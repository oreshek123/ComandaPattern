using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandaPattern.Command
{
    public interface ITransaction:ICommand
    {
        void Commit();
        void Commit(int value);
        void Rollback();
        void Rollback(Exception ex);
    }
}
