using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly HoiNghiDAO hoiNghiDAO = new HoiNghiDAO();
        private readonly LoaiPhongDAO loaiPhongDAO = new LoaiPhongDAO();
        public Form1()
        {
            InitializeComponent();

            // Khởi tạo DAO
            hoiNghiDAO = new HoiNghiDAO();
            loaiPhongDAO = new LoaiPhongDAO();

            // Load dữ liệu từ CSDL vào DataGridView và ComboBox khi form được khởi tạo
            dataGridViewHoiNghi.DataSource = hoiNghiDAO.GetAllHoiNghi();
            comboBoxLoaiPhong.DataSource = loaiPhongDAO.GetAllLoaiPhong();
            comboBoxLoaiPhong.DisplayMember = "MaLoaiPhong"; // Đổi thành property thích hợp
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Gọi lại phương thức load dữ liệu vào DataGridView
            LoadDataToDataGridView();
        }

        private void buttonThemMoi_Click(object sender, EventArgs e)
        {
            // Xóa trắng các TextBox và ComboBox, đặt con trỏ vào ô Mã Hội Nghị
            textBoxMaHoiNghi.Text = "";
            textBoxTenHoiNghi.Text = "";
            textBoxSoNguoi.Text = "";
            comboBoxLoaiPhong.SelectedIndex = 0;
            textBoxMaHoiNghi.Focus();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra tính hợp lệ của dữ liệu trước khi lưu
            if (!IsValidData())
            {
                return;
            }

            // Lưu dữ liệu vào CSDL và cập nhật lên DataGridView
            HoiNghi newHoiNghi = new HoiNghi
            {
                MaHoiNghi = textBoxMaHoiNghi.Text,
                TenHoiNghi = textBoxTenHoiNghi.Text,
                SoNguoi = int.Parse(textBoxSoNguoi.Text),
                MaLoaiPhong = comboBoxLoaiPhong.Text
            };

            hoiNghiDAO.AddHoiNghi(newHoiNghi);
            List<HoiNghi> hoiNghiList = hoiNghiDAO.GetAllHoiNghi();
            dataGridViewHoiNghi.DataSource = hoiNghiList;
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            // Xóa thông tin 1 hội nghị đang chọn
            if (dataGridViewHoiNghi.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hội nghị này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string maHoiNghiToDelete = dataGridViewHoiNghi.SelectedRows[0].Cells["maHoiNghi"].Value.ToString();
                    hoiNghiDAO.DeleteHoiNghi(maHoiNghiToDelete);
                    List<HoiNghi> hoiNghiList = hoiNghiDAO.GetAllHoiNghi();
                    dataGridViewHoiNghi.DataSource = hoiNghiList;
                }
            }
        }

        private void buttonKetThuc_Click(object sender, EventArgs e)
        {
            // Hiển thị MessageBox xác nhận việc đóng ứng dụng
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn đóng ứng dụng không?", "Xác nhận đóng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                // Đóng ứng dụng
                Application.Exit();
            }
        }

        private void buttonLoc_Click(object sender, EventArgs e)
        {
            // Lọc danh sách theo mã phòng hội nghị từ ComboBox
            string selectedMaLoaiPhong = comboBoxLoaiPhong.Text;
            List<HoiNghi> filteredList = hoiNghiDAO.FilterByMaLoaiPhong(selectedMaLoaiPhong);

            // Hiển thị danh sách lọc trên DataGridView
            dataGridViewHoiNghi.DataSource = null;
            dataGridViewHoiNghi.DataSource = filteredList;
        }

        private void dataGridViewHoiNghi_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewHoiNghi.SelectedRows.Count > 0)
            {
                // Kiểm tra nếu chỉ mục dòng được chọn không vượt quá số lượng dòng trong DataGridView
                if (dataGridViewHoiNghi.SelectedRows[0].Index < dataGridViewHoiNghi.Rows.Count)
                {
                    // Lấy dữ liệu từ DataGridView và hiển thị lên các TextBox tương ứng
                    DataGridViewRow selectedRow = dataGridViewHoiNghi.SelectedRows[0];
                    textBoxMaHoiNghi.Text = selectedRow.Cells["MaHoiNghi"].Value?.ToString();
                    textBoxTenHoiNghi.Text = selectedRow.Cells["TenHoiNghi"].Value?.ToString();
                    textBoxSoNguoi.Text = selectedRow.Cells["SoNguoi"].Value?.ToString();
                    comboBoxLoaiPhong.Text = selectedRow.Cells["MaLoaiPhong"].Value?.ToString();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Khi form được load, nạp dữ liệu từ CSDL lên các thành phần giao diện
            List<HoiNghi> hoiNghiList = hoiNghiDAO.GetAllHoiNghi();
            dataGridViewHoiNghi.DataSource = hoiNghiList;

            List<LoaiPhong> loaiPhongList = loaiPhongDAO.GetAllLoaiPhong();
            comboBoxLoaiPhong.DataSource = loaiPhongList;
            comboBoxLoaiPhong.DisplayMember = "MaLoaiPhong";
        }
        private bool IsValidData()
        {
            // Kiểm tra tính hợp lệ của dữ liệu
            if (string.IsNullOrWhiteSpace(textBoxMaHoiNghi.Text) || !textBoxMaHoiNghi.Text.StartsWith("HN") || textBoxMaHoiNghi.Text.Length != 5)
            {
                MessageBox.Show("Mã hội nghị không hợp lệ! Vui lòng nhập lại theo định dạng HNxxx.");
                textBoxMaHoiNghi.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxTenHoiNghi.Text) || textBoxTenHoiNghi.Text.Any(c => !char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Tên hội nghị không hợp lệ! Vui lòng chỉ nhập chữ, số và khoảng trắng.");
                textBoxTenHoiNghi.Focus();
                return false;
            }

            if (!int.TryParse(textBoxSoNguoi.Text, out int soNguoi) || soNguoi < 50)
            {
                MessageBox.Show("Số người tham gia không hợp lệ! Vui lòng nhập số nguyên >= 50.");
                textBoxSoNguoi.Focus();
                return false;
            }

            return true;
        }
        private void LoadDataToDataGridView()
        {
            // Đảm bảo rằng bạn thực hiện lại việc load dữ liệu từ CSDL vào DataGridView
            dataGridViewHoiNghi.DataSource = hoiNghiDAO.GetAllHoiNghi();
        }
    }
}
