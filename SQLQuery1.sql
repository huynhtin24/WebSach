
create table TheLoai
(
maloai int identity primary key,
tenloai nvarchar(39)
)

create table Sach
(
masach int identity (1,1) primary key,
maloai int references
TheLoai (maloai),
tensach nvarchar(100) not null,
hinh varchar(50),
giaban decimal (18,0),
ngaycapnhat smalldatetime,
soluongton int
)

create table KhachHang(
makh int identity (1,1) primary key,
hoten nvarchar(50),
tendangnhap varchar(20),
matkhau varchar(19),
email varchar(50),
diachi nvarchar(100),
dienthoai varchar(15),
ngaysinh date
)

create table DonHang(
madon int identity (1,1) primary key,
thanhtoan bit,
giaohang bit,
ngaydat date,
ngaygiao date,
makh int references KhachHang (makh)
)
create table ChiTietDonHang(
madon int references DonHang (madon),
masach int references Sach (masach),
soluong int,
gia decimal(18,9),
primary key(madon, masach)
)