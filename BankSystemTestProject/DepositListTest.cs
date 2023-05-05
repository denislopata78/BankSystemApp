using BankSystemModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemTestProject
{
    [TestClass]
    public class DepositListTest
    {
        [TestMethod]
        public void Add_correct()
        {
            //Arrange
            BankSystem bankSystem = new BankSystem();
            bankSystem.dataBase.Clients.Clear();
            bankSystem.dataBase.DepositPrograms.Clear();
            bankSystem.dataBase.Deposits.Clear();
            bankSystem.dataBase.Clients.Add("Михайло1", "Басманов", "Петрович", 1111111111, "111111111", "+380965875145", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");
            Dictionary<int, decimal> interestRates = new Dictionary<int, decimal>
            {
                { 1, 0.01m },
                { 2, 0.02m },
                { 12, 0.03m }
            };
            DepositProgram depositProgram = new DepositProgram("Savings Account", TypeDeposit.TimeDeposit, CurrencyType.USD, interestRates);

            //Act
            bool actual = bankSystem.dataBase.Deposits.Add(1111111111, "Мій депозит", depositProgram, 20000, 15, 12, DateTime.Now);

            //Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Add_not_correct()
        {
            //Arrange
            BankSystem bankSystem = new BankSystem();
            bankSystem.dataBase.Clients.Clear();
            bankSystem.dataBase.DepositPrograms.Clear();
            bankSystem.dataBase.Deposits.Clear();
            bankSystem.dataBase.Clients.Add("Михайло1", "Басманов", "Петрович", 1111111111, "111111111", "+380965875145", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");
            Dictionary<int, decimal> interestRates = new Dictionary<int, decimal>
            {
                { 1, 0.01m },
                { 2, 0.02m },
                { 12, 0.03m }
            };
            DepositProgram depositProgram = new DepositProgram("Savings Account", TypeDeposit.TimeDeposit, CurrencyType.USD, interestRates);

            //Act
            bool actual = bankSystem.dataBase.Deposits.Add(111111112, "Мій депозит", depositProgram, 20000, 15, 12, DateTime.Now);

            //Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void GetDepositsByInp_correct()
        {
            //Arrange
            BankSystem bankSystem = new BankSystem();
            bankSystem.dataBase.Clients.Clear();
            bankSystem.dataBase.DepositPrograms.Clear();
            bankSystem.dataBase.Deposits.Clear();
            bankSystem.dataBase.Clients.Add("Михайло1", "Басманов", "Петрович", 1111111111, "111111111", "+380965875145", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");
            Dictionary<int, decimal> interestRates = new Dictionary<int, decimal>
            {
                { 1, 0.01m },
                { 2, 0.02m },
                { 12, 0.03m }
            };
            DepositProgram depositProgram = new DepositProgram("Savings Account", TypeDeposit.TimeDeposit, CurrencyType.USD, interestRates);
            List<Deposit> depositList = new List<Deposit>() { new TimeDeposit(1111111111, "Відпочинок", depositProgram, 20000, 0, 12, DateTime.Now) };
            bankSystem.dataBase.Deposits.Add(1111111111, "Відпочинок", depositProgram, 20000, 0, 12, DateTime.Now);

            string expected = depositList.ToString();

            //Act
            string actual = bankSystem.dataBase.Deposits.GetDepositsByInp(111111111).ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_correct()
        {
            //Arrange
            BankSystem bankSystem = new BankSystem();
            bankSystem.dataBase.Clients.Clear();
            bankSystem.dataBase.DepositPrograms.Clear();
            bankSystem.dataBase.Deposits.Clear();
            decimal balance;
            bankSystem.dataBase.Clients.Add("Михайло1", "Басманов", "Петрович", 1111111111, "111111111", "+380965875145", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");
            Dictionary<int, decimal> interestRates = new Dictionary<int, decimal>
            {
                { 1, 0.01m },
                { 2, 0.02m },
                { 12, 0.03m }
            };
            DepositProgram depositProgram = new DepositProgram("Savings Account", TypeDeposit.TimeDeposit, CurrencyType.USD, interestRates);
            bankSystem.dataBase.Deposits.Add(1111111111, "Відпочинок", depositProgram, 20000, 0, 12, new DateTime(2021, 1, 1));
            List<Deposit> depositList = new List<Deposit>() { new TimeDeposit(1111111111, "Відпочинок", depositProgram, 20000, 0, 12, new DateTime(2021, 1, 1)) };

            //Act
            bool actual = bankSystem.dataBase.Deposits.Remove(depositList[0], out balance);

            //Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Remove_not_correct()
        {
            //Arrange
            BankSystem bankSystem = new BankSystem();
            bankSystem.dataBase.Clients.Clear();
            bankSystem.dataBase.DepositPrograms.Clear();
            bankSystem.dataBase.Deposits.Clear();
            decimal balance;
            bankSystem.dataBase.Clients.Add("Михайло1", "Басманов", "Петрович", 1111111111, "111111111", "+380965875145", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");
            Dictionary<int, decimal> interestRates = new Dictionary<int, decimal>
            {
                { 1, 0.01m },
                { 2, 0.02m },
                { 12, 0.03m }
            };
            DepositProgram depositProgram = new DepositProgram("Savings Account", TypeDeposit.TimeDeposit, CurrencyType.USD, interestRates);
            bankSystem.dataBase.Deposits.Add(1111111111, "Відпочинок", depositProgram, 20000, 0, 12, new DateTime(2021, 1, 1));
            List<Deposit> depositList = new List<Deposit>() { new TimeDeposit(1111111111, "Відпочинок", depositProgram, 20000, 0, 12, DateTime.Now) };

            //Act
            bool actual = bankSystem.dataBase.Deposits.Remove(depositList[0], out balance);

            //Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void SerializeObject_correct()
        {
            //Arrange
            BankSystem bankSystem = new BankSystem();
            bankSystem.dataBase.Clients.Clear();
            bankSystem.dataBase.DepositPrograms.Clear();
            bankSystem.dataBase.Deposits.Clear();
            decimal balance;
            bankSystem.dataBase.Clients.Add("Михайло1", "Басманов", "Петрович", 1111111111, "111111111", "+380965875145", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");
            Dictionary<int, decimal> interestRates = new Dictionary<int, decimal>
            {
                { 1, 0.01m },
                { 2, 0.02m },
                { 12, 0.03m }
            };
            DepositProgram depositProgram = new DepositProgram("Savings Account", TypeDeposit.TimeDeposit, CurrencyType.USD, interestRates);
            bankSystem.dataBase.Deposits.Add(1111111111, "Відпочинок", depositProgram, 20000, 0, 12, new DateTime(2021, 1, 1));

            string path = "deposits";

            //Act
            bool actual = bankSystem.dataBase.Deposits.SerializeObject(path);

            //Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void SerializeObject_not_correct()
        {
            //Arrange
            BankSystem bankSystem = new BankSystem();
            bankSystem.dataBase.Clients.Clear();
            bankSystem.dataBase.DepositPrograms.Clear();
            bankSystem.dataBase.Deposits.Clear();
            bankSystem.dataBase.Clients.Add("Михайло1", "Басманов", "Петрович", 1111111111, "111111111", "+380965875145", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");
            Dictionary<int, decimal> interestRates = new Dictionary<int, decimal>
            {
                { 1, 0.01m },
                { 2, 0.02m },
                { 12, 0.03m }
            };
            DepositProgram depositProgram = new DepositProgram("Savings Account", TypeDeposit.TimeDeposit, CurrencyType.USD, interestRates);
            bankSystem.dataBase.Deposits.Add(1111111111, "Відпочинок", depositProgram, 20000, 0, 12, new DateTime(2021, 1, 1));

            string path = "/";

            //Act & Assert
            Assert.ThrowsException<Exception>(() => bankSystem.dataBase.Deposits.SerializeObject(path));
        }

        [TestMethod]
        public void DeserializeObject_correct()
        {
            //Arrange
            BankSystem bankSystem = new BankSystem();
            bankSystem.dataBase.Clients.Clear();
            bankSystem.dataBase.DepositPrograms.Clear();
            bankSystem.dataBase.Deposits.Clear();
            decimal balance;
            bankSystem.dataBase.Clients.Add("Михайло1", "Басманов", "Петрович", 1111111111, "111111111", "+380965875145", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");
            Dictionary<int, decimal> interestRates = new Dictionary<int, decimal>
            {
                { 1, 0.01m },
                { 2, 0.02m },
                { 12, 0.03m }
            };
            DepositProgram depositProgram = new DepositProgram("Savings Account", TypeDeposit.TimeDeposit, CurrencyType.USD, interestRates);
            bankSystem.dataBase.Deposits.Add(1111111111, "Відпочинок", depositProgram, 20000, 0, 12, new DateTime(2021, 1, 1));

            string path = "deposits";
            bankSystem.dataBase.Deposits.SerializeObject(path);

            //Act
            bool actual = bankSystem.dataBase.Deposits.DeserializeObject(path);

           //Assert
            Assert.IsTrue(actual);
        }


        [TestMethod]
        public void DeserializeObject_not_correct()
        {
            //Arrange
            BankSystem bankSystem = new BankSystem();
            bankSystem.dataBase.Clients.Clear();
            bankSystem.dataBase.DepositPrograms.Clear();
            bankSystem.dataBase.Deposits.Clear();
            decimal balance;
            bankSystem.dataBase.Clients.Add("Михайло1", "Басманов", "Петрович", 1111111111, "111111111", "+380965875145", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");
            Dictionary<int, decimal> interestRates = new Dictionary<int, decimal>
            {
                { 1, 0.01m },
                { 2, 0.02m },
                { 12, 0.03m }
            };
            DepositProgram depositProgram = new DepositProgram("Savings Account", TypeDeposit.TimeDeposit, CurrencyType.USD, interestRates);
            bankSystem.dataBase.Deposits.Add(1111111111, "Відпочинок", depositProgram, 20000, 0, 12, new DateTime(2021, 1, 1));
            string path = "deposits";
            bankSystem.dataBase.Deposits.SerializeObject(path);

            //Act
            bool actual = bankSystem.dataBase.Deposits.DeserializeObject("/");

            //Assert
            Assert.IsFalse(actual);
        }
    }
}
