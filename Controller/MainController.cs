using TE11Manager.DataType;
using Newtonsoft.Json;
using TE11Manager.Util;
using TE11Manager.View;
using System;

namespace TE11Manager.Controller
{
    public class MainController: Core.IController
    {

        private string tokenUser = "{\"tokenUser\":" + LocalStorage.GetItem("token") + "}";
        public Dashboard GetDashboardData()
        {
            string jsonValue = HttpRequestCommon.GetData("dashboard");
            return JsonConvert.DeserializeObject<Dashboard>(jsonValue);
        }
        /// <summary>
        /// <param datatype="[,users,user,post,schedules]".</param>
        /// </summary>
        public T GetDataWithPostMethod<T>(string datatype)
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

        public T GetData<T>(string datatype)
        {
            string jsonValue = HttpRequestCommon.GetData(datatype);
            try
            {
                return JsonConvert.DeserializeObject<T>(jsonValue);
            }
            catch (Exception e)
            {
                return default(T);
            }
        }
        public bool DeleteDataForType(string dataType, string _Id,bool isWithDeleteMethod= false)
        {
            if (HttpRequestCommon.PostDataJSON(dataType + _Id + (isWithDeleteMethod?"?_method=DELETE":""), tokenUser)!="")
                return true;
            else
            {
                return false;
            }
        }
        public bool RestoreDataForType(string dataType, string _Id)
        {
            if (HttpRequestCommon.PostDataJSON(dataType + _Id, tokenUser) != "")
                return true;
            else
            {
                return false;
            }
        }
        public bool PatchDataForType(string dataType, string _Id, string dataPatch)
        {
            //remove the last } and append tokenUser
            string dataPatchJson = dataPatch.Remove(dataPatch.Length - 1, 1)+ ",\"tokenUser\":" + LocalStorage.GetItem("token") + "}";
            if (HttpRequestCommon.PostDataJSON(dataType + _Id + "?_method=PATCH", dataPatchJson) != "")
                return true;
            else
            {
                return false;
            }
        }
        public bool PostData(string dataType, string jsonData)
        {
            //remove the last } and append tokenUser
            string dataPostJson = jsonData.Remove(jsonData.Length - 1, 1) + ",\"tokenUser\":" + LocalStorage.GetItem("token") + "}";
            if (HttpRequestCommon.PostDataJSON(dataType , dataPostJson) != "")
                return true;
            else
            {
                return false;
            }
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
