using CamuseHome.Models;
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
    public partial class CategoryForm : Form
    {
        private int pid;
        private int id;
        public Action<string, string> Action { get; set; }

        public CategoryForm(int pid, int id = 0)
        {
            this.pid = pid;
            this.id = id;
            InitializeComponent();
            if (id > 0)
            {
                using (var db = new CamuseHomeContext())
                {
                    var curCategory = db.Category.Find(id);
                    txtName.Text = curCategory.Name;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new CamuseHomeContext())
            {
                Category cur = null;
                if (id > 0)
                {
                    cur = db.Category.Find(id);
                    cur.Name = txtName.Text;
                }
                else
                {
                    cur = new Category() { ParentId = pid, Name = txtName.Text };
                    db.Category.Add(cur);
                }
                db.SaveChanges();
                if (Action != null)
                    Action(cur.Id.ToString(), cur.Name);
            }
            this.Close();
        }

        private void btnCancal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
