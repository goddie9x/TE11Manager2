namespace TE11Manager.DataType
{
    public class Schedule
    {
    #nullable enable
        #region attributes
        private string _id;
        private string name;
        private string room;
        private string time;
        private string[] linkMeet;
        private string[] linkClass;
        private int type;
        private int dayOfWeek;
        private int partOfDay;
        private int dayStart;
        private int dayEnd;
        private bool deleted;
        public string Id { get { return _id; } set { _id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Room { get { return room; } set { room = value; } }
        public string Time { get { return time; } set { time = value; } }
        public string[] LinkMeet { get { return linkMeet; } set { linkMeet = value; } }
        public string[] LinkClass { get { return linkClass; } set { linkClass = value; } }
        public int Type { get { return type; } set { type = value; } }
        public int DayOfWeek { get { return dayOfWeek; } set { dayOfWeek = value; } }
        public int PartOfDay { get { return partOfDay; } set { partOfDay = value; } }
        public int DayStart { get { return dayStart; } set { dayStart = value; } }
        public int DayEnd { get { return dayEnd; } set { dayEnd = value; } }
        public bool Deleted { get { return deleted; } set { deleted = value; } }
        #endregion
        #region constructor
        public Schedule() 
        {
            _id = "";
            name = "";
            room = "";
            time = "";
            linkMeet = new string[0];
            linkClass = new string[0];
            type = 0;
            dayOfWeek = 0;
            partOfDay = 0;
            dayStart = 0;
            dayEnd = 0;
            deleted = false;
        }
        public Schedule(string _id = "",
            string name = "",
            string room = "",
            string time = "",
            string[] linkMeet = null,
            string[] linkClass = null,
            int type = 0,
            int dayOfWeek = 0,
            int partOfDay = 0,
            int dayStart = 0,
            int dayEnd = 0,
            bool deleted = false)
        {
            this._id = _id;
            this.name = name;
            this.room = room;
            this.time = time;
            this.linkMeet = linkMeet;
            this.linkClass = linkClass;
            this.type = type;
            this.dayOfWeek = dayOfWeek;
            this.partOfDay = partOfDay;
            this.dayStart = dayStart;
            this.dayEnd = dayEnd;
            this.deleted = deleted;
        }
        #endregion
        #region methods
        public string ToJson()
        {
            string json = "{";
            json += "\"_id\":\"" + _id + "\",";
            json += "\"name\":\"" + name + "\",";
            json += "\"room\":\"" + room + "\",";
            json += "\"time\":\"" + time + "\",";
            json += "\"linkMeet\":[";
            for (int i = 0; i < linkMeet.Length; i++)
            {
                json += "\"" + linkMeet[i] + "\"";
                if (i != linkMeet.Length - 1)
                    json += ",";
            }
            json += "],";
            json += "\"linkClass\":[";
            for (int i = 0; i < linkClass.Length; i++)
            {
                json += "\"" + linkClass[i] + "\"";
                if (i != linkClass.Length - 1)
                    json += ",";
            }
            json += "],";
            json += "\"type\":" + type + ",";
            json += "\"dayOfWeek\":" + dayOfWeek + ",";
            json += "\"partOfDay\":" + partOfDay + ",";
            json += "\"dayStart\":" + dayStart + ",";
            json += "\"dayEnd\":" + dayEnd + ",";
            json += "\"deleted\":" + deleted;
            json += "}";
            return json;
        }
        #endregion
    }
}
