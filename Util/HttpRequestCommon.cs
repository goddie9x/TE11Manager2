using System;
using xNet;
namespace TE11Manager.Util
{
    internal static class HttpRequestCommon
    {
        public static string GetDataJSON(string url)
        {
            HttpRequest http = new HttpRequest();
            try
            {
                return http.Get(url).ToString();
            }
            catch (Exception e)
            {
                return "";
            }
        }
        public static string PostDataJSON(string path, string data="", string contentType = "application/json")
        {
            HttpRequest http = new HttpRequest();
            try
            {
                string result = http.Post(Program.MainApi+path, data, contentType).ToString();
                return result;
            }
            catch(Exception e)
            {
                return "";
            }
        }
        public static string PostDataJSONIfFalseReturnStatusCode(string path, string data = "", string contentType = "application/json")
        {
            HttpRequest http = new HttpRequest();
            try
            {
                return http.Post(Program.MainApi + path, data, contentType).ToString();
            }
            catch (HttpException e)
            {
                return e.HttpStatusCode.ToString();
            }
        }
        public static HttpResponse PostDataJSONWithFullResult(string path, string data = "", string contentType = "application/json")
        {
            HttpRequest http = new HttpRequest();
            return http.Post(Program.MainApi + path, data, contentType);
        }
    }
}
