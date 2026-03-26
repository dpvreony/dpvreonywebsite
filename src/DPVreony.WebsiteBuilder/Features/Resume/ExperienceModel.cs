using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dhgms.DPVreony.Website.Models
{
    public class ExperienceModel
    {
        public string EmployerName { get; set; }

        public string JobTitle { get; set; }

        public string[] Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string[] Accomplishments { get; set; }
    }
}
