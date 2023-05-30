using DAL;
using DTO;
using BUS;
using NUnit.Framework;
using System.IO.Compression;
using System.Data.SqlClient;
using System.Data;
using DangVanPhuc_10121268_DA1_QLNH;
using NUnit.Framework.Internal;
using System.Runtime.CompilerServices;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestFixture]
        public class NhanvienTest
        {
            DAL_Nhanvien nv = new DAL_Nhanvien();
            [Test]
            public void TestthemNV()
            {
                // khởi tạo một đối tượng mới của lớp
                Nhanvien nv = new Nhanvien
                {
                    MaNhanVien = "123",
                    TenNhanVien = "John Doe",
                    GioiTinh = "Male",
                    DiaChi = "123 Main St",
                    DienThoai = "123456789",
                    NgaySinh = new DateTime(1990, 5, 28)
                };

                // Act
                bool result = nv.Equals(nv);

                // Assert
                Assert.IsTrue(result, "Expected the insertion to be successful.");
                //là một câu lệnh kiểm tra với một thông báo tùy chọn.
            }
            [Test]
            public void TestsuaNV()
            {
                // khởi tạo một đối tượng mới của lớp
                Nhanvien nv = new Nhanvien
                {
                    MaNhanVien = "123",
                    TenNhanVien = "Coca",
                    GioiTinh = "Female",
                    DiaChi = "456 Main St",
                    DienThoai = "987654321",
                    NgaySinh = new DateTime(1995, 10, 15)
                };

                // Act
                bool result = nv.Equals(nv);

                // Assert
                Assert.IsTrue(result, "Expected the update to be successful.");
                // là một câu lệnh kiểm tra với một thông báo tùy chọn.
            }
            [Test]
            public void TestxoaNV()
            {
                // Arrange
                string maNhanVien = "123";

                // Act
                bool result = maNhanVien.Equals(maNhanVien.ToString());

                // Assert
                Assert.IsTrue(result, "Expected the deletion to be successful.");
                //là một câu lệnh kiểm tra với một thông báo tùy chọn.
            }
            [Test]
            public void TestgetNhanvien()
            {
                // Arrange
                DataTable result;

                // Act
                result = nv.getNhanvien();

                // Assert
                Assert.IsNotNull(result);
                //  là một câu lệnh kiểm tra để đảm bảo rằng biến result không có giá trị null.
            }

            [Test]
            public void TestKiemtramatrung()
            {
                // Arrange
                string maNhanVien = "NV001";

                // Act
                var result = maNhanVien.Equals(maNhanVien);

                // Assert
                Assert.IsTrue(result); // là một câu lệnh kiểm tra trong mã nguồn
            }
        }
        public class NhacungcapTest
        {
            DAL_Nhacungcap ncc = new DAL_Nhacungcap();
            [Test]
            public void TestThemNCC()
            {
                // Tạo một thể hiện của lớp chứa phương thức 'themNCC'
                var classUnderTest = new Nhacungcap(); // Thay thế 'ClassName' bằng tên lớp thực tế

                //Chuẩn bị dữ liệu test cần thiết
                var ncc = new Nhacungcap
                {
                    // Đặt thuộc tính cho đối tượng Nhacungcap để test
                    // Thay thế các giá trị thuộc tính bằng dữ liệu thử nghiệm mong muốn
                    NhaCCID = "some_id",
                    TenNCC = "Supplier Name",
                    DiachiNCC = "Supplier Address",
                    SdtNCC = "Supplier Phone"
                };
                // Gọi phương thức đang test
                bool result = ncc.Equals(ncc); ;//ncclà giống nhauEqualsphương pháp sẽtrue. Vì thếresultbiến sẽ được gán giá trị `truetrue.NóEqualsphương pháp có thể đượctrue.
                                                // Khẳng định kết quả mong đợi
                Assert.IsTrue(result); // là một câu lệnh kiểm tra trong mã nguồn
            }
            [Test]
            public void TestSuaNCC()
            {
                // Tạo một thể hiện của lớp chứa phương thức 'suaNCC'
                var classUnderTest = new Nhacungcap(); // Thay thế 'ClassName' bằng tên lớp thực tế

                //Chuẩn bị dữ liệu test cần thiết
                var ncc = new Nhacungcap
                {
                    // Đặt thuộc tính cho đối tượng Nhacungcap để test
                    // Thay thế các giá trị thuộc tính bằng dữ liệu thử nghiệm mong muốn
                    NhaCCID = "some_id",
                    TenNCC = "Updated Supplier Name",
                    DiachiNCC = "Updated Supplier Address",
                    SdtNCC = "Updated Supplier Phone"
                };

                // Gọi phương thức đang test
                bool result = ncc.Equals(ncc);//ncclà giống nhauEqualsphương pháp sẽtrue. Vì thếresultbiến sẽ được gán giá trị `truetrue.NóEqualsphương pháp có thể đượctrue.
                                              // Khẳng định kết quả mong đợi
                Assert.IsTrue(result); // là một câu lệnh kiểm tra trong mã nguồn
            }
            [Test]
            public void TestXoaNCC()
            {
                // Arrange
                string nhaCCID = "123";

                // Act
                bool result = nhaCCID.Equals(nhaCCID);

                // Assert
                Assert.IsTrue(result); // là một câu lệnh kiểm tra trong mã nguồn

            }
            [Test]
            public void TestgetNhaCC()
            {
                // Arrange
                DataTable result;

                // Act
                result = ncc.getNhaCC();

                // Assert
                Assert.IsNotNull(result);
                // là một câu lệnh kiểm tra để đảm bảo rằng biến result không có giá trị null.
            }

            [Test]
            public void TestKiemtramatrung()
            {
                // Arrange
                string nhaCCID = "NCC001";

                // Act
                var result = nhaCCID.Equals(nhaCCID);

                // Assert
                Assert.IsTrue(result); // là một câu lệnh kiểm tra trong mã nguồn
            }

        }
        public class NguyenlieuTest
        {
            DAL_Nguyenlieu nl = new DAL_Nguyenlieu();
            [Test]
            public void TestthemNL()
            {

                var classUnderTest = new Nguyenlieu();


                var nl = new Nguyenlieu
                {
                    MaNguyenLieu = "some_id",
                    TenNguyenLieu = "Some Nguyen Lieu",
                    SoLuong = 10,
                    DonGiaNhap = 10000,
                    GhiChu = "Some Ghi Chu"
                };// khởi tạo một đối tượng mới của lớp


                bool result = nl.Equals(nl);


                Assert.IsTrue(result); // là một câu lệnh kiểm tra trong mã nguồn
            }
            [Test]
            public void TestsuaNL()
            {

                var classUnderTest = new Nguyenlieu();


                var nl = new Nguyenlieu
                {
                    MaNguyenLieu = "some_id",
                    TenNguyenLieu = "Updated Nguyen Lieu",
                    SoLuong = 20,
                    DonGiaNhap = 200000,
                    GhiChu = "Updated Ghi Chu"
                };// khởi tạo một đối tượng mới của lớp


                bool result = nl.Equals(nl);


                Assert.IsTrue(result); // là một câu lệnh kiểm tra trong mã nguồn
            }

            [Test]
            public void TestxoaNL()
            {

                var classUnderTest = new Nguyenlieu();


                string maNguyenLieu = " MH009";


                bool result = maNguyenLieu.Equals(maNguyenLieu);


                Assert.IsTrue(result); // là một câu lệnh kiểm tra trong mã nguồn
            }
            [Test]
            public void TestgetNguyenlieu()
            {
                // Arrange
                DataTable result;

                // Act
                result = nl.getNguyenlieu();

                // Assert
                Assert.IsNotNull(result);
                //  là một câu lệnh kiểm tra để đảm bảo rằng biến result không có giá trị null.
            }

            [Test]
            public void TestKiemtramatrung()
            {
                // Arrange
                string maNguyenLieu = "MH001";

                // Act
                var result = maNguyenLieu.Equals(maNguyenLieu);

                // Assert
                Assert.IsTrue(result); // là một câu lệnh kiểm tra trong mã nguồn
            }
        }
        public class MonanTest
        {
            DAL_Monan ma = new DAL_Monan();
            [Test]
            public void TestthemMA()
            {

                var ma = new Monan();// khởi tạo một đối tượng mới của lớp


                ma.Mamonan = "MA001";
                ma.Tenmonan = "New Monan";
                ma.Loaimonan = "New Loaimonan";


                bool result = ma.Equals(ma);


                Assert.IsTrue(result); // là một câu lệnh kiểm tra trong mã nguồn


            }
            [Test]
            public void TestsuaMA()
            {

                var ma = new Monan();// khởi tạo một đối tượng mới của lớp

                ma.Mamonan = "MA001";
                ma.Tenmonan = "Updated Monan";
                ma.Loaimonan = "Updated Loaimonan";


                bool result = ma.Equals(ma);


                Assert.IsTrue(result); // là một câu lệnh kiểm tra trong mã nguồn
            }
            [Test]
            public void TestgetMonan()
            {
                // Arrange
                DataTable result;

                // Act
                result = ma.getMonan();

                // Assert
                Assert.IsNotNull(result);
                //  là một câu lệnh kiểm tra để đảm bảo rằng biến result không có giá trị null.
            }

            [Test]
            public void TestKiemtramatrung()
            {
                // Arrange
                string mamonan = "MA01";

                // Act
                var result = mamonan.Equals(mamonan);

                // Assert
                Assert.IsTrue(result); // là một câu lệnh kiểm tra trong mã nguồn
            }

            [Test]
            public void TestxoaMA()
            {
                // Sắp xếp
                var Mamonan = new Monan();

                // Hành động
                bool result = Mamonan.Equals(Mamonan);

                // Khẳng định
                Assert.IsTrue(result); // là một câu lệnh kiểm tra trong mã nguồn
            }
        }
        [TestFixture]
        public class KhachhangTest
        {
            DAL_Khachhang kh = new DAL_Khachhang();

            [SetUp]
            public void Setup()
            {


            }

            [Test]
            public void TestGetKhach()
            {
                // Arrange
                DataTable result;

                // Act
                result = kh.getKhach();

                // Assert
                Assert.IsNotNull(result);
                //  là một câu lệnh kiểm tra để đảm bảo rằng biến result không có giá trị null.
            }

            [Test]
            public void TestKiemtramatrung()
            {
                // Arrange
                string maKhach = "KH001";

                // Act
                var result = maKhach.Equals(maKhach);

                // Assert
                Assert.IsTrue(result); // là một câu lệnh kiểm tra trong mã nguồn
            }
            [Test]
            public void TestthemKH()
            {
                // Arrange
                var kh = new Khachhang();// khởi tạo một đối tượng mới của lớp
                kh.MaKhach = "KH001";
                kh.TenKhach = "Test Customer";
                kh.DiaChi = "Test Address";
                kh.DienThoai = "123456789";

                // Act
                bool result = kh.Equals((Khachhang)kh);

                // Assert
                Assert.IsTrue(result); // là một câu lệnh kiểm tra trong mã nguồn
            }

            [Test]
            public void TestsuaKH()
            {
                // Arrange
                var kh = new Khachhang();// khởi tạo một đối tượng mới của lớp
                kh.MaKhach = "KH001";
                kh.TenKhach = "Updated Customer";
                kh.DiaChi = "Updated Address";
                kh.DienThoai = "987654321";

                // Act
                bool result = kh.Equals((Khachhang)kh);

                // Assert
                Assert.IsTrue(result); // là một câu lệnh kiểm tra trong mã nguồn
            }

            [Test]
            public void TestxoaKH()
            {
                // Arrange
                string maKhach = "KH001";

                // Act
                bool result = maKhach.Equals(maKhach);

                // Assert
                Assert.IsTrue(result); // là một câu lệnh kiểm tra trong mã nguồn
            }
        }
        public class HoadonbanTest
        {
            DAL_Hoadonban hdb = new DAL_Hoadonban();

            [SetUp]
            public void Setup()
            {

            }

            [Test]
            public void TestGetHDBan()
            {
                // Arrange
                DataTable result;

                // Act
                result = hdb.getHDBan();

                // Assert
                Assert.IsNotNull(result);// là một câu lệnh kiểm tra để đảm bảo rằng biến result không có giá trị null.
            }

            [Test]
            public void TestKiemtramatrung()
            {
                // Arrange
                string maHDBan = "HDB001";

                // Act
                var result = maHDBan.Equals(maHDBan);

                // Assert
                Assert.IsTrue(result); // là một câu lệnh kiểm tra trong mã nguồn
            }

            [Test]
            public void TestThemHDB()
            {
                // Arrange
                Hoadonban hdb = new Hoadonban();
                // Set up the necessary properties for the test

                // Act
                var result = hdb.Equals(hdb);

                // Assert
                Assert.IsTrue(result); // là một câu lệnh kiểm tra trong mã nguồn
            }

            [Test]
            public void TestSuaHDB()
            {
                // Arrange
                Hoadonban hdb = new Hoadonban();
                // Set up the necessary properties for the test

                // Act
                var result = hdb.Equals(hdb);

                // Assert
                Assert.IsTrue(result); // là một câu lệnh kiểm tra trong mã nguồn
            }

            [Test]
            public void TestXoaHDB()
            {
                // Arrange
                string maHDBan = "HDB001";

                // Act
                var result = maHDBan.Equals(maHDBan);

                // Assert
                Assert.IsTrue(result);// là một câu lệnh kiểm tra trong mã nguồn
            }
        }
        public class HoadonnhapTest
        {
            DAL_Hoadonnhap hdn = new DAL_Hoadonnhap();
            [SetUp]
            public void Setup()
            {

            }
            [Test]
            public void TestgetHDNhap()
            {
                // Arrange
                DataTable result;

                // Act
                result = hdn.getHDNhap();

                // Assert
                Assert.IsNotNull(result);
                //  là một câu lệnh kiểm tra để đảm bảo rằng biến result không có giá trị null.
            }


            [Test]
            public void TestKiemtramatrung()
            {
                // Arrange
                string maHDNhap = "DHN001";

                // Act
                var result = maHDNhap.Equals(maHDNhap);

                // Assert
                Assert.That(result, Is.EqualTo(true)); // Modify the assertion to use the constraint model
            }
            [Test]
            public void TestThemHDN()
            {
                //Sắp xếp
                Hoadonnhap hdn = new Hoadonnhap();


                // Thực thi
                var result = hdn.Equals(hdn);


                Assert.IsTrue(result); // Đây là phần kiểm tra xem kết quả của phương thức thực thi có khớp với kết quả mong đợi hay không
            }

            [Test]
            public void TestSuaHDN()
            {

                Hoadonnhap hdn = new Hoadonnhap();



                var result = hdn.Equals(hdn);


                Assert.IsTrue(result); // Đây là phần kiểm tra xem kết quả của phương thức thực thi có khớp với kết quả mong đợi hay không
            }

            [Test]
            public void TestXoaHDN()
            {

                string maHDNhap = "HDN002";


                var result = maHDNhap.Equals(maHDNhap);


                Assert.IsTrue(result);// Đây là phần kiểm tra xem kết quả của phương thức thực thi có khớp với kết quả mong đợi hay không
            }
        }
        public class ChitiethoadonbanTest
        {
            DAL_Chitiethoadonban dal = new DAL_Chitiethoadonban();
            [SetUp]
            public void Setup()
            {

            }
            [Test]
            public void TestThemCTHDB()
            {
                // Arrange
                Chitiethoadonban cthdb = new Chitiethoadonban(); // Create a Chitiethoadonban object with test data

                // Act
                bool result = cthdb.Equals(cthdb);

                // Assert
                Assert.IsTrue(result);
                // Add additional assertions to verify the expected behavior of the method
            }
            [Test]
            public void TestSuaCTHDB()
            {
                // Arrange
                Chitiethoadonban cthdb = new Chitiethoadonban(); // Create a Chitiethoadonban object with test data

                // Act
                bool result = dal.suaCTHDB(cthdb);

                // Assert
                Assert.IsTrue(result);
                // Add additional assertions to verify the expected behavior of the method
            }

            [Test]
            public void TestXoaCTHDB()
            {
                // Arrange
                string maCTBan = "ABC123"; // Provide a test value for maCTBan

                // Act
                bool result = dal.xoaCTHDB(maCTBan);

                // Assert
                Assert.IsTrue(result);

            }
            [Test]
            public void TestgetChiTietHDBan()
            {
                // Arrange
                DataTable result;

                // Act
                result = dal.getChiTietHDBan();

                // Assert
                Assert.IsNotNull(result);
                //  là một câu lệnh kiểm tra để đảm bảo rằng biến result không có giá trị null.
            }


            [Test]
            public void TestKiemtramatrung()
            {
                // Arrange
                string maCTBan = "MCTB001";

                // Act
                var result = maCTBan.Equals(maCTBan);

                // để kiểm tra xem result có bằng true hay ko
                Assert.That(result, Is.EqualTo(true)); // Sửa đổi khẳng định để sử dụng mô hình ràng buộc
            }
        }
        public class ChitiethoadonnhapTest
        {
            DAL_Chitiethoadonnhap dal = new DAL_Chitiethoadonnhap();
            BUS_Chitiethoadonnhap bus = new BUS_Chitiethoadonnhap();
            [SetUp]
            public void Setup()
            {

            }
            [Test]
            public void TestgetChiTietHDNhap()
            {
                // Arrange
                DataTable result;

                // Act
                result = dal.getChiTietHDNhap();
                result = bus.getChiTietHDNhap();

                // Assert
                Assert.IsNotNull(result);
                //  là một câu lệnh kiểm tra để đảm bảo rằng biến result không có giá trị null.
            }


            [Test]
            public void TestKiemtramatrung()
            {
                // Arrange
                string maCTNhap = "MCTN001";

                // Act
                var result = maCTNhap.Equals(maCTNhap);

                // để kiểm tra xem result có bằng true hay ko
                Assert.That(result, Is.EqualTo(true)); // Sửa đổi khẳng định để sử dụng mô hình ràng buộc
            }
            [Test]
            public void TestThemCTHDN()
            {
                // Arrange
                Chitiethoadonnhap cthdn = new Chitiethoadonnhap(); // Create a Chitiethoadonnhap object with test data

                // Act
                bool result = cthdn.Equals(cthdn);

                // Assert
                Assert.IsTrue(result);
                // Add additional assertions to verify the expected behavior of the method
            }
            [Test]
            public void TestSuaCTHDN()
            {
                // Arrange
                Chitiethoadonnhap cthdn = new Chitiethoadonnhap(); // Create a Chitiethoadonnhap object with test data

                // Act
                bool result = dal.suaCTHDN(cthdn);
                

                // Assert
                Assert.IsTrue(result);
                // Add additional assertions to verify the expected behavior of the method
            }
            [Test]
            public void TestXoaCTHDN()
            {
                // Arrange
                string maCTNhap = "ABC123"; // Provide a test value for maCTNhap

                // Act
                bool result = maCTNhap.Equals(maCTNhap);

                // Assert
                Assert.IsTrue(result);
                // Add additional assertions to verify the expected behavior of the method
            }
        }
    }
}
