using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement_System
{
	public static class CLI
	{
		public static void Login()
		{
			//Requests Login name
			Console.WriteLine("Enter user name");
			//Assigns entered ID to "accID"
			string accID = Console.ReadLine();

			//Requests password
			Console.WriteLine("\nEnter Password");
			//Assigns entered password to "password"
			string password = Console.ReadLine();

			//Verifies the entered account ID
			Account account = StaffList.ReturnAccount(accID);

			//Checks if window is filled and details have been entered
			if (account != null && Authenticator.Authenticate(account, password))
			{
				//if details match outputs this
				Console.WriteLine("\n-----------------------------------\nAccount verified\n-----------------------------------\n");
				Console.WriteLine($"Role: {account.role}\nName: {account.name}");
				if (account.role == "Support Staff")
				{
					SupportAccount();
				}
				else
				{
					MaintenanceAccount();
				}
			}
			else
			{
				//if details do not match outputs this
				Console.WriteLine("Invalid Login details\n");
			}
		}

		//Support staff menu
		public static void SupportAccount()
		{
			Console.WriteLine("===================================\n1: Create a new report\n2: Search for an existing report\n3: Exit\n===================================");
			string choice = Console.ReadLine();

			switch (choice)
			{
				case "1":
					//Create a report
					CreateReport();
					break;
				case "2":
					//Search a report
					SearchReport();
					break;
				case "3":
					//Exit
					Exit();
					break;
				default:
					Console.WriteLine("\nInput not recognised - please try again");
					break;
			}
		}

		//Maintenance Staff
		public static void MaintenanceAccount()
		{
			Console.WriteLine("===================================\n1: Search for an existing report\n2: Exit\n===================================");
			string choice = Console.ReadLine();

			switch (choice)
			{
				case "1":
					//Search a report
					SearchReport();
					break;
				case "2":
					//Exit
					Exit();
					break;
				default:
					Console.WriteLine("\nInput not recognised - please try again");
					break;
			}
		}

		public static void ManagerAccount()
		{
			Console.WriteLine("===================================\n1: Search for an existing report\n2: Exit\n===================================");
			string choice = Console.ReadLine();

			switch (choice)
			{
				case "1":
					//Search a report
					SearchReport();
					break;
				case "2":
					//Exit
					Exit();
					break;
				default:
					Console.WriteLine("\nInput not recognised - please try again");
					break;
			}
		}

		private static void CreateReport()
		{
			//Write a new repoty
			Console.WriteLine("\nWrite report");
			string text = Console.ReadLine();

			List<string> Notes = new List<string>();

			//Adds the new report to a List
			Notes.Add(text);

			//Request's Tenant's contact number
			Console.WriteLine("\nTenant's contact number");
			string phone = Console.ReadLine();

			if (phone.Length < 11)
			{
				Console.WriteLine("Contact number is too short, must contain 11 numbers");
			}
			else if (phone.Length > 11)
			{
				Console.WriteLine("Contact number is too long, must contain 11 numbers");
			}
			else
			{
				Console.WriteLine("===================================\nTenant's first name:");
				string fname = Console.ReadLine();

				Console.WriteLine("\nEnter tenant's last name:");
				string lname = Console.ReadLine();

				Console.WriteLine("\nEnter tenant's email:");
				string email = Console.ReadLine();

				Console.WriteLine("\nType of proportie:");
				string type = Console.ReadLine();

				GenerateIssue test3 = new GenerateIssue(text, new Tenant(fname, lname, email, phone), type);

				//Outputs the details entered by the staff
				Console.WriteLine($"===================================\nTenant's name: {fname} {lname}\nTenant's email: {email}\nTenant's contact number: {phone}\n-----------------------------------");

				Console.WriteLine($"\nNotes: {test3.notes}\n\nTime: {test3.timeStamp}\nType: {test3.type}\nReport ID: {test3.issueId}");

				//This does not actually work it is just here to make me feel better at the time of writing this
				Tenant tenant3 = new Tenant(fname, lname, email, phone);
				//this part does work I think (adds new tenant to the list of tenants with issues)
				TenantList.AddTenant(tenant3);
				ReportCollection.AddReport(test3);

				Console.WriteLine("===================================\n1: Return\n2: Logout\n3: Exit\n===================================");
				string choice = Console.ReadLine();

				switch (choice)
				{
					case "1":
						//Back to staff options
						SupportAccount();
						break;
					case "2":
						//Logout
						Login();
						break;
					case "3":
						//Exit
						Exit();
						break;
					default:
						Console.WriteLine("\nInput not recognised - please try again");
						break;
				}
			}
		}

		//Search for a pre existing report
		private static void SearchReport()
		{
			//Search function
			Console.WriteLine("Enter tenant's contact number");
			string search = Console.ReadLine();
			var result = TenantList.SearchTenant(search);
			var reportResult = ReportCollection.SearchIssue(search);

			//Ff phone matches to a phone in the system outputs this
			if (result.Count != 0 && result.Count != 0)
			{
				//Output tenant's details
				foreach (Tenant item in result)
				{
					Console.WriteLine($"===================================\nTenant's name: {item.fname} {item.lname}\nTenant's email: {item.email}\nTenant's contact number: {item.phone}\n-----------------------------------\n");
				}
				//Output's report details
				foreach (GenerateIssue item in reportResult)
				{
					Console.WriteLine($"Notes: {item.notes}\n\nDate: {item.timeStamp}\nType: {item.type}\nId: {item.issueId}\n===================================");
				}
				Console.WriteLine("1: Update report\n2: Exit\n===================================");
				string choice = Console.ReadLine();

				switch (choice)
				{
					case "1":
						//Update Report
						UpdateReport();
						break;
					case "2":
						//Exit
						Exit();
						break;
					default:
						Console.WriteLine("\nInput not recognised - please try again");
						break;
				}
			}
			//If matching phone not found outputs this
			else
			{
				Console.WriteLine("Record by this contact number not found");
			}
		}

		//Update pre existing report
		private static void UpdateReport()
		{
			Console.WriteLine("Write update");
			string text = Console.ReadLine();

			//Update issue = new Update(staffName);

			Console.WriteLine("===================================\n1: Return\n2: Logout\n3: Exit\n===================================");
			string choice = Console.ReadLine();

			switch (choice)
			{
				case "1":
					//Back to staff options
					SearchReport();
					break;
				case "2":
					//Logout
					Login();
					break;
				case "3":
					//Exit
					Exit();
					break;
				default:
					Console.WriteLine("\nInput not recognised - please try again");
					break;
			}
		}

		private static void Exit()
		{
			Environment.Exit(0);
		}
	}
}
