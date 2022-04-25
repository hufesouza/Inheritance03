using System;
using System.Threading;
using System.Threading.Tasks;

namespace InheritanceC
{
    public class VideoPost:Post
    {
        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;

        protected string VideoURL { get; set; }
        protected int Length { get; set; }

        public VideoPost() { }
        public VideoPost(string title, string sendByUsername, string videoURL, bool isPublic, int length)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;

            this.VideoURL = videoURL;
            this.Length = length;
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Is Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }

        private void TimerCallback(Object o)
        {
            if (currDuration < Length)
            {
                currDuration++;
                Console.WriteLine($"Video at {currDuration}");
                GC.Collect();
            }
        }

        public void Stop()
        {
            isPlaying = false;
            Console.WriteLine($"Video stopped at {currDuration}");
            currDuration = 0;
            timer.Dispose();

        }

        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - {this.VideoURL} - by {this.SendByUsername}- {this.Length}");
        }

    }
}
