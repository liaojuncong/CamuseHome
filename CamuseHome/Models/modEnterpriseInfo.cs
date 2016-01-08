using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamuseHome
{
    [Table("EnterpriseInfo")]
    public class modEnterpriseInfo
    {
        public int Id { get; set; }
        public string CnName { set; get; }
        public string EnName { set; get; }
        public string CnAddress { set; get; }
        public string EnAddress { set; get; }
        public string Telephone { set; get; }
        public string Fax { set; get; }
        public string Url { set; get; }
        public string Email { set; get; }
    }
}
