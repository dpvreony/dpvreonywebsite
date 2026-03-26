using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dhgms.DPVreony.Website.Models;
using NodaTime;

namespace Dhgms.DPVreony.Website.Queries
{
    public class SkillQueries
    {
        private static readonly LocalDate AudataStart = new LocalDate(2001, 4, 1);
        private static readonly LocalDate EncamsStart = new LocalDate(2004, 4, 1);
        private static readonly LocalDate SagaGmdStart = new LocalDate(2010, 4, 1);
        private static readonly LocalDate SagaCcTechStart = new LocalDate(2012, 6, 1);
        private static readonly LocalDate AzureStart = new LocalDate(2014, 6, 1);

        public async Task<ISkillSet> GetSkillSectionListAsync()
        {
            return await Task.Run(() => GetSkillSectionList());
        }

        private static ISkillSet GetSkillSectionList()
        {
            return new SkillSet
            {
                LastUpdated = new LocalDate(2018, 8, 1),
                Expert = GetExpertSkills(),
                Advanced = GetAdvancedSkills(),
                Intermediate =  GetIntermediateSkills(),
                Basic = GetBasicSkills(),
                Awareness = GetAwarenessSkills()
            };
        }

        private static IList<ISkillDetail> GetExpertSkills()
        {
            return new List<ISkillDetail>
                {
                    GetSkillDetail("Azure ServiceBus", AzureStart, UsageFrequency.Daily),
                    GetSkillDetail("C#", EncamsStart, UsageFrequency.Daily),
                    GetSkillDetail("Entity Framework", SagaGmdStart, UsageFrequency.Weekly),
                    GetSkillDetail("HTML", AudataStart, UsageFrequency.Weekly),
                    GetSkillDetail("IIS", AudataStart, UsageFrequency.Weekly, UsageFrequency.Daily),
                    GetSkillDetail("SQL", AudataStart, UsageFrequency.Daily),
                    GetSkillDetail("ReactiveUI", SagaCcTechStart, UsageFrequency.Weekly, UsageFrequency.Daily),
                    GetSkillDetail("Text Transforms", EncamsStart, UsageFrequency.Weekly, UsageFrequency.Daily),
                    GetSkillDetail("Web API", SagaCcTechStart, UsageFrequency.Weekly, UsageFrequency.Daily),
                    GetSkillDetail("WCF", SagaGmdStart, UsageFrequency.Weekly, UsageFrequency.Daily),
                    GetSkillDetail("XML", AudataStart, UsageFrequency.Monthly),
                    GetSkillDetail("VB.NET", EncamsStart, UsageFrequency.Weekly, UsageFrequency.Daily),
            };
        }

        private static IList<ISkillDetail> GetAdvancedSkills()
        {
            return new List<ISkillDetail>
            {

                GetSkillDetail("Active Directory", EncamsStart, UsageFrequency.Monthly),
                GetSkillDetail("Group Policy", EncamsStart, UsageFrequency.Monthly),
                GetSkillDetail("Octopus Deploy", AzureStart, UsageFrequency.Daily),
                GetSkillDetail("Oracle", SagaCcTechStart, UsageFrequency.Weekly, UsageFrequency.Daily),
                GetSkillDetail("Roslyn", AzureStart, UsageFrequency.Weekly),
            };
        }

        private static IList<ISkillDetail> GetIntermediateSkills()
        {
            return new List<ISkillDetail>
            {
                GetSkillDetail("Javascript", EncamsStart, UsageFrequency.Weekly, UsageFrequency.Weekly),
                GetSkillDetail("JQuery", SagaCcTechStart, UsageFrequency.Weekly, UsageFrequency.Weekly),
                GetSkillDetail("KnockoutJS", new LocalDate(2015, 1, 1), UsageFrequency.Weekly, UsageFrequency.Weekly),
                GetSkillDetail("C++", Period.FromYears(8), UsageFrequency.Rare, UsageFrequency.Daily),
                GetSkillDetail("SSIS", SagaGmdStart, UsageFrequency.Rare, UsageFrequency.Daily),
                GetSkillDetail("SSRS", SagaGmdStart, UsageFrequency.Rare, UsageFrequency.Daily),
                GetSkillDetail("Powershell", SagaGmdStart, UsageFrequency.Weekly, UsageFrequency.Weekly),
            };
        }

        private static IList<ISkillDetail> GetBasicSkills()
        {
            return new List<ISkillDetail>
            {
                GetSkillDetail("Avaya CMS", new LocalDate(2014, 1, 1), UsageFrequency.NotCurrentlyUsed, UsageFrequency.Daily),
                GetSkillDetail("Avaya Intelligent Customer Routing", new LocalDate(2014, 1, 1), UsageFrequency.NotCurrentlyUsed, UsageFrequency.Daily),
                GetSkillDetail("Genesys SpeechMiner", new LocalDate(2014, 1, 1), UsageFrequency.NotCurrentlyUsed, UsageFrequency.Daily),
                GetSkillDetail("Java", Period.FromYears(2), UsageFrequency.Rare),
                GetSkillDetail("PKCS#11", new LocalDate(2018, 3, 1), UsageFrequency.Weekly, UsageFrequency.Daily),
                GetSkillDetail("Qfiniti", new LocalDate(2014, 1, 1), UsageFrequency.NotCurrentlyUsed, UsageFrequency.Daily),
                GetSkillDetail("SSAS", SagaGmdStart, UsageFrequency.Rare, UsageFrequency.Weekly),
                GetSkillDetail("Smart Communications", new LocalDate(2016, 10, 1), UsageFrequency.Weekly),
                GetSkillDetail("Thunderhead ONE", new LocalDate(2015, 1, 1), UsageFrequency.NotCurrentlyUsed, UsageFrequency.Daily),
            };
        }

        private static IList<ISkillDetail> GetAwarenessSkills()
        {
            return new List<ISkillDetail>
            {
                GetSkillDetail("Machine Learning", Period.FromYears(1), UsageFrequency.Rare),
                GetSkillDetail("RPGLE", Period.FromMonths(6), UsageFrequency.NotCurrentlyUsed, UsageFrequency.Rare),
            };
        }

        private static SkillDetail GetSkillDetail(string name, LocalDate startDate, UsageFrequency currentUsage, UsageFrequency peakUsage)
        {
            var today = LocalDate.FromDateTime(DateTime.Today);

            return new SkillDetail
            {
                Name = name,
                Duration = NodaTime.Period.Between(startDate, today),
                CurrentUsage = currentUsage,
                PeakUsage = peakUsage
            };
        }

        private static SkillDetail GetSkillDetail(string name, LocalDate startDate, UsageFrequency currentUsage)
        {
            return GetSkillDetail(name, startDate, currentUsage, currentUsage);
        }

        private static SkillDetail GetSkillDetail(string name, Period period, UsageFrequency currentUsage, UsageFrequency peakUsage)
        {
            return new SkillDetail
            {
                Name = name,
                Duration = period,
                CurrentUsage = currentUsage,
                PeakUsage = peakUsage
            };
        }

        private static SkillDetail GetSkillDetail(string name, Period period, UsageFrequency currentUsage)
        {
            return GetSkillDetail(name, period, currentUsage, currentUsage);
        }
    }
}
