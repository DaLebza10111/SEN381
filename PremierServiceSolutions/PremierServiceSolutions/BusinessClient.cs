using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions
{
    class BusinessClient : IClient
    {
        string companyName, email, phone;
        int contractId;
        public BusinessClient(string clientID, string serviceLevel,string companyName,string email, string phone, int contactId) : base()
        {
            this.clientID = clientID;
            this.serviceLevel = serviceLevel;
            this.CompanyName = companyName;
            this.Email = email;
            this.Phone = phone;
            this.ContractId = contactId;
        }

        public string clientID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string serviceLevel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CompanyName { get => companyName; set => companyName = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public int ContractId { get => contractId; set => contractId = value; }

        
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
