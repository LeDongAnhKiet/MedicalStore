use QLNT
go 

	--	Nhân viên	--

IF NOT EXISTS (SELECT 1 FROM NhanVien WHERE TaiKhoan = 'Admin1')
Begin
	insert into Nguoi
	values (N'Nguyễn Văn',N'A', '0912345678',N'Là Admin')	
	declare @maNg int;
	set @maNg = SCOPE_IDENTITY();
	insert into NhanVien (MaNg, TaiKhoan, MatKhau, La_Admin)
	select @maNg, 'Admin1', 'admin1', 1

	insert into Nguoi
	values (N'Lê Thành',N'B', '1234567890',N'Là User')
	set @maNg = SCOPE_IDENTITY();
	insert into NhanVien (MaNg, TaiKhoan, MatKhau, La_Admin)
	select @maNg, 'User1', 'user1', 0
End
Go

	--	Loại dược phẩm	--

IF NOT EXISTS (SELECT 1 FROM Loai WHERE TenLoai = 'Kháng sinh')
BEGIN
	insert into Loai values(N'Kháng sinh', N'Điều trị nhiễm trùng do vi khuẩn')
	insert into Loai values(N'Giảm đau', N'Dùng để giảm đau, giảm viêm')
	insert into Loai values(N'Thực phẩm chức năng', N'Bổ sung các chất dinh dưỡng cho cơ thể')
	insert into Loai values(N'Bổ trợ tiêu hóa', N'Giúp cải thiện quá trình tiêu hóa của cơ thể')
	insert into Loai values(N'Giảm dịch mũi', N'Giảm triệu chứng dịch mũi, cảm cúm')
	insert into Loai values(N'Chống dị ứng', N'Giúp ngăn ngừa các triệu chứng dị ứng')
	insert into Loai values(N'Dung dịch vệ sinh', N'Làm sạch và khử trùng các vết thương trên da')
	insert into Loai values(N'Giảm lo âu', N'Giúp giảm triệu chứng lo âu, trầm cảm')
END
GO
	--	Dược phẩm	--

