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
    public class MemberCatalog
    {
        public List<model.Member> _storedMembers = new List<model.Member>();

        public MemberCatalog()
        {
            _storedMembers.Add(new model.Member("Kingen", "1231231231", 1));
            _storedMembers.Add(new model.Member("Kingen2", "1231231232", 2));
            _storedMembers.Add(new model.Member("Kingen3", "1231231233", 3));
            
        }

        public void AddNewUser(model.Member m)
        {
            _storedMembers.Add(m);
        }
    }
}