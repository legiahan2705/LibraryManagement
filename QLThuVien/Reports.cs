using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot.WindowsForms;
using System.Security.Policy;
using OxyPlot.Annotations;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using TO;
using System.Windows.Controls;
using Panel = System.Windows.Forms.Panel;
using Control = System.Windows.Forms.Control;



namespace QLThuVien
{
    public partial class Reports : Form
    {
        private BL_BookBorrowingStatistics blStatistics;

        private BL_GetEmployees _blEmployees;
        private string employeeName; // Lưu tên nhân viên
        private string employeeRole; // Lưu quyền của nhân viên
        private string employeeID; // Lưu ID nhân viên
        public Reports(string employeeName, string employeeRole, string id)
        {
            InitializeComponent();
            blStatistics = new BL_BookBorrowingStatistics();

            this.employeeName = employeeName;
            this.employeeRole = employeeRole;
            this.employeeID = id;



            // Khởi tạo đối tượng BL_GetEmployees
            _blEmployees = new BL_GetEmployees();
        }


        // Hàm thoát dùng chung để tránh lặp lại MessageBox thoát nhiều lần
        private bool ConfirmExit()
        {
            // Hiển thị hộp thoại xác nhận thoát
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            return result == DialogResult.Yes; // Trả về true nếu người dùng chọn Yes
        }

        // Biến cờ để theo dõi trạng thái thoát
        private bool isExiting = false;


        // Hàm xử lý Hover các panel bên Trái
        private void HoverEffect_MouseEnter(object? sender, EventArgs e)
        {
            if (sender is Control control) // Kiểm tra nếu sender là một Control
            {
                // Lấy Panel cha từ Control hiện tại (nếu Control là Panel thì chính nó, nếu không thì lấy Parent)
                Panel? parentPanel = control as Panel ?? control.Parent as Panel;

                if (parentPanel != null) // Nếu tìm thấy Panel cha
                {
                    parentPanel.BackColor = ColorTranslator.FromHtml("#BDC0FA"); // đổi màu nền
                }
            }
        }

        // Hàm xử lý khi chuột rời khỏi một thành phần
        private void HoverEffect_MouseLeave(object? sender, EventArgs e)
        {
            if (sender is Control control) // Kiểm tra nếu sender là một Control
            {
                // Lấy Panel cha từ Control hiện tại
                Panel? parentPanel = control as Panel ?? control.Parent as Panel;

                if (parentPanel != null) // Nếu tìm thấy Panel cha
                {
                    parentPanel.BackColor = Color.Transparent; // Khôi phục màu nền mặc định
                }
            }
        }

        private void pnlBookBorrowingBTN_Click(object sender, EventArgs e)
        {
            pnlBookBorrowing.Visible = true;
            
            pnlMostBorrowedBook.Visible = false;
        }

