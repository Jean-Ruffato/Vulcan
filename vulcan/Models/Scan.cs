using vulcan.Models.Enums;
using System.Collections.Generic;
using System.Linq;

namespace vulcan.Models
{
    public class Scan
    {        
        public int ID { get; set; }
        public int ScanID { get; set; }
        public string Host { get; set; }
        public string OperatingSystem { get; set; }
        public string SoftwareName { get; set; }
        public string SoftwareVersion { get; set; }
        public ICollection<Vulnerabilities> FoundVulnerabilitie { get; set; } = new List<Vulnerabilities>();
        public int VulnerabilitiesQuantity { get; set; }
        public ScanStatus ScanStatus { get; set; } 
        
        public Scan()
        {
        }

        public Scan(int iD, int scanID, string host, string operatingSystem, string softwareName, string softwareVersion, int vulnerabilitiesQuantity, ScanStatus scanStatus)
        {
            ID = iD;
            ScanID = scanID;
            Host = host;
            OperatingSystem = operatingSystem;
            SoftwareName = softwareName;
            SoftwareVersion = softwareVersion;
            VulnerabilitiesQuantity = vulnerabilitiesQuantity;
            ScanStatus = scanStatus;
        }

        public void AddVulnerabilitie(Vulnerabilities vulnerabilitie)
        {
            FoundVulnerabilitie.Add(vulnerabilitie);
        }

        public void RemoveVulnerabilitie(Vulnerabilities vulnerabilitie)
        {
            FoundVulnerabilitie.Remove(vulnerabilitie);
        }

        public double TotalVulnerabilities(string vulnerabilitieID)
        {
            return FoundVulnerabilitie.Where(vulnerabilitie => vulnerabilitie.VulnerabilitieID == vulnerabilitieID).Count();
        }
    }
}