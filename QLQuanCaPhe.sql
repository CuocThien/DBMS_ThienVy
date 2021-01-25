
create database QLQuanCaPhe
--TẠO CÁC BẢNG THÔNG TIN

--Bảng chiết khấu
create table Discount(
Level nvarchar(10) not null primary key,
Discount_Rate int,
)
 --bảng thông tin cho khách hàng
create table Customer(
ID int identity(1,1) not null,
FullName nvarchar(max),
Phone nvarchar(12) not null primary key,
Address nvarchar(max),
Points int,
Level nvarchar(10),
Constraint FK_Customer_Discount foreign key (Level) references Discount (Level)  
)

--Bảng thông tin nhân viên
create table Staff(
Id_Staff nvarchar(50) not null primary key,
FullName nvarchar(max),
DoB date,
Phone nvarchar (12),
Address nvarchar(max),
position nvarchar(50)
)


--Bảng tài khoảng đăng nhập của nhân viên và quản lý
create table Accounts(
Id_Account int identity(1,1) not null primary key,
UserName nvarchar(max),
PassWord nvarchar(max),
Id_User nvarchar(50) not null,
Role nvarchar(50),
Constraint FK_Accounts_Staff foreign key (Id_User) references Staff (Id_Staff)
)

--Bảng chứa thông tin món của cửa hảng
create table Menu(
Id_Product int identity(1,1) not null primary key,
Name nvarchar(max),
Image nvarchar(max),
FandB nvarchar(50),
Category nvarchar(100),
Status bit,
Deleted bit
)


--Bảng chửa size món 
create table Size(
Id_Product int not null,
Size nchar(2) not null,
Price float,
constraint PK_Menu primary key (ID_Product,Size),
Constraint FK_Size_Menu foreign key (ID_Product) references Menu (Id_Product)
)
--Bảng tạm chứa thông tin món của khách order (tạm)
create table Temp(
ID_Order int not null,
ID_Product int not null,
Size nchar(2) not null,
Quantity int,
Price Float,
constraint PK_Temp primary key (ID_Order,ID_Product,Size),
Constraint FK_Temp_Size foreign key (ID_Product,Size) references Size (Id_Product,Size)
)

--Hóa đơn thanh toán của khách
create table Bill(
ID int identity(1,1) not null primary key,
Phone nvarchar(12),
Price float,
Discount Float,
Total float,
Id_Staff nvarchar(50),
Date_export datetime,
Constraint FK_Bill_Customer foreign key (Phone) references Customer (Phone),
Constraint FK_Bill_Staff foreign key (Id_Staff) references Staff (Id_Staff)
)

--Chi tiết các món khách order( đã thanh toán)
create table OrderDetail(
ID_Order int not null,
ID_Product int not null,
Size nchar(2) not null,
Quantity int,
Price Float,
constraint PK_OrderDetail primary key (ID_Order,ID_Product,Size),
Constraint FK_OrderDetail_Bill foreign key (ID_Order) references Bill (ID),
Constraint FK_OrderDetail_Size foreign key (ID_Product,Size) references Size (Id_Product,Size)
)

--KPI cho nhân viên
create table KPI(
Id_Staff nvarchar(50) not null,
PayDay date not null,
Target float,
Result float,
Bonus float
constraint PK_KPI primary key (Id_Staff,PayDay),
constraint FK_KPI_Staff foreign key (Id_Staff) references Staff (Id_Staff)
)

--Tính lương cho nhân viên
create table Salary(
Id_Staff nvarchar(50) not null,
PayDay date not null,
Basic_Salary float,
KPI float,
Fine float,
Salary float
constraint PK_Salary primary key (Id_Staff,PayDay),
constraint FK_Salary_Staff foreign key (Id_Staff) references Staff (Id_Staff)
)

--Tính doanh thu cho cửa hàng
create table Turnover(
Date date not null primary key,
Earnings float,
Payroll float,
Outgoing float,
Profit float
)

--THÊM DỮ LIỆU CHO CÁC BẢNG

--Bảng Discount
insert into Discount values 
(N'New','0'),
(N'Đồng','10'),
(N'Bạc','12'),
(N'Vàng','15'),
(N'Bạch kim','20')

--Bảng Customer
insert into Customer values
(N'Lâm Hoàng An','0386486730',N'Phan Đăng Lưu, Bình Thạnh, TP.HCM','320',N'Đồng'),
(N'Nguyễn Thị Như Quỳnh','0985194510',N'Quang Trung, Q.9, TP.HCM','548',N'Bạc'),
(N'Đặng Nguyễn Hoài Thư','0333963285',N'Quang Trung, Q.9,TP.HCM','1200',N'Bạch Kim'),
(N'Nguyễn Hữu Tường','0396084832',N'Đào Trinh Nhất, Thủ Đức, TP.HCM','935',N'Vàng')

