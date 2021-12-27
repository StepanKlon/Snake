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
        }

        private void StartGame()
        {
            GameOverLabel.Visible = false;
            ScoreNum.Text = "0";
            Settings.topScore = DataService.GetTheHighestScore();
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
            if (Sneak.Count % 5 == 0)
            {
                Food = new Food(new Location { X = rnd.Next(1, maxWidth - 1), Y = rnd.Next(1, maxHeight - 1) });
            }
            else
            {
                Food = new Food(new Location { X = rnd.Next(0, maxWidth), Y = rnd.Next(0, maxHeight) });
            }
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            if (Settings.fail)
            {
                if (Input.KeyPress(Keys.Enter))
                {
                    DataService.WriteScore();
                    InitialForm init = new InitialForm();
                    Settings.score = 0;
                    gameTimer.Stop();
                    this.Hide();
                    init.Show();
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
                GetMoving();
            }
            pbCanvas.Invalidate();
        }

        private void GetMoving()
        {
            for (int i = Sneak.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.movement)
                    {
                        case Movement.UP:
                            Sneak[0].Location.Y--;
                            break;
                        case Movement.DOWN:
                            Sneak[0].Location.Y++;
                            break;
                        case Movement.RIGHT:
                            Sneak[0].Location.X++;
                            break;
                        case Movement.LEFT:
                            Sneak[0].Location.X--;
                            break;
                    }
                    for (int j = 1; j < Sneak.Count - 1; j++)
                    {
                        if (Sneak[0].Location.X == Sneak[j].Location.X && Sneak[0].Location.Y == Sneak[j].Location.Y)
                            Die();
                    }
                    if (Sneak[0].Location.X == Food.Location.X && Sneak[0].Location.Y == Food.Location.Y)
                    {
                        Eat();
                    }else if(Sneak.Count % 5 == 0)
                    {
                        var possibleX = Math.Abs(Sneak[0].Location.X - Food.Location.X);
                        var possibleY = Math.Abs(Sneak[0].Location.Y - Food.Location.Y);
                        if (possibleX <= 1 && possibleX >= 0 && possibleY <= 1 && possibleY >= 0)
                            Eat();
                    }
                    var maxWidth = pbCanvas.Size.Width / Settings.size;
                    var maxHeight = pbCanvas.Size.Height / Settings.size;
                    if (Sneak[0].Location.X > maxWidth || Sneak[0].Location.X < 0 || Sneak[0].Location.Y > maxHeight || Sneak[0].Location.Y < 0)
                        Die();
                }
                else
                {
                    Sneak[i].Location.X = Sneak[i - 1].Location.X;
                    Sneak[i].Location.Y = Sneak[i - 1].Location.Y;
                }
            }          
        }

        private void Eat()
        {
            if (Sneak.Count % 5 == 0)
            {
                Settings.score += Settings.extraPoints;
            }
            else
            {
                Settings.score += Settings.points;
            }
            Sneak.Add(new Body(new Location { X = Sneak[Sneak.Count - 1].Location.X, Y = Sneak[Sneak.Count - 1].Location.Y }));
            ScoreNum.Text = Settings.score.ToString();
            CreateFood();

        }

        private void Die()
        {
            Settings.fail = true;
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
                if (Sneak.Count % 5 == 0)
                {
                    canvas.FillEllipse(Brushes.Gold,
                    new Rectangle(Food.Location.X * Settings.size,
                    Food.Location.Y * Settings.size,
                    Settings.size * 2,
                    Settings.size * 2));
                }
                else
                {
                    canvas.FillEllipse(Brushes.OrangeRed,
                    new Rectangle(Food.Location.X * Settings.size,
                    Food.Location.Y * Settings.size,
                    Settings.size,
                    Settings.size));
                }
            }
            else
            {
                GameOverLabel.Text = $"Game over! Your score is {Settings.score}, press ENTER";
                GameOverLabel.Visible = true;
            }
        }

        private void ShowGame(object sender, EventArgs e)
        {
            Input.ClearKeys();
            Settings.fail = false;
            Settings.movement = Movement.DOWN;
            gameTimer.Interval = 1000 / Settings.speed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();
            StartGame();
        }
    }
}
