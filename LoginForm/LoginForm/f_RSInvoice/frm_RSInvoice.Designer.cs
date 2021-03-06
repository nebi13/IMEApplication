﻿namespace LoginForm.f_RSInvoice
{
    partial class frm_RSInvoice
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCostAnalyst = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNewInvoice = new System.Windows.Forms.Button();
            this.btnViewInvoice = new System.Windows.Forms.Button();
            this.btnDeleteInvoice = new System.Windows.Forms.Button();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.txtSearchText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvRSInvoice = new System.Windows.Forms.DataGridView();
            this.ctx_dgRSInvoice = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewInvoicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToLogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backFromLogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStockCode = new System.Windows.Forms.TextBox();
            this.chcCustStockNumber = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bgw_RSInvoiceGetter = new System.ComponentModel.BackgroundWorker();
            this.dgChk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgShipmentReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgBillingDocumentReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgShippingCondition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgBillingDocumentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSupplyingECCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCustomerReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgInvoiceTaxValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgInvoiceGoodsValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgInvoiceNettValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAirwayBillNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSurcharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDeleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRSInvoice)).BeginInit();
            this.ctx_dgRSInvoice.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnCostAnalyst);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Controls.Add(this.btnExportToExcel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnNewInvoice);
            this.groupBox2.Controls.Add(this.btnViewInvoice);
            this.groupBox2.Controls.Add(this.btnDeleteInvoice);
            this.groupBox2.Location = new System.Drawing.Point(236, -1);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(372, 91);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(278, 60);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Cost Analyst";
            // 
            // btnCostAnalyst
            // 
            this.btnCostAnalyst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(237)))), ((int)(((byte)(220)))));
            this.btnCostAnalyst.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnCostAnalyst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCostAnalyst.Image = global::LoginForm.Properties.Resources.if_filter_173013;
            this.btnCostAnalyst.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCostAnalyst.Location = new System.Drawing.Point(288, 15);
            this.btnCostAnalyst.Margin = new System.Windows.Forms.Padding(0);
            this.btnCostAnalyst.Name = "btnCostAnalyst";
            this.btnCostAnalyst.Padding = new System.Windows.Forms.Padding(6, 13, 6, 0);
            this.btnCostAnalyst.Size = new System.Drawing.Size(39, 42);
            this.btnCostAnalyst.TabIndex = 31;
            this.btnCostAnalyst.UseVisualStyleBackColor = true;
            this.btnCostAnalyst.Click += new System.EventHandler(this.btnCostAnalyst_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(236, 60);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Print";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(179, 60);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Excel";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(237)))), ((int)(((byte)(220)))));
            this.btnPrint.Enabled = false;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Image = global::LoginForm.Properties.Resources.if_print_173079;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrint.Location = new System.Drawing.Point(230, 15);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Padding = new System.Windows.Forms.Padding(6, 13, 6, 0);
            this.btnPrint.Size = new System.Drawing.Size(39, 42);
            this.btnPrint.TabIndex = 28;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(237)))), ((int)(((byte)(220)))));
            this.btnExportToExcel.Enabled = false;
            this.btnExportToExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnExportToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportToExcel.Image = global::LoginForm.Properties.Resources.if_Document_file_export_sending_exit_send_1886950;
            this.btnExportToExcel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExportToExcel.Location = new System.Drawing.Point(175, 15);
            this.btnExportToExcel.Margin = new System.Windows.Forms.Padding(0);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Padding = new System.Windows.Forms.Padding(6, 13, 6, 0);
            this.btnExportToExcel.Size = new System.Drawing.Size(39, 42);
            this.btnExportToExcel.TabIndex = 27;
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "New ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "View";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Delete";
            // 
            // btnNewInvoice
            // 
            this.btnNewInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(237)))), ((int)(((byte)(220)))));
            this.btnNewInvoice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnNewInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewInvoice.Image = global::LoginForm.Properties.Resources.icons8_Plus_32;
            this.btnNewInvoice.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNewInvoice.Location = new System.Drawing.Point(10, 15);
            this.btnNewInvoice.Margin = new System.Windows.Forms.Padding(0);
            this.btnNewInvoice.Name = "btnNewInvoice";
            this.btnNewInvoice.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnNewInvoice.Size = new System.Drawing.Size(39, 42);
            this.btnNewInvoice.TabIndex = 1;
            this.btnNewInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewInvoice.UseVisualStyleBackColor = true;
            this.btnNewInvoice.Click += new System.EventHandler(this.btnNewInvoice_Click);
            // 
            // btnViewInvoice
            // 
            this.btnViewInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(237)))), ((int)(((byte)(220)))));
            this.btnViewInvoice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnViewInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewInvoice.Image = global::LoginForm.Properties.Resources.icons8_Edit_Property_32;
            this.btnViewInvoice.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewInvoice.Location = new System.Drawing.Point(65, 15);
            this.btnViewInvoice.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewInvoice.Name = "btnViewInvoice";
            this.btnViewInvoice.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnViewInvoice.Size = new System.Drawing.Size(39, 42);
            this.btnViewInvoice.TabIndex = 16;
            this.btnViewInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnViewInvoice.UseVisualStyleBackColor = true;
            this.btnViewInvoice.Click += new System.EventHandler(this.btnViewInvoice_Click);
            // 
            // btnDeleteInvoice
            // 
            this.btnDeleteInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(237)))), ((int)(((byte)(220)))));
            this.btnDeleteInvoice.Enabled = false;
            this.btnDeleteInvoice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnDeleteInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteInvoice.Image = global::LoginForm.Properties.Resources.if_minus_1645995;
            this.btnDeleteInvoice.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteInvoice.Location = new System.Drawing.Point(120, 15);
            this.btnDeleteInvoice.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteInvoice.Name = "btnDeleteInvoice";
            this.btnDeleteInvoice.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnDeleteInvoice.Size = new System.Drawing.Size(39, 42);
            this.btnDeleteInvoice.TabIndex = 17;
            this.btnDeleteInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteInvoice.UseVisualStyleBackColor = true;
            this.btnDeleteInvoice.Click += new System.EventHandler(this.btnDeleteInvoice_Click);
            // 
            // cbSearch
            // 
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Location = new System.Drawing.Point(4, 11);
            this.cbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(163, 21);
            this.cbSearch.TabIndex = 22;
            // 
            // txtSearchText
            // 
            this.txtSearchText.Location = new System.Drawing.Point(4, 36);
            this.txtSearchText.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(163, 20);
            this.txtSearchText.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnRefreshList);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpToDate);
            this.groupBox1.Controls.Add(this.dtpFromDate);
            this.groupBox1.Location = new System.Drawing.Point(9, -1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(222, 91);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Refresh";
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(237)))), ((int)(((byte)(220)))));
            this.btnRefreshList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnRefreshList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshList.Image = global::LoginForm.Properties.Resources.icons8_Refresh_32;
            this.btnRefreshList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefreshList.Location = new System.Drawing.Point(167, 15);
            this.btnRefreshList.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnRefreshList.Size = new System.Drawing.Size(39, 42);
            this.btnRefreshList.TabIndex = 24;
            this.btnRefreshList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefreshList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefreshList.UseVisualStyleBackColor = true;
            this.btnRefreshList.Click += new System.EventHandler(this.btnRefreshList_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "To";
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd-MM-yyyy";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(62, 15);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(90, 20);
            this.dtpToDate.TabIndex = 18;
            this.dtpToDate.Value = new System.DateTime(2018, 9, 4, 0, 0, 0, 0);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd-MM-yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(62, 41);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(90, 20);
            this.dtpFromDate.TabIndex = 19;
            this.dtpFromDate.Value = new System.DateTime(2018, 9, 4, 0, 0, 0, 0);
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvRSInvoice, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 7F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1019, 530);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dgvRSInvoice
            // 
            this.dgvRSInvoice.AllowUserToAddRows = false;
            this.dgvRSInvoice.AllowUserToDeleteRows = false;
            this.dgvRSInvoice.AllowUserToOrderColumns = true;
            this.dgvRSInvoice.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvRSInvoice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRSInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRSInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgChk,
            this.dgID,
            this.dgShipmentReference,
            this.dgBillingDocumentReference,
            this.dgShippingCondition,
            this.dgBillingDocumentDate,
            this.dgSupplyingECCompany,
            this.dgCustomerReference,
            this.dgInvoiceTaxValue,
            this.dgInvoiceGoodsValue,
            this.dgInvoiceNettValue,
            this.dgCurrency,
            this.dgAirwayBillNumber,
            this.dgDiscount,
            this.dgSurcharge,
            this.dgStatus,
            this.dgDeleted,
            this.dgSupplier,
            this.dgUser,
            this.dgCreateDate,
            this.dgSupplierID,
            this.dgUserID});
            this.dgvRSInvoice.ContextMenuStrip = this.ctx_dgRSInvoice;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRSInvoice.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRSInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRSInvoice.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvRSInvoice.Location = new System.Drawing.Point(6, 104);
            this.dgvRSInvoice.Margin = new System.Windows.Forms.Padding(6);
            this.dgvRSInvoice.Name = "dgvRSInvoice";
            this.dgvRSInvoice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvRSInvoice.RowTemplate.Height = 24;
            this.dgvRSInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRSInvoice.Size = new System.Drawing.Size(1007, 413);
            this.dgvRSInvoice.TabIndex = 0;
            this.dgvRSInvoice.TabStop = false;
            this.dgvRSInvoice.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgRSInvoice_MouseDown);
            // 
            // ctx_dgRSInvoice
            // 
            this.ctx_dgRSInvoice.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctx_dgRSInvoice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewInvoicToolStripMenuItem,
            this.sendToLogoToolStripMenuItem,
            this.backFromLogoToolStripMenuItem});
            this.ctx_dgRSInvoice.Name = "ctx_dgRSInvoice";
            this.ctx_dgRSInvoice.Size = new System.Drawing.Size(161, 70);
            // 
            // viewInvoicToolStripMenuItem
            // 
            this.viewInvoicToolStripMenuItem.Name = "viewInvoicToolStripMenuItem";
            this.viewInvoicToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.viewInvoicToolStripMenuItem.Text = "View Invoice";
            this.viewInvoicToolStripMenuItem.Click += new System.EventHandler(this.viewInvoicToolStripMenuItem_Click);
            // 
            // sendToLogoToolStripMenuItem
            // 
            this.sendToLogoToolStripMenuItem.Name = "sendToLogoToolStripMenuItem";
            this.sendToLogoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.sendToLogoToolStripMenuItem.Text = "Send To Logo";
            this.sendToLogoToolStripMenuItem.Click += new System.EventHandler(this.sendToLogoToolStripMenuItem_Click);
            // 
            // backFromLogoToolStripMenuItem
            // 
            this.backFromLogoToolStripMenuItem.Name = "backFromLogoToolStripMenuItem";
            this.backFromLogoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.backFromLogoToolStripMenuItem.Text = "Back From Logo";
            this.backFromLogoToolStripMenuItem.Click += new System.EventHandler(this.backFromLogoToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 94);
            this.panel1.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSearch);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtStockCode);
            this.groupBox4.Controls.Add(this.chcCustStockNumber);
            this.groupBox4.Location = new System.Drawing.Point(793, 2);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(217, 86);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = global::LoginForm.Properties.Resources.if_search_magnifying_glass_find_103857;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.Location = new System.Drawing.Point(168, 11);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnSearch.Size = new System.Drawing.Size(39, 42);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(168, 57);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Search";
            // 
            // txtStockCode
            // 
            this.txtStockCode.Location = new System.Drawing.Point(2, 11);
            this.txtStockCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtStockCode.Name = "txtStockCode";
            this.txtStockCode.Size = new System.Drawing.Size(145, 20);
            this.txtStockCode.TabIndex = 25;
            // 
            // chcCustStockNumber
            // 
            this.chcCustStockNumber.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chcCustStockNumber.Location = new System.Drawing.Point(2, 37);
            this.chcCustStockNumber.Margin = new System.Windows.Forms.Padding(2);
            this.chcCustStockNumber.Name = "chcCustStockNumber";
            this.chcCustStockNumber.Size = new System.Drawing.Size(144, 17);
            this.chcCustStockNumber.TabIndex = 26;
            this.chcCustStockNumber.Text = "Customer Stock Code";
            this.chcCustStockNumber.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbSearch);
            this.groupBox3.Controls.Add(this.txtSearchText);
            this.groupBox3.Location = new System.Drawing.Point(612, 3);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(177, 89);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            // 
            // bgw_RSInvoiceGetter
            // 
            this.bgw_RSInvoiceGetter.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_RSInvoiceGetter_DoWork);
            this.bgw_RSInvoiceGetter.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RSInvoiceGetter_RunWorkerCompleted);
            // 
            // dgChk
            // 
            this.dgChk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dgChk.HeaderText = "Choose";
            this.dgChk.Name = "dgChk";
            this.dgChk.Width = 5;
            // 
            // dgID
            // 
            this.dgID.HeaderText = "ID";
            this.dgID.Name = "dgID";
            this.dgID.Visible = false;
            // 
            // dgShipmentReference
            // 
            this.dgShipmentReference.HeaderText = "Shipment Reference";
            this.dgShipmentReference.Name = "dgShipmentReference";
            // 
            // dgBillingDocumentReference
            // 
            this.dgBillingDocumentReference.HeaderText = "Billing Document Reference";
            this.dgBillingDocumentReference.Name = "dgBillingDocumentReference";
            // 
            // dgShippingCondition
            // 
            this.dgShippingCondition.HeaderText = "Shipping Condition";
            this.dgShippingCondition.Name = "dgShippingCondition";
            // 
            // dgBillingDocumentDate
            // 
            this.dgBillingDocumentDate.HeaderText = "Billing Document Date";
            this.dgBillingDocumentDate.Name = "dgBillingDocumentDate";
            // 
            // dgSupplyingECCompany
            // 
            this.dgSupplyingECCompany.HeaderText = "Supplying EC Company";
            this.dgSupplyingECCompany.Name = "dgSupplyingECCompany";
            // 
            // dgCustomerReference
            // 
            this.dgCustomerReference.HeaderText = "Customer Reference";
            this.dgCustomerReference.Name = "dgCustomerReference";
            // 
            // dgInvoiceTaxValue
            // 
            this.dgInvoiceTaxValue.HeaderText = "Invoice Tax Value";
            this.dgInvoiceTaxValue.Name = "dgInvoiceTaxValue";
            // 
            // dgInvoiceGoodsValue
            // 
            this.dgInvoiceGoodsValue.HeaderText = "Invoice Goods Value";
            this.dgInvoiceGoodsValue.Name = "dgInvoiceGoodsValue";
            // 
            // dgInvoiceNettValue
            // 
            this.dgInvoiceNettValue.HeaderText = "Invoice Nett Value";
            this.dgInvoiceNettValue.Name = "dgInvoiceNettValue";
            // 
            // dgCurrency
            // 
            this.dgCurrency.HeaderText = "Currency";
            this.dgCurrency.Name = "dgCurrency";
            // 
            // dgAirwayBillNumber
            // 
            this.dgAirwayBillNumber.HeaderText = "Airway Bill Number";
            this.dgAirwayBillNumber.Name = "dgAirwayBillNumber";
            // 
            // dgDiscount
            // 
            this.dgDiscount.HeaderText = "Discount";
            this.dgDiscount.Name = "dgDiscount";
            // 
            // dgSurcharge
            // 
            this.dgSurcharge.HeaderText = "Surcharge";
            this.dgSurcharge.Name = "dgSurcharge";
            // 
            // dgStatus
            // 
            this.dgStatus.HeaderText = "Status";
            this.dgStatus.Name = "dgStatus";
            // 
            // dgDeleted
            // 
            this.dgDeleted.HeaderText = "Deleted";
            this.dgDeleted.Name = "dgDeleted";
            // 
            // dgSupplier
            // 
            this.dgSupplier.HeaderText = "Supplier";
            this.dgSupplier.Name = "dgSupplier";
            // 
            // dgUser
            // 
            this.dgUser.HeaderText = "User";
            this.dgUser.Name = "dgUser";
            // 
            // dgCreateDate
            // 
            this.dgCreateDate.HeaderText = "CreateDate";
            this.dgCreateDate.Name = "dgCreateDate";
            // 
            // dgSupplierID
            // 
            this.dgSupplierID.HeaderText = "SupplierID";
            this.dgSupplierID.Name = "dgSupplierID";
            this.dgSupplierID.Visible = false;
            // 
            // dgUserID
            // 
            this.dgUserID.HeaderText = "UserID";
            this.dgUserID.Name = "dgUserID";
            this.dgUserID.Visible = false;
            // 
            // frm_RSInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(237)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1019, 530);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(949, 569);
            this.Name = "frm_RSInvoice";
            this.Text = "RS Invoices";
            this.Load += new System.EventHandler(this.frm_RSInvoice_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRSInvoice)).EndInit();
            this.ctx_dgRSInvoice.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNewInvoice;
        private System.Windows.Forms.Button btnViewInvoice;
        private System.Windows.Forms.Button btnDeleteInvoice;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.TextBox txtSearchText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvRSInvoice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtStockCode;
        private System.Windows.Forms.CheckBox chcCustStockNumber;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ContextMenuStrip ctx_dgRSInvoice;
        private System.Windows.Forms.ToolStripMenuItem viewInvoicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToLogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backFromLogoToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker bgw_RSInvoiceGetter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCostAnalyst;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgChk;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgShipmentReference;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgBillingDocumentReference;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgShippingCondition;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgBillingDocumentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSupplyingECCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCustomerReference;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgInvoiceTaxValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgInvoiceGoodsValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgInvoiceNettValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAirwayBillNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSurcharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDeleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSupplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgUserID;
    }
}