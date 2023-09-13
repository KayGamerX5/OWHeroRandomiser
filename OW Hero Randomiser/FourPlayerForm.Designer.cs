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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.roleDropdown1 = new System.Windows.Forms.ComboBox();
            this.roleDropdown2 = new System.Windows.Forms.ComboBox();
            this.roleDropdown3 = new System.Windows.Forms.ComboBox();
            this.roleDropdown4 = new System.Windows.Forms.ComboBox();
            this.PlayerOneSelectedRoleLabel = new System.Windows.Forms.Label();
            this.PlayerTwoSelectedRoleLabel = new System.Windows.Forms.Label();
            this.PlayerThreeSelectedRoleLabel = new System.Windows.Forms.Label();
            this.PlayerFourSelectedRoleLabel = new System.Windows.Forms.Label();
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
            this.PlayerOneNameBox.TextChanged += new System.EventHandler(this.PlayerOneNameBox_TextChanged);
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
            this.BackButton.Location = new System.Drawing.Point(553, 167);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 10;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(116, 170);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(121, 19);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Manually set roles";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // roleDropdown1
            // 
            this.roleDropdown1.FormattingEnabled = true;
            this.roleDropdown1.Items.AddRange(new object[] {
            "Tank",
            "DPS",
            "Support"});
            this.roleDropdown1.Location = new System.Drawing.Point(141, 51);
            this.roleDropdown1.Name = "roleDropdown1";
            this.roleDropdown1.Size = new System.Drawing.Size(121, 23);
            this.roleDropdown1.TabIndex = 12;
            this.roleDropdown1.Text = "Select role";
            this.roleDropdown1.Visible = false;
            // 
            // roleDropdown2
            // 
            this.roleDropdown2.FormattingEnabled = true;
            this.roleDropdown2.Items.AddRange(new object[] {
            "Tank",
            "DPS",
            "Support"});
            this.roleDropdown2.Location = new System.Drawing.Point(141, 80);
            this.roleDropdown2.Name = "roleDropdown2";
            this.roleDropdown2.Size = new System.Drawing.Size(121, 23);
            this.roleDropdown2.TabIndex = 13;
            this.roleDropdown2.Text = "Select role";
            this.roleDropdown2.Visible = false;
            // 
            // roleDropdown3
            // 
            this.roleDropdown3.FormattingEnabled = true;
            this.roleDropdown3.Items.AddRange(new object[] {
            "Tank",
            "DPS",
            "Support"});
            this.roleDropdown3.Location = new System.Drawing.Point(141, 109);
            this.roleDropdown3.Name = "roleDropdown3";
            this.roleDropdown3.Size = new System.Drawing.Size(121, 23);
            this.roleDropdown3.TabIndex = 14;
            this.roleDropdown3.Text = "Select role";
            this.roleDropdown3.Visible = false;
            // 
            // roleDropdown4
            // 
            this.roleDropdown4.FormattingEnabled = true;
            this.roleDropdown4.Items.AddRange(new object[] {
            "Tank",
            "DPS",
            "Support"});
            this.roleDropdown4.Location = new System.Drawing.Point(141, 138);
            this.roleDropdown4.Name = "roleDropdown4";
            this.roleDropdown4.Size = new System.Drawing.Size(121, 23);
            this.roleDropdown4.TabIndex = 15;
            this.roleDropdown4.Text = "Select role";
            this.roleDropdown4.Visible = false;
            // 
            // PlayerOneSelectedRoleLabel
            // 
            this.PlayerOneSelectedRoleLabel.AutoSize = true;
            this.PlayerOneSelectedRoleLabel.Location = new System.Drawing.Point(268, 54);
            this.PlayerOneSelectedRoleLabel.Name = "PlayerOneSelectedRoleLabel";
            this.PlayerOneSelectedRoleLabel.Size = new System.Drawing.Size(0, 15);
            this.PlayerOneSelectedRoleLabel.TabIndex = 16;
            // 
            // PlayerTwoSelectedRoleLabel
            // 
            this.PlayerTwoSelectedRoleLabel.AutoSize = true;
            this.PlayerTwoSelectedRoleLabel.Location = new System.Drawing.Point(268, 83);
            this.PlayerTwoSelectedRoleLabel.Name = "PlayerTwoSelectedRoleLabel";
            this.PlayerTwoSelectedRoleLabel.Size = new System.Drawing.Size(0, 15);
            this.PlayerTwoSelectedRoleLabel.TabIndex = 17;
            // 
            // PlayerThreeSelectedRoleLabel
            // 
            this.PlayerThreeSelectedRoleLabel.AutoSize = true;
            this.PlayerThreeSelectedRoleLabel.Location = new System.Drawing.Point(268, 112);
            this.PlayerThreeSelectedRoleLabel.Name = "PlayerThreeSelectedRoleLabel";
            this.PlayerThreeSelectedRoleLabel.Size = new System.Drawing.Size(0, 15);
            this.PlayerThreeSelectedRoleLabel.TabIndex = 18;
            // 
            // PlayerFourSelectedRoleLabel
            // 
            this.PlayerFourSelectedRoleLabel.AutoSize = true;
            this.PlayerFourSelectedRoleLabel.Location = new System.Drawing.Point(268, 141);
            this.PlayerFourSelectedRoleLabel.Name = "PlayerFourSelectedRoleLabel";
            this.PlayerFourSelectedRoleLabel.Size = new System.Drawing.Size(0, 15);
            this.PlayerFourSelectedRoleLabel.TabIndex = 19;
            // 
            // FourPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 207);
            this.Controls.Add(this.PlayerFourSelectedRoleLabel);
            this.Controls.Add(this.PlayerThreeSelectedRoleLabel);
            this.Controls.Add(this.PlayerTwoSelectedRoleLabel);
            this.Controls.Add(this.PlayerOneSelectedRoleLabel);
            this.Controls.Add(this.roleDropdown4);
            this.Controls.Add(this.roleDropdown3);
            this.Controls.Add(this.roleDropdown2);
            this.Controls.Add(this.roleDropdown1);
            this.Controls.Add(this.checkBox1);
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
        private CheckBox checkBox1;
        private ComboBox roleDropdown1;
        private ComboBox roleDropdown2;
        private ComboBox roleDropdown3;
        private ComboBox roleDropdown4;
        private Label PlayerOneSelectedRoleLabel;
        private Label PlayerTwoSelectedRoleLabel;
        private Label PlayerThreeSelectedRoleLabel;
        private Label PlayerFourSelectedRoleLabel;
    }
}