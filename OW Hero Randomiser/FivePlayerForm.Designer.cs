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
            label1 = new Label();
            PlayerOneNameBox = new TextBox();
            PlayerTwoNameBox = new TextBox();
            PlayerThreeNameBox = new TextBox();
            PlayerFourNameBox = new TextBox();
            PlayerFiveNameBox = new TextBox();
            RandomiseButton = new Button();
            PlayerOneNameLabel = new Label();
            PlayerTwoNameLabel = new Label();
            PlayerThreeNameLabel = new Label();
            PlayerFourNameLabel = new Label();
            PlayerFiveNameLabel = new Label();
            BackButton = new Button();
            roleDropdown1 = new ComboBox();
            roleDropdown2 = new ComboBox();
            roleDropdown3 = new ComboBox();
            roleDropdown4 = new ComboBox();
            roleDropdown5 = new ComboBox();
            checkBox1 = new CheckBox();
            PlayerOneSelectedRoleLabel = new Label();
            PlayerTwoSelectedRoleLabel = new Label();
            PlayerThreeSelectedRoleLabel = new Label();
            PlayerFourSelectedRoleLabel = new Label();
            PlayerFiveSelectedRoleLabel = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 26);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter players' names here:";
            // 
            // PlayerOneNameBox
            // 
            PlayerOneNameBox.Location = new Point(35, 44);
            PlayerOneNameBox.Name = "PlayerOneNameBox";
            PlayerOneNameBox.Size = new Size(144, 23);
            PlayerOneNameBox.TabIndex = 1;
            // 
            // PlayerTwoNameBox
            // 
            PlayerTwoNameBox.Location = new Point(35, 73);
            PlayerTwoNameBox.Name = "PlayerTwoNameBox";
            PlayerTwoNameBox.Size = new Size(144, 23);
            PlayerTwoNameBox.TabIndex = 2;
            // 
            // PlayerThreeNameBox
            // 
            PlayerThreeNameBox.Location = new Point(35, 102);
            PlayerThreeNameBox.Name = "PlayerThreeNameBox";
            PlayerThreeNameBox.Size = new Size(144, 23);
            PlayerThreeNameBox.TabIndex = 3;
            // 
            // PlayerFourNameBox
            // 
            PlayerFourNameBox.Location = new Point(35, 131);
            PlayerFourNameBox.Name = "PlayerFourNameBox";
            PlayerFourNameBox.Size = new Size(144, 23);
            PlayerFourNameBox.TabIndex = 4;
            // 
            // PlayerFiveNameBox
            // 
            PlayerFiveNameBox.Location = new Point(35, 160);
            PlayerFiveNameBox.Name = "PlayerFiveNameBox";
            PlayerFiveNameBox.Size = new Size(144, 23);
            PlayerFiveNameBox.TabIndex = 5;
            // 
            // RandomiseButton
            // 
            RandomiseButton.Location = new Point(35, 189);
            RandomiseButton.Name = "RandomiseButton";
            RandomiseButton.Size = new Size(75, 23);
            RandomiseButton.TabIndex = 6;
            RandomiseButton.Text = "Randomise";
            RandomiseButton.UseVisualStyleBackColor = true;
            RandomiseButton.Click += RandomiseButton_Click;
            // 
            // PlayerOneNameLabel
            // 
            PlayerOneNameLabel.AutoSize = true;
            PlayerOneNameLabel.Location = new Point(185, 47);
            PlayerOneNameLabel.Name = "PlayerOneNameLabel";
            PlayerOneNameLabel.Size = new Size(0, 15);
            PlayerOneNameLabel.TabIndex = 7;
            // 
            // PlayerTwoNameLabel
            // 
            PlayerTwoNameLabel.AutoSize = true;
            PlayerTwoNameLabel.Location = new Point(185, 76);
            PlayerTwoNameLabel.Name = "PlayerTwoNameLabel";
            PlayerTwoNameLabel.Size = new Size(0, 15);
            PlayerTwoNameLabel.TabIndex = 8;
            // 
            // PlayerThreeNameLabel
            // 
            PlayerThreeNameLabel.AutoSize = true;
            PlayerThreeNameLabel.Location = new Point(185, 105);
            PlayerThreeNameLabel.Name = "PlayerThreeNameLabel";
            PlayerThreeNameLabel.Size = new Size(0, 15);
            PlayerThreeNameLabel.TabIndex = 9;
            // 
            // PlayerFourNameLabel
            // 
            PlayerFourNameLabel.AutoSize = true;
            PlayerFourNameLabel.Location = new Point(185, 134);
            PlayerFourNameLabel.Name = "PlayerFourNameLabel";
            PlayerFourNameLabel.Size = new Size(0, 15);
            PlayerFourNameLabel.TabIndex = 10;
            // 
            // PlayerFiveNameLabel
            // 
            PlayerFiveNameLabel.AutoSize = true;
            PlayerFiveNameLabel.Location = new Point(185, 163);
            PlayerFiveNameLabel.Name = "PlayerFiveNameLabel";
            PlayerFiveNameLabel.Size = new Size(0, 15);
            PlayerFiveNameLabel.TabIndex = 11;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(566, 189);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 12;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // roleDropdown1
            // 
            roleDropdown1.FormattingEnabled = true;
            roleDropdown1.Items.AddRange(new object[] { "Tank", "DPS", "Support" });
            roleDropdown1.Location = new Point(191, 44);
            roleDropdown1.Name = "roleDropdown1";
            roleDropdown1.Size = new Size(121, 23);
            roleDropdown1.TabIndex = 13;
            roleDropdown1.Text = "Select role";
            roleDropdown1.Visible = false;
            // 
            // roleDropdown2
            // 
            roleDropdown2.FormattingEnabled = true;
            roleDropdown2.Items.AddRange(new object[] { "Tank", "DPS", "Support" });
            roleDropdown2.Location = new Point(191, 73);
            roleDropdown2.Name = "roleDropdown2";
            roleDropdown2.Size = new Size(121, 23);
            roleDropdown2.TabIndex = 14;
            roleDropdown2.Text = "Select role";
            roleDropdown2.Visible = false;
            // 
            // roleDropdown3
            // 
            roleDropdown3.FormattingEnabled = true;
            roleDropdown3.Items.AddRange(new object[] { "Tank", "DPS", "Support" });
            roleDropdown3.Location = new Point(191, 102);
            roleDropdown3.Name = "roleDropdown3";
            roleDropdown3.Size = new Size(121, 23);
            roleDropdown3.TabIndex = 15;
            roleDropdown3.Text = "Select role";
            roleDropdown3.Visible = false;
            // 
            // roleDropdown4
            // 
            roleDropdown4.FormattingEnabled = true;
            roleDropdown4.Items.AddRange(new object[] { "Tank", "DPS", "Support" });
            roleDropdown4.Location = new Point(191, 131);
            roleDropdown4.Name = "roleDropdown4";
            roleDropdown4.Size = new Size(121, 23);
            roleDropdown4.TabIndex = 16;
            roleDropdown4.Text = "Select role";
            roleDropdown4.Visible = false;
            // 
            // roleDropdown5
            // 
            roleDropdown5.FormattingEnabled = true;
            roleDropdown5.Items.AddRange(new object[] { "Tank", "DPS", "Support" });
            roleDropdown5.Location = new Point(191, 160);
            roleDropdown5.Name = "roleDropdown5";
            roleDropdown5.Size = new Size(121, 23);
            roleDropdown5.TabIndex = 17;
            roleDropdown5.Text = "Select role";
            roleDropdown5.Visible = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(116, 192);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 19);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "Manually set roles";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // PlayerOneSelectedRoleLabel
            // 
            PlayerOneSelectedRoleLabel.AutoSize = true;
            PlayerOneSelectedRoleLabel.Location = new Point(318, 47);
            PlayerOneSelectedRoleLabel.Name = "PlayerOneSelectedRoleLabel";
            PlayerOneSelectedRoleLabel.Size = new Size(0, 15);
            PlayerOneSelectedRoleLabel.TabIndex = 19;
            // 
            // PlayerTwoSelectedRoleLabel
            // 
            PlayerTwoSelectedRoleLabel.AutoSize = true;
            PlayerTwoSelectedRoleLabel.Location = new Point(318, 76);
            PlayerTwoSelectedRoleLabel.Name = "PlayerTwoSelectedRoleLabel";
            PlayerTwoSelectedRoleLabel.Size = new Size(0, 15);
            PlayerTwoSelectedRoleLabel.TabIndex = 20;
            // 
            // PlayerThreeSelectedRoleLabel
            // 
            PlayerThreeSelectedRoleLabel.AutoSize = true;
            PlayerThreeSelectedRoleLabel.Location = new Point(318, 105);
            PlayerThreeSelectedRoleLabel.Name = "PlayerThreeSelectedRoleLabel";
            PlayerThreeSelectedRoleLabel.Size = new Size(0, 15);
            PlayerThreeSelectedRoleLabel.TabIndex = 21;
            // 
            // PlayerFourSelectedRoleLabel
            // 
            PlayerFourSelectedRoleLabel.AutoSize = true;
            PlayerFourSelectedRoleLabel.Location = new Point(318, 134);
            PlayerFourSelectedRoleLabel.Name = "PlayerFourSelectedRoleLabel";
            PlayerFourSelectedRoleLabel.Size = new Size(0, 15);
            PlayerFourSelectedRoleLabel.TabIndex = 22;
            // 
            // PlayerFiveSelectedRoleLabel
            // 
            PlayerFiveSelectedRoleLabel.AutoSize = true;
            PlayerFiveSelectedRoleLabel.Location = new Point(318, 163);
            PlayerFiveSelectedRoleLabel.Name = "PlayerFiveSelectedRoleLabel";
            PlayerFiveSelectedRoleLabel.Size = new Size(0, 15);
            PlayerFiveSelectedRoleLabel.TabIndex = 23;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(6, 131);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(23, 23);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 27;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(6, 102);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(23, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 26;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(6, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(6, 44);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(23, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(6, 160);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(23, 23);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 28;
            pictureBox5.TabStop = false;
            // 
            // FivePlayerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 235);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(PlayerFiveSelectedRoleLabel);
            Controls.Add(PlayerFourSelectedRoleLabel);
            Controls.Add(PlayerThreeSelectedRoleLabel);
            Controls.Add(PlayerTwoSelectedRoleLabel);
            Controls.Add(PlayerOneSelectedRoleLabel);
            Controls.Add(checkBox1);
            Controls.Add(roleDropdown5);
            Controls.Add(roleDropdown4);
            Controls.Add(roleDropdown3);
            Controls.Add(roleDropdown2);
            Controls.Add(roleDropdown1);
            Controls.Add(BackButton);
            Controls.Add(PlayerFiveNameLabel);
            Controls.Add(PlayerFourNameLabel);
            Controls.Add(PlayerThreeNameLabel);
            Controls.Add(PlayerTwoNameLabel);
            Controls.Add(PlayerOneNameLabel);
            Controls.Add(RandomiseButton);
            Controls.Add(PlayerFiveNameBox);
            Controls.Add(PlayerFourNameBox);
            Controls.Add(PlayerThreeNameBox);
            Controls.Add(PlayerTwoNameBox);
            Controls.Add(PlayerOneNameBox);
            Controls.Add(label1);
            Name = "FivePlayerForm";
            Text = "FivePlayerForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private ComboBox roleDropdown1;
        private ComboBox roleDropdown2;
        private ComboBox roleDropdown3;
        private ComboBox roleDropdown4;
        private ComboBox roleDropdown5;
        private CheckBox checkBox1;
        private Label PlayerOneSelectedRoleLabel;
        private Label PlayerTwoSelectedRoleLabel;
        private Label PlayerThreeSelectedRoleLabel;
        private Label PlayerFourSelectedRoleLabel;
        private Label PlayerFiveSelectedRoleLabel;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
    }
}