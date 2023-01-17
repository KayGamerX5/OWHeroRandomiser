using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OW_Hero_Randomiser.Data
{
    internal class Roles
    {

        private static readonly List<int> RolesList = new List<int>()
        {
            //1 = tank, 2+3 = dps, 4+5 = healer
            1, 2, 3, 4, 5
        };

        public static List<int> rolesList { get { return RolesList; } }

    }
}
