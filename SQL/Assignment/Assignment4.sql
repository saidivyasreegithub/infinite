--1.	Write a T-SQL Program to find the factorial of a given number.
begin
declare @fact int=1,@n int =5
	if(@n<=1)
	begin 
		set @fact=1
	end
	else
	begin
	  declare @count int =1
	  while @count <=@n
		begin
		  set @fact=@fact*@count
		  set @count=@count+1
		end
	end
end
select @fact as 'Factorial'
--2.	Create a stored procedure to generate multiplication tables up to a given number.
create or alter proc generateMultiplication @n int
as 
begin 
	declare @i int =1
	if @i<=@n
	begin
		declare @count int =1
		while @count<=10
		begin
		 declare @result int =@n*@count
		 print cast(@n as varchar(10)) +'*'+cast(@count as varchar(10))+'='+ cast(@result as varchar(10))
		 set @count=@count+1
		 end
	end
	else
	print 'The multiplication of the table is not generated'
end
--execution of table:
exec  generateMultiplication @n=10      
--3.  Create a trigger to restrict data manipulation on EMP table during General holidays. Display the error message like “Due to Independence day you cannot manipulate data” or "Due To Diwali", you cannot manupulate" etc

--Note: Create holiday table as (holiday_date,Holiday_name) store at least 4 holiday details. try to match and stop manipulation 
create table holiday
(
holiday_date date primary key,
holiday_name varchar(20) 
)
insert into holiday(holiday_date,holiday_name) values ('2024-08-15','Independence day'),
('2024-12-25','Christmas'),('2025-01-01','New Year'),('2025-01-26','Republic Day'),('2024-03-25','Holi')
select * from holiday
CREATE OR ALTER TRIGGER trg_check_holidays
ON tblEMP
FOR INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @holiday_count INT;

    -- Check if the current date is a holiday
    SELECT @holiday_count = COUNT(*)
    FROM holiday
    WHERE holiday_date = CONVERT(DATE, GETDATE());

    -- If current date is a holiday, raise an error and rollback the transaction
    IF @holiday_count > 0
    BEGIN
        DECLARE @holiday_name VARCHAR(100);

        SELECT @holiday_name = holiday_name
        FROM holiday
        WHERE holiday_date = CONVERT(DATE, GETDATE());

        RAISERROR('Due to %s, you cannot manipulate data.', 16, 1, @holiday_name);
        ROLLBACK TRANSACTION;
    END
END
 select *  from tblEMP
 insert into tblEMP values(8900,'divya','clerk',7839,'2020-08-08',3500,null,10)
 delete from  tblEMP where empno=8900


