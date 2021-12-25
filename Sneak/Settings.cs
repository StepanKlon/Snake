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
    static class Settings
    {
        public static int speed = 20;
        public static int points = 100;
        public static int score = 0;
        public static int topScore = findTopScore();
        public static Movement movement = Movement.DOWN;
        public static int size = 16;
        public static string color = "Blue";
        public static bool fail = false;

        private static int findTopScore()
        {
            IDataService service = new FileService();
            return service.GetTheHighestScore();
        }
    }
}
