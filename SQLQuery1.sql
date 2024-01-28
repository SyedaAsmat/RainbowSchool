create database RainbowSchoolsDb;

create table Classes (
 ClassId int primary key,
 ClassName varchar(20)
);

create table Subjects (
 SubjectId int primary key,
 SubjectName varchar(20)
);create table Students (
 StudentId int primary key,
 FirstName varchar(20),
 LastName varchar(20),
 ClassId int,
);insert into Classes (ClassId, ClassName) values
(1, '10-A'),
(2, '10-B'),
(3, '10-C'),
(4, '10-D');

Select * from Classes;

insert into Subjects (SubjectId, SubjectName) values
(101, 'Math'),
(102, 'Science'),
(103, 'English'),
(104, 'Hindi'),
(105, 'Art');

Select * from Subjects;

insert into Students (StudentId, FirstName, LastName, ClassId) values
(1, 'Asha', 'Gupta', 1),
(2, 'Zehra', 'Zaidi', 3),
(3, 'Jasmine', 'Singh', 4),
(4, 'Melissa', 'Cooper', 2),
(5, 'Sameen','Naqvi',4),
(6, 'Anika','Oberoi',1),
(7, 'Astha','Singh',3),
(8, 'Dipika','Chopra',2);

select * from Students;

create index class_index on Classes (ClassName);

create index subject_index on Subjects (SubjectName);

create unique index student_index on Students (FirstName, LastName);

exec sp_helpindex Classes;

exec sp_helpindex Subjects;

exec sp_helpindex Students;