--Bảng Staff
insert into Staff values
('TN1',N'Nguyễn Thị Hồng','05-22-2000','0384562785',N'Linh Trung, Thủ Đức, TP.HCM',N'Thu Ngân'),
('TN2',N'Trần Nguyễn','09-02-1999','0989487510',N'Linh Chiểu, Thủ Đức, TP.HCM',N'Thu Ngân'),
('TN3',N'Bùi Nhật Hào','01-02-1999','0987348975',N'Linh Chiểu, Thủ Đức, TP.HCM',N'Thu Ngân'),
('PC1',N'Ngô Duy Lâm','01-09-1997','0987348975',N'Phan Văn Trị, Gò Vấp, TP.HCM',N'Pha Chế'),
('PC2',N'Giang Thị Tuyết Trinh','08-26-1995','0956478952',N'Võ Văn Ngân, Thủ Đức, TP.HCM',N'Pha Chế'),
('QL1',N'Nguyễn Cước Thiên','10-22-2000','0708033730',N'Quang Trung, Gò Vấp, TP.HCM',N'Quản Lý'),
('QL2',N'Tu Ngọc Yến Vy','09-22-2000','0334874819',N'Linh Trung, Thủ Đức, TP.HCM',N'Quản Lý'),
('Cus',N'Khách','','','','')

--Bảng Accounts
insert into Accounts values
('hongnt','123456','TN1','NV'),
('nguyentran','123456','TN2','NV'),
('haobn','123456','TN3','NV'),
('cuocthien','123456','QL1','QL'),
('vyvy','123456','QL2','QL'),
('customer','123456','Cus','Cus')

--Bảng Menu
insert into Menu values
('Coffee Americano','Image/B/Expresso/Americano.jpg',N'Nước uống',N'Expresso','True','False'),
('Capuchino','Image/B/Expresso/capuchino.jpg',N'Nước uống',N'Expresso','True','False'),
('Machiato','Image/B/Expresso/machiato.jpg',N'Nước uống',N'Expresso','True','False'),
(N'Cà Phê Sữa','Image/B/Coffee/Cafesua.jpeg',N'Nước uống',N'Coffee','True','False'),
(N'Bạc Xỉu','Image/B/Coffee/bacxiu.jpg',N'Nước uống',N'Coffee','True','False'),
(N'Cà Phê Đen','Image/B/Coffee/cfden.jpg',N'Nước uống',N'Coffee','True','False'),
(N'Trà Đào Cam Xả','Image/B/Tea/tradaocamxa.png',N'Nước uống',N'Tea','True','False'),
(N'Trà Đào','Image/B/Tea/tradao.jpg',N'Nước uống',N'Tea','True','False'),
(N'Trà Ổi Hồng','Image/B/Tea/traoi.jpg',N'Nước uống',N'Tea','True','False'),
(N'Trà Trái Cây Nhiệt Đới','Image/B/Tea/traicay.jpeg',N'Nước uống',N'Tea','True','False'),
(N'Matcha Đá Xay','Image/B/IceBlended/matcha.jpg',N'Nước uống',N'Ice Blended','True','False'),
(N'Cooki Oreo Đá Xay','Image/B/IceBlended/cookie.jpg',N'Nước uống',N'Ice Blended','True','False'),
(N'Chocolate Đá Xay','Image/B/IceBlended/chocolate.jpg',N'Nước uống',N'Ice Blended','True','False'),
(N'Yogurt Xoài','Image/B/Yogurt/xoai.jpg',N'Nước uống',N'Yogurt','True','False'),
(N'Yogurt Dâu','Image/B/Yogurt/dau.jpg',N'Nước uống',N'Yogurt','True','False'),
(N'Yogurt Việt Quốc','Image/B/Yogurt/vietquoc.jpg',N'Nước uống',N'Yogurt','True','False'),
(N'Sữa Tươi Trân Châu Đường Đen','Image/B/MilkTea/duongden.jpg',N'Nước uống',N'Milk Tea','True','False'),
(N'Trà Sữa Gạo Lứt','Image/B/MilkTea/gaolut.jpg',N'Nước uống',N'Milk Tea','True','False'),
(N'Trà Sữa Trứng Nướng','Image/B/MilkTea/trungnuong.jpg',N'Nước uống',N'Milk Tea','True','False'),
(N'Bánh Tráng Trộn','Image/F/Nosh/banhtrang.jpg',N'Đồ Ăn',N'Ăn Vặt','True','False'),
(N'Cơm Cháy','Image/F/Nosh/comchay.jpg',N'Đồ Ăn',N'Ăn Vặt','True','False'),
(N'Cá Viên Chiên(Thập cẩm)','Image/F/Nosh/dochien.jpg',N'Đồ Ăn',N'Ăn Vặt','True','False'),
(N'Khoai Tây Chiên','Image/F/Nosh/khoaitay.jpg',N'Đồ Ăn',N'Ăn Vặt','True','False'),
(N'Bánh Gạo Cay Tokbokki','Image/F/Nosh/teokbokki.jpg',N'Đồ Ăn',N'Ăn Vặt','True','False'),
(N'Bánh Mì','Image/F/Breakfast/banhmi.jpg',N'Đồ Ăn',N'Ăn Sáng','True','False'),
(N'Phở Bò','Image/F/Breakfast/pho.jpg',N'Đồ Ăn',N'Ăn Sáng','True','False'),
(N'Hủ Tiếu','Image/F/Breakfast/hutieu.jpg',N'Đồ Ăn',N'Ăn Sáng','True','False'),
(N'Mì Tôm','Image/F/Breakfast/mitom.jpg',N'Đồ Ăn',N'Ăn Sáng','True','False'),
(N'Cơm Sườn','Image/F/Lunch/comsuon.jpg',N'Đồ Ăn',N'Ăn Trưa/Chiều','True','False'),
(N'Canh Chua','Image/F/Lunch/canhchua.jpg',N'Đồ Ăn',N'Ăn Trưa/Chiều','True','False'),
(N'Canh Khổ Qua Nhồi Thịt','Image/F/Lunch/khoqua.jpg',N'Đồ Ăn',N'Ăn Trưa/Chiều','True','False'),
(N'Mỳ ý','Image/F/Lunch/miy.jpg',N'Đồ Ăn',N'Ăn Trưa/Chiều','True','False'),
(N'Cơm Chiên Hải Sản','Image/F/Lunch/comchien.png',N'Đồ Ăn',N'Ăn Trưa/Chiều','True','False'),
(N'Cơm Chay','Image/F/Lunch/comchay.jpg',N'Đồ Ăn',N'Ăn Trưa/Chiều','True','False'),
(N'Cá Lóc Kho Tộ','Image/F/Lunch/caloc.jpg',N'Đồ Ăn',N'Ăn Trưa/Chiều','True','False'),
(N'Cơm Thêm','Image/F/Lunch/com.jpg',N'Đồ Ăn',N'Ăn Trưa/Chiều','True','False')


