
# Exercise : Create a Stored Procedure

## Scenario:
You are tasked with developing a relational database schema for managing employees and their departments in an organization. The solution should support inserting new employee records using a reusable and secure approach.

## Steps Taken:

### Database Setup and Cleanup:
To ensure a clean environment, existing tables Emp and Dept were dropped using:

### Creating the Departments Table:
The Dept table was created to hold static information about each department.

### Creating the Employees Table:
The Emp table was designed to store employee-specific information:

### Populating Initial Data:
Static data was inserted into the Dept table. Then, employee records were added to the Emp table across different departments:

### Creating Stored Procedure insert_emp:
To simplify and standardize employee insertion, a stored procedure named insert_emp was created:

### Testing the Stored Procedure:
The procedure was tested by inserting a new employee:

### Verifying the Data:
A SELECT * FROM Emp; query was executed to confirm the new entry and validate the entire setup.

## Output:
<img width="1919" height="1079" alt="Stored_Procedure" src="https://github.com/user-attachments/assets/33c86c0f-6ea5-486d-95c5-3b1bd34c2edb" />


## Conclusion:
This exercise demonstrated effective database design using normalization, foreign key constraints, and modular data operations through stored procedures. This approach improves data integrity, security, and developer productivity in enterprise applications.
