using QH.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QH.Model
{
    public class 成交日报_详情_上海
    {
        public string PRODUCTID;
        /// <summary>
        /// 排序号码
        /// </summary>
        public string PRODUCTSORTNO;
        /// <summary>
        /// 商品名称
        /// </summary>
        public string PRODUCTNAME;
        /// <summary>
        /// 交割月份
        /// </summary>
        public string DELIVERYMONTH;
        /// <summary>
        /// 前结算
        /// </summary>
        public string PRESETTLEMENTPRICE;
        /// <summary>
        /// 今开盘
        /// </summary>
        public string OPENPRICE;
        /// <summary>
        /// 最高价
        /// </summary>
        public string HIGHESTPRICE;
        /// <summary>
        /// 最低价
        /// </summary>
        public string LOWESTPRICE;
        /// <summary>
        /// 收盘价
        /// </summary>
        public string CLOSEPRICE;
        /// <summary>
        /// 结算参考价
        /// </summary>
        public string SETTLEMENTPRICE;
        /// <summary>
        /// 涨跌一
        /// </summary>
        public string ZD1_CHG;   //今收盘-前结算
        /// <summary>
        /// 涨跌二
        /// </summary>
        public string ZD2_CHG;   //今结算-前结算
        /// <summary>
        /// 成交手
        /// </summary>
        public string VOLUME;
        /// <summary>
        /// 持仓手
        /// </summary>
        public string OPENINTEREST;
        /// <summary>
        /// 变化手
        /// </summary>
        public string OPENINTERESTCHG;
        public string ORDERNO;
        public string ORDERNO2;

    }

    public class 成交日报_上海 : IParse
    {
        public string report_date;
       
        public List<成交日报_详情_上海> o_curinstrument;
        
        public List<BaseModel> PaserTo()
        {
            List<BaseModel> list = new List<BaseModel>();
            foreach (var item in o_curinstrument)
            {
                try
                {
                    成交日报 cj = new 成交日报();
                    cj.交割月份 = item.DELIVERYMONTH;
                    cj.前结算价 = decimal.Parse(item.PRESETTLEMENTPRICE);
                    cj.变化手 = int.Parse(item.OPENINTERESTCHG);
                    cj.商品名称 = item.PRODUCTNAME;
                    cj.开盘价 = decimal.Parse(item.OPENPRICE);
                    cj.成交手 = int.Parse(item.VOLUME);
                    cj.持仓手 = int.Parse(item.OPENINTEREST);
                    cj.收盘价 = int.Parse(item.CLOSEPRICE);
                    cj.日期 = Convert.ToDateTime(report_date.Insert(4, "-").Insert(7, "-"));
                    cj.最低价 = decimal.Parse(item.LOWESTPRICE);
                    cj.最高价 = decimal.Parse(item.HIGHESTPRICE);
                    cj.结算价 = decimal.Parse(item.SETTLEMENTPRICE);
                    list.Add(cj);
                }
                catch
                {

                }
            }
            return list;
        }

    }

    
}
