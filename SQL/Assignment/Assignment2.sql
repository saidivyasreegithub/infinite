drop table tblEMP
drop table tblDEPT


--Creating Department details
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

---Query Questions and Answers:

--1. List all employees whose name begins with 'A'. 
select * from tblEMP where ename like 'A%'



--2. Select all those employees who don't have a manager. 
select * from tblEMP where mgr_id is null


--3. List employee name, number and salary for those employees who earn in the range 1200 to 1400. 
select empno,ename,sal from tblEMP where sal between 1200 and 1400



--4. Give all the employees in the RESEARCH department a 10% pay rise. Verify that this has been done by listing all their details before and after the rise. 
--Before the Pay rise 
select *
from tblEMP where deptno =(select deptno from tblDEPT where dname ='research')

--- 10% pay rise
update tblEMP
set sal=(sal*1.1) 
 where deptno = (select deptno from tblDEPT where dname ='research')


--After the Payrise
select *
from tblEMP where deptno =(select deptno from tblDEPT where dname ='research')


--5. Find the number of CLERKS employed. Give it a descriptive heading. 
select count(*) from tblEMP where job='clerk'



--6. Find the average salary for each job type and the number of people employed in each job. 
select job,avg(sal),count(sal) from tblEMP group by job


--7. List the employees with the lowest and highest salary. 
---for minimum salary
select * from tblEMP 
where sal =
		(select min(sal) from tblEMP )
--for  maximum salary
select *
from tblEMP where sal =(select max(sal)
						from tblEMP)


--8. List full details of departments that don't have any employees. 
select D.*
from tblDEPT D
left join  tblEMP E ON D.deptno = E.deptno
where E.deptno IS NULL;


--9. Get the names and salaries of all the analysts earning more than 1200 who are based in department 20. 
--Sort the answer by ascending order of name.
select ename,sal from tblEMP 
where job = 'analyst' and sal >1200 and deptno = 20
order by ename

--10. For each department, list its name and number together with the total salary paid to employees in that department. 
select deptno,sum(sal) TotalSalary
from tblEMP
group by deptno

--11. Find out salary of both MILLER and SMITH.
select sal from tblEMP where ename in('miller','smith')



--12. Find out the names of the employees whose name begin with ‘A’ or ‘M’.
select ename from tblEMP where ename like 'A%' or  ename like 'M%'



--13. Compute yearly salary of SMITH. 
select sal*12 'Yearly salary' from tblEMP where ename = 'smith'



--14. List the name and salary for all employees whose salary is not in the range of 1500 and 2850. 
select ename,sal from tblEMP where sal not between 1500 and 2850



--15. Find all managers who have more than 2 employees reporting to them
select m.ename  from tblEMP m where m.empno in 
										(select e.mgr_id from tblEMP E  
										group by e.mgr_id 
										having  count(*)>2)
				

