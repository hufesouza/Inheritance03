using System;
using System.Threading;

namespace InheritanceC
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks everyone for the birthday wishes", true, "Hugo Ferreira");
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("Check out my new shoes by clicking on the following link", "Hugo Ferreira", "http://images.com/shoes", true);
            Console.WriteLine(imagePost1.ToString());

            VideoPost videoPost1 = new VideoPost("Check out this new video", "Hugo Ferreira", "http://video.com/post1", true, 12);
            Console.WriteLine(videoPost1.ToString());

            videoPost1.Play();
            Console.WriteLine("Press any key to stop the video!");
            Console.ReadKey();
            videoPost1.Stop();
            Console.ReadLine();


        }

    }
}
