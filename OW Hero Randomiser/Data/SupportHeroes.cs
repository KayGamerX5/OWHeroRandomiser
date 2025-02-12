using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OW_Hero_Randomiser.Data
{
    internal class SupportHeroes
    {

        private static readonly List<string> SupportsList = new List<string>()
        {
            "Ana", "Baptiste", "Brigitte", "Kiriko", "Lucio", "Mercy", "Moira", "Zenyatta",
            "Lifeweaver", "Illari", "Juno"
        };

        public static List<string> supportsList { get { return SupportsList; } }

    }
}
