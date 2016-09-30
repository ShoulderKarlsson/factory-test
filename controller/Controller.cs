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
    public abstract class Controller
    {
        protected view.View _desiredView;
        public Controller (view.View v)
        {
          _desiredView = v;
        }

        public abstract void init();

        public virtual bool existingSSN(string ssn)
        {
            var mCat = new model.MemberCatalog();
            foreach (model.Member m in mCat._storedMembers)
            {
                if (ssn == m.PersonalNumber)
                {
                    return false;
                }
            }
            return true;
        }
    }
}