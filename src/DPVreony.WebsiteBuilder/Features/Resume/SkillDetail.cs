using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dhgms.DPVreony.Website.Models
{
    public class SkillDetail : ISkillDetail
    {
        public string Name { get; set; }

        public Period Duration { get; set; }
        public UsageFrequency CurrentUsage { get; set; }
        public UsageFrequency PeakUsage { get; set; }
    }
}
