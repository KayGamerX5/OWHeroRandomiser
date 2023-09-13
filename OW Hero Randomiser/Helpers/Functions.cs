using OW_Hero_Randomiser.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OW_Hero_Randomiser.Helpers
{
    public class Functions
    {
        List<string> rolesList = Roles.rolesList;
        List<string> pickedRoles = new List<string>();
        List<string> damageHeroes = DamageHeroes.damageHeroesList;
        List<string> pickedDamageHeroes = new List<string>();
        List<string> tankHeroes = TankHeroes.tanksList;
        List<string> pickedTankHeroes = new List<string>(); 
        List<string> supportHeroes = SupportHeroes.supportsList;
        List<string> pickedSupportHeroes = new List<string>();
        string playerRole = string.Empty;
        string playerHero = string.Empty;
        Random rnd = new Random();
        int index;

        public string GetRole()
        {
            int selectedRoleIndex = rnd.Next(rolesList.Count);
            playerRole = rolesList[selectedRoleIndex];
            pickedRoles.Add(playerRole);
            rolesList.RemoveAt(selectedRoleIndex);
            return playerRole;

        }

        public string GetRoleBySelectedIndex(int index)
        {
            string role = string.Empty;
            if (index != -1)
            {
                if (index == 0)
                {
                    role = "Tank";
                }
                if (index == 1)
                {
                    role = "Damage";
                }
                if (index == 2)
                {
                    role = "Support";
                }
                return role;
            }
            else
            {
                role = "Oops, something went wrong...";
                return role;
            }
        }

        public string GetHero(string role)
        {
            if (role != null) 
            {
                if (role == "Tank")
                {
                    int selectedHeroIndex = rnd.Next(tankHeroes.Count);
                    playerHero = tankHeroes[selectedHeroIndex];
                    pickedTankHeroes.Add(playerHero);
                    tankHeroes.RemoveAt(selectedHeroIndex);
                }
                else if (role == "Damage")
                {
                    int selectedHeroIndex = rnd.Next(damageHeroes.Count);
                    playerHero = damageHeroes[selectedHeroIndex];
                    pickedDamageHeroes.Add(playerHero);
                    damageHeroes.RemoveAt(selectedHeroIndex);
                }
                else if(role == "Support")
                {
                    int selectedHeroIndex = rnd.Next(supportHeroes.Count);
                    playerHero = supportHeroes[selectedHeroIndex];
                    pickedSupportHeroes.Add(playerHero);
                    supportHeroes.RemoveAt(selectedHeroIndex);
                }
                else
                {
                    playerHero = "Oops, something went wrong...";
                }
                return playerHero;
            }
            else
            {
                playerHero = "Oops, something went wrong...";
                return playerHero;
            }
        }

        public string GetHeroBySelectedIndex(int index)
        {
            if(index != -1)
            {
                
                if (index == 0)
                {
                    int selectedHeroIndex = rnd.Next(tankHeroes.Count);
                    playerHero = tankHeroes[selectedHeroIndex];
                    pickedTankHeroes.Add(playerHero);
                    tankHeroes.RemoveAt(selectedHeroIndex);
                }
                else if (index == 1)
                {
                    int selectedHeroIndex = rnd.Next(damageHeroes.Count);
                    playerHero = damageHeroes[selectedHeroIndex];
                    pickedDamageHeroes.Add(playerHero);
                    damageHeroes.RemoveAt(selectedHeroIndex);
                }
                else if (index == 2)
                {
                    int selectedHeroIndex = rnd.Next(supportHeroes.Count);
                    playerHero = supportHeroes[selectedHeroIndex];
                    pickedSupportHeroes.Add(playerHero);
                    supportHeroes.RemoveAt(selectedHeroIndex);
                }
                else
                {
                    playerHero = "Oops, something went wrong...";
                }
                return playerHero;
            }
            else
            {
                playerHero = "Oops, something went wrong...";
                return playerHero;
            }
        }

        public List<string> ResetRoles()
        {
            foreach(string role in pickedRoles) 
            { 
                rolesList.Add(role);
            }
            foreach(string role in rolesList)
            {
                pickedRoles.Remove(role);
            }
            return rolesList;
        }

        // VVV Still needs fixing

        public List<string> ResetHeroes()
        {
            if (pickedTankHeroes.Count > 0)
            {
                foreach (string role in pickedTankHeroes)
                {
                    tankHeroes.Add(role);
                    index = pickedTankHeroes.IndexOf(role);
                }
            }
            if (pickedDamageHeroes.Count > 0)
            {
                foreach (string role in pickedDamageHeroes)
                {
                    damageHeroes.Add(role);
                    index = pickedDamageHeroes.IndexOf(role);
                }
            }
            if (pickedSupportHeroes.Count > 0)
            {
                foreach (string role in pickedSupportHeroes)
                {
                    supportHeroes.Add(role);
                    index = pickedSupportHeroes.IndexOf(role);
                }
            }
            
            pickedTankHeroes.RemoveRange(0 , pickedTankHeroes.Count);
            pickedDamageHeroes.RemoveRange(0, pickedDamageHeroes.Count);
            pickedSupportHeroes.RemoveRange(0, pickedSupportHeroes.Count);
            return tankHeroes;
        }
        
    }
}
