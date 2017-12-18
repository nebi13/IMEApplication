﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm.QuotationModule
{
    public partial class frmQuotationExport : Form
    {
        List<bool> ischecked = new List<bool>();
        List<CheckBox> cboxList = new List<CheckBox>();
        DataGridView datagrid;
        string QuotationNo;
        public frmQuotationExport()
        {
            InitializeComponent();
        }

        public frmQuotationExport(List<string> ColumnList, string q, DataGridView dg)
        {
            datagrid = dg;
            InitializeComponent();
            QuotationNo = q;
            CheckBox box;
            int previousLength = 0;
            int y = 10;
            for (int i = 0; i < ColumnList.Count; i++)
            {

                box = new CheckBox();
                box.Tag = i.ToString();
                box.Text = ColumnList[i];
                box.AutoSize = true;
                if (10 + previousLength >= this.Width)
                {
                    y = y + 30;
                    previousLength = 0;
                }
                box.Location = new Point(10 + previousLength, y);
                previousLength = previousLength + box.Width;
                cboxList.Add(box);
                this.Controls.Add(box);
                ischecked.Add(false);
            }
            ExportButton.Location = new Point(this.Width / 2, y + 30);
            btnSelectAll.Location = new Point(0, y + 30);
            btnClearAll.Location = new Point(btnSelectAll.Width + 5, y + 30);

        }

        private void frmQuotationExport_Load(object sender, EventArgs e)
        {

        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (var item in cboxList)
            {
                item.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in cboxList)
            {
                item.Checked = false;
            }
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cboxList.Count; i++)
            {
                ischecked[i] = cboxList[i].Checked;
            }
            QuotationExcelExport.Export(datagrid, QuotationNo, ischecked);
        }

    }
}