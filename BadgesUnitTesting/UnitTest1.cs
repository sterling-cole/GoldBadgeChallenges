using Chal._3_BadgesRepo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BadgesUnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        private Badges_Repo _repo;
        private Badges _badges;
        [TestInitialize]
        public void Seed()
        {
            _repo = new Badges_Repo();
            Badges badges = new Badges();
        }
    }
}
