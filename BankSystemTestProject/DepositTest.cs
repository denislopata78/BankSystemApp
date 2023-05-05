using BankSystemModel;
using System.Xml.Linq;

class DepositClone : Deposit
{
    public DepositClone(long inp, string name, DepositProgram depositProgram, decimal amount, int duration, DateTime openDate) : base(inp, name, depositProgram, amount, duration, openDate)
    {
    }

    public override decimal CalculateInterest()
    {
        throw new NotImplementedException();
    }
}

namespace BankSystemTestProject
{
    [TestClass]
    public class DepositTest
    {
        [TestMethod]
        public void Constructor_correct()
        {
            //Arrange
            Dictionary<int, decimal> interestRates = new Dictionary<int, decimal>
            {
                { 1, 0.01m },
                { 2, 0.02m },
                { 3, 0.03m }
            };
            DepositProgram depositProgram = new DepositProgram("Savings Account", TypeDeposit.TimeDeposit, CurrencyType.USD, interestRates);
            DepositClone depositClone = new DepositClone(1111111111, "Відпочинок", depositProgram, 20000, 12, DateTime.Now);

            long expected = 1111111111;

            //Act
            long actual = depositClone.Inp;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Constructor_inp_not_correct()
        {
            //Arrange
            DepositClone depositClone;
            Dictionary<int, decimal> interestRates = new Dictionary<int, decimal>
            {
                { 1, 0.01m },
                { 2, 0.02m },
                { 3, 0.03m }
            };
            DepositProgram depositProgram = new DepositProgram("Savings Account", TypeDeposit.TimeDeposit, CurrencyType.USD, interestRates);
            long inp = 12345;

            //Act + Assert
            Assert.ThrowsException<FormatException>(() => depositClone = new DepositClone(inp, "Відпочинок", depositProgram, 20000, 12, DateTime.Now));
        }

        [TestMethod]
        public void Constructor_name_not_correct()
        {
            //Arrange
            DepositClone depositClone;
            Dictionary<int, decimal> interestRates = new Dictionary<int, decimal>
            {
                { 1, 0.01m },
                { 2, 0.02m },
                { 3, 0.03m }
            };
            DepositProgram depositProgram = new DepositProgram("Savings Account", TypeDeposit.TimeDeposit, CurrencyType.USD, interestRates);
            string name = String.Empty;

            //Act + Assert
            Assert.ThrowsException<ArgumentNullException>(() => depositClone = new DepositClone(1111111111, name, depositProgram, 20000, 12, DateTime.Now));
        }

        [TestMethod]
        public void Constructor_amount_not_correct()
        {
            //Arrange
            DepositClone depositClone;
            Dictionary<int, decimal> interestRates = new Dictionary<int, decimal>
            {
                { 1, 0.01m },
                { 2, 0.02m },
                { 3, 0.03m }
            };
            DepositProgram depositProgram = new DepositProgram("Savings Account", TypeDeposit.TimeDeposit, CurrencyType.USD, interestRates);
            decimal amount = 5;

            //Act + Assert
            Assert.ThrowsException<FormatException>(() => depositClone = new DepositClone(1111111111, "Відпочинок", depositProgram, amount, 12, DateTime.Now));
        }
    }
}
