using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamuseHome
{
    public partial class AddProductForm : Form
    {
        public static int Id = 0;
        public int CategoryId = 0;
        public AddProductForm()
        {
            InitializeComponent();

            loadtvCategory();

            modProduct modProduct = new dalProduct().getProduct(Id);
            this.txtbCode.Text = modProduct.Code;
            this.txtbName.Text = modProduct.Name;
            this.txtbLampShadeSize.Text = modProduct.LampShadeSize;
            this.txtbLampBodySize.Text = modProduct.LampBodySize;
            this.txtbLampSize.Text = modProduct.LampSize;
            this.txtbPrice.Text = modProduct.Price.ToString();
            this.txtbCost.Text = modProduct.Cost.ToString();
            this.txtbLampShadeColor.Text = modProduct.LampShadeColor;
            this.txtbLampBodyColor.Text = modProduct.LampBodyColor;
            this.txtbCraft.Text = modProduct.Craft;
            this.txtbLampBodyMaterial.Text = modProduct.LampBodyMaterial;
            this.txtbClothPlateCode.Text = modProduct.ClothPlateCode;
            this.txtbColorPlateCode.Text = modProduct.ColorPlateCode;
            this.CategoryId = modProduct.CategoryId;
            modCategory modCategory = new dalCategory().getCategory(this.CategoryId);
            this.txtbCategoryName.Text = modCategory.Name;
            this.txtbStyle.Text = modProduct.Style;
            this.txtbPackingWay.Text = modProduct.PackingWay;
            this.txtbCartonPackingSize.Text = modProduct.CartonPackingSize;
            this.txtbInventory.Text = modProduct.Inventory;
            this.txtbRemark.Text = modProduct.Remark;
            showPicture();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.CategoryId == 0 && this.txtbCategoryName.Text.Trim() != "")
            {
                MessageBox.Show("请选择有效的类别...", "提示信息");
                return;
            }
            if (this.CategoryId == 0)
            {
                MessageBox.Show("类别不能为空...", "提示信息");
                return;
            }
            int i = 0;
            modProduct modProduct = new modProduct();
            modProduct.Id = Id;
            modProduct.Code = this.txtbCode.Text.Trim();
            modProduct.Name = this.txtbName.Text.Trim();
            modProduct.LampShadeSize = this.txtbLampShadeSize.Text.Trim();
            modProduct.LampBodySize = this.txtbLampBodySize.Text.Trim();
            modProduct.LampSize = this.txtbLampSize.Text.Trim();
            modProduct.Price = Convert.ToDouble(this.txtbPrice.Text.Trim());
            modProduct.Cost = Convert.ToDouble(this.txtbCost.Text.Trim());
            modProduct.LampShadeColor = this.txtbLampShadeColor.Text.Trim();
            modProduct.LampBodyColor = this.txtbLampBodyColor.Text.Trim();
            modProduct.Craft = this.txtbCraft.Text.Trim();
            modProduct.LampBodyMaterial = this.txtbLampBodyMaterial.Text.Trim();
            modProduct.ClothPlateCode = this.txtbClothPlateCode.Text.Trim();
            modProduct.ColorPlateCode = this.txtbColorPlateCode.Text.Trim();
            modProduct.CategoryId = this.CategoryId;
            modProduct.Style = this.txtbStyle.Text.Trim();
            modProduct.PackingWay = this.txtbPackingWay.Text.Trim();
            modProduct.CartonPackingSize = this.txtbCartonPackingSize.Text.Trim();
            modProduct.Inventory = this.txtbInventory.Text.Trim();
            modProduct.Remark = this.txtbRemark.Text.Trim();
            if (modProduct.Id == 0)
            {
                i = new dalProduct().addProduct(modProduct);
                using (DataTable dt = new dalProduct().getProductDataTable(new modProduct(), ""))
                {
                    if (i > 0 && dt.Rows.Count > 0)
                    {
                        int id = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1]["Id"]);
                        int j = new dalPicture().updatePicture(id);
                    }
                }
            }
            else
            {
                i = new dalProduct().updateProduct(modProduct);
            }
            if (i > 0)
            {
                MDIForm mDIForm = (MDIForm)this.Owner;
                mDIForm.loadgvProduct(new modProduct(), "", 0);
                MessageBox.Show("操作失败...", "提示信息");
                if (Id == 0)
                {
                    this.txtbCode.Text = "";
                    this.txtbName.Text = "";
                    this.txtbLampShadeSize.Text = "";
                    this.txtbLampBodySize.Text = "";
                    this.txtbLampSize.Text = "";
                    this.txtbPrice.Text = "0";
                    this.txtbCost.Text = "0";
                    this.txtbLampShadeColor.Text = "";
                    this.txtbLampBodyColor.Text = "";
                    this.txtbCraft.Text = "";
                    this.txtbLampBodyMaterial.Text = "";
                    this.txtbClothPlateCode.Text = "";
                    this.txtbColorPlateCode.Text = "";
                    this.txtbCategoryName.Text = "0";
                    this.txtbStyle.Text = "";
                    this.txtbPackingWay.Text = "";
                    this.txtbCartonPackingSize.Text = "";
                    this.txtbInventory.Text = "";
                    this.txtbRemark.Text = "";
                }
            }
            else
            {
                MessageBox.Show("操作失败...", "提示信息");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (this.openFileDialog1.FileName != null && this.openFileDialog1.FileName != "")
                {
                    try
                    {
                        FileInfo fileInfo = new FileInfo(this.openFileDialog1.FileName);
                        string path = "\\Pictures\\" + DateTime.Now.ToString("yyyyMMddHHmmssffff") + fileInfo.Extension;
                        if (!Directory.Exists(Application.StartupPath + "\\Pictures"))
                        {
                            Directory.CreateDirectory(Application.StartupPath + "\\Pictures");
                        }
                        File.Copy(this.openFileDialog1.FileName, Application.StartupPath + path);
                        modPicture modPicture = new modPicture();
                        modPicture.Name = fileInfo.Name;
                        modPicture.Path = path;
                        modPicture.Remark = "";
                        modPicture.ProductId = Id;
                        int i = new dalPicture().addPicture(modPicture);
                        showPicture();
                    }
                    catch
                    {
                        MessageBox.Show("图片上传失败...", "提示信息");
                    }
                }
            }
        }

        public void showPicture()
        {
            #region 显示图片
            var pictures = new dalPicture().getPictureList(Id);
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
                pb.Size = new System.Drawing.Size(80, 80);
                pb.Location = new System.Drawing.Point(leftX, 8);
                leftX += 96;
                this.pnPictures.Controls.Add(pb);

                Button btn = new Button();
                btn.Parent = this.pnPictures;
                btn.Size = new System.Drawing.Size(30, 21);
                btn.Location = new Point(pb.Location.X + 25, pb.Location.Y + 80);
                btn.Name = "btn_" + pic.Id.ToString();
                btn.Text = "删";
                btn.Click += new EventHandler(btn_Click);
            }
            #endregion
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

        public void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int Id = Convert.ToInt32(btn.Name.Substring(4));
            modPicture modPicture = new dalPicture().getPicture(Id);
            try
            {
                File.Delete(Application.StartupPath + modPicture.Path);
                int i = new dalPicture().deletePicture(Id);
            }
            catch { }
            this.showPicture();
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

        private void AddProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Id == 0)
            {
                using (DataTable dt = new dalPicture().getPictureDataTable(Id))
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        string path = dr["Path"].ToString();
                        File.Delete(path);
                        int i = new dalPicture().deletePicture(Convert.ToInt32(dr["Id"]));
                    }
                }
            }
            MDIForm mdiForm = (MDIForm)this.Owner;
            mdiForm.showPicture();
        }
    }
}
