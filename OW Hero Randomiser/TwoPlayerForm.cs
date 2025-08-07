using OW_Hero_Randomiser.Data;
using OW_Hero_Randomiser.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OW_Hero_Randomiser
{
    public partial class TwoPlayerForm : Form
    {
        Functions functions = new Functions();
        public TwoPlayerForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                roleDropdown1.Visible = true;
                roleDropdown2.Visible = true;
                PlayerOneLabel.Visible = false;
                PlayerTwoLabel.Visible = false;
                PlayerOneSelectedRoleLabel.Visible = true;
                PlayerTwoSelectedRoleLabel.Visible = true;
            }
            if (checkBox1.Checked == false)
            {
                roleDropdown1.Visible = false;
                roleDropdown2.Visible = false;
                PlayerOneLabel.Visible = true;
                PlayerTwoLabel.Visible = true;
                PlayerOneSelectedRoleLabel.Visible = false;
                PlayerTwoSelectedRoleLabel.Visible = false;
            }
        }

        private void RandomiseButton_Click(object sender, EventArgs e)
        {
            string playerOneName = PlayerOneNameBox.Text;
            string playerTwoName = PlayerTwoNameBox.Text;

            if (checkBox1.Checked == false)
            {
                string playerOneRole = functions.GetRole();
                string playerTwoRole = functions.GetRole();
                string playerThreeRole = functions.GetRole();
                string playerFourRole = functions.GetRole();
                string playerFiveRole = functions.GetRole();

                string playerOneHero = functions.GetHero(playerOneRole);
                string playerTwoHero = functions.GetHero(playerTwoRole);
                string playerThreeHero = functions.GetHero(playerThreeRole);
                string playerFourHero = functions.GetHero(playerFourRole);
                string playerFiveHero = functions.GetHero(playerFiveRole);

                PlayerOneLabel.Text = playerOneName + ": " + playerOneRole + ", " + playerOneHero;
                PlayerTwoLabel.Text = playerTwoName + ": " + playerTwoRole + ", " + playerTwoHero;

                Image playerOneHeroIcon = functions.GetHeroIcon(playerOneHero);
                pictureBox1.Image = playerOneHeroIcon;

                Image playerTwoHeroIcon = functions.GetHeroIcon(playerTwoHero);
                pictureBox2.Image = playerTwoHeroIcon;

                functions.ResetRoles();
                functions.ResetHeroes();
            }

            if (checkBox1.Checked == true)
            {
                int playerOneSelectedIndex = roleDropdown1.SelectedIndex;
                int playerTwoSelectedIndex = roleDropdown2.SelectedIndex;

                string playerOneRole = functions.GetRoleBySelectedIndex(playerOneSelectedIndex);
                string playerTwoRole = functions.GetRoleBySelectedIndex(playerTwoSelectedIndex);

                string playerOneHero = functions.GetHeroBySelectedIndex(playerOneSelectedIndex);
                string playerTwoHero = functions.GetHeroBySelectedIndex(playerTwoSelectedIndex);

                PlayerOneSelectedRoleLabel.Text = playerOneName + ": " + playerOneRole + ", " + playerOneHero;
                PlayerTwoSelectedRoleLabel.Text = playerTwoName + ": " + playerTwoRole + ", " + playerTwoHero;

                Image playerOneHeroIcon = functions.GetHeroIcon(playerOneHero);
                pictureBox1.Image = playerOneHeroIcon;

                Image playerTwoHeroIcon = functions.GetHeroIcon(playerTwoHero);
                pictureBox2.Image = playerTwoHeroIcon;

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
