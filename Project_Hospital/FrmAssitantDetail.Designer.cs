namespace Project_Hospital
{
    partial class FrmAssitantDetail
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblNameSurname = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblTc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnCreateAnnouncement = new System.Windows.Forms.Button();
            this.RchAnnouncement = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.MskTc = new System.Windows.Forms.MaskedTextBox();
            this.CmbDoctor = new System.Windows.Forms.ComboBox();
            this.CmbUnit = new System.Windows.Forms.ComboBox();
            this.MskTime = new System.Windows.Forms.MaskedTextBox();
            this.MskDate = new System.Windows.Forms.MaskedTextBox();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BtnAppointmentsList = new System.Windows.Forms.Button();
            this.BtnUnitPanel = new System.Windows.Forms.Button();
            this.BtnDoctorPanel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblNameSurname);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.LblTc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assistant Detail";
            // 
            // LblNameSurname
            // 
            this.LblNameSurname.AutoSize = true;
            this.LblNameSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblNameSurname.Location = new System.Drawing.Point(15, 166);
            this.LblNameSurname.Name = "LblNameSurname";
            this.LblNameSurname.Size = new System.Drawing.Size(83, 25);
            this.LblNameSurname.TabIndex = 3;
            this.LblNameSurname.Text = "Null Null";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(15, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name Surname:";
            // 
            // LblTc
            // 
            this.LblTc.AutoSize = true;
            this.LblTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTc.Location = new System.Drawing.Point(15, 78);
            this.LblTc.Name = "LblTc";
            this.LblTc.Size = new System.Drawing.Size(133, 25);
            this.LblTc.TabIndex = 1;
            this.LblTc.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "TC No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnCreateAnnouncement);
            this.groupBox2.Controls.Add(this.RchAnnouncement);
            this.groupBox2.Location = new System.Drawing.Point(14, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 208);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create Announcement";
            // 
            // BtnCreateAnnouncement
            // 
            this.BtnCreateAnnouncement.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCreateAnnouncement.Location = new System.Drawing.Point(6, 164);
            this.BtnCreateAnnouncement.Name = "BtnCreateAnnouncement";
            this.BtnCreateAnnouncement.Size = new System.Drawing.Size(270, 38);
            this.BtnCreateAnnouncement.TabIndex = 4;
            this.BtnCreateAnnouncement.Text = "Create";
            this.BtnCreateAnnouncement.UseVisualStyleBackColor = true;
            this.BtnCreateAnnouncement.Click += new System.EventHandler(this.BtnCreateAnnouncement_Click);
            // 
            // RchAnnouncement
            // 
            this.RchAnnouncement.Location = new System.Drawing.Point(6, 19);
            this.RchAnnouncement.Name = "RchAnnouncement";
            this.RchAnnouncement.Size = new System.Drawing.Size(270, 139);
            this.RchAnnouncement.TabIndex = 0;
            this.RchAnnouncement.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnSave);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.MskTc);
            this.groupBox3.Controls.Add(this.CmbDoctor);
            this.groupBox3.Controls.Add(this.CmbUnit);
            this.groupBox3.Controls.Add(this.MskTime);
            this.groupBox3.Controls.Add(this.MskDate);
            this.groupBox3.Controls.Add(this.Txtid);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(315, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 433);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSave.Location = new System.Drawing.Point(57, 366);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(156, 38);
            this.BtnSave.TabIndex = 15;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(96, 322);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 26);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "State";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // MskTc
            // 
            this.MskTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTc.Location = new System.Drawing.Point(86, 247);
            this.MskTc.Mask = "00000000000";
            this.MskTc.Name = "MskTc";
            this.MskTc.Size = new System.Drawing.Size(178, 27);
            this.MskTc.TabIndex = 12;
            // 
            // CmbDoctor
            // 
            this.CmbDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbDoctor.FormattingEnabled = true;
            this.CmbDoctor.Location = new System.Drawing.Point(86, 210);
            this.CmbDoctor.Name = "CmbDoctor";
            this.CmbDoctor.Size = new System.Drawing.Size(178, 28);
            this.CmbDoctor.TabIndex = 11;
            // 
            // CmbUnit
            // 
            this.CmbUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbUnit.FormattingEnabled = true;
            this.CmbUnit.Location = new System.Drawing.Point(86, 173);
            this.CmbUnit.Name = "CmbUnit";
            this.CmbUnit.Size = new System.Drawing.Size(178, 28);
            this.CmbUnit.TabIndex = 10;
            this.CmbUnit.SelectedIndexChanged += new System.EventHandler(this.CmbUnit_SelectedIndexChanged);
            // 
            // MskTime
            // 
            this.MskTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTime.Location = new System.Drawing.Point(86, 136);
            this.MskTime.Mask = "00:00";
            this.MskTime.Name = "MskTime";
            this.MskTime.Size = new System.Drawing.Size(178, 27);
            this.MskTime.TabIndex = 9;
            this.MskTime.ValidatingType = typeof(System.DateTime);
            // 
            // MskDate
            // 
            this.MskDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskDate.Location = new System.Drawing.Point(86, 99);
            this.MskDate.Mask = "00/00/0000";
            this.MskDate.Name = "MskDate";
            this.MskDate.Size = new System.Drawing.Size(178, 27);
            this.MskDate.TabIndex = 8;
            this.MskDate.ValidatingType = typeof(System.DateTime);
            // 
            // Txtid
            // 
            this.Txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtid.Location = new System.Drawing.Point(86, 63);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(178, 27);
            this.Txtid.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(41, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 25);
            this.label10.TabIndex = 6;
            this.label10.Text = "TC:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(12, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Doctor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(34, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Unit:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(24, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(26, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(43, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(617, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(376, 278);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Units";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(370, 259);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(617, 299);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(376, 275);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doctors";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(370, 256);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.BtnAppointmentsList);
            this.groupBox6.Controls.Add(this.BtnUnitPanel);
            this.groupBox6.Controls.Add(this.BtnDoctorPanel);
            this.groupBox6.Location = new System.Drawing.Point(14, 476);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(583, 98);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "groupBox6";
            // 
            // BtnAppointmentsList
            // 
            this.BtnAppointmentsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAppointmentsList.Location = new System.Drawing.Point(258, 31);
            this.BtnAppointmentsList.Name = "BtnAppointmentsList";
            this.BtnAppointmentsList.Size = new System.Drawing.Size(168, 51);
            this.BtnAppointmentsList.TabIndex = 3;
            this.BtnAppointmentsList.Text = "Appointments List";
            this.BtnAppointmentsList.UseVisualStyleBackColor = true;
            this.BtnAppointmentsList.Click += new System.EventHandler(this.BtnAppointmentsList_Click);
            // 
            // BtnUnitPanel
            // 
            this.BtnUnitPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUnitPanel.Location = new System.Drawing.Point(143, 31);
            this.BtnUnitPanel.Name = "BtnUnitPanel";
            this.BtnUnitPanel.Size = new System.Drawing.Size(109, 51);
            this.BtnUnitPanel.TabIndex = 2;
            this.BtnUnitPanel.Text = "Unit Panel";
            this.BtnUnitPanel.UseVisualStyleBackColor = true;
            this.BtnUnitPanel.Click += new System.EventHandler(this.BtnUnitPanel_Click);
            // 
            // BtnDoctorPanel
            // 
            this.BtnDoctorPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDoctorPanel.Location = new System.Drawing.Point(2, 31);
            this.BtnDoctorPanel.Name = "BtnDoctorPanel";
            this.BtnDoctorPanel.Size = new System.Drawing.Size(135, 51);
            this.BtnDoctorPanel.TabIndex = 1;
            this.BtnDoctorPanel.Text = "Doctor Panel";
            this.BtnDoctorPanel.UseVisualStyleBackColor = true;
            this.BtnDoctorPanel.Click += new System.EventHandler(this.BtnDoctorPanel_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(432, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "Announcements";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAssitantDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1005, 586);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAssitantDetail";
            this.Text = "FrmAssitantDetail";
            this.Load += new System.EventHandler(this.FrmAssitantDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblNameSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button BtnCreateAnnouncement;
        private System.Windows.Forms.RichTextBox RchAnnouncement;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnAppointmentsList;
        private System.Windows.Forms.Button BtnUnitPanel;
        private System.Windows.Forms.Button BtnDoctorPanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.MaskedTextBox MskTc;
        private System.Windows.Forms.ComboBox CmbDoctor;
        private System.Windows.Forms.ComboBox CmbUnit;
        private System.Windows.Forms.MaskedTextBox MskTime;
        private System.Windows.Forms.MaskedTextBox MskDate;
        private System.Windows.Forms.TextBox Txtid;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
    }
}