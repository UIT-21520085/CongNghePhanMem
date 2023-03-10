use DKMHandTHUHP
set dateformat dmy

select * from KHOA
insert into KHOA values
('K001',N'Khoa học máy tính'),
('K002',N'Khoa học và kỹ thuật thông tin'),
('K003',N'Kỹ thuật máy tính'),
('K004',N'Công nghệ phần mềm'),
('K005',N'Hệ thống thông tin'),
('K006',N'Mạng máy tính và truyền thông')

SELECT * FROM NGANH
insert into NGANH values
('N001',N'Khoa học máy tính', 'K001'),
('N002',N'Trí tuệ nhân tạo', 'K001'),
('N003',N'Công nghệ thông tin', 'K002'),
('N004',N'Khoa học dữ liệu', 'K002'),
('N005',N'Kỹ thuật máy tính', 'K003'),
('N007',N'Kỹ thuật phần mềm', 'K004'),
('N009',N'Hệ thống thông tin', 'K005'),
('N010',N'Thương mại điện tử', 'K005'),
('N011',N'An toàn thông tin', 'K006'),
('N012',N'Mạng máy tính và truyền thông', 'K006')

SELECT * FROM DTUT
insert into DTUT values
(0, N'Không', 0.0),
(1, N'Con thương binh', 0.5),
(2, N'Con liệt sĩ', 0.8),
(3, N'Hộ nghèo', 0.8),
(4, N'Hộ cận nghèo', 0.5),
(5, N'Vùng sâu', 0.5),
(6, N'Vùng xa', 0.5)

SELECT * FROM LOGIN_PDT
insert into LOGIN_PDT values
('admin', 'admin')

SELECT * FROM TINCHI
insert into TINCHI values
('LT', 15, 27000),
('TH', 30, 37000)

SELECT * FROM DSMH
insert into DSMH values
('M001', N'Nhập môn lập trình', 'LT', 45, null, 'K001'),
('M002', N'Nhập môn lập trình (TH)', 'TH', 30, null, 'K001'),
('M003', N'Lập trình hướng đối tượng', 'LT', 45, null, 'K004'),
('M004', N'Lập trình hướng đối tượng (TH)', 'TH', 30, null, 'K004'),
('M005', N'Cơ sở dữ liệu', 'LT', 45, null, 'K005'),
('M006', N'Cơ sở dữ liệu (TH)', 'TH', 30, null, 'K005')

delete from hocky
SELECT * FROM HOCKY
INSERT INTO HOCKY VALUES
(2, 2021, '5/9/2021', '31/12/2021', '30/12/2021'),
(1, 2021, '2/1/2021', '30/6/2021', '29/6/2021'),
(2, 2022, '5/9/2022', '31/12/2022', '30/12/2022'),
(1, 2022, '2/1/2022', '30/6/2022', '29/6/2022')

SELECT * FROM DSMH_Mo
insert into DSMH_Mo values
(1, 2021, 'M001'),
(1, 2021, 'M002'),
(2, 2021, 'M003'),
(2, 2021, 'M004'),
(1, 2022, 'M005'),
(1, 2022, 'M006')

SELECT * FROM CTHOC
INSERT INTO CTHOC VALUES
(1, 2021, 'M001', 'N001', 'K001', N'Môn này rất quan trọng'),
(1, 2021, 'M002', 'N001', 'K001', N'Học mà không hành thì ăn shit'),
(2, 2021, 'M003', 'N007', 'K004', N''),
(2, 2021, 'M004', 'N007', 'K004', N''),
(1, 2022, 'M005', 'N009', 'K005', N' '),
(1, 2022, 'M006', 'N009', 'K005', N' ')

SELECT * FROM TINH
insert into TINH values
('T001',N'An Giang'),
('T002',N'Bà Rịa – Vũng Tàu'),
('T003',N'Bạc Liêu'),
('T004',N'Bắc Giang'),
('T005',N'Bắc Kạn'),
('T006',N'Bắc Ninh'),
('T007',N'Bến Tre'),
('T008',N'Bình Dương'),
('T009',N'Bình Định'),
('T010',N'Bình Phước'),
('T011',N'Bình Thuận'),
('T012',N'Cà Mau'),
('T013',N'Cao Bằng'),
('T014',N'Cần Thơ'),
('T015',N'Đà Nẵng'),
('T016',N'Đắk Lắk'),
('T017',N'Đắk Nông'),
('T018',N'Điện Biên'),
('T019',N'Đồng Nai'),
('T020',N'Đồng Tháp'),
('T021',N'Gia Lai'),
('T022',N'Hà Giang'),
('T023',N'Hà Nam'),
('T024',N'Hà Nội'),
('T025',N'Hà Tĩnh'),
('T026',N'Hải Dương'),
('T027',N'Hải Phòng'),
('T028',N'Hậu Giang'),
('T029',N'Hòa Bình'),
('T030',N'TP Hồ Chí Minh'),
('T031',N'Hưng Yên'),
('T032',N'Khánh Hòa'),
('T033',N'Kiên Giang'),
('T034',N'Kon Tum'),
('T035',N'Lai Châu'),
('T036',N'Lạng Sơn'),
('T037',N'Lào Cai'),
('T038',N'Lâm Đồng'),
('T039',N'Long An'),
('T040',N'Nam Định'),
('T041',N'Nghệ An'),
('T042',N'Ninh Bình'),
('T043',N'Ninh Thuận'),
('T044',N'Phú Thọ'),
('T045',N'Phú Yên'),
('T046',N'Quảng Bình'),
('T047',N'Quảng Nam'),
('T048',N'Quảng Ngãi'),
('T049',N'Quảng Ninh'),
('T050',N'Quảng Trị'),
('T051',N'Sóc Trăng'),
('T052',N'Sơn La'),
('T053',N'Tây Ninh'),
('T054',N'Thái Bình'),
('T055',N'Thái Nguyên'),
('T056',N'Thanh Hóa'),
('T057',N'Thừa Thiên Huế'),
('T058',N'Tiền Giang'),
('T059',N'Trà Vinh'),
('T060',N'Tuyên Quang'),
('T061',N'Vĩnh Long'),
('T062',N'Vĩnh Phúc'),
('T063',N'Yên Bái')

