use AssignmentDb
--1. Write a T-Sql based procedure to generate complete payslip of a given employee with respect to the following condition

  -- a) HRA as 10% of Salary
   --b) DA as 20% of Salary
   --c) PF as 8% of Salary
   --d) IT as 5% of Salary
   --e) Deductions as sum of PF and IT
   --f) Gross Salary as sum of Salary,HRA,DA
   --g) Net Salary as Gross Salary - Deductions

create or alter proc getPayslips @empname varchar(20)
as
begin
	declare @HRA int,@DA int,@PF int,@IT int,@salary int
	select @salary=sal from tblEMP where @empname=ename


	--calculating the HRA,DA,PF,IT
	set @HRA=@salary*0.1 --HRA 
	set @DA=@salary*0.2
	set @PF=@salary*8/100
	set @IT=@salary*5/100
	--to calculate deductions,gross salary and net salary so, declare the variables
	declare @Deduction int ,@GrossSalary int ,@NetSalary int

	-- Deductions as sum of PF and IT
	set @Deduction=@PF+@IT

	--Gross Salary as sum of Salary,HRA,DA
	set @GrossSalary=@salary+@HRA+@DA
	
	--Net Salary as Gross Salary - Deductions
	set @NetSalary=@GrossSalary-@Deduction

	--displaying the  payslips data:
	
	Print 'Employee Name: ' + cast(@Empname as varchar(10))
    Print 'Salary: ' + cast(@Salary as varchar(20))
    Print 'HRA: ' + cast(@HRA as varchar(20))
    Print 'DA: ' + cast(@DA as varchar(20))
    Print 'PF: ' + cast(@PF as varchar(20))
    Print 'IT: ' + CAST(@IT as varchar(20))
    Print 'Deductions: ' + cast(@Deduction as varchar(20))
    Print 'Gross Salary: ' + cast(@GrossSalary as varchar(20))
    Print 'Net Salary: ' + cast(@NetSalary as varchar(20))
end

--execution:
getPayslips @empname='smith'


