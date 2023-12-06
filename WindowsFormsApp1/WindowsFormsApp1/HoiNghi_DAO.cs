using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public class HoiNghiDAO
    {
        private string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLHN;Integrated Security=True;";

        public List<HoiNghi> GetAllHoiNghi()
        {
            List<HoiNghi> hoiNghis = new List<HoiNghi>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT maHoiNghi, tenHoiNghi, SoNguoi, maLoaiPhong FROM HoiNghi";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    HoiNghi hoiNghi = new HoiNghi();
                    hoiNghi.MaHoiNghi = reader["maHoiNghi"].ToString();
                    hoiNghi.TenHoiNghi = reader["tenHoiNghi"].ToString();
                    hoiNghi.SoNguoi = Convert.ToInt32(reader["SoNguoi"]);
                    hoiNghi.MaLoaiPhong = reader["maLoaiPhong"].ToString();

                    hoiNghis.Add(hoiNghi);
                }

                reader.Close();
            }

            return hoiNghis;
        }

        public bool AddHoiNghi(HoiNghi hoiNghi)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO HoiNghi (maHoiNghi, tenHoiNghi, SoNguoi, maLoaiPhong) VALUES (@MaHoiNghi, @TenHoiNghi, @SoNguoi, @MaLoaiPhong)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaHoiNghi", hoiNghi.MaHoiNghi);
                command.Parameters.AddWithValue("@TenHoiNghi", hoiNghi.TenHoiNghi);
                command.Parameters.AddWithValue("@SoNguoi", hoiNghi.SoNguoi);
                command.Parameters.AddWithValue("@MaLoaiPhong", hoiNghi.MaLoaiPhong);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }

        public bool DeleteHoiNghi(string maHoiNghi)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM HoiNghi WHERE maHoiNghi = @MaHoiNghi";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaHoiNghi", maHoiNghi);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }

        public List<HoiNghi> FilterByMaLoaiPhong(string maLoaiPhong)
        {
            List<HoiNghi> hoiNghis = new List<HoiNghi>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT maHoiNghi, tenHoiNghi, SoNguoi, maLoaiPhong FROM HoiNghi WHERE maLoaiPhong = @MaLoaiPhong";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaLoaiPhong", maLoaiPhong);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    HoiNghi hoiNghi = new HoiNghi();
                    hoiNghi.MaHoiNghi = reader["maHoiNghi"].ToString();
                    hoiNghi.TenHoiNghi = reader["tenHoiNghi"].ToString();
                    hoiNghi.SoNguoi = Convert.ToInt32(reader["SoNguoi"]);
                    hoiNghi.MaLoaiPhong = reader["maLoaiPhong"].ToString();

                    hoiNghis.Add(hoiNghi);
                }

                reader.Close();
            }

            return hoiNghis;
        }
    }
}
