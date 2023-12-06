using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class LoaiPhongDAO
    {
        private string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLHN;Integrated Security=True;"; // Thay thế bằng chuỗi kết nối tới CSDL của bạn

        public List<LoaiPhong> GetAllLoaiPhong()
        {
            List<LoaiPhong> loaiPhongs = new List<LoaiPhong>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT maLoaiPhong, tenLoaiPhong FROM LoaiPhong";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    LoaiPhong loaiPhong = new LoaiPhong();
                    loaiPhong.MaLoaiPhong = reader["maLoaiPhong"].ToString();
                    loaiPhong.TenLoaiPhong = reader["tenLoaiPhong"].ToString();

                    loaiPhongs.Add(loaiPhong);
                }

                reader.Close();
            }

            return loaiPhongs;
        }

        public bool AddLoaiPhong(LoaiPhong loaiPhong)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO LoaiPhong (maLoaiPhong, tenLoaiPhong) VALUES (@MaLoaiPhong, @TenLoaiPhong)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaLoaiPhong", loaiPhong.MaLoaiPhong);
                command.Parameters.AddWithValue("@TenLoaiPhong", loaiPhong.TenLoaiPhong);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }

        public bool DeleteLoaiPhong(string maLoaiPhong)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM LoaiPhong WHERE maLoaiPhong = @MaLoaiPhong";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaLoaiPhong", maLoaiPhong);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }
        public bool UpdateLoaiPhong(LoaiPhong loaiPhong)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE LoaiPhong SET tenLoaiPhong = @TenLoaiPhong WHERE maLoaiPhong = @MaLoaiPhong";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TenLoaiPhong", loaiPhong.TenLoaiPhong);
                command.Parameters.AddWithValue("@MaLoaiPhong", loaiPhong.MaLoaiPhong);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                return rowsAffected > 0;
            }

        }
        public List<LoaiPhong> FilterLoaiPhongByMaLoaiPhong(string maLoaiPhong)
        {
            List<LoaiPhong> loaiPhongs = new List<LoaiPhong>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT maLoaiPhong, tenLoaiPhong FROM LoaiPhong WHERE maLoaiPhong = @MaLoaiPhong";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaLoaiPhong", maLoaiPhong);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    LoaiPhong loaiPhong = new LoaiPhong();
                    loaiPhong.MaLoaiPhong = reader["maLoaiPhong"].ToString();
                    loaiPhong.TenLoaiPhong = reader["tenLoaiPhong"].ToString();

                    loaiPhongs.Add(loaiPhong);
                }

                reader.Close();
            }

            return loaiPhongs;
        }
        public List<LoaiPhong> SearchLoaiPhongByTenLoaiPhong(string tenLoaiPhong)
        {
            List<LoaiPhong> loaiPhongs = new List<LoaiPhong>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT maLoaiPhong, tenLoaiPhong FROM LoaiPhong WHERE tenLoaiPhong LIKE @TenLoaiPhong";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TenLoaiPhong", "%" + tenLoaiPhong + "%");

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    LoaiPhong loaiPhong = new LoaiPhong();
                    loaiPhong.MaLoaiPhong = reader["maLoaiPhong"].ToString();
                    loaiPhong.TenLoaiPhong = reader["tenLoaiPhong"].ToString();

                    loaiPhongs.Add(loaiPhong);
                }

                reader.Close();
            }

            return loaiPhongs;
        }

    }
}
