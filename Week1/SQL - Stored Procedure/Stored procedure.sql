--Department table

create table Dept(
	Dept_id int primary key,
	Dept_name varchar(50));

--Employee table
create table Emp
  (Emp_id int Primary key,
   Emp_name varchar(20),
   Dept_id int foreign key references Dept(Dept_id),
   Salary decimal(10,2)
   JoinDate date
   );


-- Stored Procedure
create procedure insert_emp
     @p_Emp_id int,
	 @p_EmpName VARCHAR(50),
     @p_DepartmentID INT,
     @p_Salary DECIMAL(10,2),
     @p_JoinDate DATE
AS
begin
 Insert into Emp (Emp_id,Emp_name,Dept_id,Salary,JoinDate) values 
                 (@p_Emp_id,@p_EmpName,@p_DepartmentID,@p_Salary,@p_JoinDate);
end

EXEC insert_emp 7,'Jayesh',2,50000,'2026-04-25';
select * from Emp;
