using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComandaPattern.Command;

namespace ComandaPattern
{
    public class DeleteCommand : ITransaction
    {
        private Database _database;
        private int _value;
        public DeleteCommand(Database database, int value)
        {
            _database = database;
            _value = value;
        }

        public void Execute()
        {
            try
            {
                _database.Delete(_value);
                Commit(_value);
            }
            catch (Exception e)
            {
                Rollback(e);
            }
        }

        public void Commit()
        {
            Console.WriteLine("Успешно снято");
        }

        public void Commit(int value)
        {
            Console.WriteLine($"Успешно снято {value} тг");
        }

        public void Rollback()
        {
            Console.WriteLine("delete command was rollbacked");
        }

        public void Rollback(Exception e)
        {
            Console.WriteLine(e.Message);
            Rollback();
        }
    }
}
