using KomodoRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace KomodoCafeUnitTests
{
    [TestClass]
    public class KomodoTests
    {
        private MenuItem_Repo _repo;
        private MenuItem _item;

        [TestInitialize]
        public void Seed()
        {
            _repo = new MenuItem_Repo();
            MenuItem burger = new MenuItem(1, "Burgee", "Big ol burger", "burger stuff", 3.50);
                _repo.AddItemToMenuDirectory(burger);

            _item = new MenuItem(8, "BlamWhich", "KaBlam", "100% Blam", 15);
            _repo.AddItemToMenuDirectory(_item);
        }

        [TestMethod]
        public void AddTest()
        {
            MenuItem item = new MenuItem(5, "Salad", "Green stuff", "Greener stuff", 7.00);
            bool wasAdded = _repo.AddItemToMenuDirectory(item);
            Console.WriteLine(_repo.Count);
            Console.WriteLine(wasAdded);
            Console.WriteLine(item.MealNumber);
            Assert.IsTrue(wasAdded);
        }
        [TestMethod]
        public void DeleteItem_ShouldDelete()
        {
            bool wasRemoved = _repo.DeleteItem("BlamWhich");
            Assert.IsTrue(wasRemoved);
        }
        [TestMethod]
        public void GetItemByName()
        {
            MenuItem searchResult = _repo.GetMenuItemByName("BlamWhich");
            Assert.AreEqual(searchResult, _item);
        }
        
    }
}
