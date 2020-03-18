--them khach hang moi
create proc sp_themkhachhang
@manv varchar(50),
@ten nvarchar(100),
@ngaysinh varchar(50),
@gioitinh nvarchar(50),
@diachi nvarchar(500),
@sdt varchar(50),
@chucvu nvarchar(100),
@taikhoan varchar(200)
as 
begin
	insert into NHAN_VIEN values(@manv, @ten, @ngaysinh, @gioitinh, @diachi,@sdt,@chucvu,@taikhoan)
end 
go

--load tat ca khach hang
create proc sp_hienthikhachhang
as
begin
	select * from NHAN_VIEN
end
go
