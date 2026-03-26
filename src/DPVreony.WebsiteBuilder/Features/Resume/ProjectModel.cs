using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dhgms.DPVreony.Website.Models
{
    public class ProjectModel : IProjectModel
    {
        public string Name { get; set; }
        public string[] Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public ProjectType ProjectType { get; set; }
        public Uri GithubRepository { get; set; }
        public Uri WebSite { get; set; }
        public string Logo { get; set; }
    }
}
