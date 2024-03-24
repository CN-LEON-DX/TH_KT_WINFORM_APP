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
            if(date_NKC != null)
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
            string query = "SELECT MaBN FROM tblBenhNhan";

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
                            comboBox_id_NKC.Items.Add(row["MaBN"].ToString());
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
            string query = "SELECT TenBN FROM tblBenhNhan WHERE MaBN = @MaBN";
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
            string patient_id = comboBox_id_NKC.Text.ToString();
            DetailContract form = new DetailContract(patient_id, this);
            form.ShowDialog();
        }

        
    }
}
