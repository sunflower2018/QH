using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QH.Model
{
    public class 仓单日报_上海
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

    }

    public class Result
    {
        public List<仓单日报_上海> o_cursor { get; set; }
    }
}
