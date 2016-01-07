using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamuseHome
{
    public partial class SelectForm : Form
    {
        public int CategoryId = 0;
        public SelectForm()
        {
            InitializeComponent();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (this.btnDetail.Text == "详细")
            {
                this.Size = new Size(475, 300);
                this.btnDetail.Text = "简单";
            }
            else
            {
                this.Size = new Size(475, 90);
                this.btnDetail.Text = "详细";
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            modProduct modProduct = new modProduct();
            modProduct.Code = this.txtbCode.Text.Trim();
            modProduct.Name = this.txtbName.Text.Trim();
            modProduct.LampShadeColor = this.txtbLampShadeColor.Text.Trim();
            modProduct.LampBodyColor = this.txtbLampBodyColor.Text.Trim();
            modProduct.Craft = this.txtbCraft.Text.Trim();
            modProduct.LampBodyMaterial = this.txtbLampBodyMaterial.Text.Trim();
            modProduct.ClothPlateCode = this.txtbClothPlateCode.Text.Trim();
            modProduct.ColorPlateCode = this.txtbColorPlateCode.Text.Trim();
            modProduct.CategoryId = this.CategoryId;
            modProduct.Style = this.txtbStyle.Text.Trim();
            modProduct.Remark = this.txtbRemark.Text.Trim();
            MDIForm mdiForm = (MDIForm)this.Owner;
            mdiForm.loadgvProduct(modProduct, this.txtbKeyWord.Text.Trim(), 0);
        }

        public void loadtvCategory()
        {
            this.tvCategory.Nodes.Clear();
            var tn = new TreeNode();
            tn.Name = "0";
            tn.Text = "类别";
            tvCategory.Nodes.Add(tn);
            BindTvCategory(new dalCategory().getCategoryList(), tn.Nodes, 0);
            tvCategory.ExpandAll();
        }

        /// <summary>
        /// 绑定TreeView（利用TreeNodeCollection）
        /// </summary>
        public void BindTvCategory(List<modCategory> categorys, TreeNodeCollection tnc, long pid)
        {
            TreeNode tn;
            var subCategorys = categorys.Where(i => i.ParentId == pid);
            foreach (var item in subCategorys)
            {
                tn = new TreeNode();
                tn.Name = item.Id.ToString();
                tn.Text = item.Name.ToString();
                tnc.Add(tn);
                BindTvCategory(categorys, tn.Nodes, item.Id);
            }
        }

        private void txtbCategoryId_Enter(object sender, EventArgs e)
        {
            this.loadtvCategory();
            this.tvCategory.Visible = true;
            this.tvCategory.Location = new Point(this.txtbCategoryName.Location.X, this.txtbCategoryName.Location.Y + this.txtbCategoryName.Height);
        }

        private void txtbCategoryId_Leave(object sender, EventArgs e)
        {
            if (!this.tvCategory.Focused)
            {
                this.tvCategory.Visible = false;
            }
        }

        private void tvCategory_Leave(object sender, EventArgs e)
        {
            if (!this.txtbCategoryName.Focused)
            {
                this.tvCategory.Visible = false;
            }
        }

        private void tvCategory_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            this.CategoryId = Convert.ToInt32(e.Node.Name);
            this.txtbCategoryName.Text = e.Node.Text;
        }
    }
}
