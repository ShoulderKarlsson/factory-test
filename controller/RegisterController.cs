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
            TryRegisterNewInformation();
        }
        private void TryRegisterNewInformation()
        {
            // SSN = PersonalNumber object
            model.PersonalNumber SSN = _rView.GetSSN();
            if (!existingSSN(SSN.SocialSecurityNumber))
            {
                _rView.BusySSN();
                TryRegisterNewInformation();
            }

            model.Name name = _rView.GetName();

        }

        private void SaveNewMember(model.Name n, model.PersonalNumber pN)
        {
            model.Member m = new model.Member(n.MemberName, pN.SocialSecurityNumber, 1);
            
        }
    }
}