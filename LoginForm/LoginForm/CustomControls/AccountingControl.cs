﻿using System;
using System.Windows.Forms;

namespace LoginForm.CustomControls
{
    public partial class AccountingControl : UserControl
    {
        public AccountingControl()
        {
            InitializeComponent();
        }

        private void btnAccountGroup_Click(object sender, EventArgs e)
        {
            frmAccountGroup form = new frmAccountGroup();
            form.ShowDialog();
        }

        private void btnAccountLedger_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExchangeRate_Click(object sender, EventArgs e)
        {
            frmExchangeRate form = new frmExchangeRate();
            form.ShowDialog();
        }

        private void btnTax_Click(object sender, EventArgs e)
        {
            frmTax form = new frmTax();
            form.ShowDialog();
        }

        private void btnVoucherType_Click(object sender, EventArgs e)
        {
            
        }
    }
}