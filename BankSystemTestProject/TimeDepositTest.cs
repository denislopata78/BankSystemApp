using BankSystemModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BankSystemTestProject
{
    [TestClass]
    public class TimeDepositTest
    {
        [TestMethod]
        public void Constructor_paymentPerMonth_correct()
        {
            //Arrange
            BankSystem bankSystem = new BankSystem();
            bankSystem.dataBase.Clients.Clear();
            bankSystem.dataBase.DepositPrograms.Clear();
            bankSystem.dataBase.Deposits.Clear();
            bankSystem.dataBase.Clients.Add("Михайло1", "Басманов", "Петрович", 1111111115, "111111115", "+380965875145", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");
            TimeDeposit timeDeposit;
            Dictionary<int, decimal> interestRates = new Dictionary<int, decimal>
            {
                { 1, 0.01m },
                { 2, 0.02m },
                { 3, 0.03m }
            };
            bankSystem.dataBase.DepositPrograms.Add("Savings Account EUR", TypeDeposit.TimeDeposit, CurrencyType.EUR, interestRates);
            bankSystem.dataBase.Deposits.Add(1111111115, "Дача", bankSystem.dataBase.DepositPrograms.Find(x => x.Name == "Savings Account EUR"), 20000, 100, 12, DateTime.Now);

            decimal expected = 100;

            //Act
            timeDeposit = bankSystem.dataBase.Deposits.Find(x => x.Name == "Дача") as TimeDeposit;
            decimal actual = timeDeposit.PaymentPerMonth;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Constructor_paymentPerMonth_not_correct()
        {
            //Arrange
            BankSystem bankSystem = new BankSystem();
            bankSystem.dataBase.Clients.Clear();
            bankSystem.dataBase.DepositPrograms.Clear();
            bankSystem.dataBase.Deposits.Clear();
            bankSystem.dataBase.Clients.Add("Михайло1", "Басманов", "Петрович", 1111111115, "111111115", "+380965875145", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");
            Dictionary<int, decimal> interestRates = new Dictionary<int, decimal>
            {
                { 1, 0.01m },
                { 2, 0.02m },
                { 3, 0.03m }
            };
            bankSystem.dataBase.DepositPrograms.Add("Program", TypeDeposit.TimeDeposit, CurrencyType.EUR, interestRates);

            //Act + Assert
            Assert.ThrowsException<FormatException>(() => bankSystem.dataBase.Deposits.Add(1111111115, "Греція", bankSystem.dataBase.DepositPrograms.Find(x => x.Name == "Program"), 20000, 8, 12, DateTime.Now));
        }

        [TestMethod]
        public void GetAmount_correct()
        {
            //Arrange
            BankSystem bankSystem = new BankSystem();
            TimeDeposit timeDeposit;
            bankSystem.dataBase.Clients.Clear();
            bankSystem.dataBase.DepositPrograms.Clear();
            bankSystem.dataBase.Deposits.Clear();
            bankSystem.dataBase.Clients.Add("Михайло1", "Басманов", "Петрович", 1111111115, "111111115", "+380965875145", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");
           
            Dictionary<int, decimal> interestRates = new Dictionary<int, decimal>
            {
                { 1, 0.01m },
                { 2, 0.02m },
                { 3, 0.03m }
            };
            bankSystem.dataBase.DepositPrograms.Add("Program", TypeDeposit.TimeDeposit, CurrencyType.EUR, interestRates);
            bankSystem.dataBase.Deposits.Add(1111111115, "Греція", bankSystem.dataBase.DepositPrograms.Find(x => x.Name == "Program"), 20000, 15, 10, DateTime.Now);

            decimal expected = 20150;

            //Act
            timeDeposit  = bankSystem.dataBase.Deposits.Find(x => x.Name == "Греція") as TimeDeposit;
            decimal actual = timeDeposit.GetAmount();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateInterest_correct()
        {
            //Arrange
            BankSystem bankSystem = new BankSystem();
            TimeDeposit timeDeposit;
            bankSystem.dataBase.Clients.Clear();
            bankSystem.dataBase.DepositPrograms.Clear();
            bankSystem.dataBase.Deposits.Clear();
            bankSystem.dataBase.Clients.Add("Михайло1", "Басманов", "Петрович", 1111111115, "111111115", "+380965875145", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");

            Dictionary<int, decimal> interestRates = new Dictionary<int, decimal>
            {
                { 1, 0.01m },
                { 2, 0.02m },
                { 12, 0.03m }
            };
            bankSystem.dataBase.DepositPrograms.Add("Program", TypeDeposit.TimeDeposit, CurrencyType.EUR, interestRates);
            bankSystem.dataBase.Deposits.Add(1111111115, "Мій депозит", bankSystem.dataBase.DepositPrograms.Find(x => x.Name == "Program"), 20000, 15, 12, DateTime.Now);

            decimal expected = 4.873470m;

            //Act
            timeDeposit = bankSystem.dataBase.Deposits.Find(x => x.Name == "Мій депозит") as TimeDeposit;
            decimal actual = timeDeposit.CalculateInterest();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
