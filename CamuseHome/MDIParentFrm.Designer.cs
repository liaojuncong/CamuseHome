namespace CamuseHome
{
    partial class MDIParentFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParentFrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tvCategory = new System.Windows.Forms.TreeView();
            this.lvProduct = new System.Windows.Forms.ListView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnModify = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.sbtnApprove = new System.Windows.Forms.ToolStripSplitButton();
            this.btnApprove = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUndoApprove = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.系统管理ToolStripMenuItem.Text = "系统管理";
            // 
            // tvCategory
            // 
            this.tvCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvCategory.Location = new System.Drawing.Point(0, 68);
            this.tvCategory.Name = "tvCategory";
            this.tvCategory.Size = new System.Drawing.Size(167, 491);
            this.tvCategory.TabIndex = 2;
            this.tvCategory.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvCategory_AfterSelect);
            // 
            // lvProduct
            // 
            this.lvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvProduct.Location = new System.Drawing.Point(167, 68);
            this.lvProduct.Name = "lvProduct";
            this.lvProduct.Size = new System.Drawing.Size(617, 491);
            this.lvProduct.TabIndex = 3;
            this.lvProduct.UseCompatibleStateImageBehavior = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnModify,
            this.toolStripButton1,
            this.sbtnApprove});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 40);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(52, 37);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Image = global::CamuseHome.Properties.Resources.Pen;
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(52, 37);
            this.btnModify.Text = "编辑";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::CamuseHome.Properties.Resources.Cancel;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 37);
            this.toolStripButton1.Text = "删除";
            // 
            // sbtnApprove
            // 
            this.sbtnApprove.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnApprove,
            this.btnUndoApprove});
            this.sbtnApprove.Image = global::CamuseHome.Properties.Resources.Success;
            this.sbtnApprove.Name = "sbtnApprove";
            this.sbtnApprove.Size = new System.Drawing.Size(64, 37);
            this.sbtnApprove.Text = "审核";
            this.sbtnApprove.ButtonClick += new System.EventHandler(this.sbtnApprove_ButtonClick);
            // 
            // btnApprove
            // 
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(152, 22);
            this.btnApprove.Text = "审核";
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnUndoApprove
            // 
            this.btnUndoApprove.Name = "btnUndoApprove";
            this.btnUndoApprove.Size = new System.Drawing.Size(152, 22);
            this.btnUndoApprove.Text = "弃审";
            this.btnUndoApprove.Click += new System.EventHandler(this.btnUndoApprove_Click);
            // 
            // MDIParentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lvProduct);
            this.Controls.Add(this.tvCategory);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDIParentFrm";
            this.Text = "Camuse Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TreeView tvCategory;
        private System.Windows.Forms.ListView lvProduct;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnModify;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSplitButton sbtnApprove;
        private System.Windows.Forms.ToolStripMenuItem btnUndoApprove;
        private System.Windows.Forms.ToolStripMenuItem btnApprove;
    }
}

