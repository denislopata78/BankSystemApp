using BankSystemModel;
using System.Xml.Linq;

namespace BankSystemTestProject
{
    [TestClass]
    public class BankSystemTest
    {
        [TestMethod]
        public void LogIn_correct()
        {
            //Arrange
            BankSystem bankSystem = new BankSystem();
            bankSystem.dataBase.Clients.Add("Михайло", "Басманов", "Петрович", 1234567890, "789452159", "+380456789025", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");

            //Act
            bool actual = bankSystem.LogIn("+380456789025", "1234567890");
            //Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void LogIn_unCorrect()
        {
            //Arrange
            BankSystem bankSystem = new BankSystem();
            bankSystem.dataBase.Clients.Add("Михайло", "Басманов", "Петрович", 1234567890, "789452159", "+380456789025", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");

            //Act
            bool actual = bankSystem.LogIn("+380456780025", "1234967890");
            //Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void LogOut_correct()
        {
            //Arrange
            BankSystem bankSystem = new BankSystem();
            bankSystem.dataBase.Clients.Add("Михайло", "Басманов", "Петрович", 1234567890, "789452159", "+380456789025", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");
            bankSystem.LogIn("+380456780025", "1234967890");

            Client expected = null;

            //Act
            bankSystem.LogOut();
            Client actual = bankSystem.CurrentUser;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}