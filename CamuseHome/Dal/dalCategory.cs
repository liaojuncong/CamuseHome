using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamuseHome
{
    public class dalCategory
    {
        public List<modCategory> getCategoryList()
        {
            List<modCategory> list = new List<modCategory>();
            using (DataTable dt = this.getCategoryDataTable())
            {
                foreach (DataRow dr in dt.Rows)
                {
                    modCategory modCategory = new modCategory();
                    modCategory.Id = Convert.ToInt32(dr["Id"]);
                    modCategory.Name = dr["Name"].ToString();
                    modCategory.ParentId = Convert.ToInt32(dr["ParentId"]);
                    list.Add(modCategory);
                }
            }
            return list;
        }

        public DataTable getCategoryDataTable()
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append(" select * from Category ");
            strsql.Append(" order by ParentId,Id ");
            return Sqlite.ExecuteDataTable(strsql.ToString());
        }

        public modCategory getCategory(int Id)
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append(" select * from Category where Id=" + Id);
            modCategory modCategory = new modCategory();
            using (DataTable dt = Sqlite.ExecuteDataTable(strsql.ToString()))
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    modCategory.Id = Convert.ToInt32(dr["Id"]);
                    modCategory.Name = dr["Name"].ToString();
                    modCategory.ParentId = Convert.ToInt32(dr["ParentId"]);
                }
            }
            return modCategory;
        }

        public int addCategory(modCategory modCategory)
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append(" insert into Category(Name,ParentId)values(");
            strsql.Append("'" + modCategory.Name + "'," + modCategory.ParentId + ") ");
            return Sqlite.ExecuteNonQuery(strsql.ToString());
        }

        public int updateCategory(modCategory modCategory)
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append(" update Category set Name='" + modCategory.Name
                + "',ParentId=" + modCategory.ParentId);
            strsql.Append(" where ID=" + modCategory.Id);
            return Sqlite.ExecuteNonQuery(strsql.ToString());
        }

        public int deleteCategory(int Id)
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append(" delete from Category where Id=" + Id);
            return Sqlite.ExecuteNonQuery(strsql.ToString());
        }
    }
}
