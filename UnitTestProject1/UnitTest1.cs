using System;
using _01_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MenuRepository_RemoveMenuItem_ShouldBeCorrectCount()
        {
            //Arrange
            MenuRepo _menuRepo = new MenuRepo();
            MenuItems item = new MenuItems();
            MenuItems itemTwo = new MenuItems();
            MenuItems itemThree = new MenuItems();

            _menuRepo.AddProductToMenu(item);
            _menuRepo.AddProductToMenu(itemTwo);
            _menuRepo.AddProductToMenu(itemThree);

            _menuRepo.RemoveItemFromMenu(item);
            //Act
            int actual = _menuRepo.GetMenuList().Count;
            int expected = 2;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MenuRepository_AddMenuItemToList_ShouldBeCorrectCount()
        {
            //Arrange
            MenuRepo _menuRepo = new MenuRepo();
            MenuItems item = new MenuItems();
            MenuItems itemTwo = new MenuItems();
            MenuItems itemThree = new MenuItems();

            _menuRepo.AddProductToMenu(item);
            _menuRepo.AddProductToMenu(itemTwo);
            _menuRepo.AddProductToMenu(itemThree);
            //Act
            int actual = _menuRepo.GetMenuList().Count;
            int expected = 3;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
