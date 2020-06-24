using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMU_Project_App
{
    public class Complaints
    {
        /* Variables */
        private string complaint;
        private string date;

        //* Constructor */
        public Complaints(string date, string complaint)
        {
            this.complaint = complaint;
            this.date = date;
        }

        // Methods.
        public string GetComplaintInfo()
        {
            return $"{this.date}:  {this.complaint}";
        }
    }
}
