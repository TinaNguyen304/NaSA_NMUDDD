namespace QLDANGKIMH
{
    partial class frmSVCHUAHOANTHANHHP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtHocKy = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNgaySinh = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoTienDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoTienPhaiDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoTienConLai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btXuat = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btXuat);
            this.groupPanel1.Controls.Add(this.dataGridViewX1);
            this.groupPanel1.Controls.Add(this.txtNgaySinh);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.txtHocKy);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(12, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(586, 184);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "DANH SÁCH SINH VIÊN CHƯA HOÀN THÀNH VIỆC ĐÓNG HỌC PHÍ";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(175, 14);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(44, 23);
            this.labelX5.TabIndex = 32;
            this.labelX5.Text = "Học Kỳ:";
            // 
            // txtHocKy
            // 
            // 
            // 
            // 
            this.txtHocKy.Border.Class = "TextBoxBorder";
            this.txtHocKy.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtHocKy.Location = new System.Drawing.Point(225, 14);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.PreventEnterBeep = true;
            this.txtHocKy.Size = new System.Drawing.Size(55, 20);
            this.txtHocKy.TabIndex = 31;
            // 
            // txtNgaySinh
            // 
            // 
            // 
            // 
            this.txtNgaySinh.BackgroundStyle.Class = "TextBoxBorder";
            this.txtNgaySinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNgaySinh.Location = new System.Drawing.Point(361, 17);
            this.txtNgaySinh.Mask = "0000-9999";
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(62, 20);
            this.txtNgaySinh.TabIndex = 34;
            this.txtNgaySinh.Text = "";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(304, 14);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(51, 23);
            this.labelX3.TabIndex = 33;
            this.labelX3.Text = "Năm học:";
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMSSV,
            this.colSoTienDK,
            this.colSoTienPhaiDong,
            this.colSoTienConLai});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(14, 54);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.Size = new System.Drawing.Size(554, 103);
            this.dataGridViewX1.TabIndex = 35;
            // 
            // colSTT
            // 
            this.colSTT.HeaderText = "Stt";
            this.colSTT.Name = "colSTT";
            this.colSTT.Width = 50;
            // 
            // colMSSV
            // 
            this.colMSSV.HeaderText = "Mã số sinh viên";
            this.colMSSV.Name = "colMSSV";
            this.colMSSV.Width = 120;
            // 
            // colSoTienDK
            // 
            this.colSoTienDK.HeaderText = "Số tiền đăng kí";
            this.colSoTienDK.Name = "colSoTienDK";
            this.colSoTienDK.Width = 120;
            // 
            // colSoTienPhaiDong
            // 
            this.colSoTienPhaiDong.HeaderText = "Số tiền phải đóng";
            this.colSoTienPhaiDong.Name = "colSoTienPhaiDong";
            this.colSoTienPhaiDong.Width = 120;
            // 
            // colSoTienConLai
            // 
            this.colSoTienConLai.HeaderText = "Số tiền còn lại";
            this.colSoTienConLai.Name = "colSoTienConLai";
            // 
            // btXuat
            // 
            this.btXuat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btXuat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btXuat.Image = global::QLDANGKIMH.Properties.Resources.Excel;
            this.btXuat.Location = new System.Drawing.Point(464, 14);
            this.btXuat.Name = "btXuat";
            this.btXuat.Size = new System.Drawing.Size(75, 23);
            this.btXuat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btXuat.TabIndex = 36;
            this.btXuat.Text = "Xuất";
            // 
            // frmSVCHUAHOANTHANHHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 203);
            this.Controls.Add(this.groupPanel1);
            this.Name = "frmSVCHUAHOANTHANHHP";
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtHocKy;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        public DevComponents.DotNetBar.Controls.MaskedTextBoxAdv txtNgaySinh;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoTienDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoTienPhaiDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoTienConLai;
        private DevComponents.DotNetBar.ButtonX btXuat;
    }
}