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
            label1 = new Label();
            PlayerOneNameBox = new TextBox();
            PlayerTwoNameBox = new TextBox();
            PlayerThreeNameBox = new TextBox();
            RandomiseButton = new Button();
            PlayerOneNameLabel = new Label();
            PlayerTwoNameLabel = new Label();
            PlayerThreeNameLabel = new Label();
            BackButton = new Button();
            checkBox1 = new CheckBox();
            roleDropdown1 = new ComboBox();
            roleDropdown2 = new ComboBox();
            roleDropdown3 = new ComboBox();
            PlayerOneSelectedRoleLabel = new Label();
            PlayerTwoSelectedRoleLabel = new Label();
            PlayerThreeSelectedRoleLabel = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 30);
            label1.Name = "label1";
            label1.Size = new Size(141, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter players' names here";
            // 
            // PlayerOneNameBox
            // 
            PlayerOneNameBox.Location = new Point(32, 48);
            PlayerOneNameBox.Name = "PlayerOneNameBox";
            PlayerOneNameBox.Size = new Size(141, 23);
            PlayerOneNameBox.TabIndex = 1;
            // 
            // PlayerTwoNameBox
            // 
            PlayerTwoNameBox.Location = new Point(32, 77);
            PlayerTwoNameBox.Name = "PlayerTwoNameBox";
            PlayerTwoNameBox.Size = new Size(141, 23);
            PlayerTwoNameBox.TabIndex = 2;
            // 
            // PlayerThreeNameBox
            // 
            PlayerThreeNameBox.Location = new Point(32, 106);
            PlayerThreeNameBox.Name = "PlayerThreeNameBox";
            PlayerThreeNameBox.Size = new Size(141, 23);
            PlayerThreeNameBox.TabIndex = 3;
            // 
            // RandomiseButton
            // 
            RandomiseButton.Location = new Point(32, 135);
            RandomiseButton.Name = "RandomiseButton";
            RandomiseButton.Size = new Size(75, 23);
            RandomiseButton.TabIndex = 4;
            RandomiseButton.Text = "Randomise";
            RandomiseButton.UseVisualStyleBackColor = true;
            RandomiseButton.Click += RandomiseButton_Click;
            // 
            // PlayerOneNameLabel
            // 
            PlayerOneNameLabel.AutoSize = true;
            PlayerOneNameLabel.Location = new Point(179, 51);
            PlayerOneNameLabel.Name = "PlayerOneNameLabel";
            PlayerOneNameLabel.Size = new Size(0, 15);
            PlayerOneNameLabel.TabIndex = 5;
            // 
            // PlayerTwoNameLabel
            // 
            PlayerTwoNameLabel.AutoSize = true;
            PlayerTwoNameLabel.Location = new Point(179, 80);
            PlayerTwoNameLabel.Name = "PlayerTwoNameLabel";
            PlayerTwoNameLabel.Size = new Size(0, 15);
            PlayerTwoNameLabel.TabIndex = 6;
            // 
            // PlayerThreeNameLabel
            // 
            PlayerThreeNameLabel.AutoSize = true;
            PlayerThreeNameLabel.Location = new Point(179, 109);
            PlayerThreeNameLabel.Name = "PlayerThreeNameLabel";
            PlayerThreeNameLabel.Size = new Size(0, 15);
            PlayerThreeNameLabel.TabIndex = 7;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(468, 135);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 8;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(113, 138);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 19);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Manually set roles";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // roleDropdown1
            // 
            roleDropdown1.FormattingEnabled = true;
            roleDropdown1.Items.AddRange(new object[] { "Tank", "DPS", "Support" });
            roleDropdown1.Location = new Point(179, 48);
            roleDropdown1.Name = "roleDropdown1";
            roleDropdown1.Size = new Size(121, 23);
            roleDropdown1.TabIndex = 10;
            roleDropdown1.Text = "Select role";
            roleDropdown1.Visible = false;
            // 
            // roleDropdown2
            // 
            roleDropdown2.FormattingEnabled = true;
            roleDropdown2.Items.AddRange(new object[] { "Tank", "DPS", "Support" });
            roleDropdown2.Location = new Point(179, 77);
            roleDropdown2.Name = "roleDropdown2";
            roleDropdown2.Size = new Size(121, 23);
            roleDropdown2.TabIndex = 11;
            roleDropdown2.Text = "Select role";
            roleDropdown2.Visible = false;
            // 
            // roleDropdown3
            // 
            roleDropdown3.FormattingEnabled = true;
            roleDropdown3.Items.AddRange(new object[] { "Tank", "DPS", "Support" });
            roleDropdown3.Location = new Point(179, 106);
            roleDropdown3.Name = "roleDropdown3";
            roleDropdown3.Size = new Size(121, 23);
            roleDropdown3.TabIndex = 12;
            roleDropdown3.Text = "Select role";
            roleDropdown3.Visible = false;
            // 
            // PlayerOneSelectedRoleLabel
            // 
            PlayerOneSelectedRoleLabel.AutoSize = true;
            PlayerOneSelectedRoleLabel.Location = new Point(306, 51);
            PlayerOneSelectedRoleLabel.Name = "PlayerOneSelectedRoleLabel";
            PlayerOneSelectedRoleLabel.Size = new Size(0, 15);
            PlayerOneSelectedRoleLabel.TabIndex = 13;
            PlayerOneSelectedRoleLabel.Visible = false;
            // 
            // PlayerTwoSelectedRoleLabel
            // 
            PlayerTwoSelectedRoleLabel.AutoSize = true;
            PlayerTwoSelectedRoleLabel.Location = new Point(306, 80);
            PlayerTwoSelectedRoleLabel.Name = "PlayerTwoSelectedRoleLabel";
            PlayerTwoSelectedRoleLabel.Size = new Size(0, 15);
            PlayerTwoSelectedRoleLabel.TabIndex = 14;
            PlayerTwoSelectedRoleLabel.Visible = false;
            // 
            // PlayerThreeSelectedRoleLabel
            // 
            PlayerThreeSelectedRoleLabel.AutoSize = true;
            PlayerThreeSelectedRoleLabel.Location = new Point(306, 109);
            PlayerThreeSelectedRoleLabel.Name = "PlayerThreeSelectedRoleLabel";
            PlayerThreeSelectedRoleLabel.Size = new Size(0, 15);
            PlayerThreeSelectedRoleLabel.TabIndex = 15;
            PlayerThreeSelectedRoleLabel.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(3, 48);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(23, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(3, 106);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(23, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // ThreePlayerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 174);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(PlayerThreeSelectedRoleLabel);
            Controls.Add(PlayerTwoSelectedRoleLabel);
            Controls.Add(PlayerOneSelectedRoleLabel);
            Controls.Add(roleDropdown3);
            Controls.Add(roleDropdown2);
            Controls.Add(roleDropdown1);
            Controls.Add(checkBox1);
            Controls.Add(BackButton);
            Controls.Add(PlayerThreeNameLabel);
            Controls.Add(PlayerTwoNameLabel);
            Controls.Add(PlayerOneNameLabel);
            Controls.Add(RandomiseButton);
            Controls.Add(PlayerThreeNameBox);
            Controls.Add(PlayerTwoNameBox);
            Controls.Add(PlayerOneNameBox);
            Controls.Add(label1);
            Name = "ThreePlayerForm";
            Text = "ThreePlayerForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private CheckBox checkBox1;
        private ComboBox roleDropdown1;
        private ComboBox roleDropdown2;
        private ComboBox roleDropdown3;
        private Label PlayerOneSelectedRoleLabel;
        private Label PlayerTwoSelectedRoleLabel;
        private Label PlayerThreeSelectedRoleLabel;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
    }
}