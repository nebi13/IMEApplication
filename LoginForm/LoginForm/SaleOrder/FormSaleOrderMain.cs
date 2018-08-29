﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LoginForm.DataSet;
using System.Linq;
using System.Drawing;
using LoginForm.PurchaseOrder;
using LoginForm.QuotationModule;
using LoginForm.Services;
using System.Data;
using LoginForm.clsClasses;
using static LoginForm.Services.MyClasses.MyAuthority;
using ImeLogoLibrary;

namespace LoginForm.nsSaleOrder
{
    public partial class FormSalesOrderMain : MyForm
    {
        //List<SalesOrder> list = new List<SalesOrder>
        ContextMenu PurchaseOrderMenu = new ContextMenu();

        public FormSalesOrderMain()
        {
            InitializeComponent();

            //if (Utils.getCurrentUser().AuthorizationValues.Where(x=>x.AuthorizationID == 1022).FirstOrDefault() == null)
            //{
            //    btnDelete.Visible = false;
            //}
        }


        private void ControlAutorization()
        {
            if (!Utils.AuthorityCheck(IMEAuthority.CanAddSaleOrderModule))
            {
                btnNew.Visible = false;
            }
            //if (Utils.getCurrentUser().AuthorizationValues.Where(a => a.AuthorizationID == 1106).FirstOrDefault() == null)
            //{
            //    btnModify.Visible = false;
            //}
        }


        private void FormSalesOrderMain_Load(object sender, EventArgs e)
        {
            ControlAutorization();
            datetimeEnd.MaxDate = DateTime.Today.Date;
            datetimeEnd.Value = DateTime.Today.Date;
            datetimeStart.Value = DateTime.Today.AddMonths(-3);
            BringSalesList(datetimeEnd.Value, datetimeStart.Value);
        }

        private void BringSalesList()
        {
            BringSalesList(DateTime.Today, DateTime.Today.AddDays(-7));
        }

        private void BringSalesList(DateTime endDate, DateTime startDate)
        {
            IMEEntities IME = new IMEEntities();
            endDate = endDate.AddDays(1);
            var list = (from so in IME.SaleOrders
                       from cw in IME.CustomerWorkers.Where(x => x.ID == so.ContactID)
                       from ca in IME.CustomerAddresses.Where(x => x.ID == so.InvoiceAddressID)
                       from cw1 in IME.CustomerWorkers.Where(x => x.ID == so.DeliveryContactID).DefaultIfEmpty()
                       from ca1 in IME.CustomerAddresses.Where(x => x.ID == so.DeliveryAddressID).DefaultIfEmpty()
                       where so.SaleDate <= endDate && so.SaleDate >= startDate
                       select new
                       {
                           Date = so.SaleDate,
                           SoNO = so.SaleOrderNo,
                           CustomerName = cw.Customer.c_name,
                           Contact = cw.cw_name,
                           DeliveryContact = cw1.cw_name,
                           Address = ca.AdressTitle,
                           DeliveryAddress = ca1.AdressTitle,
                           SaleID = so.SaleOrderID
                       }).OrderByDescending(s=> s.SoNO);
            populateGrid(list.ToList());
        }

        private void populateGrid<T>(List<T> queryable)
        {
            dgSales.DataSource = null;
            dgSales.DataSource = queryable;

            foreach (DataGridViewColumn col in dgSales.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            }
            dgSales.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormSaleOrderCreate form = new FormSaleOrderCreate();
            form.Show();
            BringSalesList();
        }
        private void dgSales_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {

                if (dgSales.CurrentRow != null)
                {
                    IMEEntities IME = new IMEEntities();

                    //string SaleOrderNo = dgSales.CurrentRow.Cells[1].Value.ToString();
                    //TODO gridde saleID'de olmalı.
                    decimal SaleID = (decimal)dgSales.CurrentRow.Cells[1].Value;

                    SaleOrder so = IME.SaleOrders.Where(x => x.SaleOrderID == SaleID).FirstOrDefault();

                   // NewPurchaseOrder form = new NewPurchaseOrder(so);
                   // form.ShowDialog();
                }
            }
        }

