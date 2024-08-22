using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module17
{
    public static class Calculator
    {
        // Метод для расчета процентной ставки
        public static void CalculateInterest(IAccount account)
        {
                // расчет процентной ставки обычного аккаунта по правилам банка
                account.Interest = account.GetInterest();
            
        }
    }
}
