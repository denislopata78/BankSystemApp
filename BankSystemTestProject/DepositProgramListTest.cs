
using BankSystemModel;

namespace BankSystemTestProject
{
    [TestClass]
    public class DepositProgramListTest
    {
        [TestMethod]
        public void Add_correct()
        {
            //Arrange
            DepositProgramList depositProgramList = new DepositProgramList();
            Dictionary<int, decimal> interestRates = new Dictionary<int, decimal>
            {
                { 1, 0.01m },
                { 2, 0.02m },
                { 3, 0.03m }
            };

            //Act
            bool actual = depositProgramList.Add("Savings Account", TypeDeposit.TimeDeposit, CurrencyType.USD, interestRates);

            //Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Add_not_correct()
        {
            //Arrange
            DepositProgramList depositProgramList = new DepositProgramList();
            Dictionary<int, decimal> interestRates = new Dictionary<int, decimal>
            {
                { 1, 0.01m },
                { 2, 0.02m },
                { 3, 0.03m }
            };
            depositProgramList.Add("Savings Account", TypeDeposit.TimeDeposit, CurrencyType.USD, interestRates);

            //Act
            bool actual = depositProgramList.Add("Savings Account", TypeDeposit.TimeDeposit, CurrencyType.USD, interestRates);

            //Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void RemoveByName_correct()
        {
            //Arrange
            BankSystem bankSystem = new BankSystem();
            bankSystem.dataBase.Clients.Clear();
            bankSystem.dataBase.DepositPrograms.Clear();
            bankSystem.dataBase.Deposits.Clear();
            bankSystem.dataBase.Clients.Add("Михайло", "Басманов", "Петрович", 1111111111, "111111111", "+380965875148", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");
            Dictionary<int, decimal> interestRates = new Dictionary<int, decimal>
            {
                { 1, 0.01m },
                { 2, 0.02m },
                { 3, 0.03m }
            };
            bankSystem.dataBase.DepositPrograms.Add("Savings Account", TypeDeposit.TimeDeposit, CurrencyType.USD, interestRates);

            //Act
            bool actual = bankSystem.dataBase.DepositPrograms.RemoveByName("Savings Account");

            //Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void RemoveByName_not_correct()
        {
            //Arrange
            BankSystem bankSystem = new BankSystem();
            bankSystem.dataBase.Clients.Clear();
            bankSystem.dataBase.DepositPrograms.Clear();
            bankSystem.dataBase.Deposits.Clear();
            bankSystem.dataBase.Clients.Add("Михайло", "Басманов", "Петрович", 1111111111, "111111111", "+380965875148", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");
            Dictionary<int, decimal> interestRates = new Dictionary<int, decimal>
            {
                { 1, 0.01m },
                { 2, 0.02m },
                { 3, 0.03m }
            };
            bankSystem.dataBase.DepositPrograms.Add("Savings Account", TypeDeposit.TimeDeposit, CurrencyType.USD, interestRates);
            bankSystem.dataBase.Deposits.Add(1111111111, "Квартира", bankSystem.dataBase.DepositPrograms.First(x => x.Name == "Savings Account"), 50000, 0, 12, DateTime.Now);

            //Act
            bool actual = bankSystem.dataBase.DepositPrograms.RemoveByName("Savings Account");

            //Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Update_correct()
        {
            //Arrange
            DepositProgramList depositProgramList = new DepositProgramList();
            Dictionary<int, decimal> interestRates = new Dictionary<int, decimal>
            {
                { 1, 0.01m },
                { 2, 0.02m },
                { 3, 0.03m }
            };
            Dictionary<int, decimal> newInterestRates = new Dictionary<int, decimal>
            {
                { 1, 0.02m },
                { 2, 0.03m },
                { 3, 0.04m }
            };
            Dictionary<int, decimal> expected = newInterestRates;
            depositProgramList.Add("Savings Account 1", TypeDeposit.TimeDeposit, CurrencyType.USD, interestRates);
            depositProgramList.Add("Savings Account 2", TypeDeposit.TimeDeposit, CurrencyType.USD, interestRates);

            //Act
            depositProgramList.Update("Savings Account 2", newInterestRates);
            Dictionary<int, decimal> actual = depositProgramList[1].InterestRates;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Update_not_correct()
        {
            //Arrange
            DepositProgramList depositProgramList = new DepositProgramList();
            Dictionary<int, decimal> interestRates = new Dictionary<int, decimal>
            {
                { 1, 0.01m },
                { 2, 0.02m },
                { 3, 0.03m }
            };
            Dictionary<int, decimal> newInterestRates = new Dictionary<int, decimal>
            {
                { 1, 0.02m },
                { 0, 0.03m },
                { 3, 0.04m }
            };
            depositProgramList.Add("Savings Account 1", TypeDeposit.TimeDeposit, CurrencyType.USD, interestRates);
            depositProgramList.Add("Savings Account 2", TypeDeposit.TimeDeposit, CurrencyType.USD, interestRates);

            //Act & Assert
            Assert.ThrowsException<FormatException>(() => depositProgramList.Update("Savings Account 2", newInterestRates));
        }

        [TestMethod]
        public void SerializeObject_correct()
        {
            //Arrange
            DepositProgramList depositProgramList = new DepositProgramList();
            Dictionary<int, decimal> interestRates = new Dictionary<int, decimal>
            {
                { 1, 0.01m },
                { 2, 0.02m },
                { 3, 0.03m }
            };
            depositProgramList.Add("Savings Account 1", TypeDeposit.TimeDeposit, CurrencyType.USD, interestRates);
            depositProgramList.Add("Savings Account 2", TypeDeposit.TimeDeposit, CurrencyType.USD, interestRates);

            string path = "depositPrograms";

            //Act
            bool actual = depositProgramList.SerializeObject(path);

            //Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void SerializeObject_not_correct()
        {
            //Arrange
            DepositProgramList depositProgramList = new DepositProgramList();
            Dictionary<int, decimal> interestRates = new Dictionary<int, decimal>
            {
                { 1, 0.01m },
                { 2, 0.02m },
                { 3, 0.03m }
            };
            depositProgramList.Add("Savings Account 1", TypeDeposit.TimeDeposit, CurrencyType.USD, interestRates);
            depositProgramList.Add("Savings Account 2", TypeDeposit.TimeDeposit, CurrencyType.USD, interestRates);

            string path = "/";

            //Act & Assert
            Assert.ThrowsException<Exception>(() => depositProgramList.SerializeObject(path));
        }

        [TestMethod]
        public void DeserializeObject_correct()
        {
            //Arrange
            DepositProgramList depositProgramList = new DepositProgramList();
            Dictionary<int, decimal> interestRates = new Dictionary<int, decimal>
            {
                { 1, 0.01m },
                { 2, 0.02m },
                { 3, 0.03m }
            };
            depositProgramList.Add("Savings Account 1", TypeDeposit.TimeDeposit, CurrencyType.USD, interestRates);
            depositProgramList.Add("Savings Account 2", TypeDeposit.TimeDeposit, CurrencyType.USD, interestRates);
            string path = "depositPrograms";
            depositProgramList.SerializeObject(path);

            //Act
            bool actual = depositProgramList.DeserializeObject(path);

            //Assert
            Assert.IsTrue(actual);
        }


        [TestMethod]
        public void DeserializeObject_not_correct()
        {
            //Arrange
            DepositProgramList depositProgramList = new DepositProgramList();
            Dictionary<int, decimal> interestRates = new Dictionary<int, decimal>
            {
                { 1, 0.01m },
                { 2, 0.02m },
                { 3, 0.03m }
            };
            depositProgramList.Add("Savings Account 1", TypeDeposit.TimeDeposit, CurrencyType.USD, interestRates);
            depositProgramList.Add("Savings Account 2", TypeDeposit.TimeDeposit, CurrencyType.USD, interestRates);
            string path = "depositPrograms";
            depositProgramList.SerializeObject(path);

            //Act
            bool actual = depositProgramList.DeserializeObject("/");

            //Assert
            Assert.IsFalse(actual);
        }
    }
}
