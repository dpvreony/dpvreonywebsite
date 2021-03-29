using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dhgms.DPVreony.Website.Models;

namespace Dhgms.DPVreony.Website.ViewModels
{
    public class SkillLevelViewModel
    {
        public string Level { get; set; }

        public IList<ISkillDetail> Skills { get; set; }
    }
}
