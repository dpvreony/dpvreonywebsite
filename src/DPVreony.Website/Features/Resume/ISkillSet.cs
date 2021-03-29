using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NodaTime;

namespace Dhgms.DPVreony.Website.Models
{
    public interface ISkillSet
    {
        IList<ISkillDetail> Expert { get; set; }

        IList<ISkillDetail> Advanced { get; set; }

        IList<ISkillDetail> Intermediate { get; set; }

        IList<ISkillDetail> Basic { get; set; }

        IList<ISkillDetail> Awareness { get; set; }

        LocalDate LastUpdated { get; set; }
    }
}
