using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandaPattern
{
    public class Money: IMoney
    {
        public int MoneyOnCard { get; set; }

        int IMoney.ClientMoney()
        {
            return MoneyOnCard;
        }

        
    }
}
