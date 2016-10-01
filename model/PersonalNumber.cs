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
        private string _socialSecurityNumber;
        public PersonalNumber (string ssn)
        {
            SocialSecurityNumber = ssn;
        }

        public string SocialSecurityNumber
        {
            get { return _socialSecurityNumber; }

            set
            {
                foreach(char c in value)
                {
                    if (!char.IsDigit(c))
                    {
                        throw new Exception("Personal number can only contain numbers!");
                    }
                }
                
                if (value.Length != 10)
                {
                    throw new Exception("Personal Number must be 10 numbers long.");
                }
                                        
                _socialSecurityNumber = value;
            }
        }

        // private void CheckForLetters(string ssn)
        // {
        //     foreach(char c in ssn)
        //     {
        //         if (!char.IsDigit(c))
        //         {
        //             throw new Exception("Personal number can only contain numbers!");
        //         }
        //     }
        // }
        // private void CheckLength(string ssn)
        // {
        //     if (ssn.Length != 10)
        //     {
        //         throw new Exception("Personal Number must be 10 numbers long.");
        //     }
        // }

    }
}