using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QH.Model
{
    public class 仓单日报:BaseModel
    {      
        public DateTime 日期 { get; set; }
        public string 商品名称 { get; set; }
        public string 地区 { get; set; }
        public string 仓库 { get; set; }
        public int 注册仓单 { get; set; }
        public int 变动数量 { get; set; }        
    }
}
