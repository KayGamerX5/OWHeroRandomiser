using OW_Hero_Randomiser.Data;
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
        public TwoPlayerForm()
        {
            InitializeComponent();
        }

        private void RandomiseButton_Click(object sender, EventArgs e)
        {
            string PlayerOneName = PlayerOneNameBox.Text;
            List<int> RolesList = Roles.rolesList;
            Random rnd = new Random();
            int p1RadomRoleIndex = rnd.Next(RolesList.Count);
            int p1Role = RolesList[p1RadomRoleIndex];
            RolesList.RemoveAt(p1RadomRoleIndex);
            List<string> TanksList = TankHeroes.tanksList;
            List<string> DamageHeroesList = DamageHeroes.damageHeroesList;
            List<string> SupportsList = SupportHeroes.supportsList;
            string p1Hero = "";
            if (p1Role == 1)
            {
                string p1role = "Tank";
                int p1RandomHeroIndex = rnd.Next(TanksList.Count);
                p1Hero = TanksList[p1RandomHeroIndex];
                PlayerOneLabel.Text = PlayerOneName + ": " + p1role + ", " + p1Hero;
                TanksList.RemoveAt(p1RandomHeroIndex);
            }

            else if (p1Role == 2 || p1Role == 3)
            {
                string p1role = "Damage";
                int p1RandomHeroIndex = rnd.Next(DamageHeroesList.Count);
                p1Hero = DamageHeroesList[p1RandomHeroIndex];
                PlayerOneLabel.Text = PlayerOneName + ": " + p1role + ", " + p1Hero;
                DamageHeroesList.RemoveAt(p1RandomHeroIndex);
            }

            else if (p1Role == 4 || p1Role == 5)
            {
                string p1role = "Support";
                int p1RandomHeroIndex = rnd.Next(SupportsList.Count);
                p1Hero = SupportsList[p1RandomHeroIndex];
                PlayerOneLabel.Text = PlayerOneName + ": " + p1role + ", " + p1Hero;
                SupportsList.RemoveAt(p1RandomHeroIndex);
            }

            else
            {
                PlayerOneLabel.Text = PlayerOneName + ": An error occurred";
            }

            //--------------------------

            string PlayerTwoName = PlayerTwoNameBox.Text;
            int p2RandomRoleIndex = rnd.Next(RolesList.Count);
            int p2Role = RolesList[p2RandomRoleIndex];

            if (p2Role == 1)
            {
                string p2role = "Tank";
                int p2RandomHeroIndex = rnd.Next(TanksList.Count);
                string p2Hero = TanksList[p2RandomHeroIndex];
                PlayerTwoLabel.Text = PlayerTwoName + ": " + p2role + ", " + p2Hero;
            }

            else if (p2Role == 2 || p2Role == 3)
            {
                string p2role = "Damage";
                int p2RandomHeroIndex = rnd.Next(DamageHeroesList.Count);
                string p2Hero = DamageHeroesList[p2RandomHeroIndex];
                PlayerTwoLabel.Text = PlayerTwoName + ": " + p2role + ", " + p2Hero;
            }

            else if (p2Role == 4 || p2Role == 5)
            {
                string p2role = "Support";
                int p2RandomHeroIndex = rnd.Next(SupportsList.Count);
                string p2Hero = SupportsList[p2RandomHeroIndex];
                PlayerTwoLabel.Text = PlayerTwoName + ": " + p2role + ", " + p2Hero;
            }

            else
            {
                PlayerTwoLabel.Text = PlayerTwoName + ": An error occurred";
            }

            RolesList.Add(p1Role);
            if(p1Role == 1)
            {
                TanksList.Add(p1Hero);
            }
            else if(p1Role == 2 || p1Role == 3)
            {
                DamageHeroesList.Add(p1Hero);
            }
            else if(p1Role == 4 || p1Role == 5)
            {
                SupportsList.Add(p1Hero);
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
