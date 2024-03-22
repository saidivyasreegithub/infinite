use AssignmentDb
--1. Retrieve a list of MANAGERS. 
select * from tblEMP where job='manager'

--2. Find out the names and salaries of all employees earning more than 1000 per 
--month. 
select ename,sal from tblEMP where sal>1000


--3. Display the names and salaries of all employees except JAMES. 
select ename,sal from tblEmp where ename!='james'

--4. Find out the details of employees whose names begin with ‘S’. 
select * from tblEMP where ename like 's%'


--5. Find out the names of all employees that have ‘A’ anywhere in their name. 
select ename from tblEMP where ename like '%a%'


--6. Find out the names of all employees that have ‘L’ as their third character in 
--their name. 
select ename from tblEMP where ename like '__l%'


--7. Compute daily salary of JONES. 
select empno,ename,sal,(sal/30) as DailySalary from tblEMP where ename ='jones'


--8. Calculate the total monthly salary of all employees. 
WITH EMPDETAILS AS(
SELECT * FROM tblEMP )
SELECT ENAME, SAL/30 AS TOTAL_MONTSAL FROM EMPDETAILS
 
--9. Print the average annual salary . 
WITH EDETAILS AS(
SELECT * FROM tblEMP)
SELECT AVG(SAL) AS AVERAGE_SAL FROM EDETAILS;



--10. Select the name, job, salary, department number of all employees except 
--SALESMAN from department number 30. 
select ename,job,sal,deptno from tblEMP where job!='salesman' and deptno!=30


--11. List unique departments of the EMP table. 
select distinct deptno from tblEMP

--12. List the name and salary of employees who earn more than 1500 and are in department 10 or 30. 
--Label the columns Employee and Monthly Salary respectively.
select ename Employee ,sal  MonthlySalary from tblEMP where sal >1500 and deptno in(10,30) 

select * from tblEMP
--13. Display the name, job, and salary of all the employees whose job is MANAGER or 
--ANALYST and their salary is not equal to 1000, 3000, or 5000.
select ename,job,sal from tblEMP where job in ('manager','analyst') and sal not in (1000,3000,5000)

--14. Display the name, salary and commission for all employees whose commission 
--amount is greater than their salary increased by 10%. 
select ename,sal,comm from tblEMP where comm > (sal*1.1) 


--15. Display the name of all employees who have two Ls in their name and are in 
--department 30 or their manager is 7782. 
select * from tblEMP where ename like '%ll%' and deptno=30 and mgr_id=7782


--16. Display the names of employees with experience of over 30 years and under 40 yrs.
-- Count the total number of employees. 
select ename,count(*) as TotalEmployees from tblEMP 
where DATEDIFF(year,hiredate,getdate()) between 31 and 39 
group by ename



--17. Retrieve the names of departments in ascending order and their employees in 
--descending order. 
select e.*,d.* from tblEMP e join tblDEPT d on e.deptno=d.deptno order by dname ,ename desc


--18. Find out experience of MILLER. 
select DATEDIFF(year,hiredate,getdate()) Experience
from tblEMP where ename='miller'


