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
        private string _memberName;
        public Name (string name)
        {
            MemberName = name;
        }

        public string MemberName 
        {
            get { return _memberName; }
            private set
            {
                if (value.Length < 2)
                {
                    throw new Exception("Name is to short!");
                }

                _memberName = value;    
            }
        }
    }
}