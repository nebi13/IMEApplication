﻿using LoginForm.DataSet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using LoginForm.Services;
using static LoginForm.Services.MyClasses.MyAuthority;
using System.Drawing;

namespace LoginForm.QuotationModule
{
    public partial class FormQuotationMain : Form
    {

        DateTime dateNow;
        Worker currentUser = Utils.getCurrentUser();

        public FormQuotationMain()
        {
            IMEEntities IME = new IMEEntities();
            InitializeComponent();

            dgQuotation.RowsDefaultCellStyle.SelectionBackColor = ImeSettings.DefaultGridSelectedRowColor ;

            typeof(DataGridView).InvokeMember("DoubleBuffered", System.Reflection.BindingFlags.NonPublic |
            System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty, null,
            dgQuotation, new object[] { true });

            cbSearch.SelectedIndex = 0;
            dateNow = Utils.GetCurrentDateTime();
            dtpFromDate.Value = Utils.GetCurrentDateTime().AddMonths(-3);
            dtpToDate.Value = dateNow;
        }

        private void btnNewQuotation_Click(object sender, EventArgs e)
        {
            var a = dtpFromDate.Value;
            FormQuaotationCustomerSearch form = new FormQuaotationCustomerSearch();
            Utils.LogKayit("Quotation", "Customer list new screen has been entered");
            form.Show();


           // FormQuotationAdd quotationForm = new FormQuotationAdd(this);
            //Utils.LogKayit("Quotation", "Quotation new screen has been entered");
            //quotationForm.Show();
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            BringQuotationList(dtpFromDate.Value, dtpToDate.Value.AddDays(1));
        }

        private void dgQuotation_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ViewQuotation();
        }

        private void ViewQuotation()
        {
            if (dgQuotation.CurrentRow != null)
            {
                string QuotationNo = dgQuotation.CurrentRow.Cells["QuotationNo"].Value.ToString();
                Quotation quo;

                IMEEntities IME = new IMEEntities();
                try
                {
                    quo = IME.Quotations.Where(q => q.QuotationNo == QuotationNo).FirstOrDefault();
                }
                catch (Exception)
                {

                    throw;
                }
                if (quo != null)
                {
                    FormQuotationAdd newForm = new FormQuotationAdd(quo, "View");
                    newForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("You did not chose any quotation.", "Warning!");
            }
        }

        private void btnDeleteQuotation_Click(object sender, EventArgs e)
        {
            if (dgQuotation.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Selected quotation(s) will be deleted! Do you confirm?", "Delete Quotation", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    try
                    {
                        IMEEntities IME = new IMEEntities();

                        foreach (DataGridViewRow row in dgQuotation.SelectedRows)
                        {
                            string QuotationNo = row.Cells["QuotationNo"].Value.ToString();

                            Quotation quo = IME.Quotations.Where(q => q.QuotationNo == QuotationNo).FirstOrDefault();

                            quo.status = "Deleted";

                            IME.SaveChanges();
                        }

                        IME.SaveChanges();
                        BringQuotationList(dtpFromDate.Value, dtpToDate.Value);

                        MessageBox.Show("Quotation is successfully deleted.", "Success!");
                        Utils.LogKayit("Quotation", "Quotation deleted");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("An error was encountered", "Error!");
                        throw;
                    }
                }
            }
            else
            {
                MessageBox.Show("You did not chose any quotation.", "Warning!");
            }
        }

        private void btnModifyQuotation_Click(object sender, EventArgs e)
        {
            CreateRevision();
        }

        public void checkAuthorities()
        {
            List<DataSet.AuthorizationValue> authList = Utils.getCurrentUser().AuthorizationValues.ToList();

            if (!Utils.AuthorityCheck(IMEAuthority.AddQuotation) && !Utils.AuthorityCheck(IMEAuthority.EditanyQuotation)
                 && !Utils.AuthorityCheck(IMEAuthority.RevisionQuotation))
            {
                btnModifyQuotation.Visible = false;
                btnNewQuotation.Visible = false;
                btnUpdate.Visible = false;
                qUOTATIONINFOToolStripMenuItem.Visible = false;
                uPDATEQUOTATIONToolStripMenuItem.Visible = false;
                mODIFYQUOTATIONToolStripMenuItem.Visible = false;

                label4.Visible = false;
                label5.Visible = false;
                label10.Visible = false;

            }
            if (!Utils.AuthorityCheck(IMEAuthority.ViewExcel))
            {
                btnExcel.Visible = false;
                label7.Visible = false;
            }

            if (!Utils.AuthorityCheck(IMEAuthority.DeleteQuotation))
            {
                btnDeleteQuotation.Visible = false;
                label6.Visible = false;
                uNDODELETEQUOTATIONToolStripMenuItem.Visible = false;
                dELETEQUOTATIONToolStripMenuItem.Visible = false;
            }
        }

            private void FormQuotationMain_Load(object sender, EventArgs e)
        {
            checkAuthorities();
            IMEEntities IME = new IMEEntities();
            //if (!Utils.AuthorityCheck(IMEAuthority.CanDeleteQuotation))//Can Delete Quotation
            //{
            //    btnDeleteQuotation.Enabled = false;
            //}
            //if (!Utils.AuthorityCheck(IMEAuthority.CanEditAnyQuotation))//Can Modify edit
            //{
            //    btnModifyQuotation.Enabled = false;
            //}
            //if (!Utils.AuthorityCheck(IMEAuthority.CanAddQuotation))//Can Add Quotation
            //{
            //    btnNewQuotation.Enabled = false;
            //}
            //BringQuotationList(DateTime.Now.AddDays(-1), DateTime.Now); //Bu gün oluşturulan quotation ları göstermek için.5+++12#
            BringQuotationList(dtpFromDate.Value, dtpToDate.Value.AddDays(1)); //Bu gün oluşturulan quotation ları göstermek için.5+++12#
        }

