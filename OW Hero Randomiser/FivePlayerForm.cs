﻿using OW_Hero_Randomiser.Data;
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
    public partial class FivePlayerForm : Form
    {
        Functions functions = new Functions();
        public FivePlayerForm()
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
                roleDropdown4.Visible = true;
                roleDropdown5.Visible = true;
                PlayerOneNameLabel.Visible = false;
                PlayerTwoNameLabel.Visible = false;
                PlayerThreeNameLabel.Visible = false;
                PlayerFourNameLabel.Visible = false;
                PlayerFiveNameLabel.Visible = false;
                PlayerOneSelectedRoleLabel.Visible = true;
                PlayerTwoSelectedRoleLabel.Visible = true;
                PlayerThreeSelectedRoleLabel.Visible = true;
                PlayerFourSelectedRoleLabel.Visible = true;
                PlayerFiveSelectedRoleLabel.Visible = true;
            }
            if (checkBox1.Checked == false)
            {
                roleDropdown1.Visible = false;
                roleDropdown2.Visible = false;
                roleDropdown3.Visible = false;
                roleDropdown4.Visible = false;
                roleDropdown5.Visible = false;
                PlayerOneNameLabel.Visible = true;
                PlayerTwoNameLabel.Visible = true;
                PlayerThreeNameLabel.Visible = true;
                PlayerFourNameLabel.Visible = true;
                PlayerFiveNameLabel.Visible = true;
                PlayerOneSelectedRoleLabel.Visible = false;
                PlayerTwoSelectedRoleLabel.Visible = false;
                PlayerThreeSelectedRoleLabel.Visible = false;
                PlayerFourSelectedRoleLabel.Visible = false;
                PlayerFiveSelectedRoleLabel.Visible = false;
            }
        }

        private void RandomiseButton_Click(object sender, EventArgs e)
        {
            string playerOneName = PlayerOneNameBox.Text;
            string playerTwoName = PlayerTwoNameBox.Text;
            string playerThreeName = PlayerThreeNameBox.Text;
            string playerFourName = PlayerFourNameBox.Text;
            string playerFiveName = PlayerFiveNameBox.Text;

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

            PlayerOneNameLabel.Text = playerOneName + playerOneRole + playerOneHero;
            PlayerTwoNameLabel.Text = playerTwoName + playerTwoRole + playerTwoHero;
            PlayerThreeNameLabel.Text = playerThreeName + playerThreeRole + playerThreeHero;
            PlayerFourNameLabel.Text= playerFourName + playerFourRole + playerFourHero;
            PlayerFiveNameLabel.Text= playerFiveName + playerFiveRole + playerFiveHero;

            functions.ResetRoles();
            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainForm Check = new MainForm();
            Check.Show();
            Hide();
        }
    }
}
