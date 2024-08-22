using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module17
{

    //зарплатный аккаунт
    public class SalaryAccount : IAccount
    {
        //баланс
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        public SalaryAccount()
        {
            Balance = 0;
        }

        public SalaryAccount(double balance)
        {
            Balance = balance;
        }

        public double GetInterest()
        {
            return Balance * 0.5;
        }
    }
}
