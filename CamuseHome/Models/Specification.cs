using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamuseHome.Models
{
    public class Specification
    {
        public long Id { get; set; }
        /// <summary>
        /// 产品/内盒/中盒/外箱
        /// </summary>
        public SpecificationType Type { get; set; }
        /// <summary>
        /// 包装方式
        /// </summary>
        public string Packing { get; set; }
        /// <summary>
        /// 长
        /// </summary>
        public float Length { get; set; }
        /// <summary>
        /// 宽
        /// </summary>
        public float Width { get; set; }
        /// <summary>
        /// 高
        /// </summary>
        public float Height { get; set; }
        /// <summary>
        /// 尺寸
        /// </summary>
        public string Size { get; set; }
        /// <summary>
        /// 重量
        /// </summary>
        public float Weight { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }
        public long ProductId { get; set; }
        public virtual Product Product { get; set; }
    }

    public enum SpecificationType
    {
        Product,
        InnerBox,
        MidBox,
        OuterBox
    }
}
