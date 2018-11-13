﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LoginForm.DataSet;

namespace LoginForm.QuotationModule
{
    public partial class FormQuotationPrint : DevExpress.XtraEditors.XtraForm
    {
        public FormQuotationPrint()
        {
            InitializeComponent();
        }

        public void Print(Quotation qd, List<QuotationDetail> data)
        {
            IMEEntities IME = new IMEEntities();
            ReportQuotation report = new ReportQuotation();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
            {
                p.Visible = false;
            }
            report.InitData(qd.QuotationNo, qd.Customer?.c_name, qd.MainContactName, qd.Customer?.telephone, qd.Customer?.webadress, qd.Customer?.fax, qd.RFQNo, Int32.Parse(qd.ValidationDay?.ToString()), qd.StartDate, qd.Customer?.CustomerWorker?.cw_name, qd.Customer?.CustomerWorker?.cw_email, qd.Customer?.CustomerWorker?.phone, qd.PaymentTerm?.term_name, qd.FirstNote, qd.Currency?.currencySymbol, qd.Currency?.currencyName, data);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
            //report.ExportToPdf("C:\\Users\\pomak\\Desktop\\ReportQuotation.pdf");
        }
    }
}