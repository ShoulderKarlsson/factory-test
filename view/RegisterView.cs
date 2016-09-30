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
    public class RegisterView : View
    {
        public override void Render()
        {
            System.Console.WriteLine("Enter information about new member!");
        }

        public void BusySSN()
        {
            System.Console.WriteLine("That personal number is taken!");
        }

        public model.Name GetName()
        {
            bool loop = true;
            model.Name name = null;

            do
            {
                System.Console.Write("Name: ");
                try
                {
                    name = new model.Name(Console.ReadLine());
                    loop = false;
                }
                catch (Exception e)
                {
                    PresentErrorMessage(e.Message);
                }
            } while(loop);

            return name;
        }
    }
}
