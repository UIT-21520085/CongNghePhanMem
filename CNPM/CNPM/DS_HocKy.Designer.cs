namespace hocky
{
    partial class DS_HocKy
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.HocKy1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanDongHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button_add = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HocKy1,
            this.Nam,
            this.NgBatDau,
            this.NgKetThuc,
            this.HanDongHP,
            this.Sua});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 500);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // HocKy1
            // 
            this.HocKy1.DataPropertyName = "HocKy";
            this.HocKy1.HeaderText = "Học Kỳ";
            this.HocKy1.MinimumWidth = 6;
            this.HocKy1.Name = "HocKy1";
            this.HocKy1.Width = 62;
            // 
            // Nam
            // 
            this.Nam.DataPropertyName = "Nam";
            this.Nam.HeaderText = "Năm";
            this.Nam.MinimumWidth = 6;
            this.Nam.Name = "Nam";
            this.Nam.Width = 66;
            // 
            // NgBatDau
            // 
            this.NgBatDau.DataPropertyName = "NgBatDau";
            this.NgBatDau.HeaderText = "Ngày bắt đầu";
            this.NgBatDau.MinimumWidth = 6;
            this.NgBatDau.Name = "NgBatDau";
            this.NgBatDau.Width = 91;
            // 
            // NgKetThuc
            // 
            this.NgKetThuc.DataPropertyName = "NgKetThuc";
            this.NgKetThuc.HeaderText = "Ngày Kết Thúc";
            this.NgKetThuc.MinimumWidth = 6;
            this.NgKetThuc.Name = "NgKetThuc";
            this.NgKetThuc.Width = 120;
            // 
            // HanDongHP
            // 
            this.HanDongHP.DataPropertyName = "HanDongHP";
            this.HanDongHP.HeaderText = "Hạn Đóng Học Phí";
            this.HanDongHP.MinimumWidth = 6;
            this.HanDongHP.Name = "HanDongHP";
            this.HanDongHP.Width = 123;
            // 
            // Sua
            // 
            this.Sua.DataPropertyName = "Sua";
            this.Sua.HeaderText = "Sửa";
            this.Sua.MinimumWidth = 6;
            this.Sua.Name = "Sua";
            this.Sua.Text = "Sửa";
            this.Sua.UseColumnTextForButtonValue = true;
            this.Sua.Width = 39;
            // 
            // button_add
            // 
            this.button_add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_add.Location = new System.Drawing.Point(0, 552);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(800, 56);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "+ Thêm học kỳ";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_title
            // 
            this.label_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_title.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(0, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(800, 52);
            this.label_title.TabIndex = 16;
            this.label_title.Text = "Danh sách học kỳ";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DS_HocKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 608);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "DS_HocKy";
            this.Text = "Học Kỳ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocKy1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanDongHP;
        private System.Windows.Forms.DataGridViewButtonColumn Sua;
        private Label label_title;
    }
}
