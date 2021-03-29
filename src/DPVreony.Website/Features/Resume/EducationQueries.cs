using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dhgms.DPVreony.Website.Models;

namespace Dhgms.DPVreony.Website.Queries
{
    public class EducationQueries
    {
        public async Task<IList<IEducationModel>> GetEducationListAsync()
        {
            return await Task.Run(() => GetEducationList());
        }

        private static IList<IEducationModel> GetEducationList()
        {
            return new List<IEducationModel>
            {
                new EducationModel
                {
                    Faculty = "Open University",
                    Qualification = "MSc Computer Science",
                    StartDate = new DateTime(2016, 5, 1),
                    EndDate = new DateTime(2020, 10, 1)
                },

                new EducationModel
                {
                    Faculty = "University Of Salford",
                    Qualification = "Certificate Of Higher Education Software Engineering",
                    StartDate = new DateTime(2006, 9, 1),
                    EndDate = new DateTime(2008, 3, 1)
                },

                new EducationModel
                {
                    Faculty = "Canterbury College",
                    Qualification = "BTEC ND Computer Studies",
                    StartDate = new DateTime(1999, 9, 1),
                    EndDate = new DateTime(2001, 7, 1)
                }
            };
        }
    }
}
