using System;
using System.ServiceModel;

namespace ClassLibrary
{
    public class Class1
    {
        public void HostLocalService()
        {
            ServiceHost svc = null;
            NotifyListener nvc = new NotifyListener();
            Uri httpBaseAddress = new Uri("http://localhost:6789/NotificationListener");
            svc = new ServiceHost(nvc, httpBaseAddress);
            svc.Open();
        }
    }
}
