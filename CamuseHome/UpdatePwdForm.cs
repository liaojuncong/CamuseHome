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
    public partial class UpdatePwdForm : Form
    {
        public UpdatePwdForm()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (this.OldPwdTextBox.Text.Trim() == "")
            {
                this.ShowMessage("旧密码不能为空...");
            }
            else if (this.NewPwdTextBox.Text.Trim() == "")
            {
                this.ShowMessage("新密码不能为空...");
            }
            else if (this.ConfirmPwdTextBox.Text.Trim() == "")
            {
                this.ShowMessage("确认密码不能为空...");
            }
            else
            {
                if (this.NewPwdTextBox.Text.Trim() == this.ConfirmPwdTextBox.Text.Trim())
                {
                    if (dalUserInfo.modUserInfo != null && AesHelper.AESEncrypt(this.OldPwdTextBox.Text.Trim(), "LiaoJunWu526") == dalUserInfo.modUserInfo.Pwd)
                    {
                        try
                        {
                            modUserInfo modUserInfo = new dalUserInfo().getUserInfo(dalUserInfo.modUserInfo.Id);
                            modUserInfo.Pwd = AesHelper.AESEncrypt(this.NewPwdTextBox.Text.Trim(), "LiaoJunWu526");
                            int i = new dalUserInfo().updateUserInfo(modUserInfo);
                            if (i > 0)
                            {
                                dalUserInfo.modUserInfo = modUserInfo;
                                this.ShowMessage("修改成功...");
                                this.Close();
                            }
                            else
                            {
                                this.ShowMessage("修改失败...");
                            }
                        }
                        catch (Exception ee)
                        {
                            this.ShowMessage(ee.Message);
                        }
                    }
                    else
                    {
                        this.ShowMessage("旧密码错误...");
                    }
                }
                else
                {
                    this.ShowMessage("新密码和确认密码不一致...");
                }
            }
        }

        private void ShowMessage(string message)
        {
            MessageBox.Show(message, "提示信息");
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
