namespace CamuseHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIForm));
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.lvProduct = new System.Windows.Forms.ListView();
            this.tvCategory = new System.Windows.Forms.TreeView();
            this.ribbonItemGroup1 = new System.Windows.Forms.RibbonItemGroup();
            this.ribbonItemGroup2 = new System.Windows.Forms.RibbonItemGroup();
            this.ribbonUpDown1 = new System.Windows.Forms.RibbonUpDown();
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonOrbMenuItem1 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.btnNew = new System.Windows.Forms.RibbonButton();
            this.btnModify = new System.Windows.Forms.RibbonButton();
            this.btnDelete = new System.Windows.Forms.RibbonButton();
            this.btnApprove = new System.Windows.Forms.RibbonButton();
            this.btnUndoApprove = new System.Windows.Forms.RibbonButton();
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
            this.ribbonPanel1.Text = "";
            // 
            // lvProduct
            // 
            this.lvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvProduct.Location = new System.Drawing.Point(141, 125);
            this.lvProduct.Name = "lvProduct";
            this.lvProduct.Size = new System.Drawing.Size(643, 437);
            this.lvProduct.TabIndex = 5;
            this.lvProduct.UseCompatibleStateImageBehavior = false;
            // 
            // tvCategory
            // 
            this.tvCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvCategory.Location = new System.Drawing.Point(0, 125);
            this.tvCategory.Name = "tvCategory";
            this.tvCategory.Size = new System.Drawing.Size(141, 437);
            this.tvCategory.TabIndex = 4;
            this.tvCategory.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvCategory_AfterSelect);
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
            // ribbon1
            // 
            this.ribbon1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ribbon1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItem1);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 116);
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
            this.ribbon1.Size = new System.Drawing.Size(784, 126);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbon1.Text = "ribbon1";
            // 
            // ribbonOrbMenuItem1
            // 
            this.ribbonOrbMenuItem1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.Image")));
            this.ribbonOrbMenuItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.SmallImage")));
            this.ribbonOrbMenuItem1.Text = "会员管理";
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
            // MDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lvProduct);
            this.Controls.Add(this.tvCategory);
            this.Controls.Add(this.ribbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MDIForm";
            this.Text = "Camuse Home";
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
        private System.Windows.Forms.ListView lvProduct;
        private System.Windows.Forms.TreeView tvCategory;
        private System.Windows.Forms.RibbonItemGroup ribbonItemGroup1;
        private System.Windows.Forms.RibbonItemGroup ribbonItemGroup2;
        private System.Windows.Forms.RibbonUpDown ribbonUpDown1;
        private System.Windows.Forms.RibbonButton btnApprove;
        private System.Windows.Forms.RibbonButton btnUndoApprove;
    }
}