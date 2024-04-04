namespace KT_GK
{
    partial class InforPatient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InforPatient));
            this.button_history_list_NKC = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView_service_NKC = new System.Windows.Forms.ListView();
            this.comboBox_id_NKC = new System.Windows.Forms.ComboBox();
            this.comboBox_service_NKC = new System.Windows.Forms.ComboBox();
            this.textBox_year_NKC = new System.Windows.Forms.TextBox();
            this.textBox_month_NKC = new System.Windows.Forms.TextBox();
            this.textBox_day_NKC = new System.Windows.Forms.TextBox();
            this.textBox_name_NKC = new System.Windows.Forms.TextBox();
            this.label_year_NKC = new System.Windows.Forms.Label();
            this.label_MONTH_NKC = new System.Windows.Forms.Label();
            this.label_list_service_NKC = new System.Windows.Forms.Label();
            this.label_service_NKC = new System.Windows.Forms.Label();
            this.label_DAY_NKC = new System.Windows.Forms.Label();
            this.label_name_NKC = new System.Windows.Forms.Label();
            this.label_id_NKC = new System.Windows.Forms.Label();
            this.label_title_NKC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_add_infor_patient = new System.Windows.Forms.Button();
            this.button_exit_NKC = new System.Windows.Forms.Button();
            this.button_continue_save_NKC = new System.Windows.Forms.Button();
            this.rtbResult_NKC = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_mediclal_report = new System.Windows.Forms.Button();
            this.button_report_time = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_history_list_NKC
            // 
            this.button_history_list_NKC.Image = ((System.Drawing.Image)(resources.GetObject("button_history_list_NKC.Image")));
            this.button_history_list_NKC.Location = new System.Drawing.Point(761, 413);
            this.button_history_list_NKC.Name = "button_history_list_NKC";
            this.button_history_list_NKC.Size = new System.Drawing.Size(70, 58);
            this.button_history_list_NKC.TabIndex = 10;
            this.button_history_list_NKC.UseVisualStyleBackColor = true;
            this.button_history_list_NKC.Click += new System.EventHandler(this.click_see_detail_contract_NKC);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView_service_NKC);
            this.groupBox1.Controls.Add(this.comboBox_id_NKC);
            this.groupBox1.Controls.Add(this.comboBox_service_NKC);
            this.groupBox1.Controls.Add(this.textBox_year_NKC);
            this.groupBox1.Controls.Add(this.textBox_month_NKC);
            this.groupBox1.Controls.Add(this.textBox_day_NKC);
            this.groupBox1.Controls.Add(this.textBox_name_NKC);
            this.groupBox1.Controls.Add(this.label_year_NKC);
            this.groupBox1.Controls.Add(this.label_MONTH_NKC);
            this.groupBox1.Controls.Add(this.label_list_service_NKC);
            this.groupBox1.Controls.Add(this.label_service_NKC);
            this.groupBox1.Controls.Add(this.label_DAY_NKC);
            this.groupBox1.Controls.Add(this.label_name_NKC);
            this.groupBox1.Controls.Add(this.label_id_NKC);
            this.groupBox1.Controls.Add(this.label_title_NKC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(853, 380);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // listView_service_NKC
            // 
            this.listView_service_NKC.HideSelection = false;
            this.listView_service_NKC.Location = new System.Drawing.Point(526, 237);
            this.listView_service_NKC.Name = "listView_service_NKC";
            this.listView_service_NKC.Size = new System.Drawing.Size(274, 124);
            this.listView_service_NKC.TabIndex = 10;
            this.listView_service_NKC.UseCompatibleStateImageBehavior = false;
            this.listView_service_NKC.View = System.Windows.Forms.View.List;
            // 
            // comboBox_id_NKC
            // 
            this.comboBox_id_NKC.DropDownHeight = 70;
            this.comboBox_id_NKC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_id_NKC.FormattingEnabled = true;
            this.comboBox_id_NKC.IntegralHeight = false;
            this.comboBox_id_NKC.Location = new System.Drawing.Point(235, 62);
            this.comboBox_id_NKC.Name = "comboBox_id_NKC";
            this.comboBox_id_NKC.Size = new System.Drawing.Size(282, 28);
            this.comboBox_id_NKC.TabIndex = 1;
            this.comboBox_id_NKC.Text = "BN001";
            this.comboBox_id_NKC.SelectedIndexChanged += new System.EventHandler(this.Index_Change_Item_NKC);
            // 
            // comboBox_service_NKC
            // 
            this.comboBox_service_NKC.FormattingEnabled = true;
            this.comboBox_service_NKC.Items.AddRange(new object[] {
            "Nâng mũi",
            "Sửa răng hàm",
            "Xăm lông mày",
            "Cắt môi trái tim",
            "Triệt lông"});
            this.comboBox_service_NKC.Location = new System.Drawing.Point(210, 211);
            this.comboBox_service_NKC.Name = "comboBox_service_NKC";
            this.comboBox_service_NKC.Size = new System.Drawing.Size(228, 25);
            this.comboBox_service_NKC.TabIndex = 6;
            // 
            // textBox_year_NKC
            // 
            this.textBox_year_NKC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_year_NKC.Location = new System.Drawing.Point(526, 151);
            this.textBox_year_NKC.Name = "textBox_year_NKC";
            this.textBox_year_NKC.Size = new System.Drawing.Size(100, 27);
            this.textBox_year_NKC.TabIndex = 5;
            // 
            // textBox_month_NKC
            // 
            this.textBox_month_NKC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_month_NKC.Location = new System.Drawing.Point(338, 148);
            this.textBox_month_NKC.Name = "textBox_month_NKC";
            this.textBox_month_NKC.Size = new System.Drawing.Size(100, 27);
            this.textBox_month_NKC.TabIndex = 4;
            // 
            // textBox_day_NKC
            // 
            this.textBox_day_NKC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_day_NKC.Location = new System.Drawing.Point(149, 150);
            this.textBox_day_NKC.Name = "textBox_day_NKC";
            this.textBox_day_NKC.Size = new System.Drawing.Size(93, 27);
            this.textBox_day_NKC.TabIndex = 3;
            // 
            // textBox_name_NKC
            // 
            this.textBox_name_NKC.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_name_NKC.Location = new System.Drawing.Point(235, 100);
            this.textBox_name_NKC.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_name_NKC.Name = "textBox_name_NKC";
            this.textBox_name_NKC.Size = new System.Drawing.Size(282, 30);
            this.textBox_name_NKC.TabIndex = 2;
            // 
            // label_year_NKC
            // 
            this.label_year_NKC.AutoSize = true;
            this.label_year_NKC.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_year_NKC.Location = new System.Drawing.Point(470, 153);
            this.label_year_NKC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_year_NKC.Name = "label_year_NKC";
            this.label_year_NKC.Size = new System.Drawing.Size(47, 23);
            this.label_year_NKC.TabIndex = 1;
            this.label_year_NKC.Text = "Năm";
            // 
            // label_MONTH_NKC
            // 
            this.label_MONTH_NKC.AutoSize = true;
            this.label_MONTH_NKC.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MONTH_NKC.Location = new System.Drawing.Point(273, 150);
            this.label_MONTH_NKC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_MONTH_NKC.Name = "label_MONTH_NKC";
            this.label_MONTH_NKC.Size = new System.Drawing.Size(58, 23);
            this.label_MONTH_NKC.TabIndex = 1;
            this.label_MONTH_NKC.Text = "Tháng";
            // 
            // label_list_service_NKC
            // 
            this.label_list_service_NKC.AutoSize = true;
            this.label_list_service_NKC.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_list_service_NKC.Location = new System.Drawing.Point(522, 211);
            this.label_list_service_NKC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_list_service_NKC.Name = "label_list_service_NKC";
            this.label_list_service_NKC.Size = new System.Drawing.Size(150, 23);
            this.label_list_service_NKC.TabIndex = 1;
            this.label_list_service_NKC.Text = "Danh sách dịch vụ";
            // 
            // label_service_NKC
            // 
            this.label_service_NKC.AutoSize = true;
            this.label_service_NKC.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_service_NKC.Location = new System.Drawing.Point(73, 210);
            this.label_service_NKC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_service_NKC.Name = "label_service_NKC";
            this.label_service_NKC.Size = new System.Drawing.Size(111, 23);
            this.label_service_NKC.TabIndex = 1;
            this.label_service_NKC.Text = "Chọn dịch vụ";
            // 
            // label_DAY_NKC
            // 
            this.label_DAY_NKC.AutoSize = true;
            this.label_DAY_NKC.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DAY_NKC.Location = new System.Drawing.Point(73, 153);
            this.label_DAY_NKC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DAY_NKC.Name = "label_DAY_NKC";
            this.label_DAY_NKC.Size = new System.Drawing.Size(50, 23);
            this.label_DAY_NKC.TabIndex = 1;
            this.label_DAY_NKC.Text = "Ngày";
            // 
            // label_name_NKC
            // 
            this.label_name_NKC.AutoSize = true;
            this.label_name_NKC.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name_NKC.Location = new System.Drawing.Point(73, 103);
            this.label_name_NKC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_name_NKC.Name = "label_name_NKC";
            this.label_name_NKC.Size = new System.Drawing.Size(124, 23);
            this.label_name_NKC.TabIndex = 1;
            this.label_name_NKC.Text = "Tên bệnh nhân";
            // 
            // label_id_NKC
            // 
            this.label_id_NKC.AutoSize = true;
            this.label_id_NKC.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id_NKC.Location = new System.Drawing.Point(73, 61);
            this.label_id_NKC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_id_NKC.Name = "label_id_NKC";
            this.label_id_NKC.Size = new System.Drawing.Size(122, 23);
            this.label_id_NKC.TabIndex = 1;
            this.label_id_NKC.Text = "Mã bệnh nhân";
            // 
            // label_title_NKC
            // 
            this.label_title_NKC.AutoSize = true;
            this.label_title_NKC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title_NKC.Location = new System.Drawing.Point(22, 15);
            this.label_title_NKC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_title_NKC.Name = "label_title_NKC";
            this.label_title_NKC.Size = new System.Drawing.Size(193, 28);
            this.label_title_NKC.TabIndex = 1;
            this.label_title_NKC.Text = "Thông tin bệnh nhân";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 0;
            // 
            // button_add_infor_patient
            // 
            this.button_add_infor_patient.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add_infor_patient.Location = new System.Drawing.Point(50, 420);
            this.button_add_infor_patient.Name = "button_add_infor_patient";
            this.button_add_infor_patient.Size = new System.Drawing.Size(108, 43);
            this.button_add_infor_patient.TabIndex = 7;
            this.button_add_infor_patient.Text = "Chọn";
            this.button_add_infor_patient.UseVisualStyleBackColor = true;
            // 
            // button_exit_NKC
            // 
            this.button_exit_NKC.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit_NKC.Location = new System.Drawing.Point(307, 420);
            this.button_exit_NKC.Name = "button_exit_NKC";
            this.button_exit_NKC.Size = new System.Drawing.Size(96, 43);
            this.button_exit_NKC.TabIndex = 9;
            this.button_exit_NKC.Text = "Thoát";
            this.button_exit_NKC.UseVisualStyleBackColor = true;
            this.button_exit_NKC.Click += new System.EventHandler(this.click_exit_program);
            // 
            // button_continue_save_NKC
            // 
            this.button_continue_save_NKC.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_continue_save_NKC.Location = new System.Drawing.Point(179, 420);
            this.button_continue_save_NKC.Name = "button_continue_save_NKC";
            this.button_continue_save_NKC.Size = new System.Drawing.Size(103, 43);
            this.button_continue_save_NKC.TabIndex = 8;
            this.button_continue_save_NKC.Text = "Tiếp tục";
            this.button_continue_save_NKC.UseVisualStyleBackColor = true;
            this.button_continue_save_NKC.Click += new System.EventHandler(this.click_save_change);
            // 
            // rtbResult_NKC
            // 
            this.rtbResult_NKC.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbResult_NKC.Location = new System.Drawing.Point(29, 537);
            this.rtbResult_NKC.Name = "rtbResult_NKC";
            this.rtbResult_NKC.Size = new System.Drawing.Size(811, 212);
            this.rtbResult_NKC.TabIndex = 14;
            this.rtbResult_NKC.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(46, 502);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 28);
            this.label6.TabIndex = 13;
            this.label6.Text = "Kết quả";
            // 
            // button_mediclal_report
            // 
            this.button_mediclal_report.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_mediclal_report.Location = new System.Drawing.Point(431, 420);
            this.button_mediclal_report.Name = "button_mediclal_report";
            this.button_mediclal_report.Size = new System.Drawing.Size(142, 43);
            this.button_mediclal_report.TabIndex = 9;
            this.button_mediclal_report.Text = "Sổ khám bệnh";
            this.button_mediclal_report.UseVisualStyleBackColor = true;
            this.button_mediclal_report.Click += new System.EventHandler(this.click_see_report_medical);
            // 
            // button_report_time
            // 
            this.button_report_time.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_report_time.Location = new System.Drawing.Point(599, 420);
            this.button_report_time.Name = "button_report_time";
            this.button_report_time.Size = new System.Drawing.Size(142, 43);
            this.button_report_time.TabIndex = 9;
            this.button_report_time.Text = "Sổ KB thời gian";
            this.button_report_time.UseVisualStyleBackColor = true;
            this.button_report_time.Click += new System.EventHandler(this.click_see_report_wtime);
            // 
            // InforPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 493);
            this.Controls.Add(this.rtbResult_NKC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_history_list_NKC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_add_infor_patient);
            this.Controls.Add(this.button_report_time);
            this.Controls.Add(this.button_mediclal_report);
            this.Controls.Add(this.button_exit_NKC);
            this.Controls.Add(this.button_continue_save_NKC);
            this.MinimumSize = new System.Drawing.Size(897, 540);
            this.Name = "InforPatient";
            this.Text = "Thông tin bệnh nhân";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_history_list_NKC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView_service_NKC;
        private System.Windows.Forms.ComboBox comboBox_id_NKC;
        private System.Windows.Forms.ComboBox comboBox_service_NKC;
        private System.Windows.Forms.TextBox textBox_year_NKC;
        private System.Windows.Forms.TextBox textBox_month_NKC;
        private System.Windows.Forms.TextBox textBox_day_NKC;
        private System.Windows.Forms.TextBox textBox_name_NKC;
        private System.Windows.Forms.Label label_year_NKC;
        private System.Windows.Forms.Label label_MONTH_NKC;
        private System.Windows.Forms.Label label_list_service_NKC;
        private System.Windows.Forms.Label label_service_NKC;
        private System.Windows.Forms.Label label_DAY_NKC;
        private System.Windows.Forms.Label label_name_NKC;
        private System.Windows.Forms.Label label_id_NKC;
        private System.Windows.Forms.Label label_title_NKC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_add_infor_patient;
        private System.Windows.Forms.Button button_exit_NKC;
        private System.Windows.Forms.Button button_continue_save_NKC;
        private System.Windows.Forms.RichTextBox rtbResult_NKC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_mediclal_report;
        private System.Windows.Forms.Button button_report_time;
    }
}

