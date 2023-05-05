using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BankSystemModel
{
    public class Client: IComparable<Client>
    {
        private string name;
        private string surname;
        private string? partonymic { get; set; }
        private long inp;
        private string passportNumber;
        private string phoneNumber;
        public Sex Sex { get; }
        private DateTime dateBirth;
        private string adress;
        private string password;

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
        public string Surname
        {
            get { return surname; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Поле Прізвище не може бути пустим.");
                surname = value;
            }
        }

        public string Partonymic
        {
            get { return partonymic; }
            set { partonymic = value ?? string.Empty; }
        }

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
        public string PassportNumber
        {
            get { return passportNumber; }
            set
            {
                if (value.ToString().Length < 8)
                    throw new FormatException("Довжина номеру паспорта повинна бути не менше 8 символів");
                passportNumber = value;
            }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; } 
            set
            {
                if (!value.StartsWith("+380") || value.Length != 13)
                    throw new FormatException("Номер телефону повинен починатися з +380, а загальна довжина повинна бути 13 символів");
                phoneNumber = value;
            }
        }
        public DateTime DateBirth
        {
            get { return dateBirth; }
            private set
            {
                DateTime dt;
                if (DateTime.TryParse(value.ToShortDateString(), out dt))
                {
                    int age = DateTime.Now.Year - value.Year;
                    if (value.AddYears(age) > DateTime.Now)
                    {
                        age--;
                    }
                    if (age >= 18)
                        dateBirth = value;
                    else
                        throw new FormatException("Неможливо додати клієнта, якому не виповнилось 18 років");
                }
                else
                {
                    throw new FormatException("Перевірте коректність вводу поля Дата.\nПравильний формат запису: 10.10.2022");
                }
            }
        }

        public string Adress
        {
            get { return adress; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Поле Адреса не може бути пустим.");
                adress = value;
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                if (value.Length < 10)
                    throw new FormatException("Довжина пароля повинна бути не менше 10 символів");
                password = value;
            }
        }
        [JsonConstructor]
        public Client(string name, string surname, string partonymic, long inp, string passportNumber, string phoneNumber, Sex sex,
            DateTime dateBirth, string adress, string password) 
        { 
            Name = name;
            Surname = surname;
            Partonymic = partonymic;
            Inp = inp;
            PassportNumber = passportNumber;
            PhoneNumber = phoneNumber;
            Sex = sex;
            DateBirth = dateBirth;
            Adress = adress;
            Password = password;
        }
        

        public void Update(string name, string surname, string passportNumber, string phoneNumber, string adress, string password)
        {
            Name = name;
            Surname = surname;
            PassportNumber = passportNumber;
            PhoneNumber = phoneNumber;
            Adress = adress;
            Password = password;
        }

        public List<Deposit> GetDeposits()
        {
            List<Deposit> deposits = new List<Deposit>();
            foreach (Deposit deposit in DataBase.Instance.Deposits)
            {
                if (deposit.Inp == Inp)
                {
                    deposits.Add(deposit);
                }
            }
            return deposits;
        }
        public decimal GetBalanceUAH()
        {
            decimal balance = 0; 
            foreach(Deposit deposit in DataBase.Instance.Deposits)
            {
                if (deposit.Inp == Inp && deposit.DepositProgram.CurrencyType == CurrencyType.UAH)
                {
                    if (deposit is DemandDeposit)
                        balance += deposit.Amount;
                    else if (deposit is TimeDeposit)
                    {
                        TimeDeposit timeDeposit = deposit as TimeDeposit;
                        balance += timeDeposit.GetAmount();
                    }
                }
            }
            return balance;
        }

        public decimal GetBalanceUSD()
        {
            decimal balance = 0;
            foreach (Deposit deposit in DataBase.Instance.Deposits)
            {
                if (deposit.Inp == Inp && deposit.DepositProgram.CurrencyType == CurrencyType.USD)
                {
                    if (deposit is DemandDeposit)
                        balance += deposit.Amount;
                    else if (deposit is TimeDeposit)
                    {
                        TimeDeposit timeDeposit = deposit as TimeDeposit;
                        balance += timeDeposit.GetAmount();
                    }
                }
            }
            return balance;
        }

        public decimal GetBalanceEUR()
        {
            decimal balance = 0;
            foreach (Deposit deposit in DataBase.Instance.Deposits)
            {
                if (deposit.Inp == Inp && deposit.DepositProgram.CurrencyType == CurrencyType.EUR)
                {
                    if (deposit is DemandDeposit)
                        balance += deposit.Amount;
                    else if (deposit is TimeDeposit)
                    {
                        TimeDeposit timeDeposit = deposit as TimeDeposit;
                        balance += timeDeposit.GetAmount();
                    }
                }
            }
            return balance;
        }

        public int CompareTo(Client client)
        {
            if (GetDeposits().Count > client.GetDeposits().Count)
            {
                return -1;
            }
            else if (GetDeposits().Count < client.GetDeposits().Count)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
