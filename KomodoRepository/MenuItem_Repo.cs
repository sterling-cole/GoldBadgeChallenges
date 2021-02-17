using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoRepository
{
    public class MenuItem_Repo
    {
        private readonly List<MenuItem> _menuItems = new List<MenuItem>();

        public int Count
        {
            get
            {
                return _menuItems.Count;
            }
        }


        public bool AddItemToMenuDirectory(MenuItem item)
        {
            int startingCount = _menuItems.Count;
            _menuItems.Add(item);
            bool wasAdded = _menuItems.Count > startingCount;
            return wasAdded;
        }
        public List<MenuItem> GetItems()
        {
            return _menuItems;
        }

        public MenuItem GetMenuItemByName(string name)
        {
            foreach (MenuItem item in _menuItems)
            {
                if (name == item.MealName)
                {
                    return item;
                }
            }
            throw new Exception("You wrong");
        }
        public bool DeleteItem(string name)
        {
            MenuItem itemToRemove = GetMenuItemByName(name);
            return _menuItems.Remove(itemToRemove);
        }

    }
}
