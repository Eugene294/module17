using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace module17
{

    //обычный аккаунт
    public class CommonAccount : IAccount
    {
        //баланс
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        public readonly double Coeff = 0.4;

        public CommonAccount()
        {
            Balance = 0;
        }

        public CommonAccount(double balance)
        {
            Balance = balance;
        }

        public double GetInterest()
        {
            if (Balance < 1000)
                return Balance * 0.4 - Balance * 0.2;
            else
                return Balance * 0.4 - Balance * 0.4;
        }
    }
}
