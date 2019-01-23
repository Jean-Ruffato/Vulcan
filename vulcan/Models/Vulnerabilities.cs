using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vulcan.Models
{
    public class Vulnerabilities
    {
        public int ID { get; set; }
        public string Vendor { get; set; }
        public string Product { get; set; }
        public string Version { get; set; }
        public string VulnerabilitieID { get; set; }
        public string ConfidentialityImpact { get; set; }
        public string IntegrityImpact { get; set; }
        public string AvaliabilityImpact { get; set; }
        public string AccessComplexity { get; set; }
        public string Authentication { get; set; }
        public string GainedAccess { get; set; }
        public string Type { get; set; }
        public double Score { get; set; }
        public int Gravity { get; set; }
        public string Description { get; set; }


        public Vulnerabilities()
        {
        }

        public Vulnerabilities(int iD, string vendor, string product, string version, string vulnerabilitieID, string confidentialityImpact, string integrityImpact, string avaliabilityImpact, string accessComplexity, string authentication, string gainedAccess, string type, double score, int gravity, string description)
        {
            ID = iD;
            Vendor = vendor;
            Product = product;
            Version = version;
            VulnerabilitieID = vulnerabilitieID;
            ConfidentialityImpact = confidentialityImpact;
            IntegrityImpact = integrityImpact;
            AvaliabilityImpact = avaliabilityImpact;
            AccessComplexity = accessComplexity;
            Authentication = authentication;
            GainedAccess = gainedAccess;
            Type = type;
            Score = score;
            Gravity = gravity;
            Description = description;
        }
    }    
}