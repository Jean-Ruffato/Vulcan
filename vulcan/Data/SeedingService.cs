using System.Linq;
using vulcan.Models;
using vulcan.Models.Enums;

namespace vulcan.Data
{
    public class SeedingService
    {
        private VulcanContext _context;

        public SeedingService (VulcanContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Vulnerabilities.Any() || _context.Scan.Any())
            {
                return; // DB já está populado
            }

            Vulnerabilities vulUm = new Vulnerabilities(1, "Apache", "Web Server", "2.3.2", "CVE-2018-11776", "Alto", "Médio", "Baixo", 
                "Médio", "Não requerido", "Nenhum", "Execution Code", 9.3, 6, 
                "Apache Struts versions 2.3 to 2.3.34 and 2.5 to 2.5.16 suffer from possible Remote Code Execution when alwaysSelectFullNamespace " +
                "is true (either by user or a plugin like Convention Plugin) and then: results are used with no namespace and in same time, its upper package " +
                "have no or wildcard namespace and similar to results, same possibility when using url tag which doesn't have value and action set and in same time, " +
                "its upper package have no or wildcard namespace. ");

            Scan scanUm = new Scan(1, 3432431, "192.168.0.1", "Mac OS Mojave", "Apache Web server", "2.2.3", 20, ScanStatus.Finalizado);

            _context.Vulnerabilities.AddRange(vulUm);

            _context.Scan.AddRange(scanUm);

            _context.SaveChanges();
        }
    }
}