--Bảng size
insert into Size values
('1','S','50000'),('1','M','75000'),('1','L','100000'),
('2','S','59000'),('2','M','89000'),('2','L','109000'),
('3','S','59000'),('3','M','89000'),('3','L','109000'),
('4','S','45000'),('4','M','70000'),
('5','S','42000'),('5','M','69000'),
('6','S','40000'),('6','M','60000'),
('7','S','60000'),('7','M','85000'),('7','L','110000'),
('8','S','54000'),('8','M','79000'),('8','L','99000'),
('9','S','54000'),('9','M','79000'),('9','L','99000'),
('10','S','60000'),('10','M','85000'),('10','L','110000'),
('11','S','62000'),('11','M','87000'),('11','L','113000'),
('12','S','62000'),('12','M','87000'),('12','L','113000'),
('13','S','62000'),('13','M','87000'),('13','L','113000'),
('14','S','65000'),('14','M','90000'),('14','L','130000'),
('15','S','65000'),('15','M','90000'),('15','L','130000'),
('16','S','65000'),('16','M','90000'),('16','L','130000'),
('17','S','59000'),('17','M','74000'),('17','L','110000'),
('18','S','59000'),('18','M','74000'),('18','L','110000'),
('19','S','65000'),('19','M','89000'),('19','L','130000'),
('20','S','40000'),('20','M','60000'),('20','L','80000'),
('21','S','40000'),('21','M','60000'),('21','L','80000'),
('22','S','60000'),('22','M','100000'),('22','L','150000'),
('23','S','50000'),('23','M','80000'),('23','L','100000'),
('24','S','50000'),('24','M','80000'),('24','L','100000'),
('25','S','30000'),('25','M','50000'),('25','L','70000'),
('26','S','60000'),('26','M','90000'),('26','L','120000'),
('27','S','60000'),('27','M','90000'),('27','L','120000'),
('28','S','40000'),('28','M','55000'),('28','L','69000'),
('29','S','60000'),('29','M','90000'),('29','L','120000'),
('30','S','50000'),('30','M','70000'),('30','L','90000'),
('31','S','50000'),('31','M','70000'),('31','L','90000'),
('32','S','59000'),('32','M','79000'),('32','L','99000'),
('33','S','59000'),('33','M','89000'),('33','L','120000'),
('34','S','40000'),('34','M','55000'),('34','L','69000'),
('35','S','60000'),('35','M','90000'),('35','L','120000'),
('36','S','20000'),('36','M','40000'),('36','L','60000')

--Bảng KPI
insert into KPI values
('TN1','11/30/2020','50000000','52000000','200000'),
('TN2','11/30/2020','50000000','52000000','200000'),
('TN3','11/30/2020','50000000','53000000','300000'),
('QL1','11/30/2020','','20000000',''),
('QL2','11/30/2020','','23000000',''),
('TN1','12/31/2020','50000000','55000000','500000'),
('TN2','12/31/2020','50000000','52000000','200000'),
('TN3','12/31/2020','50000000','53000000','300000'),
('QL1','12/31/2020','','20000000',''),
('QL2','12/31/2020','','20000000','')

--Bảng Salary
insert into Salary values
('TN1','11/30/2020','7000000','200000','0','7200000'),
('TN2','11/30/2020','7000000','200000','0','7200000'),
('TN3','11/30/2020','7000000','300000','0','7300000'),
('PC1','11/30/2020','8500000','0','0','8500000'),
('PC2','11/30/2020','9000000','0','0','9000000'),
('TN1','12/31/2020','7000000','500000','0','7500000'),
('TN2','12/31/2020','7000000','200000','0','7200000'),
('TN3','12/31/2020','7000000','300000','0','7300000'),
('PC1','12/31/2020','8500000','0','0','8500000'),
('PC2','12/31/2020','9000000','0','0','9000000')

--Bảng Turnover
insert into Turnover values
('11/30/2020','200000000','39200000','90800000','70000000'),
('12/31/2020','250000000','39500000','100500000','110000000')


