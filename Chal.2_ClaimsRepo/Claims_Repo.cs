using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chal._2_ClaimsRepo
{
    public class Claims_Repo
    {
        private readonly List<Claim> _claims = new List<Claim>();

        public int Count
        {
            get
            {
                return _claims.Count;
            }
        }

        public bool AddClaimToRepo(Claim claim)
        {
            int startingCount = _claims.Count;
            _claims.Add(claim);
            bool wasAdded = _claims.Count > startingCount;
            return wasAdded;
        }

        public List<Claim> GetClaims()
        {
            return _claims;
        }
        public Claim GetClaimById(int claimId)
        {
            foreach (Claim claim in _claims)
            {
                if (claimId == claim.ClaimID)
                {
                    return claim;
                }
            }
            throw new Exception("No claim with that ID");
        }
        public bool DeleteItem(int claimId)
        {
            Claim claimToRemove = GetClaimById(claimId);
            return _claims.Remove(claimToRemove);
        }
    }
}
