using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OW_Hero_Randomiser.Data
{
    internal class DamageHeroes
    {
        private static readonly List<string> DamageHeroesList = new List<string>()
        {
            "Ashe",
            "Bastion",
            "Cassidy",
            "Echo",
            "Freja", 
            "Genji",
            "Hanzo",
            "Junkrat",
            "Mei",
            "Pharah",
            "Reaper",
            "Sojourn",
            "Soldier76",
            "Sombra",
            "Symmetra",
            "Torbjörn",
            "Tracer",
            "Venture",
            "Widowmaker"
        };

        public static List<string> damageHeroesList { get { return DamageHeroesList; } }
    }
}
