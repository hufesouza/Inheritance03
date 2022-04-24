using System;
namespace InheritanceC
{
    public class Post
    {
        private static int currentPostId;

        //Properties
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }

        //Default constructor. If a derived class does not invoke a base class constructor
        // explicitly, the default constructor is called implicitly.

        public Post()
        {
            ID = 0;
            Title = "My first Post";
            IsPublic = true;
            SendByUsername = "Hugo Ferreira";

        }

        // instance constructor that has three parameters

        public Post(string title, bool isPublic, string sendByUsername)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
        }

        protected int GetNextID()
        {
            return ++currentPostId;
        }

        //User should be able to update title and the condition of post publicity.
        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        //Virtual method override the ToString() method inherited from System.Object
        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - by {this.SendByUsername}");
        }
    }
}
