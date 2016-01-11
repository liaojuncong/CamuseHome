using CamuseHome.Uilities;
using FastReport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamuseHome
{
    public partial class PrintForm : Form
    {
        List<int> productIds;
        public PrintForm(List<int> productIds)
        {
            InitializeComponent();
            this.productIds = productIds;
            cbReport.Items.Add("10幅横向简单画册.frx");
            cbReport.Items.Add("12A4英文画册.frx");
            cbReport.Items.Add("12A4中文画册.frx");
            cbReport.Items.Add("报价单1幅图.frx");
            cbReport.Items.Add("报价单2幅图.frx");
            cbReport.Items.Add("报价单无图片.frx");
            cbReport.Items.Add("标准3X5报价单.frx");
            cbReport.Items.Add("吊牌1.frx");
            cbReport.Items.Add("条形码小标签＿带价格密码1.frx");
            cbReport.Items.Add("条形码小标签＿带价格密码2.frx");
            cbReport.Items.Add("条形码小标签＿带价格密码3.frx");
            cbReport.Items.Add("条形码小标签1.frx");
            cbReport.Items.Add("条形码小标签2.frx");
            cbReport.Items.Add("小标签1.frx");
            cbReport.Items.Add("样品大标签.frx");
            cbReport.SelectedIndex = 0;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            InitReport(report);
            report.Show();
        }

        private void btnDesign_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            var reportFile = cbReport.SelectedItem.ToString();
            var reportPath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Reports", reportFile);
            report.Load(reportPath);
            report.Design();
        }

        private void InitReport(Report report)
        {
            if (cbReport.SelectedItem == null) return;
            var reportFile = cbReport.SelectedItem.ToString();
            var reportPath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Reports", reportFile);
            report.Load(reportPath);

            using (var db = new CamuseHomeContext())
            {
                var enterpriseInfo = db.EnterpriseInfo.FirstOrDefault();
                if (enterpriseInfo != null)
                {
                    report.SetParameterValue("Company_CName", enterpriseInfo.CnName);
                    report.SetParameterValue("Company_EName", enterpriseInfo.EnName);
                    report.SetParameterValue("Company_CAddress", enterpriseInfo.CnAddress);
                    report.SetParameterValue("Company_EAddress", enterpriseInfo.EnAddress);
                    report.SetParameterValue("Company_Tel", enterpriseInfo.Telephone);
                    report.SetParameterValue("Company_Fax", enterpriseInfo.Fax);
                    report.SetParameterValue("Company_Email", enterpriseInfo.Email);
                }
                else
                {
                    report.SetParameterValue("Company_CName", "卡慕斯家居");
                    report.SetParameterValue("Company_EName", "CamuseHome");
                    report.SetParameterValue("Company_CAddress", "");
                    report.SetParameterValue("Company_EAddress", "");
                    report.SetParameterValue("Company_Tel", "");
                    report.SetParameterValue("Company_Fax", "");
                    report.SetParameterValue("Company_Email", "");
                }
                report.SetParameterValue("UserNo", Global.UserCode);
                report.SetParameterValue("UserName", Global.UserName);

                var productList = db.Product.Include("Pictures").Where(p => productIds.Contains(p.Id)).ToList();
                var ds = new List<dynamic>();
                productList.ForEach(i =>
                {
                    var path = Path.Combine(Application.StartupPath, "Pictures", "Angelababy.jpg");
                    ds.Add(new
                    {
                        Prd_ItemNo = i.Code,
                        Prd_ItemNo1 = "ItemNo1",
                        Prd_ItemNo2 = "ItemNo2",
                        Prd_CName = i.Name,
                        Prd_EName = "EName",
                        Prd_BarCode = "BarCode",
                        Prd_GG = i.LampShadeSize,
                        Prd_GW = "GW",
                        Prd_NG = "NG",
                        Prd_NW = "NW",
                        Price1 = i.Price,
                        Price1100 = i.Price * 100,
                        Prd_L = 0,
                        Prd_W = 0,
                        Prd_H = 0,
                        Prd_Inner = "Inner",
                        Prd_Ctn = "Ctn",
                        Prd_Vol = 0,
                        Prd_EUnit = "Unit",
                        PackingtypeE = "PackingtypeE",
                        MPackingTypeE = "MPackingTypeE",
                        Prd_Note = i.Remark,
                        Prd_Pic1 = Common.GetPicture(path),
                        Prd_Pic2 = Common.GetPicture(path)
                    });
                });
                report.RegisterData(ds, "DstRpt");
            }
        }
    }
}
