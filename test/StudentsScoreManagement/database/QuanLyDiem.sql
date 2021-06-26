use master
drop database QLDiem

create database QLDiem
use QLDiem
go

create table KhoaDaoTao
(
	MaKhoa nvarchar(50) primary key,
	TenKhoa nvarchar(50),
	DienThoai nvarchar(40)
)

create table Lop
(
	MaLop nvarchar(30) primary key,
	MaKhoa nvarchar(50),
	TenLop nvarchar(50),
	Khoa nvarchar(50),
	HeDaoTao nvarchar(20),
	NamNhapHoc int,
	SiSo int,
	constraint FK_Lop_KhoaDaoTao foreign key(MaKhoa)  references KhoaDaoTao(MaKhoa)
)

create table SinhVien
(
	MaSV nvarchar(40) primary key,
	HoDem nvarchar(50),
	Ten nvarchar(50),
	NgaySinh Date,
	DiaChi nvarchar(50),
	GioiTinh nvarchar(20),
	Email nvarchar(30),
	SoDienThoai nvarchar(30),
	MaLop nvarchar(30),
	constraint FK_SinhVien_Lop foreign key(MaLop) references Lop(MaLop)
)

create table MonHoc
(
	MaMH nvarchar(30) primary key,
	TenMH nvarchar(50),
	SoTinChi int,
	HocKy int,

)
create table DiemThi
(
	MaMH nvarchar(30),
	MaSV nvarchar(40),
	Diem int,
	KyHoc int
	constraint PK_DiemThi primary key(MaMH,MaSV),
	constraint FK_DiemThi_SinhVien foreign key(MaSV) references SinhVien(MaSV),
	constraint FK_DiemThi_MonHoc foreign key(MaMH) references MonHoc(MaMH)
)

create table DangNhap
(
	UserID nvarchar(20) primary key,
	Ten nvarchar(20),
	Password nvarchar(20) 
)

insert into KhoaDaoTao values
('CNTT',N'Công Nghệ Thông Tin','124135'),
('KHMT',N'Khoa Học Máy Tính','456456'),
('HTTT',N'Hệ Thống Thông Tin','23425')

insert into Lop values
('CNTT03','CNTT',N'Công Nghệ Thông Tin 3',N'Công Nghệ Thông Tin',N'Đại Học',2018,80),
('CNTT01','CNTT',N'Công Nghệ Thông Tin 1',N'Công Nghệ Thông Tin',N'Đại Học',2019,70),
('KHMT03','KHMT',N'Khoa Học Máy Tính 3',N'Công Nghệ Thông Tin',N'Đại Học',2018,76),
('HTTT01','HTTT',N'Hệ Thống Thông Tin 3',N'Công Nghệ Thông Tin',N'Cao Đẳng',2017,77),
('HTTT02','HTTT',N'Hệ Thống Thông Tin 3',N'Công Nghệ Thông Tin',N'Đại Học',2018,68)

insert into SinhVien values 
('2018603147',N'Lê Hồng',N'Phong','2000-02-26',N'Hà Nam','Nam','phongle@gmail.com','035312345','CNTT03'),
('2018603455',N'Đỗ Vinh',N'Hà','2000-04-23',N'Hà Nội','Nam','havinh@gmail.com','035312456','CNTT01'),
('2018603453',N'Đoàn Duy',N'Nam','2000-12-12',N'Hải Phòng','Nam','namdoan@gmail.com','035314564','HTTT01'),
('2018606574',N'Hoàng Duy',N'Khánh','2000-08-26',N'Hải Phòng','Nam','khanh@gmail.com','035645345','KHMT03'),
('2018604564',N'Nguyễn Anh',N'Linh','2000-06-16',N'Hà Nội','Nam','anhlinh@gmail.com','034532345','HTTT02'),
('2018606325',N'Vũ Văn',N'Doan','2000-02-24',N'Nam Định','Nam','doan@gmail.com','035314353','CNTT03')

insert into MonHoc values
('JAVA',N'Lập Trình JAVA',4,6),
('C#',N'Lập Trình C#',3,6),
('XML',N'Công Nghệ XML',3,6),
('DHUD',N'ĐỒ Họa Ứng Dụng',3,6)

insert into DiemThi values 
('JAVA','2018603147',10,6),
('C#','2018603147',9,6),
('XML','2018603147',9.5,6),
('DHUD','2018603147',10,6),
('JAVA','2018603455',9,6),
('C#','2018603455',10,6),
('XML','2018603455',9.5,6),
('DHUD','2018603455',9,6),
('JAVA','2018603453',10,6),
('C#','2018603453',9,6),
('XML','2018603453',10,6),
('DHUD','2018603453',8,6),
('JAVA','2018606574',8,6),
('C#','2018606574',10,6),
('XML','2018606574',9,6),
('DHUD','2018606574',10,6),
('JAVA','2018604564',8,6),
('C#','2018604564',9,6),
('XML','2018604564',9,6),
('DHUD','2018604564',10,6),
('JAVA','2018606325',9,6),
('C#','2018606325',8,6),
('XML','2018606325',10,6),
('DHUD','2018606325',9,6)

insert into DangNhap values
('0001','admin','admin')
 
select * from KhoaDaoTao
select * from Lop
select * from SinhVien
select * from MonHoc
select * from DiemThi
select * from DangNhap
