using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_S_S_Console
{
    abstract class Contract
    {
        string contractId, contactType, contactDescription;
        double IndividualPrice, BusinessPrice;

        public string ContractId { get => ContractId1; set => ContractId1 = value; }
        public abstract double Price { get; set; }
        public string ContractId1 { get => contractId; set => contractId = value; }
        public string ContactType { get => contactType; set => contactType = value; }
        public string ContactDescription { get => contactDescription; set => contactDescription = value; }
        public double IndividualPrice1 { get => IndividualPrice; set => IndividualPrice = value; }
        public double BusinessPrice1 { get => BusinessPrice; set => BusinessPrice = value; }
    }
}
