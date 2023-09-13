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

        public string GetRole()
        {
            int selectedRoleIndex = rnd.Next(rolesList.Count);
            playerRole = rolesList[selectedRoleIndex];
            pickedRoles.Add(playerRole);
            rolesList.RemoveAt(selectedRoleIndex);
            return playerRole;

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
        
    }
}
