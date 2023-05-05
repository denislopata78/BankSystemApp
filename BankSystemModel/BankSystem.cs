using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BankSystemModel
{
    public class BankSystem
    {
        public const string ADMIN_LOGIN = "admin";
        public const string ADMIN_PASSWORD = "admin";
        public Client CurrentUser { get; set; }

        public DataBase dataBase;

        public BankSystem() 
        {
            dataBase = DataBase.Instance;
        }
        
        public bool LogIn(string phoneNumber, string password)
        {
            CurrentUser = dataBase.Clients.FirstOrDefault(client => phoneNumber == client.PhoneNumber && password == client.Password);

            if (CurrentUser != null)
                return true;

            return false;

        }

        public void LogOut()
        {
            CurrentUser = null;
        }
    }
}
