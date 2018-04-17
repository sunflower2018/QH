using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QH.Model
{
    class Contract
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// 合约代码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 数据日期
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// 现货价格
        /// </summary>
        public decimal Price_Spot { get; set; }
        /// <summary>
        /// 合约价格
        /// </summary>
        public decimal Price_Contract { get; set; }
        /// <summary>
        /// 基差
        /// </summary>
        public decimal BasisDiff { get; set; }
        /// <summary>
        /// 基差百分比
        /// </summary>
        public decimal BasisDiff_Percent { get; set; }
        /// <summary>
        /// 180日内主力基差最高
        /// </summary>
        public decimal BasisDIff180_Max { get; set; }
        /// <summary>
        /// 180日内主力基差最低
        /// </summary>
        public decimal BasisDiff180_Min { get; set; }
        /// <summary>
        /// 180日内主力基差最低
        /// </summary>
        public decimal BasisDiff180_Avg { get; set; }
      
    }
}
