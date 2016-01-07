using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamuseHome
{
    public class dalProduct
    {
        public List<modProduct> getProductList(modProduct Product, string keyWord)
        {
            List<modProduct> list = new List<modProduct>();
            using (DataTable dt = this.getProductDataTable(Product, keyWord))
            {
                foreach (DataRow dr in dt.Rows)
                {
                    modProduct modProduct = new modProduct();
                    modProduct.Id = Convert.ToInt32(dr["Id"]);
                    modProduct.Code = dr["Code"].ToString();
                    modProduct.Name = dr["Name"].ToString();
                    modProduct.LampShadeSize = dr["LampShadeSize"].ToString();
                    modProduct.LampBodySize = dr["LampBodySize"].ToString();
                    modProduct.LampSize = dr["LampSize"].ToString();
                    modProduct.Price = Convert.ToDouble(dr["Price"]);
                    modProduct.Cost = Convert.ToDouble(dr["Cost"]);
                    modProduct.LampShadeColor = dr["LampShadeColor"].ToString();
                    modProduct.LampBodyColor = dr["LampBodyColor"].ToString();
                    modProduct.Craft = dr["Craft"].ToString();
                    modProduct.LampBodyMaterial = dr["LampBodyMaterial"].ToString();
                    modProduct.ClothPlateCode = dr["ClothPlateCode"].ToString();
                    modProduct.ColorPlateCode = dr["ColorPlateCode"].ToString();
                    modProduct.CategoryId = Convert.ToInt32(dr["CategoryId"]);
                    modProduct.Style = dr["Style"].ToString();
                    modProduct.PackingWay = dr["PackingWay"].ToString();
                    modProduct.CartonPackingSize = dr["CartonPackingSize"].ToString();
                    modProduct.Inventory = dr["Inventory"].ToString();
                    modProduct.Remark = dr["Remark"].ToString();
                    modProduct.AuditState = Convert.ToBoolean(dr["AuditState"]);
                    list.Add(modProduct);
                }
            }
            return list;
        }

        public DataTable getProductDataTable(modProduct modProduct, string keyWord)
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append(" select * from Product where 1=1 ");
            if (keyWord != null && keyWord != "")
            {
                strsql.Append(" and (Code like '%" + keyWord + "%' or Name like '%" + keyWord + "%' or LampShadeColor like '%" + keyWord + "%'");
                strsql.Append(" or LampBodyColor like '%" + keyWord + "%' or LampBodyMaterial like '%" + keyWord + "%' or Craft like '%" + keyWord + "%'");
                strsql.Append(" or ClothPlateCode like '%" + keyWord + "%' or ColorPlateCode like '%" + keyWord + "%' or Style like '%" + keyWord + "%' or Remark like '%" + keyWord + "%') ");
            }
            if (modProduct.Code != null && modProduct.Code != "")
            {
                strsql.Append(" and Code like '%" + modProduct.Code + "%' ");
            }
            if (modProduct.Name != null && modProduct.Name != "")
            {
                strsql.Append(" and Name like '%" + modProduct.Name + "%' ");
            }
            if (modProduct.LampShadeColor != null && modProduct.LampShadeColor != "")
            {
                strsql.Append(" and LampShadeColor like '%" + modProduct.LampShadeColor + "%' ");
            }
            if (modProduct.LampBodyColor != null && modProduct.LampBodyColor != "")
            {
                strsql.Append(" and LampBodyColor like '%" + modProduct.LampBodyColor + "%' ");
            }
            if (modProduct.LampBodyMaterial != null && modProduct.LampBodyMaterial != "")
            {
                strsql.Append(" and LampBodyMaterial like '%" + modProduct.LampBodyMaterial + "%' ");
            }
            if (modProduct.Craft != null && modProduct.Craft != "")
            {
                strsql.Append(" and Craft like '%" + modProduct.Craft + "%' ");
            }
            if (modProduct.ClothPlateCode != null && modProduct.ClothPlateCode != "")
            {
                strsql.Append(" and ClothPlateCode like '%" + modProduct.ClothPlateCode + "%' ");
            }
            if (modProduct.CategoryId != null && modProduct.CategoryId != 0)
            {
                strsql.Append(" and CategoryId = " + modProduct.CategoryId + " ");
            }
            if (modProduct.ColorPlateCode != null && modProduct.ColorPlateCode != "")
            {
                strsql.Append(" and ColorPlateCode like '%" + modProduct.ColorPlateCode + "%' ");
            }
            if (modProduct.Style != null && modProduct.Style != "")
            {
                strsql.Append(" and Style like '%" + modProduct.Style + "%' ");
            }
            if (modProduct.Remark != null && modProduct.Remark != "")
            {
                strsql.Append(" and Remark like '%" + modProduct.Remark + "%' ");
            }
            strsql.Append(" order by Id ");
            return Sqlite.ExecuteDataTable(strsql.ToString());
        }

        public modProduct getProduct(int Id)
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append(" select * from Product where Id=" + Id);
            modProduct modProduct = new modProduct();
            using (DataTable dt = Sqlite.ExecuteDataTable(strsql.ToString()))
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    modProduct.Id = Convert.ToInt32(dr["Id"]);
                    modProduct.Code = dr["Code"].ToString();
                    modProduct.Name = dr["Name"].ToString();
                    modProduct.LampShadeSize = dr["LampShadeSize"].ToString();
                    modProduct.LampBodySize = dr["LampBodySize"].ToString();
                    modProduct.LampSize = dr["LampSize"].ToString();
                    modProduct.Price = Convert.ToDouble(dr["Price"]);
                    modProduct.Cost = Convert.ToDouble(dr["Cost"]);
                    modProduct.LampShadeColor = dr["LampShadeColor"].ToString();
                    modProduct.LampBodyColor = dr["LampBodyColor"].ToString();
                    modProduct.Craft = dr["Craft"].ToString();
                    modProduct.LampBodyMaterial = dr["LampBodyMaterial"].ToString();
                    modProduct.ClothPlateCode = dr["ClothPlateCode"].ToString();
                    modProduct.ColorPlateCode = dr["ColorPlateCode"].ToString();
                    modProduct.CategoryId = Convert.ToInt32(dr["CategoryId"]);
                    modProduct.Style = dr["Style"].ToString();
                    modProduct.PackingWay = dr["PackingWay"].ToString();
                    modProduct.CartonPackingSize = dr["CartonPackingSize"].ToString();
                    modProduct.Inventory = dr["Inventory"].ToString();
                    modProduct.Remark = dr["Remark"].ToString();
                    modProduct.AuditState = Convert.ToBoolean(dr["AuditState"]);
                }
            }
            return modProduct;
        }

        public int addProduct(modProduct modProduct)
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append(" insert into Product(Code,Name,LampShadeSize,LampBodySize,LampSize,Price,Cost,LampShadeColor,LampBodyColor,Craft,");
            strsql.Append("LampBodyMaterial,ClothPlateCode,ColorPlateCode,CategoryId,Style,PackingWay,CartonPackingSize,Inventory,Remark,AuditState)values('");
            strsql.Append(modProduct.Code + "','" + modProduct.Name + "','" + modProduct.LampShadeSize + "','" + modProduct.LampBodySize + "','");
            strsql.Append(modProduct.LampSize + "'," + modProduct.Price + "," + modProduct.Cost + ",'" + modProduct.LampShadeColor + "','");
            strsql.Append(modProduct.LampBodyColor + "','" + modProduct.Craft + "','" + modProduct.LampBodyMaterial + "','" + modProduct.ClothPlateCode + "','" + modProduct.ColorPlateCode + "',");
            strsql.Append(modProduct.CategoryId + ",'" + modProduct.Style + "','" + modProduct.PackingWay + "','" + modProduct.CartonPackingSize + "','");
            strsql.Append(modProduct.Inventory + "','" + modProduct.Remark + "'," + (modProduct.AuditState ? "1" : "0") + ") ");
            return Sqlite.ExecuteNonQuery(strsql.ToString());
        }

        public int updateProduct(modProduct modProduct)
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append(" update Product set Code='" + modProduct.Code
                + "',Name='" + modProduct.Name
                + "',LampShadeSize='" + modProduct.LampShadeSize
                + "',LampBodySize='" + modProduct.LampBodySize
                + "',LampSize='" + modProduct.LampSize
                + "',Price=" + modProduct.Price
                + ",Cost=" + modProduct.Cost
                + ",LampShadeColor='" + modProduct.LampShadeColor
                + "',LampBodyColor='" + modProduct.LampBodyColor
                + "',Craft='" + modProduct.Craft
                + "',LampBodyMaterial='" + modProduct.LampBodyMaterial
                + "',ClothPlateCode='" + modProduct.ClothPlateCode
                + "',ColorPlateCode='" + modProduct.ColorPlateCode
                + "',CategoryId=" + modProduct.CategoryId
                + ",Style='" + modProduct.Style
                + "',PackingWay='" + modProduct.PackingWay
                + "',CartonPackingSize='" + modProduct.CartonPackingSize
                + "',Remark='" + modProduct.Remark
                + "',AuditState=" + (modProduct.AuditState ? "1" : "0"));
            strsql.Append(" where Id=" + modProduct.Id);
            return Sqlite.ExecuteNonQuery(strsql.ToString());
        }

        public int deleteProduct(int Id)
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append(" delete from Product where Id=" + Id);
            return Sqlite.ExecuteNonQuery(strsql.ToString());
        }
    }
}
