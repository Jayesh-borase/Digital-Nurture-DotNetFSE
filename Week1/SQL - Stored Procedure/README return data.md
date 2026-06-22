# Exercise 4: Creating a Stored Procedure to Count Employees by Department

 cenario: In a company database, management requires a quick way to view the number of employees in each department for workforce analysis and planning. Rather than manually writing SELECT COUNT(*) queries, a stored procedure is designed to automate this task for any department as needed.

## Steps Taken: Setup and Cleanup: 

To avoid conflicts, any existing version of the procedure was dropped:

Procedure Definition with Parameters: A stored procedure named sp_CountEmployeesByDepartment was created.

Using the Procedure: The procedure was called using: EXEC sp_CountEmployeesByDepartment 2; This returns the total number of employees in DepartmentID 2 (e.g., Finance).

You can easily reuse the same procedure with any department by replacing the argument.

## Output:
<img width="1918" height="1064" alt="return data from procedure" src="https://github.com/user-attachments/assets/c5eeeb6a-3705-494a-82f5-7286f217249e" />


## Conclusion:
This stored procedure simplifies HR reporting by providing a reusable, centralized way to count employees by department. It enhances productivity, reduces manual query errors, and makes it easier for non-technical users or applications to retrieve key metrics with a simple procedure call.
