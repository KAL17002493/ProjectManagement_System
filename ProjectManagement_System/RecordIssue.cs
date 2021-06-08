using System;
using System.Collections.Generic;

namespace ProjectManagement_System
{
	public class RecordIssue
	{
		public Account author;
		public string notes;
		public DateTime timeStamp;
		//public List<Update> update;
		//public Status status;
		public Guid issueId;
		public Tenant tenant;

		public RecordIssue() { }

		public RecordIssue(Account Author, string Notes)
		{
			this.author = Author;
			this.notes = Notes;
			this.timeStamp = DateTime.Now;
			//update = new List<Update>();
			//this.status = Status.ToBeInspected;
			issueId = Guid.NewGuid();
		}
	}
}