--TẠO PROCEDURE, TRIGGER, FUNCTION

--Tạo role

create role NhanVien
Create role Khachhang
go
CREATE SCHEMA [RoleKhachhang]
GO
CREATE SCHEMA [RoleNhanVien]
GO

--Tạo login 
sp_addlogin 'vyvy','123456'
go
sp_addlogin 'cuocthien','123456'
go
sp_addlogin 'hongnt','123456'
go
sp_addlogin 'nguyentran','123456'
go
sp_addlogin 'haobn','123456'
go
sp_addlogin 'customer','123456'
go
--Tạo user ứng vs login
sp_adduser 'vyvy','vyvy'
go
sp_adduser 'cuocthien','cuocthien'
go
sp_adduser 'hongnt','hongnt'
go
sp_adduser 'nguyentran','nguyentran'
go
sp_adduser 'haobn','haobn'
go
sp_adduser 'customer','customer'
go
--Add quyền cho admin
sp_addsrvrolemember[vyvy],[sysadmin]
go
sp_addsrvrolemember[cuocthien],[sysadmin]
go


--Add khách hàng vào rolekhachhang
sp_addrolemember [Khachhang],[customer]
go
--Add nhân viên vào rolenhanvien
sp_addrolemember [NhanVien],[hongnt]
go
sp_addrolemember [NhanVien],[nguyentran]
go
sp_addrolemember [NhanVien],[haobn]
go

--CÁC VIEW (LẤY DANH SÁCH)
go--Tạo funtion lấy menu lên
create or alter view Menu_view
as
select Menu.*,Size.Size,Size.Price from Menu join Size on Menu.Id_Product =Size.Id_Product where Menu.Deleted='False'


go--Lấy danh sách nhân viên
create or alter view DSNhanvien_view
as
select * from Staff where position =N'Pha Chế' or position=N'Thu Ngân'

go-- Lấy danh sách khách hàng
create or alter view DSKH_view
as
select top(99.99) percent Customer.* from Customer order by ID asc
go

go--Lấy bảng lương
create or alter view DSLuong_view
as
select * from Salary

go--Lấy bảng doanh số
create or alter view DoanhSo_view
as
select * from Turnover

GO--lấy các món trong temp
create or alter view Temp_view
as
select * from Temp

go--xem bill
create or alter view bill_view
as select * from Bill
go
--TRIGGER

--TURNOVER

GO--Tính tiền thu vào bảng doanh thu
create or alter trigger tg_thu on Turnover
for insert
as
begin
	update Turnover set Earnings=(select sum(Result) from KPI where MONTH(KPI.PayDay)=MONTH(Turnover.Date) and year(KPI.PayDay)=year(Turnover.Date))
end


go--Tính tổng lương vào bảng doanh thu
create or alter trigger tg_luongchi on Turnover
for insert
as
begin
	update Turnover set Payroll=(select sum(Salary.Salary) from Salary where MONTH(Salary.PayDay)=MONTH(Turnover.Date) and year(Salary.PayDay)=year(Turnover.Date))
end

go--Trigger Tính doanh thu
create or alter trigger tg_Ton on Turnover
for insert
as
begin
	update Turnover set Profit=Earnings -Payroll- Outgoing
end

go--Trigger tính lương
create or alter trigger tg_luongnv on Salary
for insert
as
begin
	update Salary set Salary=Basic_Salary+KPI - Fine
end

go--Trigger tính price trong bảng temp
create or alter trigger tg_Price on Temp
for insert
as
begin
	update Temp set Price=Quantity * (select Menu_view.Price from Menu_view where Temp.ID_Product=Menu_view.Id_Product and Temp.Size=Menu_view.Size)
end

go--Trigger cập nhập price khi số lượng trong bảng temp
create or alter trigger tg_SuaPrice on Temp
for update
as
begin
	update Temp set Price=Quantity * (select Menu_view.Price from Menu_view where Temp.ID_Product=Menu_view.Id_Product and Temp.Size=Menu_view.Size)
end

go--Trigger tính price trong bill
create or alter trigger tg_pricebill on Bill
for insert
as
begin
declare @check int 
	select @check = Temp.ID_Order from Temp 
	update Bill set Price=(select sum(Price) from Temp where Bill.ID = Temp.ID_Order)where Bill.ID = @check
end

go--Trigger sửa price trong bill
create or alter trigger tg_suapricebill on Bill
for update
as
begin
IF TRIGGER_NESTLEVEL() > 1
	return
else
begin
	declare @check int 
	select @check = Temp.ID_Order from Temp 
	update Bill set Price=(select sum(Price) from Temp where Bill.ID = Temp.ID_Order) where Bill.ID = @check
end
end

go--Trigger tính discount trong bill
create or alter trigger tg_Discountbill on Bill
for insert
as
begin
	update Bill set Discount= (Bill.Price * (select Discount.Discount_Rate 
											from Discount join Customer on Discount.Level = Customer.Level
											where Customer.Phone=Bill.Phone))/100
end


go--Trigger sửa discount trong bill
create or alter trigger tg_suaDiscountbill on Bill
for update
as
begin
IF TRIGGER_NESTLEVEL() > 1
	return
else
	update Bill set Discount= (Bill.Price * (select Discount.Discount_Rate 
											from Discount join Customer on Discount.Level = Customer.Level
											where Customer.Phone=Bill.Phone))/100
