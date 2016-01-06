using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamuseHome
{
    public class dalPicture
    {
        public List<modPicture> getPictureList(int ProductId)
        {
            List<modPicture> list = new List<modPicture>();
            using (DataTable dt = this.getPictureDataTable(ProductId))
            {
                foreach (DataRow dr in dt.Rows)
                {
                    modPicture modPicture = new modPicture();
                    modPicture.Id = Convert.ToInt32(dr["Id"]);
                    modPicture.Name = dr["Name"].ToString();
                    modPicture.Path = dr["Path"].ToString();
                    modPicture.Remark = dr["Remark"].ToString();
                    modPicture.ProductId = Convert.ToInt32(dr["ProductId"]);
                    list.Add(modPicture);
                }
                return list;
            }
        }

        public DataTable getPictureDataTable(int ProductId)
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append(" select * from Picture where ProductId=" + ProductId);
            strsql.Append(" order by Id ");
            return Sqlite.ExecuteDataTable(strsql.ToString());
        }

        public modPicture getPicture(int Id)
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append(" select * from Picture where Id=" + Id);
            modPicture modPicture = new modPicture();
            using (DataTable dt = Sqlite.ExecuteDataTable(strsql.ToString()))
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    modPicture.Id = Convert.ToInt32(dr["Id"]);
                    modPicture.Name = dr["Name"].ToString();
                    modPicture.Path = dr["Path"].ToString();
                    modPicture.Remark = dr["Remark"].ToString();
                    modPicture.ProductId = Convert.ToInt32(dr["ProductId"]);
                }
            }
            return modPicture;
        }

        public int addPicture(modPicture modPicture)
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append(" insert into Picture(Name,Path,Remark,ProductId)values('");
            strsql.Append(modPicture.Name + "','" + modPicture.Path + "','" + modPicture.Remark + "'," + modPicture.ProductId + ") ");
            return Sqlite.ExecuteNonQuery(strsql.ToString());
        }

        public int updatePicture(modPicture modPicture)
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append(" update Picture set Name='" + modPicture.Name
                + "',Path='" + modPicture.Path
                + "',Remark='" + modPicture.Remark
                + "',ProductId=" + modPicture.ProductId);
            strsql.Append(" where Id=" + modPicture.Id);
            return Sqlite.ExecuteNonQuery(strsql.ToString());
        }

        public int updatePicture(int ProductId)
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append(" update Picture set ProductId=" + ProductId);
            strsql.Append(" where ProductId=0 ");
            return Sqlite.ExecuteNonQuery(strsql.ToString());
        }

        public int deletePicture(int Id)
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append(" delete from Picture where Id=" + Id);
            return Sqlite.ExecuteNonQuery(strsql.ToString());
        }

        public int deletePictures(int ProductId)
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append(" delete from Picture where ProductId=" + ProductId);
            return Sqlite.ExecuteNonQuery(strsql.ToString());
        }
    }
}
