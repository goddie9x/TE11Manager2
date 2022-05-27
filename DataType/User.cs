namespace TE11Manager.DataType
{
    #nullable enable
    public class User : Account
    {
        #region attributes
        private string _id;
        private string gender;
        private string dateOfBirth;
        private string image;
        private string[] phone;
        private string address;
        private string[] email;
        private string quote;
        private string subDescription;
        private string description;
        private int role;
        private bool deleted;
        public string Id { get { return _id; } set { _id = value; } }
        public string Gender { get { return gender; } set { gender = value; } }
        public string DateOfBirth { get { return dateOfBirth; } set { dateOfBirth = value; } }
        public string Image { get { return image; } set { image = value; } }
        public string[] Phone { get { return phone; } set { phone = value; } }
        public string[] Email { get { return email; } set { email = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string Quote { get { return quote; } set { quote = value; } }
        public string SubDescription { get { return subDescription; } set { subDescription = value; } }
        public string Description { get { return description; } set { description = value; } }
        public int Role { get { return role; } set { role = value; } }
        public bool Deleted { get { return deleted; } set { deleted = value; } }
        #endregion
        #region constructor
        public User() : base()
        {
            _id = "";
            gender = "";
            dateOfBirth = "";
            image = "";
            phone = new string[4];
            email = new string[4];
            address = "";
            quote = "";
            subDescription = "";
            description = "";
            role = 3;
            deleted = false;
        }
        public User(string _id = "",
            string account = "",
            string gender = "",
            string dateOfBirth = "",
            string image = "",
            string password = "",
            string address = "",
            string quote = "",
            string subDescription = "",
            string description = "",
            int role = 3,
            bool deleted = false)
        {
            this._id = _id;
            this.account = account;
            this.gender = gender;
            this.dateOfBirth = dateOfBirth;
            this.image = image;
            this.password = password;
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
