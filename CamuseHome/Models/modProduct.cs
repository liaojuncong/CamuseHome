using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CamuseHome
{
    [Table("Product")]
    public class modProduct
    {
        public modProduct()
        {
            Pictures = new List<modPicture>();
        }
        /// <summary>
        /// 主键Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 编号
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 灯罩尺寸
        /// </summary>
        public string LampShadeSize { get; set; }
        /// <summary>
        /// 灯体尺寸
        /// </summary>
        public string LampBodySize { get; set; }
        /// <summary>
        /// 灯总高
        /// </summary>
        public string LampSize { get; set; }
        /// <summary>
        /// 售价
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// 成本
        /// </summary>
        public double Cost { get; set; }
        /// <summary>
        /// 灯罩颜色
        /// </summary>
        public string LampShadeColor { get; set; }
        /// <summary>
        /// 灯体颜色
        /// </summary>
        public string LampBodyColor { get; set; }
        /// <summary>
        /// 工艺
        /// </summary>
        public string Craft { get; set; }
        /// <summary>
        /// 灯体材质
        /// </summary>
        public string LampBodyMaterial { get; set; }
        /// <summary>
        /// 布板编号
        /// </summary>
        public string ClothPlateCode { get; set; }
        /// <summary>
        /// 色板编号
        /// </summary>
        public string ColorPlateCode { get; set; }
        /// <summary>
        /// 分类
        /// </summary>
        public int CategoryId { get; set; }
        /// <summary>
        /// 风格
        /// </summary>
        public string Style { get; set; }
        /// <summary>
        /// 包装方式
        /// </summary>
        public string PackingWay { get; set; }
        /// <summary>
        /// 外箱包装尺寸
        /// </summary>
        public string CartonPackingSize { get; set; }
        /// <summary>
        /// 库存情况
        /// </summary>
        public string Inventory { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 审核状态
        /// </summary>
        public bool AuditState { get; set; }
        public virtual ICollection<modPicture> Pictures { get; set; }
    }
}
