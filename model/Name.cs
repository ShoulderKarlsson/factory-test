using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTesting.model
{
    public class Name
    {
        public string _name;
        public Name (string name)
        {
            CheckLength(name);
            _name = name;
        }

        public void CheckLength(string name)
        {
            if (name.Length < 2)
            {
                throw new Exception("Name is to short!");
            }
        }
    }
}