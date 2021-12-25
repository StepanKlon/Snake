using Sneak.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sneak
{
    enum Movement
    {
        UP,
        DOWN,
        RIGHT,
        LEFT
    }
    class Settings
    {
        public IDataService DataService { get; set; }
        public static int Speed { get; set; }
        public static int Score { get; set; }
        public static int TopScore { get; set; }
        public static Movement Movement { get; set; }
        public static int Size { get; set; }

        public Settings(int speed, IDataService dataService)
        {
            DataService = dataService;
            Speed = speed;
            Score = 0;
            TopScore = DataService.GetTheHighestScore();
            Movement = Movement.DOWN;
            Size = 16;
        }
    }
}
