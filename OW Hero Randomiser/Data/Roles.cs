using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OW_Hero_Randomiser.Data
{
    internal class Roles
    {

        private static readonly List<string> RolesList = new List<string>()
        {
            "Tank", "Damage", "Damage", "Support", "Support"
        };

        public static List<string> rolesList { get { return RolesList; } }

    }
}
