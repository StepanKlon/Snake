using Sneak.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sneak
{
    public partial class GameForm : Form
    {
        List<Entity> Sneak { get; set; }
        Entity Food { get; set; }
        OptionsForm OptionsForm { get; set; }
        IDataService DataService { get; set; }
        public GameForm()
        {
            DataService = new FileService();
            InitializeComponent();
            gameTimer.Interval = 1000 / Settings.speed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();
            StartGame();
        }

        private void StartGame()
        {
            GameOverLabel.Visible = false;
            ScoreNum.Text = "0";
            BestScoreNum.Text = Settings.topScore.ToString();
            Sneak = new List<Entity>();
            Head head = new Head(new Location { X = 5, Y = 5 });
            Sneak.Add(head);
            CreateFood();
        }

        private void CreateFood()
        {
            var maxWidth = pbCanvas.Size.Width / Settings.size;
            var maxHeight = pbCanvas.Size.Height / Settings.size;
            Random rnd = new Random();
            Food = new Food(new Location { X = rnd.Next(0,maxWidth), Y = rnd.Next(0,maxHeight) });
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            if (Settings.fail)
            {
                if (Input.KeyPress(Keys.Enter))
                {
                    DataService.WriteScore();
                    InitialForm init = new InitialForm();
                    init.Show();
                    this.Hide();
                }
            }
            else
            {
                if (Input.KeyPress(Keys.Right) && Settings.movement != Movement.LEFT)
                {
                    Settings.movement = Movement.RIGHT;
                }
                else if (Input.KeyPress(Keys.Left) && Settings.movement != Movement.RIGHT)
                {
                    Settings.movement = Movement.LEFT;
                }
                else if (Input.KeyPress(Keys.Up) && Settings.movement != Movement.DOWN)
                {
                    Settings.movement = Movement.UP;
                }
                else if (Input.KeyPress(Keys.Down) && Settings.movement != Movement.UP)
                {
                    Settings.movement = Movement.DOWN;
                }
                Move();
            }
            pbCanvas.Invalidate();
        }

        private void Move()
        {
            // doplnit move metodu, eat, die metodu
            throw new NotImplementedException();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode,true);
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }

        private void UpdateGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            if (!Settings.fail)
            {
                Brush snakeColour;
                for (int i = 0; i < Sneak.Count; i++)
                {
                    if (i==0)
                    {
                        snakeColour = Brushes.Yellow;
                    }
                    else
                    {
                        switch (Settings.color)
                        {
                            case "Red":
                                snakeColour = Brushes.Red;
                                break;
                            case "Blue":
                                snakeColour = Brushes.Blue;
                                break;
                            case "Green":
                                snakeColour = Brushes.Green;
                                break;
                            default:
                                snakeColour = Brushes.Blue;
                                break;
                        }
                    }
                    canvas.FillEllipse(snakeColour,
                        new Rectangle(Sneak[i].Location.X * Settings.size,
                        Sneak[i].Location.Y * Settings.size,
                        Settings.size,
                        Settings.size));
                }
                canvas.FillEllipse(Brushes.OrangeRed,
                    new Rectangle(Food.Location.X * Settings.size,
                    Food.Location.Y * Settings.size,
                    Settings.size,
                    Settings.size));
            }
            else
            {
                GameOverLabel.Text = $"Game over! Your score is {Settings.score}";
                GameOverLabel.Visible = true;
            }
        }
    }
}
