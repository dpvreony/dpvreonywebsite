using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dhgms.DPVreony.Website.Models;

namespace Dhgms.DPVreony.Website.Queries
{
    public class ExperienceQueries
    {
        public Task<IList<ExperienceModel>> GetExperienceListAsync()
        {
            return Task.FromResult(GetExperienceList());
        }

        private IList<ExperienceModel> GetExperienceList()
        {
            return new List<ExperienceModel>
            {
                new ExperienceModel
                {
                    EmployerName = "Expleo Group",
                    JobTitle = @"Lead Developer",
                    StartDate = new DateTime(2022, 06, 13),
                    Description = new []
                    {
                        "Lead Developer in .NET technologies for software development consultancy.",
                    },
                    Accomplishments = Array.Empty<string>()
                },

                new ExperienceModel
                {
                    EmployerName = "Integrated Care 24",
                    JobTitle = @"Senior Developer \ Analyst",
                    StartDate = new DateTime(2017, 10, 30),
                    EndDate = new DateTime(2022, 06, 10),
                    Description = new []
                    {
                        "Technical lead for organization, managing the development team responsible for the systems used in the provision of Urgent and Out of Hours healthcare. The role requires development in C# along with understanding the implementation of existing systems that are written in Java and Lotus Script.",
                        "My role is predominantly non coding (60-70%) for steering projects and meeting with stakeholders at regional and national level. Any coding I do is typically to flesh out a proof of concept or investigating\\supporting legacy systems to allow others to focus on their project work.",
                        "My involvement with national stakeholders can involve shaping technical and operational flows for integrations between different service providers where I have the technical knowledge combined with how things operate in Urgent care settings. The feedback can help inform and shape their road maps, especially where healthcare is moving from the XML based HL7 CDA messaging to the more agnostic (but primarily JSON) FHIR standard."
                    },
                    Accomplishments = new []
                    {
                        "Steering migration of some older platforms including IBM Domino to a more sustainable\\scalable .NET core model using SignalR, EFCore, CQRS and MassTransit with RabbitMQ that allows the core to remain platform agnostic and suitable for cloud hosting. System was set a target benchmark of sub 200ms yet achieves sub 100ms.",
                        "Analyzed and resolved issues with bottlenecks in batch auditing system that reduced it taking 30-45s to accept notifications during heavy load at weekends to all webservice calls being consistently under 3s. Identified design issue and recommended approach that will allow this to be reduced further to “normal” web service levels of approximately 200ms.",
                        "Driven stability improvements across the platform to reduce call outs to the point they are no longer weekly but can go months without escalation.",
                        "Delivered migration of web hosting to Microsoft Azure to offer better resilience than previous host and to enable future projects that can use cloud hosting and message bus systems in a cost-effective way.",
                        "Oversight of team members working on integrations with 3rd parties for providing Care Record Management and Direct Appointment Booking. Fed into national specification to close gaps and clinical\\ patient experience risks.",
                        "Mentoring team to give guidance and feedback to ideas and solutions. Try to empower them to own the development process as a team and guide them in direction of Pluralsight training or other resources that can help them better understand technologies/ patterns or problems.",
                        "Oversaw delivery of Electronic Prescribing in Urgent Care setting. Involved working with National Stakeholders on expansion of technical\\operational specifications for urgent care and hospital outpatient settings.",
                        "Introduced Technical steering group to allow Senior developers to share knowledge and design reasoning, not just with the developers involved in the projects but with other stakeholders. Forum is not limited to development projects but for any technical projects."
                    }
                },

                new ExperienceModel
                {
                    EmployerName = "Saga",
                    JobTitle = @"Senior Software Engineer \ Systems Architect, Contact Centre Technologies",
                    StartDate = new DateTime(2012, 07, 1),
                    EndDate = new DateTime(2017, 10, 23),
                    Description = new []
                    {
                        "Lead developer in a team that is responsible for the in-house CRM and DMS platforms, along with integrations into the CTI system and Customer web sites. The role requires maintenance of code in VB.NET, with newer development mostly carried out in C#. I lead and shape the projects we work on whilst also being involved in mentoring, team training and recruitment.",
                        "My work is carried out across the business group in core infrastructure projects as required, this has seen me carry out work for the insurance services, claims, holidays, legal services, finance, marketing and group level functions of the business.",
                        "I work cross team as part of the system architects’ forum to get general agreement on technologies and approaches to solutions. I also help identify risks that threaten the high availability of our platform and thus help shape improvements."
                    },
                    Accomplishments = new []
                    {
                        "Produced new Web API based services for the CRM system to allow the Customer facing websites to integrate Behavioural Targeting and for the contact centre to utilise Intelligent Call Routing. This is opening up new opportunities for marketing whilst allowing a 15 % improvement in call routing without the need for input from the customer.",
                        "Quantified and designed Document Production System that encompasses the Smart Communications (formerly Thunderhead Now) platform and provides safeguards for the existing document production practices that allows quarantining of documents for inspection. This reduces the risk of the customer receiving an email or letter with incorrect details due to an issue with a transaction system update or document template change.",
                        "Technical lead on tender process for PCI compliant payment system. Evaluated both in house and external solutions by producing prototypes and working with 3rd parties in line with the requirements gathered.",
                        "Delivered integrations with new Call Recording and Speech analytics platforms whilst producing automated processes for user management. Also improved the CRM system to better capture and match “in call” metadata.allowing better customer and agent orientated analysis to be carried out. This has helped the business target over £2m of process improvements over 2014 - 2016.",
                        "Demonstrated the ability to improve overnight processes via parallelism and asynchronous processing. This has seen some jobs running going from 1 hour to running in 25 % of the time.",
                        "Improved decoupling, scalability and resilience of systems by introducing Azure Pack Service Bus. This is also improving the SDLC by simplifying logic on the system boundaries.",
                        "Helped deliver improvements to infrastructure by demonstrating Group Policy which has persuaded the infrastructure teams to adopt it. Recently helped deliver a hardware upgrade that has seen us virtualise all of the CRM platform and reduce manual processes for the team by introducing Octopus Deploy."
                    }
                },

                new ExperienceModel
                {
                    EmployerName = "Saga",
                    JobTitle = @"Software Engineer, Customer Data",
                    StartDate = new DateTime(2010, 04, 1),
                    EndDate = new DateTime(2012, 06, 1),
                    Description = new []
                    {
                        "Sole .NET developer in team of 10 to help lead the team from AS/400 into areas of .NET and MSSQL."
                    },
                    Accomplishments = new []
                    {
                        "Produced proof of concept Single Customer View for company newly acquired by the group.Used as a demonstration of where the group AS / 400 based system could be taken.Allowed marketing campaign selections and segmentations to be run within 1 minute instead of 30 minutes.Also allowed campaigns to meet quality and compliance rules of the group.",
                        "Introduced a process to take a data file from the HM Treasury and scan the group customer systems for people who potentially had financial sanctions against them.During this project, I identified other areas of potential fraud risk to the business and raised them so processes could be put in place.",
                        "Migrated internal audit processes to the new SCV which saw them move from taking 2 hours to run a days’ worth of data being able to run a months’ worth of data within 8 minutes.",
                        "Produced logic to carry out sentiment analysis on SMS responses which helped identify implicit “STOP” requests, incorrect phone numbers on customers and issues where SMS process was taking place during unsociable hours.",
                        "Helped produce integrations between the AS/400 and MS SQL server that saw time savings on some jobs by as much as 8 hours, which allowed them to run within an overnight window."
                    }
                },

                new ExperienceModel
                {
                    EmployerName = "Hillside Holdings",
                    JobTitle = @"Administrator",
                    StartDate = new DateTime(2008, 04, 1),
                    Description = new []
                    {
                        "Non IT role, dealing with finance and purchasing for family business."
                    }
                },

                new ExperienceModel
                {
                    EmployerName = "Keep Britain Tidy",
                    JobTitle = @"Consultant (Contract)",
                    StartDate = new DateTime(2006, 1, 1),
                    EndDate = new DateTime(2009, 1, 1),
                    Description = new []
                    {
                        "Contract Role to support application development and Windows Server Infrastructure."
                    },
                    Accomplishments = new []
                    {
                        "Carried out migration of domain to Active Directory and Exchange 2003 across 4 sites. Provided training on Group Policy, Automated deployment and WSUS. Automated patching approval process through a tool I was allowed to open source.",
                        "Successfully carried out a recovery exercise on Great Plains database where backup had been failing for 2 months and data from 3 years’ prior had been deleted. Developed process to merge the data into a copy of the live database from the last backup."
                    }
                },

                new ExperienceModel
                {
                    EmployerName = "Continum",
                    JobTitle = @"Web Developer (Contract)",
                    StartDate = new DateTime(2005, 7, 1),
                    EndDate = new DateTime(2005, 9, 1),
                    Description = new []
                    {
                        "Short term contract to add multilingual capabilities to a website and its online shopping system. Worked with ASP.NET (VB), SQL Server 2000, IIS6."
                    }
                },

                new ExperienceModel
                {
                    EmployerName = "Keep Britain Tidy",
                    JobTitle = @"Database and Web Developer (Contract)",
                    StartDate = new DateTime(2005, 7, 1),
                    EndDate = new DateTime(2004, 7, 1),
                    Description = new []
                    {
                        "Contract Role primarily for migration of database backed websites from MS Access to SQL Server."
                    },
                    Accomplishments = new []
                    {
                        "Planned migration of domain to Active Directory and Exchange 2003 across 4 sites.",
                        "Acted as Web Manager for company during transitional period 08/2004 – 11/2004, representing the company to DEFRA and ODPM.",
                        "Migrated portfolio of websites from MS Access to SQL Server.",
                        "Represented company for dealings with other suppliers and contractors to ensure other projects were meeting the needs of the business.",
                        "Quantified migration from paying for dedicated hosting in MANOC to installing fibre on premise. Project broke even within 3 months and was expanded to facilitate a DR site.",
                    }
                },

                new ExperienceModel
                {
                    EmployerName = "Brook Street",
                    JobTitle = @"Temp",
                    StartDate = new DateTime(2003, 7, 1),
                    EndDate = new DateTime(2003, 9, 1),
                    Description = new []
                    {
                        "Non IT role."
                    }
                },

                new ExperienceModel
                {
                    EmployerName = "Ideas And Concepts",
                    JobTitle = @"Database and Web Developer",
                    StartDate = new DateTime(2002, 10, 1),
                    EndDate = new DateTime(2003, 7, 1),
                    Description = new []
                    {
                        "Developing web and database solutions for Ideas And Concepts projects. Providing support for technical issues, and configuration of the office network."
                    }
                },

                new ExperienceModel
                {
                    EmployerName = "Audata",
                    JobTitle = @"Junior Developer",
                    StartDate = new DateTime(2001, 4, 1),
                    EndDate = new DateTime(2002, 7, 1),
                    Description = new []
                    {
                        "Developing software solutions for clients. Day-to-Day running of the local network, providing support to colleagues and clients in the office and on client sites. I also configured systems for demonstrations of products to clients. Also provided support and training on usage of Office applications to other members of staff. Visited client sites and product launch events to provide support, liaise with potential customers and/ or develop solutions."
                    }
                }
            };
        }
    }
}
