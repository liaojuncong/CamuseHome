
using System.ComponentModel.DataAnnotations.Schema;

namespace CamuseHome
{
    [Table("UserInfo")]
    public class modUserInfo
    {
        public int Id { set; get; }
        /// <summary>
        /// 登录编号
        /// </summary>
        public int Code { set; get; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { set; get; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Pwd { set; get; }
        /// <summary>
        /// 录入资料
        /// </summary>
        public bool InputData { set; get; }
        /// <summary>
        /// 修改资料
        /// </summary>
        public bool ModifyData { set; get; }
        /// <summary>
        /// 删除资料
        /// </summary>
        public bool DeleteData { set; get; }
        /// <summary>
        /// 审核资料
        /// </summary>
        public bool AuditData { set; get; }
        /// <summary>
        /// 弃审资料
        /// </summary>
        public bool AbandonData { set; get; }
        /// <summary>
        /// 设置参数
        /// </summary>
        public bool SetParam { set; get; }
        /// <summary>
        /// 导出资料
        /// </summary>
        public bool ExportData { set; get; }
        /// <summary>
        /// 打印
        /// </summary>
        public bool Print { set; get; }
        /// <summary>
        /// 查看成本
        /// </summary>
        public bool LookCost { set; get; }
        /// <summary>
        /// 查看价格
        /// </summary>
        public bool LookPrice { set; get; }
    }
}
