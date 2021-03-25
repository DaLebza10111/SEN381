using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_S_S_Console
{
    interface IClient
    {
        string clientID { get; set; }
        string serviceLevel { get; set; }

        void sendRequest();
    }
}
