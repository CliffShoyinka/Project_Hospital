namespace Project_Hospital
{
    partial class FrmEntrances
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntrances));
            this.BtnPatientEntrance = new System.Windows.Forms.Button();
            this.BtnDoctorEntrance = new System.Windows.Forms.Button();
            this.BtnAssistantEntrance = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnPatientEntrance
            // 
            this.BtnPatientEntrance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPatientEntrance.BackgroundImage")));
            this.BtnPatientEntrance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPatientEntrance.Location = new System.Drawing.Point(22, 119);
            this.BtnPatientEntrance.Name = "BtnPatientEntrance";
            this.BtnPatientEntrance.Size = new System.Drawing.Size(179, 156);
            this.BtnPatientEntrance.TabIndex = 0;
            this.BtnPatientEntrance.UseVisualStyleBackColor = true;
            this.BtnPatientEntrance.Click += new System.EventHandler(this.BtnPatientEntrance_Click);
            // 
            // BtnDoctorEntrance
            // 
            this.BtnDoctorEntrance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDoctorEntrance.BackgroundImage")));
            this.BtnDoctorEntrance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDoctorEntrance.Location = new System.Drawing.Point(207, 119);
            this.BtnDoctorEntrance.Name = "BtnDoctorEntrance";
            this.BtnDoctorEntrance.Size = new System.Drawing.Size(179, 156);
            this.BtnDoctorEntrance.TabIndex = 1;
            this.BtnDoctorEntrance.UseVisualStyleBackColor = true;
            this.BtnDoctorEntrance.Click += new System.EventHandler(this.BtnDoctorEntrance_Click);
            // 
            // BtnAssistantEntrance
            // 
            this.BtnAssistantEntrance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAssistantEntrance.BackgroundImage")));
            this.BtnAssistantEntrance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAssistantEntrance.Location = new System.Drawing.Point(392, 119);
            this.BtnAssistantEntrance.Name = "BtnAssistantEntrance";
            this.BtnAssistantEntrance.Size = new System.Drawing.Size(179, 156);
            this.BtnAssistantEntrance.TabIndex = 2;
            this.BtnAssistantEntrance.UseVisualStyleBackColor = true;
            this.BtnAssistantEntrance.Click += new System.EventHandler(this.BtnAssistantEntrance_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(72, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Patient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(262, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doctor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(448, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Assistant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(18, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(525, 65);
            this.label4.TabIndex = 6;
            this.label4.Text = "PROJECT HOSPITAL";
            // 
            // FrmEntrances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(592, 341);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAssistantEntrance);
            this.Controls.Add(this.BtnDoctorEntrance);
            this.Controls.Add(this.BtnPatientEntrance);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmEntrances";
            this.Text = "Hospital Entrance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPatientEntrance;
        private System.Windows.Forms.Button BtnDoctorEntrance;
        private System.Windows.Forms.Button BtnAssistantEntrance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

