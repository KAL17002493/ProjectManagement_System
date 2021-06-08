using System;
using System.Collections.Generic;

namespace ProjectManagement_System
{
	public class GenerateIssue
	{
		//public SupportStaff author;
		public string notes;
		public DateTime timeStamp;
		public List<GenerateIssue> generateIssue;
		public Guid issueId;
		public string type;
		public Tenant tenant;

		public GenerateIssue() { }

		public GenerateIssue(/*SupportStaff Author,*/ string Notes, Tenant tenant, string Type)
		{
			//this.author = Author;
			this.notes = Notes;
			this.type = Type;

			this.timeStamp = DateTime.Now;
			issueId = Guid.NewGuid();
			
			generateIssue = new List<GenerateIssue>();
		}

	}
}
