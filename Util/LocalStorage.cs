using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TE11Manager.Util
{
    internal static class LocalStorage
    {
        private static readonly string localFilePath = "min_db.db";
        public static void RemoveBracesFirstAndEnd(ref string target)
        {
            target = target.Trim();
            target = target.Substring(1, target.Length - 2);
        }

        public static void AddBracesFirstAndEnd(ref string target)
        {
            target = "{" + target + "}";
        }
        public static string GetItem(string key, bool containValue = false)
        {
            Cursor.Current = Cursors.WaitCursor;

            string localStore = "";
            try
            {
                localStore = File.ReadAllText(localFilePath);
            }
            //If has no file => create new file
            catch (Exception e)
            {
                File.WriteAllText(localFilePath, localStore);
                return localStore;
            }
            string pattern;
            if (containValue)
            {
                pattern = @"""" + key + @""":.*?(?=endValC#)";
            }
            else
            {
                pattern = @"(?<=""" + key + @""":).*?(?=endValC#)";
            }

            Regex reg = new Regex(pattern, RegexOptions.IgnoreCase);
            string value = reg.Match(localStore).ToString();
            if (containValue)
            {
                AddBracesFirstAndEnd(ref value);
            }
            Cursor.Current = Cursors.Default;
            return value;
        }
        public static bool SaveJSONData(string json)
        {
            Cursor.Current = Cursors.WaitCursor;

            //we never have any json string with lenght < 1
            if (json.Length < 1)
            {
                Cursor.Current = Cursors.Default;

                return false;
            }
            //{"example":"example"}=> "example":"example" endValC#
            RemoveBracesFirstAndEnd(ref json);
            string stringRemovedCurlyBracesFirstAndEnd = json + "endValC#";
            string[] listKeyValue = stringRemovedCurlyBracesFirstAndEnd.Split(',');
            string localStore;
            try
            {
                localStore = File.ReadAllText(localFilePath);
                for (int i = 0; i < listKeyValue.Length; i++)
                {
                    string[] currentKeyValue = listKeyValue[i].Split(':');
                    string key = currentKeyValue[0];
                    string value = currentKeyValue[1];
                    string pattern = @"(?<=" + key + @":).*?(?=endValC#)";
                    if (localStore.Contains(key))
                    {
                        localStore = Regex.Replace(localStore, pattern, value);
                    }
                    else
                    {
                        localStore += listKeyValue[i] + "endValC#";
                    }
                }
                File.WriteAllText(localFilePath, localStore);
            }
            catch (Exception ex)
            {
                File.WriteAllText(localFilePath, stringRemovedCurlyBracesFirstAndEnd);
            }
            Cursor.Current = Cursors.Default;

            return true;
        }
        public static void RemoveItem(string key)
        {
            Cursor.Current = Cursors.WaitCursor;

            string localStore = File.ReadAllText(localFilePath);
            string pattern = @"^""" + key + @""":.*?endValC#*?$";

            localStore = Regex.Replace(localStore, pattern, "");
            File.WriteAllText(localFilePath, localStore);
            Cursor.Current = Cursors.Default;
        }
    }
}
