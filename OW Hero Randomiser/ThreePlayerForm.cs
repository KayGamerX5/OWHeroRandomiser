using OW_Hero_Randomiser.Data;
using OW_Hero_Randomiser.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OW_Hero_Randomiser
{
    public partial class ThreePlayerForm : Form
    {
        Functions functions = new Functions();
        public ThreePlayerForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                roleDropdown1.Visible = true;
                roleDropdown2.Visible = true;
                roleDropdown3.Visible = true;
                PlayerOneNameLabel.Visible = false;
                PlayerTwoNameLabel.Visible = false;
                PlayerThreeNameLabel.Visible = false;
                PlayerOneSelectedRoleLabel.Visible = true;
                PlayerTwoSelectedRoleLabel.Visible = true;
                PlayerThreeSelectedRoleLabel.Visible = true;
            }
            if (checkBox1.Checked == false)
            {
                roleDropdown1.Visible = false;
                roleDropdown2.Visible = false;
                roleDropdown3.Visible = false;
                PlayerOneNameLabel.Visible = true;
                PlayerTwoNameLabel.Visible = true;
                PlayerThreeNameLabel.Visible = true;
                PlayerOneSelectedRoleLabel.Visible = false;
                PlayerTwoSelectedRoleLabel.Visible = false;
                PlayerThreeSelectedRoleLabel.Visible = false;
            }
        }

        private void RandomiseButton_Click(object sender, EventArgs e)
        {
            string playerOneName = PlayerOneNameBox.Text;
            string playerTwoName = PlayerTwoNameBox.Text;
            string playerThreeName = PlayerThreeNameBox.Text;

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

                PlayerOneNameLabel.Text = playerOneName + ": " + playerOneRole + ", " + playerOneHero;
                PlayerTwoNameLabel.Text = playerTwoName + ": " + playerTwoRole + ", " + playerTwoHero;
                PlayerThreeNameLabel.Text = playerThreeName + ": " + playerThreeRole + ", " + playerThreeHero;

                Image playerOneHeroIcon = functions.GetHeroIcon(playerOneHero);
                pictureBox1.Image = playerOneHeroIcon;

                Image playerTwoHeroIcon = functions.GetHeroIcon(playerTwoHero);
                pictureBox2.Image = playerTwoHeroIcon;

                Image playerThreeHeroIcon = functions.GetHeroIcon(playerThreeHero);
                pictureBox3.Image = playerThreeHeroIcon;

                functions.ResetRoles();
                functions.ResetHeroes();
            }

            if (checkBox1.Checked == true)
            {
                int playerOneSelectedIndex = roleDropdown1.SelectedIndex;
                int playerTwoSelectedIndex = roleDropdown2.SelectedIndex;
                int playerThreeSelectedIndex = roleDropdown3.SelectedIndex;

                string playerOneRole = functions.GetRoleBySelectedIndex(playerOneSelectedIndex);
                string playerTwoRole = functions.GetRoleBySelectedIndex(playerTwoSelectedIndex);
                string playerThreeRole = functions.GetRoleBySelectedIndex(playerThreeSelectedIndex);

                string playerOneHero = functions.GetHeroBySelectedIndex(playerOneSelectedIndex);
                string playerTwoHero = functions.GetHeroBySelectedIndex(playerTwoSelectedIndex);
                string playerThreeHero = functions.GetHeroBySelectedIndex(playerThreeSelectedIndex);

                PlayerOneSelectedRoleLabel.Text = playerOneName + ": " + playerOneRole + ", " + playerOneHero;
                PlayerTwoSelectedRoleLabel.Text = playerTwoName + ": " + playerTwoRole + ", " + playerTwoHero;
                PlayerThreeSelectedRoleLabel.Text = playerThreeName + ": " + playerThreeRole + ", " + playerThreeHero;

                Image playerOneHeroIcon = functions.GetHeroIcon(playerOneHero);
                pictureBox1.Image = playerOneHeroIcon;

                Image playerTwoHeroIcon = functions.GetHeroIcon(playerTwoHero);
                pictureBox2.Image = playerTwoHeroIcon;

                Image playerThreeHeroIcon = functions.GetHeroIcon(playerThreeHero);
                pictureBox3.Image = playerThreeHeroIcon;

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
