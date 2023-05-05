
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BankSystemModel
{
    public class DepositProgramList: List<DepositProgram>, ISerializableJSON<DepositProgram>
    {
        public bool Add(string name, TypeDeposit type, CurrencyType currencyType, Dictionary<int, decimal> interestRates)
        {
            bool result = !this.Any(depositProgram => depositProgram.Name == name);

            if (result)
            {
                Add(new DepositProgram(name, type, currencyType, interestRates));
            }
            return result;
        }
        public bool RemoveByName(string nameToDelete)
        {
            foreach (Client client in DataBase.Instance.Clients)
            {
                if (client.GetDeposits().Exists(deposit => deposit.DepositProgram.Name == nameToDelete))
                {
                    return false;
                }
            }
            RemoveAll(depositProgram => depositProgram.Name == nameToDelete);
            return true;
        }
        public bool Update(string name, Dictionary<int, decimal> interestRates)
        {
            foreach (DepositProgram depositProgram in this)
            {
                if (depositProgram.Name == name)
                {
                    depositProgram.Update(interestRates);
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
                    string jsonString = File.ReadAllText(path + ".json");

                    List<DepositProgram> result = new List<DepositProgram>();
                    JsonDocument jsonDoc = JsonDocument.Parse(jsonString);

                    foreach (JsonElement element in jsonDoc.RootElement.EnumerateArray())
                    {
                        try
                        {
                            DepositProgram depositProgram = JsonSerializer.Deserialize<DepositProgram>(element.GetRawText());
                            result.Add(depositProgram);
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
