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
            this.Close();
        }
    }
}
