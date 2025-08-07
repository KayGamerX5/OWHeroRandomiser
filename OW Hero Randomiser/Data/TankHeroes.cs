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

            "D.va",
            "Doomfist",
            "Hazard",
            "Junkerqueen",
            "Mauga",
            "Orisa",
            "Ramattra",
            "Reinhardt",
            "Roadhog",
            "Sigma",
            "Winston",
            "Wreckingball",
            "Zarya"
        };

        public static List<string> tanksList { get { return TanksList; } }

        

       
    }
}