end

go--Tính tổng bill

create or alter trigger tg_Totalbill on Bill
for insert
as
begin
	update Bill set Total=Price - Discount
end


go--Sửa tổng bill
create or alter trigger tg_suaTotalbill on Bill
for update
as
begin
	update Bill set Total=Price - Discount
end


go--Update level chiết khấu cho khách
Create or alter trigger tg_discountCus on Customer
for update
as
begin
IF TRIGGER_NESTLEVEL() > 1
	return
else
begin
	update Customer set Level=N'Đồng' where Customer.Points >=100 and Customer.Points <=499
	update Customer set Level=N'Bạc' where Customer.Points >=500 and Customer.Points <=699
	update Customer set Level=N'Vàng' where Customer.Points >=700 and Customer.Points <=999
	update Customer set Level=N'Bạch Kim' where Customer.Points >=1000
end
end

go--Thêm Bonus cho nhân viên
create or alter trigger tg_Bonus on KPI
for insert
as
begin
	update KPI set Bonus=((Result-Target)*10)/100 where Result > Target
end

go--Update Bonus cho nhân viên

create or alter trigger tg_suaBonus on KPI
for update
as
begin
	update KPI set Bonus=((Result-Target)*10)/100 where Result >Target
end

go-- Thêm KPI vào bảng lương
create or alter trigger tg_ThemKPI on Salary
for insert
as
begin
update Salary set Salary.KPI=KPI.Bonus from KPI where Salary.Id_Staff=KPI.Id_Staff and Month(KPI.PayDay) = MONTH(Salary.PayDay) and year(KPI.PayDay)=year(Salary.PayDay)
end
--CÁC FUNCTION DÙNG CHO HIỂN THỊ LÊN GIAO DIỆN ( TÌM KIẾM)
	go ---Tạo function đăng nhập
create or alter function func_ktlogin (@name nvarchar(max), @pass nvarchar(max))
returns @tblogin table (kq int)
as
begin
declare @kq int, @chucnang nvarchar(50)
if(exists(select * from Accounts where @name = Accounts.UserName and @pass=Accounts.PassWord))
begin
	select @chucnang=Accounts.Role
	from Accounts 
	where @name = Accounts.UserName and @pass=Accounts.PassWord
	if(@chucnang = 'NV')
		set @kq=1;
	else if(@chucnang='QL')
		set @kq=2;
	else
		set @kq=0;
end
else
	set @kq=-1;
insert into @tblogin values (@kq)
return
end

go--Tìm món theo tên
create or alter function func_TimMon(@ten nvarchar(max))
returns table
as
return select Menu.*,Size.Size,Size.Price from Menu join Size on Menu.Id_Product =Size.Id_Product
where Menu.Name like N'%'+@ten+'%'

go--Tìm món theo F&D
create or alter function func_TimFandB(@key nvarchar(50))
returns table
as
return select Menu.*,Size.Size,Size.Price from Menu join Size on Menu.Id_Product =Size.Id_Product
where Menu.FandB like N'%'+@key+'%'

go
go--Tìm theo loại
create or alter function func_TimMontheoLoai(@key nvarchar(max))
returns table
as
return select Menu.*,Size.Size,Size.Price from Menu join Size on Menu.Id_Product =Size.Id_Product
where Menu.Category like N'%'+@key+'%'
go
go --Lấy top 5 món bán chạy nhất cửa hàng
create or alter function func_Top5Mon()
returns table
as
return (select top(5) Menu.*,SLBAN
from (select ID_Product, sum(Quantity) as SLBAN
from OrderDetail
group by ID_Product) A join Menu on a.ID_Product=Menu.Id_Product
order by SLBAN DESC)


go--Lấy top 1 nhân viên xuất sắc theo tháng
create or alter function func_Top1nhanvien()
returns table
as
return (select KPI.PayDay,KPI.Id_Staff,KPI.Result
from(
select max(Result) as LN,PayDay
from KPI
group by PayDay) A, KPI 
where A.LN = KPI.Result and A.PayDay=KPI.PayDay)

go--Lấy top 3 khách hàng thân thiết
create or alter function func_Top3KH()
returns table
as
return select top(3) Customer.* from Customer order by Customer.Points desc

go--Tìm kiếm nhân viên theo tên hoặc mã
create or alter function func_TimNV(@key nvarchar(50), @luachon int)
returns @staff table (id nvarchar(50),name nvarchar(max),Dob date,phone nvarchar(12),address nvarchar(max), position nvarchar(50))
as
begin
declare @id nvarchar(50), @name nvarchar(max),@dob date, @phone nvarchar(12),@address nvarchar(max), @position nvarchar(50)
if(@luachon=1)
	 (select @id=Id_Staff,@name=FullName,@dob=DoB, @phone=Phone,@address=Staff.Address,@position=position from Staff where Staff.Id_Staff=@key)
else
	(select @id=Id_Staff,@name=FullName,@dob=DoB, @phone=Phone,@address=Staff.Address,@position=position from Staff where Staff.FullName like N'%' +@key+'%')
insert into @staff values (@id, @name,@dob, @phone,@address, @position)
return
end


