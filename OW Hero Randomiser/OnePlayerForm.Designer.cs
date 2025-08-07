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
            PlayerOneNameBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            RandomiseButton = new Button();
            BackButton = new Button();
            checkBox1 = new CheckBox();
            RoleDropdown1 = new ComboBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PlayerOneNameBox
            // 
            PlayerOneNameBox.Location = new Point(45, 54);
            PlayerOneNameBox.Name = "PlayerOneNameBox";
            PlayerOneNameBox.Size = new Size(144, 23);
            PlayerOneNameBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 36);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 1;
            label1.Text = "Enter players' names here:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195, 57);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 2;
            // 
            // RandomiseButton
            // 
            RandomiseButton.Location = new Point(45, 83);
            RandomiseButton.Name = "RandomiseButton";
            RandomiseButton.Size = new Size(75, 23);
            RandomiseButton.TabIndex = 3;
            RandomiseButton.Text = "Randomise";
            RandomiseButton.UseVisualStyleBackColor = true;
            RandomiseButton.Click += RandomiseButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(465, 83);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 4;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(123, 86);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Manually set roles";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // RoleDropdown1
            // 
            RoleDropdown1.FormattingEnabled = true;
            RoleDropdown1.Items.AddRange(new object[] { "Tank", "DPS", "Support" });
            RoleDropdown1.Location = new Point(195, 54);
            RoleDropdown1.Name = "RoleDropdown1";
            RoleDropdown1.Size = new Size(121, 23);
            RoleDropdown1.TabIndex = 6;
            RoleDropdown1.Text = "Select role";
            RoleDropdown1.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(322, 57);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 7;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(16, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // OnePlayerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 131);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(RoleDropdown1);
            Controls.Add(checkBox1);
            Controls.Add(BackButton);
            Controls.Add(RandomiseButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PlayerOneNameBox);
            Name = "OnePlayerForm";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private PictureBox pictureBox1;
    }
}