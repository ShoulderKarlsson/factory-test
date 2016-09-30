using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTesting.controller
{
    public class RegisterController : Controller
    {

        view.RegisterView _rView;

        public RegisterController (view.View v)
        {
            _rView = (view.RegisterView)v;
        }

        public override void init()
        {
            _rView.Render();
            CollectInformation();
        }

        private model.PersonalNumber GetSSN()
        {
            return _rView.GetSSN();
        }

        private void CollectInformation()
        {
            model.PersonalNumber SSN = GetSSN();
            if (!existingSSN(SSN._personalNumber))
            {
                _rView.BusySSN();
                CollectInformation();
            }    
        }
    }
}