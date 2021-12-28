
namespace Snake
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.ScoreNum = new System.Windows.Forms.Label();
            this.BestScoreLabel = new System.Windows.Forms.Label();
            this.BestScoreNum = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.GameOverLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbCanvas.Location = new System.Drawing.Point(12, 30);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(640, 480);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdateGraphics);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ScoreLabel.Location = new System.Drawing.Point(12, 6);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(56, 21);
            this.ScoreLabel.TabIndex = 1;
            this.ScoreLabel.Text = "Score:";
            // 
            // ScoreNum
            // 
            this.ScoreNum.AutoSize = true;
            this.ScoreNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ScoreNum.Location = new System.Drawing.Point(64, 6);
            this.ScoreNum.Name = "ScoreNum";
            this.ScoreNum.Size = new System.Drawing.Size(19, 21);
            this.ScoreNum.TabIndex = 2;
            this.ScoreNum.Text = "0";
            // 
            // BestScoreLabel
            // 
            this.BestScoreLabel.AutoSize = true;
            this.BestScoreLabel.BackColor = System.Drawing.SystemColors.Control;
            this.BestScoreLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BestScoreLabel.ForeColor = System.Drawing.Color.Green;
            this.BestScoreLabel.Location = new System.Drawing.Point(157, 6);
            this.BestScoreLabel.Name = "BestScoreLabel";
            this.BestScoreLabel.Size = new System.Drawing.Size(90, 21);
            this.BestScoreLabel.TabIndex = 3;
            this.BestScoreLabel.Text = "Best score:";
            // 
            // BestScoreNum
            // 
            this.BestScoreNum.AutoSize = true;
            this.BestScoreNum.BackColor = System.Drawing.SystemColors.Control;
            this.BestScoreNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BestScoreNum.ForeColor = System.Drawing.Color.Green;
            this.BestScoreNum.Location = new System.Drawing.Point(243, 6);
            this.BestScoreNum.Name = "BestScoreNum";
            this.BestScoreNum.Size = new System.Drawing.Size(19, 21);
            this.BestScoreNum.TabIndex = 4;
            this.BestScoreNum.Text = "0";
            // 
            // GameOverLabel
            // 
            this.GameOverLabel.AutoSize = true;
            this.GameOverLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.GameOverLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GameOverLabel.Location = new System.Drawing.Point(27, 252);
            this.GameOverLabel.Name = "GameOverLabel";
            this.GameOverLabel.Size = new System.Drawing.Size(148, 32);
            this.GameOverLabel.TabIndex = 5;
            this.GameOverLabel.Text = "Game Over!";
            this.GameOverLabel.Visible = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 511);
            this.Controls.Add(this.GameOverLabel);
            this.Controls.Add(this.BestScoreNum);
            this.Controls.Add(this.BestScoreLabel);
            this.Controls.Add(this.ScoreNum);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.pbCanvas);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Shown += new System.EventHandler(this.ShowGame);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label ScoreNum;
        private System.Windows.Forms.Label BestScoreLabel;
        private System.Windows.Forms.Label BestScoreNum;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label GameOverLabel;
    }
}