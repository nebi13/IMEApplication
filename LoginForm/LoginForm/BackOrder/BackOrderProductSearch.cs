﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginForm.DataSet;
using LoginForm.Services;
using static LoginForm.Services.MyClasses.MyAuthority;

namespace LoginForm.BackOrder
{
    public partial class BackOrderProductSearch : MyForm
    {
        public BackOrderProductSearch()
        {
            InitializeComponent();
            checkAuthorities();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            IMEEntities IME = new IMEEntities();
            dg.Rows.Clear();
            dg.Refresh();
            var BackOrderItemSeachList= IME.BackOrderItemSeach(txtSearch.Text).ToList();
            foreach (var item in BackOrderItemSeachList)
            {
                DataGridViewRow row = (DataGridViewRow)dg.Rows[0].Clone();
                row.Cells[Adder.Index].Value = item.Adder;
                row.Cells[CustomerName.Index].Value = item.customerName;
                row.Cells[FirstPromisedDate.Index].Value = item.FirstDate;
                row.Cells[CurrentPromisedDate1.Index].Value = item.PromisedDate;
                row.Cells[PendingAmount.Index].Value = item.PendingQuantity;
                row.Cells[Productno.Index].Value = item.ProductNo;
                row.Cells[PurchaseOrderNumber.Index].Value = item.PurchaseOrderNo;
                row.Cells[Quantity.Index].Value = item.SaleOrderQuantity;
                row.Cells[QuotationNo.Index].Value = item.QuotationNo;
                row.Cells[Representative.Index].Value = item.RepresentativeID;
                row.Cells[OrderDate.Index].Value = item.SaleDate;
                row.Cells[SaleOrder.Index].Value = item.SaleOrderID;
                dg.Rows.Add(row);
            }
            if (BackOrderItemSeachList.Count== 0)
            {
                MessageBox.Show("There is no such an Item");
            }
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Close", "Are you sure to close this page", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BackOrderProductSearch_Load(object sender, EventArgs e)
        {
            Utils.LogKayit("RoleAuths Main", "RoleAuths main screen has been entered");
        }

        public void checkAuthorities()
        {
            List<DataSet.AuthorizationValue> authList = Utils.getCurrentUser().AuthorizationValues.ToList();

            if (!Utils.AuthorityCheck(IMEAuthority.ViewExcel))
            {
                btnExcel.Visible = false;
            }
        }
    }

 }
