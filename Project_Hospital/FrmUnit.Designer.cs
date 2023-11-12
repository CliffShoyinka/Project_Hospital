namespace Project_Hospital
{
    partial class FrmUnit
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
            this.LblUnitId = new System.Windows.Forms.Label();
            this.LblUnitName = new System.Windows.Forms.Label();
            this.TxtUnitId = new System.Windows.Forms.TextBox();
            this.TxtUnitName = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblUnitId
            // 
            this.LblUnitId.AutoSize = true;
            this.LblUnitId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblUnitId.Location = new System.Drawing.Point(49, 52);
            this.LblUnitId.Name = "LblUnitId";
            this.LblUnitId.Size = new System.Drawing.Size(76, 25);
            this.LblUnitId.TabIndex = 0;
            this.LblUnitId.Text = "Unit ID:";
            // 
            // LblUnitName
            // 
            this.LblUnitName.AutoSize = true;
            this.LblUnitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblUnitName.Location = new System.Drawing.Point(16, 102);
            this.LblUnitName.Name = "LblUnitName";
            this.LblUnitName.Size = new System.Drawing.Size(109, 25);
            this.LblUnitName.TabIndex = 1;
            this.LblUnitName.Text = "Unit Name:";
            // 
            // TxtUnitId
            // 
            this.TxtUnitId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtUnitId.Location = new System.Drawing.Point(131, 51);
            this.TxtUnitId.Name = "TxtUnitId";
            this.TxtUnitId.Size = new System.Drawing.Size(154, 30);
            this.TxtUnitId.TabIndex = 2;
            // 
            // TxtUnitName
            // 
            this.TxtUnitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtUnitName.Location = new System.Drawing.Point(131, 102);
            this.TxtUnitName.Name = "TxtUnitName";
            this.TxtUnitName.Size = new System.Drawing.Size(154, 30);
            this.TxtUnitName.TabIndex = 3;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAdd.Location = new System.Drawing.Point(13, 174);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(58, 37);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDelete.Location = new System.Drawing.Point(91, 174);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(79, 37);
            this.BtnDelete.TabIndex = 5;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUpdate.Location = new System.Drawing.Point(188, 174);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(98, 37);
            this.BtnUpdate.TabIndex = 6;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(333, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(457, 214);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FrmUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(802, 248);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtUnitName);
            this.Controls.Add(this.TxtUnitId);
            this.Controls.Add(this.LblUnitName);
            this.Controls.Add(this.LblUnitId);
            this.Name = "FrmUnit";
            this.Text = "FrmUnit";
            this.Load += new System.EventHandler(this.FrmUnit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUnitId;
        private System.Windows.Forms.Label LblUnitName;
        private System.Windows.Forms.TextBox TxtUnitId;
        private System.Windows.Forms.TextBox TxtUnitName;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}