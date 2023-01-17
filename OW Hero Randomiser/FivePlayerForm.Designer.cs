namespace OW_Hero_Randomiser
{
    partial class FivePlayerForm
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
            this.PlayerThreeNameBox = new System.Windows.Forms.TextBox();
            this.PlayerFourNameBox = new System.Windows.Forms.TextBox();
            this.PlayerFiveNameBox = new System.Windows.Forms.TextBox();
            this.RandomiseButton = new System.Windows.Forms.Button();
            this.PlayerOneNameLabel = new System.Windows.Forms.Label();
            this.PlayerTwoNameLabel = new System.Windows.Forms.Label();
            this.PlayerThreeNameLabel = new System.Windows.Forms.Label();
            this.PlayerFourNameLabel = new System.Windows.Forms.Label();
            this.PlayerFiveNameLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter players\' names here:";
            // 
            // PlayerOneNameBox
            // 
            this.PlayerOneNameBox.Location = new System.Drawing.Point(35, 44);
            this.PlayerOneNameBox.Name = "PlayerOneNameBox";
            this.PlayerOneNameBox.Size = new System.Drawing.Size(144, 23);
            this.PlayerOneNameBox.TabIndex = 1;
            // 
            // PlayerTwoNameBox
            // 
            this.PlayerTwoNameBox.Location = new System.Drawing.Point(35, 73);
            this.PlayerTwoNameBox.Name = "PlayerTwoNameBox";
            this.PlayerTwoNameBox.Size = new System.Drawing.Size(144, 23);
            this.PlayerTwoNameBox.TabIndex = 2;
            // 
            // PlayerThreeNameBox
            // 
            this.PlayerThreeNameBox.Location = new System.Drawing.Point(35, 102);
            this.PlayerThreeNameBox.Name = "PlayerThreeNameBox";
            this.PlayerThreeNameBox.Size = new System.Drawing.Size(144, 23);
            this.PlayerThreeNameBox.TabIndex = 3;
            // 
            // PlayerFourNameBox
            // 
            this.PlayerFourNameBox.Location = new System.Drawing.Point(35, 131);
            this.PlayerFourNameBox.Name = "PlayerFourNameBox";
            this.PlayerFourNameBox.Size = new System.Drawing.Size(144, 23);
            this.PlayerFourNameBox.TabIndex = 4;
            // 
            // PlayerFiveNameBox
            // 
            this.PlayerFiveNameBox.Location = new System.Drawing.Point(35, 160);
            this.PlayerFiveNameBox.Name = "PlayerFiveNameBox";
            this.PlayerFiveNameBox.Size = new System.Drawing.Size(144, 23);
            this.PlayerFiveNameBox.TabIndex = 5;
            // 
            // RandomiseButton
            // 
            this.RandomiseButton.Location = new System.Drawing.Point(35, 189);
            this.RandomiseButton.Name = "RandomiseButton";
            this.RandomiseButton.Size = new System.Drawing.Size(75, 23);
            this.RandomiseButton.TabIndex = 6;
            this.RandomiseButton.Text = "Randomise";
            this.RandomiseButton.UseVisualStyleBackColor = true;
            this.RandomiseButton.Click += new System.EventHandler(this.RandomiseButton_Click);
            // 
            // PlayerOneNameLabel
            // 
            this.PlayerOneNameLabel.AutoSize = true;
            this.PlayerOneNameLabel.Location = new System.Drawing.Point(185, 47);
            this.PlayerOneNameLabel.Name = "PlayerOneNameLabel";
            this.PlayerOneNameLabel.Size = new System.Drawing.Size(38, 15);
            this.PlayerOneNameLabel.TabIndex = 7;
            this.PlayerOneNameLabel.Text = "label2";
            // 
            // PlayerTwoNameLabel
            // 
            this.PlayerTwoNameLabel.AutoSize = true;
            this.PlayerTwoNameLabel.Location = new System.Drawing.Point(185, 76);
            this.PlayerTwoNameLabel.Name = "PlayerTwoNameLabel";
            this.PlayerTwoNameLabel.Size = new System.Drawing.Size(38, 15);
            this.PlayerTwoNameLabel.TabIndex = 8;
            this.PlayerTwoNameLabel.Text = "label3";
            // 
            // PlayerThreeNameLabel
            // 
            this.PlayerThreeNameLabel.AutoSize = true;
            this.PlayerThreeNameLabel.Location = new System.Drawing.Point(185, 105);
            this.PlayerThreeNameLabel.Name = "PlayerThreeNameLabel";
            this.PlayerThreeNameLabel.Size = new System.Drawing.Size(38, 15);
            this.PlayerThreeNameLabel.TabIndex = 9;
            this.PlayerThreeNameLabel.Text = "label4";
            // 
            // PlayerFourNameLabel
            // 
            this.PlayerFourNameLabel.AutoSize = true;
            this.PlayerFourNameLabel.Location = new System.Drawing.Point(185, 134);
            this.PlayerFourNameLabel.Name = "PlayerFourNameLabel";
            this.PlayerFourNameLabel.Size = new System.Drawing.Size(38, 15);
            this.PlayerFourNameLabel.TabIndex = 10;
            this.PlayerFourNameLabel.Text = "label5";
            // 
            // PlayerFiveNameLabel
            // 
            this.PlayerFiveNameLabel.AutoSize = true;
            this.PlayerFiveNameLabel.Location = new System.Drawing.Point(185, 163);
            this.PlayerFiveNameLabel.Name = "PlayerFiveNameLabel";
            this.PlayerFiveNameLabel.Size = new System.Drawing.Size(38, 15);
            this.PlayerFiveNameLabel.TabIndex = 11;
            this.PlayerFiveNameLabel.Text = "label6";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(421, 189);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 12;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // FivePlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 235);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.PlayerFiveNameLabel);
            this.Controls.Add(this.PlayerFourNameLabel);
            this.Controls.Add(this.PlayerThreeNameLabel);
            this.Controls.Add(this.PlayerTwoNameLabel);
            this.Controls.Add(this.PlayerOneNameLabel);
            this.Controls.Add(this.RandomiseButton);
            this.Controls.Add(this.PlayerFiveNameBox);
            this.Controls.Add(this.PlayerFourNameBox);
            this.Controls.Add(this.PlayerThreeNameBox);
            this.Controls.Add(this.PlayerTwoNameBox);
            this.Controls.Add(this.PlayerOneNameBox);
            this.Controls.Add(this.label1);
            this.Name = "FivePlayerForm";
            this.Text = "FivePlayerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox PlayerOneNameBox;
        private TextBox PlayerTwoNameBox;
        private TextBox PlayerThreeNameBox;
        private TextBox PlayerFourNameBox;
        private TextBox PlayerFiveNameBox;
        private Button RandomiseButton;
        private Label PlayerOneNameLabel;
        private Label PlayerTwoNameLabel;
        private Label PlayerThreeNameLabel;
        private Label PlayerFourNameLabel;
        private Label PlayerFiveNameLabel;
        private Button BackButton;
    }
}