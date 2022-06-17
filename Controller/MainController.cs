using TE11Manager.DataType;
using Newtonsoft.Json;
using TE11Manager.Util;
using System.Collections.Generic;
using TE11Manager.View;
using System;

namespace TE11Manager.Controller
{
    public class MainController: Core.IController
    {

        private string tokenUser = "{\"tokenUser\":" + LocalStorage.GetItem("token") + "}";
        public Dashboard GetDashboardData()
        {
            string jsonValue = HttpRequestCommon.GetDataJSON("dashboard");
            return JsonConvert.DeserializeObject<Dashboard>(jsonValue);
        }
        /// <summary>
        /// <param datatype="[,users,user,post,schedules]".</param>
        /// </summary>
        public T GetData<T>(string datatype)
        {
            string jsonValue = HttpRequestCommon.PostDataJSON(datatype, tokenUser);
            try
            {
                return JsonConvert.DeserializeObject<T>(jsonValue);
            }
            catch(Exception e)
            {
                return default(T);
            }
        }
        public void UpdateDataForType(string dataType)
        {
           
        }
        public bool DeleteDataForType(string dataType, string _Id)
        {
            if (HttpRequestCommon.PostDataJSON(dataType + _Id + "?_method=DELETE", tokenUser)!="")
                return true;
            else
            {
                return false;
            }
        }
        public void AddDataDataForType(string dataType)
        {
           
        }
        public void Logout()
        {
            LocalStorage.RemoveItem("token");
            FormLogin.user = null;
        }
        public void Start()
        {
        }
    }
}