go --Tìm kiếm khách hàng theo số điện thoại
create or alter function func_timkh (@sdt nvarchar(12))
returns table
as
return select * from Customer where Customer.Phone=@sdt


go--Lấy thông tin của cá nhân
create or alter function func_thongtin(@ma nvarchar(50))
returns table
as
return select * from Staff where Staff.Id_Staff = @ma
go--Lấy thông tin đăng nhập (dùng để đổi mật khẩu)
create or alter function func_layAccount(@ma nvarchar(50))
returns table
as
return select * from Accounts where @ma= Accounts.Id_User

go--Tìm Account theo username--dùng để lấy mật khẩu cũ
create or alter function func_timMaNV (@username nvarchar(max))
returns table
as
return select * from Accounts where Accounts.UserName = @username


 go--Tìm mã món (thêm size)
 create or alter function func_MaMon (@name nvarchar(max))
 returns int
 as
 begin
 declare @id int
select @id= Menu.Id_Product from Menu where @name=Menu.Name
return @id
end

go--Lấy lương nhân viên theo mã
create or alter function func_Luongnv (@id nvarchar(50),@PayDay date)
returns table
as
 return select * from Salary where @id=Salary.Id_Staff and Month(Salary.PayDay) = MONTH(@PayDay) and year(Salary.PayDay)=year(@PayDay)

 go--Tìm món theo id product
create or alter function func_TimMonTheoMa(@id nvarchar(max))
 returns table
 as return select Menu.Name from Menu where Menu.Id_Product=@id
 go
 go--Tìm doanh thu theo tháng
create or alter function func_Timdoanhthu(@date date)
 returns table
 as return select * from Turnover where Turnover.Date=@date
 go
 go--Lấy nhân viên xuất sắc nhất (lấy theo 1 tháng nào đó)
create or alter function func_timTop1nhanvien(@date date)
returns table
as
return select * from func_Top1nhanvien() a where Month(a.PayDay)= month(@date) and year(a.PayDay)= year(@date)
--FUNCTION KIỂM TRA CÁC MÃ ĐỂ THÊM VÀO BẢNG
go--Kiểm tra Tên món
create or alter function func_checkname(@name nvarchar(max))
returns int
as
begin
declare @check int
if(exists(select * from Menu where @name=Menu.Name))
	set @check=1;
else
	set @check=0;
return @check
end

go--Kiểm tra mã id của staff
create or alter function func_checkid(@id nvarchar(50))
returns int
as
begin
declare @check int
if(exists(select * from Staff where @id=Staff.Id_Staff))
	set @check=1;
else
	set @check=0;
return @check
end

go--Kiểm tra userName
create or alter function func_checkUsername(@username nvarchar(max))
returns int
as
begin
declare @check int
if(exists(select * from Accounts where @username=Accounts.UserName))
	set @check=1;
else
	set @check=0;
return @check
end

go--Kiểm tra 2 password trùng
create or alter function func_checkpass(@pass nvarchar(max),@confirm nvarchar(max))
returns int
as
begin
declare @check int
if(@pass=@confirm)
	set @check=1;
else
	set @check=0;
return @check
end

go--Kiểm tra ngày tháng trùng (tính doanh số)
create or alter function func_checkPayday(@Payday date)
returns int
as
begin
declare @check int
if(exists(select * from Turnover where Month(Turnover.Date) = MONTH(@PayDay) and year(Turnover.Date)=year(@PayDay)))
	set @check=1;
else
	set @check=0;
return @check
end
go--Kiểm tra id và ngày tháng (tính KPI)
create or alter function func_checkPaydayKPI(@id nvarchar(50), @Payday date)
returns int
as
begin
declare @check int
if(exists(select * from KPI where @id=KPI.Id_Staff and Month(KPI.PayDay) = MONTH(@PayDay) and year(KPI.PayDay)=year(@PayDay)))
	set @check=1;
else
	set @check=0;
return @check
end

go--Kiểm tra lương nhân viên đó đã có hay chưa
create or alter function func_checksalary(@id nvarchar(50), @payday date)
returns int
begin
declare @check int
if(exists(select * from Salary where @id=Salary.Id_Staff and Month(Salary.PayDay) = MONTH(@PayDay) and year(Salary.PayDay)=year(@PayDay)))
	set @check=1;
else
	set @check=0;
return @check
end

go--Kiểm tra size đã có hay chưa
create or alter function func_checkSize(@id int, @size nchar(2))
returns int
begin
declare @check int
if(exists(select * from Size where @id=Size.Id_Product and @size = Size))
	set @check=1;
else
	set @check=0;
return @check;
end

--PROCEDURE (THÊM SỬA XÓA)
--MENU
go--Thêm món vào menu
create or alter procedure proc_ThemMenu @name nvarchar(max), @image nvarchar(max), @FandB nvarchar(50), @Category nvarchar(100)
as
begin
		insert into Menu values (@name,@image,@FandB,@Category,'True','False')
end

go--Thêm size cho món
create or alter procedure proc_ThemSize @id int, @size nchar(2), @price float
as
begin
		insert into Size values (@id,@size,@price)
end

go--Chỉnh sửa thông tin món
create or alter procedure proc_SuaMenu @id int,@name nvarchar(max), @image nvarchar(max), @FandB nvarchar(50), @Category nvarchar(100)
as
begin
	update Menu set Name=@name,Image=@image,FandB=@FandB,Category=@Category where Id_Product=@id
