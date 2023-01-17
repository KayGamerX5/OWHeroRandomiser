namespace OW_Hero_Randomiser
{
    partial class TwoPlayerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.PlayerOneNameBox = new System.Windows.Forms.TextBox();
            this.PlayerTwoNameBox = new System.Windows.Forms.TextBox();
            this.PlayerOneLabel = new System.Windows.Forms.Label();
            this.PlayerTwoLabel = new System.Windows.Forms.Label();
            this.RandomiseButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter players\' names here:";
            // 
            // PlayerOneNameBox
            // 
            this.PlayerOneNameBox.Location = new System.Drawing.Point(48, 44);
            this.PlayerOneNameBox.Name = "PlayerOneNameBox";
            this.PlayerOneNameBox.Size = new System.Drawing.Size(144, 23);
            this.PlayerOneNameBox.TabIndex = 1;
            // 
            // PlayerTwoNameBox
            // 
            this.PlayerTwoNameBox.Location = new System.Drawing.Point(48, 73);
            this.PlayerTwoNameBox.Name = "PlayerTwoNameBox";
            this.PlayerTwoNameBox.Size = new System.Drawing.Size(144, 23);
            this.PlayerTwoNameBox.TabIndex = 2;
            // 
            // PlayerOneLabel
            // 
            this.PlayerOneLabel.AutoSize = true;
            this.PlayerOneLabel.Location = new System.Drawing.Point(198, 47);
            this.PlayerOneLabel.Name = "PlayerOneLabel";
            this.PlayerOneLabel.Size = new System.Drawing.Size(0, 15);
            this.PlayerOneLabel.TabIndex = 3;
            // 
            // PlayerTwoLabel
            // 
            this.PlayerTwoLabel.AutoSize = true;
            this.PlayerTwoLabel.Location = new System.Drawing.Point(198, 81);
            this.PlayerTwoLabel.Name = "PlayerTwoLabel";
            this.PlayerTwoLabel.Size = new System.Drawing.Size(0, 15);
            this.PlayerTwoLabel.TabIndex = 4;
            // 
            // RandomiseButton
            // 
            this.RandomiseButton.Location = new System.Drawing.Point(48, 102);
            this.RandomiseButton.Name = "RandomiseButton";
            this.RandomiseButton.Size = new System.Drawing.Size(75, 23);
            this.RandomiseButton.TabIndex = 5;
            this.RandomiseButton.Text = "Randomise";
            this.RandomiseButton.UseVisualStyleBackColor = true;
            this.RandomiseButton.Click += new System.EventHandler(this.RandomiseButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(395, 102);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // TwoPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 152);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.RandomiseButton);
            this.Controls.Add(this.PlayerTwoLabel);
            this.Controls.Add(this.PlayerOneLabel);
            this.Controls.Add(this.PlayerTwoNameBox);
            this.Controls.Add(this.PlayerOneNameBox);
            this.Controls.Add(this.label1);
            this.Name = "TwoPlayerForm";
            this.Text = "TwoPlayerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox PlayerOneNameBox;
        private TextBox PlayerTwoNameBox;
        private Label PlayerOneLabel;
        private Label PlayerTwoLabel;
        private Button RandomiseButton;
        private Button BackButton;
    }
}