namespace TE11Manager.DataType
{
    public class Post
    {
#nullable enable
        #region Properties
        private string _id;
        private string author;
        private string authorAvatar;
        private string authorQuote;
        private string authorId;
        private string title;
        private string description;
        private string content;
        private string headingList;
        private string slug;
        private string[] tag;
        private int type;
        private int publicType;
        private bool deleted;
        #endregion
        #region Getter and Setter
        public string Id
        {
            get => _id;
            set => _id = value;
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string AuthorAvatar
        {
            get { return authorAvatar; }
            set { authorAvatar = value; }
        }
        public string AuthorQuote
        {
            get { return authorQuote; }
            set { authorQuote = value; }
        }
        public string AuthorId
        {
            get { return authorId; }
            set { authorId = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        public string HeadingList
        {
            get { return headingList; }
            set { headingList = value; }
        }
        public string Slug
        {
            get { return slug; }
            set { slug = value; }
        }
        public string[] Tag
        {
            get { return tag; }
            set { tag = value; }
        }
        public int Type
        {
            get { return type; }
            set { type = value; }
        }
        public int PublicType
        {
            get { return publicType; }
            set { publicType = value; }
        }
        public bool Deleted
        {
            get { return deleted; }
            set { deleted = value; }
        }
        #endregion
        #region Constructor
        public Post()
        {
            _id = "";
            author = "";
            authorAvatar = "";
            authorQuote = "";
            authorId = "";
            title = "";
            description = "";
            content = "";
            headingList = "";
            slug = "";
            type = 0;
            publicType = 0;
            deleted = false;
        }
        public Post(
            string _id,
            string authorId,
            string title, string description,
            string slug, string author = "",
            string content = "",
            string authorAvatar = "",
            string authorQuote = "",
            string headingList = "",
            int type = 0,
            int publicType = 0,
            bool deleted = false)
        {
            this.author = author;
            this.authorAvatar = authorAvatar;
            this.authorQuote = authorQuote;
            this.authorId = authorId;
            this.title = title;
            this.description = description;
            this.content = content;
            this.headingList = headingList;
            this.slug = slug;
            this.type = type;
            this.publicType = publicType;
            this.deleted = deleted;
        }
        #endregion
        #region Methods
        public string ToJSON()
        {
            string json = "{";
            json += "\"author\":\"" + author + "\",";
            json += "\"authorAvatar\":\"" + authorAvatar + "\",";
            json += "\"authorQuote\":\"" + authorQuote + "\",";
            json += "\"authorId\":\"" + authorId + "\",";
            json += "\"title\":\"" + title + "\",";
            json += "\"description\":\"" + description + "\",";
            json += "\"content\":\"" + content + "\",";
            json += "\"headingList\":\"" + headingList + "\",";
            json += "\"slug\":\"" + slug + "\",";
            json += "\"tag\":[";
            for (int i = 0; i < tag.Length; i++)
            {
                json += "\"" + tag[i] + "\"";
                if (i != tag.Length - 1)
                    json += ",";
            }
            json += "],";
            json += "\"type\":" + type + ",";
            json += "\"publicType\":" + publicType + ",";
            json += "\"deleted\":" + deleted;
            json += "}";
            return json;
        }
        #endregion
    }
}
