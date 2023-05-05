using BankSystemModel;
using Microsoft.VisualBasic;
using System.Xml.Linq;

namespace BankSystemTestProject
{
    [TestClass]
    public class ClientTest
    {
        [TestMethod]
        public void Constructor_correct()
        {
            //Arrange
            Client client = new Client("Михайло", "Басманов", "Петрович", 1234567890, "789452159", "+380456789025", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");

            long expected = 1234567890;

            //Act
            long actual = client.Inp;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Constructor_name_not_correct()
        {
            //Arrange
            Client client;
            string name = String.Empty;

            //Act + Assert
            Assert.ThrowsException<ArgumentNullException>(() => client = new Client(name, "Басманов", "Петрович", 1234567891, "789452152", "+380456789025", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890"));
        }

        [TestMethod]
        public void Constructor_surname_not_correct()
        {
            //Arrange
            Client client;
            string surname = String.Empty;

            //Act + Assert
            Assert.ThrowsException<ArgumentNullException>(() => client = new Client("Михайло", surname, "Петрович", 1234567891, "789452152", "+380456789025", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890"));
        }

        [TestMethod]
        public void Constructor_inp_not_correct()
        {
            //Arrange
            Client client;
            long inp = 123;

            //Act + Assert
            Assert.ThrowsException<FormatException>(() => client = new Client("Михайло", "Басманов", "Петрович", inp, "789452152", "+380456789025", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890"));
        }

        [TestMethod]
        public void Constructor_passportNumber_not_correct()
        {
            //Arrange
            Client client;
            string passportNumber = string.Empty;

            //Act + Assert
            Assert.ThrowsException<FormatException>(() => client = new Client("Михайло", "Басманов", "Петрович", 1234567895, passportNumber, "+380456789025", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890"));
        }

        [TestMethod]
        public void Constructor_phoneNumber_not_correct()
        {
            //Arrange
            Client client;
            string phoneNumber = "+380888";

            //Act + Assert
            Assert.ThrowsException<FormatException>(() => client = new Client("Михайло", "Басманов", "Петрович", 1234567895, "789452152", phoneNumber, Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890"));
        }

        [TestMethod]
        public void Constructor_adress_not_correct()
        {
            //Arrange
            Client client;
            string adress = String.Empty;

            //Act + Assert
            Assert.ThrowsException<ArgumentNullException>(() => client = new Client("Михайло", "Басманов", "Петрович", 1234567895, "789452152", "+380456789025", Sex.male, new DateTime(1990, 1, 1), adress, "1234567890"));
        }

        [TestMethod]
        public void Constructor_password_not_correct()
        {
            //Arrange
            Client client;
            string password = "123";

            //Act + Assert
            Assert.ThrowsException<FormatException>(() => client = new Client("Михайло", "Басманов", "Петрович", 1234567895, "789452152", "+380456789025", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", password));
        }

        [TestMethod]
        public void Update_correct()
        {
            //Arrange
            Client client = new Client("Михайло", "Басманов", "Петрович", 1234567899, "789452150", "+380456789029", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");

            string expected = "Петро";

            //Act
            client.Update("Петро", "Басманов", "789452150", "+380456789029", "м. Полтава, вул. Перемоги, буд. 23", "1234567890");
            string actual = client.Name;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Update_name_not_correct()
        {
            //Arrange
            Client client = new Client("Михайло", "Басманов", "Петрович", 1234567899, "789452150", "+380456789029", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");

            string name = String.Empty;

            //Act + Assert
            Assert.ThrowsException<ArgumentNullException>(() => client.Update(name, "Басманов", "789452150", "+380456789029", "м. Полтава, вул. Перемоги, буд. 23", "1234567890"));
        }

        [TestMethod]
        public void GetDeposits_correct()
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
            DepositProgram depositProgram = new DepositProgram("Savings Account", TypeDeposit.DemandDeposit, CurrencyType.USD, interestRates);
            bankSystem.dataBase.Deposits.Add(1111111111, "Квартира", depositProgram, 50000, 0, 12, DateTime.Now);
            bankSystem.dataBase.Deposits.Add(1111111111, "Машина", depositProgram, 20000, 0, 12, DateTime.Now);

            int expected = 2;

            //Act
            long actual = bankSystem.dataBase.Clients.FindByInp(1111111111).GetDeposits().Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetBalanceUAH_correct()
        {
            //Arrange
            BankSystem bankSystem = new BankSystem();
            bankSystem.dataBase.Clients.Clear();
            bankSystem.dataBase.DepositPrograms.Clear();
            bankSystem.dataBase.Deposits.Clear();
            bankSystem.dataBase.Clients.Add("Михайло", "Басманов", "Петрович", 1111111112, "111111112", "+380965875142", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");
            Dictionary<int, decimal> interestRates = new Dictionary<int, decimal>
            {
                { 1, 0.01m },
                { 2, 0.02m },
                { 3, 0.03m }
            };
            DepositProgram depositProgram = new DepositProgram("Savings Account", TypeDeposit.DemandDeposit, CurrencyType.UAH, interestRates);
            bankSystem.dataBase.Deposits.Add(1111111112, "Квартира", depositProgram, 20000, 0, 12, DateTime.Now);

            decimal expected = 20000;

            //Act
            decimal actual = bankSystem.dataBase.Clients.FindByInp(1111111112).GetBalanceUAH();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetBalanceUSD_correct()
        {
            //Arrange
            BankSystem bankSystem = new BankSystem();
            bankSystem.dataBase.Clients.Clear();
            bankSystem.dataBase.DepositPrograms.Clear();
            bankSystem.dataBase.Deposits.Clear();
            bankSystem.dataBase.Clients.Add("Михайло", "Басманов", "Петрович", 1111111113, "111111113", "+380965875143", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");
            Dictionary<int, decimal> interestRates = new Dictionary<int, decimal>
            {
                { 1, 0.01m },
                { 2, 0.02m },
                { 3, 0.03m }
            };
            DepositProgram depositProgram = new DepositProgram("Savings Account", TypeDeposit.DemandDeposit, CurrencyType.USD, interestRates);
            bankSystem.dataBase.Deposits.Add(1111111113, "Машина", depositProgram, 20000, 0, 12, DateTime.Now);

            decimal expected = 20000;

            //Act
            decimal actual = bankSystem.dataBase.Clients.FindByInp(1111111113).GetBalanceUSD();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetBalanceEUR_correct()
        {
            //Arrange
            BankSystem bankSystem = new BankSystem();
            bankSystem.dataBase.Clients.Clear();
            bankSystem.dataBase.DepositPrograms.Clear();
            bankSystem.dataBase.Deposits.Clear();
            bankSystem.dataBase.Clients.Add("Михайло", "Басманов", "Петрович", 1111111114, "111111114", "+380965875144", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");
            Dictionary<int, decimal> interestRates = new Dictionary<int, decimal>
            {
                { 1, 0.01m },
                { 2, 0.02m },
                { 3, 0.03m }
            };
            DepositProgram depositProgram = new DepositProgram("Savings Account", TypeDeposit.DemandDeposit, CurrencyType.EUR, interestRates);
            bankSystem.dataBase.Deposits.Add(1111111114, "Відпочинок", depositProgram, 20000, 0, 12, DateTime.Now);

            decimal expected = 20000;

            //Act
            decimal actual = bankSystem.dataBase.Clients.FindByInp(1111111114).GetBalanceEUR();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CompareTo_correct()
        {
            //Arrange
            BankSystem bankSystem = new BankSystem();
            bankSystem.dataBase.Clients.Clear();
            bankSystem.dataBase.DepositPrograms.Clear();
            bankSystem.dataBase.Deposits.Clear();

            bankSystem.dataBase.Clients.Add("Михайло1", "Басманов", "Петрович", 1111111115, "111111115", "+380965875145", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");
            bankSystem.dataBase.Clients.Add("Михайло2", "Басманов", "Петрович", 1111111116, "111111116", "+380965875146", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");
            Dictionary<int, decimal> interestRates = new Dictionary<int, decimal>
            {
                { 1, 0.01m },
                { 2, 0.02m },
                { 3, 0.03m }
            };
            DepositProgram depositProgram = new DepositProgram("Savings Account", TypeDeposit.DemandDeposit, CurrencyType.USD, interestRates);
            bankSystem.dataBase.Deposits.Add(1111111115, "Відпочинок", depositProgram, 20000, 0, 12, DateTime.Now);
            bankSystem.dataBase.Deposits.Add(1111111116, "Квартира", depositProgram, 10000, 0, 12, DateTime.Now);
            bankSystem.dataBase.Deposits.Add(1111111116, "Відпочинок", depositProgram, 20000, 0, 12, DateTime.Now);

            string expected = "Михайло2Михайло1";

            //Act
            string actual = "";
            bankSystem.dataBase.Clients.Sort();
            foreach(Client client in bankSystem.dataBase.Clients)
            {
                actual += client.Name;
            }

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}