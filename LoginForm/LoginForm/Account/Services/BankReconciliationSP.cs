﻿using LoginForm.DataSet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LoginForm.Account.Services
{
    class BankReconciliationSP
    {
        public DataTable BankReconciliationFillReconcile(decimal decLedgerId, DateTime dtFromDate, DateTime dtToDate)
        {
            DataTable dtblBank = new DataTable();
            dtblBank.Columns.Add("Sl No", typeof(int));
            dtblBank.Columns["Sl No"].AutoIncrement = true;
            dtblBank.Columns["Sl No"].AutoIncrementSeed = 1;
            dtblBank.Columns["Sl No"].AutoIncrementStep = 1;
            dtblBank.Columns.Add("date");
            dtblBank.Columns.Add("ledgerName");
            dtblBank.Columns.Add("voucherTypeName");
            dtblBank.Columns.Add("ledgerPostingId");
            dtblBank.Columns.Add("voucherNo");
            dtblBank.Columns.Add("chequeNo");
            dtblBank.Columns.Add("chequeDate");
            dtblBank.Columns.Add("debit");
            dtblBank.Columns.Add("credit");
            dtblBank.Columns.Add("statementDate");
            IMEEntities IME = new IMEEntities();

            var result = (from lp in IME.LedgerPostings
                          join vt in IME.VoucherTypes on lp.voucherTypeId equals vt.voucherTypeId
                          join al in IME.AccountLedgers on lp.ledgerId equals al.ledgerId
                          join br in IME.BankReconciliations on lp.ledgerPostingId equals br.ledgerPostingId into a
                          from br in a.DefaultIfEmpty() //RIGHT JOIN
                          where al.AccountGroup.accountGroupName == "Bank Account"
                          where lp.ledgerId == decLedgerId
                          where br.statementDate > dtFromDate
                          where br.statementDate < dtToDate
                          select new
                          {
                              lp.date,
                              al.ledgerName,
                              vt.voucherTypeName,
                              lp.ledgerPostingId,
                              lp.voucherNo,
                              lp.chequeNo,
                              lp.chequeDate,
                              lp.debit,
                              lp.credit,
                              br.statementDate
                          }
                );

           

            foreach (var item in result)
            {
                var row = dtblBank.NewRow();

                row["date"] = item.date;
                row["ledgerName"] = item.ledgerName;
                row["voucherTypeName"] = item.voucherTypeName;
                row["ledgerPostingId"] = item.ledgerPostingId;
                row["voucherNo"] = item.voucherNo;
                row["chequeNo"] = item.chequeNo;
                row["chequeDate"] = item.chequeDate;
                row["debit"] = item.debit;
                row["credit"] = item.credit;
                row["statementDate"] = item.statementDate;
                dtblBank.Rows.Add(row);
            }

            return dtblBank;
        }


        public DataTable BankReconciliationUnrecocile(decimal decLedgerId, DateTime dtFromDate, DateTime dtToDate)
        {
            IMEEntities IME = new IMEEntities();
            DataTable dtblBank = new DataTable();
            dtblBank.Columns.Add("Sl No", typeof(int));
            dtblBank.Columns["Sl No"].AutoIncrement = true;
            dtblBank.Columns["Sl No"].AutoIncrementSeed = 1;
            dtblBank.Columns["Sl No"].AutoIncrementStep = 1;
            
            dtblBank.Columns.Add("date");
            dtblBank.Columns.Add("ledgerName");
            dtblBank.Columns.Add("voucherTypeName");
            dtblBank.Columns.Add("ledgerPostingId");
            dtblBank.Columns.Add("voucherNo");
            dtblBank.Columns.Add("chequeNo");
            dtblBank.Columns.Add("chequeDate");
            dtblBank.Columns.Add("debit");
            dtblBank.Columns.Add("credit");
            dtblBank.Columns.Add("statementDate");
            var result =IME.BankReconciliationFillUnrecon((decimal)decLedgerId, (DateTime)dtFromDate, (DateTime)dtToDate);
            foreach (var item in result)
            {
                var row = dtblBank.NewRow();

                row["date"] = item.date;
                row["ledgerName"] = item.ledgerName;
                row["voucherTypeName"] = item.voucherTypeName;
                row["ledgerPostingId"] = item.ledgerPostingId;
                row["voucherNo"] = item.voucherNo;
                row["chequeNo"] = item.chequeNo;
                row["chequeDate"] = item.chequeDate;
                row["debit"] = item.debit;
                row["credit"] = item.credit;
                dtblBank.Rows.Add(row);
            }

            return dtblBank;
        }

    }
}
