using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
            SpeedCheckListBox.MultiColumn = false;
        }

        private void GetBack(object sender, EventArgs e)
        {
            InitialForm init = new InitialForm();
            init.Show();
            this.Hide();
        }

        private void GetStart(object sender, EventArgs e)
        {
            if (SpeedCheckListBox.CheckedItems.Count != 0)
            {
                switch (SpeedCheckListBox.CheckedItems[0].ToString())
                {
                    case "Low":
                        Settings.speed = 15;
                        Settings.points = 80;
                        break;
                    case "Medium":
                        Settings.speed = 20;
                        Settings.points = 100;
                        break;
                    case "High":
                        Settings.speed = 25;
                        Settings.points = 120;
                        break;
                    default:
                        break;
                }
            }
            if (ColorCheckedBoxList.CheckedItems.Count != 0)
                 Settings.color = ColorCheckedBoxList.CheckedItems[0].ToString();
            GameForm game = new GameForm();
            game.Show();
            this.Hide();
        }
    }
}
