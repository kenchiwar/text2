USE MASTER 
GO
DROP DATABASE IF EXISTS SinhVien
CREATE DATABASE SinhVien
GO
USE SinhVien
GO
DROP TABLE IF EXISTS TblStudent 
CREATE TABLE TblStudent
(
StuId int identity primary key ,
StuPass NVARCHAR(50),
StuAdress NVARCHAR(50),
StuPhone NVARCHAR(50),
StuEmail NVARCHAR(50),
StuName NVARCHAR(50),
deptId int ,
)
GO
DROP TABLE IF EXISTS TblExam 
CREATE TABLE TblExam (
ExamId int identity PRIMARY KEY ,
ExamName NVARCHAR(50),
ExamMark NVARCHAR(50),
ExamDate NVARCHAR(50),
StuId int ,
CouId int ,
/*** Đánh giá nhận xét , của giáo viên , hoặc vắng mặt ko đủ tiêu chuẩn thi ***/
Comment Text ,
/*** ddiemr dau  ***/
MarkPass int ,
)
GO
DROP TABLE IF EXISTS TblCourse
CREATE TABLE TblCourse (
CouId int identity primary key,
CouName NVARCHAR(50),
CouSemester NVARCHAR(50),

)
GO
ALTER TABLE TblExam
ADD CONSTRAINT FK_TblExam_TblStudent
foreign key (StuId)
REFERENCES TblStudent(StuId)
go

ALTER TABLE TblExam 
ADD CONSTRAINT 
Fk_TblExam_TblCourse
FOREIGN KEY (StuId)
REFERENCES TblCourse(CouId)
GO
insert into TblStudent(StuPass,StuName,StuAdress,StuPhone,StuEmail,deptId)
Values ('1003241','hay ko ' , 'hay qua ha ' , '096784933234' , 'huynhtienthang@gmal.com' , '32')

Go
insert into TblStudent(StuPass,StuName,StuAdress,StuPhone,StuEmail,deptId)
Values ('1003252','huỳnh tiến  ' , 'đường võ đức  ' , '096784933890' , 'tienthang@gmal.com' , '35')
Go
insert into TblStudent(StuPass,StuName,StuAdress,StuPhone,StuEmail,deptId)
Values ('1003263','hay quá  ' , 'hay ko  ' , '098989087332' , 'hang@gmal.com' , '63')

Go


