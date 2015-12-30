﻿namespace CamuseHome
{
    partial class MDIForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIForm));
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.btnNew = new System.Windows.Forms.RibbonButton();
            this.btnModify = new System.Windows.Forms.RibbonButton();
            this.btnDelete = new System.Windows.Forms.RibbonButton();
            this.btnApprove = new System.Windows.Forms.RibbonButton();
            this.btnUndoApprove = new System.Windows.Forms.RibbonButton();
            this.ribbonSeparator1 = new System.Windows.Forms.RibbonSeparator();
            this.btnImport = new System.Windows.Forms.RibbonButton();
            this.btnExport = new System.Windows.Forms.RibbonButton();
            this.ribbonSeparator2 = new System.Windows.Forms.RibbonSeparator();
            this.btnPrint = new System.Windows.Forms.RibbonButton();
            this.ribbonSeparator3 = new System.Windows.Forms.RibbonSeparator();
            this.btnSearch = new System.Windows.Forms.RibbonButton();
            this.tvCategory = new System.Windows.Forms.TreeView();
            this.ribbonItemGroup1 = new System.Windows.Forms.RibbonItemGroup();
            this.ribbonItemGroup2 = new System.Windows.Forms.RibbonItemGroup();
            this.ribbonUpDown1 = new System.Windows.Forms.RibbonUpDown();
            this.gvProduct = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameEn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnPictures = new System.Windows.Forms.Panel();
            this.cmCategory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAddCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModifyCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonOrbMenuItem1 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.btnChangePasswd = new System.Windows.Forms.RibbonButton();
            this.btnMember = new System.Windows.Forms.RibbonButton();
            this.btnSystemP = new System.Windows.Forms.RibbonButton();
            this.btnExit = new System.Windows.Forms.RibbonOrbMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).BeginInit();
            this.cmCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Text = "开始";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ButtonMoreEnabled = false;
            this.ribbonPanel1.ButtonMoreVisible = false;
            this.ribbonPanel1.Items.Add(this.btnNew);
            this.ribbonPanel1.Items.Add(this.btnModify);
            this.ribbonPanel1.Items.Add(this.btnDelete);
            this.ribbonPanel1.Items.Add(this.btnApprove);
            this.ribbonPanel1.Items.Add(this.ribbonSeparator1);
            this.ribbonPanel1.Items.Add(this.btnImport);
            this.ribbonPanel1.Items.Add(this.btnExport);
            this.ribbonPanel1.Items.Add(this.ribbonSeparator2);
            this.ribbonPanel1.Items.Add(this.btnPrint);
            this.ribbonPanel1.Items.Add(this.ribbonSeparator3);
            this.ribbonPanel1.Items.Add(this.btnSearch);
            this.ribbonPanel1.Text = "";
            // 
            // btnNew
            // 
            this.btnNew.Image = global::CamuseHome.Properties.Resources.new_file_32px;
            this.btnNew.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnNew.SmallImage")));
            this.btnNew.Text = "新增";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnModify
            // 
            this.btnModify.Image = global::CamuseHome.Properties.Resources.Tests_32;
            this.btnModify.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnModify.SmallImage")));
            this.btnModify.Text = "编辑";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::CamuseHome.Properties.Resources.delete_file_32;
            this.btnDelete.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.SmallImage")));
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.DropDownItems.Add(this.btnUndoApprove);
            this.btnApprove.Image = global::CamuseHome.Properties.Resources.file_complete_32;
            this.btnApprove.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnApprove.SmallImage")));
            this.btnApprove.Style = System.Windows.Forms.RibbonButtonStyle.SplitDropDown;
            this.btnApprove.Text = "审核";
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnUndoApprove
            // 
            this.btnUndoApprove.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.btnUndoApprove.Image = global::CamuseHome.Properties.Resources.undo_32;
            this.btnUndoApprove.SmallImage = global::CamuseHome.Properties.Resources.undo_16;
            this.btnUndoApprove.Text = "弃审";
            this.btnUndoApprove.Value = "";
            this.btnUndoApprove.Click += new System.EventHandler(this.btnUndoApprove_Click);
            // 
            // btnImport
            // 
            this.btnImport.Image = global::CamuseHome.Properties.Resources.Upload_32;
            this.btnImport.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnImport.SmallImage")));
            this.btnImport.Text = "导入";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Image = global::CamuseHome.Properties.Resources.Download_32;
            this.btnExport.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnExport.SmallImage")));
            this.btnExport.Text = "导出";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::CamuseHome.Properties.Resources.Printer_blue_32;
            this.btnPrint.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.SmallImage")));
            this.btnPrint.Text = "打印";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::CamuseHome.Properties.Resources.search_file_32;
            this.btnSearch.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.SmallImage")));
            this.btnSearch.Text = "查询";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tvCategory
            // 
            this.tvCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvCategory.Location = new System.Drawing.Point(0, 125);
            this.tvCategory.Name = "tvCategory";
            this.tvCategory.Size = new System.Drawing.Size(141, 433);
            this.tvCategory.TabIndex = 4;
            this.tvCategory.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.tvCategory_AfterLabelEdit);
            this.tvCategory.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvCategory_AfterSelect);
            this.tvCategory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tvCategory_MouseDown);
            // 
            // ribbonItemGroup1
            // 
            this.ribbonItemGroup1.Text = "ribbonItemGroup1";
            // 
            // ribbonItemGroup2
            // 
            this.ribbonItemGroup2.Text = "ribbonItemGroup2";
            // 
            // ribbonUpDown1
            // 
            this.ribbonUpDown1.Text = "ribbonUpDown1";
            this.ribbonUpDown1.TextBoxText = "";
            this.ribbonUpDown1.TextBoxWidth = 50;
            // 
            // gvProduct
            // 
            this.gvProduct.AllowUserToAddRows = false;
            this.gvProduct.AllowUserToDeleteRows = false;
            this.gvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvProduct.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Code,
            this.NameCn,
            this.NameEn});
            this.gvProduct.Location = new System.Drawing.Point(147, 132);
            this.gvProduct.Name = "gvProduct";
            this.gvProduct.ReadOnly = true;
            this.gvProduct.RowTemplate.Height = 23;
            this.gvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvProduct.Size = new System.Drawing.Size(621, 291);
            this.gvProduct.TabIndex = 7;
            this.gvProduct.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gvProduct_CellFormatting);
            this.gvProduct.SelectionChanged += new System.EventHandler(this.gvProduct_SelectionChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 5;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "货号";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // NameCn
            // 
            this.NameCn.DataPropertyName = "Name";
            this.NameCn.HeaderText = "品名";
            this.NameCn.Name = "NameCn";
            this.NameCn.ReadOnly = true;
            // 
            // NameEn
            // 
            this.NameEn.DataPropertyName = "EN";
            this.NameEn.HeaderText = "英文名称";
            this.NameEn.Name = "NameEn";
            this.NameEn.ReadOnly = true;
            // 
            // pnPictures
            // 
            this.pnPictures.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnPictures.AutoScroll = true;
            this.pnPictures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnPictures.Location = new System.Drawing.Point(147, 429);
            this.pnPictures.Name = "pnPictures";
            this.pnPictures.Size = new System.Drawing.Size(621, 116);
            this.pnPictures.TabIndex = 9;
            // 
            // cmCategory
            // 
            this.cmCategory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddCategory,
            this.btnModifyCategory,
            this.btnDeleteCategory});
            this.cmCategory.Name = "cmCategory";
            this.cmCategory.Size = new System.Drawing.Size(101, 70);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(100, 22);
            this.btnAddCategory.Text = "新增";
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnModifyCategory
            // 
            this.btnModifyCategory.Name = "btnModifyCategory";
            this.btnModifyCategory.Size = new System.Drawing.Size(100, 22);
            this.btnModifyCategory.Text = "编辑";
            this.btnModifyCategory.Click += new System.EventHandler(this.btnModifyCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(100, 22);
            this.btnDeleteCategory.Text = "删除";
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // ribbon1
            // 
            this.ribbon1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ribbon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItem1);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.btnExit);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 160);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = global::CamuseHome.Properties.Resources.Lamp_22;
            this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013;
            // 
            // 
            // 
            this.ribbon1.QuickAcessToolbar.DropDownButtonVisible = false;
            this.ribbon1.QuickAcessToolbar.Text = "";
            this.ribbon1.QuickAcessToolbar.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.ribbon1.QuickAcessToolbar.Value = "";
            this.ribbon1.QuickAcessToolbar.Visible = false;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(780, 126);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbon1.Text = "ribbon1";
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
            // 
            // ribbonOrbMenuItem1
            // 
            this.ribbonOrbMenuItem1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem1.DropDownItems.Add(this.btnChangePasswd);
            this.ribbonOrbMenuItem1.DropDownItems.Add(this.btnMember);
            this.ribbonOrbMenuItem1.DropDownItems.Add(this.btnSystemP);
            this.ribbonOrbMenuItem1.Image = global::CamuseHome.Properties.Resources.setting_24;
            this.ribbonOrbMenuItem1.SmallImage = global::CamuseHome.Properties.Resources.setting_24;
            this.ribbonOrbMenuItem1.Style = System.Windows.Forms.RibbonButtonStyle.SplitDropDown;
            this.ribbonOrbMenuItem1.Text = "系统设置";
            // 
            // btnChangePasswd
            // 
            this.btnChangePasswd.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.btnChangePasswd.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePasswd.Image")));
            this.btnChangePasswd.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnChangePasswd.SmallImage")));
            this.btnChangePasswd.Text = "修改密码";
            this.btnChangePasswd.Click += new System.EventHandler(this.btnChangePasswd_Click);
            // 
            // btnMember
            // 
            this.btnMember.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.btnMember.Image = ((System.Drawing.Image)(resources.GetObject("btnMember.Image")));
            this.btnMember.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnMember.SmallImage")));
            this.btnMember.Text = "操作员管理";
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnSystemP
            // 
            this.btnSystemP.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.btnSystemP.Image = ((System.Drawing.Image)(resources.GetObject("btnSystemP.Image")));
            this.btnSystemP.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnSystemP.SmallImage")));
            this.btnSystemP.Text = "系统参数";
            this.btnSystemP.Click += new System.EventHandler(this.btnSystemP_Click);
            // 
            // btnExit
            // 
            this.btnExit.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.btnExit.Image = global::CamuseHome.Properties.Resources.Logout_24;
            this.btnExit.SmallImage = global::CamuseHome.Properties.Resources.Logout_24;
            this.btnExit.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.Controls.Add(this.ribbon1);
            this.Controls.Add(this.gvProduct);
            this.Controls.Add(this.pnPictures);
            this.Controls.Add(this.tvCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "MDIForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camuse Home";
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).EndInit();
            this.cmCategory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton btnNew;
        private System.Windows.Forms.RibbonButton btnModify;
        private System.Windows.Forms.RibbonButton btnDelete;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem1;
        private System.Windows.Forms.TreeView tvCategory;
        private System.Windows.Forms.RibbonItemGroup ribbonItemGroup1;
        private System.Windows.Forms.RibbonItemGroup ribbonItemGroup2;
        private System.Windows.Forms.RibbonUpDown ribbonUpDown1;
        private System.Windows.Forms.RibbonButton btnApprove;
        private System.Windows.Forms.RibbonButton btnUndoApprove;
        private System.Windows.Forms.DataGridView gvProduct;
        private System.Windows.Forms.Panel pnPictures;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameEn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.ContextMenuStrip cmCategory;
        private System.Windows.Forms.ToolStripMenuItem btnAddCategory;
        private System.Windows.Forms.ToolStripMenuItem btnModifyCategory;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteCategory;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator1;
        private System.Windows.Forms.RibbonButton btnImport;
        private System.Windows.Forms.RibbonButton btnExport;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator2;
        private System.Windows.Forms.RibbonButton btnPrint;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator3;
        private System.Windows.Forms.RibbonButton btnSearch;
        private System.Windows.Forms.RibbonButton btnSystemP;
        private System.Windows.Forms.RibbonButton btnMember;
        private System.Windows.Forms.RibbonButton btnChangePasswd;
        private System.Windows.Forms.RibbonOrbMenuItem btnExit;
    }
}