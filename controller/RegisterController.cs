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

        public RegisterController (view.View v) : base(v) { }

        public override void init()
        {
            _desiredView.Render();
            CollectInformation();
        }

        private model.PersonalNumber GetSSN()
        {
            return _desiredView.GetSSN();
        }

        private void CollectInformation()
        {
            model.PersonalNumber SSN = GetSSN();
            if (!existingSSN(SSN._personalNumber))
            {
                _desiredView.SsnMessage();
                CollectInformation();
            }    
        }

    }
}