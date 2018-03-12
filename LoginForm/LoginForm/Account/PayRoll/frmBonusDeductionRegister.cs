﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using LoginForm.DataSet;
using LoginForm.Services;
using LoginForm.Account.Services;

namespace LoginForm


{
   
    public partial class frmBonusDeductionRegister : Form
    {
        #region Public Variables
        IMEEntities IME = new IMEEntities();
        int inCurrentRowIndex = 0;
        //frmEmployeePopup frmEmployeeObj;
       
        #endregion

        #region Function
        /// <summary>
        /// Creates an instance of frmBonusDeductionRegister class
        /// </summary>
        public frmBonusDeductionRegister()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to fill EmployeeName combobox
        /// </summary>
        public void EmployeeNameComboFill()
        {
            try
            {
                DataTable dtblEmployeeName = new DataTable();
                EmployeeSP spEmployee = new EmployeeSP();
                dtblEmployeeName = spEmployee.EmployeeViewAll();
                DataRow dr = dtblEmployeeName.NewRow();
                dr[2] = "All";
                dtblEmployeeName.Rows.InsertAt(dr, 0);
                cmbEmployeeName.DataSource = dtblEmployeeName;
                cmbEmployeeName.ValueMember = "employeeId";
                cmbEmployeeName.DisplayMember = "employeeName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("BDR1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to reset the form
        /// </summary>
        public void Clear()
        {
            try
            {
                cmbEmployeeName.SelectedIndex = 0;
                dtpMonth.Value = (DateTime)IME.CurrentDate().First();
                dtpMonth.MinDate =  (DateTime)IME.FinancialYears.Where(a => a.fromDate <= Convert.ToDateTime(IME.CurrentDate().First())).Where(b => b.toDate >= Convert.ToDateTime(IME.CurrentDate().First())).FirstOrDefault().fromDate; 
                dtpMonth.MaxDate = (DateTime)IME.FinancialYears.Where(a => a.fromDate <= Convert.ToDateTime(IME.CurrentDate().First())).Where(b => b.toDate >= Convert.ToDateTime(IME.CurrentDate().First())).FirstOrDefault().toDate;
                GridFill();
                cmbEmployeeName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("BDR2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Datagridview
        /// </summary>
        public void GridFill()
        {
            try
            {
                DataTable dtblBonusDeduction = new DataTable();
                BonusDedutionSP spBonusDeduction = new BonusDedutionSP();
                dtblBonusDeduction = spBonusDeduction.BonusDeductionSearch(cmbEmployeeName.Text, Convert.ToDateTime(dtpMonth.Text.ToString()));
                dgvBonusDeduction.DataSource = dtblBonusDeduction;
            }
            catch (Exception ex)
            {
                MessageBox.Show("BDR3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to Select the row in Datagridview
        /// </summary>
        public void GridSelection()
        {
            try
            {
                if (inCurrentRowIndex >= 0 && dgvBonusDeduction.Rows.Count > 0 && inCurrentRowIndex < dgvBonusDeduction.Rows.Count)
                {
                    dgvBonusDeduction.CurrentCell = dgvBonusDeduction.Rows[inCurrentRowIndex].Cells[0];
                    dgvBonusDeduction.CurrentCell.Selected = true;
                }
                else
                {
                    inCurrentRowIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BDR4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call frmEmployeePopup form to select and view Employee
        /// </summary>
        /// <param name="frmEmployee"></param>
        /// <param name="decId"></param>
        //public void CallFromEmployee(frmEmployeePopup frmEmployee, decimal decId) //POP UP
        //{
        //    try
        //    {
        //        base.Show();
        //        this.frmEmployeeObj = frmEmployee;
        //        EmployeeNameComboFill();
        //        cmbEmployeeName.SelectedValue = decId;
        //        cmbEmployeeName.Focus();
        //        frmEmployeeObj.Close();
        //        frmEmployeeObj = null;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("BDR5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

        #endregion

        #region Events
        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBonusDeductionRegister_Load(object sender, EventArgs e)
        {
            try
            {
                EmployeeNameComboFill();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("BDR6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Clear' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("BDR7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Clears selection on databinding
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvBonusDeduction_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                dgvBonusDeduction.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("BDR8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call frmBonusDeduction form on cell doubleclick for updation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvBonusDeduction_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    if (e.RowIndex != -1)
            //    {
            //        if (dgvBonusDeduction.CurrentRow.Index == e.RowIndex)
            //        {
            //            frmBonusDeduction frmBonusDeductionObj = new frmBonusDeduction();
            //            frmBonusDeduction open = Application.OpenForms["frmBonusDeduction"] as frmBonusDeduction;
            //            if (open == null)
            //            {
            //                frmBonusDeductionObj.WindowState = FormWindowState.Normal;
            //                frmBonusDeductionObj.MdiParent = formMDI.MDIObj;
            //                frmBonusDeductionObj.CallFromBonusDeductionRegister(Convert.ToDecimal(dgvBonusDeduction.Rows[e.RowIndex].Cells["dgvtxtBonusDeductionId"].Value.ToString()), this);
            //            }
            //            else
            //            {
                         
            //                open.BringToFront();
            //                open.CallFromBonusDeductionRegister(Convert.ToDecimal(dgvBonusDeduction.Rows[e.RowIndex].Cells["dgvtxtBonusDeductionId"].Value.ToString()), this);
            //                if (open.WindowState == FormWindowState.Minimized)
            //                {
            //                    open.WindowState = FormWindowState.Normal;
            //                }
            //            }
            //            inCurrentRowIndex = dgvBonusDeduction.CurrentRow.Index;
            //        }
            //        this.Enabled = false;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("BDR9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }
       /// <summary>
       /// On 'Search' button click
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("BDR10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Navigation

        private void cmbEmployeeName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dtpMonth.Focus();
                }
                //if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control) //Pop Up
                //{
                    
                //    frmEmployeeObj = new frmEmployeePopup();
                //    frmEmployeeObj.MdiParent = formMDI.MDIObj;
                //    if (cmbEmployeeName.SelectedIndex > 0)
                //    {
                //        frmEmployeeObj.CallFromBonusDeductionregister(this, Convert.ToDecimal(cmbEmployeeName.SelectedValue.ToString()));
                //    }
                //    else
                //    {
                //        Messages.InformationMessage("Select employeename");
                //        cmbEmployeeName.Focus();
                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("BDR12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpMonth_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearch.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbEmployeeName.Focus();
                    cmbEmployeeName.SelectionStart = 0;
                    cmbEmployeeName.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BDR13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    dtpMonth.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BDR14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion
    }
}
