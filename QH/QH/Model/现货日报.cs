using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QH.Model
{
    public class 现货日报 : BaseModel
    {      
        public DateTime 日期 { get; set; }
        public string 商品名称 { get; set; }
        public string 商品价格 { get; set; }
     
    }
}
