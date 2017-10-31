﻿namespace LoginForm.CustomControls
{
    partial class ManagementControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel31 = new System.Windows.Forms.Panel();
            this.cbCurrencyType = new System.Windows.Forms.ComboBox();
            this.cbCurrency = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTermsOfPayment = new System.Windows.Forms.Button();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.lblVAT = new System.Windows.Forms.Label();
            this.btnRolesAuthorities = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtLowMarginLimit = new System.Windows.Forms.TextBox();
            this.lblLowMarginLimit = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel31.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.71202F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.34389F));
            this.tableLayoutPanel1.Controls.Add(this.panel31, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1023, 553);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel31
            // 
            this.panel31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel31.Controls.Add(this.cbCurrencyType);
            this.panel31.Controls.Add(this.cbCurrency);
            this.panel31.Controls.Add(this.label1);
            this.panel31.Controls.Add(this.btnTermsOfPayment);
            this.panel31.Controls.Add(this.txtVAT);
            this.panel31.Controls.Add(this.lblVAT);
            this.panel31.Controls.Add(this.btnRolesAuthorities);
            this.panel31.Controls.Add(this.btnSave);
            this.panel31.Controls.Add(this.txtLowMarginLimit);
            this.panel31.Controls.Add(this.lblLowMarginLimit);
            this.panel31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel31.Location = new System.Drawing.Point(204, 0);
            this.panel31.Margin = new System.Windows.Forms.Padding(0);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(334, 553);
            this.panel31.TabIndex = 0;
            // 
            // cbCurrencyType
            // 
            this.cbCurrencyType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCurrencyType.FormattingEnabled = true;
            this.cbCurrencyType.Items.AddRange(new object[] {
            "Buy",
            "Eff. Buy",
            "Sale",
            "Eff. Sale"});
            this.cbCurrencyType.Location = new System.Drawing.Point(191, 147);
            this.cbCurrencyType.Name = "cbCurrencyType";
            this.cbCurrencyType.Size = new System.Drawing.Size(125, 26);
            this.cbCurrencyType.TabIndex = 11;
            // 
            // cbCurrency
            // 
            this.cbCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCurrency.FormattingEnabled = true;
            this.cbCurrency.Location = new System.Drawing.Point(191, 115);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(125, 26);
            this.cbCurrency.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Default Currency";
            // 
            // btnTermsOfPayment
            // 
            this.btnTermsOfPayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTermsOfPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.btnTermsOfPayment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(214)))), ((int)(((byte)(167)))));
            this.btnTermsOfPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTermsOfPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTermsOfPayment.Location = new System.Drawing.Point(-1, 394);
            this.btnTermsOfPayment.Margin = new System.Windows.Forms.Padding(0);
            this.btnTermsOfPayment.Name = "btnTermsOfPayment";
            this.btnTermsOfPayment.Size = new System.Drawing.Size(335, 37);
            this.btnTermsOfPayment.TabIndex = 8;
            this.btnTermsOfPayment.Text = "Terms of Payment";
            this.btnTermsOfPayment.UseVisualStyleBackColor = false;
            this.btnTermsOfPayment.Click += new System.EventHandler(this.btnTermsOfPayment_Click);
            // 
            // txtVAT
            // 
            this.txtVAT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVAT.Location = new System.Drawing.Point(191, 71);
            this.txtVAT.Margin = new System.Windows.Forms.Padding(3, 3, 16, 3);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(125, 24);
            this.txtVAT.TabIndex = 7;
            // 
            // lblVAT
            // 
            this.lblVAT.AutoSize = true;
            this.lblVAT.Location = new System.Drawing.Point(16, 74);
            this.lblVAT.Margin = new System.Windows.Forms.Padding(16, 0, 3, 0);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(35, 18);
            this.lblVAT.TabIndex = 6;
            this.lblVAT.Text = "VAT";
            // 
            // btnRolesAuthorities
            // 
            this.btnRolesAuthorities.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRolesAuthorities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.btnRolesAuthorities.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(214)))), ((int)(((byte)(167)))));
            this.btnRolesAuthorities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRolesAuthorities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRolesAuthorities.Location = new System.Drawing.Point(-2, 440);
            this.btnRolesAuthorities.Margin = new System.Windows.Forms.Padding(0);
            this.btnRolesAuthorities.Name = "btnRolesAuthorities";
            this.btnRolesAuthorities.Size = new System.Drawing.Size(335, 37);
            this.btnRolesAuthorities.TabIndex = 5;
            this.btnRolesAuthorities.Text = "Roles and Authorities";
            this.btnRolesAuthorities.UseVisualStyleBackColor = false;
            this.btnRolesAuthorities.Click += new System.EventHandler(this.btnRolesAuthorities_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(0, 496);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(332, 55);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtLowMarginLimit
            // 
            this.txtLowMarginLimit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLowMarginLimit.Location = new System.Drawing.Point(191, 27);
            this.txtLowMarginLimit.Margin = new System.Windows.Forms.Padding(3, 3, 16, 3);
            this.txtLowMarginLimit.Name = "txtLowMarginLimit";
            this.txtLowMarginLimit.Size = new System.Drawing.Size(125, 24);
            this.txtLowMarginLimit.TabIndex = 1;
            // 
            // lblLowMarginLimit
            // 
            this.lblLowMarginLimit.AutoSize = true;
            this.lblLowMarginLimit.Location = new System.Drawing.Point(16, 30);
            this.lblLowMarginLimit.Margin = new System.Windows.Forms.Padding(16, 0, 3, 0);
            this.lblLowMarginLimit.Name = "lblLowMarginLimit";
            this.lblLowMarginLimit.Size = new System.Drawing.Size(120, 18);
            this.lblLowMarginLimit.TabIndex = 0;
            this.lblLowMarginLimit.Text = "Low Margin Limit";
            // 
            // ManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ManagementControl";
            this.Size = new System.Drawing.Size(1023, 553);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel31.ResumeLayout(false);
            this.panel31.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel31;
        private System.Windows.Forms.TextBox txtLowMarginLimit;
        private System.Windows.Forms.Label lblLowMarginLimit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRolesAuthorities;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.Button btnTermsOfPayment;
        private System.Windows.Forms.ComboBox cbCurrencyType;
        private System.Windows.Forms.ComboBox cbCurrency;
        private System.Windows.Forms.Label label1;
    }
}
