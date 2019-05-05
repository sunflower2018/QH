using GalaSoft.MvvmLight;
using Newtonsoft.Json;
using QH.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using win.Logger;

namespace QH.ViewModel
{    
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class ImportDataViewModel : ViewModelBase
    {
        private qhDbContext context;
        /// <summary>
        /// Initializes a new instance of the ImportDataViewModel class.
        /// </summary>
        public ImportDataViewModel()
        {
            this.context = new qhDbContext();
        }

        public void ImportData()
        {
            this.Import成交日报();
        }

        private void Import成交日报()
        {
            DateTime dtMax = this.GetMaxDate();
            DateTime dtImport = dtMax.AddDays(1);
            while (true)
            {
                if (dtImport.Date > DateTime.Now.Date)
                    break;

                this.Import成交日报(dtImport);
                dtImport = dtImport.AddDays(1);
            }
        }

        private DateTime GetMaxDate()
        {
            DateTime dtReturn = DateTime.MinValue;
            if (this.context.成交日报s.Count() > 0)
                dtReturn = this.context.成交日报s.Select(p => p.日期).Max();

            if (dtReturn == DateTime.MinValue)
            {
                dtReturn = new DateTime(2002, 1, 6);
            }
            return dtReturn;
        }

        private void Import成交日报(DateTime date交易日期)
        {
            try
            {
                string url = string.Format("http://www.shfe.com.cn/data/dailydata/kx/kx{0}.dat", date交易日期.ToString("yyyyMMdd"));
                string r1 = win.Util.Util_Http.HttpGet(url, string.Empty); //上海期货交易所，每日交易数据
                成交日报_上海 r = JsonConvert.DeserializeObject<成交日报_上海>(r1);
                List<BaseModel> llist = r.PaserTo();

                foreach (var item in llist)
                {
                    成交日报 rp = item as 成交日报;
                    if (rp.日期 != date交易日期)
                        continue;
                    if (!this.IsExsitInDb(rp))
                        continue;

                    context.成交日报s.Add(rp);
                }
                context.SaveChanges();
            }       
            catch (Exception ex)
            {
                if (!ex.Message.Contains("(404)"))
                {
                    Logger.Error(ex.Message);
                }
                    
            }

            ////查询，删除
            //List<成交日报> list = context.成交日报s.ToList<成交日报>();
            //for (int i = 0; i < list.Count; i++)
            //{
            //    context.Entry(list[i]).State = EntityState.Deleted;
            //    MessageBox.Show(list[i].标识.ToString());
            //    context.SaveChanges();
            //}
          
        }

        private bool IsExsitInDb(成交日报 rp)
        {
            bool IsExsit = context.成交日报s.Any(p => p.交割月份 == rp.交割月份 && p.日期 == rp.日期 && p.商品名称 == rp.商品名称);
            if (IsExsit)
                return false;

            return true;
        }
    }
}