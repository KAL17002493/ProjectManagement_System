using System;
using System.Collections.Generic;

namespace ProjectManagement_System
{
	public static class SearchIssue
	{
		public static List<RecordIssue> SearchList = new List<RecordIssue>();

		public static void AddIssue(RecordIssue recordIssue)
		{
			SearchList.Add(recordIssue);
		}

		public static List<RecordIssue> IssueSearch (string search)
		{
			List<RecordIssue> result = new List<RecordIssue>();

			foreach (var recordIssue in SearchList)
			{
				if (recordIssue.tenant.phone == search)
				{
					result.Add(recordIssue);
				}
			}
			return result;
		}
	}
}
