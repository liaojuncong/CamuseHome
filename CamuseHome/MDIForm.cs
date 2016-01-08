using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace CamuseHome
{
    public partial class MDIForm : RibbonForm
    {
        public MDIForm()
        {
            InitializeComponent();
        }

        private void MDIForm_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + " V" + Application.ProductVersion;

            this.loadtvCategory();

            gvProduct.ReadOnly = true;
            gvProduct.AutoGenerateColumns = false;
            this.loadgvProduct(new modProduct(), "", 0);
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

        private bool bindFlag = true;
        private void tvCategory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(e.Node.Name)) return;
            var categoryId = int.Parse(e.Node.Name);
            this.loadgvProduct(new modProduct(), "", categoryId);
        }

        public void loadgvProduct(modProduct modProduct, string keyWord, int CategoryId)
        {
            try
            {
                if (CategoryId == 0)
                {
                    gvProduct.DataSource = new dalProduct().getProductDataTable(modProduct, keyWord);
                }
                else
                {
                    var products = new dalProduct().getProductList(modProduct, keyWord).Where(i => i.CategoryId == CategoryId).ToList();
                    if (gvProduct.CurrentRow != null)
                        bindFlag = false;
                    pnPictures.Controls.Clear();
                    gvProduct.DataSource = products.ToDataTable<modProduct>();
                }
            }
            catch { }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.Owner = this;
            addProductForm.ShowDialog();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in this.gvProduct.SelectedRows)
            {
                if (dgvr.Cells["AuditState"].Value.ToString() == "1")
                {
                    MessageBox.Show("当前记录" + dgvr.Cells["ProductName"].Value.ToString() + "已经审核，不能编辑...", "提示信息");
                }
                else
                {
                    int id = Convert.ToInt32(dgvr.Cells[1].Value.ToString());
                    AddProductForm.Id = id;
                    AddProductForm addProductForm = new AddProductForm();
                    addProductForm.Owner = this;
                    addProductForm.ShowDialog();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "确定删除所选记录吗？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < this.gvProduct.Rows.Count; i++)
                {
                    if (this.gvProduct.Rows[i].Cells["AuditState"].Value.ToString() == "1")
                    {
                        MessageBox.Show("当前记录" + this.gvProduct.Rows[i].Cells["ProductName"].Value.ToString() + "已经审核，不能删除...", "提示信息");
                    }
                    else
                    {
                        //判断当前行是否被选中
                        if ((bool)this.gvProduct.Rows[i].Cells[0].EditedFormattedValue == true)
                        {
                            int id = Convert.ToInt32(this.gvProduct.Rows[i].Cells[1].Value.ToString());
                            new dalProduct().deleteProduct(id);
                        }
                    }
                }
                this.loadgvProduct(new modProduct(), "", 0);
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "确定审核所选记录吗？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < this.gvProduct.Rows.Count; i++)
                {
                    //判断当前行是否被选中
                    if ((bool)this.gvProduct.Rows[i].Cells[0].EditedFormattedValue == true)
                    {
                        int id = Convert.ToInt32(this.gvProduct.Rows[i].Cells[1].Value.ToString());
                        modProduct modProduct = new dalProduct().getProduct(id);
                        if (!modProduct.AuditState)
                        {
                            modProduct.AuditState = true;
                            int j = new dalProduct().updateProduct(modProduct);
                        }
                    }
                }
                this.loadgvProduct(new modProduct(), "", 0);
            }
        }

        private void btnUndoApprove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "确定弃审所选记录吗？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < this.gvProduct.Rows.Count; i++)
                {
                    //判断当前行是否被选中
                    if ((bool)this.gvProduct.Rows[i].Cells[0].EditedFormattedValue == true)
                    {
                        int id = Convert.ToInt32(this.gvProduct.Rows[i].Cells[1].Value.ToString());
                        modProduct modProduct = new dalProduct().getProduct(id);
                        if (modProduct.AuditState)
                        {
                            modProduct.AuditState = false;
                            int j = new dalProduct().updateProduct(modProduct);
                        }
                    }
                }
                this.loadgvProduct(new modProduct(), "", 0);
            }
        }

        private void gvProduct_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (gvProduct.Columns[e.ColumnIndex].Name.Equals("modPicture"))
            {
                string path = e.Value.ToString();
                e.Value = GetImage(Application.StartupPath + path);
            }
            if (gvProduct.Rows[e.RowIndex].Cells["AuditState"].Value.ToString() == "1")
            {
                this.gvProduct.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.BlueViolet;
            }
        }
        public System.Drawing.Image GetImage(string path)
        {
            if (string.IsNullOrWhiteSpace(path) || !File.Exists(Path.Combine(System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase, "Pictures", path)))
                return null;
            System.IO.FileStream fs = new System.IO.FileStream(Path.Combine(System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase, "Pictures", path), System.IO.FileMode.Open);
            System.Drawing.Image result = System.Drawing.Image.FromStream(fs);

            fs.Close();

            return result;
        }

        private void gvProduct_SelectionChanged(object sender, EventArgs e)
        {
            this.showPicture();
        }

        public void showPicture()
        {
            if (!bindFlag)
            {
                bindFlag = true;
                return;
            }
            if (this.gvProduct.CurrentRow == null)
                return;

            var id = int.Parse(this.gvProduct.CurrentRow.Cells["Id"].Value.ToString());
            var pictures = new dalPicture().getPictureList(id);

            #region 显示图片
            this.pnPictures.Controls.Clear();
            int leftX = 8;
            foreach (var pic in pictures)
            {
                PictureBox pb = new PictureBox();
                pb.BorderStyle = BorderStyle.FixedSingle;
                pb.Paint += (s, e1) =>
                {
                    Graphics g = e1.Graphics;
                    g.SmoothingMode = SmoothingMode.HighQuality;
                    //g.DrawString(pic.Name, new Font("Arial", 8), SystemBrushes.ActiveCaptionText, new PointF(10, 30));
                };
                pb.DoubleClick += (s, e1) =>
                {
                    var c = s as PictureBox;
                    if (c != null)
                    {
                        var p = c.Tag.ToString();
                        var img = c.Image;
                        if (img != null)
                        {
                            var frm = new PictureView(img);
                            frm.Show();
                        }
                    }
                };
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Image = GetImage(Application.StartupPath + pic.Path);
                pb.Tag = pic;
                pb.Size = new System.Drawing.Size(100, 100);
                pb.Location = new System.Drawing.Point(leftX, 8);
                leftX += 116;
                this.pnPictures.Controls.Add(pb);
            }
            #endregion
        }

        private void tvCategory_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.tvCategory.SelectedNode = e.Node;
                this.cmCategory.Show(new Point(MousePosition.X, MousePosition.Y));
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            tvCategory.LabelEdit = true;
            var node = new TreeNode("新增类别");
            tvCategory.SelectedNode.Nodes.Add(node);
            tvCategory.ExpandAll();
            node.BeginEdit();
            tvCategory.SelectedNode = node;
        }

        private void btnModifyCategory_Click(object sender, EventArgs e)
        {
            if (tvCategory.SelectedNode.Name == "0")
            {
                MessageBox.Show("该类别不能编辑", "提示信息");
                return;
            }
            tvCategory.LabelEdit = true;
            tvCategory.SelectedNode.BeginEdit();
        }

        private void tvCategory_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Node.Text == "新增类别" && e.Label == null)
                e.Node.Remove();
            else if (!string.IsNullOrWhiteSpace(e.Label))
            {
                modCategory cur = null;
                if (string.IsNullOrWhiteSpace(e.Node.Name))
                {
                    var pid = int.Parse(e.Node.Parent.Name);
                    cur = new modCategory() { ParentId = pid, Name = e.Label };
                    int i = new dalCategory().addCategory(cur);
                }
                else
                {
                    var id = int.Parse(e.Node.Name);
                    cur = new dalCategory().getCategory(id);
                    cur.Name = e.Label;
                    int i = new dalCategory().updateCategory(cur);
                }
                this.loadtvCategory();
                e.Node.EndEdit(false);
            }
            else
            {
                e.Node.EndEdit(true);
            }
            tvCategory.LabelEdit = false;
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (tvCategory.SelectedNode.Name == "0")
            {
                MessageBox.Show("该类别不能删除", "提示信息");
                return;
            }
            if (string.IsNullOrWhiteSpace(tvCategory.SelectedNode.Name))
            {
                tvCategory.SelectedNode.Remove();
                return;
            }
            if (tvCategory.SelectedNode.Nodes != null && tvCategory.SelectedNode.Nodes.Count > 0)
            {
                MessageBox.Show("此类别存在子类别，不允许删除！");
                return;
            }

            var id = int.Parse(tvCategory.SelectedNode.Name);
            var exits = new dalProduct().getProductList(new modProduct(), "").Any(i => i.CategoryId == id);
            if (exits)
            {
                MessageBox.Show("此类别已经有产品存在，不允许删除！");
            }
            else
            {
                int i = new dalCategory().deleteCategory(id);
                tvCategory.SelectedNode.Remove();
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("导入");
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("导出");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintForm printForm = new PrintForm();
            printForm.Owner = this;
            printForm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SelectForm selectForm = new SelectForm();
            selectForm.Owner = this;
            selectForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangePasswd_Click(object sender, EventArgs e)
        {
            UpdatePwdForm updatePwdForm = new UpdatePwdForm();
            updatePwdForm.ShowDialog();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.ShowDialog();
        }

        private void btnSystemP_Click(object sender, EventArgs e)
        {
            SetParamForm setParamForm = new SetParamForm();
            setParamForm.ShowDialog();
        }

        private void gvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if ((bool)this.gvProduct.Rows[e.RowIndex].Cells[0].EditedFormattedValue == true)
                {
                    this.gvProduct.Rows[e.RowIndex].Cells[0].Value = false;
                }
                else
                {
                    this.gvProduct.Rows[e.RowIndex].Cells[0].Value = true;
                }
            }
        }
    }
}
