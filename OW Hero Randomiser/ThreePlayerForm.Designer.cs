namespace OW_Hero_Randomiser
{
    partial class ThreePlayerForm
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
            this.RandomiseButton = new System.Windows.Forms.Button();
            this.PlayerOneNameLabel = new System.Windows.Forms.Label();
            this.PlayerTwoNameLabel = new System.Windows.Forms.Label();
            this.PlayerThreeNameLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter players\' names here";
            // 
            // PlayerOneNameBox
            // 
            this.PlayerOneNameBox.Location = new System.Drawing.Point(32, 48);
            this.PlayerOneNameBox.Name = "PlayerOneNameBox";
            this.PlayerOneNameBox.Size = new System.Drawing.Size(141, 23);
            this.PlayerOneNameBox.TabIndex = 1;
            // 
            // PlayerTwoNameBox
            // 
            this.PlayerTwoNameBox.Location = new System.Drawing.Point(32, 77);
            this.PlayerTwoNameBox.Name = "PlayerTwoNameBox";
            this.PlayerTwoNameBox.Size = new System.Drawing.Size(141, 23);
            this.PlayerTwoNameBox.TabIndex = 2;
            // 
            // PlayerThreeNameBox
            // 
            this.PlayerThreeNameBox.Location = new System.Drawing.Point(32, 106);
            this.PlayerThreeNameBox.Name = "PlayerThreeNameBox";
            this.PlayerThreeNameBox.Size = new System.Drawing.Size(141, 23);
            this.PlayerThreeNameBox.TabIndex = 3;
            // 
            // RandomiseButton
            // 
            this.RandomiseButton.Location = new System.Drawing.Point(32, 135);
            this.RandomiseButton.Name = "RandomiseButton";
            this.RandomiseButton.Size = new System.Drawing.Size(75, 23);
            this.RandomiseButton.TabIndex = 4;
            this.RandomiseButton.Text = "Randomise";
            this.RandomiseButton.UseVisualStyleBackColor = true;
            this.RandomiseButton.Click += new System.EventHandler(this.RandomiseButton_Click);
            // 
            // PlayerOneNameLabel
            // 
            this.PlayerOneNameLabel.AutoSize = true;
            this.PlayerOneNameLabel.Location = new System.Drawing.Point(179, 51);
            this.PlayerOneNameLabel.Name = "PlayerOneNameLabel";
            this.PlayerOneNameLabel.Size = new System.Drawing.Size(38, 15);
            this.PlayerOneNameLabel.TabIndex = 5;
            this.PlayerOneNameLabel.Text = "label2";
            // 
            // PlayerTwoNameLabel
            // 
            this.PlayerTwoNameLabel.AutoSize = true;
            this.PlayerTwoNameLabel.Location = new System.Drawing.Point(179, 80);
            this.PlayerTwoNameLabel.Name = "PlayerTwoNameLabel";
            this.PlayerTwoNameLabel.Size = new System.Drawing.Size(38, 15);
            this.PlayerTwoNameLabel.TabIndex = 6;
            this.PlayerTwoNameLabel.Text = "label3";
            // 
            // PlayerThreeNameLabel
            // 
            this.PlayerThreeNameLabel.AutoSize = true;
            this.PlayerThreeNameLabel.Location = new System.Drawing.Point(179, 109);
            this.PlayerThreeNameLabel.Name = "PlayerThreeNameLabel";
            this.PlayerThreeNameLabel.Size = new System.Drawing.Size(38, 15);
            this.PlayerThreeNameLabel.TabIndex = 7;
            this.PlayerThreeNameLabel.Text = "label4";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(371, 135);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ThreePlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 174);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.PlayerThreeNameLabel);
            this.Controls.Add(this.PlayerTwoNameLabel);
            this.Controls.Add(this.PlayerOneNameLabel);
            this.Controls.Add(this.RandomiseButton);
            this.Controls.Add(this.PlayerThreeNameBox);
            this.Controls.Add(this.PlayerTwoNameBox);
            this.Controls.Add(this.PlayerOneNameBox);
            this.Controls.Add(this.label1);
            this.Name = "ThreePlayerForm";
            this.Text = "ThreePlayerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox PlayerOneNameBox;
        private TextBox PlayerTwoNameBox;
        private TextBox PlayerThreeNameBox;
        private Button RandomiseButton;
        private Label PlayerOneNameLabel;
        private Label PlayerTwoNameLabel;
        private Label PlayerThreeNameLabel;
        private Button BackButton;
    }
}