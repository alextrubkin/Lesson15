using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework15
{
    public static class DelegateHolder
    {
        public delegate void MessageHandler(string messageText);
        public delegate string InputTypeHandler();
    }
}
