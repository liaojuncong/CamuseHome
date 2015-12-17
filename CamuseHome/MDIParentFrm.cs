using CamuseHome;
using CamuseHome.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamuseHome
{
    public partial class MDIParentFrm : Form
    {
        public MDIParentFrm()
        {
            InitializeComponent();

            using (var db = new CamuseHomeContext())
            {
                var categorys = new List<Category>() {
                    new Category() { Code = "DeskLamp", Name = "台灯" },
                    new Category() { Code = "FloorLamp", Name = "落地灯" },
                    new Category() { Code = "HomeDecoration", Name = "家饰" }
                };
                db.Category.AddRange(categorys);
                //db.SaveChanges();
                //var subCategorys = new List<Category>() {
                //    new Category() { Code = "SmallDeskLamp", Name = "小台灯", ParentId = categorys.FirstOrDefault(i => i.Code == "DeskLamp").Id },
                //    new Category() { Code = "BigDeskLamp", Name = "大台灯", ParentId = categorys.FirstOrDefault(i => i.Code == "DeskLamp").Id }
                //};
                //db.Category.AddRange(subCategorys);
                var pictures = db.Product.Add(new Product()
                {
                    Code = "code1",
                    Name = "cn1",
                    NameEn = "en1",
                    Category = "DeskLamp",
                    Pictures = new List<Picture>() {
                    new Picture() { Path = "/Images/1.jpg" },
                    new Picture() { Path = "/Images/2.jpg" }
                }
                });
                db.Product.Add(new Product()
                {
                    Code = "code2",
                    Name = "cn2",
                    NameEn = "en2",
                    Category = "DeskLamp",
                    Pictures = new List<Picture>() {
                    new Picture() { Path = "/Images/3.jpg" },
                    new Picture() { Path = "/Images/4.jpg" }
                }
                });
                db.SaveChanges();
            }

            using (var db = new CamuseHomeContext())
            {
                var tn = new TreeNode();
                tn.Name = "0";
                tn.Text = "类别";
                tvCategory.Nodes.Add(tn);
                var categoryList = db.Category.ToList();
                BindTvCategory(categoryList, tn.Nodes, 0);
            }

            this.lvProduct.GridLines = true; //显示表格线
            this.lvProduct.View = View.Details;//显示表格细节
            this.lvProduct.LabelEdit = false; //是否可编辑,ListView只可编辑第一列。
            this.lvProduct.Scrollable = true;//有滚动条
            this.lvProduct.HeaderStyle = ColumnHeaderStyle.Clickable;//对表头进行设置
            this.lvProduct.FullRowSelect = true;//是否可以选择行
            //添加表头
            this.lvProduct.Columns.Add("序号", 50, HorizontalAlignment.Center);
            this.lvProduct.Columns.Add("名称", 80);
            this.lvProduct.Columns.Add("英文名称", 80);
            this.lvProduct.Columns.Add("图片", 80);
            tvCategory.ExpandAll();
        }

        /// <summary>
        /// 绑定TreeView（利用TreeNodeCollection）
        /// </summary>
        private void BindTvCategory(List<Category> categorys, TreeNodeCollection tnc, long pid)
        {
            TreeNode tn;
            var subCategorys = categorys.Where(i => i.ParentId == pid);
            foreach (var item in subCategorys)
            {
                tn = new TreeNode();
                tn.Name = item.Code.ToString();
                tn.Text = item.Name.ToString();
                tnc.Add(tn);
                BindTvCategory(categorys, tn.Nodes, item.Id);
            }
        }

        private void tvCategory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            using (var db = new CamuseHomeContext())
            {
                var products = db.Product.Include("Pictures").Where(i => i.Category == e.Node.Name).ToList();
                var index = 1;
                var listViewItemList = from i in products
                                       select new ListViewItem(new string[] {
                                           index++.ToString(),
                                           i.Name,
                                           i.NameEn,
                                           string.Join(",", i.Pictures.Select(p => p.Path))
                                       });


                this.lvProduct.Items.Clear();
                this.lvProduct.Items.AddRange(listViewItemList.ToArray());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("add");
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            MessageBox.Show("modify");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //http://www.easyicon.net/iconsearch/iconset:bitsies-icons/
            MessageBox.Show("delete");
        }
    }
}
