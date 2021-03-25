using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_S_S_Console
{
    class Call
    {
        string date, duration, startTime;
        int companyId, employeeId;


        public Call(string date, string duration, string startTime, int employeeId, int companyId)
        {
            this.Date = date;
            this.Duration = duration;
            this.StartTime = startTime;
            this.CompanyId = companyId;
            this.EmployeeId = employeeId;
        }

        public string Date { get => date; set => date = value; }
        public string Duration { get => duration; set => duration = value; }
        public string StartTime { get => startTime; set => startTime = value; }
        public int CompanyId { get => companyId; set => companyId = value; }
        public int EmployeeId { get => employeeId; set => employeeId = value; }

        public void AcceptCall()
        {

        }

        public void EndCall()
        {

        }

        public void RecordCall()
        {

        }

        public void sendRequest()
        {
            throw new NotImplementedException();
        }
    }
}
