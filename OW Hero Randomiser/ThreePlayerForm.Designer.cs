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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.roleDropdown1 = new System.Windows.Forms.ComboBox();
            this.roleDropdown2 = new System.Windows.Forms.ComboBox();
            this.roleDropdown3 = new System.Windows.Forms.ComboBox();
            this.PlayerOneSelectedRoleLabel = new System.Windows.Forms.Label();
            this.PlayerTwoSelectedRoleLabel = new System.Windows.Forms.Label();
            this.PlayerThreeSelectedRoleLabel = new System.Windows.Forms.Label();
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
            this.PlayerOneNameLabel.Size = new System.Drawing.Size(0, 15);
            this.PlayerOneNameLabel.TabIndex = 5;
            // 
            // PlayerTwoNameLabel
            // 
            this.PlayerTwoNameLabel.AutoSize = true;
            this.PlayerTwoNameLabel.Location = new System.Drawing.Point(179, 80);
            this.PlayerTwoNameLabel.Name = "PlayerTwoNameLabel";
            this.PlayerTwoNameLabel.Size = new System.Drawing.Size(0, 15);
            this.PlayerTwoNameLabel.TabIndex = 6;
            // 
            // PlayerThreeNameLabel
            // 
            this.PlayerThreeNameLabel.AutoSize = true;
            this.PlayerThreeNameLabel.Location = new System.Drawing.Point(179, 109);
            this.PlayerThreeNameLabel.Name = "PlayerThreeNameLabel";
            this.PlayerThreeNameLabel.Size = new System.Drawing.Size(0, 15);
            this.PlayerThreeNameLabel.TabIndex = 7;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(468, 135);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(113, 138);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(121, 19);
            this.checkBox1.TabIndex = 9;
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
            this.roleDropdown1.Location = new System.Drawing.Point(179, 48);
            this.roleDropdown1.Name = "roleDropdown1";
            this.roleDropdown1.Size = new System.Drawing.Size(121, 23);
            this.roleDropdown1.TabIndex = 10;
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
            this.roleDropdown2.Location = new System.Drawing.Point(179, 77);
            this.roleDropdown2.Name = "roleDropdown2";
            this.roleDropdown2.Size = new System.Drawing.Size(121, 23);
            this.roleDropdown2.TabIndex = 11;
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
            this.roleDropdown3.Location = new System.Drawing.Point(179, 106);
            this.roleDropdown3.Name = "roleDropdown3";
            this.roleDropdown3.Size = new System.Drawing.Size(121, 23);
            this.roleDropdown3.TabIndex = 12;
            this.roleDropdown3.Text = "Select role";
            this.roleDropdown3.Visible = false;
            // 
            // PlayerOneSelectedRoleLabel
            // 
            this.PlayerOneSelectedRoleLabel.AutoSize = true;
            this.PlayerOneSelectedRoleLabel.Location = new System.Drawing.Point(306, 51);
            this.PlayerOneSelectedRoleLabel.Name = "PlayerOneSelectedRoleLabel";
            this.PlayerOneSelectedRoleLabel.Size = new System.Drawing.Size(0, 15);
            this.PlayerOneSelectedRoleLabel.TabIndex = 13;
            this.PlayerOneSelectedRoleLabel.Visible = false;
            // 
            // PlayerTwoSelectedRoleLabel
            // 
            this.PlayerTwoSelectedRoleLabel.AutoSize = true;
            this.PlayerTwoSelectedRoleLabel.Location = new System.Drawing.Point(306, 80);
            this.PlayerTwoSelectedRoleLabel.Name = "PlayerTwoSelectedRoleLabel";
            this.PlayerTwoSelectedRoleLabel.Size = new System.Drawing.Size(0, 15);
            this.PlayerTwoSelectedRoleLabel.TabIndex = 14;
            this.PlayerTwoSelectedRoleLabel.Visible = false;
            // 
            // PlayerThreeSelectedRoleLabel
            // 
            this.PlayerThreeSelectedRoleLabel.AutoSize = true;
            this.PlayerThreeSelectedRoleLabel.Location = new System.Drawing.Point(306, 109);
            this.PlayerThreeSelectedRoleLabel.Name = "PlayerThreeSelectedRoleLabel";
            this.PlayerThreeSelectedRoleLabel.Size = new System.Drawing.Size(0, 15);
            this.PlayerThreeSelectedRoleLabel.TabIndex = 15;
            this.PlayerThreeSelectedRoleLabel.Visible = false;
            // 
            // ThreePlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 174);
            this.Controls.Add(this.PlayerThreeSelectedRoleLabel);
            this.Controls.Add(this.PlayerTwoSelectedRoleLabel);
            this.Controls.Add(this.PlayerOneSelectedRoleLabel);
            this.Controls.Add(this.roleDropdown3);
            this.Controls.Add(this.roleDropdown2);
            this.Controls.Add(this.roleDropdown1);
            this.Controls.Add(this.checkBox1);
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
        private CheckBox checkBox1;
        private ComboBox roleDropdown1;
        private ComboBox roleDropdown2;
        private ComboBox roleDropdown3;
        private Label PlayerOneSelectedRoleLabel;
        private Label PlayerTwoSelectedRoleLabel;
        private Label PlayerThreeSelectedRoleLabel;
    }
}