CREATE DATABASE Quanlyphongtro

use [Quanlyphongtro]
go

create table Room(
MaPhong 

)go

create table Khachhang(
IDKh tinyint primary key REFERENCES  Khachhang(IDKh),
Hoten nvarchar(100), 
CMND nvarchar(100) not null,
SĐT tinyint not null,
MaPhong nvarchar(100) ,
)
go

