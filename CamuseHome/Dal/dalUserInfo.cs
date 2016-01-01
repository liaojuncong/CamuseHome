using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamuseHome
{
    public class dalUserInfo
    {
        public static modUserInfo modUserInfo = null;

        public DataTable getUserInfoList()
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append(" select * from UserInfo ");
            strsql.Append(" order by Id ");
            return Sqlite.ExecuteDataTable(strsql.ToString());
        }

        public modUserInfo getUserInfo(int Id)
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append(" select * from UserInfo where Id=" + Id);
            modUserInfo modUserInfo = new modUserInfo();
            using (DataTable dt = Sqlite.ExecuteDataTable(strsql.ToString()))
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    modUserInfo.Id = Convert.ToInt32(dr["Id"]);
                    modUserInfo.Code = Convert.ToInt32(dr["Code"]);
                    modUserInfo.Name = dr["Name"].ToString();
                    modUserInfo.Pwd = dr["Pwd"].ToString();
                    modUserInfo.InputData = Convert.ToBoolean(dr["InputData"]);
                    modUserInfo.ModifyData = Convert.ToBoolean(dr["ModifyData"]);
                    modUserInfo.DeleteData = Convert.ToBoolean(dr["DeleteData"]);
                    modUserInfo.AuditData = Convert.ToBoolean(dr["AuditData"]);
                    modUserInfo.AbandonData = Convert.ToBoolean(dr["AbandonData"]);
                    modUserInfo.SetParam = Convert.ToBoolean(dr["SetParam"]);
                    modUserInfo.ExportData = Convert.ToBoolean(dr["ExportData"]);
                    modUserInfo.Print = Convert.ToBoolean(dr["Print"]);
                    modUserInfo.LookCost = Convert.ToBoolean(dr["LookCost"]);
                    modUserInfo.LookPrice = Convert.ToBoolean(dr["LookPrice"]);
                }
            }
            return modUserInfo;
        }

        public modUserInfo getUserInfo(int Code, string Pwd)
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append(" select * from UserInfo where Pwd='" + Pwd + "' and Code=" + Code + "");
            modUserInfo modUserInfo = new modUserInfo();
            using (DataTable dt = Sqlite.ExecuteDataTable(strsql.ToString()))
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    modUserInfo.Id = Convert.ToInt32(dr["Id"]);
                    modUserInfo.Code = Convert.ToInt32(dr["Code"]);
                    modUserInfo.Name = dr["Name"].ToString();
                    modUserInfo.Pwd = dr["Pwd"].ToString();
                    modUserInfo.InputData = Convert.ToBoolean(dr["InputData"]);
                    modUserInfo.ModifyData = Convert.ToBoolean(dr["ModifyData"]);
                    modUserInfo.DeleteData = Convert.ToBoolean(dr["DeleteData"]);
                    modUserInfo.AuditData = Convert.ToBoolean(dr["AuditData"]);
                    modUserInfo.AbandonData = Convert.ToBoolean(dr["AbandonData"]);
                    modUserInfo.SetParam = Convert.ToBoolean(dr["SetParam"]);
                    modUserInfo.ExportData = Convert.ToBoolean(dr["ExportData"]);
                    modUserInfo.Print = Convert.ToBoolean(dr["Print"]);
                    modUserInfo.LookCost = Convert.ToBoolean(dr["LookCost"]);
                    modUserInfo.LookPrice = Convert.ToBoolean(dr["LookPrice"]);
                }
            }
            return modUserInfo;
        }

        public int addUserInfo(modUserInfo modUserInfo)
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append(" insert into UserInfo(Id,Code,Name,Pwd,InputData,ModifyData,DeleteData,AuditData,AbandonData,SetParam,");
            strsql.Append("ExportData,Print,LookCost,LookPrice)values(" + modUserInfo.Id + "," + modUserInfo.Code + ",'" + modUserInfo.Name);
            strsql.Append("','" + modUserInfo.Pwd + "'," + (modUserInfo.InputData ? 1 : 0) + "," + (modUserInfo.ModifyData ? 1 : 0));
            strsql.Append("," + (modUserInfo.DeleteData ? 1 : 0) + "," + (modUserInfo.AuditData ? 1 : 0) + "," + (modUserInfo.AbandonData ? 1 : 0));
            strsql.Append("," + (modUserInfo.SetParam ? 1 : 0) + "," + (modUserInfo.ExportData ? 1 : 0) + "," + (modUserInfo.Print ? 1 : 0));
            strsql.Append("," + (modUserInfo.LookCost ? 1 : 0) + "," + (modUserInfo.LookPrice ? 1 : 0) + ") ");
            return Sqlite.ExecuteNonQuery(strsql.ToString());
        }

        public int updateUserInfo(modUserInfo modUserInfo)
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append(" update UserInfo set Code=" + modUserInfo.Code
                + ",Name='" + modUserInfo.Name
                + "',Pwd='" + modUserInfo.Pwd
                + "',InputData=" + (modUserInfo.InputData ? 1 : 0)
                + ",ModifyData=" + (modUserInfo.ModifyData ? 1 : 0)
                + ",DeleteData=" + (modUserInfo.DeleteData ? 1 : 0)
                + ",AuditData=" + (modUserInfo.AuditData ? 1 : 0)
                + ",AbandonData=" + (modUserInfo.AbandonData ? 1 : 0)
                + ",SetParam=" + (modUserInfo.SetParam ? 1 : 0)
                + ",ExportData=" + (modUserInfo.ExportData ? 1 : 0)
                + ",Print=" + (modUserInfo.Print ? 1 : 0)
                + ",LookPrice=" + (modUserInfo.LookPrice ? 1 : 0));
            strsql.Append(" where ID=" + modUserInfo.Id);
            return Sqlite.ExecuteNonQuery(strsql.ToString());
        }

        public int deleteUserInfo(int Id)
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append(" delete from UserInfo where Id=" + Id);
            return Sqlite.ExecuteNonQuery(strsql.ToString());
        }
    }
}
