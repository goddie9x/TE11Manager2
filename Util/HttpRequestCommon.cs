using System;
using xNet;
namespace TE11Manager.Util
{
    internal static class HttpRequestCommon
    {
        private static string MainApi = "https://te11api.herokuapp.com/";
        public static string GetData(string path)
        {
            HttpRequest http = new HttpRequest();
            try
            {
                return http.Get(MainApi+ path).ToString();
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
                string result = http.Post(MainApi+path, data, contentType).ToString();
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
                return http.Post(MainApi + path, data, contentType).ToString();
            }
            catch (HttpException e)
            {
                return e.HttpStatusCode.ToString();
            }
        }
        public static HttpResponse PostDataJSONWithFullResult(string path, string data = "", string contentType = "application/json")
        {
            HttpRequest http = new HttpRequest();
            return http.Post(MainApi + path, data, contentType);
        }
    }
}
