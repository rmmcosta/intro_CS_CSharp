using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern_Dinner
{
    abstract class Invoker
    {
        protected List<ICommand> _cmds = new List<ICommand>();
        
        public void AddCommand(ICommand command)
        {
            _cmds.Add(command);
        }
    }
}
