using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sneak
{
    abstract class Entity
    {
        public Location Location { get; set; }
        public string Color { get; set; }
    }
}
