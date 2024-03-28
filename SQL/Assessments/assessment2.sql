use testdb
create table tblDEPT
(
deptno int primary key,
dname  varchar(20),
loc varchar(20)
) 
---Inserting Departments Details
insert into tblDEPT(deptno,dname,loc) values (10,'ACCOUNTING','NEW YORK' ),(20,'RESEARCH','DALLAS'),(30,'SALES','CHICAGO'),(40,'OPERATION','BOSTON')

--Creating Employees table
create table tblEMP
(
empno  int primary key, 
ename varchar(20), 
job varchar(20),
mgr_id int, 
hiredate Date,
sal float,
comm int,
deptno int foreign key references tblDEPT(deptno)
)
---Inserting Employees Details
insert into tblEMP(empno,ename,job,mgr_id,hiredate,sal,comm,deptno) values (7369,'SMITH','CLERK',7902,'17-DEC-80',800,null,20),
(7499,'ALLEN','SALESMAN',7698,'20-FEB-81',1600,300,30),(7521,'WARD','SALESMAN',7698,'22-FEB-81',1250,500,30),(7566,'JONES','MANAGER',7839,'02-APR-81',2975,null,20),
(7654,'MARTIN','SALESMAN',7698,'28-SEP-81',1250,1400,30),(7698,'BLAKE','MANAGER',7839,'01-MAY-81',2850,null,30),(7782,'CLARK','MANAGER',7839,'09-JUN-81',2450,null,10),
(7788,'SCOTT','ANALYST',7566,'19-APR-87',3000,null,20),(7839,'KING','PRESIDENT',null,'17-NOV-81',5000,null,10),(7844,'TURNER','SALESMAN',7698,'08-SEP-81',1500,0,30),
(7876,'ADAMS','CLERK',7788,'23-MAY-87',1100,null,20),(7900,'JAMES','CLERK',7698,'03-DEC-81',950,null,30),(7902,'FORD','ANALYST',7566,'03-DEC-81',3000,null,20),
(7934,'MILLER','CLERK',7782,'23-JAN-82',1300,null,10)
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--1.	Write a query to display your birthday( day of week)
select datename(weekday, '2001-08-08') as Birthday_Day_of_Week
--output:
--Birthday_Day_of_Week
--Wednesday
------------------------------------------------------------------------------------------------------------------------------------------
--2.Write a query to display your age in days
 select DATEDIFF(day, '2001-08-08', cast(GETDATE() as date)) as Age_In_Days
 --output:
 --Completed Age
 --8268

 ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- 3.	Write a query to display all employees information those who joined before 5 years in the current month
 
--(Hint : If required update some HireDates in your EMP table of the assignment)

 -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- 4.	Create table Employee with empno, ename, sal, doj columns and perform the following operations in a single transaction
--	a. First insert 3 rows 
--	b. Update the second row sal with 15% increment  
--  c. Delete first row.
--After completing above all actions how to recall the deleted row without losing increment of second row.
-- Create stored procedure to perform operations
create table Employees
(
    empno int primary key,
    ename varchar(50),
    sal float,
    doj DATE
)
drop table Employees

CREATE or alter proc operation
as
begin
	set nocount on
	begin transaction
    
    -- a. Insert 3 rows
    insert INTO Employees(empno, ename, sal, doj)
    values (110, 'divya', 4500.00, '2020-03-09'),
           (111, 'haritha', 2500.00, '2019-07-27'),
           (112, 'Ramalakshmi', 5500.00, '2010-08-08');

    -- b. Update the second row sal with 15% increment
	
    UPDATE Employees
    set sal = sal * 15/100
    where empno = 111

    -- c. Delete first row
    delete  from Employees
    where empno =110 

    -- Commit the transaction
	commit transaction

	select * from Employees
end   
-- Create stored procedure to recall deleted row
create or alter proc deletedRow
as
begin
	set nocount on
	begin transaction
    insert into Employees(empno, ename, sal, doj)
    select  empno, ename, sal, doj
    from Employees
    where empno = 110

    -- Commit the transaction to recall the deleted row
    commit transaction
	select * from Employees
END

--execution of stored procedure
exec operation
exec deletedRow
--output:
--empno ename       sal         doj
--111	haritha		375			2019-07-27
--112	Ramalakshmi	5500		2010-08-08



 -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--5. Create a user defined function calculate Bonus for all employees of a  given job using 	following conditions
--	a. For Deptno 10 employees 15% of sal as bonus.
--	b. For Deptno 20 employees  20% of sal as bonus
--	c. For Others employees 5%of sal as bonus

create or alter FUNCTION CalculateBonus (@job VARCHAR(50))
returns int
as
begin
    declare @bonus int

    select  @bonus = 
        case
            when e.deptno = 10 then e.sal * 0.15
            when e.deptno = 20 then e.sal * 0.20
            else  e.sal * 0.05
        end
    from tblEMP e
    where e.job = @job;

    return @bonus;
end
--execution  function
select empno, ename, job, sal, dbo.CalculateBonus(job) AS bonus
FROM tblEMP

--output:
--empno  ename   job       sal     bonus
--7369 SMITH	CLERK	    800	   160
--7499	ALLEN	SALESMAN	1600	80
--7521	WARD	SALESMAN	1250	80
--7566	JONES	MANAGER	    2975   595
--7654	MARTIN	SALESMAN	1250	80
--7698	BLAKE	MANAGER	    2850    595
--7782	CLARK	MANAGER	    2450	595
--7788	SCOTT	ANALYST	   3000	    600
--7839	KING	PRESIDENT	5000	750
--7844	TURNER	SALESMAN	1500	80
--7876	ADAMS	CLERK		1100	160
--7900	JAMES	CLERK		950	    160
--7902	FORD	ANALYST		3000	600
--7934	MILLER	CLERK		1300	160

