using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGClientTest
{
    public class ServiceCallback : WcfService.IWcfServiceCallback
    {
        public void ClientOffline(string Msg)
        {
            throw new NotImplementedException();
        }
    }
}
