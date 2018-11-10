using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace ComandaPattern.Command
{
    public class AddCommand:ITransaction
    {
        private Database _database;
        private int _value;
        public AddCommand(Database database, int value)
        {
            _database = database;
            _value = value;
        }

        public void Execute()
        {
            try
            {
                _database.Insert(_value);
                Commit(_value);
            }
            catch (Exception e)
            {
                Rollback(e);
            }
        }

        public void Commit()
        {
            Console.WriteLine("Успешно добавили");
        }

        public void Commit(int value)
        {
            Console.WriteLine($"Успешно добавили {value} тг");
        }

        public void Rollback()
        {
            Console.WriteLine("insert command was rollbacked");
        }

        public void Rollback(Exception e)
        {
            Console.WriteLine(e);
            Rollback();
        }
    }
}
