using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_S_S_Console
{
    class Job
    {
        string jobID, clientName, technician;
        int duration;
        bool finished;

        public string JobID { get => jobID; set => jobID = value; }
        public string ClientName { get => clientName; set => clientName = value; }
        public string Technician { get => technician; set => technician = value; }
        public bool Finished { get => finished; set => finished = value; }
        public int Duration { get => duration; set => duration = value; }

        public Job(string jobID, string clientName, string technician, int duration)
        {
            this.JobID = jobID;
            this.ClientName = clientName;
            this.Technician = technician;
            this.Duration = duration;

        }

        public void StartJob()
        {

        }

        public void FinishJob()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }

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
