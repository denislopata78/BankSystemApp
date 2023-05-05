using BankSystemModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemTestProject
{
    [TestClass]
    public class DemandDepositTest
    {
        [TestMethod]
        public void Withdraw_correct()
        {
            //Arrange
            BankSystem bankSystem = new BankSystem();
            bankSystem.dataBase.Clients.Clear();
            bankSystem.dataBase.DepositPrograms.Clear();
            bankSystem.dataBase.Deposits.Clear();
            bankSystem.dataBase.Clients.Add("Михайло1", "Басманов", "Петрович", 1111111115, "111111115", "+380965875145", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");
            DemandDeposit demandDeposit;
            Dictionary<int, decimal> interestRates = new Dictionary<int, decimal>
            {
                { 1, 0.01m },
                { 2, 0.02m },
                { 12, 0.03m }
            };
            DepositProgram depositProgram = new DepositProgram("Savings Account", TypeDeposit.DemandDeposit, CurrencyType.UAH, interestRates);
            bankSystem.dataBase.Deposits.Add(1111111115, "Дача", depositProgram, 20000, 0, 12, DateTime.Now);

            decimal expected = 19900;

            //Act
            demandDeposit = bankSystem.dataBase.Deposits.Find(x => x.Name == "Дача") as DemandDeposit;
            demandDeposit.Withdraw(100);

            decimal actual = demandDeposit.Amount;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Withdraw_not_correct()
        {
            //Arrange
            BankSystem bankSystem = new BankSystem();
            bankSystem.dataBase.Clients.Clear();
            bankSystem.dataBase.DepositPrograms.Clear();
            bankSystem.dataBase.Deposits.Clear();
            bankSystem.dataBase.Clients.Add("Михайло1", "Басманов", "Петрович", 1111111115, "111111115", "+380965875145", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");
            DemandDeposit demandDeposit;
            Dictionary<int, decimal> interestRates = new Dictionary<int, decimal>
            {
                { 1, 0.01m },
                { 2, 0.02m },
                { 12, 0.03m }
            };
            DepositProgram depositProgram = new DepositProgram("Savings Account", TypeDeposit.DemandDeposit, CurrencyType.UAH, interestRates);
            bankSystem.dataBase.Deposits.Add(1111111115, "Подорож", depositProgram, 20000, 0, 12, DateTime.Now);

            decimal expected = 20000;

            //Act
            demandDeposit = bankSystem.dataBase.Deposits.Find(x => x.Name == "Подорож") as DemandDeposit;
            demandDeposit.Withdraw(100000);

            decimal actual = demandDeposit.Amount;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateInterest_correctt()
        {
            //Arrange
            BankSystem bankSystem = new BankSystem();
            bankSystem.dataBase.Clients.Clear();
            bankSystem.dataBase.DepositPrograms.Clear();
            bankSystem.dataBase.Deposits.Clear();
            bankSystem.dataBase.Clients.Add("Михайло1", "Басманов", "Петрович", 1111111115, "111111115", "+380965875145", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");
            DemandDeposit demandDeposit;
            Dictionary<int, decimal> interestRates = new Dictionary<int, decimal>
            {
                { 1, 0.01m },
                { 2, 0.02m },
                { 9, 0.03m }
            };
            DepositProgram depositProgram = new DepositProgram("Savings Account", TypeDeposit.DemandDeposit, CurrencyType.UAH, interestRates);
            bankSystem.dataBase.Deposits.Add(1111111115, "Обладнання", depositProgram, 20000, 0, 9, DateTime.Now);

            decimal expected = 3.62250m;

            //Act
            demandDeposit = bankSystem.dataBase.Deposits.Find(x => x.Name == "Обладнання") as DemandDeposit;
            decimal actual = demandDeposit.CalculateInterest();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
