using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chal._3_BadgesRepo
{

    public class Badges
    {
        public int BadgeID { get; set; }
        public List<string> DoorAccess { get; set; }
        public Badges()
        {

        }
        public Badges(int badgeId, List<string> doors)
        {
            BadgeID = badgeId;
            DoorAccess = doors;

        }
    }
}
