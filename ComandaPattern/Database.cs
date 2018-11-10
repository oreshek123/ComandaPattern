using System;
using System.Collections.Generic;
using System.Data;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Compilation;

namespace ComandaPattern
{
    public class Database
    {
        private Money _money;
       
        public Database(Money money)
        {
            _money = money;
        }

        public void Insert(Money money)
        {
            _money.ClientMoney = money.ClientMoney;

        }

        public void Update(Money money)
        {
            _money.ClientMoney += money.ClientMoney;

        }

        public void Delete(Money money)
        {
            if (money.ClientMoney > _money.ClientMoney)
                throw new Exception("Not enough money to withdraw");

            _money.ClientMoney = 0;
        }

        public int Select()
        {
            return _money.ClientMoney;
        }

    }
}
