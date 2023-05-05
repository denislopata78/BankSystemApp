using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BankSystemModel
{
    public class ClientList: List<Client>, ISerializableJSON<Client>
    {
        public bool Add(string name, string surname, string partonymic, long inp, string passportNumber, string phoneNumber, Sex sex,
            DateTime dateBirth, string adress, string password)
        {
            bool exists = this.Any(client => client.Inp == inp || client.PassportNumber == passportNumber || client.PhoneNumber == phoneNumber);
            
            if (exists)
                return false;

            Add(new Client(name, surname, partonymic, inp, passportNumber, phoneNumber, sex, dateBirth, adress, password));
            return true;
        }
        public bool Remove(long inpToDelete)
        {
            var clientToDelete = this.FirstOrDefault(client => client.Inp == inpToDelete && client.GetBalanceUAH() + client.GetBalanceUSD() + client.GetBalanceEUR() == 0);

            if (clientToDelete != null)
            {
                Remove(clientToDelete);
                return true;
            }
            return false;
        }
        public bool Update(string name, string surname, long inp, string passportNumber, string phoneNumber, string adress, string password)
        {
            foreach (Client client in this)
            {
                if (client.Inp == inp)
                {
                    client.Update(name, surname, passportNumber, phoneNumber, adress, password);
                    return true;
                }
            }
            return false;
        }
        public Client? FindByInp(long inp)
        {
            return this.FirstOrDefault(client => client.Inp == inp);
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

                    List<Client> result = new List<Client>();
                    JsonDocument jsonDoc = JsonDocument.Parse(jsonString);

                    foreach (JsonElement element in jsonDoc.RootElement.EnumerateArray())
                    {
                        try
                        {
                            Client client = JsonSerializer.Deserialize<Client>(element.GetRawText());
                            result.Add(client);
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
