using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Configuration;
using CamuseHome.Uilities;

namespace CamuseHome
{
    public partial class LoginForm : Form
    {

        string path = Application.StartupPath;
        
        public LoginForm()
        {
            InitializeComponent();

            this.checkBox1.BackColor = Color.Transparent;
        }
   
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Login();
        }

        private void Login()
        {
            string userCode = this.txtUserCode.Text;
            string password = this.txtPwd.Text;

            if (userCode == "" || Regex.IsMatch(userCode, @"\W"))
            {
                this.lblMsg.ForeColor = Color.Red;
                this.lblMsg.Text = "用户不合法";
            }
            else if (password == "")
            {
                this.lblMsg.ForeColor = Color.Red;
                this.lblMsg.Text = "密码必需输入";
            }
            else
            {
                if (true)
                {
                    this.RememberLoginInfo(this.checkBox1.Checked);
                    //MessageBox.Show(resultModel.message);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("123");
                }
            }
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {
            string signUserPwd = GetAppConfig("signUserPwd");

            if (signUserPwd == null || signUserPwd == "")
            {
                this.txtUserCode.Text = "";
                this.txtPwd.Text = "";
                this.checkBox1.Checked = false;
            }
            else
            {
                this.txtUserCode.Text = GetAppConfig("userCode");
                if(GetAppConfig("passWord") != "")
                {
                    this.txtPwd.Text = DESCode.DecryptDES(GetAppConfig("passWord"));
                }
                
                this.checkBox1.Checked = true;                
            }          
        }

        private void txtUserCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Login();
            }

        }

        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Login();
            }
        }


        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// 记住登陆用户帐号与密码
        /// </summary>
        /// <param name="flag">是否记住</param>
        private void RememberLoginInfo(bool flag)
        {
            if (flag==true)
            {
                UpdateAppConfig("signUserPwd", "Y");
                UpdateAppConfig("userCode", this.txtUserCode.Text );
                UpdateAppConfig("passWord", DESCode.EncryptDES(this.txtPwd.Text)); 
                ////写入数据到配置文件
                //System.IO.StreamWriter sw= new System.IO.StreamWriter(path);
                //sw.WriteLine(this.txtUserCode.Text);
                //sw.WriteLine(SiBu.DecryptFrm.DESCode.EncryptDES(this.txtPwd.Text));
                //sw.Close();
            }
            else
            {
                UpdateAppConfig("signUserPwd", "");
                UpdateAppConfig("userCode", "");
                UpdateAppConfig("passWord", "");
            }
        }


        ///<summary> 
        ///返回*.exe.config文件中appSettings配置节的value项  
        ///</summary> 
        ///<param name="strKey"></param> 
        ///<returns></returns> 
        public string GetAppConfig(string strKey)
        {
            string file = System.Windows.Forms.Application.ExecutablePath;
            Configuration config = ConfigurationManager.OpenExeConfiguration(file);
            foreach (string key in config.AppSettings.Settings.AllKeys)
            {
                if (key == strKey)
                {
                    return config.AppSettings.Settings[strKey].Value.ToString();
                }
            }
            return null;
        }

        ///<summary>  
        ///在*.exe.config文件中appSettings配置节增加一对键值对  
        ///</summary>  
        ///<param name="newKey"></param>  
        ///<param name="newValue"></param>  
        public void UpdateAppConfig(string newKey, string newValue)
        {
            string file = System.Windows.Forms.Application.ExecutablePath;
            Configuration config = ConfigurationManager.OpenExeConfiguration(file);
            bool exist = false;
            foreach (string key in config.AppSettings.Settings.AllKeys)
            {
                if (key == newKey)
                {
                    exist = true;
                }
            }
            if (exist)
            {
                config.AppSettings.Settings.Remove(newKey);
            }
            config.AppSettings.Settings.Add(newKey, newValue);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
