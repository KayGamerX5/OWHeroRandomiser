using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OW_Hero_Randomiser.Data
{
    public class TankHeroes
    {
        private static readonly List<string> TanksList = new List<string>()
        {
            
            "Reinhardt", "Zarya", "Sigma", "Orisa", "Winston", "Wreckingball",
            "Junkerqueen", "D.va", "Doomfist", "Roadhog", "Ramattra", "Hazard"
        };

        public static List<string> tanksList { get { return TanksList; } }

        

       
    }
}