SELECT * FROM HUYEN
insert into HUYEN values
('H001','T057','A Lưới',0,0),
('H002','T033','An Biên',0,0),
('H003','T027','An Dương',0,0),
('H004','T021','An Khê',0,0),
('H005','T027','An Lão',0,1),
('H006','T009','An Lão',0,1),
('H007','T033','An Minh',0,0),
('H008','T009','An Nhơn',0,0),
('H009','T001','An Phú',0,0),
('H010','T031','Ân Thi',0,0),
('H011','T041','Anh Sơn',0,0),
('H012','T021','Ayun Pa',0,0),
('H013','T005','Ba Bể',0,0),
('H014','T049','Ba Chẽ',0,0),
('H015','T024','Ba Đình',0,0),
('H016','T046','Ba Đồn',0,0),
('H017','T002','Bà Rịa',0,0),
('H018','T056','Bá Thước',0,0),
('H019','T048','Ba Tơ',0,1),
('H020','T007','Ba Tri',0,0),
('H021','T024','Ba Vì',0,0),
('H022','T043','Bác Ái',0,1),
('H023','T011','Bắc Bình',0,0),
('H024','T004','Bắc Giang',0,0),
('H025','T037','Bắc Hà',0,1),
('H026','T005','Bắc Kạn',0,0),
('H027','T003','Bạc Liêu',0,0),
('H028','T022','Bắc Mê',0,0),
('H029','T006','Bắc Ninh',0,0),
('H030','T022','Bắc Quang',0,0),
('H031','T036','Bắc Sơn',0,0),
('H032','T008','Bắc Tân Uyên',0,0),
('H033','T047','Bắc Trà My',0,0),
('H034','T024','Bắc Từ Liêm',0,0),
('H035','T052','Bắc Yên',0,0),
('H036','T027','Bạch Long Vĩ',0,0),
('H037','T005','Bạch Thông',0,0),
('H038','T013','Bảo Lạc',0,1),
('H039','T013','Bảo Lâm',0,1),
('H040','T038','Bảo Lâm',0,1),
('H041','T038','Bảo Lộc',0,0),
('H042','T037','Bảo Thắng',0,0),
('H043','T037','Bảo Yên',0,0),
('H044','T037','Bát Xát',0,0),
('H045','T008','Bàu Bàng',0,0),
('H046','T008','Bến Cát',0,0),
('H047','T053','Bến Cầu',0,0),
('H048','T039','Bến Lức',0,0),
('H049','T007','Bến Tre',0,0),
('H050','T019','Biên Hòa',0,0),
('H051','T056','Bỉm Sơn',0,0),
('H052','T030','Bình Chánh',0,0),
('H053','T007','Bình Đại',0,0),
('H054','T036','Bình Gia',1,0),
('H055','T026','Bình Giang',0,0),
('H056','T049','Bình Liêu',0,0),
('H057','T010','Bình Long',0,0),
('H058','T023','Bình Lục',0,0),
('H059','T061','Bình Minh',0,0),
('H060','T048','Bình Sơn',0,0),
('H061','T030','Bình Tân',0,0),
('H062','T061','Bình Tân',0,0),
('H063','T030','Bình Thạnh',0,0),
('H064','T014','Bình Thủy',0,0),
('H065','T062','Bình Xuyên',0,0),
('H066','T046','Bố Trạch',0,0),
('H067','T010','Bù Đăng',0,0),
('H068','T010','Bù Đốp',0,0),
('H069','T010','Bù Gia Mập',0,0),
('H070','T016','Buôn Đôn',0,0),
('H071','T016','Buôn Hồ',0,0),
('H072','T016','Buôn Ma Thuột',0,0),
('H073','T012','Cà Mau',0,0),
('H074','T058','Cái Bè',0,0),
('H075','T058','Cai Lậy',0,0),
('H076','T058','Cai Lậy',0,0),
('H077','T012','Cái Nước',0,0),
('H078','T014','Cái Răng',0,0),
('H079','T026','Cẩm Giàng',0,0),
('H080','T044','Cẩm Khê',0,0),
('H081','T032','Cam Lâm',0,0),
('H082','T015','Cẩm Lệ',0,0),
('H083','T050','Cam Lộ',0,0),
('H084','T019','Cẩm Mỹ',0,0),
('H085','T049','Cẩm Phả',0,0),
('H086','T032','Cam Ranh',0,0),
('H087','T056','Cẩm Thủy',0,0),
('H088','T025','Cẩm Xuyên',0,0),
('H089','T039','Cần Đước',0,0),
('H090','T030','Cần Giờ',0,0),
('H091','T039','Cần Giuộc',0,0),
('H092','T025','Can Lộc',0,0),
('H093','T059','Càng Long',0,0),
('H094','T013','Cao Bằng',0,0),
('H095','T020','Cao Lãnh',0,0),
('H096','T020','Cao Lãnh',0,0),
('H097','T036','Cao Lộc',0,0),
('H098','T029','Cao Phong',0,0),
('H099','T027','Cát Hải',0,0),
('H100','T038','Cát Tiên',0,0),
('H101','T024','Cầu Giấy',0,0),
('H102','T059','Cầu Kè',0,0),
('H103','T059','Cầu Ngang',0,0),
('H104','T001','Châu Đốc',0,0),
('H105','T002','Châu Đức',0,0),
('H106','T001','Châu Phú',0,0),
('H107','T001','Châu Thành',0,0),
('H108','T007','Châu Thành',0,0),
('H109','T020','Châu Thành',0,0),
('H110','T028','Châu Thành',0,0),
('H111','T033','Châu Thành',0,0),
('H112','T039','Châu Thành',0,0),
('H113','T051','Châu Thành',0,0),
('H114','T053','Châu Thành',0,0),
('H115','T058','Châu Thành',0,0),
('H116','T059','Châu Thành',0,0),
('H117','T028','Châu Thành A',0,0),
('H118','T036','Chi Lăng',0,0),
('H119','T026','Chí Linh',0,0),
('H120','T060','Chiêm Hóa',0,0),
('H121','T005','Chợ Đồn',0,0),
('H122','T058','Chợ Gạo',0,0),
('H123','T007','Chợ Lách',0,0),
('H124','T001','Chợ Mới',0,0),
('H125','T005','Chợ Mới',0,0),
('H126','T010','Chơn Thành',0,0),
('H127','T021','Chư Păh',0,0),
('H128','T021','Chư Prông',0,0),
('H129','T021','Chư Pưh',0,0),
('H130','T021','Chư Sê',0,0),
('H131','T024','Chương Mỹ',0,0),
('H132','T014','Cờ Đỏ',0,0),
('H133','T049','Cô Tô',0,0),
('H134','T050','Cồn Cỏ',0,0),
('H135','T041','Con Cuông',0,0),
('H136','T002','Côn Đảo',0,0),
('H137','T030','Củ Chi',0,0),
('H138','T017','Cư Jút',0,0),
('H139','T016','Cư Kuin',0,0),
('H140','T051','Cù Lao Dung',0,0),
('H141','T016','Cư Mgar',0,0),
('H142','T041','Cửa Lò',0,0),
('H143','T029','Đà Bắc',1,0),
('H144','T038','Đạ Huoai',0,0),
('H145','T050','Đakrông',1,0),
('H146','T038','Đà Lạt',0,0),
('H147','T038','Đạ Tẻh',0,0),
('H148','T047','Đại Lộc',0,0),
('H149','T055','Đại Từ',0,0),
('H150','T021','Đak Đoa',0,0),
('H151','T034','Đăk Glei',0,0),
('H152','T017','Đắk Glong',0,0),
('H153','T034','Đăk Hà',0,0),
('H154','T017','Đắk Mil',0,0),
('H155','T021','Đak Pơ',0,0),
('H156','T017','Đắk Rlấp',0,0),
('H157','T017','Đắk Song',0,0),
('H158','T034','Đăk Tô',0,0),
('H159','T012','Đầm Dơi',0,0),
('H160','T049','Đầm Hà',0,0),
('H161','T038','Đam Rông',1,0),
('H162','T024','Đan Phượng',0,0),
('H163','T002','Đất Đỏ',0,0),
('H164','T008','Dầu Tiếng',0,0),
('H165','T008','Dĩ An',0,0),
('H166','T038','Di Linh',0,0),
('H167','T047','Điện Bàn',0,0),
('H168','T018','Điện Biên',0,0),
('H169','T018','Điện Biên Đông',0,1),
('H170','T018','Điện Biên Phủ',0,0),
('H171','T041','Diễn Châu',0,0),
('H172','T032','Diên Khánh',0,0),
('H173','T055','Định Hóa',0,0),
('H174','T036','Đình Lập',0,0),
('H175','T019','Định Quán',0,0),
('H176','T041','Đô Lương',0,0),
('H177','T027','Đồ Sơn',0,0),
('H178','T044','Đoan Hùng',0,0),
('H179','T038','Đơn Dương',0,0),
('H180','T024','Đông Anh',0,0),
('H181','T024','Đống Đa',0,0),
('H182','T047','Đông Giang',0,0),
('H183','T050','Đông Hà',0,0),
('H184','T003','Đông Hải',0,0),
('H185','T045','Đông Hòa',0,0),
('H186','T046','Đồng Hới',0,0),
('H187','T054','Đông Hưng',0,0),
('H188','T055','Đồng Hỷ',0,0),
('H189','T010','Đồng Phú',0,0),
('H190','T056','Đông Sơn',0,0),
('H191','T049','Đông Triều',0,0),
('H192','T022','Đồng Văn',0,1),
('H193','T010','Đồng Xoài',0,0),
('H194','T045','Đồng Xuân',0,0),
('H195','T021','Đức Cơ',0,0),
('H196','T039','Đức Hòa',0,0),
('H197','T039','Đức Huệ',0,0),
('H198','T011','Đức Linh',0,0),
('H199','T048','Đức Phổ',0,0),
('H200','T025','Đức Thọ',0,0),
('H201','T038','Đức Trọng',0,0),
('H202','T027','Dương Kinh',0,0),
('H203','T053','Dương Minh Châu',0,0),
('H204','T023','Duy Tiên',0,0),
('H205','T047','Duy Xuyên',0,0),
('H206','T059','Duyên Hải',0,0),
('H207','T059','Duyên Hải',0,0),
('H208','T016','Ea Hleo',0,0),
('H209','T016','Ea Kar',0,0),
('H210','T016','Ea Súp',0,0),
('H211','T006','Gia Bình',0,0),
('H212','T024','Gia Lâm',0,0),
('H213','T026','Gia Lộc',0,0),
('H214','T017','Gia Nghĩa',0,0),
('H215','T003','Giá Rai',0,0),
('H216','T042','Gia Viễn',0,0),
('H217','T033','Giang Thành',0,0),
('H218','T040','Giao Thủy',0,0),
('H219','T050','Gio Linh',0,0),
('H220','T033','Giồng Riềng',0,0),
('H221','T007','Giồng Trôm',0,0),
('H222','T058','Gò Công',0,0),
('H223','T058','Gò Công Đông',0,0),
('H224','T058','Gò Công Tây',0,0),
('H225','T053','Gò Dầu',0,0),
('H226','T033','Gò Quao',0,0),
('H227','T030','Gò Vấp',0,0),
('H228','T024','Hà Đông',0,0),
('H229','T022','Hà Giang',0,0),
('H230','T044','Hạ Hòa',0,0),
('H231','T013','Hạ Lang',0,1),
('H232','T049','Hạ Long',0,0),
('H233','T013','Hà Quảng',1,0),
('H234','T033','Hà Tiên',0,0),
('H235','T025','Hà Tĩnh',0,0),
('H236','T056','Hà Trung',0,0),
('H237','T027','Hải An',0,0),
('H238','T024','Hai Bà Trưng',0,0),
('H239','T015','Hải Châu',0,0),
('H240','T026','Hải Dương',0,0),
('H241','T049','Hải Hà',0,0),
('H242','T040','Hải Hậu',0,0),
('H243','T050','Hải Lăng',0,0),
('H244','T011','Hàm Tân',0,0),
('H245','T011','Hàm Thuận Bắc',0,0),
('H246','T011','Hàm Thuận Nam',0,0),
('H247','T060','Hàm Yên',0,0),
('H248','T056','Hậu Lộc',0,0),
('H249','T047','Hiệp Đức',0,0),
('H250','T004','Hiệp Hòa',0,0),
('H251','T013','Hòa An',0,0),
('H252','T029','Hòa Bình',0,0),
('H253','T003','Hòa Bình',0,0),
('H254','T042','Hoa Lư',0,0),
('H255','T053','Hòa Thành',0,0),
('H256','T015','Hòa Vang',0,0),
('H257','T009','Hoài Ân',0,0),
('H258','T024','Hoài Đức',0,0),
('H259','T009','Hoài Nhơn',0,0),
('H260','T024','Hoàn Kiếm',0,0),
('H261','T056','Hoằng Hóa',0,0),
('H262','T024','Hoàng Mai',0,0),
('H263','T041','Hoàng Mai',0,0),
('H264','T015','Hoàng Sa',0,0),
('H265','T022','Hoàng Su Phì',1,0),
('H266','T030','Hóc Môn',0,0),
('H267','T047','Hội An',0,0),
('H268','T033','Hòn Đất',0,0),
('H269','T010','Hớn Quản',0,0),
('H270','T027','Hồng Bàng',0,0),
('H271','T003','Hồng Dân',0,0),
('H272','T025','Hồng Lĩnh',0,0),
('H273','T020','Hồng Ngự',0,0),
('H274','T020','Hồng Ngự',0,0),
('H275','T057','Huế',0,0),
('H276','T054','Hưng Hà',0,0),
('H277','T041','Hưng Nguyên',0,0),
('H278','T031','Hưng Yên',0,0),
('H279','T050','Hướng Hóa',0,0),
('H280','T025','Hương Khê',0,0),
('H281','T025','Hương Sơn',0,0),
('H282','T057','Hương Thủy',0,0),
('H283','T057','Hương Trà',0,0),
('H284','T036','Hữu Lũng',0,0),
('H285','T021','Ia Grai',0,0),
('H286','T034','Ia HDrai',0,0),
('H287','T021','Ia Pa',0,0),
('H288','T021','Kbang',0,0),
('H289','T051','Kế Sách',0,0),
('H290','T032','Khánh Sơn',1,0),
('H291','T032','Khánh Vĩnh',0,1),
('H292','T031','Khoái Châu',0,0),
('H293','T027','Kiến An',0,0),
('H294','T033','Kiên Hải',0,0),
('H295','T033','Kiên Lương',0,0),
('H296','T027','Kiến Thụy',0,0),
('H297','T039','Kiến Tường',0,0),
('H298','T054','Kiến Xương',0,0),
('H299','T023','Kim Bảng',0,0),
('H300','T029','Kim Bôi',0,0),
('H301','T031','Kim Động',0,0),
('H302','T042','Kim Sơn',0,0),
('H303','T026','Kim Thành',0,0),
('H304','T026','Kinh Môn',0,0),
('H305','T034','Kon Plông',1,0),
('H306','T034','Kon Rẫy',0,0),
('H307','T034','Kon Tum',0,0),
('H308','T021','Kông Chro',0,0),
('H309','T016','Krông Ana',0,0),
('H310','T016','Krông Bông',0,0),
('H311','T016','Krông Búk',0,0),
('H312','T016','Krông Năng',0,0),
('H313','T017','Krông Nô',0,0),
('H314','T021','Krông Pa',0,0),
('H315','T016','Krông Pắc',0,0),
('H316','T025','Kỳ Anh',0,0),
('H317','T025','Kỳ Anh',0,0),
('H318','T041','Kỳ Sơn',1,0),
('H319','T011','La Gi',0,0),
('H320','T038','Lạc Dương',0,0),
('H321','T029','Lạc Sơn',0,0),
('H322','T029','Lạc Thủy',0,0),
('H323','T035','Lai Châu',0,0),
('H324','T020','Lai Vung',0,0),
('H325','T016','Lắk',0,0),
('H326','T060','Lâm Bình',0,0),
('H327','T038','Lâm Hà',0,0),
('H328','T044','Lâm Thao',0,0),
('H329','T056','Lang Chánh',0,0),
('H330','T004','Lạng Giang',0,0),
('H331','T036','Lạng Sơn',0,0),
('H332','T037','Lào Cai',0,0),
('H333','T062','Lập Thạch',0,0),
('H334','T020','Lấp Vò',0,0),
('H335','T027','Lê Chân',0,0),
('H336','T046','Lệ Thủy',0,0),
('H337','T015','Liên Chiểu',0,0),
('H338','T036','Lộc Bình',0,0),
('H339','T025','Lộc Hà',0,0),
('H340','T010','Lộc Ninh',0,0),
('H341','T024','Long Biên',0,0),
('H342','T002','Long Điền',0,0),
('H343','T061','Long Hồ',0,0),
('H344','T019','Long Khánh',0,0),
('H345','T028','Long Mỹ',0,0),
('H346','T028','Long Mỹ',0,0),
('H347','T051','Long Phú',0,0),
('H348','T019','Long Thành',0,0),
('H349','T001','Long Xuyên',0,0),
('H350','T004','Lục Nam',0,0),
('H351','T004','Lục Ngạn',0,0),
('H352','T063','Lục Yên',0,0),
('H353','T029','Lương Sơn',0,0),
('H354','T006','Lương Tài',0,0),
('H355','T023','Lý Nhân',0,0),
('H356','T048','Lý Sơn',0,0),
('H357','T016','MDrắk',0,0),
('H358','T029','Mai Châu',0,0),
('H359','T052','Mai Sơn',0,0),
('H360','T061','Mang Thít',0,0),
('H361','T021','Mang Yang',0,0),
('H362','T024','Mê Linh',0,0),
('H363','T022','Mèo Vạc',1,0),
('H364','T046','Minh Hóa',0,1),
('H365','T048','Minh Long',0,0),
('H366','T007','Mỏ Cày Bắc',0,0),
('H367','T007','Mỏ Cày Nam',0,0),
('H368','T048','Mộ Đức',0,0),
('H369','T052','Mộc Châu',0,0),
('H370','T039','Mộc Hóa',0,0),
('H371','T049','Móng Cái',0,0),
('H372','T063','Mù Cang Chải',0,0),
('H373','T018','Mường Ảng',0,0),
('H374','T018','Mường Chà',0,0),
('H375','T037','Mường Khương',0,0),
('H376','T052','Mường La',0,0),
('H377','T056','Mường Lát',0,0),
('H378','T018','Mường Lay',0,0),
('H379','T018','Mường Nhé',0,1),
('H380','T035','Mường Tè',0,1),
('H381','T024','Mỹ Đức',0,0),
('H382','T031','Mỹ Hào',0,0),
('H383','T040','Mỹ Lộc',0,0),
('H384','T058','Mỹ Tho',0,0),
('H385','T051','Mỹ Tú',0,0),
('H386','T051','Mỹ Xuyên',0,0),
('H387','T060','Na Hang',0,1),
('H388','T005','Na Rì',0,0),
('H389','T012','Năm Căn',0,0),
('H390','T041','Nam Đàn',0,0),
('H391','T040','Nam Định',0,0),
('H392','T057','Nam Đông',0,0),
('H393','T047','Nam Giang',0,0),
('H394','T035','Nậm Nhùn',0,1),
('H395','T018','Nậm Pồ',1,0),
('H396','T026','Nam Sách',0,0),
('H397','T047','Nam Trà My',0,0),
('H398','T040','Nam Trực',0,0),
('H399','T024','Nam Từ Liêm',0,0),
('H400','T028','Ngã Bảy',0,0),
('H401','T051','Ngã Năm',0,0),
('H402','T056','Nga Sơn',0,0),
('H403','T005','Ngân Sơn',0,1),
('H404','T041','Nghi Lộc',0,0),
('H405','T056','Nghi Sơn',0,0),
('H406','T025','Nghi Xuân',0,0),
('H407','T041','Nghĩa Đàn',0,0),
('H408','T048','Nghĩa Hành',0,0),
('H409','T040','Nghĩa Hưng',0,0),
('H410','T063','Nghĩa Lộ',0,0),
('H411','T027','Ngô Quyền',0,0),
('H412','T012','Ngọc Hiển',0,0),
('H413','T034','Ngọc Hồi',0,0),
('H414','T056','Ngọc Lặc',0,0),
('H415','T015','Ngũ Hành Sơn',0,0),
('H416','T013','Nguyên Bình',0,0),
('H417','T030','Nhà Bè',0,0),
('H418','T032','Nha Trang',0,0),
('H419','T042','Nho Quan',0,0),
('H420','T019','Nhơn Trạch',0,0),
('H421','T056','Như Thanh',0,0),
('H422','T056','Như Xuân',0,0),
('H423','T042','Ninh Bình',0,0),
('H424','T026','Ninh Giang',0,0),
('H425','T043','Ninh Hải',0,0),
('H426','T032','Ninh Hòa',0,0),
('H427','T014','Ninh Kiều',0,0),
('H428','T043','Ninh Phước',0,0),
('H429','T043','Ninh Sơn',0,0),
('H430','T056','Nông Cống',0,0),
('H431','T047','Nông Sơn',0,0),
('H432','T047','Núi Thành',0,0),
('H433','T014','Ô Môn',0,0),
('H434','T005','Pác Nặm',0,1),
('H435','T043','Phan Rang Tháp Chàm',0,0),
('H436','T011','Phan Thiết',0,0),
('H437','T055','Phổ Yên',0,0),
('H438','T014','Phong Điền',0,0),
('H439','T057','Phong Điền',0,0),
('H440','T035','Phong Thổ',0,1),
('H441','T055','Phú Bình',0,0),
('H442','T009','Phù Cát',0,0),
('H443','T031','Phù Cừ',0,0),
('H444','T008','Phú Giáo',0,0),
('H445','T045','Phú Hòa',0,0),
('H446','T057','Phú Lộc',0,0),
('H447','T055','Phú Lương',0,0),
('H448','T023','Phủ Lý',0,0),
('H449','T002','Phú Mỹ',0,0),
('H450','T009','Phù Mỹ',0,0),
('H451','T030','Phú Nhuận',0,0),
('H452','T047','Phú Ninh',0,0),
('H453','T044','Phù Ninh',0,0),
('H454','T033','Phú Quốc',0,0),
('H455','T011','Phú Quý',0,0),
('H456','T010','Phú Riềng',0,0),
('H457','T001','Phú Tân',0,0),
('H458','T012','Phú Tân',0,0),
('H459','T021','Phú Thiện',0,0),
('H460','T044','Phú Thọ',0,0),
('H461','T057','Phú Vang',0,0),
('H462','T024','Phú Xuyên',0,0),
('H463','T052','Phù Yên',0,0),
('H464','T024','Phúc Thọ',0,0),
('H465','T062','Phúc Yên',0,0),
('H466','T028','Phụng Hiệp',0,0),
('H467','T010','Phước Long',0,0),
('H468','T003','Phước Long',0,0),
('H469','T047','Phước Sơn',0,1),
('H470','T021','Pleiku',0,0),
('H471','T030','Quận 1',0,0),
('H472','T030','Quận 3',0,0),
('H473','T030','Quận 4',0,0),
('H474','T030','Quận 5',0,0),
('H475','T030','Quận 6',0,0),
('H476','T030','Quận 7',0,0),
('H477','T030','Quận 8',0,0),
('H478','T030','Quận 10',0,0),
('H479','T030','Quận 11',0,0),
('H480','T030','Quận 12',0,0),
('H481','T022','Quản Bạ',0,1),
('H482','T056','Quan Hóa',0,1),
('H483','T056','Quan Sơn',0,0),
('H484','T022','Quang Bình',0,0),
('H485','T057','Quảng Điền',0,0),
('H486','T013','Quảng Hòa',0,0),
('H487','T048','Quảng Ngãi',0,0),
('H488','T046','Quảng Ninh',0,0),
('H489','T046','Quảng Trạch',0,0),
('H490','T050','Quảng Trị',0,0),
('H491','T056','Quảng Xương',0,0),
('H492','T049','Quảng Yên',0,0),
('H493','T041','Quế Phong',0,0),
('H494','T047','Quế Sơn',0,0),
('H495','T006','Quế Võ',0,0),
('H496','T024','Quốc Oai',0,0),
('H497','T041','Quỳ Châu',0,0),
('H498','T041','Quỳ Hợp',0,0),
('H499','T009','Quy Nhơn',0,0),
('H500','T041','Quỳnh Lưu',0,0),
('H501','T052','Quỳnh Nhai',0,0),
('H502','T054','Quỳnh Phụ',0,0),
('H503','T033','Rạch Giá',0,0),
('H504','T020','Sa Đéc',0,0),
('H505','T037','Sa Pa',0,0),
('H506','T034','Sa Thầy',0,0),
('H507','T056','Sầm Sơn',0,0),
('H508','T037','Si Ma Cai',0,0),
('H509','T035','Sìn Hồ',0,1),
('H510','T024','Sóc Sơn',0,0),
('H511','T051','Sóc Trăng',0,0),
('H512','T004','Sơn Động',1,0),
('H513','T060','Sơn Dương',0,0),
('H514','T048','Sơn Hà',0,0),
('H515','T045','Sơn Hòa',0,0),
('H516','T052','Sơn La',0,0),
('H517','T024','Sơn Tây',0,0),
('H518','T048','Sơn Tây',0,0),
('H519','T048','Sơn Tịnh',0,0),
('H520','T015','Sơn Trà',0,0),
('H521','T045','Sông Cầu',0,0),
('H522','T055','Sông Công',0,0),
('H523','T045','Sông Hinh',0,0),
('H524','T062','Sông Lô',0,0),
('H525','T052','Sông Mã',0,0),
('H526','T052','Sốp Cộp',1,0),
('H527','T061','Tam Bình',0,0),
('H528','T062','Tam Đảo',0,0),
('H529','T042','Tam Điệp',0,0),
('H530','T062','Tam Dương',0,0),
('H531','T035','Tam Đường',0,0),
('H532','T047','Tam Kỳ',0,0),
('H533','T020','Tam Nông',0,0),
('H534','T044','Tam Nông',0,0),
('H535','T039','Tân An',0,0),
('H536','T053','Tân Biên',0,0),
('H537','T030','Tân Bình',0,0),
('H538','T001','Tân Châu',0,0),
('H539','T053','Tân Châu',0,0),
('H540','T033','Tân Hiệp',0,0),
('H541','T020','Tân Hồng',0,0),
('H542','T039','Tân Hưng',0,0),
('H543','T041','Tân Kỳ',0,0),
('H544','T029','Tân Lạc',0,0),
('H545','T030','Tân Phú',0,0),
('H546','T019','Tân Phú',0,0),
('H547','T058','Tân Phú Đông',0,0),
('H548','T058','Tân Phước',0,0),
('H549','T044','Tân Sơn',0,0),
('H550','T039','Tân Thạnh',0,0),
('H551','T039','Tân Trụ',0,0),
('H552','T008','Tân Uyên',0,0),
('H553','T035','Tân Uyên',0,0),
('H554','T004','Tân Yên',0,0),
('H555','T011','Tánh Linh',0,0),
('H556','T047','Tây Giang',0,0),
('H557','T024','Tây Hồ',0,0),
('H558','T045','Tây Hòa',0,0),
('H559','T053','Tây Ninh',0,0),
('H560','T009','Tây Sơn',0,0),
('H561','T013','Thạch An',0,0),
('H562','T025','Thạch Hà',0,0),
('H563','T056','Thạch Thành',0,0),
('H564','T024','Thạch Thất',0,0),
('H565','T054','Thái Bình',0,0),
('H566','T041','Thái Hòa',0,0),
('H567','T055','Thái Nguyên',0,0),
('H568','T054','Thái Thụy',0,0),
('H569','T035','Than Uyên',0,0),
('H570','T047','Thăng Bình',0,0),
('H571','T044','Thanh Ba',0,0),
('H572','T020','Thanh Bình',0,0),
('H573','T041','Thanh Chương',0,0),
('H574','T026','Thanh Hà',0,0),
('H575','T056','Thanh Hóa',0,0),
('H576','T039','Thạnh Hóa',0,0),
('H577','T015','Thanh Khê',0,0),
('H578','T023','Thanh Liêm',0,0),
('H579','T026','Thanh Miện',0,0),
('H580','T024','Thanh Oai',0,0),
('H581','T007','Thạnh Phú',0,0),
('H582','T044','Thanh Sơn',0,0),
('H583','T044','Thanh Thủy',0,0),
('H584','T024','Thanh Trì',0,0),
('H585','T051','Thạnh Trị',0,0),
('H586','T024','Thanh Xuân',0,0),
('H587','T020','Tháp Mười',0,0),
('H588','T056','Thiệu Hóa',0,0),
('H589','T056','Thọ Xuân',0,0),
('H590','T001','Thoại Sơn',0,0),
('H591','T012','Thới Bình',0,0),
('H592','T014','Thới Lai',0,0),
('H593','T019','Thống Nhất',0,0),
('H594','T014','Thốt Nốt',0,0),
('H595','T008','Thủ Dầu Một',0,0),
('H596','T030','Thủ Đức',0,0),
('H597','T039','Thủ Thừa',0,0),
('H598','T008','Thuận An',0,0),
('H599','T043','Thuận Bắc',0,0),
('H600','T052','Thuận Châu',0,0),
('H601','T043','Thuận Nam',0,0),
('H602','T006','Thuận Thành',0,0),
('H603','T024','Thường Tín',0,0),
('H604','T056','Thường Xuân',0,0),
('H605','T027','Thủy Nguyên',0,0),
('H606','T006','Tiên Du',0,0),
('H607','T054','Tiền Hải',0,0),
('H608','T027','Tiên Lãng',0,0),
('H609','T031','Tiên Lữ',0,0),
('H610','T047','Tiên Phước',0,0),
('H611','T049','Tiên Yên',0,0),
('H612','T059','Tiểu Cần',0,0),
('H613','T001','Tịnh Biên',0,0),
('H614','T048','Trà Bồng',0,0),
('H615','T059','Trà Cú',0,0),
('H616','T061','Trà Ôn',0,0),
('H617','T059','Trà Vinh',0,0),
('H618','T063','Trạm Tấu',0,1),
('H619','T051','Trần Đề',0,0),
('H620','T012','Trần Văn Thời',0,0),
('H621','T063','Trấn Yên',0,0),
('H622','T053','Trảng Bàng',0,0),
('H623','T019','Trảng Bom',0,0),
('H624','T036','Tràng Định',0,0),
('H625','T001','Tri Tôn',0,0),
('H626','T050','Triệu Phong',0,0),
('H627','T056','Triệu Sơn',0,0),
('H628','T040','Trực Ninh',0,0),
('H629','T013','Trùng Khánh',0,0),
('H630','T032','Trường Sa',0,0),
('H631','T026','Tứ Kỳ',0,0),
('H632','T034','Tu Mơ Rông',0,1),
('H633','T048','Tư Nghĩa',0,0),
('H634','T006','Từ Sơn',0,0),
('H635','T018','Tủa Chùa',1,0),
('H636','T018','Tuần Giáo',0,0),
('H637','T041','Tương Dương',0,0),
('H638','T045','Tuy An',0,0),
('H639','T017','Tuy Đức',0,0),
('H640','T045','Tuy Hòa',0,0),
('H641','T011','Tuy Phong',0,0),
('H642','T009','Tuy Phước',0,0),
('H643','T046','Tuyên Hóa',0,0),
('H644','T060','Tuyên Quang',0,0),
('H645','T033','U Minh Thượng',0,0),
('H646','T012','U Minh',0,0),
('H647','T024','Ứng Hòa',0,0),
('H648','T049','Uông Bí',0,0),
('H649','T037','Văn Bàn',0,0),
('H650','T009','Vân Canh',0,1),
('H651','T063','Văn Chấn',0,0),
('H652','T049','Vân Đồn',0,0),
('H653','T031','Văn Giang',0,0),
('H654','T052','Vân Hồ',0,0),
('H655','T031','Văn Lâm',0,0),
('H656','T036','Văn Lãng',0,0),
('H657','T032','Vạn Ninh',0,0),
('H658','T036','Văn Quan',0,0),
('H659','T063','Văn Yên',0,0),
('H660','T028','Vị Thanh',0,0),
('H661','T028','Vị Thủy',0,0),
('H662','T022','Vị Xuyên',0,0),
('H663','T044','Việt Trì',0,0),
('H664','T004','Việt Yên',0,0),
('H665','T027','Vĩnh Bảo',0,0),
('H666','T051','Vĩnh Châu',0,0),
('H667','T019','Vĩnh Cửu',0,0),
('H668','T039','Vĩnh Hưng',0,0),
('H669','T050','Vĩnh Linh',0,0),
('H670','T056','Vĩnh Lộc',0,0),
('H671','T003','Vĩnh Lợi',0,0),
('H672','T061','Vĩnh Long',0,0),
('H673','T014','Vĩnh Thạnh',1,0),
('H674','T009','Vĩnh Thạnh',1,0),
('H675','T033','Vĩnh Thuận',0,0),
('H676','T062','Vĩnh Tường',0,0),
('H677','T062','Vĩnh Yên',0,0),
('H678','T041','Vinh',0,0),
('H679','T055','Võ Nhai',0,0),
('H680','T040','Vụ Bản',0,0),
('H681','T025','Vũ Quang',0,0),
('H682','T054','Vũ Thư',0,0),
('H683','T061','Vũng Liêm',0,0),
('H684','T002','Vũng Tàu',0,0),
('H685','T022','Xín Mần',1,0),
('H686','T019','Xuân Lộc',0,0),
('H687','T040','Xuân Trường',0,0),
('H688','T002','Xuyên Mộc',0,0),
('H689','T040','Ý Yên',0,0),
('H690','T063','Yên Bái',0,0),
('H691','T063','Yên Bình',0,0),
('H692','T052','Yên Châu',0,0),
('H693','T056','Yên Định',0,0),
('H694','T004','Yên Dũng',0,0),
('H695','T042','Yên Khánh',0,0),
('H696','T062','Yên Lạc',0,0),
('H697','T044','Yên Lập',0,0),
('H698','T022','Yên Minh',1,0),
('H699','T042','Yên Mô',0,0),
('H700','T031','Yên Mỹ',0,0),
('H701','T006','Yên Phong',0,0),
('H702','T060','Yên Sơn',0,0),
('H703','T041','Yên Thành',0,0),
('H704','T004','Yên Thế',0,0),
('H705','T029','Yên Thủy',0,0)