IF NOT EXISTS (SELECT 1 FROM DuocPham WHERE TenDP = 'Paracetamol')
Begin
		declare @ma int;
	insert into DuocPham
	values (N'Paracetamol', N'Bảo quản nơi khô ráo, thoáng mát. Được sử dụng rộng rãi trong các bệnh viêm, hạ sốt')	
	set @ma = SCOPE_IDENTITY();
	insert into ChiTietDP(MaDP, MaLoai, HanSuDung, SoLuong, DonGia)
	select @ma, 2, '2023-06-30', 500, 10000

	insert into DuocPham
	values (N'Augmentin', N'Phải được sử dụng dưới sự giám sát của bác sĩ')
	set @ma = SCOPE_IDENTITY();
	insert into ChiTietDP(MaDP, MaLoai, HanSuDung, SoLuong, DonGia)
	select @ma, 1, '2022-06-30', 20, 50000

	insert into DuocPham
	values (N'Ibuprofen', N'Nên dùng sau khi ăn để giảm tác dụng phụ đến dạ dày, hạ sốt. Không uống khi đang dùng thuốc khác')
	set @ma = SCOPE_IDENTITY();
	insert into ChiTietDP(MaDP, MaLoai, HanSuDung, SoLuong, DonGia)
	select @ma, 2, '2024-07-01', 90, 20000

	insert into DuocPham
	values (N'Domperidone', N'Nên uống trước khi ăn. Điều trị rối loạn tiêu hóa như buồn nôn, khó tiêu, trào ngược dạ dày thực quản')
	set @ma = SCOPE_IDENTITY();
	insert into ChiTietDP(MaDP, MaLoai, HanSuDung, SoLuong, DonGia)
	select @ma, 4, '2023-06-30', 50, 20000
	insert into DuocPham
	values (N'Paroxetine', N'Không được sử dụng trong thai kỳ và cho con bú')
	set @ma = SCOPE_IDENTITY();
	insert into ChiTietDP(MaDP, MaLoai, HanSuDung, SoLuong, DonGia)
	select @ma, 8, '2022-06-20', 30, 35000
		insert into DuocPham
	values (N'Mefenamic acid', N'Không nên dùng quá 7 ngày liên tiếp')
	set @ma = SCOPE_IDENTITY();
	insert into ChiTietDP(MaDP, MaLoai, HanSuDung, SoLuong, DonGia)
	select @ma, 2, '2022-10-05', 70, 18000
		insert into DuocPham
	values (N'Azithromycin', N'Dùng cho nhiễm khuẩn hô hấp, nhiễm khuẩn tai mũi họng, viêm phổi, viêm họng và nhiễm khuẩn sinh dục')
	set @ma = SCOPE_IDENTITY();
	insert into ChiTietDP(MaDP, MaLoai, HanSuDung, SoLuong, DonGia)
	select @ma, 1, '2025-12-30', 50, 22100
		insert into DuocPham
	values (N'Omeprazole', N'Điều trị loét dạ dày tá tràng, viêm dạ dày tá tràng. Không nên dùng quá liều lượng đề ra')
	set @ma = SCOPE_IDENTITY();
	insert into ChiTietDP(MaDP, MaLoai, HanSuDung, SoLuong, DonGia)
	select @ma, 4, '2023-06-30', 80, 25000
			insert into DuocPham
	values (N'Aspirin', N'Không nên dùng cho người có vấn đề về dạ dày')
	set @ma = SCOPE_IDENTITY();
	insert into ChiTietDP(MaDP, MaLoai, HanSuDung, SoLuong, DonGia)
	select @ma, 2, '2023-08-31', 120, 10000
		insert into DuocPham
	values (N'Panadol', N'Không dùng quá liều lượng chỉ định')
	set @ma = SCOPE_IDENTITY();
	insert into ChiTietDP(MaDP, MaLoai, HanSuDung, SoLuong, DonGia)
	select @ma, 2, '2023-05-31', 50, 20000
	insert into DuocPham
	values (N'Amoxicillin', N'Dùng cho viêm họng, nhiễm khuẩn đường tiết niệu, nhiễm khuẩn tai mũi họng, viêm phổi, viêm ruột, viêm da')
	set @ma = SCOPE_IDENTITY();
	insert into ChiTietDP(MaDP, MaLoai, HanSuDung, SoLuong, DonGia)
	select @ma, 1, '2024-08-15', 60, 20500
		insert into DuocPham
	values (N'Strepsils', N'Không sử dụng quá 2 ngày liên tiếp, giảm đau họng')
	set @ma = SCOPE_IDENTITY();
	insert into ChiTietDP(MaDP, MaLoai, HanSuDung, SoLuong, DonGia)
	select @ma, 2, '2023-11-30', 24, 25000
	insert into DuocPham
	values (N'Diclofenac', N'Không dùng quá liều lượng')
	set @ma = SCOPE_IDENTITY();
	insert into ChiTietDP(MaDP, MaLoai, HanSuDung, SoLuong, DonGia)
	select @ma, 2, '2023-09-23', 50, 20000
	insert into DuocPham
	values (N'Diphenhydramine', N'Cần chú ý đến tác dụng phụ gây buồn ngủ')
	set @ma = SCOPE_IDENTITY();
	insert into ChiTietDP(MaDP, MaLoai, HanSuDung, SoLuong, DonGia)
	select @ma, 8, '2023-04-30', 200, 12000
	insert into DuocPham
	values (N'Ranitidine', N'Nên dùng trước khi ăn 30 phút để đạt hiệu quả tốt nhất')
	set @ma = SCOPE_IDENTITY();
	insert into ChiTietDP(MaDP, MaLoai, HanSuDung, SoLuong, DonGia)
	select @ma, 8, '2022-12-31', 120, 18000
		insert into DuocPham
	values (N'Ciprofloxacin', N'Dùng cho nhiễm khuẩn đường tiết niệu, nhiễm khuẩn ruột, nhiễm khuẩn hô hấp, viêm xoang và nhiễm khuẩn da')
	set @ma = SCOPE_IDENTITY();
	insert into ChiTietDP(MaDP, MaLoai, HanSuDung, SoLuong, DonGia)
	select @ma, 1, '2024-01-01', 30, 35200
		insert into DuocPham
	values (N'Clarithromycin', N'Dùng cho viêm họng, viêm xoang, viêm phổi, nhiễm khuẩn da và nhiễm khuẩn dạ dày tá tràng.Có thể gây tác dụng phụ trên tiêu hóa và gan.')
	set @ma = SCOPE_IDENTITY();
	insert into ChiTietDP(MaDP, MaLoai, HanSuDung, SoLuong, DonGia)
	select @ma, 1, '2025-12-31', 40, 18300
		insert into DuocPham
	values (N'Doxycycline', N'Dùng cho nhiễm khuẩn đường tiết niệu, viêm họng, viêm phổi, nhiễm khuẩn da và bệnh Lyme. Nên dùng sau khi ăn, không nên dùng cho trẻ em dưới 8 tuổi')
	set @ma = SCOPE_IDENTITY();
	insert into ChiTietDP(MaDP, MaLoai, HanSuDung, SoLuong, DonGia)
	select @ma, 1, '2024-02-28', 60, 12800
			insert into DuocPham
	values (N'Gaviscon', N'Giảm triệu chứng trào ngược dạ dày thực quản.Không dùng quá liều lượng chỉ định')
	set @ma = SCOPE_IDENTITY();
	insert into ChiTietDP(MaDP, MaLoai, HanSuDung, SoLuong, DonGia)
	select @ma, 4, '2023-09-15', 20, 50000
		insert into DuocPham
	values (N'BioGaia', N'Chứa vi khuẩn đường ruột có lợi giúp cân bằng hệ vi sinh đường ruột.Bảo quản ở nơi khô ráo, tránh ánh nắng mặt trời')
	set @ma = SCOPE_IDENTITY();
	insert into ChiTietDP(MaDP, MaLoai, HanSuDung, SoLuong, DonGia)
	select @ma, 4, '2024-06-30', 30, 200000
		insert into DuocPham
	values (N'Puritans Pride 500mg', N'Hỗ trợ làm chậm dấu hiệu tuổi tác ở trên da và Hỗ trợ cải thiện các vấn đề liên quan tới mụn trên da mặt')
	set @ma = SCOPE_IDENTITY();
	insert into ChiTietDP(MaDP, MaLoai, HanSuDung, SoLuong, DonGia)
	select @ma, 3, '2025-01-01', 20, 242000
		insert into DuocPham
	values (N'Vitamin E 400 IU Kirkland', N'Hỗ trợ bổ sung thêm nhiều dưỡng chất quý hiếm, có hiệu quả tốt trong việc hỗ trợ làm đẹp da, giúp bạn có làn da khỏe, mịn màng')
	set @ma = SCOPE_IDENTITY();
	insert into ChiTietDP(MaDP, MaLoai, HanSuDung, SoLuong, DonGia)
	select @ma, 3, '2024-12-31', 20, 378000
			insert into DuocPham
	values (N'Vitamin C 1000mg Kirkland', N'Bổ sung vitamin C giúp hỗ trợ tăng cường hệ miễn dịch, hỗ trợ thúc đẩy sự hình thành collagen, hỗ trợ bài tiết chất độc khỏi cơ thể')
	set @ma = SCOPE_IDENTITY();
	insert into ChiTietDP(MaDP, MaLoai, HanSuDung, SoLuong, DonGia)
	select @ma, 3, '2025-12-31', 20, 430000
		insert into DuocPham
	values (N'WellVita E 400IU', N'Hỗ trợ dưỡng ẩm, tái tạo sự đàn hồi và ngăn ngừa sự xuất hiện của các dấu hiệu tuổi tác trên da, giúp cân bằng nội tiết tố nữ hiệu quả')
	set @ma = SCOPE_IDENTITY();
	insert into ChiTietDP(MaDP, MaLoai, HanSuDung, SoLuong, DonGia)
	select @ma, 3, '2025-12-31', 20, 305000
			insert into DuocPham
	values (N'Clorpheniramin 4mg', N'Có thể gây ra một số tác dụng phụ như: chóng mặt, buồn ngủ, khô miệng. Không được dùng quá liều')
	set @ma = SCOPE_IDENTITY();
	insert into ChiTietDP(MaDP, MaLoai, HanSuDung, SoLuong, DonGia)
	select @ma, 5, '2024-01-01', 20, 20000
	insert into DuocPham
	values (N'Hadocolcen', N'Có thể gây ra một số tác dụng phụ như: chóng mặt, buồn ngủ, khô miệng. Không được dùng quá liều')
	set @ma = SCOPE_IDENTITY();
	insert into ChiTietDP(MaDP, MaLoai, HanSuDung, SoLuong, DonGia)
	select @ma, 5, '2024-12-31', 20, 23000
	insert into DuocPham
	values (N'Otrivin', N'Có thể gây ra một số tác dụng phụ như: khô mũi, đau đầu ,buồn nôn. Không được dùng quá liều')
	set @ma = SCOPE_IDENTITY();
	insert into ChiTietDP(MaDP, MaLoai, HanSuDung, SoLuong, DonGia)
	select @ma, 5, '2024-12-31', 50, 56000
	insert into DuocPham
	values (N'Sinuflex D', N'có thể gây ra một số tác dụng phụ như: khô mũi,đau đầu ,buồn nôn. Không được dùng quá liều')
	set @ma = SCOPE_IDENTITY();
	insert into ChiTietDP(MaDP, MaLoai, HanSuDung, SoLuong, DonGia)
	select @ma, 5, '2025-10-19', 30, 33000
		insert into DuocPham
	values (N'cetirizin', N'Không được dùng quá liều')
	set @ma = SCOPE_IDENTITY();
	insert into ChiTietDP(MaDP, MaLoai, HanSuDung, SoLuong, DonGia)
	select @ma, 6, '2025-12-24', 50, 22000

		insert into DuocPham
	values (N'Loratadin', N'Không được dùng quá liều')
	set @ma = SCOPE_IDENTITY();
	insert into ChiTietDP(MaDP, MaLoai, HanSuDung, SoLuong, DonGia)
	select @ma, 6, '2024-11-13', 20, 15000
		insert into DuocPham
	values (N' Fexofenadin 60', N'Có thể gây ra một số tác dụng phụ như:nôn mửa,khô miệng')
	set @ma = SCOPE_IDENTITY();
	insert into ChiTietDP(MaDP, MaLoai, HanSuDung, SoLuong, DonGia)
	select @ma, 6, '2025-12-15', 25, 80000
	insert into DuocPham
	values (N'Prednison 5 mg', N'Có thể gây ra mất ngủ,thần kinh dễ kích động,khó tiêu')
	set @ma = SCOPE_IDENTITY();
	insert into ChiTietDP(MaDP, MaLoai, HanSuDung, SoLuong, DonGia)
	select @ma, 6, '2024-12-30', 20, 49000
		insert into DuocPham
	values (N'Lactacyd', N'')
	set @ma = SCOPE_IDENTITY();
	insert into ChiTietDP(MaDP, MaLoai, HanSuDung, SoLuong, DonGia)
	select @ma, 7, '2025-12-31', 20, 77000
		insert into DuocPham
	values (N'Crevil Intim Waschlotion', N'')
	set @ma = SCOPE_IDENTITY();
	insert into ChiTietDP(MaDP, MaLoai, HanSuDung, SoLuong, DonGia)
	select @ma, 7, '2025-12-31', 20, 120000
			insert into DuocPham
	values (N'Serenys', N'')
	set @ma = SCOPE_IDENTITY();
	insert into ChiTietDP(MaDP, MaLoai, HanSuDung, SoLuong, DonGia)
	select @ma, 7, '2025-12-31', 15, 100000
			insert into DuocPham
	values (N'Oriss Men', N'')
	set @ma = SCOPE_IDENTITY();
	insert into ChiTietDP(MaDP, MaLoai, HanSuDung, SoLuong, DonGia)
	select @ma, 7, '2025-12-31', 15, 99000
	insert into DuocPham
	values (N'Haloperidol', N'Dùng theo chỉ định của bác sĩ')
	set @ma = SCOPE_IDENTITY();
	insert into ChiTietDP(MaDP, MaLoai, HanSuDung, SoLuong, DonGia)
	select @ma, 8, '2025-12-31', 25, 95000
		insert into DuocPham
	values (N'Medi-Paroxetin', N'Tác dụng không mong muốn trên hệ thần kinh: buồn ngủ, hoa mắt, chóng mặt, suy nhược cơ thể, suy giảm thị lực')
	set @ma = SCOPE_IDENTITY();
	insert into ChiTietDP(MaDP, MaLoai, HanSuDung, SoLuong, DonGia)
	select @ma, 8, '2025-12-31', 20, 195000
		insert into DuocPham
	values (N'Xalexa 30mg', N'Thận trọng khi dùng cho bệnh nhân tim mạch, động kinh')
	set @ma = SCOPE_IDENTITY();
	insert into ChiTietDP(MaDP, MaLoai, HanSuDung, SoLuong, DonGia)
	select @ma, 8, '2025-12-31', 20, 220000
	insert into DuocPham
	values (N'Sumiko', N'dùng theo chỉ định của bác sĩ')
	set @ma = SCOPE_IDENTITY();
	insert into ChiTietDP(MaDP, MaLoai, HanSuDung, SoLuong, DonGia)
	select @ma, 8, '2025-12-31', 15, 300000
End
Go

	--	DBCC CHECKIDENT(DuocPham, RESEED, 0)