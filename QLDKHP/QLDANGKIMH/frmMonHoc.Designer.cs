namespace QLDANGKIMH
{
    partial class frmMonHoc
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonHoc));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cbLoaiMon = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtSoTiet = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenMH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaMH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgvMonHoc = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.qLDKHPDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDKHPDataSet = new QLDANGKIMH.QLDKHPDataSet();
            this.btXoa = new DevComponents.DotNetBar.ButtonX();
            this.btHuy = new DevComponents.DotNetBar.ButtonX();
            this.btSua = new DevComponents.DotNetBar.ButtonX();
            this.btThem = new DevComponents.DotNetBar.ButtonX();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDKHPDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDKHPDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.cbLoaiMon);
            this.groupPanel1.Controls.Add(this.txtSoTiet);
            this.groupPanel1.Controls.Add(this.txtTenMH);
            this.groupPanel1.Controls.Add(this.txtMaMH);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(12, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(583, 86);
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
            this.groupPanel1.Text = "DANH SÁCH MÔN HỌC";
            // 
            // cbLoaiMon
            // 
            this.cbLoaiMon.DisplayMember = "Text";
            this.cbLoaiMon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLoaiMon.FormattingEnabled = true;
            this.cbLoaiMon.ItemHeight = 14;
            this.cbLoaiMon.Location = new System.Drawing.Point(87, 36);
            this.cbLoaiMon.Name = "cbLoaiMon";
            this.cbLoaiMon.Size = new System.Drawing.Size(121, 20);
            this.cbLoaiMon.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbLoaiMon.TabIndex = 7;
            // 
            // txtSoTiet
            // 
            // 
            // 
            // 
            this.txtSoTiet.Border.Class = "TextBoxBorder";
            this.txtSoTiet.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSoTiet.Location = new System.Drawing.Point(360, 36);
            this.txtSoTiet.Name = "txtSoTiet";
            this.txtSoTiet.PreventEnterBeep = true;
            this.txtSoTiet.Size = new System.Drawing.Size(77, 20);
            this.txtSoTiet.TabIndex = 6;
            // 
            // txtTenMH
            // 
            // 
            // 
            // 
            this.txtTenMH.Border.Class = "TextBoxBorder";
            this.txtTenMH.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenMH.Location = new System.Drawing.Point(360, 7);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.PreventEnterBeep = true;
            this.txtTenMH.Size = new System.Drawing.Size(157, 20);
            this.txtTenMH.TabIndex = 5;
            // 
            // txtMaMH
            // 
            // 
            // 
            // 
            this.txtMaMH.Border.Class = "TextBoxBorder";
            this.txtMaMH.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaMH.Location = new System.Drawing.Point(87, 7);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.PreventEnterBeep = true;
            this.txtMaMH.Size = new System.Drawing.Size(100, 20);
            this.txtMaMH.TabIndex = 4;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(279, 33);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(48, 23);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "Số tiết:";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(6, 33);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(58, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Loại môn:";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(279, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Tên môn học:";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(6, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Mã môn học: ";
            // 
            // dgvMonHoc
            // 
            this.dgvMonHoc.AutoGenerateColumns = false;
            this.dgvMonHoc.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMaMH,
            this.colTenMH,
            this.colLoaiMon,
            this.colSoTiet});
            this.dgvMonHoc.DataSource = this.qLDKHPDataSet;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMonHoc.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMonHoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvMonHoc.Location = new System.Drawing.Point(12, 148);
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.Size = new System.Drawing.Size(583, 150);
            this.dgvMonHoc.TabIndex = 1;
            // 
            // qLDKHPDataSetBindingSource
            // 
            this.qLDKHPDataSetBindingSource.DataSource = this.qLDKHPDataSet;
            this.qLDKHPDataSetBindingSource.Position = 0;
            // 
            // qLDKHPDataSet
            // 
            this.qLDKHPDataSet.DataSetName = "QLDKHPDataSet";
            this.qLDKHPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btXoa
            // 
            this.btXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.Location = new System.Drawing.Point(417, 104);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(84, 23);
            this.btXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btXoa.TabIndex = 11;
            this.btXoa.Text = "Xóa";
            // 
            // btHuy
            // 
            this.btHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btHuy.Image = global::QLDANGKIMH.Properties.Resources.cancel;
            this.btHuy.Location = new System.Drawing.Point(507, 104);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(87, 23);
            this.btHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btHuy.TabIndex = 10;
            this.btHuy.Text = "Hủy";
            // 
            // btSua
            // 
            this.btSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btSua.Image = ((System.Drawing.Image)(resources.GetObject("btSua.Image")));
            this.btSua.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btSua.Location = new System.Drawing.Point(330, 104);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(81, 23);
            this.btSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btSua.TabIndex = 9;
            this.btSua.Text = "Sửa";
            // 
            // btThem
            // 
            this.btThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btThem.Image = global::QLDANGKIMH.Properties.Resources.add;
            this.btThem.Location = new System.Drawing.Point(12, 104);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(84, 23);
            this.btThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btThem.TabIndex = 8;
            this.btThem.Text = "Thêm";
            // 
            // colSTT
            // 
            this.colSTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSTT.DataPropertyName = "loaimon";
            this.colSTT.HeaderText = "Stt";
            this.colSTT.Name = "colSTT";
            this.colSTT.Width = 50;
            // 
            // colMaMH
            // 
            this.colMaMH.HeaderText = "Mã môn học";
            this.colMaMH.Name = "colMaMH";
            // 
            // colTenMH
            // 
            this.colTenMH.HeaderText = "Tên môn học";
            this.colTenMH.Name = "colTenMH";
            this.colTenMH.Width = 210;
            // 
            // colLoaiMon
            // 
            this.colLoaiMon.DataPropertyName = "loaimon";
            this.colLoaiMon.HeaderText = "Loại môn";
            this.colLoaiMon.Name = "colLoaiMon";
            // 
            // colSoTiet
            // 
            this.colSoTiet.HeaderText = "Số tiết";
            this.colSoTiet.Name = "colSoTiet";
            this.colSoTiet.Width = 80;
            // 
            // frmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 310);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dgvMonHoc);
            this.Controls.Add(this.groupPanel1);
            this.Name = "frmMonHoc";
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDKHPDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDKHPDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvMonHoc;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbLoaiMon;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSoTiet;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenMH;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaMH;
        private DevComponents.DotNetBar.ButtonX btXoa;
        private DevComponents.DotNetBar.ButtonX btHuy;
        private DevComponents.DotNetBar.ButtonX btSua;
        private DevComponents.DotNetBar.ButtonX btThem;
        private System.Windows.Forms.BindingSource qLDKHPDataSetBindingSource;
        private QLDKHPDataSet qLDKHPDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoTiet;
    }
}