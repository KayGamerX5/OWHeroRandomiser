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
    public partial class OnePlayerForm : Form
    {
        public OnePlayerForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        

        private void OnePlayerForm_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                RoleDropdown1.Visible = true;
                label2.Visible = false;
                label3.Visible = true;
            }
            if(checkBox1.Checked == false)
            {
                RoleDropdown1.Visible=false;
                label2.Visible=true;
                label3.Visible=false;
            }
        }

        private void RandomiseButton_Click(object sender, EventArgs e)
        {
            string PlayerOneName = PlayerOneNameBox.Text;
            List<int> RolesList = Roles.rolesList;
            Random rnd = new Random();
            int p1RadomRoleIndex = rnd.Next(RolesList.Count);
            int p1Role = RolesList[p1RadomRoleIndex];
            if (checkBox1.Checked == false)
            {
                if (p1Role == 1)
                {
                    string p1role = "Tank";
                    List<string> TanksList = TankHeroes.tanksList;
                    int p1RandomHeroIndex = rnd.Next(TanksList.Count);
                    string p1Hero = TanksList[p1RandomHeroIndex];
                    label2.Text = PlayerOneName + ": " + p1role + ", " + p1Hero;
                }

                else if (p1Role == 2 || p1Role == 3)
                {
                    string p1role = "Damage";
                    List<string> DamageHeroesList = DamageHeroes.damageHeroesList;
                    int p1RandomHeroIndex = rnd.Next(DamageHeroesList.Count);
                    string p1Hero = DamageHeroesList[p1RandomHeroIndex];
                    label2.Text = PlayerOneName + ": " + p1role + ", " + p1Hero;
                }

                else if (p1Role == 4 || p1Role == 5)
                {
                    string p1role = "Support";
                    List<string> SupportsList = SupportHeroes.supportsList;
                    int p1RandomHeroIndex = rnd.Next(SupportsList.Count);
                    string p1Hero = SupportsList[p1RandomHeroIndex];
                    label2.Text = PlayerOneName + ": " + p1role + ", " + p1Hero;
                }

                else
                {
                    label2.Text = PlayerOneName + " An error occurred";
                }
            }
            else
            {
                if(RoleDropdown1.SelectedIndex == 0)
                {
                    string p1role = "Tank";
                    List<string> TanksList = TankHeroes.tanksList;
                    int p1RandomHeroIndex = rnd.Next(TanksList.Count);
                    string p1Hero = TanksList[p1RandomHeroIndex];
                    label3.Text = PlayerOneName + ": " + p1role + ", " + p1Hero;
                }

                else if(RoleDropdown1.SelectedIndex == 1)
                {
                    string p1role = "Damage";
                    List<string> DamageHeroesList = DamageHeroes.damageHeroesList;
                    int p1RandomHeroIndex = rnd.Next(DamageHeroesList.Count);
                    string p1Hero = DamageHeroesList[p1RandomHeroIndex];
                    label3.Text = PlayerOneName + ": " + p1role + ", " + p1Hero;
                }

                else if(RoleDropdown1.SelectedIndex == 2)
                {
                    string p1role = "Support";
                    List<string> SupportsList = SupportHeroes.supportsList;
                    int p1RandomHeroIndex = rnd.Next(SupportsList.Count);
                    string p1Hero = SupportsList[p1RandomHeroIndex];
                    label3.Text = PlayerOneName + ": " + p1role + ", " + p1Hero;
                }

                else
                {
                    label3.Text = PlayerOneName + " An error occurred";
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
