﻿using LoginForm.Services.SP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm.f_RSInvoice
{
    public partial class frm_RSInvoice : Form
    {
        public frm_RSInvoice()
        {
            InitializeComponent();

            dtpToDate.MaxDate = DateTime.Today;

            typeof(DataGridView).InvokeMember("DoubleBuffered", System.Reflection.BindingFlags.NonPublic |
            System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty, null,
            dgRSInvoice, new object[] { true });
        }

        private void frm_RSInvoice_Load(object sender, EventArgs e)
        {
            dtpToDate.Value = DateTime.Now.Date;
            dtpFromDate.Value = DateTime.Now.AddMonths(-1).Date;

            dgRSInvoice.DataSource = new Sp_RSInvoice().GetRSInvoiceBetweenDates(dtpFromDate.Value.Date,dtpToDate.Value.AddDays(1).Date);
            FixGridColumns();
            dgRSInvoice.ClearSelection();
            dgRSInvoice.Focus();
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            dgRSInvoice.DataSource = null;
            dgRSInvoice.DataSource = new Sp_RSInvoice().GetRSInvoiceBetweenDates(dtpFromDate.Value.Date, dtpToDate.Value.AddDays(1).Date);
            FixGridColumns();
        }

        private void btnModifyQuotation_Click(object sender, EventArgs e)
        {
            
        }

        private void ShowHiddenRows()
        {
            foreach (DataGridViewRow row in dgRSInvoice.Rows)
            {
                if (!row.Visible)
                {
                    row.Visible = true;
                }
            }
        }

        private void btnDeleteQuotation_Click(object sender, EventArgs e)
        {
            
        }

        private void HideChoosenRows()
        {
            if (dgRSInvoice.SelectedRows.Count != 0)
            {
                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgRSInvoice.DataSource];
                currencyManager1.SuspendBinding();
                foreach (DataGridViewRow row in dgRSInvoice.SelectedRows)
                {
                    row.Visible = false;
                }
                currencyManager1.ResumeBinding();
            }
        }

        private void dgRSInvoice_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dgRSInvoice.HitTest(e.X, e.Y);
                dgRSInvoice.ClearSelection();
                dgRSInvoice.Rows[hti.RowIndex].Selected = true;
            }
        }

        private void btnNewInvoice_Click(object sender, EventArgs e)
        {

        }

        private void FixGridColumns()
        {
            dgRSInvoice.Columns["ID"].Visible = false;

            dgRSInvoice.Columns["ShipmentReference"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgRSInvoice.Columns["ShipmentReference"].HeaderText = "Shipment Reference";
            dgRSInvoice.Columns["BillingDocumentReference"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgRSInvoice.Columns["BillingDocumentReference"].HeaderText = "Billing Document Reference";
            dgRSInvoice.Columns["ShippingCondition"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgRSInvoice.Columns["ShippingCondition"].HeaderText = "Shipping Condition";
            dgRSInvoice.Columns["BillingDocumentDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgRSInvoice.Columns["BillingDocumentDate"].HeaderText = "Billing DocumentDate";
            dgRSInvoice.Columns["SupplyingECCompany"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgRSInvoice.Columns["SupplyingECCompany"].HeaderText = "Supplying EC Company";
            dgRSInvoice.Columns["CustomerReference"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgRSInvoice.Columns["CustomerReference"].HeaderText = "Customer Reference";
            dgRSInvoice.Columns["InvoiceTaxValue"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgRSInvoice.Columns["InvoiceTaxValue"].HeaderText = "Invoice Tax Value";
            dgRSInvoice.Columns["InvoiceGoodsValue"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgRSInvoice.Columns["InvoiceGoodsValue"].HeaderText = "Invoice Goods Value";
            dgRSInvoice.Columns["InvoiceNettValue"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgRSInvoice.Columns["InvoiceNettValue"].HeaderText = "Invoice Nett Value";
            dgRSInvoice.Columns["Currency"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgRSInvoice.Columns["AirwayBillNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgRSInvoice.Columns["AirwayBillNumber"].HeaderText = "Airway Bill Number";
            dgRSInvoice.Columns["Discount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgRSInvoice.Columns["Surcharge"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgRSInvoice.Columns["Status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgRSInvoice.Columns["Deleted"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgRSInvoice.Columns["Supplier"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
        }

        private void viewInvoicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Int32.TryParse(dgRSInvoice.SelectedRows[0].Cells["ID"].Value.ToString(), out int InvoiceID))
            {
                frm_RsInvoiceDetail form = new frm_RsInvoiceDetail(InvoiceID);
                form.Show();
            }
            
        }
    }
}
