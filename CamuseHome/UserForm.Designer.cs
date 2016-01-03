namespace CamuseHome
{
    partial class UserForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ResetButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputData = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ModifyData = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DeleteData = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AuditData = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AbandonData = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SetParam = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ExportData = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Print = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LookCost = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LookPrice = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Code,
            this.Name,
            this.Pwd,
            this.InputData,
            this.ModifyData,
            this.DeleteData,
            this.AuditData,
            this.AbandonData,
            this.SetParam,
            this.ExportData,
            this.Print,
            this.LookCost,
            this.LookPrice});
            this.dataGridView1.Location = new System.Drawing.Point(0, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(660, 312);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(146, 15);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(65, 23);
            this.ResetButton.TabIndex = 6;
            this.ResetButton.Text = "重置密码";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(80, 15);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(50, 23);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "删除";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(15, 15);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(50, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "增加";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 23;
            // 
            // Code
            // 
            this.Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "编号";
            this.Code.Name = "Code";
            this.Code.Width = 54;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "姓名";
            this.Name.Name = "Name";
            this.Name.Width = 54;
            // 
            // Pwd
            // 
            this.Pwd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Pwd.DataPropertyName = "Pwd";
            this.Pwd.HeaderText = "Pwd";
            this.Pwd.Name = "Pwd";
            this.Pwd.Visible = false;
            this.Pwd.Width = 48;
            // 
            // InputData
            // 
            this.InputData.DataPropertyName = "InputData";
            this.InputData.FalseValue = "0";
            this.InputData.HeaderText = "录入资料";
            this.InputData.Name = "InputData";
            this.InputData.TrueValue = "1";
            this.InputData.Width = 40;
            // 
            // ModifyData
            // 
            this.ModifyData.DataPropertyName = "ModifyData";
            this.ModifyData.FalseValue = "0";
            this.ModifyData.HeaderText = "修改资料";
            this.ModifyData.Name = "ModifyData";
            this.ModifyData.TrueValue = "1";
            this.ModifyData.Width = 40;
            // 
            // DeleteData
            // 
            this.DeleteData.DataPropertyName = "DeleteData";
            this.DeleteData.FalseValue = "0";
            this.DeleteData.HeaderText = "删除资料";
            this.DeleteData.Name = "DeleteData";
            this.DeleteData.TrueValue = "1";
            this.DeleteData.Width = 40;
            // 
            // AuditData
            // 
            this.AuditData.DataPropertyName = "AuditData";
            this.AuditData.FalseValue = "0";
            this.AuditData.HeaderText = "审核资料";
            this.AuditData.Name = "AuditData";
            this.AuditData.TrueValue = "1";
            this.AuditData.Width = 40;
            // 
            // AbandonData
            // 
            this.AbandonData.DataPropertyName = "AbandonData";
            this.AbandonData.FalseValue = "0";
            this.AbandonData.HeaderText = "弃审资料";
            this.AbandonData.Name = "AbandonData";
            this.AbandonData.TrueValue = "1";
            this.AbandonData.Width = 40;
            // 
            // SetParam
            // 
            this.SetParam.DataPropertyName = "SetParam";
            this.SetParam.FalseValue = "0";
            this.SetParam.HeaderText = "设置参数";
            this.SetParam.Name = "SetParam";
            this.SetParam.TrueValue = "1";
            this.SetParam.Width = 40;
            // 
            // ExportData
            // 
            this.ExportData.DataPropertyName = "ExportData";
            this.ExportData.FalseValue = "0";
            this.ExportData.HeaderText = "导出资料";
            this.ExportData.Name = "ExportData";
            this.ExportData.TrueValue = "1";
            this.ExportData.Width = 40;
            // 
            // Print
            // 
            this.Print.DataPropertyName = "Print";
            this.Print.FalseValue = "0";
            this.Print.HeaderText = "打印";
            this.Print.Name = "Print";
            this.Print.TrueValue = "1";
            this.Print.Width = 40;
            // 
            // LookCost
            // 
            this.LookCost.DataPropertyName = "LookCost";
            this.LookCost.FalseValue = "0";
            this.LookCost.HeaderText = "查看成本";
            this.LookCost.Name = "LookCost";
            this.LookCost.TrueValue = "1";
            this.LookCost.Width = 40;
            // 
            // LookPrice
            // 
            this.LookPrice.DataPropertyName = "LookPrice";
            this.LookPrice.FalseValue = "0";
            this.LookPrice.HeaderText = "查看价格";
            this.LookPrice.Name = "LookPrice";
            this.LookPrice.TrueValue = "1";
            this.LookPrice.Width = 40;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 357);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "操作员管理";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pwd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn InputData;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ModifyData;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DeleteData;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AuditData;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AbandonData;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SetParam;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ExportData;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Print;
        private System.Windows.Forms.DataGridViewCheckBoxColumn LookCost;
        private System.Windows.Forms.DataGridViewCheckBoxColumn LookPrice;
    }
}