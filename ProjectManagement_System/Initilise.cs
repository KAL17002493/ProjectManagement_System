using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement_System
{
    class Initilise
    {
        public static void Init()
        {
            //Support Staff
            StaffList.AddAccount(new Account("Nigel", "West", "Nwest@projectsystem.come", "Support Staff"));
            StaffList.AddAccount(new Account("Larrey", "Drew", "Ldrew@projectsystem.come", "Support Staff"));
            StaffList.AddAccount(new Account("George", "Lewis", "GorgieLew@projectsystem.com", "Support Staff"));

            Account staff1 = new Account("Michael", "Green", "MGreen@projectsystem.com", "Support Staff");
            Account staff2 = new Account("Nora", "White", "NoraW@projectsystem.com", "Support Staff");

            StaffList.AddAccount(staff1);
            StaffList.AddAccount(staff2);

            //Maintenance Staff
            StaffList.AddAccount(new Account("George", "Drew", "Jdew@projectsystem.com", "Maintenance Staff"));
            StaffList.AddAccount(new Account("Mark", "Sew", "MarkS@prjectsystem.com", "Maintenance Staff"));

            Account staff3 = new Account("Maximilian", "Pegases", "MP@projectsystem.com", "Maintenance Staff");

            StaffList.AddAccount(staff3);

            //Manager Staff
            StaffList.AddAccount(new Account("Big", "Rich", "IManagerEverything@gmail.com", "Manager")); 

            //Tenant
            Tenant tenant1 = new Tenant("Mike", "Green", "Bearlover29@bear.com", "987654321");
            Tenant tenant2 = new Tenant("Josh", "Large", "Joshue23429@gmail.com", "123456789");

            TenantList.AddTenant(tenant1);
            TenantList.AddTenant(tenant2);

            //Report
            GenerateIssue issue1 = new GenerateIssue("White wall it back, wish for it be to repainted", tenant1, "Comercial");
            GenerateIssue issue2 = new GenerateIssue("Somebody removed my window dureing the night, I would like for it to be replaced", tenant2, "Residential");

            ReportCollection.AddReport(issue1);
            ReportCollection.AddReport(issue2);
            //RecordIssue.AddIssue(issue2);


            //Update Report
            /*Update issue3 = new Update(staff1, "Paint pealing off of a wall");

            issue3.comment.Add(new Comment(staff1, "Maintenance worker has been sent out to inspect the issue"));
            issue3.comment.Add(new Comment(staff3, "Issue has been inspected, wall will be painted by the end of the week"));

                //Original issue
                Console.WriteLine($"Author: {issue3.author.name}\n\nIssue:  {issue3.update}\nDate: {issue3.timeStamp}");

                //Comments
                foreach (Comment comment in issue3.comment)
                {
                    Console.WriteLine($"\n---------------Post: {comment.comment}\n\n               Author: {comment.author.name}\n               Poster: {comment.timeStamp}");
                }*/
        }
    }
}
