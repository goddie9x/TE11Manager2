using System.Collections.Generic;

namespace TE11Manager.DataType
{
    public class Users
    {
        public int countCurrentStored;
        public int countOpositeStored;
        public List<User> users;
        public Users()
        {
            countCurrentStored = 0;
            countOpositeStored = 0;
            users = new List<User>();
        }
        public Users(int countCurrentStored, int countOpositeStored, List<User> Users)
        {
            this.countCurrentStored = countCurrentStored;
            this.countOpositeStored = countOpositeStored;
            this.users = Users;
        }
    }
}
