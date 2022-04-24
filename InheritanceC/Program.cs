using System;

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
        }
    }
}
