﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginForm.Services;
using LoginForm.DataSet;

namespace LoginForm
{
    public partial class frmPurchaseInvoiceLoader : Form
    {
        IMEEntities IME = new IMEEntities();
        public frmPurchaseInvoiceLoader()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtReader.PurchaseInvoicetxtReader();
        }

        private void frmPurchaseInvoiceLoader_Load(object sender, EventArgs e)
        {

            PurchaseInvoiceList.DataSource = IME.PurchaseInvoices.ToList();
            PurchaseInvoiceList.DisplayMember = "BillingDocumentReference";

        }

        private void PurchaseInvoiceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int PurchaseInvoiceListID = (PurchaseInvoiceList.SelectedItem as PurchaseInvoice).ID;
            PurchaseInvoiceItemList.DataSource = IME.PurchaseInvoiceDetails.Where(a=>a.PurchaseInvoiceID== PurchaseInvoiceListID).ToList();
            PurchaseInvoiceItemList.DisplayMember = "PurchaseOrderItemNumber";
        }
    }
}
