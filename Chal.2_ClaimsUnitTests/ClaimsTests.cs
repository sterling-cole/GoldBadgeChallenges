using Chal._2_ClaimsRepo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Chal._2_ClaimsUnitTests
{
    [TestClass]
    public class ClaimsTests
    {
        private Claims_Repo _repo;
        private Claim _claim;
        [TestInitialize]
        public void Seed()
        {
            _repo = new Claims_Repo();
            Claim newClaim1 = new Claim(1, ClaimType.Car, "Crashed into tree", 4500.00, "04/26/18");
            _repo.AddClaimToRepo(newClaim1);

            _claim = new Claim(5, ClaimType.Home, "Water pipe burst", 5000.00, "08/09/18");
            _repo.AddClaimToRepo(_claim);
        }

        [TestMethod]
        public void AddTest()
        {
            Claim claim = new Claim(8, ClaimType.Theft, "Stolen phone", 500.00, "08/10/18");
            bool wasAdded = _repo.AddClaimToRepo(claim);
            Console.WriteLine(_repo.Count);
            Console.WriteLine(wasAdded);
            Console.WriteLine(claim.ClaimID);
            Assert.IsTrue(wasAdded);
        }

        [TestMethod]
        public void DeleteClaim_ShouldDeleteCorrectClaim()
        {
            bool wasRemoved = _repo.DeleteItem(5);
            Assert.IsTrue(wasRemoved);
        }
        [TestMethod]
        public void GetClaimById()
        {
            Claim searchResult = _repo.GetClaimById(5);
            Assert.AreEqual(searchResult, _claim);
        }
    }
}
