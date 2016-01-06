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
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (this.btnDetail.Text == "详细")
            {
                this.Size = new Size(475, 335);
                this.btnDetail.Text = "简单";
            }
            else
            {
                this.Size = new Size(475, 90);
                this.btnDetail.Text = "详细";
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {

        }
    }
}
