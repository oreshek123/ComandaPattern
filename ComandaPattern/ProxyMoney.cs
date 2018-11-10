using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandaPattern
{
    public class ProxyMoney: IMoney
    {
        private Money _money;
        public int MoneyOnCard { get; set; }

        public ProxyMoney(Money money)
        {
            _money = money;
        }



        int IMoney.ClientMoney()
        {
            if (MoneyOnCard == 0)
            {
                MoneyOnCard = _money.MoneyOnCard;
            }

            return MoneyOnCard;
        }

        
    }
}
