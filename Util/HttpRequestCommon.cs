using System;
using System.Windows.Forms;
using xNet;
namespace TE11Manager.Util
{
    internal static class HttpRequestCommon
    {
        private static string MainApi = "https://te11api.herokuapp.com/";
        public static string GetData(string path)
        {
            Cursor.Current = Cursors.WaitCursor;
            HttpRequest http = new HttpRequest();
            try
            {
                Cursor.Current = Cursors.Default;
                return http.Get(MainApi + path).ToString();
            }
            catch (Exception e)
            {
                Cursor.Current = Cursors.Default;
                return "";
            }
        }
        public static string PostDataJSON(string path, string data = "", string contentType = "application/json")
        {
            Cursor.Current = Cursors.WaitCursor;
            HttpRequest http = new HttpRequest();
            try
            {
                string result = http.Post(MainApi + path, data, contentType).ToString();
                return result;
                Cursor.Current = Cursors.Default;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                Cursor.Current = Cursors.Default;
                return "";
            }
        }
        public static string PostDataJSONIfFalseReturnStatusCode(string path, string data = "", string contentType = "application/json")
        {
            Cursor.Current = Cursors.WaitCursor;
            HttpRequest http = new HttpRequest();
            try
            {
                return http.Post(MainApi + path, data, contentType).ToString();
                Cursor.Current = Cursors.Default;
            }
            catch (HttpException e)
            {
                return e.HttpStatusCode.ToString();
                Cursor.Current = Cursors.Default;
            }
        }
        public static HttpResponse PostDataJSONWithFullResult(string path, string data = "", string contentType = "application/json")
        {
            Cursor.Current = Cursors.WaitCursor;
            HttpRequest http = new HttpRequest();
            return http.Post(MainApi + path, data, contentType);
            Cursor.Current = Cursors.Default;
        }
    }
}
