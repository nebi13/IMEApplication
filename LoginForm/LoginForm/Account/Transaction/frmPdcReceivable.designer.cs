﻿namespace LoginForm
{
    partial class frmPdcReceivable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPdcReceivable));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBankValidator = new System.Windows.Forms.Label();
            this.lblChecknoValidator = new System.Windows.Forms.Label();
            this.lbAmountValidator = new System.Windows.Forms.Label();
            this.dtpcheckdate = new System.Windows.Forms.DateTimePicker();
            this.lblCheckdate = new System.Windows.Forms.Label();
            this.txtCheckDate = new System.Windows.Forms.TextBox();
            this.btnNewAccountLedger2 = new System.Windows.Forms.Button();
            this.cmbBank = new System.Windows.Forms.ComboBox();
            this.lblBank = new System.Windows.Forms.Label();
            this.lblCheckNo = new System.Windows.Forms.Label();
            this.txtcheckNo = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnAgainRef = new System.Windows.Forms.Button();
            this.cbxPrint = new System.Windows.Forms.CheckBox();
            this.lblNarration = new System.Windows.Forms.Label();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.btnNewAccountLedger = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAccountLedger = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblvoucherNo = new System.Windows.Forms.Label();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.cmbAccountLedger = new System.Windows.Forms.ComboBox();
            this.txtVoucherDate = new System.Windows.Forms.TextBox();
            this.dtpVoucherDate = new System.Windows.Forms.DateTimePicker();
            this.lblVoucherNoManualValidator = new System.Windows.Forms.Label();
            this.lblaccountLedgerlValidator = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBankValidator);
            this.groupBox1.Controls.Add(this.lblChecknoValidator);
            this.groupBox1.Controls.Add(this.lbAmountValidator);
            this.groupBox1.Controls.Add(this.dtpcheckdate);
            this.groupBox1.Controls.Add(this.lblCheckdate);
            this.groupBox1.Controls.Add(this.txtCheckDate);
            this.groupBox1.Controls.Add(this.btnNewAccountLedger2);
            this.groupBox1.Controls.Add(this.cmbBank);
            this.groupBox1.Controls.Add(this.lblBank);
            this.groupBox1.Controls.Add(this.lblCheckNo);
            this.groupBox1.Controls.Add(this.txtcheckNo);
            this.groupBox1.Controls.Add(this.lblAmount);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(27, 155);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.groupBox1.Size = new System.Drawing.Size(1013, 108);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // lblBankValidator
            // 
            this.lblBankValidator.AutoSize = true;
            this.lblBankValidator.ForeColor = System.Drawing.Color.Red;
            this.lblBankValidator.Location = new System.Drawing.Point(937, 33);
            this.lblBankValidator.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblBankValidator.Name = "lblBankValidator";
            this.lblBankValidator.Size = new System.Drawing.Size(13, 17);
            this.lblBankValidator.TabIndex = 1151;
            this.lblBankValidator.Text = "*";
            // 
            // lblChecknoValidator
            // 
            this.lblChecknoValidator.AutoSize = true;
            this.lblChecknoValidator.ForeColor = System.Drawing.Color.Red;
            this.lblChecknoValidator.Location = new System.Drawing.Point(451, 65);
            this.lblChecknoValidator.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblChecknoValidator.Name = "lblChecknoValidator";
            this.lblChecknoValidator.Size = new System.Drawing.Size(13, 17);
            this.lblChecknoValidator.TabIndex = 1150;
            this.lblChecknoValidator.Text = "*";
            // 
            // lbAmountValidator
            // 
            this.lbAmountValidator.AutoSize = true;
            this.lbAmountValidator.ForeColor = System.Drawing.Color.Red;
            this.lbAmountValidator.Location = new System.Drawing.Point(451, 33);
            this.lbAmountValidator.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lbAmountValidator.Name = "lbAmountValidator";
            this.lbAmountValidator.Size = new System.Drawing.Size(13, 17);
            this.lbAmountValidator.TabIndex = 1149;
            this.lbAmountValidator.Text = "*";
            // 
            // dtpcheckdate
            // 
            this.dtpcheckdate.CustomFormat = "dd-MMM-yyyy";
            this.dtpcheckdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpcheckdate.Location = new System.Drawing.Point(908, 60);
            this.dtpcheckdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpcheckdate.Name = "dtpcheckdate";
            this.dtpcheckdate.Size = new System.Drawing.Size(25, 22);
            this.dtpcheckdate.TabIndex = 503;
            this.dtpcheckdate.ValueChanged += new System.EventHandler(this.dtpcheckdate_ValueChanged);
            // 
            // lblCheckdate
            // 
            this.lblCheckdate.AutoSize = true;
            this.lblCheckdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCheckdate.Location = new System.Drawing.Point(521, 65);
            this.lblCheckdate.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.lblCheckdate.Name = "lblCheckdate";
            this.lblCheckdate.Size = new System.Drawing.Size(91, 17);
            this.lblCheckdate.TabIndex = 475;
            this.lblCheckdate.Text = "Cheque Date";
            // 
            // txtCheckDate
            // 
            this.txtCheckDate.Location = new System.Drawing.Point(668, 60);
            this.txtCheckDate.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.txtCheckDate.Name = "txtCheckDate";
            this.txtCheckDate.Size = new System.Drawing.Size(265, 22);
            this.txtCheckDate.TabIndex = 4;
            this.txtCheckDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCheckDate_KeyDown);
            this.txtCheckDate.Leave += new System.EventHandler(this.txtCheckDate_Leave);
            // 
            // btnNewAccountLedger2
            // 
            this.btnNewAccountLedger2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNewAccountLedger2.FlatAppearance.BorderSize = 0;
            this.btnNewAccountLedger2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewAccountLedger2.ForeColor = System.Drawing.Color.White;
            this.btnNewAccountLedger2.Location = new System.Drawing.Point(963, 28);
            this.btnNewAccountLedger2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewAccountLedger2.Name = "btnNewAccountLedger2";
            this.btnNewAccountLedger2.Size = new System.Drawing.Size(28, 25);
            this.btnNewAccountLedger2.TabIndex = 2;
            this.btnNewAccountLedger2.UseVisualStyleBackColor = true;
            this.btnNewAccountLedger2.Click += new System.EventHandler(this.btnNewAccountLedger2_Click);
            // 
            // cmbBank
            // 
            this.cmbBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBank.FormattingEnabled = true;
            this.cmbBank.Location = new System.Drawing.Point(668, 28);
            this.cmbBank.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(265, 24);
            this.cmbBank.TabIndex = 1;
            this.cmbBank.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbBank_KeyDown);
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBank.Location = new System.Drawing.Point(521, 33);
            this.lblBank.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(40, 17);
            this.lblBank.TabIndex = 472;
            this.lblBank.Text = "Bank";
            // 
            // lblCheckNo
            // 
            this.lblCheckNo.AutoSize = true;
            this.lblCheckNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCheckNo.Location = new System.Drawing.Point(24, 65);
            this.lblCheckNo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.lblCheckNo.Name = "lblCheckNo";
            this.lblCheckNo.Size = new System.Drawing.Size(83, 17);
            this.lblCheckNo.TabIndex = 455;
            this.lblCheckNo.Text = "Cheque No.";
            // 
            // txtcheckNo
            // 
            this.txtcheckNo.Location = new System.Drawing.Point(171, 60);
            this.txtcheckNo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.txtcheckNo.Name = "txtcheckNo";
            this.txtcheckNo.Size = new System.Drawing.Size(265, 22);
            this.txtcheckNo.TabIndex = 3;
            this.txtcheckNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcheckNo_KeyDown);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAmount.Location = new System.Drawing.Point(24, 33);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(56, 17);
            this.lblAmount.TabIndex = 453;
            this.lblAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(171, 28);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.txtAmount.MaxLength = 10;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(265, 22);
            this.txtAmount.TabIndex = 0;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyDown);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // btnAgainRef
            // 
            this.btnAgainRef.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgainRef.FlatAppearance.BorderSize = 0;
            this.btnAgainRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgainRef.ForeColor = System.Drawing.Color.Black;
            this.btnAgainRef.Location = new System.Drawing.Point(173, 112);
            this.btnAgainRef.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgainRef.Name = "btnAgainRef";
            this.btnAgainRef.Size = new System.Drawing.Size(113, 33);
            this.btnAgainRef.TabIndex = 4;
            this.btnAgainRef.Text = "Against Ref.";
            this.btnAgainRef.UseVisualStyleBackColor = false;
            this.btnAgainRef.Click += new System.EventHandler(this.btnAgainRef_Click);
            this.btnAgainRef.Enter += new System.EventHandler(this.btnAgainRef_Enter);
            this.btnAgainRef.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnAgainRef_KeyDown);
            // 
            // cbxPrint
            // 
            this.cbxPrint.AutoSize = true;
            this.cbxPrint.ForeColor = System.Drawing.Color.White;
            this.cbxPrint.Location = new System.Drawing.Point(27, 422);
            this.cbxPrint.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cbxPrint.Name = "cbxPrint";
            this.cbxPrint.Size = new System.Drawing.Size(126, 21);
            this.cbxPrint.TabIndex = 11;
            this.cbxPrint.Text = "Print after save";
            this.cbxPrint.UseVisualStyleBackColor = true;
            // 
            // lblNarration
            // 
            this.lblNarration.AutoSize = true;
            this.lblNarration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNarration.Location = new System.Drawing.Point(360, 284);
            this.lblNarration.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(67, 17);
            this.lblNarration.TabIndex = 496;
            this.lblNarration.Text = "Narration";
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(507, 284);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(532, 122);
            this.txtNarration.TabIndex = 6;
            this.txtNarration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNarration_KeyDown);
            this.txtNarration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNarration_KeyPress);
            // 
            // btnNewAccountLedger
            // 
            this.btnNewAccountLedger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNewAccountLedger.FlatAppearance.BorderSize = 0;
            this.btnNewAccountLedger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewAccountLedger.ForeColor = System.Drawing.Color.White;
            this.btnNewAccountLedger.Location = new System.Drawing.Point(475, 81);
            this.btnNewAccountLedger.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewAccountLedger.Name = "btnNewAccountLedger";
            this.btnNewAccountLedger.Size = new System.Drawing.Size(28, 25);
            this.btnNewAccountLedger.TabIndex = 3;
            this.btnNewAccountLedger.UseVisualStyleBackColor = true;
            this.btnNewAccountLedger.Click += new System.EventHandler(this.btnNewAccountLedger_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDate.Location = new System.Drawing.Point(27, 54);
            this.lblDate.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 17);
            this.lblDate.TabIndex = 492;
            this.lblDate.Text = "Date";
            // 
            // lblAccountLedger
            // 
            this.lblAccountLedger.AutoSize = true;
            this.lblAccountLedger.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAccountLedger.Location = new System.Drawing.Point(27, 85);
            this.lblAccountLedger.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.lblAccountLedger.Name = "lblAccountLedger";
            this.lblAccountLedger.Size = new System.Drawing.Size(108, 17);
            this.lblAccountLedger.TabIndex = 490;
            this.lblAccountLedger.Text = "Account Ledger";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(927, 415);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 33);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(805, 415);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 33);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(684, 415);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(113, 33);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(563, 415);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 33);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
            // 
            // lblvoucherNo
            // 
            this.lblvoucherNo.AutoSize = true;
            this.lblvoucherNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblvoucherNo.Location = new System.Drawing.Point(27, 23);
            this.lblvoucherNo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.lblvoucherNo.Name = "lblvoucherNo";
            this.lblvoucherNo.Size = new System.Drawing.Size(87, 17);
            this.lblvoucherNo.TabIndex = 485;
            this.lblvoucherNo.Text = "Voucher No.";
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.Location = new System.Drawing.Point(173, 18);
            this.txtVoucherNo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(265, 22);
            this.txtVoucherNo.TabIndex = 0;
            this.txtVoucherNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherNo_KeyDown);
            // 
            // cmbAccountLedger
            // 
            this.cmbAccountLedger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccountLedger.FormattingEnabled = true;
            this.cmbAccountLedger.Location = new System.Drawing.Point(173, 80);
            this.cmbAccountLedger.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.cmbAccountLedger.Name = "cmbAccountLedger";
            this.cmbAccountLedger.Size = new System.Drawing.Size(265, 24);
            this.cmbAccountLedger.TabIndex = 2;
            this.cmbAccountLedger.SelectedIndexChanged += new System.EventHandler(this.cmbAccountLedger_SelectedIndexChanged);
            this.cmbAccountLedger.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbAccountLedger_KeyDown);
            // 
            // txtVoucherDate
            // 
            this.txtVoucherDate.Location = new System.Drawing.Point(173, 49);
            this.txtVoucherDate.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.txtVoucherDate.Name = "txtVoucherDate";
            this.txtVoucherDate.Size = new System.Drawing.Size(241, 22);
            this.txtVoucherDate.TabIndex = 1;
            this.txtVoucherDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherDate_KeyDown);
            this.txtVoucherDate.Leave += new System.EventHandler(this.txtVoucherDate_Leave);
            // 
            // dtpVoucherDate
            // 
            this.dtpVoucherDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpVoucherDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVoucherDate.Location = new System.Drawing.Point(413, 49);
            this.dtpVoucherDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpVoucherDate.Name = "dtpVoucherDate";
            this.dtpVoucherDate.Size = new System.Drawing.Size(25, 22);
            this.dtpVoucherDate.TabIndex = 1146;
            this.dtpVoucherDate.ValueChanged += new System.EventHandler(this.dtpVoucherDate_ValueChanged);
            // 
            // lblVoucherNoManualValidator
            // 
            this.lblVoucherNoManualValidator.AutoSize = true;
            this.lblVoucherNoManualValidator.ForeColor = System.Drawing.Color.Red;
            this.lblVoucherNoManualValidator.Location = new System.Drawing.Point(449, 22);
            this.lblVoucherNoManualValidator.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblVoucherNoManualValidator.Name = "lblVoucherNoManualValidator";
            this.lblVoucherNoManualValidator.Size = new System.Drawing.Size(13, 17);
            this.lblVoucherNoManualValidator.TabIndex = 1151;
            this.lblVoucherNoManualValidator.Text = "*";
            this.lblVoucherNoManualValidator.Visible = false;
            // 
            // lblaccountLedgerlValidator
            // 
            this.lblaccountLedgerlValidator.AutoSize = true;
            this.lblaccountLedgerlValidator.ForeColor = System.Drawing.Color.Red;
            this.lblaccountLedgerlValidator.Location = new System.Drawing.Point(449, 85);
            this.lblaccountLedgerlValidator.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblaccountLedgerlValidator.Name = "lblaccountLedgerlValidator";
            this.lblaccountLedgerlValidator.Size = new System.Drawing.Size(13, 17);
            this.lblaccountLedgerlValidator.TabIndex = 1152;
            this.lblaccountLedgerlValidator.Text = "*";
            // 
            // frmPdcReceivable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(1067, 463);
            this.Controls.Add(this.lblaccountLedgerlValidator);
            this.Controls.Add(this.lblVoucherNoManualValidator);
            this.Controls.Add(this.dtpVoucherDate);
            this.Controls.Add(this.txtVoucherDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAgainRef);
            this.Controls.Add(this.cbxPrint);
            this.Controls.Add(this.lblNarration);
            this.Controls.Add(this.txtNarration);
            this.Controls.Add(this.btnNewAccountLedger);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cmbAccountLedger);
            this.Controls.Add(this.lblAccountLedger);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblvoucherNo);
            this.Controls.Add(this.txtVoucherNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmPdcReceivable";
            this.Padding = new System.Windows.Forms.Padding(20, 12, 20, 12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDC Receivable";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPdcReceivable_FormClosing);
            this.Load += new System.EventHandler(this.frmPdcReceivable_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPdcReceivable_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCheckdate;
        private System.Windows.Forms.Button btnNewAccountLedger2;
        private System.Windows.Forms.ComboBox cmbBank;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.Label lblCheckNo;
        private System.Windows.Forms.TextBox txtcheckNo;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnAgainRef;
        private System.Windows.Forms.CheckBox cbxPrint;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.Button btnNewAccountLedger;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAccountLedger;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblvoucherNo;
        private System.Windows.Forms.DateTimePicker dtpcheckdate;
        private System.Windows.Forms.TextBox txtCheckDate;
        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.ComboBox cmbAccountLedger;
        private System.Windows.Forms.TextBox txtVoucherDate;
        private System.Windows.Forms.DateTimePicker dtpVoucherDate;
        private System.Windows.Forms.Label lblVoucherNoManualValidator;
        private System.Windows.Forms.Label lblaccountLedgerlValidator;
        private System.Windows.Forms.Label lbAmountValidator;
        private System.Windows.Forms.Label lblChecknoValidator;
        private System.Windows.Forms.Label lblBankValidator;
    }
}