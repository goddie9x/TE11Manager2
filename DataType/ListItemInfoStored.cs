using System.Collections.Generic;

namespace TE11Manager.DataType
{
    public class ListItemInfoStored<T>
    {
        public int countCurrentStored;
        public int countOpositeStored;
        public List<T> schedules;
        public ListItemInfoStored()
        {
            countCurrentStored = 0;
            countOpositeStored = 0;
            schedules = new List<T>();
        }
        public ListItemInfoStored(int countCurrentStored, int countOpositeStored, List<T> schedules)
        {
            this.countCurrentStored = countCurrentStored;
            this.countOpositeStored = countOpositeStored;
            this.schedules = schedules;
        }
    }
}
