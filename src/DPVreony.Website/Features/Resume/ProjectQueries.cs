using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dhgms.DPVreony.Website.Models;

namespace Dhgms.DPVreony.Website.Queries
{
    public class ProjectQueries
    {
        public async Task<IList<IProjectModel>> GetProjectsListAsync()
        {
            return await Task.Run(() => GetProjectsList());
        }

        private static IList<IProjectModel> GetProjectsList()
        {
            return new List<IProjectModel>
            {
                GetNucleotideRoslynRewriteProject(),
                GetSagaInsuranceSystemRewriteIntegrationProject(),
                GetSagaCtiBladeMigrationProject(),
                GetSagaCrmPhoneCallJournalProject(),
                GetSagaFcaComplaintsProcessWorkflowProject(),
                GetSagaDocumentArchiveThirdPartyNotificationProject(),
                GetSagaDocumentArchiveHighAvailabilityProject(),
                GetSagaDocumentProductionQuarantineProject(),
                GetSagaLegalProductThirdPartyIntegrationProject(),
                GetThunderheadOneBehaviouralTargetingProject(),
                GetQfinitiCallRecordingOrganisationStructureAutomationProject(),
                GetQfinitCallRecordingMetadataImplementationProject(),
                GetGenesysSpeechAnalyticsImplementationProject(),
                GetQfinitiCallRecordingMetadataMiddlewareImplementationProject(),
                GetAs400LongRunningJobsToMsSqlMigration(),
                GetResolProcessAnalysisProject(),
                GetNegativeCommissionBrokingProject(),
                GetTfs2010InstallationProject(),
                GetHmtSanctionsProject(),
                GetDirectChoiceSmsFeedbackProcessorProject(),
                GetDirectChoiceResolProcessProject(),
                GetDirectChoiceSingleCustomerView(),
                GetDirectChoiceTheAAAuditProject(),
                GetSagaPciPaymentGatewayProject(),
                GetSagaCrmSearchScreenReplacementProject(),
                GetKeepBritainTidyGreatPlainsRecoveryProject(),
                GetWindowsServerUpdateApprovalAutomationProject(),
                GetKeepBritainTidyActiveDirectoryMigration()
            }.OrderByDescending(x => x.StartDate).ToArray();
        }

        private static IProjectModel GetSagaCrmPhoneCallJournalProject()
        {
            return new ProjectModel
            {
                Description = new[]{"Improvement to the CRM platform to visualise what is happening during a phone call and at customer loads. The challenge with a call centre operation is that a journal entry can comprise of many phone calls or many customer loads (duplicate records, relatives, etc.). The journal screen considers a session reset to be when there is no active phone call and no customer loaded. The system is also designed to append notifications from other systems. The end aim for this is to improve the amount and quality of data for analysis to be carried out by the business as part of Speech Analytics etc."},
                Name = "CRM Phone Call Journal",
                StartDate = new DateTime(2015, 11, 1),
                EndDate = new DateTime(2015, 11, 1),
                ProjectType = ProjectType.Professional
            };
        }

        private static IProjectModel GetSagaInsuranceSystemRewriteIntegrationProject()
        {
            return new ProjectModel
            {
                Description = new[]{"Working alongside the team responsible for the Insurance transaction system to plan the real-time integration into the CRM platform. My role has been to recommend the technologies being utilised by our team as part of this project."},
                Name = "Insurance System Rewrite Integration",
                StartDate = new DateTime(2016, 1, 1),
                EndDate = new DateTime(2016, 2, 1),
                ProjectType = ProjectType.Professional
            };
        }

        private static IProjectModel GetSagaFcaComplaintsProcessWorkflowProject()
        {
            return new ProjectModel
            {
                Description = new[]{"Adjustment of existing complaints process to meet new FCA regulatory requirements while simplifying the process the users have to go through. Simplification has allowed for some screens to be rewritten in WPF working on top of the existing Winforms application, as it was quicker to recreate those screens than adjust the existing largely redundant screens."},
                Name = "FCA Complaints Process Workflow",
                StartDate = new DateTime(2016, 1, 1),
                EndDate = new DateTime(2016, 2, 1),
                ProjectType = ProjectType.Professional
            };
        }

        private static IProjectModel GetSagaDocumentProductionQuarantineProject()
        {
            return new ProjectModel
            {
                Description = new[]{ "A project to allow the quarantining of Customer Documents during a release phase to allow verification spot checks to take place and reduce risk of customers receiving incorrect documents."},
                Name = "Saga Document Production Quarantine System",
                StartDate = new DateTime(2015, 5, 1),
                EndDate = new DateTime(2017, 3, 1),
                ProjectType = ProjectType.Professional
            };
        }

