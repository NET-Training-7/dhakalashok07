-- Create new table
create table Student
(
	Id int identity primary key,
	Name varchar(100),
	Contact varchar(100),
	Major varchar(100),
	DOB datetime2,
	Semester varchar(5)
);

-- Get data
select * from Student
select Name, Contact from Student where Id=1

-- Insert data
insert into Student
values ('Ashok Dhakal', '9863799528', 'Science', '2003/03/14', 'I');

-- update table
update Student
set Major='Arts'
where Id=2

delete from Student
where Id=3
-- CLASSWORK
-- Create a table called "Teacher" with at least 5 columns 
-- and insert data for 5 teachers in there

create table Teacher
(
	Id int identity primary key,
	Name nvarchar(50),
	Contact varchar(100),
	Department varchar(50),
	Salary decimal
);

Insert into Teacher
values 
('Ram Khatri', '987654322', 'Mathematics' ,500000),
('Sunil Gautam', '9866654322', 'English' ,400000),
('Nirmal Pandey', '988852365', 'Science' ,300000),
('Sarita Acharya', '9555654322', 'History' ,550000),
('Ram Ji Acharya', '8887654322', 'Mathematics',45000);

select * from Teacher order by Salary desc

select Department, count(*) as TeacherCount from Teacher
group by Department

--drop table Teacher2