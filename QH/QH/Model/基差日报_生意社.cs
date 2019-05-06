using QH.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace QH.Model
{  
    public class 基差日报_生意社 : IParse
    {
        public string report_date;

        public string strHtml;
        
        public List<BaseModel> PaserTo()
        {

            XmlDocument xml = new XmlDocument();
            xml.LoadXml(strHtml);
           


            List<BaseModel> list = new List<BaseModel>();



            //foreach (var item in o_curinstrument)
            //{
            //    try
            //    {
            //        现货日报 xh = new 现货日报();
            //        //xh.商品价格=
            //        //xh.商品名称=
            //        //xh.日期=                 
            //        list.Add(xh);
            //    }
            //    catch
            //    {

            //    }
            //}
            return list;
        }

    }

    
}
