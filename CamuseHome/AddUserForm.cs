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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (this.CodeTextBox.Text.Trim() == "")
            {
                this.ShowMessage("编号不能为空...");
            }
            else if (this.NameTextBox.Text.Trim() == "")
            {
                this.ShowMessage("姓名不能为空...");
            }
            else if (this.PwdTextBox.Text.Trim() == "")
            {
                this.ShowMessage("密码不能为空...");
            }
            else
            {
                try
                {
                    modUserInfo modUserInfo = new modUserInfo();
                    modUserInfo.Code = Convert.ToInt32(this.CodeTextBox.Text.Trim());
                    modUserInfo.Name = this.NameTextBox.Text.Trim();
                    modUserInfo.Pwd = AesHelper.AESEncrypt(this.PwdTextBox.Text.Trim(), "LiaoJunWu526");
                    int i = new dalUserInfo().addUserInfo(modUserInfo);
                    if (i > 0)
                    {
                        this.ShowMessage("增加成功...");
                        UserForm userForm = (UserForm)this.Owner;
                        userForm.loadDataGridView1();
                        this.Close();
                    }
                    else
                    {
                        this.ShowMessage("增加失败...");
                    }
                }
                catch (Exception ee)
                {
                    this.ShowMessage(ee.Message);
                }
            }
        }
        private void ShowMessage(string message)
        {
            MessageBox.Show(message, "提示信息");
        }
    }
}
