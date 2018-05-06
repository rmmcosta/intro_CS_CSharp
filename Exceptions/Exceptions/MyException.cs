using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class MyException : Exception
    {
        public MyException() : base("This is my exception!")
        {

        }
        //public override string Message => base.Message;
    }
}
