
namespace Snake
{
    partial class OptionsForm
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
            this.Speed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SpeedCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.ColorCheckedBoxList = new System.Windows.Forms.CheckedListBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Speed
            // 
            this.Speed.AutoSize = true;
            this.Speed.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Speed.Location = new System.Drawing.Point(189, 70);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(77, 25);
            this.Speed.TabIndex = 0;
            this.Speed.Text = "Speed: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(133, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sneak color:";
            // 
            // SpeedCheckListBox
            // 
            this.SpeedCheckListBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SpeedCheckListBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SpeedCheckListBox.FormattingEnabled = true;
            this.SpeedCheckListBox.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.SpeedCheckListBox.Location = new System.Drawing.Point(272, 70);
            this.SpeedCheckListBox.Name = "SpeedCheckListBox";
            this.SpeedCheckListBox.Size = new System.Drawing.Size(120, 88);
            this.SpeedCheckListBox.TabIndex = 2;
            // 
            // ColorCheckedBoxList
            // 
            this.ColorCheckedBoxList.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ColorCheckedBoxList.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ColorCheckedBoxList.FormattingEnabled = true;
            this.ColorCheckedBoxList.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Green"});
            this.ColorCheckedBoxList.Location = new System.Drawing.Point(272, 184);
            this.ColorCheckedBoxList.Name = "ColorCheckedBoxList";
            this.ColorCheckedBoxList.Size = new System.Drawing.Size(120, 88);
            this.ColorCheckedBoxList.TabIndex = 4;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackButton.Location = new System.Drawing.Point(146, 310);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(120, 49);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.GetBack);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.StartButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartButton.Location = new System.Drawing.Point(272, 310);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(120, 49);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.GetStart);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(664, 511);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ColorCheckedBoxList);
            this.Controls.Add(this.SpeedCheckListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Speed);
            this.Name = "OptionsForm";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Speed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox SpeedCheckListBox;
        private System.Windows.Forms.CheckedListBox ColorCheckedBoxList;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button StartButton;
    }
}