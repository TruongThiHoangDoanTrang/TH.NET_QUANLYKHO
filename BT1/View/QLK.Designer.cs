namespace BT1
{
    partial class QLK
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
            label1 = new Label();
            txtMaKho = new TextBox();
            txtTenKho = new TextBox();
            txtDiaChi = new TextBox();
            makho = new Label();
            tenkho = new Label();
            diachikho = new Label();
            panel1 = new Panel();
            btnthem = new Button();
            btnxoa = new Button();
            btntimkiem = new Button();
            btnsua = new Button();
            lstView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            btnload = new Button();
            txtTimKiem = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(295, 27);
            label1.Name = "label1";
            label1.Size = new Size(188, 37);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ KHO";
            // 
            // txtMaKho
            // 
            txtMaKho.Location = new Point(12, 137);
            txtMaKho.Name = "txtMaKho";
            txtMaKho.Size = new Size(118, 23);
            txtMaKho.TabIndex = 1;
            // 
            // txtTenKho
            // 
            txtTenKho.Location = new Point(291, 137);
            txtTenKho.Name = "txtTenKho";
            txtTenKho.Size = new Size(136, 23);
            txtTenKho.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(562, 137);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(128, 23);
            txtDiaChi.TabIndex = 3;
            // 
            // makho
            // 
            makho.AutoSize = true;
            makho.Location = new Point(48, 109);
            makho.Name = "makho";
            makho.Size = new Size(47, 15);
            makho.TabIndex = 4;
            makho.Text = "Mã kho";
            // 
            // tenkho
            // 
            tenkho.AutoSize = true;
            tenkho.Location = new Point(331, 109);
            tenkho.Name = "tenkho";
            tenkho.Size = new Size(48, 15);
            tenkho.TabIndex = 5;
            tenkho.Text = "Tên kho";
            // 
            // diachikho
            // 
            diachikho.AutoSize = true;
            diachikho.Location = new Point(600, 109);
            diachikho.Name = "diachikho";
            diachikho.Size = new Size(43, 15);
            diachikho.TabIndex = 6;
            diachikho.Text = "Địa chỉ";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(758, 100);
            panel1.TabIndex = 7;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(519, 217);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(75, 23);
            btnthem.TabIndex = 8;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click_1;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(600, 217);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(75, 23);
            btnxoa.TabIndex = 9;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click_1;
            // 
            // btntimkiem
            // 
            btntimkiem.Location = new Point(12, 184);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.Size = new Size(75, 23);
            btntimkiem.TabIndex = 10;
            btntimkiem.Text = "Tìm kiếm";
            btntimkiem.UseVisualStyleBackColor = true;
            btntimkiem.Click += btntimkiem_Click;
            // 
            // btnsua
            // 
            btnsua.Location = new Point(681, 217);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(75, 23);
            btnsua.TabIndex = 11;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click_1;
            // 
            // lstView
            // 
            lstView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lstView.Location = new Point(12, 246);
            lstView.Name = "lstView";
            lstView.Size = new Size(758, 115);
            lstView.TabIndex = 12;
            lstView.UseCompatibleStateImageBehavior = false;
            lstView.View = View.Details;
            lstView.Click += lstView_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã kho";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên kho";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Địa chỉ";
            columnHeader3.Width = 200;
            // 
            // btnload
            // 
            btnload.Location = new Point(438, 217);
            btnload.Name = "btnload";
            btnload.Size = new Size(75, 23);
            btnload.TabIndex = 13;
            btnload.Text = "Load";
            btnload.UseVisualStyleBackColor = true;
            btnload.Click += btnload_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(101, 185);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(264, 23);
            txtTimKiem.TabIndex = 15;
            // 
            // QLK
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 373);
            Controls.Add(txtTimKiem);
            Controls.Add(btnload);
            Controls.Add(lstView);
            Controls.Add(btnsua);
            Controls.Add(btntimkiem);
            Controls.Add(btnxoa);
            Controls.Add(btnthem);
            Controls.Add(panel1);
            Controls.Add(diachikho);
            Controls.Add(tenkho);
            Controls.Add(makho);
            Controls.Add(txtDiaChi);
            Controls.Add(txtTenKho);
            Controls.Add(txtMaKho);
            Name = "QLK";
            Text = "QLK";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMaKho;
        private TextBox txtTenKho;
        private TextBox txtDiaChi;
        private Label makho;
        private Label tenkho;
        private Label diachikho;
        private Panel panel1;
        private Button btnthem;
        private Button btnxoa;
        private Button btntimkiem;
        private Button btnsua;
        private ListView lstView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnload;
        private TextBox txtTimKiem;
    }
}