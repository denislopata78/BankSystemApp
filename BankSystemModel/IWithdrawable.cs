using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemModel
{
    public interface IWithdrawable
    {
        bool Withdraw(decimal amountToWithdraw);
    }
}
