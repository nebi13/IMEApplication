﻿namespace LoginForm
{
    partial class frmBankReconciliation
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
            this.label13 = new System.Windows.Forms.Label();
            this.cmbBankAccount = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBalanceCompnyDr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBalanceCompanyCr = new System.Windows.Forms.TextBox();
            this.txtBalanceBankCr = new System.Windows.Forms.TextBox();
            this.txtBalanceBankDr = new System.Windows.Forms.TextBox();
            this.txtDifferenceCr = new System.Windows.Forms.TextBox();
            this.txtDifferenceDr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpStatementFrom = new System.Windows.Forms.DateTimePicker();
            this.txtStatementFrom = new System.Windows.Forms.TextBox();
            this.dtpStatrmentTo = new System.Windows.Forms.DateTimePicker();
            this.txtStatementTo = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvBankReconciliation = new System.Windows.Forms.DataGridView();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtParticular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtChequeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtChequeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDeposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtWithdraw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtStatementDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtLedgerPostingId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankReconciliation)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(615, 55);
            this.label13.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 17);
            this.label13.TabIndex = 1068;
            this.label13.Text = "Statement Date To";
            // 
            // cmbBankAccount
            // 
            this.cmbBankAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBankAccount.FormattingEnabled = true;
            this.cmbBankAccount.Location = new System.Drawing.Point(169, 18);
            this.cmbBankAccount.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.cmbBankAccount.Name = "cmbBankAccount";
            this.cmbBankAccount.Size = new System.Drawing.Size(265, 24);
            this.cmbBankAccount.TabIndex = 0;
            this.cmbBankAccount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbBankAccount_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(23, 55);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 17);
            this.label10.TabIndex = 1066;
            this.label10.Text = "Statement Date From";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(929, 689);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 33);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnClose_KeyDown);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(687, 689);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 33);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(808, 689);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(113, 33);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnClear_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(601, 602);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 17);
            this.label1.TabIndex = 1059;
            this.label1.Text = "Balance As Per Company Book ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(23, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 1057;
            this.label7.Text = "Bank Account";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Reconciled",
            "Unreconciled"});
            this.cmbStatus.Location = new System.Drawing.Point(757, 18);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(265, 24);
            this.cmbStatus.TabIndex = 1;
            this.cmbStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbStatus_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(612, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 1054;
            this.label3.Text = "Status";
            // 
            // txtBalanceCompnyDr
            // 
            this.txtBalanceCompnyDr.Location = new System.Drawing.Point(815, 597);
            this.txtBalanceCompnyDr.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.txtBalanceCompnyDr.Name = "txtBalanceCompnyDr";
            this.txtBalanceCompnyDr.ReadOnly = true;
            this.txtBalanceCompnyDr.Size = new System.Drawing.Size(105, 22);
            this.txtBalanceCompnyDr.TabIndex = 1075;
            this.txtBalanceCompnyDr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(813, 576);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 1076;
            this.label4.Text = "Debit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(932, 576);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 1077;
            this.label5.Text = "Credit";
            // 
            // txtBalanceCompanyCr
            // 
            this.txtBalanceCompanyCr.Location = new System.Drawing.Point(933, 597);
            this.txtBalanceCompanyCr.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.txtBalanceCompanyCr.Name = "txtBalanceCompanyCr";
            this.txtBalanceCompanyCr.ReadOnly = true;
            this.txtBalanceCompanyCr.Size = new System.Drawing.Size(105, 22);
            this.txtBalanceCompanyCr.TabIndex = 1078;
            this.txtBalanceCompanyCr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBalanceBankCr
            // 
            this.txtBalanceBankCr.Location = new System.Drawing.Point(933, 628);
            this.txtBalanceBankCr.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.txtBalanceBankCr.Name = "txtBalanceBankCr";
            this.txtBalanceBankCr.ReadOnly = true;
            this.txtBalanceBankCr.Size = new System.Drawing.Size(105, 22);
            this.txtBalanceBankCr.TabIndex = 1081;
            this.txtBalanceBankCr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBalanceBankDr
            // 
            this.txtBalanceBankDr.Location = new System.Drawing.Point(815, 628);
            this.txtBalanceBankDr.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.txtBalanceBankDr.Name = "txtBalanceBankDr";
            this.txtBalanceBankDr.ReadOnly = true;
            this.txtBalanceBankDr.Size = new System.Drawing.Size(105, 22);
            this.txtBalanceBankDr.TabIndex = 1080;
            this.txtBalanceBankDr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDifferenceCr
            // 
            this.txtDifferenceCr.Location = new System.Drawing.Point(933, 658);
            this.txtDifferenceCr.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.txtDifferenceCr.Name = "txtDifferenceCr";
            this.txtDifferenceCr.ReadOnly = true;
            this.txtDifferenceCr.Size = new System.Drawing.Size(105, 22);
            this.txtDifferenceCr.TabIndex = 1084;
            this.txtDifferenceCr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDifferenceDr
            // 
            this.txtDifferenceDr.Location = new System.Drawing.Point(815, 658);
            this.txtDifferenceDr.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.txtDifferenceDr.Name = "txtDifferenceDr";
            this.txtDifferenceDr.ReadOnly = true;
            this.txtDifferenceDr.Size = new System.Drawing.Size(105, 22);
            this.txtDifferenceDr.TabIndex = 1083;
            this.txtDifferenceDr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(601, 633);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 17);
            this.label6.TabIndex = 1085;
            this.label6.Text = "Balance As Per Bank ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(601, 663);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 1086;
            this.label8.Text = "Difference";
            // 
            // dtpStatementFrom
            // 
            this.dtpStatementFrom.CustomFormat = "dd-MMM-yyyy";
            this.dtpStatementFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStatementFrom.Location = new System.Drawing.Point(411, 50);
            this.dtpStatementFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpStatementFrom.Name = "dtpStatementFrom";
            this.dtpStatementFrom.Size = new System.Drawing.Size(24, 22);
            this.dtpStatementFrom.TabIndex = 1088;
            this.dtpStatementFrom.ValueChanged += new System.EventHandler(this.dtpStatementFrom_ValueChanged);
            // 
            // txtStatementFrom
            // 
            this.txtStatementFrom.Location = new System.Drawing.Point(169, 50);
            this.txtStatementFrom.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.txtStatementFrom.Name = "txtStatementFrom";
            this.txtStatementFrom.Size = new System.Drawing.Size(240, 22);
            this.txtStatementFrom.TabIndex = 2;
            this.txtStatementFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStatementFrom_KeyDown);
            this.txtStatementFrom.Leave += new System.EventHandler(this.txtStatementFrom_Leave);
            // 
            // dtpStatrmentTo
            // 
            this.dtpStatrmentTo.CustomFormat = "dd-MMM-yyyy";
            this.dtpStatrmentTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStatrmentTo.Location = new System.Drawing.Point(999, 50);
            this.dtpStatrmentTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpStatrmentTo.Name = "dtpStatrmentTo";
            this.dtpStatrmentTo.Size = new System.Drawing.Size(24, 22);
            this.dtpStatrmentTo.TabIndex = 1090;
            this.dtpStatrmentTo.ValueChanged += new System.EventHandler(this.dtpStatrmentTo_ValueChanged);
            // 
            // txtStatementTo
            // 
            this.txtStatementTo.Location = new System.Drawing.Point(757, 50);
            this.txtStatementTo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.txtStatementTo.Name = "txtStatementTo";
            this.txtStatementTo.Size = new System.Drawing.Size(241, 22);
            this.txtStatementTo.TabIndex = 3;
            this.txtStatementTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStatementTo_KeyDown);
            this.txtStatementTo.Leave += new System.EventHandler(this.txtStatementTo_Leave);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(757, 79);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 33);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(444, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 17);
            this.label2.TabIndex = 1091;
            this.label2.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(444, 60);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 17);
            this.label9.TabIndex = 1092;
            this.label9.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(1031, 28);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 17);
            this.label11.TabIndex = 1093;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(1031, 59);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 17);
            this.label12.TabIndex = 1094;
            this.label12.Text = "*";
            // 
            // dgvBankReconciliation
            // 
            this.dgvBankReconciliation.AllowUserToAddRows = false;
            this.dgvBankReconciliation.AllowUserToDeleteRows = false;
            this.dgvBankReconciliation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBankReconciliation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvtxtDate,
            this.dgvtxtParticular,
            this.dgvtxtVoucherType,
            this.dgvtxtVoucherNo,
            this.dgvtxtChequeNo,
            this.dgvtxtChequeDate,
            this.dgvtxtDeposit,
            this.dgvtxtWithdraw,
            this.dgvtxtStatementDate,
            this.dgvtxtLedgerPostingId});
            this.dgvBankReconciliation.Location = new System.Drawing.Point(9, 129);
            this.dgvBankReconciliation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBankReconciliation.Name = "dgvBankReconciliation";
            this.dgvBankReconciliation.Size = new System.Drawing.Size(1055, 437);
            this.dgvBankReconciliation.TabIndex = 1095;
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.Width = 76;
            // 
            // dgvtxtDate
            // 
            this.dgvtxtDate.HeaderText = "Date";
            this.dgvtxtDate.Name = "dgvtxtDate";
            this.dgvtxtDate.Width = 76;
            // 
            // dgvtxtParticular
            // 
            this.dgvtxtParticular.HeaderText = "Particular";
            this.dgvtxtParticular.Name = "dgvtxtParticular";
            this.dgvtxtParticular.Width = 76;
            // 
            // dgvtxtVoucherType
            // 
            this.dgvtxtVoucherType.HeaderText = "Voucher Type";
            this.dgvtxtVoucherType.Name = "dgvtxtVoucherType";
            this.dgvtxtVoucherType.Width = 76;
            // 
            // dgvtxtVoucherNo
            // 
            this.dgvtxtVoucherNo.HeaderText = "Voucher No";
            this.dgvtxtVoucherNo.Name = "dgvtxtVoucherNo";
            this.dgvtxtVoucherNo.Width = 76;
            // 
            // dgvtxtChequeNo
            // 
            this.dgvtxtChequeNo.HeaderText = "Cheque No.";
            this.dgvtxtChequeNo.Name = "dgvtxtChequeNo";
            this.dgvtxtChequeNo.Width = 76;
            // 
            // dgvtxtChequeDate
            // 
            this.dgvtxtChequeDate.HeaderText = "Cheque Date";
            this.dgvtxtChequeDate.Name = "dgvtxtChequeDate";
            this.dgvtxtChequeDate.Width = 76;
            // 
            // dgvtxtDeposit
            // 
            this.dgvtxtDeposit.HeaderText = "Deposit";
            this.dgvtxtDeposit.Name = "dgvtxtDeposit";
            this.dgvtxtDeposit.Width = 76;
            // 
            // dgvtxtWithdraw
            // 
            this.dgvtxtWithdraw.HeaderText = "Withdraw";
            this.dgvtxtWithdraw.Name = "dgvtxtWithdraw";
            this.dgvtxtWithdraw.Width = 76;
            // 
            // dgvtxtStatementDate
            // 
            this.dgvtxtStatementDate.HeaderText = "Statement Date";
            this.dgvtxtStatementDate.Name = "dgvtxtStatementDate";
            this.dgvtxtStatementDate.Width = 76;
            // 
            // dgvtxtLedgerPostingId
            // 
            this.dgvtxtLedgerPostingId.HeaderText = "ledgerPostingId";
            this.dgvtxtLedgerPostingId.Name = "dgvtxtLedgerPostingId";
            this.dgvtxtLedgerPostingId.Width = 76;
            // 
            // frmBankReconciliation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1067, 738);
            this.Controls.Add(this.dgvBankReconciliation);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpStatrmentTo);
            this.Controls.Add(this.txtStatementTo);
            this.Controls.Add(this.dtpStatementFrom);
            this.Controls.Add(this.txtStatementFrom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDifferenceCr);
            this.Controls.Add(this.txtDifferenceDr);
            this.Controls.Add(this.txtBalanceBankCr);
            this.Controls.Add(this.txtBalanceBankDr);
            this.Controls.Add(this.txtBalanceCompanyCr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBalanceCompnyDr);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbBankAccount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmBankReconciliation";
            this.Padding = new System.Windows.Forms.Padding(20, 12, 20, 12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Reconciliation";
            this.Load += new System.EventHandler(this.frmBankReconciliation_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBankReconciliation_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankReconciliation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbBankAccount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBalanceCompnyDr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBalanceCompanyCr;
        private System.Windows.Forms.TextBox txtBalanceBankCr;
        private System.Windows.Forms.TextBox txtBalanceBankDr;
        private System.Windows.Forms.TextBox txtDifferenceCr;
        private System.Windows.Forms.TextBox txtDifferenceDr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpStatementFrom;
        private System.Windows.Forms.TextBox txtStatementFrom;
        private System.Windows.Forms.DateTimePicker dtpStatrmentTo;
        private System.Windows.Forms.TextBox txtStatementTo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvBankReconciliation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtParticular;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtChequeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtChequeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDeposit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtWithdraw;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtStatementDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtLedgerPostingId;
    }
}