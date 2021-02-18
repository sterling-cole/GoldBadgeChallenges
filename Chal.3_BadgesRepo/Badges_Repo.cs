using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chal._3_BadgesRepo
{
   public class Badges_Repo
    {
        List<string> doors = new List<string> { "A1", "A2", "A3" };
        readonly Dictionary<int, List<string>> badges = new Dictionary<int, List<string>>();
        

        //Get All Badges Method
        public Dictionary<int, List<string>> GetAllBadges()
        {
            return badges;
        }
        public bool AddBadgeToDictionary(Badges badge)
        {
            int startingCount = badges.Count;
            badges.Add( 12345, doors);
            bool wasAdded = badges.Count > startingCount;
            return wasAdded;
        }
        
    }
}
