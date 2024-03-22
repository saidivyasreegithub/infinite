create database testdb


--creating the books and inserting the books data:
create table Books(
	ID int primary key,
	Title varchar(255),
	Isbn varchar(13) unique,
	Author varchar(100),
	Published_date DATETIME);
 
INSERT INTO Books(ID, Title,Isbn,Author,Published_date) VAlUES
(1, 'My First SQL book', '981483029127', 'Mary Parker', '2012-02-22 12:08:17'),
(2, 'My Second SQL book', '857300923713', 'John Mayer', '1972-07-03 09:22:45'),
(3, 'My Third SQL book', '523120967812', 'Cary Flint', '2015-10-18 14:05:44');
 
Select * from Books
 
--creating the reviews and data inserted:
 
Create table Reviews(
	ID int primary key,
	Book_ID int,
	Reviewer_Name varchar(100),
	Content TEXT,
	Rating int,
	Published_date DATETIME,
	Foreign key (Book_ID) REFERENCES Books(ID))
	INSERT INTO reviews (id, book_id, reviewer_name, content, rating, published_date) VALUES
(1, 1, 'John Smith', 'My first review', 4, '2017-12-10 05:50:11.1'),
(2, 2, 'John Smith', 'My second review', 5, '2017-10-13 15:05:12.6'),
(3, 2, 'Alice Walker', 'Another review', 1, '2017-10-22 23:47:10')
 
Select * from Reviews
 
--1. Write a query to fetch the details of the books written by author whose name ends with er.
select * from Books where Author like '%er'
--2.Display the Title ,Author and ReviewerName for all the books from the above table-
select b.title,b.author,r.reviewer_name from Books b join Reviews r on b.ID=r.Book_ID
--3.Display the reviewer name who reviewed more than one book.
select r.reviewer_name,count( distinct book_id) as ReviewedBooks from Books b ,Reviews r 
group by r.Reviewer_Name
having count(distinct Book_ID)>1

---creating customers and orders table and inserting data:
create table customers
(
id int primary key,
name varchar(20) not null,
age int not null,
address varchar(30) not null,
salary float not null)

insert into customers(id,name,age,address,salary) values (1,'ramesh',32,'ahmedabad',2000.00),(2,'khilan',25,'delhi',1500.00),
(3,'kaushik',23,'kota',2000.00),(4,'chaitali',25,'mumbai',6500.00),(5,'hardik',27,'bhopal',8500.00),(6,'komal',22,'mp',4500.00),
(7,'muffy',24,'indore',10000.00)
select * from customers

--4.Display the Name for the customer from above customer table who live in same address
--which has character o anywhere in address
select name from customers
where address =
				(SELECT address
				from customers
				where address LIKE '%o%'
				group by address
				having count(*) > 1)

create table orders
(
Oid int primary key,
date datetime,
customer_id int foreign key references customers(id),
amount int not null)
insert into orders(Oid, DATE, customer_id, amount) VALUES
(102, '2009-10-08', 3, 3000.00),
(100, '2009-10-08', 3, 1500.00),
(101, '2009-11-20', 2, 1560.00),
(103, '2008-05-20', 4, 2060.00);
--5.Write a query to display the Date,Total no of customer placed order on same Date
select date,customer_id as 'Total No Of Customers'  from orders  
where  date in
			(select distinct date
			from orders
			group by date
			having count(*)>1)
--------------------------------------
--creatin g employees and inserted the data:
CREATE TABLE Employee (
    ID int primary key,
    NAME varchar(255),
    AGE int,
    ADDRESS varchar(255),
    SALARY decimal(10, 2)
);
INSERT INTO Employee (ID, NAME, AGE, ADDRESS, SALARY) VALUES
(1, 'Ramesh', 32, 'Ahmedabad', 2000.00),
(2, 'Khilan', 25, 'Delhi', 1500.00),
(3, 'kaushik', 23, 'Kota', 2000.00),
(4, 'Chaitali', 25, 'Mumbai', 6500),
(5, 'Hardik', 27, 'Bhopal', 8500.00),
(6, 'Komal', 22, 'MP', Null),
(7, 'Muffy', 24, 'Indore', NULL)
 
--6.Display the Names of the Employee in lower case, whose salary is null.
Select LOWER(NAME) As name from Employee WHERE Salary is null
----------------------------------
--creating students table and inserted data:
drop table students

CREATE TABLE Students (
    Register_No int primary key,
    Name varchar(255),
    Age int,
    Qualification varchar(50),
    Mobile_No varchar(15),
    Location varchar(100),
    Gender char(1),
    Mail_id varchar(255)
)
 
INSERT INTO Students (Register_No, Name, Age, Qualification, Mobile_No, Mail_id, Location, Gender) VALUES
(2., 'Sai', 22, 'B.E', '9952836777', 'Sai@gmail.com', 'Chennai', 'M'),
(3, 'Kumar', 20, 'BSC', '7890125648', 'Kumar@gmail.com', 'Madurai', 'M'),
(4, 'Selvi', 22, 'B.Tech', '8904567342', 'selvi@gmail.com', 'Selam', 'F'),
(5, 'Nisha', 25, 'M.E', '7834672310', 'Nisha@gmail.com', 'Theni', 'F'),
(6, 'SaiSaran', 21, 'B.A', '7890345678', 'saran@gmail.com', 'Madurai', 'F'),
(7, 'Tom', 23, 'BCA', '8901234675', 'Tom@gmail.com', 'Pune', 'M')
 --7.Write a sql server query to display the Gender,Total no of male and female from the above relation
 
 select gender,count(*)
 from Students
 group by gender



