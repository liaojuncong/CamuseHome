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
    public partial class SetParamForm : Form
    {
        public SetParamForm()
        {
            InitializeComponent();
        }

        private void SetParamForm_Load(object sender, EventArgs e)
        {
            modEnterpriseInfo modEnterpriseInfo = new dalEnterpriseInfo().getEnterpriseInfo();
            this.txtbCnName.Text = modEnterpriseInfo.CnName;
            this.txtbEnName.Text = modEnterpriseInfo.EnName;
            this.txtbCnAddress.Text = modEnterpriseInfo.CnAddress;
            this.txtbEnAddress.Text = modEnterpriseInfo.EnAddress;
            this.txtbTelephone.Text = modEnterpriseInfo.Telephone;
            this.txtbFax.Text = modEnterpriseInfo.Fax;
            this.txtbUrl.Text = modEnterpriseInfo.Url;
            this.txtbEmail.Text = modEnterpriseInfo.Email;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            modEnterpriseInfo modEnterpriseInfo = new modEnterpriseInfo();
            modEnterpriseInfo.CnName = this.txtbCnName.Text.Trim();
            modEnterpriseInfo.EnName = this.txtbEnName.Text.Trim();
            modEnterpriseInfo.CnAddress = this.txtbCnAddress.Text.Trim();
            modEnterpriseInfo.EnAddress = this.txtbEnAddress.Text.Trim();
            modEnterpriseInfo.Telephone = this.txtbTelephone.Text.Trim();
            modEnterpriseInfo.Fax = this.txtbFax.Text.Trim();
            modEnterpriseInfo.Url = this.txtbUrl.Text.Trim();
            modEnterpriseInfo.Email = this.txtbEmail.Text.Trim();
            int i = new dalEnterpriseInfo().addOrUpdateEnterpriseInfo(modEnterpriseInfo);
            if (i > 0)
            {
                MessageBox.Show("增加成功...", "提示信息");
            }
            else
            {
                MessageBox.Show("增加失败...", "提示信息");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
