using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dhgms.DPVreony.Website.Models
{
    public interface IEducationModel
    {
        string Faculty { get; }

        string Qualification { get; }

        DateTime StartDate { get; }

        DateTime? EndDate { get; }

        string Description { get; }
    }
}
