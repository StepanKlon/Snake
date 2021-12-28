using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Services
{
    interface IDataService
    {
        public int GetTheHighestScore();
        public void WriteScore();
    }
}
