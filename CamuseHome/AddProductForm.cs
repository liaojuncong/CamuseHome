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
        public AddProductForm()
        {
            InitializeComponent();

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
            this.txtbCategoryId.Text = modProduct.CategoryId.ToString();
            this.txtbStyle.Text = modProduct.Style;
            this.txtbPackingWay.Text = modProduct.PackingWay;
            this.txtbCartonPackingSize.Text = modProduct.CartonPackingSize;
            this.txtbInventory.Text = modProduct.Inventory;
            this.txtbRemark.Text = modProduct.Remark;
            showPicture();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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
            modProduct.CategoryId = Convert.ToInt32(this.txtbCategoryId.Text.Trim());
            modProduct.Style = this.txtbStyle.Text.Trim();
            modProduct.PackingWay = this.txtbPackingWay.Text.Trim();
            modProduct.CartonPackingSize = this.txtbCartonPackingSize.Text.Trim();
            modProduct.Inventory = this.txtbInventory.Text.Trim();
            modProduct.Remark = this.txtbRemark.Text.Trim();
            if (modProduct.Id == 0)
            {
                i = new dalProduct().addProduct(modProduct);
                using (DataTable dt = new dalProduct().getProductDataTable())
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
                mDIForm.loadgvProduct(0);
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
                    this.txtbCategoryId.Text = "0";
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
                pb.Image = GetImage(Application.StartupPath + pic.Path);
                pb.Tag = pic;
                pb.Size = new System.Drawing.Size(80, 80);
                pb.Location = new System.Drawing.Point(leftX, 10);
                leftX += 100;
                this.pnPictures.Controls.Add(pb);
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
    }
}
