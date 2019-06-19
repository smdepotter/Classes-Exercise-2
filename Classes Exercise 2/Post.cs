using System;

namespace Classes_Exercise_2
{
    public class Post
    {
        private string _title;
        private string _description;
        private string _date;
        private string _time;
        public int VoteValue { get; private set; } = 0;

        public Post()
        {
            Console.Write("Give me a Title: ");
            _title = Console.ReadLine();
            Console.Write("Give me a description: ");
            _description = Console.ReadLine();
            _date = DateTime.Now.ToShortDateString();
            _time = DateTime.Now.ToShortTimeString();

            Console.WriteLine(@"Post: {0}
Description: {1}
Date: {2}
Time: {3}",_title, _description , _date , _time);
        }

        public void UpVote()
        {
            VoteValue++;
        }

        public void DownVote()
        {
            VoteValue--;
        }

    }
}