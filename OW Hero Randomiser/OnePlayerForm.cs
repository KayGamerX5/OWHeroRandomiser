using Microsoft.VisualBasic.ApplicationServices;
using OW_Hero_Randomiser.Data;
using OW_Hero_Randomiser.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace OW_Hero_Randomiser
{
    public partial class OnePlayerForm : Form
    {
        Functions functions = new Functions();
        public OnePlayerForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                RoleDropdown1.Visible = true;
                label2.Visible = false;
                label3.Visible = true;
            }
            if (checkBox1.Checked == false)
            {
                RoleDropdown1.Visible = false;
                label2.Visible = true;
                label3.Visible = false;
            }
        }

        private void RandomiseButton_Click(object sender, EventArgs e)
        {
            string playerOneName = PlayerOneNameBox.Text;

            if (checkBox1.Checked == false)
            {
                string playerOneRole = functions.GetRole();

                string playerOneHero = functions.GetHero(playerOneRole);
                label2.Text = playerOneName + ": " + playerOneRole + ", " + playerOneHero;
                
                Image heroIcon = functions.GetHeroIcon(playerOneHero);
                pictureBox1.Image = heroIcon;

                functions.ResetRoles();
                functions.ResetHeroes();
            }

            if (checkBox1.Checked == true)
            {
                int playerOneSelectedIndex = RoleDropdown1.SelectedIndex;

                string playerOneRole = functions.GetRoleBySelectedIndex(playerOneSelectedIndex);

                string playerOneHero = functions.GetHeroBySelectedIndex(playerOneSelectedIndex);

                label3.Text = playerOneName + ": " + playerOneRole + ", " + playerOneHero;

                Image heroIcon = functions.GetHeroIcon(playerOneHero);
                pictureBox1.Image = heroIcon;

                functions.ResetRoles();
                functions.ResetHeroes();
            }

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainForm Check = new MainForm();
            Check.Show();
            Hide();
        }

    }
}
