using System;
namespace InheritanceC
{
    //Image Post derives from Post and Add a property (ImageURL) and two constructor
    public class ImagePost:Post
    {
        public string ImageURL { get; set; }
        public ImagePost() { }
        public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic)
        {
            // the following properties and the GetNextID method are inherited from POST(parent class).
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
            //The Property ImageURLis a member of ImagePost, but not of Post.
            this.ImageURL = imageURL;

        }
        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - {this.ImageURL} - by {this.SendByUsername}");
        }
    
    }
}