end

go --Xóa món
create or alter procedure proc_XoaMenu @id int
as
begin
	Update Menu set Deleted='True' where @id=Menu.Id_Product
end

go--Sửa giá của món
create or alter procedure proc_Suagia @id int, @size nchar(2),@price float
as
begin
	update Size set Size.Price=@price where Id_Product=@id and Size=@size
end

go--Sửa trạng thái món
create or alter procedure proc_suastatus @id int
as
begin
	update Menu set Status='False'where Menu.Id_Product=@id
end
go--Reset lại trạng thái món
create or alter procedure proc_resetstatus 
as
begin
	update Menu set Status='True'
end
--STAFF
go--Thêm nhân viên
create or alter procedure proc_ThemNV @Id_Staff nvarchar(50), @Name nvarchar(max), @dob date, @phone nvarchar(12),@address nvarchar(max),@possition nvarchar(50)
as
begin
	insert into Staff values (@Id_Staff, @Name, @dob, @phone,@address ,@possition)
end

go--Thêm Account nhân viên
create or alter procedure proc_ThemAccountNV @user nvarchar(max), @password nvarchar(max), @iduser nvarchar(50), @role nvarchar(50)
as
begin
	insert into Accounts values(@user,@password,@iduser,@role)
end

go--Thêm login nhân viên
create or alter procedure proc_ThemLoginNV @user nvarchar(max), @pass nvarchar(max)
as
begin
	declare @sql nvarchar(MAX)
	EXEC sp_addlogin @user,@pass
	EXEC sp_adduser @user,@user
	set @sql= 'sp_addrolemember[NhanVien],['+@user+']' 
	EXEC sp_sqlexec @sql
end


go--Sửa thông tin nhân viên
create or alter procedure proc_SuaNV @Id_Staff nvarchar(50), @Name nvarchar(max), @dob date, @phone nvarchar(12),@address nvarchar(max),@possition nvarchar(50)
as
begin
	update Staff set FullName=@Name,DoB= @dob,Phone= @phone,Address=@address,position= @possition where Id_Staff=@Id_Staff
end

go--Sửa mật khẩu
Create or alter procedure proc_SuaMK @Id_Staff nvarchar(50), @password nvarchar(max)
as
begin
	update Accounts set PassWord=@password where Id_User=@Id_Staff
end

go--Sửa mật khẩu login,user
create or alter procedure proc_doimksql @user nvarchar(max), @passold nvarchar(max),@passnew nvarchar(max)
as
begin
EXEC sp_password @passold,@passnew,@user
end

go--Xóa nhân viên
create or alter procedure proc_XoaNV @id nvarchar(50)
as
begin
	delete from Staff where Id_Staff=@id
end
go--Xóa account
create or alter procedure proc_XoaAccount @id nvarchar(50)
as
begin
	delete from Accounts where Id_User=@id
end
go --Xóa login/user
create or alter procedure proc_xoalogin @user nvarchar(max)
as
begin
EXEC sp_droplogin @user
EXEC sp_dropuser @user
end
GO

--CUSTOMER
go--Thêm khách
create or alter procedure proc_ThemKH @name nvarchar(max), @phone nvarchar(12), @address nvarchar(max)
as
begin
	insert into Customer values (@name,@phone,@address,'0','New')
end

go--sửa điểm tích lũy khách
create or alter procedure proc_Points @phone nvarchar(12),@price float
as
begin
	update Customer set Points=Points+ (@price/1000)*0.1 where @phone=Customer.Phone
end


--SALARY
go--Thêm lương
create or alter procedure proc_Luong  @id nvarchar(50),@Luongcb float, @fine float
as
begin
	insert into Salary values (@id,GETDATE(),@Luongcb,'',@fine,'')
end

--TURNOVER
go--Thêm doanh số
create or alter procedure proc_Doanhthu  @payday date,@chi float
as
begin
	insert into Turnover values (@payday,'','',@chi,'')
end

--BILL
go--Thêm bill
create or alter procedure proc_ThemBill @phone nvarchar(12),@id_staff nvarchar(50)
as
begin
insert into Bill values (@phone,'','','',@id_staff,GETdate())
end

go--Update bill
create or alter procedure proc_SuaBill @id int
as
begin
update Bill set Date_export= getdate()
end
--exec proc_ThemBill '0333963285','TN1'


--TEMP
go--Thêm món vào temp
create or alter procedure proc_ThemTemp @id_pro int, @size nchar(2),@phone nvarchar(12),@id_staff nvarchar(50)
as
begin
declare @id_order int
if(exists(select * from Temp))
begin
	select @id_order= max(Temp.ID_Order) from Temp 
	insert into Temp values (@id_order,@id_pro,@size,'1','')
	exec proc_SuaBill @id_order
	return
end
else
begin
	if(exists(select * from Bill))
	begin
		select @id_order= max(Bill.ID) from Bill 
		set @id_order=@id_order+1;
		insert into Temp values (@id_order,@id_pro,@size,'1','')
		exec proc_ThemBill @phone,@id_staff
		return
	end
	else
		insert into Temp values ('1',@id_pro,@size,'1','')
		exec proc_ThemBill @phone,@id_staff
		return
	end
