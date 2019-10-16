namespace baitap5_xml
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenSp = new System.Windows.Forms.TextBox();
            this.txtLinkFile = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnChonFile = new System.Windows.Forms.Button();
            this.ptbHinhAnh = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.cbxTheloai = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXoaSp = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHinhAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thể loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hình ảnh";
            // 
            // txtTenSp
            // 
            this.txtTenSp.Location = new System.Drawing.Point(145, 8);
            this.txtTenSp.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenSp.Name = "txtTenSp";
            this.txtTenSp.Size = new System.Drawing.Size(494, 23);
            this.txtTenSp.TabIndex = 3;
            this.txtTenSp.TextChanged += new System.EventHandler(this.txtTenSp_TextChanged);
            // 
            // txtLinkFile
            // 
            this.txtLinkFile.Location = new System.Drawing.Point(145, 79);
            this.txtLinkFile.Margin = new System.Windows.Forms.Padding(5);
            this.txtLinkFile.Name = "txtLinkFile";
            this.txtLinkFile.Size = new System.Drawing.Size(258, 23);
            this.txtLinkFile.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(739, 14);
            this.btnThem.Margin = new System.Windows.Forms.Padding(5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(125, 81);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnChonFile
            // 
            this.btnChonFile.Location = new System.Drawing.Point(431, 102);
            this.btnChonFile.Margin = new System.Windows.Forms.Padding(5);
            this.btnChonFile.Name = "btnChonFile";
            this.btnChonFile.Size = new System.Drawing.Size(125, 35);
            this.btnChonFile.TabIndex = 7;
            this.btnChonFile.Text = "Chọn file...";
            this.btnChonFile.UseVisualStyleBackColor = true;
            this.btnChonFile.Click += new System.EventHandler(this.btnChonFile_Click);
            // 
            // ptbHinhAnh
            // 
            this.ptbHinhAnh.Location = new System.Drawing.Point(224, 164);
            this.ptbHinhAnh.Margin = new System.Windows.Forms.Padding(5);
            this.ptbHinhAnh.Name = "ptbHinhAnh";
            this.ptbHinhAnh.Size = new System.Drawing.Size(260, 175);
            this.ptbHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbHinhAnh.TabIndex = 8;
            this.ptbHinhAnh.TabStop = false;
            this.ptbHinhAnh.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 307);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Danh sách sản phẩm";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(14, 349);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(850, 482);
            this.dataGridView.TabIndex = 10;
            this.dataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseClick);
            // 
            // cbxTheloai
            // 
            this.cbxTheloai.DisplayMember = "--Chọn một--";
            this.cbxTheloai.FormattingEnabled = true;
            this.cbxTheloai.Location = new System.Drawing.Point(145, 44);
            this.cbxTheloai.Margin = new System.Windows.Forms.Padding(5);
            this.cbxTheloai.Name = "cbxTheloai";
            this.cbxTheloai.Size = new System.Drawing.Size(494, 25);
            this.cbxTheloai.TabIndex = 11;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(739, 113);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(125, 35);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xoá text";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXoaSp
            // 
            this.btnXoaSp.Location = new System.Drawing.Point(739, 297);
            this.btnXoaSp.Margin = new System.Windows.Forms.Padding(5);
            this.btnXoaSp.Name = "btnXoaSp";
            this.btnXoaSp.Size = new System.Drawing.Size(125, 35);
            this.btnXoaSp.TabIndex = 13;
            this.btnXoaSp.Text = "Xoá Sp";
            this.btnXoaSp.UseVisualStyleBackColor = true;
            this.btnXoaSp.Click += new System.EventHandler(this.btnXoaSp_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(739, 252);
            this.btnCapnhat.Margin = new System.Windows.Forms.Padding(5);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(125, 35);
            this.btnCapnhat.TabIndex = 14;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Mã sản phẩm";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(145, 117);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(95, 23);
            this.txtMaSP.TabIndex = 16;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(739, 164);
            this.btnTim.Margin = new System.Windows.Forms.Padding(5);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(125, 35);
            this.btnTim.TabIndex = 17;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 845);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.btnXoaSp);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.cbxTheloai);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ptbHinhAnh);
            this.Controls.Add(this.btnChonFile);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtLinkFile);
            this.Controls.Add(this.txtTenSp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Thêm sản phẩm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbHinhAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenSp;
        private System.Windows.Forms.TextBox txtLinkFile;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnChonFile;
        private System.Windows.Forms.PictureBox ptbHinhAnh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox cbxTheloai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXoaSp;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Button btnTim;
    }
}

