using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KT_GK
{
    public partial class InforPatient : Form, ITransferData
    {
        private string connectionString_NKC = ConfigurationManager.ConnectionStrings["ConnectionStringKT_GK"].ConnectionString;
        private string date_NKC, list_service_NKC;
        public InforPatient()
        {
            InitializeComponent();
        }

        public void XLDLieu_NKC(string date, string list_service)
        {
            this.date_NKC = date;
            this.list_service_NKC = list_service;
            if (date_NKC != null)
            {
                DateTime birthday = Convert.ToDateTime(date_NKC);
                textBox_day_NKC.Text = birthday.Day.ToString();
                textBox_month_NKC.Text = birthday.Month.ToString();
                textBox_year_NKC.Text = birthday.Year.ToString();

            }
            // Đưa thông tin vào list view 
            listView_service_NKC.Items.Clear();
            // Đưa thông tin vào bên trong listView;
            string[] services = list_service.Split(',');
            foreach (string service in services)
            {
                ListViewItem item = new ListViewItem(service.Trim());
                listView_service_NKC.Items.Add(item);
            }
            // Sau đó hiển thị cho kích thước màn hình đạt tại 897, 760
            // mà người dùng không cần kéo ra
            // lây thông tin tên bệnh nhân, ngày thực hiện và list các danh sách dịch vụ đưa vào
            // richtextbox 
            // Hiển thị thông tin trong RichTextBox
            string patientInfo = "Tên bệnh nhân: " + textBox_name_NKC.Text + "\n";
            patientInfo += "Ngày thực hiện: " + textBox_day_NKC.Text + "/" + textBox_month_NKC.Text + "/" + textBox_year_NKC.Text + "\n";
            patientInfo += "Danh sách dịch vụ:\n";
            foreach (ListViewItem item in listView_service_NKC.Items)
            {
                patientInfo += "- " + item.Text + "\n";
            }

            rtbResult_NKC.Text = patientInfo;
            this.MaximumSize = new Size(780, 600);
            this.ClientSize = new Size(780, 600);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //- Khi load thì combo box sẽ được thêm các item bên trong 
            // lấy từ DB vơi 
            LoadData_ToComboBox();
            comboBox_id_NKC.SelectedIndex = 0;
        }

        private void LoadData_ToComboBox()
        {
            string query = "SELECT MaBN_NKC FROM tblBenhNhan_NKC";

            using (SqlConnection conn = new SqlConnection(connectionString_NKC))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        comboBox_id_NKC.Items.Clear();

                        foreach (DataRow row in dataTable.Rows)
                        {
                            comboBox_id_NKC.Items.Add(row["MaBN_NKC"].ToString());
                        }
                        comboBox_id_NKC.MaxDropDownItems = 5; // Số lượng mục tối đa hiển thị
                        comboBox_id_NKC.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                }
            }
        }
        // Hàm lấy tên bệnh nhân khi người dùng chọn BN
        private void tabindex_change_id(object sender, EventArgs e)
        {

        }

        private void Index_Change_Item_NKC(object sender, EventArgs e)
        {
            string patient_id = comboBox_id_NKC.SelectedItem.ToString();
            string query = "SELECT TenBN_NKC FROM tblBenhNhan_NKC WHERE MaBN_NKC = @MaBN";
            using (SqlConnection conn = new SqlConnection(connectionString_NKC))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@MaBN", patient_id);
                    string tenBenhNhan = command.ExecuteScalar().ToString();
                    textBox_name_NKC.Text = tenBenhNhan;
                }
            }
        }

        private void click_see_detail_contract_NKC(object sender, EventArgs e)
        {
            string patient_id_NKC = comboBox_id_NKC.Text.ToString();
            // Kiem tra ds trong 
            if (!CheckDSLS_HD_TonTai_TRONG_NKC(patient_id_NKC))
            {
                MessageBox.Show("Không có bản ghi nào !", "Thông báo");
            }
            else
            {
                DetailContract form = new DetailContract(patient_id_NKC, this);
                form.ShowDialog();
            }

        }

        private bool CheckDSLS_HD_TonTai_TRONG_NKC(string patient_id_NKC)
        {
            string query = "SELECT COUNT(*) FROM tblHopDong_NKC WHERE MaBN_NKC = @patient_id_NKC";
            int count = 0;

            // Sử dụng kết nối và truy vấn SQL
            using (SqlConnection conn = new SqlConnection(connectionString_NKC))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@patient_id_NKC", patient_id_NKC);
                    count = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return count > 0;
        }

        private void click_save_change(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận xóa thông tin không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                XoaThongTinHienTai();
            }

        }

        private void click_exit_program(object sender, EventArgs e)
        {
            this.Close();
        }

        private void click_see_report_medical(object sender, EventArgs e)
        {
            string sMaBN = comboBox_id_NKC.SelectedItem.ToString();
            string sTenBN = textBox_name_NKC.Text.ToString();
            List<string> list_service = new List<string>();
            list_service.Add(sMaBN);
            list_service.Add(sTenBN);
            foreach (string i in list_service)
            {
                Console.WriteLine(i);
            }
            Form_BaoCao form_report = new Form_BaoCao();
            form_report.Show();
            form_report.ShowReport("CR_DSKB.rpt", "select_list_service", list_service);
        }

        private void click_see_report_wtime(object sender, EventArgs e)
        {
            Form_BaoCao form = new Form_BaoCao();
            form.Show();
            List<string> list = new List<string>();
            // Chay ham show o day.
            form.ShowReport("CR_DSKB_TIME.rpt", "select_list_time", list);
        }

        private void XoaThongTinHienTai()
        {
            // Xóa thông tin trong các TextBox của GroupBox
            textBox_day_NKC.Clear();
            textBox_month_NKC.Clear();
            textBox_year_NKC.Clear();

            // Xóa thông tin trong ListView
            listView_service_NKC.Items.Clear();
            rtbResult_NKC.Clear();
        }
    }
}