        private void txtSearchText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) && cbSearch.SelectedItem != null)
            {
                if (chcAllQuots.Checked==true)
                {
                    IMEEntities IME = new IMEEntities();
                    switch (cbSearch.SelectedItem.ToString())
                    {
                        case "QUOT NUMBER":
                            var list1 = (from q in IME.Quotations
                                         join c in IME.Customers on q.CustomerID equals c.ID
                                         select new
                                         {
                                             Date = q.StartDate,
                                             QuotationNo = q.QuotationNo,
                                             Rep_Name = q.Worker.NameLastName,
                                             PreparedBy = currentUser.NameLastName.ToString(),
                                             RFQ = q.RFQNo,
                                             CustomerCode = c.ID,
                                             CustomerName = c.c_name,
                                             Total = q.GrossTotal,
                                             Currency = q.CurrName,
                                             OrderDate = (q.SaleOrder != null) ? q.SaleOrder.SaleDate.ToString() : "",
                                             City = c.CustomerAddresses.Where(x => x.CustomerID == c.ID).FirstOrDefault().City.City_name,
                                             SaleOrderID = q.SaleOrderID,
                                             SaleOrderNo = (q.SaleOrder != null) ? q.SaleOrder.SaleOrderNo.ToString() : "",
                                             OrderStatus = q.status,
                                             FirstNote = q.FirstNote,
                                             Date1 = q.NoteDate1,
                                             Rep1 = q.NoteRep1,
                                             SecondNote = q.SecondNote,
                                             Date2 = q.NoteDate2,
                                             Rep2 = q.NoteRep2
                                         }).ToList();
                            var quoList = list1.Where(a => a.QuotationNo.Substring(a.QuotationNo.LastIndexOf('/')).Contains(txtSearchText.Text)).ToList();
                            populateGrid(quoList.ToList());
                            break;

                        case "CUSTOMER CODE":
                            string customerCode = txtSearchText.Text.ToUpperInvariant();
                            var list2 = from q in IME.Quotations
                                        join c in IME.Customers on q.CustomerID equals c.ID
                                        where c.ID.Contains(customerCode)
                                        select new
                                        {
                                            Date = q.StartDate,
                                            QuotationNo = q.QuotationNo,
                                            Rep_Name = q.Worker.NameLastName,
                                            PreparedBy = currentUser.NameLastName.ToString(),
                                            RFQ = q.RFQNo,
                                            CustomerCode = c.ID,
                                            CustomerName = c.c_name,
                                            Total = q.GrossTotal,
                                            Currency = q.CurrName,
                                            OrderDate = (q.SaleOrder != null) ? q.SaleOrder.SaleDate.ToString() : "",
                                            City = c.CustomerAddresses.Where(x => x.CustomerID == c.ID).FirstOrDefault().City.City_name,
                                            SaleOrderID = q.SaleOrderID,
                                            SaleOrderNo = (q.SaleOrder != null) ? q.SaleOrder.SaleOrderNo.ToString() : "",
                                            OrderStatus = q.status,
                                            FirstNote = q.FirstNote,
                                            Date1 = q.NoteDate1,
                                            Rep1 = q.NoteRep1,
                                            SecondNote = q.SecondNote,
                                            Date2 = q.NoteDate2,
                                            Rep2 = q.NoteRep2
                                        };

                            populateGrid(list2.ToList());
                            break;

                        case "CUSTOMER NAME":
                            string customerName = txtSearchText.Text.ToUpperInvariant();
                            var list3 = from q in IME.Quotations
                                        join c in IME.Customers on q.CustomerID equals c.ID
                                        where c.c_name.Contains(customerName)
                                        select new
                                        {
                                            Date = q.StartDate,
                                            QuotationNo = q.QuotationNo,
                                            Rep_Name = q.Worker.NameLastName,
                                            PreparedBy = currentUser.NameLastName.ToString(),
                                            RFQ = q.RFQNo,
                                            CustomerCode = c.ID,
                                            CustomerName = c.c_name,
                                            Total = q.GrossTotal,
                                            Currency = q.CurrName,
                                            OrderDate = (q.SaleOrder != null) ? q.SaleOrder.SaleDate.ToString() : "",
                                            City = c.CustomerAddresses.Where(x => x.CustomerID == c.ID).FirstOrDefault().City.City_name,
                                            SaleOrderID = q.SaleOrderID,
                                            SaleOrderNo = (q.SaleOrder != null) ? q.SaleOrder.SaleOrderNo.ToString() : "",
                                            OrderStatus = q.status,
                                            FirstNote = q.FirstNote,
                                            Date1 = q.NoteDate1,
                                            Rep1 = q.NoteRep1,
                                            SecondNote = q.SecondNote,
                                            Date2 = q.NoteDate2,
                                            Rep2 = q.NoteRep2
                                        };

                            populateGrid(list3.ToList());
                            break;

                        case "TOTAL AMOUNT":
                            decimal amountDecimal;
                            string searchTxt = txtSearchText.Text.Replace(",", ".");
                            if (Decimal.TryParse(searchTxt, out amountDecimal))
                            {
                                int amount = Decimal.ToInt32(amountDecimal);
                                var list4 = from q in IME.Quotations
                                            join c in IME.Customers on q.CustomerID equals c.ID
                                            where amount <= q.GrossTotal && q.GrossTotal < (amount + 1)
                                            select new
                                            {
                                                Date = q.StartDate,
                                                QuotationNo = q.QuotationNo,
                                                Rep_Name = q.Worker.NameLastName,
                                                PreparedBy = currentUser.NameLastName.ToString(),
                                                RFQ = q.RFQNo,
                                                CustomerCode = c.ID,
                                                CustomerName = c.c_name,
                                                Total = q.GrossTotal,
                                                Currency = q.CurrName,
                                                OrderDate = (q.SaleOrder != null) ? q.SaleOrder.SaleDate.ToString() : "",
                                                City = c.CustomerAddresses.Where(x => x.CustomerID == c.ID).FirstOrDefault().City.City_name,
                                                SaleOrderID = q.SaleOrderID,
                                                SaleOrderNo = (q.SaleOrder != null) ? q.SaleOrder.SaleOrderNo.ToString() : "",
                                                OrderStatus = q.status,
                                                FirstNote = q.FirstNote,
                                                Date1 = q.NoteDate1,
                                                Rep1 = q.NoteRep1,
                                                SecondNote = q.SecondNote,
                                                Date2 = q.NoteDate2,
                                                Rep2 = q.NoteRep2
                                            };

                                populateGrid(list4.ToList());
                            }

                            break;

                        case "RFQ":
                            string rfq = txtSearchText.Text.ToUpperInvariant();
                            var list5 = from q in IME.Quotations
                                        join c in IME.Customers on q.CustomerID equals c.ID
                                        where q.RFQNo.Contains(rfq)
                                        select new
                                        {
                                            Date = q.StartDate,
                                            QuotationNo = q.QuotationNo,
                                            Rep_Name = q.Worker.NameLastName,
                                            PreparedBy = currentUser.NameLastName.ToString(),
                                            RFQ = q.RFQNo,
                                            CustomerCode = c.ID,
                                            CustomerName = c.c_name,
                                            Total = q.GrossTotal,
                                            Currency = q.CurrName,
                                            OrderDate = (q.SaleOrder != null) ? q.SaleOrder.SaleDate.ToString() : "",
                                            City = c.CustomerAddresses.Where(x => x.CustomerID == c.ID).FirstOrDefault().City.City_name,
                                            SaleOrderID = q.SaleOrderID,
                                            SaleOrderNo = (q.SaleOrder != null) ? q.SaleOrder.SaleOrderNo.ToString() : "",
                                            OrderStatus = q.status,
                                            FirstNote = q.FirstNote,
                                            Date1 = q.NoteDate1,
                                            Rep1 = q.NoteRep1,
                                            SecondNote = q.SecondNote,
                                            Date2 = q.NoteDate2,
                                            Rep2 = q.NoteRep2
                                        };

                            populateGrid(list5.ToList());
                            break;

                        case "MPN":
                            string mpn = txtSearchText.Text.ToUpperInvariant();
                            var list6 = (from q in IME.Quotations.Join(IME.QuotationDetails.Where(qd => qd.MPN.Contains(mpn)), q => q.QuotationNo, qd => qd.QuotationNo, (q, qd) => q).Distinct()
                                         join c in IME.Customers on q.CustomerID equals c.ID
                                         select new
                                         {
                                             Date = q.StartDate,
                                             QuotationNo = q.QuotationNo,
                                             Rep_Name = q.Worker.NameLastName,
                                             PreparedBy = currentUser.NameLastName.ToString(),
                                             RFQ = q.RFQNo,
                                             CustomerCode = c.ID,
                                             CustomerName = c.c_name,
                                             Total = q.GrossTotal,
                                             Currency = q.CurrName,
                                             OrderDate = (q.SaleOrder != null) ? q.SaleOrder.SaleDate.ToString() : "",
                                             City = c.CustomerAddresses.Where(x => x.CustomerID == c.ID).FirstOrDefault().City.City_name,
                                             SaleOrderID = q.SaleOrderID,
                                             SaleOrderNo = (q.SaleOrder != null) ? q.SaleOrder.SaleOrderNo.ToString() : "",
                                             OrderStatus = q.status,
                                             FirstNote = q.FirstNote,
                                             Date1 = q.NoteDate1,
                                             Rep1 = q.NoteRep1,
                                             SecondNote = q.SecondNote,
                                             Date2 = q.NoteDate2,
                                             Rep2 = q.NoteRep2
                                         });
                            populateGrid(list6.ToList());
                            break;
                        case "SALE ORDER NO":
                            string SoNO = txtSearchText.Text.ToUpperInvariant();
                            var list7 = from q in IME.Quotations
                                        join c in IME.Customers on q.CustomerID equals c.ID
                                        where q.SaleOrder.SaleOrderNo.ToString().Contains(SoNO)
                                        select new
                                         {
                                             Date = q.StartDate,
                                             QuotationNo = q.QuotationNo,
                                             Rep_Name = q.Worker.NameLastName,
                                             PreparedBy = currentUser.NameLastName.ToString(),
                                             RFQ = q.RFQNo,
                                             CustomerCode = c.ID,
                                             CustomerName = c.c_name,
                                             Total = q.GrossTotal,
                                             Currency = q.CurrName,
                                             OrderDate = (q.SaleOrder != null) ? q.SaleOrder.SaleDate.ToString() : "",
                                             City = c.CustomerAddresses.Where(x => x.CustomerID == c.ID).FirstOrDefault().City.City_name,
                                            SaleOrderID = q.SaleOrderID,
                                            SaleOrderNo = (q.SaleOrder != null) ? q.SaleOrder.SaleOrderNo.ToString() : "",
                                            OrderStatus = q.status,
                                             FirstNote = q.FirstNote,
                                             Date1 = q.NoteDate1,
                                             Rep1 = q.NoteRep1,
                                             SecondNote = q.SecondNote,
                                             Date2 = q.NoteDate2,
                                             Rep2 = q.NoteRep2
                                         };
                            populateGrid(list7.ToList());
                            break;
                        case "PURCHASE ORDER NO":
                            string PoNO = txtSearchText.Text.ToUpperInvariant();
                            var list8 = from q in IME.Quotations
                                        join c in IME.Customers on q.CustomerID equals c.ID
                                        where q.SaleOrder.PurchaseOrder.PurchaseNo.ToString().Contains(PoNO)
                                        select new
                                         {
                                             Date = q.StartDate,
                                             QuotationNo = q.QuotationNo,
                                             Rep_Name = q.Worker.NameLastName,
                                             PreparedBy = currentUser.NameLastName.ToString(),
                                             RFQ = q.RFQNo,
                                             CustomerCode = c.ID,
                                             CustomerName = c.c_name,
                                             Total = q.GrossTotal,
                                             Currency = q.CurrName,
                                             OrderDate = (q.SaleOrder != null) ? q.SaleOrder.SaleDate.ToString() : "",
                                             City = c.CustomerAddresses.Where(x => x.CustomerID == c.ID).FirstOrDefault().City.City_name,
                                             SaleOrderID = q.SaleOrderID,
                                            SaleOrderNo = (q.SaleOrder != null) ? q.SaleOrder.SaleOrderNo.ToString() : "",
                                            OrderStatus = q.status,
                                             FirstNote = q.FirstNote,
                                             Date1 = q.NoteDate1,
                                             Rep1 = q.NoteRep1,
                                             SecondNote = q.SecondNote,
                                             Date2 = q.NoteDate2,
                                             Rep2 = q.NoteRep2
                                         };
                            populateGrid(list8.ToList());
                            break;
                        default:
                            MessageBox.Show("Choosen search filter is not implemented into the software yet", "Error");
                            break;
                    }
                }
                else
                {
                    IMEEntities IME = new IMEEntities();
                    switch (cbSearch.SelectedItem.ToString())
                    {
                        case "QUOT NUMBER":
                            var list1 = (from q in IME.Quotations
                                         join c in IME.Customers on q.CustomerID equals c.ID
                                         where q.StartDate >= dtpFromDate.Value && q.StartDate < dtpToDate.Value
                                         select new
                                         {
                                             Date = q.StartDate,
                                             QuotationNo = q.QuotationNo,
                                             Rep_Name = q.Worker.NameLastName,
                                             PreparedBy = currentUser.NameLastName.ToString(),
                                             RFQ = q.RFQNo,
                                             CustomerCode = c.ID,
                                             CustomerName = c.c_name,
                                             Total = q.GrossTotal,
                                             Currency = q.CurrName,
                                             OrderDate = (q.SaleOrder != null) ? q.SaleOrder.SaleDate.ToString() : "",
                                             City = c.CustomerAddresses.Where(x => x.CustomerID == c.ID).FirstOrDefault().City.City_name,
                                             SaleOrderID = q.SaleOrderID,
                                             SaleOrderNo = (q.SaleOrder != null) ? q.SaleOrder.SaleOrderNo.ToString() : "",
                                             OrderStatus = q.status,
                                             FirstNote = q.FirstNote,
                                             Date1 = q.NoteDate1,
                                             Rep1 = q.NoteRep1,
                                             SecondNote = q.SecondNote,
                                             Date2 = q.NoteDate2,
                                             Rep2 = q.NoteRep2
                                         }).ToList();
                            var quoList = list1.Where(a => a.QuotationNo.Substring(a.QuotationNo.LastIndexOf('/')).Contains(txtSearchText.Text)).ToList();

                            populateGrid(quoList.ToList());
                            break;

                        case "CUSTOMER CODE":
                            string customerCode = txtSearchText.Text.ToUpperInvariant();
                            var list2 = from q in IME.Quotations
                                        join c in IME.Customers on q.CustomerID equals c.ID
                                        where (c.ID.Contains(customerCode)
                                        && q.StartDate >= dtpFromDate.Value && q.StartDate < dtpToDate.Value)
                                        select new
                                        {
                                            Date = q.StartDate,
                                            QuotationNo = q.QuotationNo,
                                            Rep_Name = q.Worker.NameLastName,
                                            PreparedBy = currentUser.NameLastName.ToString(),
                                            RFQ = q.RFQNo,
                                            CustomerCode = c.ID,
                                            CustomerName = c.c_name,
                                            Total = q.GrossTotal,
                                            Currency = q.CurrName,
                                            OrderDate = (q.SaleOrder != null) ? q.SaleOrder.SaleDate.ToString() : "",
                                            City = c.CustomerAddresses.Where(x => x.CustomerID == c.ID).FirstOrDefault().City.City_name,
                                            SaleOrderID = q.SaleOrderID,
                                            SaleOrderNo = (q.SaleOrder != null) ? q.SaleOrder.SaleOrderNo.ToString() : "",
                                            OrderStatus = q.status,
                                            FirstNote = q.FirstNote,
                                            Date1 = q.NoteDate1,
                                            Rep1 = q.NoteRep1,
                                            SecondNote = q.SecondNote,
                                            Date2 = q.NoteDate2,
                                            Rep2 = q.NoteRep2
                                        };

                            populateGrid(list2.ToList());
                            break;

                        case "CUSTOMER NAME":
                            string customerName = txtSearchText.Text.ToUpperInvariant();
                            var list3 = from q in IME.Quotations
                                        join c in IME.Customers on q.CustomerID equals c.ID
                                        where (c.c_name.Contains(customerName)
                                        && q.StartDate >= dtpFromDate.Value && q.StartDate < dtpToDate.Value)
                                        select new
                                        {
                                            Date = q.StartDate,
                                            QuotationNo = q.QuotationNo,
                                            Rep_Name = q.Worker.NameLastName,
                                            PreparedBy = currentUser.NameLastName.ToString(),
                                            RFQ = q.RFQNo,
                                            CustomerCode = c.ID,
                                            CustomerName = c.c_name,
                                            Total = q.GrossTotal,
                                            Currency = q.CurrName,
                                            OrderDate = (q.SaleOrder != null) ? q.SaleOrder.SaleDate.ToString() : "",
                                            City = c.CustomerAddresses.Where(x => x.CustomerID == c.ID).FirstOrDefault().City.City_name,
                                            SaleOrderID = q.SaleOrderID,
                                            SaleOrderNo = (q.SaleOrder != null) ? q.SaleOrder.SaleOrderNo.ToString() : "",
                                            OrderStatus = q.status,
                                            FirstNote = q.FirstNote,
                                            Date1 = q.NoteDate1,
                                            Rep1 = q.NoteRep1,
                                            SecondNote = q.SecondNote,
                                            Date2 = q.NoteDate2,
                                            Rep2 = q.NoteRep2
                                        };

                            populateGrid(list3.ToList());
                            break;

                        case "TOTAL AMOUNT":
                            decimal amountDecimal;
                            string searchTxt = txtSearchText.Text.Replace(",", ".");
                            if (Decimal.TryParse(searchTxt, out amountDecimal))
                            {
                                int amount = Decimal.ToInt32(amountDecimal);
                                var list4 = from q in IME.Quotations
                                            join c in IME.Customers on q.CustomerID equals c.ID
                                            where (amount <= q.GrossTotal && q.GrossTotal < (amount + 1)
                                            && q.StartDate >= dtpFromDate.Value && q.StartDate < dtpToDate.Value)
                                            select new
                                            {
                                                Date = q.StartDate,
                                                QuotationNo = q.QuotationNo,
                                                Rep_Name = q.Worker.NameLastName,
                                                PreparedBy = currentUser.NameLastName.ToString(),
                                                RFQ = q.RFQNo,
                                                CustomerCode = c.ID,
                                                CustomerName = c.c_name,
                                                Total = q.GrossTotal,
                                                Currency = q.CurrName,
                                                OrderDate = (q.SaleOrder != null) ? q.SaleOrder.SaleDate.ToString() : "",
                                                City = c.CustomerAddresses.Where(x => x.CustomerID == c.ID).FirstOrDefault().City.City_name,
                                                SaleOrderID = q.SaleOrderID,
                                                SaleOrderNo = (q.SaleOrder != null) ? q.SaleOrder.SaleOrderNo.ToString() : "",
                                                OrderStatus = q.status,
                                                FirstNote = q.FirstNote,
                                                Date1 = q.NoteDate1,
                                                Rep1 = q.NoteRep1,
                                                SecondNote = q.SecondNote,
                                                Date2 = q.NoteDate2,
                                                Rep2 = q.NoteRep2
                                            };

                                populateGrid(list4.ToList());
                            }

                            break;

                        case "RFQ":
                            string rfq = txtSearchText.Text.ToUpperInvariant();
                            var list5 = from q in IME.Quotations
                                        join c in IME.Customers on q.CustomerID equals c.ID
                                        where (q.RFQNo.Contains(rfq)
                                        && q.StartDate >= dtpFromDate.Value && q.StartDate < dtpToDate.Value)
                                        select new
                                        {
                                            Date = q.StartDate,
                                            QuotationNo = q.QuotationNo,
                                            Rep_Name = q.Worker.NameLastName,
                                            PreparedBy = currentUser.NameLastName.ToString(),
                                            RFQ = q.RFQNo,
                                            CustomerCode = c.ID,
                                            CustomerName = c.c_name,
                                            Total = q.GrossTotal,
                                            Currency = q.CurrName,
                                            OrderDate = (q.SaleOrder != null) ? q.SaleOrder.SaleDate.ToString() : "",
                                            City = c.CustomerAddresses.Where(x => x.CustomerID == c.ID).FirstOrDefault().City.City_name,
                                            SaleOrderID = q.SaleOrderID,
                                            SaleOrderNo = (q.SaleOrder != null) ? q.SaleOrder.SaleOrderNo.ToString() : "",
                                            OrderStatus = q.status,
                                            FirstNote = q.FirstNote,
                                            Date1 = q.NoteDate1,
                                            Rep1 = q.NoteRep1,
                                            SecondNote = q.SecondNote,
                                            Date2 = q.NoteDate2,
                                            Rep2 = q.NoteRep2
                                        };
                            populateGrid(list5.ToList());
                            break;
                        case "MPN":
                            string mpn = txtSearchText.Text.ToUpperInvariant();
                            var list6 = (from q in IME.Quotations.Join(IME.QuotationDetails.Where(qd=>qd.MPN.Contains(mpn)), q=>q.QuotationNo, qd=>qd.QuotationNo, (q,qd) => q).Distinct()
                                        join c in IME.Customers on q.CustomerID equals c.ID
                                        where (q.StartDate >= dtpFromDate.Value && q.StartDate < dtpToDate.Value)
                                        select new
                                        {
                                            Date = q.StartDate,
                                            QuotationNo = q.QuotationNo,
                                            Rep_Name = q.Worker.NameLastName,
                                            PreparedBy = currentUser.NameLastName.ToString(),
                                            RFQ = q.RFQNo,
                                            CustomerCode = c.ID,
                                            CustomerName = c.c_name,
                                            Total = q.GrossTotal,
                                            Currency = q.CurrName,
                                            OrderDate = (q.SaleOrder != null) ? q.SaleOrder.SaleDate.ToString() : "",
                                            City = c.CustomerAddresses.Where(x => x.CustomerID == c.ID).FirstOrDefault().City.City_name,
                                            SaleOrderID = q.SaleOrderID,
                                            SaleOrderNo = (q.SaleOrder != null) ? q.SaleOrder.SaleOrderNo.ToString() : "",
                                            OrderStatus = q.status,
                                            FirstNote = q.FirstNote,
                                            Date1 = q.NoteDate1,
                                            Rep1 = q.NoteRep1,
                                            SecondNote = q.SecondNote,
                                            Date2 = q.NoteDate2,
                                            Rep2 = q.NoteRep2
                                        });
                            populateGrid(list6.ToList());
                            break;
                        case "SALE ORDER NO":
                            string SoNO = txtSearchText.Text.ToUpperInvariant();
                            var list7 = from q in IME.Quotations
                                        join c in IME.Customers on q.CustomerID equals c.ID
                                        where q.SaleOrder.SaleOrderNo.ToString().Contains(SoNO) &&
                                            (q.StartDate >= dtpFromDate.Value && q.StartDate < dtpToDate.Value)
                                        select new
                                        {
                                            Date = q.StartDate,
                                            QuotationNo = q.QuotationNo,
                                            Rep_Name = q.Worker.NameLastName,
                                            PreparedBy = currentUser.NameLastName.ToString(),
                                            RFQ = q.RFQNo,
                                            CustomerCode = c.ID,
                                            CustomerName = c.c_name,
                                            Total = q.GrossTotal,
                                            Currency = q.CurrName,
                                            OrderDate = (q.SaleOrder != null) ? q.SaleOrder.SaleDate.ToString() : "",
                                            City = c.CustomerAddresses.Where(x => x.CustomerID == c.ID).FirstOrDefault().City.City_name,
                                            SaleOrderID = q.SaleOrderID,
                                            SaleOrderNo = (q.SaleOrder != null) ? q.SaleOrder.SaleOrderNo.ToString() : "",
                                            OrderStatus = q.status,
                                            FirstNote = q.FirstNote,
                                            Date1 = q.NoteDate1,
                                            Rep1 = q.NoteRep1,
                                            SecondNote = q.SecondNote,
                                            Date2 = q.NoteDate2,
                                            Rep2 = q.NoteRep2
                                        };
                            populateGrid(list7.ToList());
                            break;
                        case "PURCHASE ORDER NO":
                            string PoNO = txtSearchText.Text.ToUpperInvariant();
                            var list8 = from q in IME.Quotations
                                        join c in IME.Customers on q.CustomerID equals c.ID
                                        where q.SaleOrder.PurchaseOrder.PurchaseNo.ToString().Contains(PoNO) &&
                                            (q.StartDate >= dtpFromDate.Value && q.StartDate < dtpToDate.Value)
                                        select new
                                        {
                                            Date = q.StartDate,
                                            QuotationNo = q.QuotationNo,
                                            Rep_Name = q.Worker.NameLastName,
                                            PreparedBy = currentUser.NameLastName.ToString(),
                                            RFQ = q.RFQNo,
                                            CustomerCode = c.ID,
                                            CustomerName = c.c_name,
                                            Total = q.GrossTotal,
                                            Currency = q.CurrName,
                                            OrderDate = (q.SaleOrder != null) ? q.SaleOrder.SaleDate.ToString() : "",
                                            City = c.CustomerAddresses.Where(x => x.CustomerID == c.ID).FirstOrDefault().City.City_name,
                                            SaleOrderID = q.SaleOrderID,
                                            SaleOrderNo = (q.SaleOrder != null) ? q.SaleOrder.SaleOrderNo.ToString() : "",
                                            OrderStatus = q.status,
                                            FirstNote = q.FirstNote,
                                            Date1 = q.NoteDate1,
                                            Rep1 = q.NoteRep1,
                                            SecondNote = q.SecondNote,
                                            Date2 = q.NoteDate2,
                                            Rep2 = q.NoteRep2
                                        };
                            populateGrid(list8.ToList());
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void CreateRevision()
        {
            if (dgQuotation.CurrentRow != null)
            {
                string QuotationNo = dgQuotation.CurrentRow.Cells["QuotationNo"].Value.ToString();
                Quotation quo;

                IMEEntities IME = new IMEEntities();
                try
                {
                    quo = IME.Quotations.Where(q => q.QuotationNo == QuotationNo).FirstOrDefault();
                    if (quo != null)
                    {
                        FormQuotationAdd newForm = new FormQuotationAdd(quo, this, "Create New Version");
                        Utils.LogKayit("Quotation", "Quotation new version screen has been entered");
                        newForm.ShowDialog();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("An error was encountered", "Error!");
                    //throw;
                }

            }
            else
            {
                MessageBox.Show("You did not chose any quotation.", "Warning!");
            }
        }

        public void BringQuotationList()
        {
            IMEEntities IME = new IMEEntities();
            BringQuotationList(dateNow.AddMonths(-1), dateNow.AddDays(1));
        }

        private void BringQuotationList(DateTime fromDate, DateTime toDate)
        {
            dgQuotation.Rows.Clear();
            dgQuotation.Refresh();

            IMEEntities IME = new IMEEntities();
            var list = (from q in IME.Quotations
                        join c in IME.Customers on q.CustomerID equals c.ID
                        where q.StartDate >= fromDate && q.StartDate < toDate
                        select new
                        {
                            Date = q.StartDate,
                            QuotationNo = q.QuotationNo,
                            Rep_Name = q.Worker.NameLastName,
                            PreparedBy = currentUser.NameLastName.ToString(),
                            RFQ = q.RFQNo,
                            CustomerCode = c.ID,
                            CustomerName = c.c_name,
                            Total = q.GrossTotal,
                            Currency = q.Currency.currencySymbol,
                            OrderDate = (q.SaleOrder != null) ? q.SaleOrder.SaleDate.ToString() : "",
                            City = c.CustomerAddresses.Where(x => x.CustomerID == c.ID).FirstOrDefault().City.City_name,
                            SaleOrderNo = (q.SaleOrder != null) ? q.SaleOrder.SaleOrderNo.ToString() : "",
                            SaleOrderID = q.SaleOrderID,
                            OrderStatus = q.status,
                            FirstNote = q.FirstNote,
                            Date1 = q.NoteDate1,
                            Rep1 = q.NoteRep1,
                            SecondNote = q.SecondNote,
                            Date2 = q.NoteDate2,
                            Rep2 = q.NoteRep2
                        }).OrderByDescending(x => x.Date);

            populateGrid(list.ToList());


        }

        public Int32 ConvertInt(String id)
        {
            Int32 locID = Convert.ToInt32(id);
            return locID;
        }

        private void populateGrid<T>(List<T> queryable)
        {

            dgQuotation.Rows.Clear();
            dgQuotation.Refresh();

            foreach (dynamic item in queryable)
            {
                int rowIndex = dgQuotation.Rows.Add();
                DataGridViewRow row = dgQuotation.Rows[rowIndex];


                row.Cells[Date.Index].Value = item.Date;
                row.Cells[QuotationNo.Index].Value = item.QuotationNo;
                row.Cells[Rep_Name.Index].Value = item.Rep_Name;
                row.Cells[PreparedBy.Index].Value = item.PreparedBy;
                row.Cells[RFQ.Index].Value = item.RFQ;
                row.Cells[CustomerCode.Index].Value = item.CustomerCode;
                row.Cells[CustomerName.Index].Value = item.CustomerName;
                row.Cells[Total.Index].Value = item.Total;
                row.Cells[Currency.Index].Value = item.Currency;
                row.Cells[OrderDate.Index].Value = item.OrderDate;
                row.Cells[City.Index].Value = item.City;
                row.Cells[SaleOrderNo.Index].Value = item.SaleOrderNo;
                row.Cells[OrderStatus.Index].Value = item.OrderStatus;
                row.Cells[FirstNote.Index].Value = item.FirstNote;
                row.Cells[Date1.Index].Value = item.Date1;
                row.Cells[Rep1.Index].Value = item.Rep1;
                row.Cells[SecondNote.Index].Value = item.SecondNote;
                row.Cells[Date2.Index].Value = item.Date2;
                row.Cells[Rep2.Index].Value = item.Rep2;
                row.Cells[SaleOrderID.Index].Value = item.SaleOrderID;
                row.Cells[QuoID.Index].Value = item.QuotationNo.Substring(item.QuotationNo.LastIndexOf('/') + 1).ToString();

            }

            foreach (DataGridViewRow row in dgQuotation.Rows)
            {

                if (row.Cells[OrderStatus.Index].Value != null)
                {

                    if (row.Cells[OrderStatus.Index].Value.ToString() == "Ordered")
                    {
                        row.Cells[OrderStatus.Index].Style.BackColor = Color.FromArgb(140, 255, 195);
                    }
                    else if (row.Cells[OrderStatus.Index].Value.ToString() == "Not Ordered")
                    {
                        row.Cells[OrderStatus.Index].Style.BackColor = Color.FromArgb(255, 190, 130);
                    }
                    else if (row.Cells[OrderStatus.Index].Value.ToString() == "Deleted")
                    {
                        row.Cells[OrderStatus.Index].Style.BackColor = ImeSettings.GridDeletedRowColor;
                    }
                }
            }

        }

        private void dgQuotation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (!Utils.AuthorityCheck(IMEAuthority.DeleteQuotation))//Can Delete Quotation
                {
                    btnDeleteQuotation.PerformClick();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            QuotationExcelExport.QuotationMainExport(dgQuotation, dtpFromDate.Value, dtpToDate.Value);
            Utils.LogKayit("Quotation", "Quotation excel");
            //List<string> QuotationItemList = new List<string>();
            //for (int i = 0; i < dgQuotation.ColumnCount; i++)
            //{
            //    QuotationItemList.Add(dgQuotation.Columns[i].HeaderText);
            //}
            //frmQuotationExport form = new frmQuotationExport(QuotationItemList, dgQuotation.CurrentRow.Cells["QuotationNo"].Value.ToString(), dgQuotation);
            //form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ExperimentQuotationAdd form = new ExperimentQuotationAdd();
            form.Show();
        }


        private string FixItemCode(string _itemCode)
        {
            string result = _itemCode.Replace("-", "");

            if (Int32.TryParse(result, out int x) && result.Length == 6)
            {
                result = "0" + result;
            }
            return result;
        }

        private void txtStockCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchStockNumber.PerformClick();
            }
        }

        private void btnSearchStockNumber_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtStockCode.Text))
            {
                IMEEntities db = new IMEEntities();

                string stockCode = txtStockCode.Text.ToUpperInvariant();

                if (!chcCustStockNumber.Checked)
                {
                    stockCode = FixItemCode(stockCode);
                    var list = from q in db.Quotations
                               join qd in db.QuotationDetails on q.QuotationNo equals qd.QuotationNo
                               join c in db.Customers on q.CustomerID equals c.ID
                               where qd.ItemCode.Contains(stockCode)
                               select new
                               {
                                   Date = q.StartDate,
                                   QuotationNo = q.QuotationNo,
                                   Rep_Name = q.Worker.NameLastName,
                                   PreparedBy = currentUser.NameLastName.ToString(),
                                   RFQ = q.RFQNo,
                                   CustomerCode = c.ID,
                                   CustomerName = c.c_name,
                                   Total = q.GrossTotal,
                                   Currency = q.CurrName,
                                   OrderDate = (q.SaleOrder != null) ? q.SaleOrder.SaleDate.ToString() : "",
                                   City = c.CustomerAddresses.Where(x => x.CustomerID == c.ID).FirstOrDefault().City.City_name,
                                   SaleOrderNo = q.SaleOrderID,
                                   OrderStatus = q.status,
                                   FirstNote = q.FirstNote,
                                   Date1 = q.NoteDate1,
                                   Rep1 = q.NoteRep1,
                                   SecondNote = q.SecondNote,
                                   Date2 = q.NoteDate2,
                                   Rep2 = q.NoteRep2
                               };
                                   populateGrid(list.ToList());
                }
                else
                {
                    var list2 = from q in db.Quotations
                                join qd in db.QuotationDetails on q.QuotationNo equals qd.QuotationNo
                                join c in db.Customers on q.CustomerID equals c.ID
                                where qd.CustomerStockCode.Contains(stockCode)
                                select new
                                {
                                    Date = q.StartDate,
                                    QuotationNo = q.QuotationNo,
                                    Rep_Name = q.Worker.NameLastName,
                                    PreparedBy = currentUser.NameLastName.ToString(),
                                    RFQ = q.RFQNo,
                                    CustomerCode = c.ID,
                                    CustomerName = c.c_name,
                                    Total = q.GrossTotal,
                                    Currency = q.CurrName,
                                    OrderDate = (q.SaleOrder != null) ? q.SaleOrder.SaleDate.ToString() : "",
                                    City = c.CustomerAddresses.Where(x => x.CustomerID == c.ID).FirstOrDefault().City.City_name,
                                    SaleOrderNo = q.SaleOrderID,
                                    OrderStatus = q.status,
                                    FirstNote = q.FirstNote,
                                    Date1 = q.NoteDate1,
                                    Rep1 = q.NoteRep1,
                                    SecondNote = q.SecondNote,
                                    Date2 = q.NoteDate2,
                                    Rep2 = q.NoteRep2
                                };

                    populateGrid(list2.ToList());
                }
            }
            else
            {
                MessageBox.Show("You should enter a stock code", "Attention!");
                btnRefreshList.PerformClick();
            }
        }

        private void mODIFYQUOTATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateRevision();
        }

        private void dELETEQUOTATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dgQuotation.CurrentRow != null)
            {
                if (dgQuotation.CurrentRow.Cells[SaleOrderNo.Index].Value == null || dgQuotation.CurrentRow.Cells[SaleOrderNo.Index].Value.ToString() == "")
                {
                    DialogResult result = MessageBox.Show("Selected quotation(s) will be deleted! Do you confirm?", "Delete Quotation", MessageBoxButtons.OKCancel);

                    if (result == DialogResult.OK)
                    {
                        try
                        {
                            IMEEntities IME = new IMEEntities();

                            foreach (DataGridViewRow row in dgQuotation.SelectedRows)
                            {
                                string QuotationNo = row.Cells["QuotationNo"].Value.ToString();

                                Quotation quo = IME.Quotations.Where(q => q.QuotationNo == QuotationNo).FirstOrDefault();

                                quo.status = "Deleted";

                                IME.SaveChanges();
                            }

                            IME.SaveChanges();

                            BringQuotationList();

                            MessageBox.Show("Quotation is successfully deleted.", "Success!");
                            Utils.LogKayit("Quotation", "Quotation deleted");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("An error was encountered", "Error!");
                            throw;
                        }
                    }
                    else
                    {
                        MessageBox.Show("You did not chose any quotation.", "Warning!");
                    }
                }
                else
                {
                    MessageBox.Show("You can not delete, order exist !", "Warning!");
                }
            }
        }
        private void qUOTATIONINFOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgQuotation.CurrentRow != null)
            {
                string QuotationNo = dgQuotation.CurrentRow.Cells["QuotationNo"].Value.ToString();
                Quotation quo;

                IMEEntities IME = new IMEEntities();
                try
                {
                    quo = IME.Quotations.Where(q => q.QuotationNo == QuotationNo).FirstOrDefault();
                }
                catch (Exception)
                {

                    throw;
                }
                if (quo != null)
                {
                    FormQuotationAdd newForm = new FormQuotationAdd(quo, "View");
                    Utils.LogKayit("Quotation", "Quotation info screen has been entered");
                    newForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("You did not chose any quotation.", "Warning!");
            }
        }

        private void dgQuotation_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string note1 =  "";
            string note2 = "";
            if (dgQuotation.CurrentRow.Cells[FirstNote.Index].Value != null && dgQuotation.CurrentRow.Cells["FirstNote"].Value.ToString() != "")
            {
                note1 = dgQuotation.CurrentRow.Cells[FirstNote.Index].Value.ToString();
            }
            if (dgQuotation.CurrentRow.Cells[SecondNote.Index].Value != null && dgQuotation.CurrentRow.Cells["SecondNote"].Value.ToString() != "")
            {
                note2= dgQuotation.CurrentRow.Cells[SecondNote.Index].Value.ToString();
            }

            switch (dgQuotation.CurrentCell.ColumnIndex)
            {
                case 14:
                    if (dgQuotation.CurrentRow != null)
                    {
                        DialogResult result = MessageBox.Show("Note is added, please confirm", "Quotation Note", MessageBoxButtons.OKCancel);

                        if (result == DialogResult.OK)
                        {
                            try
                            {
                                IMEEntities IME = new IMEEntities();

                                foreach (DataGridViewRow row in dgQuotation.SelectedRows)
                                {
                                    string QuotationNo = row.Cells["QuotationNo"].Value.ToString();

                                    Quotation quo = IME.Quotations.Where(q => q.QuotationNo == QuotationNo).FirstOrDefault();

                                    quo.FirstNote = note1;
                                    quo.NoteDate1 = Utils.GetCurrentDateTime();
                                    quo.NoteRep1 = currentUser.NameLastName.ToString();

                                    IME.SaveChanges();
                                }

                                IME.SaveChanges();

                                BringQuotationList();
                            }
                            catch (Exception)
                            {
                                dgQuotation.CurrentRow.Cells[FirstNote.Index].Value = "";
                                MessageBox.Show("Please press the enter key!", "Error!");
                            }
                        }
                    }

                    break;
                case 17:
                    if (dgQuotation.CurrentRow != null)
                    {
                        DialogResult result = MessageBox.Show("Note is added, please confirm", "Quotation Note", MessageBoxButtons.OKCancel);

                        if (result == DialogResult.OK)
                        {
                            try
                            {
                                IMEEntities IME = new IMEEntities();

                                foreach (DataGridViewRow row in dgQuotation.SelectedRows)
                                {
                                    string QuotationNo = row.Cells["QuotationNo"].Value.ToString();

                                    Quotation quo = IME.Quotations.Where(q => q.QuotationNo == QuotationNo).FirstOrDefault();

                                    quo.SecondNote = note2;
                                    quo.NoteDate2 = Utils.GetCurrentDateTime();
                                    quo.NoteRep2 = currentUser.NameLastName.ToString();

                                    IME.SaveChanges();
                                }

                                IME.SaveChanges();

                                BringQuotationList();
                            }
                            catch (Exception)
                            {
                                dgQuotation.CurrentRow.Cells[SecondNote.Index].Value = "";
                                MessageBox.Show("Please press the enter key! ", "Error!");
                            }
                        }
                    }

                    break;
            }
        }

        private void qUOTATIONPRINTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgQuotation.CurrentRow != null)
            {
                string QuotationNo = dgQuotation.CurrentRow.Cells["QuotationNo"].Value.ToString();
                Quotation quo;

                IMEEntities IME = new IMEEntities();
                try
                {
                    quo = IME.Quotations.Where(q => q.QuotationNo == QuotationNo).FirstOrDefault();
                }
                catch (Exception)
                {

                    throw;
                }
                if (quo != null)
                {
                    List<QuotationDetail> list = IME.QuotationDetails.Where(x => x.QuotationNo == QuotationNo).ToList();

                    //FormQuotationPrint form = new FormQuotationPrint();
                    //form.Print(quo, list);
                    //form.ShowDialog();

                    frmPrintOptions frm = new frmPrintOptions(quo, list);
                    frm.ShowDialog();

                    //form.Close();
                    //QuotationExcelExport.QuotationMainPrintExport(quo);
                    Utils.LogKayit("Quotation", "Quotation print");
                }
            }
            else
            {
                MessageBox.Show("You did not chose any quotation.", "Warning!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgQuotation.CurrentRow != null)
            {
                string QuotationNo = dgQuotation.CurrentRow.Cells["QuotationNo"].Value.ToString();
                Quotation quo;

                IMEEntities IME = new IMEEntities();
                try
                {
                    quo = IME.Quotations.Where(q => q.QuotationNo == QuotationNo).FirstOrDefault();
                }
                catch (Exception)
                {

                    throw;
                }

                if (quo.ViewQuotation != false)
                {
                    quo.ViewQuotation = false;
                    quo.ViewQuotationName = Utils.getCurrentUser().UserName;
                    IME.SaveChanges();

                    if (quo != null && quo.SaleOrder == null)
                    {
                        FormQuotationAdd newForm = new FormQuotationAdd(quo, this, "Update");
                        Utils.LogKayit("Quotation", "Quotation update screen has been entered");
                        newForm.Show();
                    }
                    else
                    {

                        DialogResult result = MessageBox.Show("Quotation is locked to Sales Order Number:" + quo.SaleOrder.SaleOrderNo, "Warning", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            DialogResult result2 = MessageBox.Show("Do you want to create revision", "Informaion", MessageBoxButtons.YesNo);
                            if (result2 == DialogResult.Yes)
                            {
                                CreateRevision();
                            }
                        }
                    }
                }
                else
                {
                    DialogResult result2 = MessageBox.Show(quo.ViewQuotationName + " is working on this Quotation", "Informaion", MessageBoxButtons.YesNo);
                    if (result2 == DialogResult.Yes)
                    {
                        ViewQuotation();
                    }
                }
            }
            else
            {
                MessageBox.Show("You did not chose any quotation.", "Warning!");
            }
        }

        private void uPDATEQUOTATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgQuotation.CurrentRow != null)
            {
                string QuotationNo = dgQuotation.CurrentRow.Cells["QuotationNo"].Value.ToString();
                Quotation quo;

                IMEEntities IME = new IMEEntities();
                try
                {
                    quo = IME.Quotations.Where(q => q.QuotationNo == QuotationNo).FirstOrDefault();
                }
                catch (Exception)
                {

                    throw;
                }

                if (quo.ViewQuotation != false)
                {
                    quo.ViewQuotation = false;
                    quo.ViewQuotationName = Utils.getCurrentUser().UserName;
                    IME.SaveChanges();

                    if (quo != null && quo.SaleOrder == null)
                    {
                        FormQuotationAdd newForm = new FormQuotationAdd(quo, this, "Update");
                        Utils.LogKayit("Quotation", "Quotation modify screen has been entered");
                        newForm.ShowDialog();
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Quotation is locked to Sales Order Number:" + quo.SaleOrder.SaleOrderNo, "Warning", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            DialogResult result2 = MessageBox.Show("Create Revision ?", "Informaion", MessageBoxButtons.OKCancel);
                            if (result2 == DialogResult.OK)
                            {
                                CreateRevision();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show(quo.ViewQuotationName + "is working on this Quotation");
                }
            }
            else
            {
                MessageBox.Show("You did not chose any quotation.", "Warning!");
            }
        }

        private void uNDODELETEQUOTATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgQuotation.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Selected quotation(s) undo deleted! Do you confirm?", "Undo Delete Quotation", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    try
                    {
                        IMEEntities IME = new IMEEntities();

                        foreach (DataGridViewRow row in dgQuotation.SelectedRows)
                        {
                            string QuotationNo = row.Cells["QuotationNo"].Value.ToString();

                            Quotation quo = IME.Quotations.Where(q => q.QuotationNo == QuotationNo).FirstOrDefault();

                            quo.status = "Not Ordered";

                            IME.SaveChanges();
                        }

                        IME.SaveChanges();

                        BringQuotationList();

                        MessageBox.Show("Quotation is successfully undo deleted.", "Success!");
                        Utils.LogKayit("Quotation", "Quotation undo deleted");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("An error was encountered", "Error!");
                        throw;
                    }
                }
            }
            else
            {
                MessageBox.Show("You did not chose any quotation.", "Warning!");
            }
        }

        private void dgQuotation_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (dgQuotation.CurrentRow.Cells[OrderStatus.Index].Value.ToString() != "Deleted")
                {
                    dELETEQUOTATIONToolStripMenuItem.Visible = true;
                    uNDODELETEQUOTATIONToolStripMenuItem.Visible = false;
                }
                else
                {
                    dELETEQUOTATIONToolStripMenuItem.Visible = false;
                    uNDODELETEQUOTATIONToolStripMenuItem.Visible = true;
                }
            }
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            //printDocument1.Print();
            //Utils.LogKayit("Quotation", "Quotation print");

            if (dgQuotation.CurrentRow != null)
            {
                string QuotationNo = dgQuotation.CurrentRow.Cells["QuotationNo"].Value.ToString();
                Quotation quo;

                IMEEntities IME = new IMEEntities();
                try
                {
                    quo = IME.Quotations.Where(q => q.QuotationNo == QuotationNo).FirstOrDefault();
                }
                catch (Exception)
                {

                    throw;
                }
                if (quo != null)
                {
                    List<QuotationDetail> list = IME.QuotationDetails.Where(x => x.QuotationNo == QuotationNo).ToList();

                    frmPrintOptions frm = new frmPrintOptions(quo, list);
                    frm.ShowDialog();
                    
                    //FormQuotationPrint form = new FormQuotationPrint();
                    //form.Print(quo, list);
                    //form.ShowDialog();
                    //form.Close();
                    //QuotationExcelExport.QuotationMainPrintExport(quo);
                    Utils.LogKayit("Quotation", "Quotation print");
                }
            }
            else
            {
                MessageBox.Show("You did not chose any quotation.", "Warning!");
            }
        }

        private void dISCONTINUEDUSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.LogKayit("Quotation", "Quotation discontinuned user");
        }

        private void cOPYQUOTATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgQuotation.CurrentRow != null)
            {
                string QuotationNo = dgQuotation.CurrentRow.Cells["QuotationNo"].Value.ToString();
                Quotation quo;

                IMEEntities IME = new IMEEntities();
                try
                {
                    quo = IME.Quotations.Where(q => q.QuotationNo == QuotationNo).FirstOrDefault();
                    if (quo != null)
                    {
                        FormQuotationAdd newForm = new FormQuotationAdd(quo, this, "Copy");
                        Utils.LogKayit("Quotation", "Quotation copy quotation");
                        newForm.ShowDialog();
                    }
                }
                catch { }

            }
            else
            {
                MessageBox.Show("You did not chose any quotation.", "Warning!");
            }
        }

        private void cREATESALEORDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgQuotation.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection SelectedRows = dgQuotation.SelectedRows;
                List<QuotationDetail> list = new List<QuotationDetail>();
                string quotNo = dgQuotation.CurrentRow.Cells[QuotationNo.Index].Value.ToString();
                bool AllSameCustomer = true;
                bool AllSameCurrency = true;
                string _customerCode = String.Empty;
                string _currency = String.Empty;
                foreach (DataGridViewRow row in SelectedRows)
                {
                    string customerCode = row.Cells[CustomerCode.Index].Value.ToString();
                    string currencyName = row.Cells[Currency.Index].Value.ToString();
                    #region Farklı Customer
                    if (_customerCode == String.Empty)
                    {
                        AllSameCustomer = true;
                        _customerCode = customerCode;
                    }
                    else if(customerCode != _customerCode)
                    {
                        AllSameCustomer = false;
                        MessageBox.Show("You can only choose the same customer's quotations!","Warning");
                        break;
                    }
                    else
                    {
                        AllSameCustomer = true;
                    }
                    #endregion

                    #region Farklı Currency
                    if (_currency == String.Empty)
                    {
                        AllSameCurrency = true;
                        _currency = currencyName;
                    }
                    else if (currencyName != _currency)
                    {
                        AllSameCurrency = false;
                        MessageBox.Show("Quotations have different currencies", "Warning");
                        break;
                    }
                    else
                    {
                        AllSameCurrency = true;
                    }
                    #endregion
                }

                if (AllSameCustomer && AllSameCurrency)
                {
                    bool OnlyPendingQuotations = true;

                    foreach (DataGridViewRow row in SelectedRows)
                    {
                        if (row.Cells[OrderStatus.Index].Value.ToString() != "Not Ordered")
                        {
                            OnlyPendingQuotations = false;
                            MessageBox.Show("You can only choose the pending quotations!", "Warning");
                            break;
                        }
                    }

                    if (OnlyPendingQuotations)
                    {
                        IMEEntities IME = new IMEEntities();
                        foreach (DataGridViewRow row in SelectedRows)
                        {
                            
                            List<QuotationDetail> detailList = IME.Quotations.Where(x => x.QuotationNo == quotNo).First().QuotationDetails.ToList();
                            list.AddRange(detailList);
                        }

                        List<string> quotationNos = new List<string>();
                        for (int i = 0; i < SelectedRows.Count; i++)
                        {
                            if (quotationNos.Where(x => x == SelectedRows[i].Cells[QuotationNo.Index].ToString()).FirstOrDefault() == null)
                            {
                                quotationNos.Add(list[i].QuotationNo);
                            }
                        }
                        string quotationIDs = String.Empty;
                        for (int i = 0; i < quotationNos.Count; i++)
                        {
                            quotationIDs += quotationNos[i].ToString();
                            if (i != quotationNos.Count - 1)
                            {
                                quotationIDs += ",";
                            }
                        }

                        string CustCode = SelectedRows[0].Cells[CustomerCode.Index].Value.ToString();
                        Customer customer = IME.Customers.Where(x => x.ID == CustCode).FirstOrDefault();
                        Quotation quo = IME.Quotations.Where(x => x.QuotationNo == quotNo).FirstOrDefault();

                        //XtraFormSaleOrder form = new XtraFormSaleOrder(so, this, "Quotation");
                        FormSaleOrderAdd form = new FormSaleOrderAdd(customer, list, quotationIDs, 1,quo);
                        Utils.LogKayit("Sale Order", "Sale Order add screen has been entered");
                        form.Show();
                        this.Close();

                    }
                }
                
            }
            else
            {
                MessageBox.Show("At least one quotation should be choosen!","Warning");
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dgQuotation.Width, this.dgQuotation.Height);
            dgQuotation.DrawToBitmap(bm, new Rectangle(0, 0, this.dgQuotation.Width, this.dgQuotation.Height));
            e.Graphics.DrawImage(bm,10,10);
        }

        private void dubaiQouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgQuotation.CurrentRow != null)
            {
                string QuotationNo = dgQuotation.CurrentRow.Cells["QuotationNo"].Value.ToString();
                Quotation quo;
                Customer c;
                IMEEntities IME = new IMEEntities();
                try
                {
                    quo = IME.Quotations.Where(q => q.QuotationNo == QuotationNo).FirstOrDefault();
                    c = IME.Customers.Where(q => q.ID == quo.CustomerID).FirstOrDefault();
                }
                catch (Exception)
                {

                    throw;
                }
                if (quo != null)
                {
                    FormQuotationAdd_Dubai newForm = new FormQuotationAdd_Dubai("View", quo, c);
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
