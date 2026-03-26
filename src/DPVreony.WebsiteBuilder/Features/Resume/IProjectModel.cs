using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dhgms.DPVreony.Website.Models
{
    public interface IProjectModel
    {
        string Name { get; }

        string[] Description { get; }

        DateTime StartDate { get; }

        DateTime? EndDate { get; }

        ProjectType ProjectType { get; set; }

        Uri GithubRepository { get; set; }

        Uri WebSite { get; }

        string Logo { get; }
    }
}
