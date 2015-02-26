using System.Collections.Generic;
using Duty = System.String;
using skill = System.String;

class MyResume
{
    static void Main()
    {
        var resume = new Resume();

        resume.Title = "Senior .NET Developer";

        resume.ContactInfo = new ContactInfo()
        {
                Name = "Eldie Turner",
                Phone = "440.678.8268",
                Email = "Eldie.Turner@live.com",
                Website = "http://EldieTurner.com",
                LinkedIn = "https://www.linkedin.com/in/eldieturner",
                Twitter = "https://twitter.com/eldieturner" //I don't really tweet
        };

        resume.WorkExperiences = new List<WorkExperience>()
        {
            new WorkExperience()
            {
                CompanName = "Onosys (a LivingSocial Company)",
                From = "06/2014", To = "Present",
                Title = "Senior .NET Developer",
                Duties = new List<Duty>()
                {
                    "• Perform bug fixes for existing applications (MVC, and Web API)",
                    "• Help create new features for existing applications",
                    "• Write and update unit tests",
                    "• Perform front end work for product, using html5, css3, JQuery and AngularJS",
                    "• Work with data in SQL Server 2012/1014 as well as RavenDB and MongoDB"
                }
            },

            new WorkExperience()
            {
                CompanName = "The Cleveland Clinic",
                From = "03/2013", To = "06/2014",
                Title = "Web Development Manager",
                Duties = new List<Duty>()
                {
                    "• Design Databases within SQL Server 2008R2/2012",
                    "• Design new .NET applications with frameworks (4.5 and 4.5.1)",
                    "• Build new applications with C# and MVC 4/5",
                    "• Use Entity Framework 5/6 with both Database First and Code First",
                    "• Use JQuery and WCF services to create responsive, light weight web applications.",
                    "• Design secure login process (password management, password reset loop)",
                    "• Design auditing system for login, data changes, and data view",
                    "• Mentor junior developers",
                    "• Implement (Test Driven Design) TDD and Unit Tests where appropriate"
                }
            },

            new WorkExperience()
            {
                CompanName = "SummaCare",
                ContratingCompany = "Randstad Technologies",
                From = "09/2012", To = "03/2013",
                Title = "Senior .NET Developer",
                Duties = new List<Duty>()
                {
                    "• Modify existing .NET4.0  applications",
                    "• Work with SQL Server 2008R2 and Oracle databases",
                    "• Modify SSIS packages",
                    "• Modify stored procedures",
                    "• Work with project managers to determine requirements and timeline",
                    "• Write turnover documents and update BA specs for programs",
                    "• Do 100% of application testing"
                }
            },

            new WorkExperience()
            {
                CompanName = "Westfield Insurance",
                ContratingCompany = "TekSystems",
                From = "02/2012", To = "08/2012",
                Title = "Test Automation Specialist",
                Duties = new List<Duty>()
                {
                    "• Develop an ASP.NET application for internal use",
                    "• Utilize Jquery, AJAX.NET, and Entity Framework in new application",
                    "• Worked in an AGILE environment",
                    "• Responsible for application through entire SDLC",
                    "• Design SQL Server Database",
                    "• SQL Server Administrator",
                    "• IIS 7 Administrator",
                    "• Windows Server 2008R2 Administrator"
                }
            },

            new WorkExperience()
            {
                CompanName = "NASA (National Aeronautics and Space Administration)",
                ContratingCompany = "ASRC (Arctic Slope Regional Corporation)",
                From = "08/2006", To = "02/2012",
                Title = "Program Analyst IV",
                Duties = new List<Duty>()
                {
                    "• Lead Programmer on 2 contract management applications (ASP.NET)",
                    "• Maintain several ASP.NET (C# and VB) applications using Visual Studio (2003,2008 and 2010)",
                    "• Wrote and consumed WCF (Windows Communication Foundation) services",
                    "• Worked in an AGILE environment",
                    "• Responsible for applications through entire SDLC",
                    "• Develop .NET applications on top of Sharepoint 2008",
                    "• Attend requirements meetings for multiple applications",
                    "• Helped to design application look and features, including page layout, workflow, and database strictures",
                    "• Write SQL statements for getting data into and out of the database",
                    "• Create custom data objects with ADO.NET for both Access and SQL Server",
                    "• Write test plans for QA department to do testing",
                    "• Do black box testing for application changes",
                    "• Web Administrator on 3 Windows 2003/2008-R2 Web Servers (IIS 6 and IIS7)",
                    "• Server Administrator on 2 Windows 2003/2008-R2 File Servers",
                    "• Server admin on MS SQL Server 2008",
                    "• Assisted with IT security plans, and implemented harder security in applications and on servers",
                    "• Help create and implement disaster recovery plans"
                }
            },
        };

        resume.TechnicalSkills  = new List<skill>()
        {
            "dot net framework 1.1 - 4.5.2", "asp.net mvc", ".net Web api", "c#",
            "object oriented programming (oop)", "design patterns", "functional programming",
            "mongoDB", "ravenDB", "Microsoft SQL Server 2005-2012", "T-SQL", "stored procedures", "ssis",
            "javascript", "jquery", "knockout", "angularjs", "css", "html5"
        };

        resume.Education = new List<Degree>()
        {
            new Degree()
            {
                School = "Lakeland Community College",
                Type = "Associate of Art",
                Year = "2001"
            }
        };
        resume.Close();
    }
}
