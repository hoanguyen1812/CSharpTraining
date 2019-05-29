using System;

namespace Exercise
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var stopwatch = new StopWatch();
            stopwatch.Start();

            Console.WriteLine("Input Title post");
            var title = Console.ReadLine();
            Console.WriteLine("Input Description post");
            var description = Console.ReadLine();

            var post = new Posts(title, description);
            Console.WriteLine("Your post has been created");
            while (true)
            {
                Console.WriteLine("Up-vote the post with Y and down-vote with N and E to exit");
                var vote = Console.ReadLine();
                if (vote == "Y")
                    post.UpVote();
                else if (vote == "N")
                    post.DownVote();
                else if(string.IsNullOrEmpty(vote))
                    continue;
                else if(vote == "E")
                    break;
            }

            Console.WriteLine("Total vote: {0}", post.Votes);
        }
    }
}