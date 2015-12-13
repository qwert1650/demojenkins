create database QLHP
go 
use QLHP
go 
create table quantri
(
	ma varchar(10) not null primary key,
	Tendangnhap varchar(30),
	Matkhau varchar(20),
	maQuanLy varchar(10)
)
create table QuanLy
(
	ma varchar(10)not null primary key,
	Hoten varchar(30),
	Tendangnhap varchar(30),
	Matkhau varchar(20),
	Namsinh datetime,
	Gioitinh varchar(10),
	Dantoc varchar(30),
	maBoPhan varchar(10),
	Diachi varchar(100),
	Quyentruycap varchar(10),
	Dienthoai int,
	TrangThai varchar(10)
	
)

create table GiaoVien
(
	ma varchar(10)not null primary key,
	Hoten varchar(30),
	Tendangnhap varchar(30),
	Matkhau varchar(20),
	Namsinh datetime,
	Gioitinh varchar(10),
	Dantoc varchar(30),
	maBoPhan varchar(10),
	Diachi varchar(100),
	Quyentruycap varchar(10),
	Dienthoai int,
	maQuanLy varchar(10),
	maKhoa varchar(10),
	TrangThai varchar(10)
)

create table SinhVien
(
	ma varchar(10)not null primary key,
	Hoten varchar(30),
	Tendangnhap varchar(30),
	Matkhau varchar(20),
	Namsinh datetime,
	Gioitinh varchar(10),
	Dantoc varchar(30),
	maLop varchar(10),
	Diachi varchar(100),
	Quyentruycap varchar(10),
	Dienthoai int,
	maQuanLy varchar(10),
	maKhoa varchar(10),
	TrangThai varchar(10)
)
create table MonHoc
(
	ma varchar(10)not null primary key,
	tenMonHoc varchar(30),
	maKhoa varchar(10) 
)

create table PhuTrach
(
	maGiaoVien varchar(10),
	maMonHoc varchar(10),
	maKhoaHoc varchar(10),
	maLop varchar(10)
	constraint pk_phutrach primary key (maGiaoVien,maMonHoc, maKhoaHoc)
)

create table DoAn
(
	ma varchar(10) not null primary key,
	tenDoAn varchar(30),
	Chitiet varchar(200),
	Sothanhvien int,
	deadline datetime,
	maMonHoc varchar(10),
	maGiangVien varchar(10)
)

create table DangKiMonHoc
(
	maSinhVien varchar(10),
	maMonHoc varchar(10),
	maKhoaHoc varchar(10),
	maLop varchar(10)
	constraint pk_dangkimonhoc primary key (maSinhVien, maMonHoc)
)

create table DangKiNhom
(
	maNhom varchar(10) not null primary key,
	tenNhom varchar(30),
	Songuoi int,
	maMonHoc varchar(10),
	Nhomtruong varchar(10),
	Thanhvien varchar(10),
	maDangKi varchar(10)
)
create table DangKiDoAn
(
	ma varchar(10) not null primary key,
	maDoAn varchar(10),
	maNhom varchar(10),
	Soluongnhom int
)
create table Khoa
(
	maKhoa varchar(10)not null primary key,
	tenKhoa varchar(30),
)
create table TrangThai
(
	maTrangThai varchar(10) not null primary key,
	tenTrangThai varchar(30)
)
alter table quantri
add constraint fk_quantri foreign key (maQuanLy) references QuanLy(ma)
alter table GiaoVien
add constraint fk_quanlygiaovien foreign key (maQuanLy) references QuanLy(ma)
alter table SinhVien 
add constraint fk_quanlysinhvien foreign key (maQuanLy) references QuanLy(ma)
alter table PhuTrach
add constraint fk_phutrach1 foreign key (maMonHoc) references MonHoc(ma)
alter table DoAn
add constraint fk_doan1 foreign key (maMonHoc) references MonHoc(ma)
alter table DangKiMonHoc
add constraint fk_dangkimonhoc1 foreign key (maMonHoc) references MonHoc(ma)
alter table DangKiNhom
add constraint fk_dangkinhom1 foreign key (maDangKi) references DangKiDoAn(ma)
alter table PhuTrach
add constraint fk_phutrach2 foreign key (maGiaoVien) references GiaoVien(ma)
alter table DangKiMonHoc 
add constraint fk_dangkimonhoc2 foreign key (maSinhVien) references SinhVien(ma) 
alter table DangKiDoAn
add constraint kf_dangkidoan1 foreign key (maDoAn) references DoAn(ma)
alter table SinhVien
add constraint kf_SinhVienKhoa foreign key (maKhoa) references Khoa(maKhoa)
alter table GiaoVien
add constraint kf_GiaoVienKhoa foreign key (maKhoa) references Khoa(maKhoa)
alter table GiaoVien
add constraint kf_GiaoVienTrangThai foreign key (TrangThai) references TrangThai(maTrangThai)
alter table SinhVien
add constraint kf_SinhTrangThai foreign key (TrangThai) references TrangThai(maTrangThai)
alter table QuanLy
add constraint kf_QuanLyTrangThai foreign key (TrangThai) references TrangThai(maTrangThai)


