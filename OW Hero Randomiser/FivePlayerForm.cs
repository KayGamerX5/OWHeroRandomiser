using OW_Hero_Randomiser.Data;
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
            List<int> RolesList = Roles.rolesList;
            Random rnd = new Random();

            string PlayerOneName = PlayerOneNameBox.Text;
            int p1RadomRoleIndex = rnd.Next(RolesList.Count);
            int p1Role = RolesList[p1RadomRoleIndex];
            RolesList.RemoveAt(p1RadomRoleIndex);
            string p1Hero = string.Empty;

            string PlayerTwoName = PlayerTwoNameBox.Text;
            int p2RandomRoleIndex = rnd.Next(RolesList.Count);
            int p2Role = RolesList[p2RandomRoleIndex];
            RolesList.RemoveAt(p2RandomRoleIndex);
            string p2Hero = string.Empty;

            string PlayerThreeName = PlayerThreeNameBox.Text;
            int p3RandomRoleIndex = rnd.Next(RolesList.Count);
            int p3Role = RolesList[p3RandomRoleIndex];
            RolesList.RemoveAt(p3RandomRoleIndex);
            string p3Hero = string.Empty;

            string PlayerFourName = PlayerFourNameBox.Text;
            int p4RandomRoleIndex = rnd.Next(RolesList.Count);
            int p4Role = RolesList[p4RandomRoleIndex];
            RolesList.RemoveAt(p4RandomRoleIndex);
            string p4Hero = string.Empty;

            string PlayerFiveName = PlayerFiveNameBox.Text;
            int p5RandomRoleIndex = rnd.Next(RolesList.Count);
            int p5Role = RolesList[p5RandomRoleIndex];
            string p5Hero = string.Empty;

            List<string> TanksList = TankHeroes.tanksList;
            List<string> DamageHeroesList = DamageHeroes.damageHeroesList;
            List<string> SupportsList = SupportHeroes.supportsList;

            if (checkBox1.Checked == false)
            {
                if (p1Role == 1)
                {
                    string p1role = "Tank";
                    int p1RandomHeroIndex = rnd.Next(TanksList.Count);
                    p1Hero = TanksList[p1RandomHeroIndex];
                    PlayerOneNameLabel.Text = PlayerOneName + ": " + p1role + ", " + p1Hero;
                    TanksList.RemoveAt(p1RandomHeroIndex);
                }

                else if (p1Role == 2 || p1Role == 3)
                {
                    string p1role = "Damage";
                    int p1RandomHeroIndex = rnd.Next(DamageHeroesList.Count);
                    p1Hero = DamageHeroesList[p1RandomHeroIndex];
                    PlayerOneNameLabel.Text = PlayerOneName + ": " + p1role + ", " + p1Hero;
                    DamageHeroesList.RemoveAt(p1RandomHeroIndex);
                }

                else if (p1Role == 4 || p1Role == 5)
                {
                    string p1role = "Support";
                    int p1RandomHeroIndex = rnd.Next(SupportsList.Count);
                    p1Hero = SupportsList[p1RandomHeroIndex];
                    PlayerOneNameLabel.Text = PlayerOneName + ": " + p1role + ", " + p1Hero;
                    SupportsList.RemoveAt(p1RandomHeroIndex);
                }

                else
                {
                    PlayerOneNameLabel.Text = PlayerOneName + ": An error occurred";
                }

                //--------------------------

                if (p2Role == 1)
                {
                    string p2role = "Tank";
                    int p2RandomHeroIndex = rnd.Next(TanksList.Count);
                    p2Hero = TanksList[p2RandomHeroIndex];
                    PlayerTwoNameLabel.Text = PlayerTwoName + ": " + p2role + ", " + p2Hero;
                    TanksList.RemoveAt(p2RandomHeroIndex);
                }

                else if (p2Role == 2 || p2Role == 3)
                {
                    string p2role = "Damage";
                    int p2RandomHeroIndex = rnd.Next(DamageHeroesList.Count);
                    p2Hero = DamageHeroesList[p2RandomHeroIndex];
                    PlayerTwoNameLabel.Text = PlayerTwoName + ": " + p2role + ", " + p2Hero;
                    DamageHeroesList.RemoveAt(p2RandomHeroIndex);
                }

                else if (p2Role == 4 || p2Role == 5)
                {
                    string p2role = "Support";
                    int p2RandomHeroIndex = rnd.Next(SupportsList.Count);
                    p2Hero = SupportsList[p2RandomHeroIndex];
                    PlayerTwoNameLabel.Text = PlayerTwoName + ": " + p2role + ", " + p2Hero;
                    SupportsList.RemoveAt(p2RandomHeroIndex);
                }

                else
                {
                    PlayerTwoNameLabel.Text = PlayerTwoName + ": An error occurred";
                }

                //-----------------------------

                if (p3Role == 1)
                {
                    string p3role = "Tank";
                    int p3RandomHeroIndex = rnd.Next(TanksList.Count);
                    p3Hero = TanksList[p3RandomHeroIndex];
                    PlayerThreeNameLabel.Text = PlayerThreeName + ": " + p3role + ", " + p3Hero;
                    TanksList.RemoveAt(p3RandomHeroIndex);
                }

                else if (p3Role == 2 || p3Role == 3)
                {
                    string p3role = "Damage";
                    int p3RandomHeroIndex = rnd.Next(DamageHeroesList.Count);
                    p3Hero = DamageHeroesList[p3RandomHeroIndex];
                    PlayerThreeNameLabel.Text = PlayerThreeName + ": " + p3role + ", " + p3Hero;
                    DamageHeroesList.RemoveAt(p3RandomHeroIndex);
                }

                else if (p3Role == 4 || p3Role == 5)
                {
                    string p3role = "Support";
                    int p3RandomHeroIndex = rnd.Next(SupportsList.Count);
                    p3Hero = SupportsList[p3RandomHeroIndex];
                    PlayerThreeNameLabel.Text = PlayerThreeName + ": " + p3role + ", " + p3Hero;
                    SupportsList.RemoveAt(p3RandomHeroIndex);
                }

                else
                {
                    PlayerThreeNameLabel.Text = PlayerThreeName + ": An error occurred";
                }

                //------------------------------------------------------

                if (p4Role == 1)
                {
                    string p4role = "Tank";
                    int p4RandomHeroIndex = rnd.Next(TanksList.Count);
                    p4Hero = TanksList[p4RandomHeroIndex];
                    PlayerFourNameLabel.Text = PlayerFourName + ": " + p4role + ", " + p4Hero;
                    TanksList.RemoveAt(p4RandomHeroIndex);
                }

                else if (p4Role == 2 || p4Role == 3)
                {
                    string p4role = "Damage";
                    int p4RandomHeroIndex = rnd.Next(DamageHeroesList.Count);
                    p4Hero = DamageHeroesList[p4RandomHeroIndex];
                    PlayerFourNameLabel.Text = PlayerFourName + ": " + p4role + ", " + p4Hero;
                    DamageHeroesList.RemoveAt(p4RandomHeroIndex);
                }

                else if (p4Role == 4 || p4Role == 5)
                {
                    string p4role = "Support";
                    int p4RandomHeroIndex = rnd.Next(SupportsList.Count);
                    p4Hero = SupportsList[p4RandomHeroIndex];
                    PlayerFourNameLabel.Text = PlayerFourName + ": " + p4role + ", " + p4Hero;
                    SupportsList.RemoveAt(p4RandomHeroIndex);
                }

                else
                {
                    PlayerFourNameLabel.Text = PlayerFourName + ": An error occurred";
                }

                //------------------------------------------------------

                if (p5Role == 1)
                {
                    string p5role = "Tank";
                    int p5RandomHeroIndex = rnd.Next(TanksList.Count);
                    p5Hero = TanksList[p5RandomHeroIndex];
                    PlayerFiveNameLabel.Text = PlayerFiveName + ": " + p5role + ", " + p5Hero;
                }

                else if (p5Role == 2 || p5Role == 3)
                {
                    string p5role = "Damage";
                    int p5RandomHeroIndex = rnd.Next(DamageHeroesList.Count);
                    p5Hero = DamageHeroesList[p5RandomHeroIndex];
                    PlayerFiveNameLabel.Text = PlayerFiveName + ": " + p5role + ", " + p5Hero;
                }

                else if (p5Role == 4 || p5Role == 5)
                {
                    string p5role = "Support";
                    int p5RandomHeroIndex = rnd.Next(SupportsList.Count);
                    p5Hero = SupportsList[p5RandomHeroIndex];
                    PlayerFiveNameLabel.Text = PlayerFiveName + ": " + p5role + ", " + p5Hero;
                }

                else
                {
                    PlayerFiveNameLabel.Text = PlayerFiveName + ": An error occurred";
                }

                //------------------------------------------------------

                RolesList.Add(p1Role);
                RolesList.Add(p2Role);
                RolesList.Add(p3Role);
                RolesList.Add(p4Role);
                if (p1Role == 1)
                {
                    TanksList.Add(p1Hero);
                }
                else if (p1Role == 2 || p1Role == 3)
                {
                    DamageHeroesList.Add(p1Hero);
                }
                else if (p1Role == 4 || p1Role == 5)
                {
                    SupportsList.Add(p1Hero);
                }

                if (p2Role == 1)
                {
                    TanksList.Add(p2Hero);
                }
                else if (p2Role == 2 || p2Role == 3)
                {
                    DamageHeroesList.Add(p2Hero);
                }
                else if (p2Role == 4 || p2Role == 5)
                {
                    SupportsList.Add(p2Hero);
                }

                if (p3Role == 1)
                {
                    TanksList.Add(p3Hero);
                }
                else if (p3Role == 2 || p3Role == 3)
                {
                    DamageHeroesList.Add(p3Hero);
                }
                else if (p3Role == 4 || p3Role == 5)
                {
                    SupportsList.Add(p3Hero);
                }

                if (p4Role == 1)
                {
                    TanksList.Add(p4Hero);
                }
                else if (p4Role == 2 || p4Role == 3)
                {
                    DamageHeroesList.Add(p4Hero);
                }
                else if (p4Role == 4 || p4Role == 5)
                {
                    SupportsList.Add(p4Hero);
                }
            }
            else
            {
                if (roleDropdown1.SelectedIndex == 0)
                {
                    string p1role = "Tank";
                    int p1RandomHeroIndex = rnd.Next(TanksList.Count);
                    p1Hero = TanksList[p1RandomHeroIndex];
                    PlayerOneSelectedRoleLabel.Text = PlayerOneName + ": " + p1role + ", " + p1Hero;
                    TanksList.RemoveAt(p1RandomHeroIndex);
                }

                else if (roleDropdown1.SelectedIndex == 1)
                {
                    string p1role = "Damage";
                    int p1RandomHeroIndex = rnd.Next(DamageHeroesList.Count);
                    p1Hero = DamageHeroesList[p1RandomHeroIndex];
                    PlayerOneSelectedRoleLabel.Text = PlayerOneName + ": " + p1role + ", " + p1Hero;
                    DamageHeroesList.RemoveAt(p1RandomHeroIndex);
                }

                else if (roleDropdown1.SelectedIndex == 2)
                {
                    string p1role = "Support";
                    int p1RandomHeroIndex = rnd.Next(SupportsList.Count);
                    p1Hero = SupportsList[p1RandomHeroIndex];
                    PlayerOneSelectedRoleLabel.Text = PlayerOneName + ": " + p1role + ", " + p1Hero;
                    SupportsList.RemoveAt(p1RandomHeroIndex);
                }

                else
                {
                    PlayerOneSelectedRoleLabel.Text = PlayerOneName + " An error occurred";
                }

                //-----------------------------------------------

                if (roleDropdown2.SelectedIndex == 0)
                {
                    string p2role = "Tank";
                    int p2RandomHeroIndex = rnd.Next(TanksList.Count);
                    p2Hero = TanksList[p2RandomHeroIndex];
                    PlayerTwoSelectedRoleLabel.Text = PlayerTwoName + ": " + p2role + ", " + p2Hero;
                    TanksList.RemoveAt(p2RandomHeroIndex);
                }

                else if (roleDropdown2.SelectedIndex == 1)
                {
                    string p2role = "Damage";
                    int p2RandomHeroIndex = rnd.Next(DamageHeroesList.Count);
                    p2Hero = DamageHeroesList[p2RandomHeroIndex];
                    PlayerTwoSelectedRoleLabel.Text = PlayerTwoName + ": " + p2role + ", " + p2Hero;
                    DamageHeroesList.RemoveAt(p2RandomHeroIndex);
                }

                else if (roleDropdown2.SelectedIndex == 2)
                {
                    string p2role = "Support";
                    int p2RandomHeroIndex = rnd.Next(SupportsList.Count);
                    p2Hero = SupportsList[p2RandomHeroIndex];
                    PlayerTwoSelectedRoleLabel.Text = PlayerTwoName + ": " + p2role + ", " + p2Hero;
                    SupportsList.RemoveAt(p2RandomHeroIndex);
                }

                else
                {
                    PlayerTwoSelectedRoleLabel.Text = PlayerTwoName + " An error occurred";
                }

                //------------------------------------------


                if (roleDropdown3.SelectedIndex == 0)
                {
                    string p3role = "Tank";
                    int p3RandomHeroIndex = rnd.Next(TanksList.Count);
                    p3Hero = TanksList[p3RandomHeroIndex];
                    PlayerThreeSelectedRoleLabel.Text = PlayerThreeName + ": " + p3role + ", " + p3Hero;
                    TanksList.RemoveAt(p3RandomHeroIndex);
                }

                else if (roleDropdown3.SelectedIndex == 1)
                {
                    string p3role = "Damage";
                    int p3RandomHeroIndex = rnd.Next(DamageHeroesList.Count);
                    p3Hero = DamageHeroesList[p3RandomHeroIndex];
                    PlayerThreeSelectedRoleLabel.Text = PlayerThreeName + ": " + p3role + ", " + p3Hero;
                    DamageHeroesList.RemoveAt(p3RandomHeroIndex);
                }

                else if (roleDropdown3.SelectedIndex == 2)
                {
                    string p3role = "Support";
                    int p3RandomHeroIndex = rnd.Next(SupportsList.Count);
                    p3Hero = SupportsList[p3RandomHeroIndex];
                    PlayerThreeSelectedRoleLabel.Text = PlayerThreeName + ": " + p3role + ", " + p3Hero;
                    SupportsList.RemoveAt(p3RandomHeroIndex);
                }

                else
                {
                    PlayerThreeSelectedRoleLabel.Text = PlayerThreeName + " An error occurred";
                }

                //-----------------------------------------------------------

                if (roleDropdown4.SelectedIndex == 0)
                {
                    string p4role = "Tank";
                    int p4RandomHeroIndex = rnd.Next(TanksList.Count);
                    p4Hero = TanksList[p4RandomHeroIndex];
                    PlayerFourSelectedRoleLabel.Text = PlayerFourName + ": " + p4role + ", " + p4Hero;
                    TanksList.RemoveAt(p4RandomHeroIndex);
                }

                else if (roleDropdown4.SelectedIndex == 1)
                {
                    string p4role = "Damage";
                    int p4RandomHeroIndex = rnd.Next(DamageHeroesList.Count);
                    p4Hero = DamageHeroesList[p4RandomHeroIndex];
                    PlayerFourSelectedRoleLabel.Text = PlayerFourName + ": " + p4role + ", " + p4Hero;
                    DamageHeroesList.RemoveAt(p4RandomHeroIndex);
                }

                else if (roleDropdown4.SelectedIndex == 2)
                {
                    string p4role = "Support";
                    int p4RandomHeroIndex = rnd.Next(SupportsList.Count);
                    p4Hero = SupportsList[p4RandomHeroIndex];
                    PlayerFourSelectedRoleLabel.Text = PlayerFourName + ": " + p4role + ", " + p4Hero;
                    SupportsList.RemoveAt(p4RandomHeroIndex);
                }

                else
                {
                    PlayerFourSelectedRoleLabel.Text = PlayerFourName + " An error occurred";
                }

                //-----------------------------------------------------------

                if (roleDropdown5.SelectedIndex == 0)
                {
                    string p5role = "Tank";
                    int p5RandomHeroIndex = rnd.Next(TanksList.Count);
                    p5Hero = TanksList[p5RandomHeroIndex];
                    PlayerFiveSelectedRoleLabel.Text = PlayerFiveName + ": " + p5role + ", " + p5Hero;
                }

                else if (roleDropdown5.SelectedIndex == 1)
                {
                    string p5role = "Damage";
                    int p5RandomHeroIndex = rnd.Next(DamageHeroesList.Count);
                    p5Hero = DamageHeroesList[p5RandomHeroIndex];
                    PlayerFiveSelectedRoleLabel.Text = PlayerFiveName + ": " + p5role + ", " + p5Hero;
                }

                else if (roleDropdown5.SelectedIndex == 2)
                {
                    string p5role = "Support";
                    int p5RandomHeroIndex = rnd.Next(SupportsList.Count);
                    p5Hero = SupportsList[p5RandomHeroIndex];
                    PlayerFiveSelectedRoleLabel.Text = PlayerFiveName + ": " + p5role + ", " + p5Hero;
                }

                else
                {
                    PlayerFiveSelectedRoleLabel.Text = PlayerFiveName + " An error occurred";
                }

                RolesList.Add(p1Role);
                RolesList.Add(p2Role);
                RolesList.Add(p3Role);
                RolesList.Add(p4Role);
                if (roleDropdown1.SelectedIndex == 0)
                {
                    TanksList.Add(p1Hero);
                }
                else if (roleDropdown1.SelectedIndex == 1)
                {
                    DamageHeroesList.Add(p1Hero);
                }
                else if (roleDropdown1.SelectedIndex == 2)
                {
                    SupportsList.Add(p1Hero);
                }
                //--------------------------------
                if (roleDropdown2.SelectedIndex == 0)
                {
                    TanksList.Add(p2Hero);
                }
                else if (roleDropdown2.SelectedIndex == 1)
                {
                    DamageHeroesList.Add(p2Hero);
                }
                else if (roleDropdown2.SelectedIndex == 2)
                {
                    SupportsList.Add(p2Hero);
                }
                //----------------------------
                if (roleDropdown3.SelectedIndex == 0)
                {
                    TanksList.Add(p3Hero);
                }
                else if (roleDropdown3.SelectedIndex == 1)
                {
                    DamageHeroesList.Add(p3Hero);
                }
                else if (roleDropdown3.SelectedIndex == 2)
                {
                    SupportsList.Add(p3Hero);
                }
                //----------------------------
                if (roleDropdown4.SelectedIndex == 0)
                {
                    TanksList.Add(p4Hero);
                }
                else if (roleDropdown4.SelectedIndex == 1)
                {
                    DamageHeroesList.Add(p4Hero);
                }
                else if (roleDropdown4.SelectedIndex == 2)
                {
                    SupportsList.Add(p4Hero);
                }
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
