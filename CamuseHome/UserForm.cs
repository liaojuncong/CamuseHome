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
    public partial class UserForm : Form
    {
        private string BeginValue = "";
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            this.loadDataGridView1();
        }

        public void loadDataGridView1()
        {
            this.dataGridView1.DataSource = new dalUserInfo().getUserInfoList();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Code"].HeaderText = "编号";
            dataGridView1.Columns["Code"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Code"].ReadOnly = true;
            dataGridView1.Columns["Name"].HeaderText = "姓名";
            dataGridView1.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Pwd"].Visible = false;
            dataGridView1.Columns["InputData"].HeaderText = "录入资料";
            dataGridView1.Columns["InputData"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["InputData"].Width = 40;
            //dataGridView1.Columns["InputData"].ValueType = typeof(System.Boolean);//DataGridViewColumn.ValueType
            //dataGridView1.Columns["InputData"].DefaultHeaderCellType = typeof(System.Windows.Forms.DataGridViewCheckBoxCell);
            //{Name = "DataGridViewColumnHeaderCell" FullName = "System.Windows.Forms.DataGridViewColumnHeaderCell"}
            dataGridView1.Columns["ModifyData"].HeaderText = "修改资料";
            dataGridView1.Columns["ModifyData"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["ModifyData"].Width = 40;
            dataGridView1.Columns["DeleteData"].HeaderText = "删除资料";
            dataGridView1.Columns["DeleteData"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["DeleteData"].Width = 40;
            dataGridView1.Columns["AuditData"].HeaderText = "审核资料";
            dataGridView1.Columns["AuditData"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["AuditData"].Width = 40;
            dataGridView1.Columns["AbandonData"].HeaderText = "弃审资料";
            dataGridView1.Columns["AbandonData"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["AbandonData"].Width = 40;
            dataGridView1.Columns["SetParam"].HeaderText = "设置参数";
            dataGridView1.Columns["SetParam"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["SetParam"].Width = 40;
            dataGridView1.Columns["ExportData"].HeaderText = "导出数据";
            dataGridView1.Columns["ExportData"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["ExportData"].Width = 40;
            dataGridView1.Columns["Print"].HeaderText = "打印";
            dataGridView1.Columns["Print"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["Print"].Width = 40;
            dataGridView1.Columns["LookCost"].HeaderText = "查看成本";
            dataGridView1.Columns["LookCost"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["LookCost"].Width = 40;
            dataGridView1.Columns["LookPrice"].HeaderText = "查看价格";
            dataGridView1.Columns["LookPrice"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["LookPrice"].Width = 40;
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            BeginValue = ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            string EndValue = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (EndValue != BeginValue)
            {
                modUserInfo modUserInfo = new modUserInfo();
                modUserInfo.Id = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
                modUserInfo.Code = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[1].Value.ToString());
                modUserInfo.Name = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                modUserInfo.Pwd = dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
                modUserInfo.InputData = Convert.ToBoolean(dgv.Rows[e.RowIndex].Cells[4].Value.ToString() == "0" ? "False" : "True");
                modUserInfo.ModifyData = Convert.ToBoolean(dgv.Rows[e.RowIndex].Cells[5].Value.ToString() == "0" ? "False" : "True");
                modUserInfo.DeleteData = Convert.ToBoolean(dgv.Rows[e.RowIndex].Cells[6].Value.ToString() == "0" ? "False" : "True");
                modUserInfo.AuditData = Convert.ToBoolean(dgv.Rows[e.RowIndex].Cells[7].Value.ToString() == "0" ? "False" : "True");
                modUserInfo.AbandonData = Convert.ToBoolean(dgv.Rows[e.RowIndex].Cells[8].Value.ToString() == "0" ? "False" : "True");
                modUserInfo.SetParam = Convert.ToBoolean(dgv.Rows[e.RowIndex].Cells[9].Value.ToString() == "0" ? "False" : "True");
                modUserInfo.ExportData = Convert.ToBoolean(dgv.Rows[e.RowIndex].Cells[10].Value.ToString() == "0" ? "False" : "True");
                modUserInfo.Print = Convert.ToBoolean(dgv.Rows[e.RowIndex].Cells[11].Value.ToString() == "0" ? "False" : "True");
                modUserInfo.LookCost = Convert.ToBoolean(dgv.Rows[e.RowIndex].Cells[12].Value.ToString() == "0" ? "False" : "True");
                modUserInfo.LookPrice = Convert.ToBoolean(dgv.Rows[e.RowIndex].Cells[13].Value.ToString() == "0" ? "False" : "True");
                int i = new dalUserInfo().updateUserInfo(modUserInfo);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.Owner = this;
            addUserForm.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "确定删除所选记录吗？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow dgvr in this.dataGridView1.SelectedRows)
                {
                    int id = Convert.ToInt32(dgvr.Cells[0].Value.ToString());
                    if (id != 1 && id != dalUserInfo.modUserInfo.Id)
                    {
                        new dalUserInfo().deleteUserInfo(id);
                    }
                }
                this.loadDataGridView1();
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "确定重置所选记录的密码为123456吗？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow dgvr in this.dataGridView1.SelectedRows)
                {
                    int id = Convert.ToInt32(dgvr.Cells[0].Value.ToString());
                    if (id != 1)
                    {
                        modUserInfo modUserInfo = new dalUserInfo().getUserInfo(id);
                        modUserInfo.Pwd = AesHelper.AESEncrypt("123456", "LiaoJunWu526");
                        int i = new dalUserInfo().updateUserInfo(modUserInfo);
                        if (i > 0 && id == dalUserInfo.modUserInfo.Id)
                        {
                            dalUserInfo.modUserInfo = modUserInfo;
                        }
                    }
                }
                this.loadDataGridView1();
            }
        }
    }
}
