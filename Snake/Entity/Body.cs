﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Body : Entity
    {
        public Body(Location location) : base(location)
        {
            Location = location;
        }
    }
}
