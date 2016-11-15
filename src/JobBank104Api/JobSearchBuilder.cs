using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBank104Api {
    public class JobSearchBuilder {
        /// <summary>
        /// 類型
        /// </summary>
        public JobRoles Role { get; set; }

        /// <summary>
        /// 排序方式
        /// </summary>
        public QueryOrders? Order { get; set; }

        /// <summary>
        /// 是否為遞增排序
        /// </summary>
        public bool? IsAscOrder { get; set; }

        /// <summary>
        /// 關鍵字
        /// </summary>
        public string Keyword { get; set; }

        public QueryKeywordModes? KeywordMode { get; set; }
        public QueryKeywordScopes? KeywordScope { get; set; }

        public QueryFilterTypes SearchOutsourcing { get; set; } = QueryFilterTypes.Informal;
        public QueryFilterTypes SearchDispatch { get; set; } = QueryFilterTypes.Informal;
        public QueryFilterTypes SearchDisability { get; set; } = QueryFilterTypes.Informal;

        public List<JobRoleStatus> RoleStatus { get; set; } 

        public ManagementLevels? MangementLevel { get; set; }
       

        public List<JobSalary> SalaryTypes { get; set; }
        public int? Salary_Max { get; set; }
        public int? Salary_Min { get; set; }


        public DisabilityTypes? DisabilityType { get; set; }
        public DisabilityLevels? DisabilityLevel { get; set; }

        
        public List<JobType> FilterJobTypes { get; set; } 
        public List<Area> FilterAreas { get; set; }
        public List<Indust> FilterIndusts { get; set; }
        public List<Major> FilterMajor { get; set; }
        public List<ComputerSkill> FilterComputerSkills { get; set; }
        public List<JobSkill> FilterJobSkills { get; set; }
        public List<Certification> FilterCertifications { get; set; }

        public Educations? MinEducation { get; set; }


        public int? Experience { get; set; }
        public QueryRange? ExperienceRange { get; set; }

        public Languages? Language { get; set; }
        public LanguageLevels? LanguageLevel { get; set; }
        public QueryRange? LanguageLevelRange { get; set; }

        public StartTimes? StartBy { get; set; }
        public PartTimeJobTypes? PartTimeJobType { get; set; }


        public JobSearchBuilder(JobRoles role = JobRoles.Informal) {
            this.Role = role;
        }

        public JobSearchBuilder Keyword(string keyword) {

        }
    }
}
