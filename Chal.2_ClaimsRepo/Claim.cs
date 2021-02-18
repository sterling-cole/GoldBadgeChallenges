using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chal._2_ClaimsRepo
{
    public class Claim
    {
        public int ClaimID { get; set; }
        public ClaimType ClaimType { get; set; }
        public string ClaimDescription { get; set; }

        public double ClaimAmount { get; set; }
        public string DateOfAccident { get; set; }
        public DateTime DateOfIncident { get; }
        private DateTime DateOfClaim { get; }
        public int AgeOfClaim
        {
            get
            {
                TimeSpan ageOfClaim = DateOfClaim - DateOfIncident;
                return (int)ageOfClaim.TotalDays;
            }
        }
        public bool IsValid { get;  set; }
        
        public Claim()
        {

        }
        public Claim(int claimID, ClaimType claimType, string claimDescription, double claimAmount,string dateOfAccident )
        {
            ClaimID = claimID;
            ClaimType = claimType;
            ClaimDescription = claimDescription;
            ClaimAmount = claimAmount;
            DateOfAccident = dateOfAccident;
            
        }

    }

    public enum ClaimType { Car = 1, Home, Theft }

}
