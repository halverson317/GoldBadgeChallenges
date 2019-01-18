using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge
{
    public class MenuRepo
    {
        List<MenuItems> _MenuList = new List<MenuItems>();

        public void AddProductToMenu(MenuItems item)
        {
            _MenuList.Add(item);
        }

        public List<MenuItems> GetMenuList()
        {
            return _MenuList;
        }

        public void RemoveItemFromMenu(MenuItems item)
        {
            _MenuList.Remove(item);
        }

        public void RemoveSpecificItemFromList (int itemNumber)
        {
            foreach (MenuItems menu in _MenuList)
            
                if (menu.ItemNumber == itemNumber)
                {
                    RemoveItemFromMenu(menu);
                    break;
                }
            }

        }
    }

