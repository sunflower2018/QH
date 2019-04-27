using Newtonsoft.Json;
using QH.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace QH
{
    /// <summary>
    /// Interaction logic for ImportDataWindow.xaml
    /// </summary>
    public partial class ImportDataWindow : Window
    {
        public ImportDataWindow()
        {
            InitializeComponent();
        }

        private void btnImportData_Click(object sender, RoutedEventArgs e)
        {

            ////string r1= win.Util.Util_Http.HttpGet("http://www.100ppi.com/sf2/day-2018-04-17.html", string.Empty);

            ////string r1 = win.Util.Util_Http.HttpGet("http://www.shfe.com.cn/data/dailydata/20190411dailystock.dat", string.Empty); //上海期货交易所 仓单日报
            ////仓单日报_上海 r = JsonConvert.DeserializeObject<仓单日报_上海>(r1);
            ////List<BaseModel> llist = r.PaserTo();


            ////string r1 = win.Util.Util_Http.HttpGet("http://www.shfe.com.cn/data/dailydata/20190412weeklystock.dat", string.Empty);//上海期货交易所 


            //string r1 = win.Util.Util_Http.HttpGet("http://www.shfe.com.cn/data/dailydata/kx/kx20190410.dat", string.Empty); //上海期货交易所，每日交易数据
            //成交日报_上海 r = JsonConvert.DeserializeObject<成交日报_上海>(r1);
            //List<BaseModel> llist = r.PaserTo();     

            //using (var entity = new QHDBModel())
            //{

            //    //查询，删除
            //    List<成交日报> list = entity.成交日报s.ToList<成交日报>();
            //    for (int i = 0; i < list.Count; i++)
            //    {
            //        entity.Entry(list[i]).State = EntityState.Deleted;
            //        MessageBox.Show(list[i].标识.ToString());
            //        entity.SaveChanges();
            //    }


            //    ////增加
            //    //User user = new User() { Name = "雷克斯 阿帕奇", Email = "wutqqqqqq@gmail.com" };
            //    //user = entity.Users.Add(user);
            //    //entity.SaveChanges();

            //    //Console.ReadKey();

            //}

          

        }
    }
}


