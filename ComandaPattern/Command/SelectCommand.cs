using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComandaPattern.Command;

namespace ComandaPattern
{
    public class SelectCommand : ITransaction
    {
        private Database _database;
        private int _value;
        public SelectCommand(Database database)
        {
            _database = database;
        }

        public void Execute()
        {
            try
            {
                int res = _database.Select();
                Commit(res);
            }
            catch (Exception e)
            {
                Rollback(e);
            }
        }

        public void Commit()
        {
            Console.WriteLine("Успешно");
        }

        public void Commit(int value)
        {
            Console.WriteLine($"Баланс = {value} тг");
        }

        public void Rollback()
        {
            Console.WriteLine("select command was rollbacked");
        }

        public void Rollback(Exception e)
        {
            Console.WriteLine(e);
            Rollback();
        }
    }
}