        private void dgSales_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgSales.CurrentRow != null)
            {
                IMEEntities IME = new IMEEntities();

                //string SaleOrderNo = dgSales.CurrentRow.Cells[1].Value.ToString();
                //TODO gridde saleID'de olmalı.
                decimal SaleID = (decimal)dgSales.CurrentRow.Cells[1].Value;

                SaleOrder so = IME.SaleOrders.Where(x => x.SaleOrderID == SaleID).FirstOrDefault();

               // NewPurchaseOrder form = new NewPurchaseOrder(so);
              //  form.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            IMEEntities db = new IMEEntities();
            foreach (DataGridViewRow row in dgSales.SelectedRows)
            {
                //string SaleID = row.Cells[1].Value.ToString();
                //TODO gridde saleID'de olmalı.
                decimal SaleID = (decimal)dgSales.CurrentRow.Cells[1].Value;
                SaleOrder s = db.SaleOrders.Where(x => x.SaleOrderID == SaleID).FirstOrDefault();
                if(s != null)
                {
                    if (s.SaleOrderDetails != null)
                    {
                        db.SaleOrderDetails.RemoveRange(s.SaleOrderDetails);
                    }
                    db.SaleOrders.Remove(s);
                    db.SaveChanges();
                }
            }
            BringSalesList();
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            BringSalesList(datetimeEnd.Value.Date, datetimeStart.Value.Date);
        }

        private void FormSalesOrderMain_Activated(object sender, EventArgs e)
        {
            BringSalesList();
        }

        private void sentToPurchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decimal item_code = 0;
            // string purchasecode = "";
            IMEEntities IME = new IMEEntities();

            if (dgSales.CurrentRow.Cells["SoNO"].Value != null)
            {
                item_code = Convert.ToDecimal(dgSales.CurrentRow.Cells["SaleID"].Value.ToString());
            }
            if (item_code == 0)
                MessageBox.Show("Please Enter a Item Code", "Eror !");
            else
            {
                this.Close();
                NewPurchaseOrder f = new NewPurchaseOrder(item_code);
                f.Show();
            }
        }

        private void sentToLogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string server = @"195.201.76.136";
            string imedatabase = "IME";
            string logodatabase = "TEST";
            string sqluser = "sa";
            string sqlpassword = "ime1453..";

            ImeLogoSalesOrder order = new ImeLogoSalesOrder();
            ImeSQL imesql = new ImeSQL();
            LogoSQL logosql = new LogoSQL();
            MessageBox.Show(order.addSalesOrder(imesql.ImeSqlConnect(server, imedatabase, sqluser, sqlpassword), dgSales.CurrentRow.Cells["SaleID"].Value.ToString(), logosql.LogoSqlConnect(server, logodatabase, sqluser, sqlpassword), Utils.FrmNo, Utils.DnmNo));
        }

        private void btnModify_Click(object sender, EventArgs e)
        {

        }

        private void dgSales_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ViewSaleOrder();
        }

        private void ViewSaleOrder()
        {
            if (dgSales.CurrentRow != null)
            {
                decimal QuotationNo = Convert.ToDecimal(dgSales.CurrentRow.Cells["SoNO"].Value);
                SaleOrder saleOrder;

                IMEEntities IME = new IMEEntities();
                try
                {
                    saleOrder = IME.SaleOrders.Where(s => s.SaleOrderNo == QuotationNo).FirstOrDefault();
                }
                catch (Exception)
                {

                    throw;
                }
                if (saleOrder != null)
                {
                    FormSaleOrderAdd newForm = new FormSaleOrderAdd(saleOrder.Customer, saleOrder.SaleOrderDetails.ToList(), 0);
                    newForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("You did not chose any quotation.", "Warning!");
            }
        }
    }
}
