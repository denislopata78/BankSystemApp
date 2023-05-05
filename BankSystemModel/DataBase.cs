using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemModel
{
    public class DataBase
    {
        private static DataBase? instance = null;
        private DataBase()
        {
            DepositPrograms = new DepositProgramList();
            Clients = new ClientList();
            Deposits = new DepositList();
        }

        public static DataBase Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataBase();
                return instance;
            }
        }
        public DepositProgramList DepositPrograms { get; set; }
        public ClientList Clients { get; set; }
        public DepositList Deposits { get; set; }
    }
}
