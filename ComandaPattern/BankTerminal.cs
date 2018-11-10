using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComandaPattern.Command;


namespace ComandaPattern
{
    public class BankTerminal
    {
        public void BeginTransaction(ICommand command)
        {
            command.Execute();
        }
    }
}
