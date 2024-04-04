using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KT_GK
{
    public partial class Form_BaoCao : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringKT_GK"].ConnectionString;
        public Form_BaoCao()
        {
            InitializeComponent();
        }

        private void Form_BaoCao_Load(object sender, EventArgs e)
        {
        }
        public void ShowReport(string name_report, string name_proc, List<string> parameters)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand comm = conn.CreateCommand())
                    {
                        comm.CommandText = name_proc;
                        comm.CommandType = CommandType.StoredProcedure;
                        int check_which_form = -1;
                        if (parameters.Count > 0)
                        {
                            comm.Parameters.AddWithValue("@sMaBN_NKC", parameters[0]);
                            check_which_form = 1;
                        }  else
                        {
                            check_which_form = 2;
                        }
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            adapter.SelectCommand = comm;
                            using (DataTable dt = new DataTable())
                            {
                                adapter.Fill(dt);
                                // Load data to report
                                ReportDocument report = new ReportDocument();
                                string path = string.Format("{0}\\BaoCao\\{1}",
                                    Application.StartupPath, name_report);
                                report.Load(path);
                                report.Database.Tables[name_proc].SetDataSource(dt);
                                
                                if (check_which_form == 1)
                                {
                                    // Day la ma benh nhan truyen vao
                                    report.SetParameterValue("sMaBN", parameters[0]);
                                    // Day la ten benh nhan truyen vao
                                    report.SetParameterValue("sHoTenBN", parameters[1]);
                                    report.SetParameterValue("sNguoiLap", "Nguyễn Chính Siu");
                                }
                                crystalReportViewer1.ReportSource = report;
                                crystalReportViewer1.Refresh();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error form report");
            }
        }

    }
}