        //đổ dữ liệu vào datagridview
        private void DisplayStatisticsInDgv(List<BookBorrowingStatistic_TO> statistics, DataGridView dgv, bool isQuarter)
        {
            // Xóa dữ liệu cũ trong DataGridView
            dgv.Rows.Clear();

            if (statistics.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu thống kê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Đổ dữ liệu vào DataGridView
            foreach (var stat in statistics)
            {
                if (isQuarter)
                {
                    dgv.Rows.Add(stat.Quarter, stat.TotalBooks);
                }
                else
                {
                    dgv.Rows.Add(stat.Month, stat.TotalBooks);
                }
            }
        }


        private void btnMonth_Click(object sender, EventArgs e)
        {
            pnl_Month.Controls.Clear();
            try
            {
                // Lấy năm từ TextBox
                if (!int.TryParse(txtYear.Text, out int year))
                {
                    MessageBox.Show("Vui lòng nhập năm hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy danh sách các tháng được chọn từ CheckedListBox
                List<int> selectedMonths = new List<int>();
                foreach (var item in clbMonth.CheckedItems)
                {
                    if (int.TryParse(item.ToString(), out int month))
                    {
                        selectedMonths.Add(month);
                    }
                }

                if (selectedMonths.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một tháng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Gọi BL để lấy dữ liệu
                var statistics = blStatistics.GetStatisticsByMonths(year, selectedMonths);

                // Hiển thị dữ liệu vào DataGridView
                DisplayStatisticsInDgv(statistics, dgvMonth, isQuarter: false);

                pnl_Month.Controls.Add(dgvMonth);
                // Vẽ biểu đồ cột cho dữ liệu đã lấy
                DrawMonthlyLineChart(statistics);
                pnl_Quarter.Visible = false;
                pnl_Month.Visible = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuarter_Click(object sender, EventArgs e)
        {
            pnl_Quarter.Controls.Clear();
            try
            {
                // Lấy năm từ TextBox
                if (!int.TryParse(txtYear.Text, out int year))
                {
                    MessageBox.Show("Vui lòng nhập năm hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy danh sách các quý được chọn từ CheckedListBox
                List<int> selectedQuarters = new List<int>();
                foreach (var item in clbQuarter.CheckedItems)
                {
                    if (int.TryParse(item.ToString(), out int quarter))
                    {
                        selectedQuarters.Add(quarter);
                    }
                }

                if (selectedQuarters.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một quý!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Gọi BL để lấy dữ liệu
                var statistics = blStatistics.GetStatisticsByQuarters(year, selectedQuarters);

                
                
                // Hiển thị dữ liệu vào DataGridView
                
                
                DisplayStatisticsInDgv(statistics, dgvQuarter, isQuarter: true);
                pnl_Quarter.Controls.Add(dgvQuarter);

                // Vẽ biểu đồ cột cho dữ liệu đã lấy
                DrawQuarterlyLineChart(statistics);
                pnl_Month.Visible = false;
                pnl_Quarter.Visible = true;
                
               


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reports_Load(object sender, EventArgs e)
        {

            pnlReports.BackColor = ColorTranslator.FromHtml("#BDC0FA");

            //gán tên nhân viên vào label Welcome
            lblEmployeeName.Text = employeeName;

            pnlBookBorrowing.Visible = false;
            pnlMostBorrowedBook.Visible = false;
        }

        // Phương thức vẽ biểu đồ cột cho các tháng
        private void DrawMonthlyLineChart(List<BookBorrowingStatistic_TO> statistics)
        {
            // Kiểm tra nếu statistics không trống
            if (statistics == null || statistics.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để vẽ biểu đồ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đối tượng PlotModel cho biểu đồ
            var plotModel = new PlotModel
            {
                Title = "Thống kê mượn sách theo tháng",
                TitlePadding = 20,
            };

            // Tạo LineSeries để vẽ đường
            var BarSeries = new BarSeries()
            {
                Title = "Số lượng sách mượn",
                FillColor = OxyColor.FromRgb(221, 160, 221), // Màu tím pastel
                XAxisKey = "x1",
                YAxisKey = "y1"
            };

            // Thêm các điểm vào LineSeries
            foreach (var stat in statistics)
            {
                // Dùng điểm với tọa độ (x = tháng, y = số lượng sách)
                BarSeries.Items.Add(new BarItem(stat.TotalBooks));
            }

            plotModel.Series.Add(BarSeries);

            // Thêm trục danh mục (Tháng) trên trục Ox
            var categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Bottom, // Đặt ở phía dưới
                Title = "Tháng",
                ItemsSource = statistics.Select(s => $"Tháng {s.Month}").ToList(), // Cố định 12 tháng
                IsTickCentered = true,
                Key = "y1"
            };
            plotModel.Axes.Add(categoryAxis);

            // Thêm trục giá trị (Số lượng sách) trên trục Oy
            var valueAxis = new LinearAxis
            {
                Position = AxisPosition.Left, // Đặt ở bên trái
                MinimumPadding = 0.1,
                MaximumPadding = 0.1,
                Title = "Số lượng sách",
                Minimum = 0, // Giá trị tối thiểu
                Maximum = statistics.Max(s => s.TotalBooks) + 10,
                MajorStep = 10, // Mỗi bước trên trục Oy sẽ cách nhau 10 (từ 0 đến 100)
                MinorStep = 2,  // Bước nhỏ hơn, ví dụ chia nhỏ khoảng cách cho các nhãn nhỏ
                Key = "x1"
            };

            plotModel.Axes.Add(valueAxis);

            // Tạo đối tượng PlotView và thêm vào form với kích thước mong muốn (600x400)
            var plotView = new PlotView
            {
                Model = plotModel,
                Width = 600,
                Height = 400,
                Location = new Point(
                    (pnl_Month.Width - 600),
                    (pnl_Month.Height - 400)/2
                )
            };


            // Xóa biểu đồ cũ (nếu có) và thêm biểu đồ mới vào panel

            
            pnl_Month.Controls.Add(plotView);
        }


        // phương thức vẽ biểu đồ cột cho các quý
        private void DrawQuarterlyLineChart(List<BookBorrowingStatistic_TO> statistics)
        {
            // Kiểm tra nếu statistics không trống
            if (statistics == null || statistics.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để vẽ biểu đồ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đối tượng PlotModel cho biểu đồ
            var plotModel = new PlotModel
            {
                Title = "Thống kê mượn sách theo quý",
                TitlePadding = 20,
            };

            // Tạo LineSeries để vẽ đường
            var BarSeries = new BarSeries()
            {
                Title = "Số lượng sách mượn",
                FillColor = OxyColor.FromRgb(221, 160, 221), // Màu tím pastel
                XAxisKey = "x1",
                YAxisKey = "y1"
            };

            // Thêm các điểm vào LineSeries
            foreach (var stat in statistics)
            {
                // Dùng điểm với tọa độ (x = tháng, y = số lượng sách)
                BarSeries.Items.Add(new BarItem(stat.TotalBooks));
            }

            plotModel.Series.Add(BarSeries);

            // Thêm trục danh mục (QÚY) trên trục Ox
            var categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Bottom, // Đặt ở phía dưới
                Title = "Qúy",
                ItemsSource = statistics.Select(s => $"Qúy {s.Quarter}").ToList(), // Cố định 12 tháng
                IsTickCentered = true,
                Key = "y1"
            };
            plotModel.Axes.Add(categoryAxis);

            // Thêm trục giá trị (Số lượng sách) trên trục Oy
            var valueAxis = new LinearAxis
            {
                Position = AxisPosition.Left, // Đặt ở bên trái
                MinimumPadding = 0.1,
                MaximumPadding = 0.1,
                Title = "Số lượng sách",
                Minimum = 0, // Giá trị tối thiểu
                Maximum = statistics.Max(s => s.TotalBooks) + 10,
                MajorStep = 10, // Mỗi bước trên trục Oy sẽ cách nhau 10 (từ 0 đến 100)
                MinorStep = 2,  // Bước nhỏ hơn, ví dụ chia nhỏ khoảng cách cho các nhãn nhỏ
                Key = "x1"
            };

            plotModel.Axes.Add(valueAxis);

            // Tạo đối tượng PlotView và thêm vào form với kích thước mong muốn (600x400)
            var plotView = new PlotView
            {
                Model = plotModel,
                Width = 600,
                Height = 400,
                Location = new Point(
                    (pnl_Month.Width - 600),
                    (pnl_Month.Height - 400) 
                )
            };


            // Xóa biểu đồ cũ (nếu có) và thêm biểu đồ mới vào panel

            
            pnl_Quarter.Controls.Add(plotView);
        }

        private void pnlMostBorrowedBTN_Click(object sender, EventArgs e)
        {
            pnlMostBorrowedBook.Visible = true;
        }

        private void btn_Year_Click(object sender, EventArgs e)
        {
            dgvTop5Book.Rows.Clear(); // Xóa dữ liệu cũ nếu có

            try
            {
                // Lấy giá trị từ các TextBox
                int topN;
                int year;

                if (!int.TryParse(txtTopN.Text, out topN) || topN <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số Top N hợp lệ (lớn hơn 0)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txt_Year.Text, out year) || year <= 0)
                {
                    MessageBox.Show("Vui lòng nhập năm hợp lệ (lớn hơn 0)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Gọi lớp BL để lấy dữ liệu
                BL_MostBorrowedBook bl = new BL_MostBorrowedBook();
                List<MostBorrowedBook_TO> books = bl.GetTopNBorrowedBooksByYear(year, topN);

                if (books == null || books.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu cho năm này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Hiển thị vào DataGridView
                dgvTop5Book.Rows.Clear(); // Xóa dữ liệu cũ nếu có

                for (int i = 0; i < books.Count; i++)
                {
                    dgvTop5Book.Rows.Add(
                        i + 1,                       // STT
                        books[i].MaSach,            // Mã Sách
                        books[i].TenSach,           // Tên Sách
                        books[i].TongSL             // Tổng Số Lượng
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Quarter_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ TextBox và ComboBox
                int topN;
                int year;
                int quarter;

                if (!int.TryParse(txtTopN.Text, out topN) || topN <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số Top N hợp lệ (lớn hơn 0)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txt_Year.Text, out year) || year <= 0)
                {
                    MessageBox.Show("Vui lòng nhập năm hợp lệ (lớn hơn 0)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cb_Quarter.SelectedIndex < 0)
                {
                    MessageBox.Show("Vui lòng chọn quý hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy giá trị của quý từ ComboBox
                quarter = cb_Quarter.SelectedIndex + 1; // Giả sử ComboBox có các mục: "Quý 1", "Quý 2", ...

                // Gọi lớp BL để lấy dữ liệu
                BL_MostBorrowedBook bl = new BL_MostBorrowedBook();
                List<MostBorrowedBook_TO> books = bl.GetTopNBorrowedBooksByQuarter(year, quarter, topN);

                if (books == null || books.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu cho quý này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Hiển thị vào DataGridView
                dgvTop5Book.Rows.Clear(); // Xóa dữ liệu cũ nếu có

                for (int i = 0; i < books.Count; i++)
                {
                    dgvTop5Book.Rows.Add(
                        i + 1,                       // STT
                        books[i].MaSach,            // Mã Sách
                        books[i].TenSach,           // Tên Sách
                        books[i].TongSL             // Tổng Số Lượng
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Month_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ TextBox và ComboBox
                int topN;
                int year;
                int month;

                // Kiểm tra giá trị nhập vào cho số lượng sách top N
                if (!int.TryParse(txtTopN.Text, out topN) || topN <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số Top N hợp lệ (lớn hơn 0)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra giá trị năm nhập vào
                if (!int.TryParse(txt_Year.Text, out year) || year <= 0)
                {
                    MessageBox.Show("Vui lòng nhập năm hợp lệ (lớn hơn 0)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra xem có chọn tháng hay không
                if (cb_Month.SelectedIndex < 0)
                {
                    MessageBox.Show("Vui lòng chọn tháng hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy tháng từ ComboBox 
                month = cb_Month.SelectedIndex + 1;  // Index của ComboBox bắt đầu từ 0, vì vậy cộng thêm 1 để có giá trị tháng thực tế

                // Gọi lớp BL để lấy dữ liệu
                BL_MostBorrowedBook bl = new BL_MostBorrowedBook();
                List<MostBorrowedBook_TO> books = bl.GetTopNBorrowedBooksByMonth(year, month, topN);  // Gọi phương thức BL với tháng

                if (books == null || books.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu cho tháng đã chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Hiển thị dữ liệu vào DataGridView
                dgvTop5Book.Rows.Clear(); // Xóa dữ liệu cũ nếu có

                for (int i = 0; i < books.Count; i++)
                {
                    dgvTop5Book.Rows.Add(
                        i + 1,                       // STT
                        books[i].MaSach,            // Mã Sách
                        books[i].TenSach,           // Tên Sách
                        books[i].TongSL             // Tổng Số Lượng
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reports_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Nếu chưa xác nhận thoát hoặc chọn Không, hủy sự kiện đóng form
            if (!isExiting && !ConfirmExit())
            {
                e.Cancel = true;
            }
            else
            {
                isExiting = true; // Đánh dấu đã xác nhận thoát
                Environment.Exit(0); // Thoát toàn bộ ứng dụng
            }
        }

        private void pnlDashBoard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(employeeName, employeeRole, employeeID);
            dashboard.Show();
            this.Hide();
        }

        private void pnlProfile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(employeeName, employeeRole, employeeID);
            profile.Show();
            this.Hide();
        }

        private void pnlManageEmployees_Click(object sender, EventArgs e)
        {
            //Kiểm tra vai trò trước\
            string role = "Quản lý";
            if (!string.Equals(this.employeeRole, role, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Only managers are allowed to access this function.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Thoát khỏi sự kiện nếu không phải quản lý
            }

            ManageEmployees manageEmployees = new ManageEmployees(employeeName, employeeRole, employeeID);
            manageEmployees.Show();
            this.Hide();
        }

        private void pnlManageBooks_Click(object sender, EventArgs e)
        {
            ManageBooks managebooks = new ManageBooks(employeeName, employeeRole, employeeID);
            managebooks.Show();
            this.Hide();
        }

        private void pnlBorrowReturn_Click(object sender, EventArgs e)
        {
            BorrowReturn borrowReturn = new BorrowReturn(employeeName, employeeRole, employeeID);
            borrowReturn.Show();
            this.Hide();
        }

        private void pnlLogOut_Click(object sender, EventArgs e)
        {
            // Hiển thị MessageBox xác nhận đăng xuất
            DialogResult result = MessageBox.Show(
                "Do you want to log out?",
                "Log Out Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Nếu chọn Có, đóng form Dashboard và mở lại form DangNhap
                this.Hide(); // Ẩn form Dashboard hiện tại
                DangNhap loginForm = new DangNhap(); // Tạo mới form DangNhap
                loginForm.Show(); // Hiển thị form DangNhap
            }
            else
            {
                // Nếu chọn không, MessageBox tự tắt
            }
        }
    }
}
