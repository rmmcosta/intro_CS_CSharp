using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern_Dinner
{
    class InvokerWaitress : Invoker
    {
        public void Order()
        {
            foreach(ICommand cmd in _cmds)
            {
                cmd.Execute();
            }
            _cmds.Clear();
        }
    }
}
