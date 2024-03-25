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

namespace KT_GK
{
    public partial class DetailContract : Form
    {
        private ITransferData _itransferData_NKC;
        private string pattient_id_NKC;
        private string connectionString_NKC = ConfigurationManager.ConnectionStrings["ConnectionStringKT_GK"].ConnectionString;

        public DetailContract(string patient_id, ITransferData itransferData)
        {
            this._itransferData_NKC = itransferData;
            this.pattient_id_NKC = patient_id;
            InitializeComponent();
        }
        



        private void DetailContract_Load(object sender, EventArgs e)
        {
            // Hieenj thong tin danh sach cac hop dong cua khach hang
            Load_Data_From_DB_Contract();
        }

        private void Load_Data_From_DB_Contract()
        {
            string proc = "proc_display_listcontract";

            using (SqlConnection conn = new SqlConnection(connectionString_NKC))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(proc, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MaBN_NKC", pattient_id_NKC);
                    DataTable dt_NKC = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt_NKC);
                    }
                    DataView dv = new DataView(dt_NKC);
                    // Sắp xếp các cột theo thứ tự
                    dv.Sort = "Ngay_NKC ASC";
                    
                    dtgv_NKC.DataSource = dv;


                    // Thiet lap ten :
                    dtgv_NKC.Columns[0].HeaderText = "Ngày tháng";
                    dtgv_NKC.Columns[1].HeaderText = "Mã bệnh nhân";
                    dtgv_NKC.Columns[2].HeaderText = "Danh sách dịch vụ";
                }
            }
        }

        private void cell_mouse_click_NKC(object sender, DataGridViewCellMouseEventArgs e)
        {
            //- Nếu click vào cell nào thì cell đó được thêm 
            // Truyền thông tin của dòng click vào bên giao diện gọi ban đầu
            // Lấy ngày tháng, đưa danh sách dịch vụ vào list view 
            // Lấy ngày từ cell được chọn
            // Kiểm tra xem cell được click có phải là header hay không
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
            {
                return;
            }

            string date = dtgv_NKC.Rows[e.RowIndex].Cells["Ngay_NKC"].Value?.ToString();
            string list_service = dtgv_NKC.Rows[e.RowIndex].Cells["DichVu_NKC"].Value?.ToString();

            if (!string.IsNullOrEmpty(date) && !string.IsNullOrEmpty(list_service))
            {
                _itransferData_NKC.XLDLieu_NKC(date, list_service);
                this.Close();
            }
        }

        
        

        
    }
}
