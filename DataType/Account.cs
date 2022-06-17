namespace TE11Manager.DataType
{
    public class Account
    {
#nullable enable
        #region attributes
        public string account;
        public string email;
        private string password;
        #endregion
        #region constructor
        public Account()
        {
            account = "";
            email = "";
            password = "";
        }
        public Account(string account = "", string password = "", string email = "")
        {
            this.account = account;
            this.password = password;
            this.email = email;
        }
        #endregion
        #region methods
        public string ToJSONForLogin()
        {
            string json = "{\"account\":\"" + account + "\",\"password\":\"" + password + "\"}";
            return json;
        }
        public string ToJSONForRegister()
        {
            string json = "{\"account\":\"" + account + "\",\"password\":\"" + password + "\",\"email\":[\"" + email + "\"]}";
            return json;
        }
        #endregion
    }
}
