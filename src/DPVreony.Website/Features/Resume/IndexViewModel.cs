using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dhgms.DPVreony.Website.Models;

namespace Dhgms.DPVreony.Website.ViewModels
{
    public class IndexViewModel
    {
        public IList<ExperienceModel> Experience { get; set; }

        public IList<IEducationModel> Education { get; set; }

        public IList<IProjectModel> Projects { get; set; }

        public ISkillSet SkillSet { get; set; }
    }
}
