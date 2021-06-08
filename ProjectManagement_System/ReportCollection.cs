using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement_System
{
    public static class ReportCollection
    {
        public static List<GenerateIssue> issueRepo = new List<GenerateIssue>();

        public static void AddReport(GenerateIssue generateIssue)
        {
            issueRepo.Add(generateIssue);
        }

        public static List<GenerateIssue> SearchIssue(string search)
        {
            List<GenerateIssue> result = new List<GenerateIssue>();

            foreach (var issue in issueRepo)
            {
                if (issue.tenant.phone == search)
                {
                    result.Add(issue);
                }
            }
            return result;
        }
    }
}
