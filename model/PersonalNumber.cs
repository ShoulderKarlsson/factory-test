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
    public class PersonalNumber
    {
        public string _personalNumber;
        public PersonalNumber (string ssn)
        {
            CheckForLetters(ssn);
            CheckLength(ssn);
            _personalNumber = ssn;
        }

        private void CheckForLetters(string ssn)
        {
            foreach(char c in ssn)
            {
                if (!char.IsDigit(c))
                {
                    throw new Exception("Personal number can only contain numbers!");
                }
            }
        }
        private void CheckLength(string ssn)
        {
            if (ssn.Length != 10)
            {
                throw new Exception("Personal Number must be 10 numbers long.");
            }
        }

    }
}