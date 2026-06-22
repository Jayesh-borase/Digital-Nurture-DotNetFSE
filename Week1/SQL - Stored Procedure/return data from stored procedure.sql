create procedure CountEmpByDept
		@Dept_id int
	AS
	Begin

	select count(*) as TotalEmployee from Emp
	where Dept_id = @Dept_id;

	End

Exec CountEmpByDept 2;	
