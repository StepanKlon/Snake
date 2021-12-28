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
    public partial class InitialForm : Form
    {
        public InitialForm()
        {
            InitializeComponent();
        }

        private void GetOptions(object sender, EventArgs e)
        {
            OptionsForm options = new OptionsForm();
            options.Show();
            this.Hide();
        }

        private void GetStart(object sender, EventArgs e)
        {
            GameForm game = new GameForm();
            game.Show();
            game.Activate();
            this.Hide();
        }

        private void GetEnd(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
