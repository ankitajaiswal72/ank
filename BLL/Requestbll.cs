using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagementSystem.BLL
{
    internal class Requestbll
    {
        public int RequestId { get; set; }
        public DateTime RequestDate { get; set; }
        public string DonorName { get; set;}
        public string Disease { get; set;}
        public string BloodGroup{ get; set;}
        public int Unit { get; set;}
        public string Status { get; set;}

    }
}
