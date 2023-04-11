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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.roleDropdown1 = new System.Windows.Forms.ComboBox();
            this.roleDropdown2 = new System.Windows.Forms.ComboBox();
            this.PlayerOneSelectedRoleLabel = new System.Windows.Forms.Label();
            this.PlayerTwoSelectedRoleLabel = new System.Windows.Forms.Label();
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
            this.BackButton.Location = new System.Drawing.Point(439, 101);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(129, 105);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(121, 19);
            this.checkBox1.TabIndex = 7;
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
            this.roleDropdown1.Location = new System.Drawing.Point(198, 44);
            this.roleDropdown1.Name = "roleDropdown1";
            this.roleDropdown1.Size = new System.Drawing.Size(121, 23);
            this.roleDropdown1.TabIndex = 8;
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
            this.roleDropdown2.Location = new System.Drawing.Point(198, 73);
            this.roleDropdown2.Name = "roleDropdown2";
            this.roleDropdown2.Size = new System.Drawing.Size(121, 23);
            this.roleDropdown2.TabIndex = 9;
            this.roleDropdown2.Text = "Select role";
            this.roleDropdown2.Visible = false;
            // 
            // PlayerOneSelectedRoleLabel
            // 
            this.PlayerOneSelectedRoleLabel.AutoSize = true;
            this.PlayerOneSelectedRoleLabel.Location = new System.Drawing.Point(325, 47);
            this.PlayerOneSelectedRoleLabel.Name = "PlayerOneSelectedRoleLabel";
            this.PlayerOneSelectedRoleLabel.Size = new System.Drawing.Size(0, 15);
            this.PlayerOneSelectedRoleLabel.TabIndex = 10;
            // 
            // PlayerTwoSelectedRoleLabel
            // 
            this.PlayerTwoSelectedRoleLabel.AutoSize = true;
            this.PlayerTwoSelectedRoleLabel.Location = new System.Drawing.Point(325, 76);
            this.PlayerTwoSelectedRoleLabel.Name = "PlayerTwoSelectedRoleLabel";
            this.PlayerTwoSelectedRoleLabel.Size = new System.Drawing.Size(0, 15);
            this.PlayerTwoSelectedRoleLabel.TabIndex = 11;
            // 
            // TwoPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 152);
            this.Controls.Add(this.PlayerTwoSelectedRoleLabel);
            this.Controls.Add(this.PlayerOneSelectedRoleLabel);
            this.Controls.Add(this.roleDropdown2);
            this.Controls.Add(this.roleDropdown1);
            this.Controls.Add(this.checkBox1);
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
        private CheckBox checkBox1;
        private ComboBox roleDropdown1;
        private ComboBox roleDropdown2;
        private Label PlayerOneSelectedRoleLabel;
        private Label PlayerTwoSelectedRoleLabel;
    }
}