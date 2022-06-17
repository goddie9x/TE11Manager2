namespace TE11Manager.DataType
{
    #nullable enable
    public class User : Account
    {
        #region attributes
        public string _id;
        public string fullName;
        public string gender;
        public string dateOfBirth;
        public string image;
        public string[] phone;
        public string address;
        public string[] email;
        public string quote;
        public string subDescription;
        public string description;
        public int role;
        public bool deleted;
        #endregion
        #region constructor
        public User() : base()
        {
            _id = "";
            fullName = "";
            gender = "";
            dateOfBirth = "";
            image = "";
            address = "";
            quote = "";
            subDescription = "";
            description = "";
            role = 3;
            deleted = false;
        }
        public User(string _id = "",
            string fullName = "",
            string account = "",
            string gender = "",
            string dateOfBirth = "",
            string image = "",
            string address = "",
            string quote = "",
            string subDescription = "",
            string description = "",
            int role = 3,
            bool deleted = false) : base()
        {
            this._id = _id;
            this.fullName = fullName;
            this.account = account;
            this.gender = gender;
            this.dateOfBirth = dateOfBirth;
            this.image = image;
            this.address = address;
            this.quote = quote;
            this.subDescription = subDescription;
            this.description = description;
            this.role = role;
            this.deleted = deleted;
        }
        #endregion
        #region methods
        #endregion
    }
}
