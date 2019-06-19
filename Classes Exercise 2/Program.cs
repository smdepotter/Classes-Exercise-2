using System;

namespace Classes_Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post();
            post.UpVote();
            post.UpVote();
            post.DownVote();


            Console.WriteLine(post.VoteValue);
        }
    }
}
