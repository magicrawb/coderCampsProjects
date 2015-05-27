using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace PlayMovieQuotesHW1
{
    class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer words = new SoundPlayer(@"C:\CoderCampsProjects\coderCampsProjects\PlayMovieQuotesHW1\PlayMovieQuotesHW1\dead_poets_ideas.wav");
            SoundPlayer aladdin = new SoundPlayer(@"C:\CoderCampsProjects\coderCampsProjects\PlayMovieQuotesHW1\PlayMovieQuotesHW1\aladdin_outta_here.wav");
            SoundPlayer vietnam = new SoundPlayer(@"C:\CoderCampsProjects\coderCampsProjects\PlayMovieQuotesHW1\PlayMovieQuotesHW1\good_morning.wav");
            Random rdm = new Random();
            int randomNumber = rdm.Next(1, 4);
            switch (randomNumber)
            {
                case 1:
                    words.PlaySync();
                    break;
                case 2:
                    aladdin.PlaySync();
                    break;
                case 3:
                    vietnam.PlaySync();
                    break;
            }
        }
    }
}
