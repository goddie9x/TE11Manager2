using System.Collections.Generic;

namespace TE11Manager.DataType
{
    public class Schedules
    {
        public int countCurrentStored;
        public int countOpositeStored;
        public List<Schedule> schedules;
        public Schedules()
        {
            countCurrentStored = 0;
            countOpositeStored = 0;
            schedules = new List<Schedule>();
        }
        public Schedules(int countCurrentStored, int countOpositeStored, List<Schedule> schedules)
        {
            this.countCurrentStored = countCurrentStored;
            this.countOpositeStored = countOpositeStored;
            this.schedules = schedules;
        }
    }
}
