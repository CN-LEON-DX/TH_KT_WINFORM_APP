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

                    // Thêm tham số vào Procedure
                    cmd.Parameters.AddWithValue("@MaBN", pattient_id_NKC);

                    // Lấy dữ liệu từ database
                    DataTable dt = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                    // Tạo DataView mới
                    DataView dv = new DataView(dt);
                    // Sắp xếp các cột theo thứ tự
                    dv.Sort = "Ngay ASC";
                    
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
            string date = dtgv_NKC.Rows[e.RowIndex].Cells["Ngay"].Value.ToString();
            string list_service = dtgv_NKC.Rows[e.RowIndex].Cells["DichVu"].Value.ToString();

            // Tạo một instance mới của DetailContract
            _itransferData_NKC.XLDLieu_NKC(date, list_service);
            this.Close();
        }

        
        

        
    }
}
