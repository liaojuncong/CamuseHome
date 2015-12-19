using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamuseHome.Models
{
    public class Product
    {
        public Product()
        {
            Pictures = new List<Picture>();
        }
        public long Id { get; set; }
        /// <summary>
        /// 货号
        /// </summary>
        public string ItemNo { get; set; }
        /// <summary>
        /// 产品编号
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 中文名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 英文名称
        /// </summary>
        public string EN { get; set; }
        /// <summary>
        /// 客户货号
        /// </summary>
        public string CustomerItemNo { get; set; }
        /// <summary>
        /// 厂商货号
        /// </summary>
        public string SupplierItemNo { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 套数
        /// </summary>
        public int Sets { get; set; }
        /// <summary>
        /// 容量
        /// </summary>
        public float Capacity { get; set; }
        /// <summary>
        /// 类别
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// 颜色
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// 材质
        /// </summary>
        public string Material { get; set; }
        /// <summary>
        /// 风格系列
        /// </summary>
        public string Style { get; set; }
        /// <summary>
        /// 毛重
        /// </summary>
        public float Weight { get; set; }
        /// <summary>
        /// 总成本
        /// </summary>
        public float Cost { get; set; }
        /// <summary>
        /// 规格
        /// </summary>
        public string Specification { get; set; }
        /// <summary>
        /// 成本备注
        /// </summary>
        public string CostRemark { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        //public virtual ICollection<Specification> Specifications { get; set; }
        //public virtual ICollection<Cost> Costs { get; set; }
        //public virtual ICollection<Price> Prices { get; set; }
        public virtual ICollection<Picture> Pictures { get; set; }
    }
}
