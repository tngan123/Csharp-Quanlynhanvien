namespace Csharp_Quanlynhanvien
{
    partial class Form1
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
            this.txtten = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.lsbhovaten = new System.Windows.Forms.ListBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "NHẬP HỌ VÀ TÊN";
            // 
            // txtten
            // 
            this.txtten.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtten.Location = new System.Drawing.Point(180, 146);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(321, 36);
            this.txtten.TabIndex = 1;
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(548, 146);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(115, 36);
            this.btnthem.TabIndex = 2;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.button1_Click);
            // 
            // lsbhovaten
            // 
            this.lsbhovaten.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbhovaten.FormattingEnabled = true;
            this.lsbhovaten.ItemHeight = 29;
            this.lsbhovaten.Location = new System.Drawing.Point(180, 211);
            this.lsbhovaten.Name = "lsbhovaten";
            this.lsbhovaten.Size = new System.Drawing.Size(607, 178);
            this.lsbhovaten.TabIndex = 3;
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(707, 146);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(115, 36);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(851, 144);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(115, 38);
            this.btnsua.TabIndex = 4;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 450);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.lsbhovaten);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.ListBox lsbhovaten;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
    }
}

