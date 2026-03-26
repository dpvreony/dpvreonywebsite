using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NodaTime;

namespace Dhgms.DPVreony.Website.Models
{
    public class SkillSet : ISkillSet
    {
        public IList<ISkillDetail> Expert { get; set; }
        public IList<ISkillDetail> Advanced { get; set; }
        public IList<ISkillDetail> Intermediate { get; set; }
        public IList<ISkillDetail> Basic { get; set; }
        public IList<ISkillDetail> Awareness { get; set; }
        public LocalDate LastUpdated { get; set; }
    }
}
