using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComandaPattern.Command;

namespace ComandaPattern
{
    public class UpdateCommand : ITransaction
    {
        private Database _database;
        private int _value;
        private Client _client2;
        public UpdateCommand(Database database, int value,Client client2)
        {
            _database = database;
            _value = value;
            _client2 = client2;
        }

        public void Execute()
        {
            try
            {
                _database.Transfer(_client2, _value);
                Commit(_value);
            }
            catch (Exception e)
            {
                Rollback(e);
            }
        }

        public void Commit()
        {
            Console.WriteLine("Деньги успешно переведены");
        }

        public void Commit(int value)
        {
            Console.WriteLine($"Успешно переведены {value} тг");
        }

        public void Rollback()
        {
            Console.WriteLine("update command was rollbacked");
        }

        public void Rollback(Exception e)
        {
            Console.WriteLine(e);
            Rollback();
        }
    }
}
