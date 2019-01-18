using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vulcan.Models
{
    public class Vulnerabilities
    {
        public int ID { get; set; }
        private string Vendor { get; set; }
        public string Product { get; set; }
        public double Version { get; set; }
        public string VulnerabilitieID { get; set; }
        public string VulnerabilitieName { get; set; }
        public string ConfidentialityImpact { get; set; }
        public string IntegrityImpact { get; set; }
        public string AvaliabilityImpact { get; set; }
        public string AccessComplexity { get; set; }
        public string Authentication { get; set; }
        public string GainedAccess { get; set; }
        public string Type { get; set; }
        public int Score { get; set; }
        public int Gravity { get; set; }
        public string Description { get; set; }
    }
}