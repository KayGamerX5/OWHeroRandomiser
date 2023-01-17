namespace OW_Hero_Randomiser
{
    partial class FourPlayerForm
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
            this.PlayerOneNameLabel = new System.Windows.Forms.Label();
            this.PlayerTwoNameLabel = new System.Windows.Forms.Label();
            this.PlayerThreeNameLabel = new System.Windows.Forms.Label();
            this.PlayerFourNameLabel = new System.Windows.Forms.Label();
            this.RandomiseButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter players\' names here:";
            // 
            // PlayerOneNameBox
            // 
            this.PlayerOneNameBox.Location = new System.Drawing.Point(35, 51);
            this.PlayerOneNameBox.Name = "PlayerOneNameBox";
            this.PlayerOneNameBox.Size = new System.Drawing.Size(100, 23);
            this.PlayerOneNameBox.TabIndex = 1;
            // 
            // PlayerTwoNameBox
            // 
            this.PlayerTwoNameBox.Location = new System.Drawing.Point(35, 80);
            this.PlayerTwoNameBox.Name = "PlayerTwoNameBox";
            this.PlayerTwoNameBox.Size = new System.Drawing.Size(100, 23);
            this.PlayerTwoNameBox.TabIndex = 2;
            // 
            // PlayerThreeNameBox
            // 
            this.PlayerThreeNameBox.Location = new System.Drawing.Point(35, 109);
            this.PlayerThreeNameBox.Name = "PlayerThreeNameBox";
            this.PlayerThreeNameBox.Size = new System.Drawing.Size(100, 23);
            this.PlayerThreeNameBox.TabIndex = 3;
            // 
            // PlayerFourNameBox
            // 
            this.PlayerFourNameBox.Location = new System.Drawing.Point(35, 138);
            this.PlayerFourNameBox.Name = "PlayerFourNameBox";
            this.PlayerFourNameBox.Size = new System.Drawing.Size(100, 23);
            this.PlayerFourNameBox.TabIndex = 4;
            // 
            // PlayerOneNameLabel
            // 
            this.PlayerOneNameLabel.AutoSize = true;
            this.PlayerOneNameLabel.Location = new System.Drawing.Point(141, 54);
            this.PlayerOneNameLabel.Name = "PlayerOneNameLabel";
            this.PlayerOneNameLabel.Size = new System.Drawing.Size(0, 15);
            this.PlayerOneNameLabel.TabIndex = 5;
            // 
            // PlayerTwoNameLabel
            // 
            this.PlayerTwoNameLabel.AutoSize = true;
            this.PlayerTwoNameLabel.Location = new System.Drawing.Point(141, 83);
            this.PlayerTwoNameLabel.Name = "PlayerTwoNameLabel";
            this.PlayerTwoNameLabel.Size = new System.Drawing.Size(0, 15);
            this.PlayerTwoNameLabel.TabIndex = 6;
            // 
            // PlayerThreeNameLabel
            // 
            this.PlayerThreeNameLabel.AutoSize = true;
            this.PlayerThreeNameLabel.Location = new System.Drawing.Point(141, 112);
            this.PlayerThreeNameLabel.Name = "PlayerThreeNameLabel";
            this.PlayerThreeNameLabel.Size = new System.Drawing.Size(0, 15);
            this.PlayerThreeNameLabel.TabIndex = 7;
            // 
            // PlayerFourNameLabel
            // 
            this.PlayerFourNameLabel.AutoSize = true;
            this.PlayerFourNameLabel.Location = new System.Drawing.Point(141, 141);
            this.PlayerFourNameLabel.Name = "PlayerFourNameLabel";
            this.PlayerFourNameLabel.Size = new System.Drawing.Size(0, 15);
            this.PlayerFourNameLabel.TabIndex = 8;
            // 
            // RandomiseButton
            // 
            this.RandomiseButton.Location = new System.Drawing.Point(35, 167);
            this.RandomiseButton.Name = "RandomiseButton";
            this.RandomiseButton.Size = new System.Drawing.Size(75, 23);
            this.RandomiseButton.TabIndex = 9;
            this.RandomiseButton.Text = "Randomise";
            this.RandomiseButton.UseVisualStyleBackColor = true;
            this.RandomiseButton.Click += new System.EventHandler(this.RandomiseButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(374, 167);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 10;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // FourPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 207);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.RandomiseButton);
            this.Controls.Add(this.PlayerFourNameLabel);
            this.Controls.Add(this.PlayerThreeNameLabel);
            this.Controls.Add(this.PlayerTwoNameLabel);
            this.Controls.Add(this.PlayerOneNameLabel);
            this.Controls.Add(this.PlayerFourNameBox);
            this.Controls.Add(this.PlayerThreeNameBox);
            this.Controls.Add(this.PlayerTwoNameBox);
            this.Controls.Add(this.PlayerOneNameBox);
            this.Controls.Add(this.label1);
            this.Name = "FourPlayerForm";
            this.Text = "FourPlayerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox PlayerOneNameBox;
        private TextBox PlayerTwoNameBox;
        private TextBox PlayerThreeNameBox;
        private TextBox PlayerFourNameBox;
        private Label PlayerOneNameLabel;
        private Label PlayerTwoNameLabel;
        private Label PlayerThreeNameLabel;
        private Label PlayerFourNameLabel;
        private Button RandomiseButton;
        private Button BackButton;
    }
}