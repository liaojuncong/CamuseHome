using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamuseHome
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            var frm = new LoginForm();
            DialogResult dir = frm.ShowDialog();
            if (dir == DialogResult.OK)
            {
                Application.Run(new MDIForm());
            }
        }
    }
}
