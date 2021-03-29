using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dhgms.DPVreony.Website.Models
{
    public class EducationModel : IEducationModel
    {
        public string Faculty { get; set; }
        public string Qualification { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }
    }
}
