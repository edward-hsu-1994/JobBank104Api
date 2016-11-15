using JobBank104Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test {
    public class Program {
        public static void Main(string[] args) {
            var k = JobType.GetRootType().GetAwaiter().GetResult()
                .FindTypes(x=>x.Name.Contains("Internet"));
            var area = Area.GetRootArea().GetAwaiter().GetResult()
                .FindAreas(x => x.Name.Contains("西"));
            var k2 = Indust.GetRootIndust().GetAwaiter().GetResult()
                .FindIndusts(x => x.Name.Contains("資"));
            var majors = Major.GetRootMajor().GetAwaiter().GetResult()
                .FindMajors(x => x.Name.Contains("資訊"));
            var comp = ComputerSkill.GetRootComputerSkill().GetAwaiter().GetResult()
                .FindComputerSkills(x => x.Name.Contains("ERP"));
            var k3 = Certification.GetRootCertification().GetAwaiter().GetResult()
                .FindCertifications(x => x.Name.Contains("貿易經營師證照"));
            var k4 = JobSkill.GetRootJobSkill().GetAwaiter().GetResult()
                .FindJobSkills(x => x.Name.Contains("會計")); 
        }
    }
}