end


go--Sửa số lượng trong temp
create or alter procedure proc_SuaTemp  @id_pro int, @size nchar(2),@Quantity int
as
begin
update Temp set Quantity=@Quantity where  ID_Product=@id_pro and Size=@size
declare @id_order int
select @id_order= max(Temp.ID_Order) from Temp 
exec proc_SuaBill @id_order
end

go--Xóa món trong temp
create or alter procedure proc_XoaMonTemp  @id_pro int, @size nchar(2)
as
begin
declare @id int
select @id=MAX(Temp.ID_Product) from Temp
delete Temp where ID_Product=@id_pro and Size=@size
exec proc_SuaBill @id
end

go--Xóa bảng Temp
create or alter procedure proc_XoaTemp 
as
begin
delete Temp 
end

--KPI
go--Thêm KPI cho nhân viên 

create or alter procedure proc_ThemKPI @id_staff nvarchar(50)
as
begin
declare @check int,@result float,@target float, @bonus float
set @check=dbo.func_checkPaydayKPI(@id_staff,GETDATE())
select @result=Bill.Total from Bill where @id_staff=Bill.Id_Staff and Month(Bill.Date_export) = MONTH(GETDATE()) and year(Bill.Date_export)=year(GETDATE())
set @target='5000000'
set @bonus=0
if(@check=0)
begin
	if(@result>@target)
		set @bonus=(@result-@target)*0.1
	insert into KPI values (@id_staff,GETDATE(),@target,@result,@bonus)
end
else
begin
	update KPI set Result=Result+@result,PayDay=GETDATE() where @id_staff=KPI.Id_Staff and Month(KPI.PayDay) = MONTH(GETDATE()) and year(KPI.PayDay)=year(GETDATE())
end
end


--DBCC CHECKIDENT (Bill, RESEED, 0) chạy lại bill từ 1

go--ORDER DETAIL
Create or alter procedure proc_ThemOrder 
as
begin
declare @id_staff nvarchar(50),@id int,@phone nvarchar(12),@price float
select @id=max(Bill.ID) from Bill
select @id_staff=Bill.Id_Staff,@price=Price,@phone=Phone from Bill where @id=Bill.ID
insert into OrderDetail select * from Temp
exec proc_XoaTemp 
exec proc_ThemKPI @id_staff
exec proc_Points @phone, @price
end

--GÁN QUYỀN
--*KHÁCH HÀNG
--Login
grant select on func_ktlogin to Khachhang
grant select on Accounts to Khachhang
--Khách hàng có quyền xem menu
grant select on Menu to Khachhang --table
grant select on Size to Khachhang
grant select on Menu_view to Khachhang --view

--Tìm món
grant select on func_TimMon to Khachhang --function
grant select on func_LayLoai to Khachhang
grant select on func_TimFandB to Khachhang
grant select on func_TimMontheoLoai to Khachhang


--*NHÂN VIÊN
--Login
grant select on func_ktlogin to NhanVien
grant select on Accounts to NhanVien

--Nhân viên có quyền xem menu
grant select,update on Menu to NhanVien
grant select on Size to NhanVien
grant select,update on Menu_view to NhanVien --view

--Tìm món
grant select on func_TimMon to NhanVien --function
grant select on func_LayLoai to NhanVien
grant select on func_TimFandB to NhanVien
grant select on func_TimMontheoLoai to NhanVien
grant select on func_TimMonTheoMa to NhanVien
grant select on func_Top5Mon to NhanVien

--Sửa thông tin cá nhân
grant select,update on func_thongtin to NhanVien
grant select,update on Staff to NhanVien
grant exec on proc_SuaNV to NhanVien

--Sửa mật khẩu
grant exec on proc_SuaMK to NhanVien--procedure
grant exec on proc_doimksql to NhanVien
grant exec on func_checkpass to NhanVien --function
grant select on func_timMaNV to NhanVien
grant select,update on func_layAccount to NhanVien
grant select,update on Accounts to NhanVien --table

--Thêm khách hàng
grant select ,insert on DSKH_view to NhanVien 
grant select ,insert,update on Customer to NhanVien --sửa point,level
grant select on func_timkh to NhanVien
grant exec on proc_ThemKH to NhanVien
grant exec on proc_Points to NhanVien


--Thêm bill, bảng temp, bảng order...
grant select,insert,update on Bill to NhanVien 
grant select,insert,update,delete on Temp to NhanVien 
grant select,insert on OrderDetail to NhanVien 
grant select,insert,update on KPI to NhanVien --tính KPI khi tính bill cho khách
grant exec on proc_ThemTemp to NhanVien --procedure
grant exec on proc_SuaTemp to NhanVien 
grant exec on proc_XoaMonTemp to NhanVien 
grant exec on proc_XoaTemp to NhanVien 
grant exec on proc_ThemKPI to NhanVien 
grant exec on proc_ThemBill to NhanVien
grant exec on proc_SuaBill to NhanVien
grant exec on proc_ThemOrder to NhanVien 
grant exec on proc_suastatus to NhanVien 
grant exec on proc_resetstatus to NhanVien

select * from bill_view

exec proc_ThemTemp '1','S','0985194510','TN1'

exec proc_ThemOrder
exec proc_ThemTemp '1','S','0333963285','TN1'