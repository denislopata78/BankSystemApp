using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BankSystemModel
{
    public class DepositProgram
    {
        private string name;
        public TypeDeposit Type { get; set; }
        public CurrencyType CurrencyType { get; }
        private Dictionary<int, decimal> interestRates;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Поле Назва не може бути пустим.");
                name = value;
            }
        }
        public Dictionary<int, decimal> InterestRates
        {
            get { return interestRates; }
            set
            {
                foreach (var dct in value)
                {
                    if (dct.Key <= 0)
                    {
                        throw new FormatException("Місяць повинен бути > 0");
                    }
                    if (dct.Value <= 0 || dct.Value >= 100)
                    {
                        throw new FormatException("Процентна ставка не може бути менше або дорівнювати 0, а також бути більше 100");
                    }
                }
                interestRates = value;
            }
        }

        [JsonConstructor]
        public DepositProgram(string name, TypeDeposit type, CurrencyType currencyType, Dictionary<int, decimal> interestRates)
        {
            Name = name;
            Type = type;
            CurrencyType = currencyType;
            InterestRates = interestRates;
        }

        public void Update(Dictionary<int, decimal> interestRates)
        {
            InterestRates= interestRates;
        }
    }
}
