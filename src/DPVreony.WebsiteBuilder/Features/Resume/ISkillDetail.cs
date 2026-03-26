using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dhgms.DPVreony.Website.Models
{
    public interface ISkillDetail
    {
        string Name { get; }

        Period Duration { get; }
    }
}
