﻿namespace VNS.HIS.UI.THUOC
{
    partial class frm_PhieuNhapKho
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
            Janus.Windows.UI.StatusBar.UIStatusBarPanel uiStatusBarPanel1 = new Janus.Windows.UI.StatusBar.UIStatusBarPanel();
            Janus.Windows.UI.StatusBar.UIStatusBarPanel uiStatusBarPanel2 = new Janus.Windows.UI.StatusBar.UIStatusBarPanel();
            Janus.Windows.UI.StatusBar.UIStatusBarPanel uiStatusBarPanel3 = new Janus.Windows.UI.StatusBar.UIStatusBarPanel();
            Janus.Windows.UI.StatusBar.UIStatusBarPanel uiStatusBarPanel4 = new Janus.Windows.UI.StatusBar.UIStatusBarPanel();
            Janus.Windows.UI.StatusBar.UIStatusBarPanel uiStatusBarPanel5 = new Janus.Windows.UI.StatusBar.UIStatusBarPanel();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PhieuNhapKho));
            Janus.Windows.GridEX.GridEXLayout grdList_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdPhieuNhapChiTiet_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.uiStatusBar1 = new Janus.Windows.UI.StatusBar.UIStatusBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cmdThemPhieuNhap = new System.Windows.Forms.ToolStripButton();
            this.cmdUpdatePhieuNhap = new System.Windows.Forms.ToolStripButton();
            this.cmdXoaPhieuNhap = new System.Windows.Forms.ToolStripButton();
            this.cmdNhapKho = new System.Windows.Forms.ToolStripButton();
            this.cmdHuyXacnhan = new System.Windows.Forms.ToolStripButton();
            this.cmdInPhieuNhapKho = new System.Windows.Forms.ToolStripButton();
            this.cmdExit = new System.Windows.Forms.ToolStripButton();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.txtNhacungcap = new VNS.HIS.UCs.AutoCompleteTextbox_Danhmucchung();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboKhoThuoc = new Janus.Windows.EditControls.UIComboBox();
            this.radChuaNhapKho = new Janus.Windows.EditControls.UIRadioButton();
            this.radDaNhap = new Janus.Windows.EditControls.UIRadioButton();
            this.radTatCa = new Janus.Windows.EditControls.UIRadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cboNhanVien = new Janus.Windows.EditControls.UIComboBox();
            this.cmdSearch = new Janus.Windows.EditControls.UIButton();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.chkByDate = new Janus.Windows.EditControls.UICheckBox();
            this.dtFromdate = new System.Windows.Forms.DateTimePicker();
            this.txtSoPhieu = new Janus.Windows.GridEX.EditControls.EditBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.uiGroupBox2 = new Janus.Windows.EditControls.UIGroupBox();
            this.grdList = new Janus.Windows.GridEX.GridEX();
            this.uiGroupBox4 = new Janus.Windows.EditControls.UIGroupBox();
            this.grdPhieuNhapChiTiet = new Janus.Windows.GridEX.GridEX();
            this.cmdConfig = new Janus.Windows.EditControls.UIButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).BeginInit();
            this.uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox4)).BeginInit();
            this.uiGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPhieuNhapChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // uiStatusBar1
            // 
            this.uiStatusBar1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiStatusBar1.Location = new System.Drawing.Point(0, 713);
            this.uiStatusBar1.Name = "uiStatusBar1";
            uiStatusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            uiStatusBarPanel1.BorderColor = System.Drawing.Color.Empty;
            uiStatusBarPanel1.Key = "";
            uiStatusBarPanel1.ProgressBarValue = 0;
            uiStatusBarPanel1.Text = "Ctrl+N: Thêm phiếu";
            uiStatusBarPanel1.Width = 122;
            uiStatusBarPanel2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            uiStatusBarPanel2.BorderColor = System.Drawing.Color.Empty;
            uiStatusBarPanel2.Key = "";
            uiStatusBarPanel2.ProgressBarValue = 0;
            uiStatusBarPanel2.Text = "Ctrl+E: Sửa phiếu";
            uiStatusBarPanel2.Width = 112;
            uiStatusBarPanel3.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            uiStatusBarPanel3.BorderColor = System.Drawing.Color.Empty;
            uiStatusBarPanel3.Key = "";
            uiStatusBarPanel3.ProgressBarValue = 0;
            uiStatusBarPanel3.Text = "Ctrl+D: Xóa phiếu";
            uiStatusBarPanel3.Width = 111;
            uiStatusBarPanel4.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            uiStatusBarPanel4.BorderColor = System.Drawing.Color.Empty;
            uiStatusBarPanel4.Key = "";
            uiStatusBarPanel4.ProgressBarValue = 0;
            uiStatusBarPanel4.Text = "Esc: Thoát chức năng";
            uiStatusBarPanel4.Width = 134;
            uiStatusBarPanel5.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            uiStatusBarPanel5.BorderColor = System.Drawing.Color.Empty;
            uiStatusBarPanel5.FormatStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            uiStatusBarPanel5.FormatStyle.FontBold = Janus.Windows.UI.TriState.True;
            uiStatusBarPanel5.FormatStyle.ForeColor = System.Drawing.Color.Navy;
            uiStatusBarPanel5.Key = "MSG";
            uiStatusBarPanel5.ProgressBarValue = 0;
            uiStatusBarPanel5.Text = "Thông báo";
            uiStatusBarPanel5.Width = 74;
            this.uiStatusBar1.Panels.AddRange(new Janus.Windows.UI.StatusBar.UIStatusBarPanel[] {
            uiStatusBarPanel1,
            uiStatusBarPanel2,
            uiStatusBarPanel3,
            uiStatusBarPanel4,
            uiStatusBarPanel5});
            this.uiStatusBar1.Size = new System.Drawing.Size(1018, 27);
            this.uiStatusBar1.TabIndex = 0;
            this.uiStatusBar1.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdThemPhieuNhap,
            this.cmdUpdatePhieuNhap,
            this.cmdXoaPhieuNhap,
            this.cmdNhapKho,
            this.cmdHuyXacnhan,
            this.cmdInPhieuNhapKho,
            this.cmdExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1018, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cmdThemPhieuNhap
            // 
            this.cmdThemPhieuNhap.Image = ((System.Drawing.Image)(resources.GetObject("cmdThemPhieuNhap.Image")));
            this.cmdThemPhieuNhap.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdThemPhieuNhap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdThemPhieuNhap.Name = "cmdThemPhieuNhap";
            this.cmdThemPhieuNhap.Size = new System.Drawing.Size(101, 36);
            this.cmdThemPhieuNhap.Text = "Thêm phiếu";
            this.cmdThemPhieuNhap.ToolTipText = "Thêm mới phiếu nhập kho(Ctrl+N)";
            this.cmdThemPhieuNhap.Click += new System.EventHandler(this.cmdThemPhieuNhap_Click);
            // 
            // cmdUpdatePhieuNhap
            // 
            this.cmdUpdatePhieuNhap.Image = ((System.Drawing.Image)(resources.GetObject("cmdUpdatePhieuNhap.Image")));
            this.cmdUpdatePhieuNhap.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdUpdatePhieuNhap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdUpdatePhieuNhap.Name = "cmdUpdatePhieuNhap";
            this.cmdUpdatePhieuNhap.Size = new System.Drawing.Size(92, 36);
            this.cmdUpdatePhieuNhap.Text = "Sửa phiếu";
            this.cmdUpdatePhieuNhap.ToolTipText = "Sửa phiếu nhập kho(Ctrl+E)";
            this.cmdUpdatePhieuNhap.Click += new System.EventHandler(this.cmdUpdatePhieuNhap_Click);
            // 
            // cmdXoaPhieuNhap
            // 
            this.cmdXoaPhieuNhap.Image = ((System.Drawing.Image)(resources.GetObject("cmdXoaPhieuNhap.Image")));
            this.cmdXoaPhieuNhap.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdXoaPhieuNhap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdXoaPhieuNhap.Name = "cmdXoaPhieuNhap";
            this.cmdXoaPhieuNhap.Size = new System.Drawing.Size(90, 36);
            this.cmdXoaPhieuNhap.Text = "Xóa phiếu";
            this.cmdXoaPhieuNhap.ToolTipText = "Xóa phiếu nhập kho(Ctrl+D)";
            this.cmdXoaPhieuNhap.Click += new System.EventHandler(this.cmdXoaPhieuNhap_Click);
            // 
            // cmdNhapKho
            // 
            this.cmdNhapKho.Image = ((System.Drawing.Image)(resources.GetObject("cmdNhapKho.Image")));
            this.cmdNhapKho.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdNhapKho.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdNhapKho.Name = "cmdNhapKho";
            this.cmdNhapKho.Size = new System.Drawing.Size(94, 36);
            this.cmdNhapKho.Text = "Xác nhận";
            this.cmdNhapKho.ToolTipText = "Ctrl+X: Xác nhận nhập vào kho(Thuốc được cộng vào trong kho nhập)";
            this.cmdNhapKho.Click += new System.EventHandler(this.cmdNhapKho_Click);
            // 
            // cmdHuyXacnhan
            // 
            this.cmdHuyXacnhan.Image = ((System.Drawing.Image)(resources.GetObject("cmdHuyXacnhan.Image")));
            this.cmdHuyXacnhan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdHuyXacnhan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdHuyXacnhan.Name = "cmdHuyXacnhan";
            this.cmdHuyXacnhan.Size = new System.Drawing.Size(108, 36);
            this.cmdHuyXacnhan.Text = "Hủy xác nhận";
            this.cmdHuyXacnhan.ToolTipText = "Ctrl+Z: Hủy xác nhận phiếu nhập kho(Thuốc bị trừ khỏi kho nhập)";
            this.cmdHuyXacnhan.Click += new System.EventHandler(this.cmdHuyXacnhan_Click);
            // 
            // cmdInPhieuNhapKho
            // 
            this.cmdInPhieuNhapKho.Image = ((System.Drawing.Image)(resources.GetObject("cmdInPhieuNhapKho.Image")));
            this.cmdInPhieuNhapKho.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdInPhieuNhapKho.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdInPhieuNhapKho.Name = "cmdInPhieuNhapKho";
            this.cmdInPhieuNhapKho.Size = new System.Drawing.Size(87, 36);
            this.cmdInPhieuNhapKho.Text = "In phiếu";
            this.cmdInPhieuNhapKho.ToolTipText = "In phiếu nhập kho(Ctrl+P)";
            this.cmdInPhieuNhapKho.Click += new System.EventHandler(this.cmdInPhieuNhapKho_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Image = ((System.Drawing.Image)(resources.GetObject("cmdExit.Image")));
            this.cmdExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(106, 36);
            this.cmdExit.Text = "Thoát (Esc)";
            this.cmdExit.ToolTipText = "Thoát khỏi chức năng (Esc)";
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.txtNhacungcap);
            this.uiGroupBox1.Controls.Add(this.label4);
            this.uiGroupBox1.Controls.Add(this.label3);
            this.uiGroupBox1.Controls.Add(this.cboKhoThuoc);
            this.uiGroupBox1.Controls.Add(this.radChuaNhapKho);
            this.uiGroupBox1.Controls.Add(this.radDaNhap);
            this.uiGroupBox1.Controls.Add(this.radTatCa);
            this.uiGroupBox1.Controls.Add(this.label2);
            this.uiGroupBox1.Controls.Add(this.cboNhanVien);
            this.uiGroupBox1.Controls.Add(this.cmdSearch);
            this.uiGroupBox1.Controls.Add(this.dtToDate);
            this.uiGroupBox1.Controls.Add(this.chkByDate);
            this.uiGroupBox1.Controls.Add(this.dtFromdate);
            this.uiGroupBox1.Controls.Add(this.txtSoPhieu);
            this.uiGroupBox1.Controls.Add(this.label1);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiGroupBox1.Location = new System.Drawing.Point(0, 39);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(1018, 111);
            this.uiGroupBox1.TabIndex = 2;
            this.uiGroupBox1.Text = "Tìm kiếm";
            // 
            // txtNhacungcap
            // 
            this.txtNhacungcap._backcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtNhacungcap._Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhacungcap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNhacungcap.AutoCompleteList = ((System.Collections.Generic.List<string>)(resources.GetObject("txtNhacungcap.AutoCompleteList")));
            this.txtNhacungcap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNhacungcap.CaseSensitive = false;
            this.txtNhacungcap.CompareNoID = true;
            this.txtNhacungcap.DefaultCode = "-1";
            this.txtNhacungcap.DefaultID = "-1";
            this.txtNhacungcap.Drug_ID = null;
            this.txtNhacungcap.ExtraWidth = 0;
            this.txtNhacungcap.FillValueAfterSelect = false;
            this.txtNhacungcap.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhacungcap.LOAI_DANHMUC = "NHACUNGCAP";
            this.txtNhacungcap.Location = new System.Drawing.Point(370, 55);
            this.txtNhacungcap.MaxHeight = -1;
            this.txtNhacungcap.MinTypedCharacters = 2;
            this.txtNhacungcap.MyCode = "-1";
            this.txtNhacungcap.MyID = "-1";
            this.txtNhacungcap.Name = "txtNhacungcap";
            this.txtNhacungcap.RaiseEvent = false;
            this.txtNhacungcap.RaiseEventEnter = false;
            this.txtNhacungcap.RaiseEventEnterWhenEmpty = false;
            this.txtNhacungcap.SelectedIndex = -1;
            this.txtNhacungcap.Size = new System.Drawing.Size(484, 21);
            this.txtNhacungcap.splitChar = '@';
            this.txtNhacungcap.splitCharIDAndCode = '#';
            this.txtNhacungcap.TabIndex = 122;
            this.txtNhacungcap.TakeCode = false;
            this.txtNhacungcap.txtMyCode = null;
            this.txtNhacungcap.txtMyCode_Edit = null;
            this.txtNhacungcap.txtMyID = null;
            this.txtNhacungcap.txtMyID_Edit = null;
            this.txtNhacungcap.txtMyName = null;
            this.txtNhacungcap.txtMyName_Edit = null;
            this.txtNhacungcap.txtNext = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(281, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nhà cung cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kho nhập:";
            // 
            // cboKhoThuoc
            // 
            this.cboKhoThuoc.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKhoThuoc.Location = new System.Drawing.Point(94, 51);
            this.cboKhoThuoc.MaxDropDownItems = 15;
            this.cboKhoThuoc.Name = "cboKhoThuoc";
            this.cboKhoThuoc.Size = new System.Drawing.Size(177, 21);
            this.cboKhoThuoc.TabIndex = 11;
            this.cboKhoThuoc.Text = "Kho thuốc";
            // 
            // radChuaNhapKho
            // 
            this.radChuaNhapKho.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radChuaNhapKho.Location = new System.Drawing.Point(702, 79);
            this.radChuaNhapKho.Name = "radChuaNhapKho";
            this.radChuaNhapKho.Size = new System.Drawing.Size(124, 27);
            this.radChuaNhapKho.TabIndex = 10;
            this.radChuaNhapKho.Text = "Chưa xác nhận";
            // 
            // radDaNhap
            // 
            this.radDaNhap.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDaNhap.Location = new System.Drawing.Point(583, 79);
            this.radDaNhap.Name = "radDaNhap";
            this.radDaNhap.Size = new System.Drawing.Size(103, 27);
            this.radDaNhap.TabIndex = 9;
            this.radDaNhap.Text = "Đã xác nhận";
            // 
            // radTatCa
            // 
            this.radTatCa.Checked = true;
            this.radTatCa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTatCa.Location = new System.Drawing.Point(488, 79);
            this.radTatCa.Name = "radTatCa";
            this.radTatCa.Size = new System.Drawing.Size(89, 27);
            this.radTatCa.TabIndex = 8;
            this.radTatCa.TabStop = true;
            this.radTatCa.Text = "Tất cả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nhân viên";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboNhanVien.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNhanVien.Location = new System.Drawing.Point(370, 24);
            this.cboNhanVien.MaxDropDownItems = 15;
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(484, 21);
            this.cboNhanVien.TabIndex = 6;
            this.cboNhanVien.Text = "Nhân viên";
            // 
            // cmdSearch
            // 
            this.cmdSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSearch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSearch.Image = ((System.Drawing.Image)(resources.GetObject("cmdSearch.Image")));
            this.cmdSearch.ImageSize = new System.Drawing.Size(24, 24);
            this.cmdSearch.Location = new System.Drawing.Point(860, 23);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(152, 57);
            this.cmdSearch.TabIndex = 5;
            this.cmdSearch.Text = "&Tìm kiếm(F3)";
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // dtToDate
            // 
            this.dtToDate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtToDate.Location = new System.Drawing.Point(279, 80);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Size = new System.Drawing.Size(181, 21);
            this.dtToDate.TabIndex = 4;
            // 
            // chkByDate
            // 
            this.chkByDate.Checked = true;
            this.chkByDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkByDate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkByDate.Location = new System.Drawing.Point(8, 77);
            this.chkByDate.Name = "chkByDate";
            this.chkByDate.Size = new System.Drawing.Size(79, 27);
            this.chkByDate.TabIndex = 3;
            this.chkByDate.Text = "Từ ngày";
            this.chkByDate.CheckedChanged += new System.EventHandler(this.chkByDate_CheckedChanged);
            // 
            // dtFromdate
            // 
            this.dtFromdate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFromdate.Location = new System.Drawing.Point(94, 80);
            this.dtFromdate.Name = "dtFromdate";
            this.dtFromdate.Size = new System.Drawing.Size(177, 21);
            this.dtFromdate.TabIndex = 2;
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoPhieu.Location = new System.Drawing.Point(94, 23);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Size = new System.Drawing.Size(177, 21);
            this.txtSoPhieu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số phiếu";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 150);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.uiGroupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.uiGroupBox4);
            this.splitContainer1.Size = new System.Drawing.Size(1018, 563);
            this.splitContainer1.SplitterDistance = 491;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 3;
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.grdList);
            this.uiGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiGroupBox2.Location = new System.Drawing.Point(0, 0);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Size = new System.Drawing.Size(489, 561);
            this.uiGroupBox2.TabIndex = 0;
            this.uiGroupBox2.Text = "Danh sách phiếu nhập";
            // 
            // grdList
            // 
            this.grdList.AlternatingColors = true;
            this.grdList.BuiltInTextsData = "<LocalizableData ID=\"LocalizableStrings\" Collection=\"true\"><FilterRowInfoText>Lọc" +
                " thông tin phiếu nhập khoa</FilterRowInfoText></LocalizableData>";
            grdList_DesignTimeLayout.LayoutString = resources.GetString("grdList_DesignTimeLayout.LayoutString");
            this.grdList.DesignTimeLayout = grdList_DesignTimeLayout;
            this.grdList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdList.DynamicFiltering = true;
            this.grdList.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdList.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdList.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grdList.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.grdList.GroupByBoxVisible = false;
            this.grdList.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight;
            this.grdList.Location = new System.Drawing.Point(3, 17);
            this.grdList.Name = "grdList";
            this.grdList.RecordNavigator = true;
            this.grdList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdList.Size = new System.Drawing.Size(483, 541);
            this.grdList.TabIndex = 1;
            this.grdList.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2005;
            this.grdList.SelectionChanged += new System.EventHandler(this.grdList_SelectionChanged);
            this.grdList.ApplyingFilter += new System.ComponentModel.CancelEventHandler(this.grdList_ApplyingFilter);
            // 
            // uiGroupBox4
            // 
            this.uiGroupBox4.Controls.Add(this.grdPhieuNhapChiTiet);
            this.uiGroupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiGroupBox4.Location = new System.Drawing.Point(0, 0);
            this.uiGroupBox4.Name = "uiGroupBox4";
            this.uiGroupBox4.Size = new System.Drawing.Size(520, 561);
            this.uiGroupBox4.TabIndex = 1;
            this.uiGroupBox4.Text = "Chi tiết phiếu nhập";
            // 
            // grdPhieuNhapChiTiet
            // 
            this.grdPhieuNhapChiTiet.AlternatingColors = true;
            grdPhieuNhapChiTiet_DesignTimeLayout.LayoutString = resources.GetString("grdPhieuNhapChiTiet_DesignTimeLayout.LayoutString");
            this.grdPhieuNhapChiTiet.DesignTimeLayout = grdPhieuNhapChiTiet_DesignTimeLayout;
            this.grdPhieuNhapChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPhieuNhapChiTiet.DynamicFiltering = true;
            this.grdPhieuNhapChiTiet.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdPhieuNhapChiTiet.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grdPhieuNhapChiTiet.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.grdPhieuNhapChiTiet.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdPhieuNhapChiTiet.FrozenColumns = 2;
            this.grdPhieuNhapChiTiet.GroupByBoxVisible = false;
            this.grdPhieuNhapChiTiet.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight;
            this.grdPhieuNhapChiTiet.Location = new System.Drawing.Point(3, 17);
            this.grdPhieuNhapChiTiet.Name = "grdPhieuNhapChiTiet";
            this.grdPhieuNhapChiTiet.RecordNavigator = true;
            this.grdPhieuNhapChiTiet.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdPhieuNhapChiTiet.Size = new System.Drawing.Size(514, 541);
            this.grdPhieuNhapChiTiet.TabIndex = 1;
            this.grdPhieuNhapChiTiet.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdPhieuNhapChiTiet.TotalRowFormatStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdPhieuNhapChiTiet.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.grdPhieuNhapChiTiet.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2005;
            // 
            // cmdConfig
            // 
            this.cmdConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdConfig.Image = ((System.Drawing.Image)(resources.GetObject("cmdConfig.Image")));
            this.cmdConfig.Location = new System.Drawing.Point(972, 0);
            this.cmdConfig.Name = "cmdConfig";
            this.cmdConfig.Size = new System.Drawing.Size(45, 38);
            this.cmdConfig.TabIndex = 460;
            this.cmdConfig.Click += new System.EventHandler(this.cmdConfig_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Trợ giúp:";
            // 
            // frm_PhieuNhapKho
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1018, 740);
            this.Controls.Add(this.cmdConfig);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.uiStatusBar1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frm_PhieuNhapKho";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu nhập kho thuốc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_PhieuNhapKho_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_PhieuNhapKho_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).EndInit();
            this.uiGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox4)).EndInit();
            this.uiGroupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPhieuNhapChiTiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Janus.Windows.UI.StatusBar.UIStatusBar uiStatusBar1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton cmdThemPhieuNhap;
        private System.Windows.Forms.ToolStripButton cmdUpdatePhieuNhap;
        private System.Windows.Forms.ToolStripButton cmdXoaPhieuNhap;
        private System.Windows.Forms.ToolStripButton cmdInPhieuNhapKho;
        private System.Windows.Forms.ToolStripButton cmdExit;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Janus.Windows.EditControls.UICheckBox chkByDate;
        private System.Windows.Forms.DateTimePicker dtFromdate;
        private Janus.Windows.GridEX.EditControls.EditBox txtSoPhieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtToDate;
        private Janus.Windows.EditControls.UIButton cmdSearch;
        private System.Windows.Forms.Label label2;
        private Janus.Windows.EditControls.UIComboBox cboNhanVien;
        private Janus.Windows.EditControls.UIRadioButton radChuaNhapKho;
        private Janus.Windows.EditControls.UIRadioButton radDaNhap;
        private Janus.Windows.EditControls.UIRadioButton radTatCa;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox2;
        private Janus.Windows.GridEX.GridEX grdList;
        private System.Windows.Forms.ToolStripButton cmdNhapKho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Janus.Windows.EditControls.UIComboBox cboKhoThuoc;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox4;
        private Janus.Windows.GridEX.GridEX grdPhieuNhapChiTiet;
        private System.Windows.Forms.ToolStripButton cmdHuyXacnhan;
        private Janus.Windows.EditControls.UIButton cmdConfig;
        private VNS.HIS.UCs.AutoCompleteTextbox_Danhmucchung txtNhacungcap;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}