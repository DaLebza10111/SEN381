using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_S_S_Console
{
    class IndividualClient : Person, IClient
    {
        public IndividualClient(string clientID, string serviceLevel) : base()
        {
            this.clientID = clientID;
            this.serviceLevel = serviceLevel;
        }

        public string clientID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string serviceLevel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Regiter()
        {
            throw new NotImplementedException();
        }

        public void sendRequest()
        {
            throw new NotImplementedException();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
