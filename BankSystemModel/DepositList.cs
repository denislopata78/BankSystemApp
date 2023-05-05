using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BankSystemModel
{
    public class DepositList: List<Deposit>, ISerializableJSON<Deposit>
    {
        public bool Add(long inp, string name, DepositProgram depositProgram, decimal amount, decimal paymentPerMonth, int duration, DateTime openingTime)
        {
            if (DataBase.Instance.Clients.FindByInp(inp) != null && !DataBase.Instance.Clients.FindByInp(inp).GetDeposits().Exists(x => x.Name == name))
            {
                if (depositProgram.Type == TypeDeposit.TimeDeposit)
                {
                    Add(new TimeDeposit(inp, name, depositProgram, amount, paymentPerMonth, duration, openingTime));
                    return true;
                }
                else if (depositProgram.Type == TypeDeposit.DemandDeposit)
                {
                    Add(new DemandDeposit(inp, name, depositProgram, amount, duration, openingTime));
                    return true;
                }
            }
            return false;
        }

        public List<Deposit> GetDepositsByInp(long inp)
        {
            Predicate<Deposit> predicate = deposit => deposit.Inp == inp;
            List<Deposit> deposits = FindAll(predicate);
            return deposits;
        }

        public bool Remove(Deposit depositToClose, out decimal balance)
        {
            DateTime monthsAgo;
            balance = 0;
            if (depositToClose is DemandDeposit)
            {
                monthsAgo = DateTime.Now.AddMonths(-depositToClose.Duration);
                if (depositToClose.OpenDate <= monthsAgo)
                {
                    balance = depositToClose.Amount + depositToClose.CalculateInterest();
                    Remove(depositToClose);
                    return true;
                }
                else
                {
                    balance = depositToClose.Amount;
                    Remove(depositToClose);
                    return true;
                }
            }
            else if (depositToClose is TimeDeposit)
            {
                TimeDeposit timeDeposit = depositToClose as TimeDeposit;
                monthsAgo = DateTime.Now.AddMonths(-timeDeposit.Duration);
                if (timeDeposit.OpenDate <= monthsAgo)
                {
                    balance = timeDeposit.GetAmount() + timeDeposit.CalculateInterest();
                    Remove(timeDeposit);
                    return true;
                }
            }
            return false;
        }

        public bool SerializeObject(string path)
        {
            try
            {
                var jsonString = JsonSerializer.Serialize(this);
                File.WriteAllText(path + ".json", jsonString);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool DeserializeObject(string path)
        {
            try
            {
                if (File.Exists(path + ".json"))
                {
                    var options = new JsonSerializerOptions
                    {
                        Converters = { new DepositConverter() }
                    };
                    string jsonString = File.ReadAllText(path + ".json");

                    List<Deposit> result = new List<Deposit>();
                    JsonDocument jsonDoc = JsonDocument.Parse(jsonString);

                    foreach (JsonElement element in jsonDoc.RootElement.EnumerateArray())
                    {
                        try
                        {
                            Deposit deposit = JsonSerializer.Deserialize<Deposit>(element.GetRawText(), options);
                            result.Add(deposit);
                        }
                        catch (Exception ex)
                        {
                            continue;
                        }
                    }

                    Clear();
                    AddRange(result);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
