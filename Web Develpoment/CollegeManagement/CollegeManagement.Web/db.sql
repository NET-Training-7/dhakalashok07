create table Student
(
  Id int identity primary  key,
  Name nvarchar(100),
  Contact varchar(100),
  Major varchar(100),
  Dob datetime2,
  Semester varchar(5)
);

--Get data
select * from Student

select Name, Contact from Student where Id=1

--Insert data
insert into Student 
values('Roshan Twayana', '9867234521', 'Science', '1995/12/12', 'VI');


--Update 
update Student
set Major='Arts'
where Id = 2

delete from Student
where Id=5

--Classwork 
--Create a table called "Teacher" with at least 5 columns

create table Teacher
(
Id int identity primary key, 
Name varchar(50),
Contact varchar(100),
Department varchar(50),
Salary decimal
);

Select*from Teacher order by Salary desc

--Insert data for 5 teahers in there
insert into Teacher
values
('Leo Messi', '987654322', 'Mathematics' ,500000),
('Ronaldo', '9866654322', 'English' ,400000),
('Di Maria', '988852365', 'Science' ,300000),
('Lewandoski', '9555654322', 'History' ,550000),
('kaka', '8887654322', 'Mathematics',45000);

select Department,count(*) as TeacherCount from Teacher
group by Department