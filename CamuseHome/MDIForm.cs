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

            using (var db = new CamuseHomeContext())
            {
                var tn = new TreeNode();
                tn.Name = "0";
                tn.Text = "类别";
                tvCategory.Nodes.Add(tn);
                try
                {
                    var categoryList = db.Category.ToList();
                    BindTvCategory(categoryList, tn.Nodes, 0);
                }
                catch { }
            }
            tvCategory.ExpandAll();

            gvProduct.ReadOnly = true;
            gvProduct.AutoGenerateColumns = false;
        }

        /// <summary>
        /// 绑定TreeView（利用TreeNodeCollection）
        /// </summary>
        private void BindTvCategory(List<modCategory> categorys, TreeNodeCollection tnc, long pid)
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
            using (var db = new CamuseHomeContext())
            {
                var categoryId = int.Parse(e.Node.Name);
                try
                {
                    var products = db.Product.Include("Pictures").Where(i => i.CategoryId == categoryId).ToList();
                    if (gvProduct.CurrentRow != null)
                        bindFlag = false;
                    pnPictures.Controls.Clear();
                    gvProduct.DataSource = products.ToDataTable<modProduct>();
                }
                catch { }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New");
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modify");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete");
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Approve");
        }

        private void btnUndoApprove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UnApprove");
        }

        private void gvProduct_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (gvProduct.Columns[e.ColumnIndex].Name.Equals("modPicture"))
            {
                string path = e.Value.ToString();
                e.Value = GetImage(path);
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
            if (!bindFlag)
            { bindFlag = true; return; }
            if (this.gvProduct.CurrentRow == null)
                return;
            using (var db = new CamuseHomeContext())
            {
                var id = int.Parse(this.gvProduct.CurrentRow.Cells["Id"].Value.ToString());
                var pictures = db.Picture.Where(p => p.ProductId == id).Select(p => new { p.Name, p.Path });

                #region 显示图片
                this.pnPictures.Controls.Clear();
                int leftX = 10;
                foreach (var pic in pictures)
                {
                    PictureBox pb = new PictureBox();
                    pb.Paint += (s, e1) =>
                    {
                        Graphics g = e1.Graphics;
                        g.SmoothingMode = SmoothingMode.HighQuality;
                        g.DrawString(pic.Name, new Font("Arial", 8), SystemBrushes.ActiveCaptionText, new PointF(10, 30));
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
                    pb.Image = GetImage(pic.Path);
                    pb.Tag = pic;
                    pb.Size = new System.Drawing.Size(80, 80);
                    pb.Location = new System.Drawing.Point(leftX, 10);
                    leftX += 100;
                    this.pnPictures.Controls.Add(pb);
                }
                #endregion
            }
        }

        private void tvCategory_MouseDown(object sender, MouseEventArgs e)
        {
            Point ClickPoint = new Point(e.X, e.Y);
            TreeNode CurrentNode = tvCategory.GetNodeAt(ClickPoint);
            if (CurrentNode != null && CurrentNode.Name != "0")//判断你点的是不是一个节点
                CurrentNode.ContextMenuStrip = cmCategory;
            tvCategory.SelectedNode = CurrentNode;//选中这个节点
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
            tvCategory.LabelEdit = true;
            tvCategory.SelectedNode.BeginEdit();
        }

        private void tvCategory_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Node.Text == "新增类别" && e.Label == null)
                e.Node.Remove();
            else if (!string.IsNullOrWhiteSpace(e.Label))
            {
                using (var db = new CamuseHomeContext())
                {
                    modCategory cur = null;

                    if (string.IsNullOrWhiteSpace(e.Node.Name))
                    {
                        var pid = int.Parse(e.Node.Parent.Name);
                        cur = new modCategory() { ParentId = pid, Name = e.Label };
                        db.Category.Add(cur);
                    }
                    else
                    {
                        var id = int.Parse(e.Node.Name);
                        cur = db.Category.Find(id);
                        cur.Name = e.Label;
                    }
                    db.SaveChanges();
                    e.Node.Name = cur.Id.ToString();
                }
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
            using (var db = new CamuseHomeContext())
            {
                var exits = db.Product.Any(i => i.CategoryId == id);
                if (exits)
                {
                    MessageBox.Show("此类别已经有产品存在，不允许删除！");
                }
                else
                {
                    db.Category.Remove(db.Category.Find(id));
                    tvCategory.SelectedNode.Remove();
                }
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
            MessageBox.Show("打印");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("查询");
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
            MessageBox.Show("系统参数");
        }
    }
}
