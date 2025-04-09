# Expense-Reimbursement
This repository houses an "Expense Reimbursement" Web Application with Front-End Web Interface, and a Back-End API service.

# Hours Expected/spent
- Expected Hours: 10 hours
	- .5 hours - Requirements understanding/planning
	- .5 hours - creating Git Repository
	- 1 hour - Designing PostgreSQL Database (Table Structure, Normalization, etc)
	- 1 hour - connecting PostgreSQL Database to Expense-Reimbursement Project
	- 4 hours - designing/implementing Front-End Web Interface alligning with Project Requirements
	- 3 hours - connecting Back-End API with Web Interface and PostgreSQL Database

- Hours Spent (so far): 8 hours
	- .5 hours - Requirements understanding/planning
	- .5 hours - creating Git Repository
	- 2 hours - Designing and connecting PostgreSQL Database to Expense-Reimbursement Project
   	- 5 hours - Implementing Code

# How to Run
To run this project, Clone repository, open the Visual Studio solution, and hit Run. 

# Tech Stack (Subject to change)
	- Back-End: ASP.NET Core Web API (.NET 8)
	- Front-End: Blazor
	- Database: PostgreSQL or SQL Server
	- ORM: Entity Framework Core

# Comments:
	- 1: Assumptions made during implementation
 		- I am assuming that when a "Receipt" is approved for reimbursement, the reimbursed funds will be added to the employees next paycheck (handled outside of the Expense-Reimbursement Web Application).
   		- I am assuming that the handling of submitted receipts is handled outside of this web app (handled outside of the Expense-Reimbursement Web Application).
     		- I am assuming that there are only the two hardcoded users that i have provided in my Users Table.
	- 2: Problems I came across / How I solved them
		- I ran into some issues with Blazors InteractiveServer RenderMode not working and none of my components were firing.
  			- To solve this I did some research online and found that someone had put @rendermode InteractiveServer directly in their App.razor and got InteractiveServer to work
	- 3: Highlights in my submission
 		- I was able to get a "working" solution in less time than what I had anticipated I would have.
   	- 4: Anything Else
    		- If I had some more time, I would improve the functionality including: (Adding a Register/Login so that you can create new users and login to existing users, Add a way for Admins to see and approve/reject expenses,
      		Make the page look nicer [get rid of overlapping fields], Add Form Validation and Alerts that show what needs to be fixed on the form [especially to handle invalid inputs]
