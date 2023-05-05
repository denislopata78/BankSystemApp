using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BankSystemModel
{
    [JsonConverter(typeof(DepositConverter))]
    public abstract class Deposit
    {
        public event EventHandler BalanceChanged;
        public static decimal TaxOnIncome = 19.5m;
        public long inp;
        private string name;
        private decimal amount;
        public DepositProgram DepositProgram { get; }
        public int Duration { get; }
        private DateTime openDate;
        public string DepositType { get; set; } 

        public long Inp
        {
            get { return inp; }
            set
            {
                if (value.ToString().Length < 10)
                    throw new FormatException("Довжина ІПН повинна бути не менше 10 символів");
                inp = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Поле Ім'я не може бути пустим.");
                name = value;
            }
        }

        public decimal Amount
        { 
            get { return amount; }
            set
            {
                if (value < 1000 && DepositProgram.CurrencyType == CurrencyType.UAH)
                {
                    throw new FormatException("Сума повинна бути більше або дорівнювати 1000 грн.");
                }
                else if (value < 100)
                {
                    throw new FormatException("Сума повинна бути більше або дорівнювати 100$/100€");
                }
                amount = value;
                BalanceChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public DateTime OpenDate 
        { 
            get { return openDate; }
            protected set
            {
                DateTime dt;
                if (DateTime.TryParse(value.ToShortDateString(), out dt))
                {
                    openDate = value;
                }
                else
                {
                    throw new FormatException("Перевірте коректність вводу поля Дата.\nПравильний формат запису: 10.10.2022");
                }
            }
        }

        [JsonConstructor]
        public Deposit(long inp, string name, DepositProgram depositProgram, decimal amount, int duration, DateTime openDate)
        {
            Inp = inp;
            Name = name;
            DepositProgram = depositProgram;
            Amount = amount;
            Duration = duration;
            OpenDate = openDate;
        }

        public abstract decimal CalculateInterest();
    }
}
