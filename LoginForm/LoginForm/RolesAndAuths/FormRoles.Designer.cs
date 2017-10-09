﻿namespace LoginForm.RolesAndAuths
{
    partial class FormRoles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddRole = new System.Windows.Forms.Button();
            this.btnAddAuth = new System.Windows.Forms.Button();
            this.cbRoleList = new System.Windows.Forms.ComboBox();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.txtAuthName = new System.Windows.Forms.TextBox();
            this.lbWorkerList = new System.Windows.Forms.ListBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnEditWorker = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAddWorker = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // btnAddRole
            // 
            this.btnAddRole.Location = new System.Drawing.Point(652, 82);
            this.btnAddRole.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(142, 29);
            this.btnAddRole.TabIndex = 0;
            this.btnAddRole.Text = "AddRole";
            this.btnAddRole.UseVisualStyleBackColor = true;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // btnAddAuth
            // 
            this.btnAddAuth.Location = new System.Drawing.Point(652, 114);
            this.btnAddAuth.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAuth.Name = "btnAddAuth";
            this.btnAddAuth.Size = new System.Drawing.Size(142, 29);
            this.btnAddAuth.TabIndex = 1;
            this.btnAddAuth.Text = "AddAuth";
            this.btnAddAuth.UseVisualStyleBackColor = true;
            this.btnAddAuth.Click += new System.EventHandler(this.btnAddAuth_Click);
            // 
            // cbRoleList
            // 
            this.cbRoleList.FormattingEnabled = true;
            this.cbRoleList.Location = new System.Drawing.Point(15, 117);
            this.cbRoleList.Margin = new System.Windows.Forms.Padding(4);
            this.cbRoleList.Name = "cbRoleList";
            this.cbRoleList.Size = new System.Drawing.Size(330, 28);
            this.cbRoleList.TabIndex = 2;
            // 
            // txtRoleName
            // 
            this.txtRoleName.Location = new System.Drawing.Point(352, 88);
            this.txtRoleName.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(276, 26);
            this.txtRoleName.TabIndex = 3;
            // 
            // txtAuthName
            // 
            this.txtAuthName.Location = new System.Drawing.Point(352, 119);
            this.txtAuthName.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuthName.Name = "txtAuthName";
            this.txtAuthName.Size = new System.Drawing.Size(276, 26);
            this.txtAuthName.TabIndex = 4;
            // 
            // lbWorkerList
            // 
            this.lbWorkerList.FormattingEnabled = true;
            this.lbWorkerList.ItemHeight = 20;
            this.lbWorkerList.Location = new System.Drawing.Point(15, 160);
            this.lbWorkerList.Margin = new System.Windows.Forms.Padding(4);
            this.lbWorkerList.Name = "lbWorkerList";
            this.lbWorkerList.Size = new System.Drawing.Size(330, 204);
            this.lbWorkerList.TabIndex = 6;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(621, 201);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(213, 36);
            this.materialFlatButton1.TabIndex = 8;
            this.materialFlatButton1.Text = "materialFlatButton1";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox1.Location = new System.Drawing.Point(621, 160);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(181, 30);
            this.materialCheckBox1.TabIndex = 9;
            this.materialCheckBox1.Text = "materialCheckBox1";
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(621, 246);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(213, 28);
            this.materialSingleLineTextField1.TabIndex = 10;
            this.materialSingleLineTextField1.Text = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // btnEditWorker
            // 
            this.btnEditWorker.Depth = 0;
            this.btnEditWorker.Location = new System.Drawing.Point(352, 209);
            this.btnEditWorker.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditWorker.Name = "btnEditWorker";
            this.btnEditWorker.Primary = true;
            this.btnEditWorker.Size = new System.Drawing.Size(93, 43);
            this.btnEditWorker.TabIndex = 11;
            this.btnEditWorker.Text = "Edit";
            this.btnEditWorker.UseVisualStyleBackColor = true;
            this.btnEditWorker.Click += new System.EventHandler(this.btnEditWorker_Click);
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.Depth = 0;
            this.btnAddWorker.Location = new System.Drawing.Point(352, 160);
            this.btnAddWorker.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Primary = true;
            this.btnAddWorker.Size = new System.Drawing.Size(93, 43);
            this.btnAddWorker.TabIndex = 12;
            this.btnAddWorker.Text = "Add";
            this.btnAddWorker.UseVisualStyleBackColor = true;
            this.btnAddWorker.Click += new System.EventHandler(this.btnAddWorker_Click);
            // 
            // FormRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 395);
            this.Controls.Add(this.btnAddWorker);
            this.Controls.Add(this.btnEditWorker);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.materialCheckBox1);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.lbWorkerList);
            this.Controls.Add(this.txtAuthName);
            this.Controls.Add(this.txtRoleName);
            this.Controls.Add(this.cbRoleList);
            this.Controls.Add(this.btnAddAuth);
            this.Controls.Add(this.btnAddRole);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(811, 308);
            this.Name = "FormRoles";
            this.Text = "FormRoles";
            this.Load += new System.EventHandler(this.FormRoles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.Button btnAddAuth;
        private System.Windows.Forms.ComboBox cbRoleList;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.TextBox txtAuthName;
        private System.Windows.Forms.ListBox lbWorkerList;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditWorker;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddWorker;
    }
}