
namespace Snake
{
    partial class InitialForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitialForm));
            this.Title = new System.Windows.Forms.Label();
            this.SubTitle = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.OptionsButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(221, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(172, 37);
            this.Title.TabIndex = 0;
            this.Title.Text = "Sneak game";
            // 
            // SubTitle
            // 
            this.SubTitle.AutoSize = true;
            this.SubTitle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SubTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.SubTitle.Location = new System.Drawing.Point(194, 46);
            this.SubTitle.Name = "SubTitle";
            this.SubTitle.Size = new System.Drawing.Size(235, 19);
            this.SubTitle.TabIndex = 1;
            this.SubTitle.Text = "Welcome and enjoy the game :)";
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.StartButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartButton.Location = new System.Drawing.Point(221, 92);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(172, 60);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.GetStart);
            // 
            // OptionsButton
            // 
            this.OptionsButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.OptionsButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OptionsButton.Location = new System.Drawing.Point(221, 158);
            this.OptionsButton.Name = "OptionsButton";
            this.OptionsButton.Size = new System.Drawing.Size(172, 60);
            this.OptionsButton.TabIndex = 3;
            this.OptionsButton.Text = "Options";
            this.OptionsButton.UseVisualStyleBackColor = false;
            this.OptionsButton.Click += new System.EventHandler(this.GetOptions);
            // 
            // EndButton
            // 
            this.EndButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.EndButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EndButton.Location = new System.Drawing.Point(221, 224);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(172, 60);
            this.EndButton.TabIndex = 4;
            this.EndButton.Text = "End";
            this.EndButton.UseVisualStyleBackColor = false;
            this.EndButton.Click += new System.EventHandler(this.GetEnd);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(146, 290);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 220);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // InitialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(664, 511);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.OptionsButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.SubTitle);
            this.Controls.Add(this.Title);
            this.Name = "InitialForm";
            this.Text = "Sneak Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label SubTitle;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button OptionsButton;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

