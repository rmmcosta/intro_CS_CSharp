using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern_DomoticHouse
{
    interface ICommand
    {
        void Execute();
        void UnExecute();
    }
}
