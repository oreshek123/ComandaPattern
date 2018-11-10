using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ComandaPattern
{
    public class Client
    {
        private string _nameOnCard;
        private string _clientName;
        private string _cardNumber;
        private int _moneyOnCard;



        public Client(string nameOnCard, string cardNumber, int moneyOnCard, string clientName)
        {
            _nameOnCard = nameOnCard;
            _cardNumber = cardNumber;
            _moneyOnCard = moneyOnCard;
            _clientName = clientName;
        }
        public Client(string cardNumber)
        {
            _cardNumber = cardNumber;
        }

        public string NameOnCard { get => _nameOnCard; set => _nameOnCard = value; }
        public string ClientName { get => _clientName; set => _clientName = value; }
        public string CardNumber { get => _cardNumber; set => _cardNumber = value; }
        public int MoneyOnCard { get => _moneyOnCard; set => _moneyOnCard = value; }

        public Database GetDataBase()
        {
            return _database;
        }
    }
}
