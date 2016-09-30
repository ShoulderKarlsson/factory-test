using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTesting.view
{
    public abstract class View
    {
        public abstract void Render();

        public virtual string GetSSN()
        {
            string ssn = "";
            bool shouldLoop = true;
            do
            {
                Console.Write("Personal Number: ");
                try
                {
                    ssn = Console.ReadLine();
                    CheckForLetters(ssn);
                    CheckLength(ssn);
                    shouldLoop = false;
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            } while (shouldLoop);
            return ssn;
        }

        protected virtual void CheckForLetters(string ssn)
        {
            foreach(char c in ssn)
            {
                if (!char.IsDigit(c))
                {
                    throw new Exception("Personal number can only contain numbers!");
                }
            }
        }

        protected void CheckLength(string ssn)
        {
            if (ssn.Length != 10)
            {
                throw new Exception("Personal Number must be 10 numbers long.");
            }
        }


    }
}

