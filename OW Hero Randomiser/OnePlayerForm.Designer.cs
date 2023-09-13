namespace OW_Hero_Randomiser
{
    partial class OnePlayerForm
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
            this.PlayerOneNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RandomiseButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.RoleDropdown1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlayerOneNameBox
            // 
            this.PlayerOneNameBox.Location = new System.Drawing.Point(45, 54);
            this.PlayerOneNameBox.Name = "PlayerOneNameBox";
            this.PlayerOneNameBox.Size = new System.Drawing.Size(144, 23);
            this.PlayerOneNameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter players\' names here:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 2;
            // 
            // RandomiseButton
            // 
            this.RandomiseButton.Location = new System.Drawing.Point(45, 83);
            this.RandomiseButton.Name = "RandomiseButton";
            this.RandomiseButton.Size = new System.Drawing.Size(75, 23);
            this.RandomiseButton.TabIndex = 3;
            this.RandomiseButton.Text = "Randomise";
            this.RandomiseButton.UseVisualStyleBackColor = true;
            this.RandomiseButton.Click += new System.EventHandler(this.RandomiseButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(465, 83);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(123, 86);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(121, 19);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Manually set roles";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // RoleDropdown1
            // 
            this.RoleDropdown1.FormattingEnabled = true;
            this.RoleDropdown1.Items.AddRange(new object[] {
            "Tank",
            "DPS",
            "Support"});
            this.RoleDropdown1.Location = new System.Drawing.Point(195, 54);
            this.RoleDropdown1.Name = "RoleDropdown1";
            this.RoleDropdown1.Size = new System.Drawing.Size(121, 23);
            this.RoleDropdown1.TabIndex = 6;
            this.RoleDropdown1.Text = "Select role";
            this.RoleDropdown1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 7;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // OnePlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 137);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RoleDropdown1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.RandomiseButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayerOneNameBox);
            this.Name = "OnePlayerForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox PlayerOneNameBox;
        private Label label1;
        private Label label2;
        private Button RandomiseButton;
        private Button BackButton;
        private CheckBox checkBox1;
        private ComboBox RoleDropdown1;
        private Label label3;
    }
}