--Them sinh vien
create proc insert_sv
@masv varchar(10),
@Hoten varchar(30),
@Tendangnhap varchar(30),
@Matkhau varchar(20),
@Namsinh datetime,
@Gioitinh varchar(10),
@Dantoc varchar(30),
@maLop varchar(10),
@Diachi varchar(10),
@Quyentruycap varchar(10),
@Dienthoai int,
@maQuanLy varchar(10),
@maKhoa varchar(10),
@TrangThai varchar(10)
as
begin
	insert into SinhVien values (@masv,@Hoten,@Tendangnhap,@Matkhau,@Namsinh,@Gioitinh,@Dantoc,@maLop,@Diachi,@Quyentruycap,@Dienthoai,@maQuanLy,@maKhoa,@TrangThai)
end

--update thong tinh sinh vien
create proc update_sv
@masv varchar(10),
@Hoten varchar(30),
@Namsinh datetime,
@Gioitinh varchar(10),
@Dantoc varchar(30),
@maLop varchar(10),
@Diachi varchar(10),
@Dienthoai int,
@maKhoa varchar(10)
as
begin
	update SinhVien set HoTen=@Hoten,@Namsinh=@Namsinh,Gioitinh=@Gioitinh,Dantoc=@Dantoc,maLop=@maLop,Diachi=@Diachi,Dienthoai=@Dienthoai,maKhoa=@maKhoa where ma=@masv
end

--delete sinh vien
create proc deleteHocSinh
@masv varchar(10)
as
begin 
	delete SinhVien where ma=@masv
end

--khoa sinh vien
create proc khoa_sv
@masv varchar(10)
as
begin 
	update SinhVien set TrangThai='0' where ma=@masv
end

--mo khoa sinh vien
create proc mokhoa_sv
@masv varchar(10)
as
begin 
	update SinhVien set TrangThai='1' where ma=@masv
end


--insert giang vien
create proc insert_gv
@masv varchar(10),
@Hoten varchar(30),
@Tendangnhap varchar(30),
@Matkhau varchar(20),
@Namsinh datetime,
@Gioitinh varchar(10),
@Dantoc varchar(30),
@maBoPhan varchar(10),
@Diachi varchar(10),
@Quyentruycap varchar(10),
@Dienthoai int,
@maQuanLy varchar(10),
@maKhoa varchar(10),
@TrangThai varchar(10)
as
begin
	insert into GiaoVien values (@masv,@Hoten,@Tendangnhap,@Matkhau,@Namsinh,@Gioitinh,@Dantoc,@maBoPhan,@Diachi,@Quyentruycap,@Dienthoai,@maQuanLy,@maKhoa,@TrangThai)
end


--update thong tinh giang vien
create proc update_gv
@magv varchar(10),
@Hoten varchar(30),
@Namsinh datetime,
@Gioitinh varchar(10),
@Dantoc varchar(30),
@maBoPhan varchar(10),
@Diachi varchar(10),
@Dienthoai int,
@maKhoa varchar(10)
as
begin
	update GiaoVien set HoTen=@Hoten,@Namsinh=@Namsinh,Gioitinh=@Gioitinh,Dantoc=@Dantoc,maBoPhan=@maBoPhan,Diachi=@Diachi,Dienthoai=@Dienthoai,maKhoa=@maKhoa where ma=@magv
end

--delete giang vien
create proc delete_gv
@magv varchar(10)
as
begin 
	delete GiaoVien where ma=@magv
end


--khoa sinh vien
create proc khoa_gv
@magv varchar(10)
as
begin 
	update GiaoVien set TrangThai='0' where ma=@magv
end

--khoa sinh vien
create proc mokhoa_gv
@magv varchar(10)
as
begin 
	update GiaoVien set TrangThai='1' where ma=@magv
end

--thuc hien capnhattaikhoan_gv
create proc capnhattaikhoan_gv
@magv varchar(10),
@Hoten varchar(30),
@Matkhau varchar(20),
@Diachi varchar(100),
@Dienthoai int
as 
begin
	update GiaoVien set Hoten=@Hoten, Matkhau=@Matkhau, Diachi=@Diachi, Dienthoai=@Dienthoai where ma=@magv
end
--dang ky phu trach mon hoc           
create proc insert_phutrachmonhoc
@magv varchar(10),
@tenmh varchar(10),
@malop varchar(10),
@khoahoc varchar(10)
as 
begin 
	insert into PhuTrach values (@magv,@tenmh,@khoahoc,@malop)
