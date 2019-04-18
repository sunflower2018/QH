using QH.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QH.Model
{
    public class 仓单日报_详情_上海
    {
        /// <summary>
        /// 商品名称
        /// </summary>
        public string VARNAME { get; set; }
        public string VARSORT { get; set; }
        /// <summary>
        /// 地区
        /// </summary>
        public string REGNAME { get; set; }
        public string REGSORT { get; set; }
        /// <summary>
        /// 仓库
        /// </summary>
        public string WHABBRNAME { get; set; }
        public string WHROWS { get; set; }
        public string WGHTUNIT { get; set; }
        /// <summary>
        /// 注册仓单
        /// </summary>
        public string WRTWGHTS { get; set; }
        /// <summary>
        /// 变动数量
        /// </summary>
        public string WRTCHANGE { get; set; }
        public string ROWORDER { get; set; }
        public string ROWSTATUS { get; set; }

        public BaseModel PaserTo()
        {
            仓单日报 model = new 仓单日报();
            return model;
        }
    }

    public class 仓单日报_上海 : IParse
    {
        public string o_tradingday { get; set; }
        public string o_issueno { get; set; }
        public string o_totalissueno { get; set; }
        public string o_code { get; set; }
        public string o_msg { get; set; }
        public string report_date { get; set; }
        public DateTime update_date { get; set; }
        public string print_date { get; set; }
        public List<仓单日报_详情_上海> o_cursor { get; set; }

        public List<BaseModel> PaserTo()
        {
            List<BaseModel> list = new List<BaseModel>();

            foreach (var item in o_cursor)
            {
                仓单日报 model = new 仓单日报();
                model.仓库 = item.WHABBRNAME;
                model.变动数量 = Convert.ToInt32(item.WRTCHANGE);
                model.商品名称 = item.VARNAME;
                model.地区 = item.REGNAME;
                model.日期 = Convert.ToDateTime(o_tradingday,);
                model.注册仓单 = Convert.ToInt32(item.WRTWGHTS);               
                list.Add(model);
            }

            return list;
            
        }
        private DateTime GetDate(string strDate)
        {
            IFormatProvider iff=new da
            string[] arr = strDate.Split(' ');
            
            return DateTime.MinValue;
        }
    }
}
