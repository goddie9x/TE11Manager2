using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace TE11Manager.Util
{
    internal static class JSONParse
    {
        public static string getItemFromJSON(string json, string itemName)
        {
            string item = "";
            try
            {
                JObject jObject = JObject.Parse(json);
                item = jObject[itemName].ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return item;
        }
        public static T getItemFromJSON<T>(string json, string itemName)
        {
            T item = default(T);
            try
            {
                JObject jObject = JObject.Parse(json);
                item = jObject[itemName].ToObject<T>();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return item;
        }
        public static string convertStringToJson<T>(T customObject)
        {
            string json = "";
            try
            {
                json = JsonConvert.SerializeObject(customObject);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return json;
        }
    }
}