        private static IProjectModel GetSagaCtiBladeMigrationProject()
        {
            return new ProjectModel
            {
                Description = new[]{ "Upgrade of CCTech platform from Windows Server 2003 to 2012 and from Oracle 10 to Oracle 11. Included automation of release processes via Octopus deploy and migration to new F5 load balancers"},
                Name = "Saga Contact Centre platform migration to Windows Server 2012 R2",
                StartDate = new DateTime(2014, 5, 1),
                EndDate = new DateTime(2016, 6, 1),
                ProjectType = ProjectType.Professional
            };
        }

        private static IProjectModel GetSagaLegalProductThirdPartyIntegrationProject()
        {
            return new ProjectModel
            {
                Description = new[]{ "Production of integrations with 3rd Party that were fulfilling the Saga Legal product on behalf of Saga. 2 way process involved sending leads to 3rd parties and providing web service in order to get status updates back."},
                Name = "Saga Legal Product Third Party Integration",
                StartDate = new DateTime(2010, 5, 1),
                EndDate = new DateTime(2010, 5, 1),
                ProjectType = ProjectType.Professional
            };
        }

        private static IProjectModel GetThunderheadOneBehaviouralTargetingProject()
        {
            return new ProjectModel
            {
                Description = new[]{ "Production of integration between Saga CRM, Saga Websites and Thunderhead ONE platform to allow Holidays arm of the business to carry out targeted campaigns to customers based on site activity and CRM historical data."},
                Name = "Thunderhead ONE Behavioral Targeting",
                StartDate = new DateTime(2010, 5, 1),
                EndDate = new DateTime(2010, 5, 1),
                ProjectType = ProjectType.Professional
            };
        }

        private static IProjectModel GetSagaDocumentArchiveThirdPartyNotificationProject()
        {
            return new ProjectModel
            {
                Description = new[]{ "?"},
                Name = "Saga Document Archive Third Party Integration",
                StartDate = new DateTime(2010, 5, 1),
                EndDate = new DateTime(2010, 5, 1),
                ProjectType = ProjectType.Professional
            };
        }

        private static IProjectModel GetSagaDocumentArchiveHighAvailabilityProject()
        {
            return new ProjectModel
            {
                Description = new[]{ "?"},
                Name = "Saga Document Archive High Availability",
                StartDate = new DateTime(2010, 5, 1),
                EndDate = new DateTime(2010, 5, 1),
                ProjectType = ProjectType.Professional
            };
        }

        private static IProjectModel GetKeepBritainTidyGreatPlainsRecoveryProject()
        {
            return new ProjectModel
            {
                Description = new[]{ "?"},
                Name = "Great Plains Disaster Recovery",
                StartDate = new DateTime(2010, 5, 1),
                EndDate = new DateTime(2010, 5, 1),
                ProjectType = ProjectType.Professional
            };
        }

        private static IProjectModel GetWindowsServerUpdateApprovalAutomationProject()
        {
            return new ProjectModel
            {
                Description = new[]{ "?"},
                Name = "WSUS Update Approval Automation",
                StartDate = new DateTime(2010, 5, 1),
                EndDate = new DateTime(2010, 5, 1),
                ProjectType = ProjectType.Professional
            };
        }

        private static IProjectModel GetKeepBritainTidyActiveDirectoryMigration()
        {
            return new ProjectModel
            {
                Description = new[]{ "?"},
                Name = "NT4 to Active Directory Migration",
                StartDate = new DateTime(2010, 5, 1),
                EndDate = new DateTime(2010, 5, 1),
                ProjectType = ProjectType.Professional
            };
        }

        private static IProjectModel GetDirectChoiceSmsFeedbackProcessorProject()
        {
            return new ProjectModel
            {
                Description = new[]{ "?"},
                Name = "Direct Choice SMS Feedback Processor",
                StartDate = new DateTime(2010, 5, 1),
                EndDate = new DateTime(2010, 5, 1),
                ProjectType = ProjectType.Professional
            };
        }

        private static IProjectModel GetSagaCrmSearchScreenReplacementProject()
        {
            return new ProjectModel
            {
                Description = new []{ "?" },
                Name = "Saga CRM Search Screen Replacement",
                StartDate = new DateTime(2010, 5, 1),
                EndDate = new DateTime(2010, 5, 1),
                ProjectType = ProjectType.Professional
            };
        }

        private static IProjectModel GetSagaPciPaymentGatewayProject()
        {
            return new ProjectModel
            {
                Description = new []
                {
                    "As part of Saga’s replacement of its existing Payment system I worked as part of a technical group to review 3rd party tenders and options for internal development to ensure the company had a full picture of the options available and the different implications for development timescales, ease of PCI compliance.",
                    "I produced prototypes for a system that would have seen Saga responsible for liability of the PCI layer, along with producing integration pieces for 3rd party solutions that varied between desktop applications that called web services, 3rd party hosted iframes, 3rd party hosted portals and open source solutions."
                },
                Name = "Saga PCI Payment Gateway Replacement",
                StartDate = new DateTime(2010, 5, 1),
                EndDate = new DateTime(2010, 5, 1),
                ProjectType = ProjectType.Professional
            };
        }

