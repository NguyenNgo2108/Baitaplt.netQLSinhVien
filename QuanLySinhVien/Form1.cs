using System.Data;
using System.Data.SqlClient;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataSet layThongTinSinhVien()
        {
            DataSet data = new DataSet();

            String query = "SELECT * FROM SinhVien";

            using (SqlConnection con = new SqlConnection(KetNoi.chuoiKN))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(data);
            }
            return data;
        }


        private void tbTenSinhVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMaSinhVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDiemTrungBinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbLop_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string TenSinhVien = tbTenSinhVien.Text;
                string MaSinhVien = tbMaSinhVien.Text;
                decimal DiemTrungBinh;
                if (!decimal.TryParse(tbDiemTrungBinh.Text, out DiemTrungBinh))
                {
                    MessageBox.Show("Điểm trung bình không hợp lệ.");
                    return;
                }
                string Lop = tbLop.Text;
                string query = "INSERT INTO SinhVien (TenSinhVien, MaSinhVien, DiemTrungBinh, Lop) VALUES (@TenSinhVien, @MaSinhVien, @DiemTrungBinh, @Lop)";

                using (SqlConnection con = new SqlConnection(KetNoi.chuoiKN))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@TenSinhVien", TenSinhVien);
                        cmd.Parameters.AddWithValue("@MaSinhVien", MaSinhVien);
                        cmd.Parameters.AddWithValue("@DiemTrungBinh", DiemTrungBinh);
                        cmd.Parameters.AddWithValue("@Lop", Lop);


                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm thông tin sinh viên thành công!");
                    }
                }

                dataGridView1.DataSource = layThongTinSinhVien().Tables[0];

                tbTenSinhVien.Clear();
                tbMaSinhVien.Clear();
                tbDiemTrungBinh.Clear();
                tbLop.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string TenSinhVien = tbTenSinhVien.Text;
                    string MaSinhVien = tbMaSinhVien.Text;
                    decimal DiemTrungBinh;
                    if (!decimal.TryParse(tbDiemTrungBinh.Text, out DiemTrungBinh))
                    {
                        MessageBox.Show("Điểm trung bình không hợp lệ.");
                        return;
                    }
                    string Lop = tbLop.Text;

                    // Kiểm tra xem mã sinh viên có được nhập không
                    if (string.IsNullOrEmpty(MaSinhVien))
                    {
                        MessageBox.Show("Vui lòng nhập mã sinh viên để sửa thông tin.");
                        return;
                    }

                    string query = "UPDATE SinhVien SET TenSinhVien = @TenSinhVien, DiemTrungBinh = @DiemTrungBinh, Lop = @Lop WHERE MaSinhVien = @MaSinhVien";

                    using (SqlConnection con = new SqlConnection(KetNoi.chuoiKN))
                    {
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@TenSinhVien", TenSinhVien);
                            cmd.Parameters.AddWithValue("@DiemTrungBinh", DiemTrungBinh);
                            cmd.Parameters.AddWithValue("@Lop", Lop);
                            cmd.Parameters.AddWithValue("@MaSinhVien", MaSinhVien);

                            con.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Sửa thông tin sinh viên thành công!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string MaSinhVien = tbMaSinhVien.Text;

                // Kiểm tra mã sinh viên
                if (string.IsNullOrEmpty(MaSinhVien))
                {
                    MessageBox.Show("Vui lòng nhập mã sinh viên để xóa thông tin.");
                    return;
                }

                string query = "DELETE FROM SinhVien WHERE MaSinhVien = @MaSinhVien";

                using (SqlConnection con = new SqlConnection(KetNoi.chuoiKN))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MaSinhVien", MaSinhVien);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa thông tin sinh viên thành công!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = layThongTinSinhVien().Tables[0];
        }

    }
}
