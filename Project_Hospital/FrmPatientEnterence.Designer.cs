namespace Project_Hospital
{
    partial class FrmPatientEnterence
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTc = new System.Windows.Forms.MaskedTextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LnkSignIn = new System.Windows.Forms.LinkLabel();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(86, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Entrance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(101, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(73, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // TxtTc
            // 
            this.TxtTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTc.Location = new System.Drawing.Point(187, 170);
            this.TxtTc.Mask = "00000000000";
            this.TxtTc.Name = "TxtTc";
            this.TxtTc.Size = new System.Drawing.Size(248, 26);
            this.TxtTc.TabIndex = 3;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPassword.Location = new System.Drawing.Point(187, 240);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(248, 26);
            this.TxtPassword.TabIndex = 4;
            // 
            // LnkSignIn
            // 
            this.LnkSignIn.AutoSize = true;
            this.LnkSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LnkSignIn.Location = new System.Drawing.Point(458, 241);
            this.LnkSignIn.Name = "LnkSignIn";
            this.LnkSignIn.Size = new System.Drawing.Size(73, 25);
            this.LnkSignIn.TabIndex = 5;
            this.LnkSignIn.TabStop = true;
            this.LnkSignIn.Text = "Sign In";
            // 
            // BtnEnter
            // 
            this.BtnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEnter.Location = new System.Drawing.Point(215, 304);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(163, 44);
            this.BtnEnter.TabIndex = 6;
            this.BtnEnter.Text = "Enter";
            this.BtnEnter.UseVisualStyleBackColor = true;
            // 
            // FrmPatientEnterence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(582, 381);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.LnkSignIn);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtTc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPatientEnterence";
            this.Text = "FrmPatientEnterence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox TxtTc;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.LinkLabel LnkSignIn;
        private System.Windows.Forms.Button BtnEnter;
    }
}