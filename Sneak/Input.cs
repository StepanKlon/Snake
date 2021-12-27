using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sneak
{
    static class Input
    {
        private static Hashtable KeyTable = new Hashtable();

        public static void ChangeState(Keys key, bool state)
        {
            KeyTable[key] = state;
        }

        public static bool KeyPress(Keys key)
        {
            if (KeyTable[key] == null)
            {
                return false;
            }
            return (bool)KeyTable[key];
        }
        public static void ClearKeys()
        {
            KeyTable.Clear();
        }
    }
}