        private static IProjectModel GetDirectChoiceResolProcessProject()
        {
            return new ProjectModel
            {
                Description = new[] { "?" },
                Name = "Direct Choice Resolicitation Process",
                StartDate = new DateTime(2010, 5, 1),
                EndDate = new DateTime(2010, 5, 1),
                ProjectType = ProjectType.Professional
            };
        }

        private static IProjectModel GetAs400LongRunningJobsToMsSqlMigration()
        {
            return new ProjectModel
            {
                Description = new[] { "?" },
                Name = "Saga AS/400 Long running jobs to MS SQL",
                StartDate = new DateTime(2010, 5, 1),
                EndDate = new DateTime(2010, 5, 1),
                ProjectType = ProjectType.Professional
            };
        }

        private static IProjectModel GetDirectChoiceTheAAAuditProject()
        {
            return new ProjectModel
            {
                Description = new[] { "?" },
                Name = "Direct Choice Third Party Audit Improvements",
                StartDate = new DateTime(2010, 5, 1),
                EndDate = new DateTime(2010, 5, 1),
                ProjectType = ProjectType.Professional
            };
        }

        private static IProjectModel GetDirectChoiceSingleCustomerView()
        {
            return new ProjectModel
            {
                Description = new[] { "?" },
                Name = "Direct Choice Single Customer View",
                StartDate = new DateTime(2017, 1, 8),
                ProjectType = ProjectType.Professional
            };
        }

        private static IProjectModel GetHmtSanctionsProject()
        {
            return new ProjectModel
            {
                Description = new[] { "?" },
                Name = "HMT Sanctions Check",
                StartDate = new DateTime(2017, 1, 8),
                ProjectType = ProjectType.Professional
            };
        }

        private static IProjectModel GetTfs2010InstallationProject()
        {
            return new ProjectModel
            {
                Description = new[] { "?" },
                Name = "TFS 2010 Installation",
                StartDate = new DateTime(2017, 1, 8),
                ProjectType = ProjectType.Professional
            };
        }

        private static IProjectModel GetNegativeCommissionBrokingProject()
        {
            return new ProjectModel
            {
                Description = new[] { "?" },
                Name = "Saga Negative Commission Broking Project",
                StartDate = new DateTime(2017, 1, 8),
                ProjectType = ProjectType.Professional
            };
        }

        private static IProjectModel GetResolProcessAnalysisProject()
        {
            return new ProjectModel
            {
                Description = new[] { "?" },
                Name = "Saga Resolicitation Process",
                StartDate = new DateTime(2017, 1, 8),
                ProjectType = ProjectType.Professional
            };
        }

        private static IProjectModel GetQfinitiCallRecordingOrganisationStructureAutomationProject()
        {
            return new ProjectModel
            {
                Description = new[] { "?" },
                Name = "Qfiniti Organisation Structure and License Management Automation",
                StartDate = new DateTime(2017, 1, 8),
                ProjectType = ProjectType.Professional
            };
        }

        private static IProjectModel GetQfinitCallRecordingMetadataImplementationProject()
        {
            return new ProjectModel
            {
                Description = new[] { "?" },
                Name = "Qfiniti Call Recording Metadata Import",
                StartDate = new DateTime(2017, 1, 8),
                ProjectType = ProjectType.Personal
            };
        }

        private static IProjectModel GetGenesysSpeechAnalyticsImplementationProject()
        {
            return new ProjectModel
            {
                Description = new[] { "?" },
                Name = "Genesys Speech Miner Metadata Feed",
                StartDate = new DateTime(2017, 1, 8),
                ProjectType = ProjectType.Professional
            };
        }

        private static IProjectModel GetQfinitiCallRecordingMetadataMiddlewareImplementationProject()
        {
            return new ProjectModel
            {
                Description = new[] { "?" },
                Name = "Qfiniti Call Recording Metadata Middleware Implmentation",
                StartDate = new DateTime(2013, 10, 7),
                ProjectType = ProjectType.Professional
            };
        }

        private static IProjectModel GetNucleotideRoslynRewriteProject()
        {
            return new ProjectModel
            {
                Description = new []{ "Rewrite of my code generation library to take advantage of new Roslyn features in Visual Studio 2017" },
                Name = "Nucleotide Roslyn Rewrite",
                StartDate = new DateTime(2017, 1, 8),
                GithubRepository = new Uri("https://github.com/dpvreony/nucleotide"),
                ProjectType = ProjectType.Personal
            };
        }
    }
}