end
--cap nhat dang ky phu trach mon
create proc capnhat_phutrachmonhoc
@magv varchar(10),
@tenmh varchar(10),
@malop varchar(10),
@khoahoc varchar(10)
as 
begin 
	update PhuTrach set maLop=@malop, maKhoaHoc=@khoahoc where maGiaoVien=@magv and maMonHoc=@tenmh 
end

--huy dang ky phu trach mon hoc        
create proc delete_phutrachmonhoc
@magv varchar(10),
@tenmh varchar(10),
@malop varchar(10),
@khoahoc varchar(10)
as 
begin 
	delete PhuTrach where maGiaoVien=@magv and maMonHoc=@tenmh and maLop=@malop and maKhoaHoc=@khoahoc
end

--dang ky mon hoc
create proc insert_dangkymonhoc
@magv varchar(10),
@tenmh varchar(10),
@malop varchar(10),
@khoahoc varchar(10)
as 
begin 
	insert into DangKiMonHoc values (@magv,@tenmh,@khoahoc,@malop)
end

--huy dang ki mon hoc
create proc delete_dangkyhmonhoc
@masv varchar(10),
@tenmh varchar(10),
@khoahoc varchar(10),
@malop varchar(10)
as 
begin
	delete DangKiMonHoc where maSinhVien=@masv and maMonHoc=@tenmh and maKhoaHoc=@khoahoc and maLop=@malop
end

--thuc hien capnhattaikhoan_sv
create proc capnhattaikhoan_sv
@masv varchar(10),
@Hoten varchar(30),
@Matkhau varchar(20),
@Diachi varchar(100),
@Dienthoai int
as 
begin
	update SinhVien set Hoten=@Hoten, Matkhau=@Matkhau, Diachi=@Diachi, Dienthoai=@Dienthoai where ma=@masv
end

--dang mon hoc
create proc dangmonhoc
@ma varchar(10),
@tenMonHoc varchar(30),
@maKhoa varchar(10) 
as
begin
	insert into MonHoc values (@ma,@tenMonHoc,@maKhoa)
end

--update mon hoc
create proc updatemonhoc
@ma varchar(10),
@tenMonHoc varchar(30),
@maKhoa varchar(10) 
as
begin
	update MonHoc set tenMonHoc=@tenMonHoc,maKhoa=@maKhoa where ma=@ma
end

--delete mon hoc
create proc xoamonhoc
@ma varchar(10),
@tenMonHoc varchar(30),
@maKhoa varchar(10) 
as
begin
	delete MonHoc where ma=@ma
end



--them do an
create proc insert_themmonhoc
@ma varchar(30),
@tenDoAn varchar(30),
@ChiTiet varchar(200),
@SoThanhVien int,
@deadline datetime,
@maMonHoc varchar(10),
@maGiangVien varchar(10)
as
begin
	insert into DoAn values (@ma,@tenDoAn,@ChiTiet,@SoThanhVien,@deadline,@maMonHoc,@maGiangVien)
end

--huy mon hoc
create proc delete_themmonhoc
@ma varchar(30),
@maMonHoc varchar(10),
@maGiangVien varchar(10)
as 
begin 
	delete DoAn where ma=@ma and maMonHoc =@maMonHoc and maGiangVien = @maGiangVien 
end


--cap nhat do an mon hoc
create proc capnhat_themmonhoc
@ma varchar(30),
@tenDoAn varchar(30),
@ChiTiet varchar(200),
@SoThanhVien int,
@deadline datetime,
@maMonHoc varchar(10),
@maGiangVien varchar(10)
as
begin
	update DoAn set tenDoAn=@tenDoAn,ChiTiet=@ChiTiet,SoThanhVien=@SoThanhVien,deadline=@deadline where ma=@ma and maMonHoc=@maMonHoc and maGiangVien=@maGiangVien
end

--phan cong phu trach mon hoc           
create proc PhanCong_phutrachmonhoc
@magv varchar(10),
@tenmh varchar(10),
@malop varchar(10),
@khoahoc varchar(10)
as 
begin 
	insert into PhuTrach values (@magv,@tenmh,@khoahoc,@malop)
end
--cap nhat Phan Cong phu trach mon
create proc capnhatPhanCong_phutrachmonhoc
@magv varchar(10),
@tenmh varchar(10),
@malop varchar(10),
@khoahoc varchar(10)
as 
begin 
	update PhuTrach set maLop=@malop, maKhoaHoc=@khoahoc, maGiaoVien=@magv where maMonHoc=@tenmh 
end

--huy Phan Cong phu trach mon hoc        
create proc deletePhanCong_phutrachmonhoc
@magv varchar(10),
@tenmh varchar(10),
@malop varchar(10),
@khoahoc varchar(10)
as 
begin 
	delete PhuTrach where maGiaoVien=@magv and maMonHoc=@tenmh and maLop=@malop and maKhoaHoc=@khoahoc
end
