# LibraryManagement

Hệ thống quản lý thư viện cho đồ án cuối kỳ môn Lập trình Cơ sở dữ liệu.

## Tổng quan

Project này là một ứng dụng Windows Forms bằng C# để quản lý thư viện, bao gồm:

- Đăng nhập hệ thống
- Quản lý sách
- Quản lý nhân viên
- Quản lý độc giả
- Quản lý phiếu mượn/trả
- Thống kê và báo cáo
- Tích hợp với SQL Server để lưu trữ dữ liệu

## Công nghệ sử dụng

- C# / .NET 8
- Windows Forms
- SQL Server
- Microsoft.Data.SqlClient
- OxyPlot (để hiển thị biểu đồ/thống kê)

## Cấu trúc thư mục

```text
LibraryManagement/
├── BL/                     # Business Logic Layer
│   ├── BL_*.cs
│   └── obj/
├── DL/                     # Data Access Layer
│   ├── DL_*.cs
│   └── obj/
├── Images/                 # Hình ảnh UI của ứng dụng
├── QLThuVien/              # Project giao diện chính (Windows Forms)
│   ├── *.cs
│   ├── *.resx
│   ├── Properties/
│   ├── QLThuVien.csproj
│   └── QLThuVien.sln
├── TO/                     # Transfer Object / model layer
│   ├── *.cs
│   └── obj/
├── QuanLyThuVien.sql       # Script tạo cơ sở dữ liệu và bảng
├── bin/                    # Build output
├── .gitignore
└── README.md
```

## Chức năng chính

- Quản lý danh mục sách
- Thêm, sửa, xóa sách
- Quản lý thông tin độc giả và nhân viên
- Tạo và xử lý phiếu mượn/trả
- Theo dõi tình trạng sách đang được mượn
- Thống kê sách mượn nhiều nhất
- Báo cáo theo thể loại, mượn/trả, số lượng

## Cơ sở dữ liệu

File SQL chính của project là:

- `QuanLyThuVien.sql`

File này chứa schema và dữ liệu ban đầu cho hệ thống quản lý thư viện. Trước khi chạy ứng dụng, cần đảm bảo database đã được tạo và import script.

Kết nối SQL Server được định nghĩa trong file:

- `DL/DL_Connect.cs`

Hiện tại connection string đang dùng:

```csharp
Data Source=LEGIAHAN\SQLEXPRESS01;Initial Catalog=QuanLyThuVien;Integrated Security=True;Trust Server Certificate=True
```

Bạn cần cập nhật `Data Source` theo tên máy chủ / SQL Server của bạn nếu chạy trên máy khác.

## Yêu cầu môi trường

- Visual Studio 2022
- .NET 8 SDK
- SQL Server / SQL Server Express
- Hệ điều hành Windows (do project target `net8.0-windows`)

## Cài đặt và chạy

1. Clone repository:

```bash
git clone https://github.com/legiahan2705/LibraryManagement.git
```

2. Mở file solution:

```text
QLThuVien/QLThuVien.sln
```

3. Restore NuGet packages nếu cần.

4. Cập nhật connection string trong file `DL/DL_Connect.cs` cho đúng SQL Server của bạn.

5. Chạy script `QuanLyThuVien.sql` trong SQL Server Management Studio (SSMS) hoặc SQL Server Object Explorer.

6. Build và chạy project.

## Khởi chạy ứng dụng

Project chính dùng giao diện đăng nhập và khởi chạy từ:

- `QLThuVien/program.cs`

File này chạy form `DangNhap` khi chương trình start.

## Ghi chú

- Đây là một project WinForms đơn giản dành cho mục tiêu học tập và đồ án môn Database Programming.
- Cấu trúc code theo mô hình nhiều tầng:
  - `QLThuVien`: giao diện người dùng
  - `BL`: xử lý nghiệp vụ
  - `DL`: truy vấn dữ liệu
  - `TO`: đối tượng dữ liệu

## License

Repository hiện chưa khai báo license cụ thể.

## Tác giả

- Lê Gia Hân
- Phan Hồng Lĩnh
- Trịnh Ngọc Mai Chi
