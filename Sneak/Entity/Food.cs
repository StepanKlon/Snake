using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Food : Entity
    {
        public Food(Location location) : base(location)
        {
            Location = location;
        }
    }
}
