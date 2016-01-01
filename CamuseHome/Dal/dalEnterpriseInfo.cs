using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamuseHome
{
    public class dalEnterpriseInfo
    {
        public modEnterpriseInfo getEnterpriseInfo()
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append(" select * from EnterpriseInfo ");
            modEnterpriseInfo modEnterpriseInfo = new modEnterpriseInfo();
            using (DataTable dt = Sqlite.ExecuteDataTable(strsql.ToString()))
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    modEnterpriseInfo.CnName = dr["CnName"].ToString();
                    modEnterpriseInfo.EnName = dr["EnName"].ToString();
                    modEnterpriseInfo.CnAddress = dr["CnAddress"].ToString();
                    modEnterpriseInfo.EnAddress = dr["EnAddress"].ToString();
                    modEnterpriseInfo.Telephone = dr["Telephone"].ToString();
                    modEnterpriseInfo.Fax = dr["Fax"].ToString();
                    modEnterpriseInfo.Url = dr["Url"].ToString();
                    modEnterpriseInfo.Email = dr["Email"].ToString();
                }
            }
            return modEnterpriseInfo;
        }

        public int addOrUpdateEnterpriseInfo(modEnterpriseInfo modEnterpriseInfo)
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append(" select * from EnterpriseInfo ");
            using (DataTable dt = Sqlite.ExecuteDataTable(strsql.ToString()))
            {
                if (dt.Rows.Count > 0)
                {
                    strsql.Clear();
                    strsql.Append(" update EnterpriseInfo set CnName='" + modEnterpriseInfo.CnName
                        + "',EnName='" + modEnterpriseInfo.EnName
                        + "',CnAddress='" + modEnterpriseInfo.CnAddress
                        + "',EnAddress='" + modEnterpriseInfo.EnAddress
                        + "',Telephone='" + modEnterpriseInfo.Telephone
                        + "',Fax='" + modEnterpriseInfo.Fax
                        + "',Url='" + modEnterpriseInfo.Url
                        + "',Email='" + modEnterpriseInfo.Email + "' ");
                    return Sqlite.ExecuteNonQuery(strsql.ToString());
                }
                else
                {
                    strsql.Clear();
                    strsql.Append(" insert into EnterpriseInfo(CnName,EnName,CnAddress,EnAddress,Telephone,Fax,Url,Email)values('");
                    strsql.Append(modEnterpriseInfo.CnName + "','" + modEnterpriseInfo.EnName + "','" + modEnterpriseInfo.CnAddress + "','");
                    strsql.Append(modEnterpriseInfo.EnAddress + "','" + modEnterpriseInfo.Telephone + "','" + modEnterpriseInfo.Fax + "','");
                    strsql.Append(modEnterpriseInfo.Url + "','" + modEnterpriseInfo.Email + "') ");
                    return Sqlite.ExecuteNonQuery(strsql.ToString());
                }
            }
        }
    }
}
