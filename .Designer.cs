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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_add_infor_patient = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_continue_save = new System.Windows.Forms.Button();
            this.rtbResult_NKC = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_history_list_NKC
            // 
            this.button_history_list_NKC.Image = ((System.Drawing.Image)(resources.GetObject("button_history_list_NKC.Image")));
            this.button_history_list_NKC.Location = new System.Drawing.Point(709, 412);
            this.button_history_list_NKC.Name = "button_history_list_NKC";
            this.button_history_list_NKC.Size = new System.Drawing.Size(81, 51);
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
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(470, 153);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "Năm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(273, 150);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tháng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(522, 211);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 23);
            this.label10.TabIndex = 1;
            this.label10.Text = "Danh sách dịch vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Chọn dịch vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(73, 103);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tên bệnh nhân";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã bệnh nhân";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thông tin bệnh nhân";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // button_add_infor_patient
            // 
            this.button_add_infor_patient.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add_infor_patient.Location = new System.Drawing.Point(99, 420);
            this.button_add_infor_patient.Name = "button_add_infor_patient";
            this.button_add_infor_patient.Size = new System.Drawing.Size(156, 43);
            this.button_add_infor_patient.TabIndex = 7;
            this.button_add_infor_patient.Text = "Chọn";
            this.button_add_infor_patient.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(504, 420);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 43);
            this.button3.TabIndex = 9;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button_continue_save
            // 
            this.button_continue_save.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_continue_save.Location = new System.Drawing.Point(295, 420);
            this.button_continue_save.Name = "button_continue_save";
            this.button_continue_save.Size = new System.Drawing.Size(156, 43);
            this.button_continue_save.TabIndex = 8;
            this.button_continue_save.Text = "Tiếp tục";
            this.button_continue_save.UseVisualStyleBackColor = true;
            this.button_continue_save.Click += new System.EventHandler(this.click_save_change);
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
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_continue_save);
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_add_infor_patient;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_continue_save;
        private System.Windows.Forms.RichTextBox rtbResult_NKC;
        private System.Windows.Forms.Label label6;
    }
}

