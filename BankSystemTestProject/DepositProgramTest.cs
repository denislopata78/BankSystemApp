using BankSystemModel;

namespace BankSystemTestProject
{
    [TestClass]
    public class DepositProgramTest
    {
        [TestMethod]
        public void Constructor_correct()
        {
            //Arrange
            DepositProgram depositProgram;
            Dictionary<int, decimal> interestRates = new Dictionary<int, decimal>
            {
                { 1, 0.01m },
                { 2, 0.02m },
                { 3, 0.03m }
            };
            string expected = "Savings Account";

            //Act
            depositProgram = new DepositProgram("Savings Account", TypeDeposit.TimeDeposit, CurrencyType.USD, interestRates);
            string actual = depositProgram.Name;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Constructor_name_not_correct()
        {
            //Arrange
            DepositProgram depositProgram;
            Dictionary<int, decimal> interestRates = new Dictionary<int, decimal>
            {
                { 1, 0.01m },
                { 2, 0.02m },
                { 3, 0.03m }
            };

            //Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => depositProgram = new DepositProgram(string.Empty, TypeDeposit.TimeDeposit, CurrencyType.USD, interestRates));
        }

        [TestMethod]
        public void Constructor_interestRates_key_not_correct()
        {
            //Arrange
            DepositProgram depositProgram;
            Dictionary<int, decimal> interestRates = new Dictionary<int, decimal>
            {
                { 0, 0.01m },
                { 2, 0.02m },
                { 3, 0.03m }
            };

            //Act & Assert
            Assert.ThrowsException<FormatException>(() => depositProgram = new DepositProgram("Saving Account", TypeDeposit.TimeDeposit, CurrencyType.USD, interestRates));
        }
        [TestMethod]
        public void Constructor_interestRates_value_not_correct()
        {
            //Arrange
            DepositProgram depositProgram;
            Dictionary<int, decimal> interestRates = new Dictionary<int, decimal>
            {
                { 1, 0.01m },
                { 2, -0.02m },
                { 3, 0.03m }
            };

            //Act & Assert
            Assert.ThrowsException<FormatException>(() => depositProgram = new DepositProgram("Saving Account", TypeDeposit.TimeDeposit, CurrencyType.USD, interestRates));
        }

        [TestMethod]
        public void Update_not_correct()
        {
            //Arrange
            DepositProgram depositProgram;
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
                { 0, 0.04m }
            };
            Dictionary<int, decimal> expected = newInterestRates;
            depositProgram = new DepositProgram("Savings Account", TypeDeposit.TimeDeposit, CurrencyType.USD, interestRates);

            //Act & Assert
            Assert.ThrowsException<FormatException>(() => depositProgram.Update(newInterestRates));
        }

        [TestMethod]
        public void Update_correct()
        {
            //Arrange
            DepositProgram depositProgram;
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

            //Act
            depositProgram = new DepositProgram("Savings Account", TypeDeposit.TimeDeposit, CurrencyType.USD, interestRates);
            depositProgram.Update(newInterestRates);
            Dictionary<int, decimal> actual = depositProgram.InterestRates;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
