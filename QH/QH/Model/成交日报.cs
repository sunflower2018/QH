using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QH.Model
{
    class 成交日报:BaseModel
    {
        public string 商品名称 { get; set; }
        public string 交割月份 { get; set; }
        public DateTime 日期 { get; set; }
        public decimal 前结算价 { get; set; } 
        public decimal 开盘价 { get; set; }
        public decimal 最高价 { get; set; }
        public decimal 最低价 { get; set; }
        public decimal 收盘价 { get; set; }
        public decimal 结算价 { get; set; }
        public int 成交手 { get; set; }
        public int 持仓手 { get; set; }
        public int 变化手 { get; set; }
    }
}
