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
        public PrintForm()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            var reportPath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Reports", "10幅横向简单画册.frx");
            report.Load(reportPath);
            report.SetParameterValue("Company_CName", "11");
            report.SetParameterValue("Company_EName", "22");
            report.SetParameterValue("Company_CAddress", "33");
            report.SetParameterValue("Company_EAddress", "44");
            report.SetParameterValue("Company_Tel", "55");
            report.SetParameterValue("Company_Fax", "66");
            report.SetParameterValue("Company_Email", "77");
            report.SetParameterValue("UserNo", "88");
            report.SetParameterValue("UserName", "99");

            var FArray = new List<dynamic>();
            FArray.Add(new { Prd_Pic1 = "", Prd_CName = "Prd_CName", Prd_GG = "Prd_GG", Prd_Note = "Prd_Note", Prd_ItemNo = "Prd_ItemNo" });
            FArray.Add(new { Prd_Pic1 = "", Prd_CName = "Prd_CName", Prd_GG = "Prd_GG", Prd_Note = "Prd_Note", Prd_ItemNo = "Prd_ItemNo" });
            FArray.Add(new { Prd_Pic1 = "", Prd_CName = "Prd_CName", Prd_GG = "Prd_GG", Prd_Note = "Prd_Note", Prd_ItemNo = "Prd_ItemNo" });
            FArray.Add(new { Prd_Pic1 = "", Prd_CName = "Prd_CName", Prd_GG = "Prd_GG", Prd_Note = "Prd_Note", Prd_ItemNo = "Prd_ItemNo" });
            FArray.Add(new { Prd_Pic1 = "", Prd_CName = "Prd_CName", Prd_GG = "Prd_GG", Prd_Note = "Prd_Note", Prd_ItemNo = "Prd_ItemNo" });
            FArray.Add(new { Prd_Pic1 = "", Prd_CName = "Prd_CName", Prd_GG = "Prd_GG", Prd_Note = "Prd_Note", Prd_ItemNo = "Prd_ItemNo" });
            FArray.Add(new { Prd_Pic1 = "", Prd_CName = "Prd_CName", Prd_GG = "Prd_GG", Prd_Note = "Prd_Note", Prd_ItemNo = "Prd_ItemNo" });
            FArray.Add(new { Prd_Pic1 = "", Prd_CName = "Prd_CName", Prd_GG = "Prd_GG", Prd_Note = "Prd_Note", Prd_ItemNo = "Prd_ItemNo" });
            FArray.Add(new { Prd_Pic1 = "", Prd_CName = "Prd_CName", Prd_GG = "Prd_GG", Prd_Note = "Prd_Note", Prd_ItemNo = "Prd_ItemNo" });
            FArray.Add(new { Prd_Pic1 = "", Prd_CName = "Prd_CName", Prd_GG = "Prd_GG", Prd_Note = "Prd_Note", Prd_ItemNo = "Prd_ItemNo" });
            report.RegisterData(FArray, "DstRpt");

            report.Show();
        }
    }
}
