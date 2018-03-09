using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace RuntimeComponent1
{
    public sealed class Class1
    {
        public void WrapperHost()
        {
            ClassLibrary.Class1 c1 = new ClassLibrary.Class1();
            c1.HostLocalService();
        }
    }
}
