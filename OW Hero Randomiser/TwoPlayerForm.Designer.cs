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
            label1 = new Label();
            PlayerOneNameBox = new TextBox();
            PlayerTwoNameBox = new TextBox();
            PlayerOneLabel = new Label();
            PlayerTwoLabel = new Label();
            RandomiseButton = new Button();
            BackButton = new Button();
            checkBox1 = new CheckBox();
            roleDropdown1 = new ComboBox();
            roleDropdown2 = new ComboBox();
            PlayerOneSelectedRoleLabel = new Label();
            PlayerTwoSelectedRoleLabel = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 26);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter players' names here:";
            // 
            // PlayerOneNameBox
            // 
            PlayerOneNameBox.Location = new Point(48, 44);
            PlayerOneNameBox.Name = "PlayerOneNameBox";
            PlayerOneNameBox.Size = new Size(144, 23);
            PlayerOneNameBox.TabIndex = 1;
            // 
            // PlayerTwoNameBox
            // 
            PlayerTwoNameBox.Location = new Point(48, 73);
            PlayerTwoNameBox.Name = "PlayerTwoNameBox";
            PlayerTwoNameBox.Size = new Size(144, 23);
            PlayerTwoNameBox.TabIndex = 2;
            // 
            // PlayerOneLabel
            // 
            PlayerOneLabel.AutoSize = true;
            PlayerOneLabel.Location = new Point(198, 47);
            PlayerOneLabel.Name = "PlayerOneLabel";
            PlayerOneLabel.Size = new Size(0, 15);
            PlayerOneLabel.TabIndex = 3;
            // 
            // PlayerTwoLabel
            // 
            PlayerTwoLabel.AutoSize = true;
            PlayerTwoLabel.Location = new Point(198, 81);
            PlayerTwoLabel.Name = "PlayerTwoLabel";
            PlayerTwoLabel.Size = new Size(0, 15);
            PlayerTwoLabel.TabIndex = 4;
            // 
            // RandomiseButton
            // 
            RandomiseButton.Location = new Point(48, 102);
            RandomiseButton.Name = "RandomiseButton";
            RandomiseButton.Size = new Size(75, 23);
            RandomiseButton.TabIndex = 5;
            RandomiseButton.Text = "Randomise";
            RandomiseButton.UseVisualStyleBackColor = true;
            RandomiseButton.Click += RandomiseButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(439, 101);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 6;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(129, 105);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Manually set roles";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // roleDropdown1
            // 
            roleDropdown1.FormattingEnabled = true;
            roleDropdown1.Items.AddRange(new object[] { "Tank", "DPS", "Support" });
            roleDropdown1.Location = new Point(198, 44);
            roleDropdown1.Name = "roleDropdown1";
            roleDropdown1.Size = new Size(121, 23);
            roleDropdown1.TabIndex = 8;
            roleDropdown1.Text = "Select role";
            roleDropdown1.Visible = false;
            // 
            // roleDropdown2
            // 
            roleDropdown2.FormattingEnabled = true;
            roleDropdown2.Items.AddRange(new object[] { "Tank", "DPS", "Support" });
            roleDropdown2.Location = new Point(198, 73);
            roleDropdown2.Name = "roleDropdown2";
            roleDropdown2.Size = new Size(121, 23);
            roleDropdown2.TabIndex = 9;
            roleDropdown2.Text = "Select role";
            roleDropdown2.Visible = false;
            // 
            // PlayerOneSelectedRoleLabel
            // 
            PlayerOneSelectedRoleLabel.AutoSize = true;
            PlayerOneSelectedRoleLabel.Location = new Point(325, 47);
            PlayerOneSelectedRoleLabel.Name = "PlayerOneSelectedRoleLabel";
            PlayerOneSelectedRoleLabel.Size = new Size(0, 15);
            PlayerOneSelectedRoleLabel.TabIndex = 10;
            // 
            // PlayerTwoSelectedRoleLabel
            // 
            PlayerTwoSelectedRoleLabel.AutoSize = true;
            PlayerTwoSelectedRoleLabel.Location = new Point(325, 76);
            PlayerTwoSelectedRoleLabel.Name = "PlayerTwoSelectedRoleLabel";
            PlayerTwoSelectedRoleLabel.Size = new Size(0, 15);
            PlayerTwoSelectedRoleLabel.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(19, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(19, 73);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(23, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // TwoPlayerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 152);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(PlayerTwoSelectedRoleLabel);
            Controls.Add(PlayerOneSelectedRoleLabel);
            Controls.Add(roleDropdown2);
            Controls.Add(roleDropdown1);
            Controls.Add(checkBox1);
            Controls.Add(BackButton);
            Controls.Add(RandomiseButton);
            Controls.Add(PlayerTwoLabel);
            Controls.Add(PlayerOneLabel);
            Controls.Add(PlayerTwoNameBox);
            Controls.Add(PlayerOneNameBox);
            Controls.Add(label1);
            Name = "TwoPlayerForm";
            Text = "TwoPlayerForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox PlayerOneNameBox;
        private TextBox PlayerTwoNameBox;
        private Label PlayerOneLabel;
        private Label PlayerTwoLabel;
        private Button RandomiseButton;
        private Button BackButton;
        private CheckBox checkBox1;
        private ComboBox roleDropdown1;
        private ComboBox roleDropdown2;
        private Label PlayerOneSelectedRoleLabel;
        private Label PlayerTwoSelectedRoleLabel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}