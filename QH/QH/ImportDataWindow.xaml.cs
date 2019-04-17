﻿using Newtonsoft.Json;
using QH.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
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
          
            //string r1= win.Util.Util_Http.HttpGet("http://www.100ppi.com/sf2/day-2018-04-17.html", string.Empty);

            string r1 = win.Util.Util_Http.HttpGet("http://www.shfe.com.cn/data/dailydata/20190411dailystock.dat", string.Empty); //上海期货交易所 仓单日报
          
            //string r1 = win.Util.Util_Http.HttpGet("http://www.shfe.com.cn/data/dailydata/20190412weeklystock.dat", string.Empty);//上海期货交易所 库存周报

            //Result r= JsonConvert.DeserializeObject<Result>(r1);

        }

        /*
        {"o_tradingday":"20190412","o_issueno":"14","o_totalissueno":"1022","o_cursor":[{"VARNAME":"铜$$COPPER","VARSORT":0,"REGNAME":"上海$$Shanghai","REGSORT":0,"WHABBRNAME":"国储天威$$Guochutianwei","WHROWS":14,"WGHTUNIT":"2","PRESPOTWGHTS":224,"PREWRTWGHTS":199,"SPOTWGHTS":1413,"WRTWGHTS":199,"SPOTCHANGE":1189,"WRTCHANGE":0,"PREWHSTOCKS":21722,"WHSTOCKS":21722,"WHSTOCKCHANGE":0,"ROWORDER":16,"ROWSTATUS":"0"},{"VARNAME":"铜$$COPPER","VARSORT":0,"REGNAME":"上海$$Shanghai","REGSORT":0,"WHABBRNAME":"国储外高桥$$Guochu Waigaoqiao","WHROWS":14,"WGHTUNIT":"2","PRESPOTWGHTS":0,"PREWRTWGHTS":0,"SPOTWGHTS":0,"WRTWGHTS":0,"SPOTCHANGE":0,"WRTCHANGE":0,"PREWHSTOCKS":20000,"WHSTOCKS":20000,"WHSTOCKCHANGE":0,"ROWORDER":17,"ROWSTATUS":"0"},{"VARNAME":"铜$$COPPER","VARSORT":0,"REGNAME":"上海$$Shanghai","REGSORT":0,"WHABBRNAME":"中储吴淞$$Zhongchu Wusong","WHROWS":14,"WGHTUNIT":"2","PRESPOTWGHTS":44735,"PREWRTWGHTS":11213,"SPOTWGHTS":40793,"WRTWGHTS":15070,"SPOTCHANGE":-3942,"WRTCHANGE":3857,"PREWHSTOCKS":109810,"WHSTOCKS":105953,"WHSTOCKCHANGE":-3857,"ROWORDER":25,"ROWSTATUS":"0"},{"VARNAME":"铜$$COPPER","VARSORT":0,"REGNAME":"上海$$Shanghai","REGSORT":0,"WHABBRNAME":"上港物流$$SIPG Logistics","WHROWS":14,"WGHTUNIT":"2","PRESPOTWGHTS":49989,"PREWRTWGHTS":13627,"SPOTWGHTS":43979,"WRTWGHTS":8473,"SPOTCHANGE":-6010,"WRTCHANGE":-5154,"PREWHSTOCKS":106370,"WHSTOCKS":128003,"WHSTOCKCHANGE":21633,"ROWORDER":27,"ROWSTATUS":"0"},{"VARNAME":"铜$$COPPER","VARSORT":0,"REGNAME":"上海$$Shanghai","REGSORT":0,"WHABBRNAME":"上海裕强$$R&S Logistics","WHROWS":14,"WGHTUNIT":"2","PRESPOTWGHTS":0,"PREWRTWGHTS":0,"SPOTWGHTS":0,"WRTWGHTS":0,"SPOTCHANGE":0,"WRTCHANGE":0,"PREWHSTOCKS":15000,"WHSTOCKS":15000,"WHSTOCKCHANGE":0,"ROWORDER":28,"ROWSTATUS":"0"},{"VARNAME":"铜$$COPPER","VARSORT":0,"REGNAME":"上海$$Shanghai","REGSORT":0,"WHABBRNAME":"裕强闵行$$R&S Logistics MHC","WHROWS":14,"WGHTUNIT":"2","PRESPOTWGHTS":11928,"PREWRTWGHTS":9138,"SPOTWGHTS":10903,"WRTWGHTS":8000,"SPOTCHANGE":-1025,"WRTCHANGE":-1138,"PREWHSTOCKS":45519,"WHSTOCKS":47491,"WHSTOCKCHANGE":1972,"ROWORDER":29,"ROWSTATUS":"0"},{"VARNAME":"铜$$COPPER","VARSORT":0,"REGNAME":"上海$$Shanghai","REGSORT":0,"WHABBRNAME":"中储大场$$Zhongchu Dachang","WHROWS":14,"WGHTUNIT":"2","PRESPOTWGHTS":18505,"PREWRTWGHTS":3807,"SPOTWGHTS":18859,"WRTWGHTS":3132,"SPOTCHANGE":354,"WRTCHANGE":-675,"PREWHSTOCKS":191770,"WHSTOCKS":193642,"WHSTOCKCHANGE":1872,"ROWORDER":38,"ROWSTATUS":"0"},{"VARNAME":"铜$$COPPER","VARSORT":0,"REGNAME":"上海$$Shanghai","REGSORT":0,"WHABBRNAME":"世天威洋山$$Steinweg Yangshan","WHROWS":14,"WGHTUNIT":"2","PRESPOTWGHTS":1528,"PREWRTWGHTS":1528,"SPOTWGHTS":3041,"WRTWGHTS":1528,"SPOTCHANGE":1513,"WRTCHANGE":0,"PREWHSTOCKS":8472,"WHSTOCKS":8472,"WHSTOCKCHANGE":0,"ROWORDER":273,"ROWSTATUS":"0"},{"VARNAME":"铜$$COPPER","VARSORT":0,"REGNAME":"上海$$Shanghai","REGSORT":0,"WHABBRNAME":"同盛松江$$Tongsheng Songjiang","WHROWS":14,"WGHTUNIT":"2","PRESPOTWGHTS":177,"PREWRTWGHTS":177,"SPOTWGHTS":177,"WRTWGHTS":177,"SPOTCHANGE":0,"WRTCHANGE":0,"PREWHSTOCKS":52542,"WHSTOCKS":52542,"WHSTOCKCHANGE":0,"ROWORDER":315,"ROWSTATUS":"0"},{"VARNAME":"铜$$COPPER","VARSORT":0,"REGNAME":"上海$$Shanghai","REGSORT":0,"WHABBRNAME":"外运华东张华浜$$Sinotrans Eastern Zhanghuabang","WHROWS":14,"WGHTUNIT":"2","PRESPOTWGHTS":25,"PREWRTWGHTS":25,"SPOTWGHTS":25,"WRTWGHTS":25,"SPOTCHANGE":0,"WRTCHANGE":0,"PREWHSTOCKS":19975,"WHSTOCKS":19975,"WHSTOCKCHANGE":0,"ROWORDER":340,"ROWSTATUS":"0"},{"VARNAME":"铜$$COPPER","VARSORT":0,"REGNAME":"上海$$Shanghai","REGSORT":0,"WHABBRNAME":"中海华东宝山$$China Shipping East Baoshan","WHROWS":14,"WGHTUNIT":"2","PRESPOTWGHTS":12951,"PREWRTWGHTS":12751,"SPOTWGHTS":8567,"WRTWGHTS":8567,"SPOTCHANGE":-4384,"WRTCHANGE":-4184,"PREWHSTOCKS":7249,"WHSTOCKS":11433,"WHSTOCKCHANGE":4184,"ROWORDER":350,"ROWSTATUS":"0"},{"VARNAME":"铜$$COPPER","VARSORT":0,"REGNAME":"上海$$Shanghai","REGSORT":0,"WHABBRNAME":"同盛洋山(保税)$$Tongsheng Yangshan (Bonded)","WHROWS":14,"WGHTUNIT":"2","PRESPOTWGHTS":0,"PREWRTWGHTS":0,"SPOTWGHTS":0,"WRTWGHTS":0,"SPOTCHANGE":0,"WRTCHANGE":0,"PREWHSTOCKS":30000,"WHSTOCKS":30000,"WHSTOCKCHANGE":0,"ROWORDER":381,"ROWSTATUS":"0"},{"VARNAME":"铜$$COPPER","VARSORT":0,"REGNAME":"上海$$Shanghai","REGSORT":0,"WHABBRNAME":"中储临港(保税)$$Zhongchu LinGang (Bonded)","WHROWS":14,"WGHTUNIT":"2","PRESPOTWGHTS":18,"PREWRTWGHTS":0,"SPOTWGHTS":18,"WRTWGHTS":0,"SPOTCHANGE":0,"WRTCHANGE":0,"PREWHSTOCKS":30000,"WHSTOCKS":30000,"WHSTOCKCHANGE":0,"ROWORDER":383,"ROWSTATUS":"0"},{"VARNAME":"铜$$COPPER","VARSORT":0,"REGNAME":"上海$$Shanghai","REGSORT":0,"WHABBRNAME":"合计$$Subtotal","WHROWS":14,"WGHTUNIT":"2","PRESPOTWGHTS":140080,"PREWRTWGHTS":52465,"SPOTWGHTS":127775,"WRTWGHTS":45171,"SPOTCHANGE":-12305,"WRTCHANGE":-7294,"PREWHSTOCKS":658429,"WHSTOCKS":684233,"WHSTOCKCHANGE":25804,"ROWORDER":100000,"ROWSTATUS":"1"},{"VARNAME":"铜$$COPPER","VARSORT":0,"REGNAME":"广东$$Guangdong","REGSORT":1,"WHABBRNAME":"南储仓储$$Nanchu","WHROWS":3,"WGHTUNIT":"2","PRESPOTWGHTS":20000,"PREWRTWGHTS":18602,"SPOTWGHTS":20000,"WRTWGHTS":14651,"SPOTCHANGE":0,"WRTCHANGE":-3951,"PREWHSTOCKS":1398,"WHSTOCKS":5349,"WHSTOCKCHANGE":3951,"ROWORDER":12,"ROWSTATUS":"0"},{"VARNAME":"铜$$COPPER","VARSORT":0,"REGNAME":"广东$$Guangdong","REGSORT":1,"WHABBRNAME":"八三O黄浦$$830 Huangpu","WHROWS":3,"WGHTUNIT":"2","PRESPOTWGHTS":30000,"PREWRTWGHTS":25002,"SPOTWGHTS":29869,"WRTWGHTS":23560,"SPOTCHANGE":-131,"WRTCHANGE":-1442,"PREWHSTOCKS":4998,"WHSTOCKS":6440,"WHSTOCKCHANGE":1442,"ROWORDER":334,"ROWSTATUS":"0"},{"VARNAME":"铜$$COPPER","VARSORT":0,"REGNAME":"广东$$Guangdong","REGSORT":1,"WHABBRNAME":"合计$$Subtotal","WHROWS":3,"WGHTUNIT":"2","PRESPOTWGHTS":50000,"PREWRTWGHTS":43604,"SPOTWGHTS":49869,"WRTWGHTS":38211,"SPOTCHANGE":-131,"WRTCHANGE":-5393,"PREWHSTOCKS":6396,"WHSTOCKS":11789,"WHSTOCKCHANGE":5393,"ROWORDER":100000,"ROWSTATUS":"1"},{"VARNAME":"铜$$COPPER","VARSORT":0,"REGNAME":"江苏$$Jiangsu","REGSORT":2,"WHABBRNAME":"中储无锡$$Zhongchu Wuxi","WHROWS":6,"WGHTUNIT":"2","PRESPOTWGHTS":19804,"PREWRTWGHTS":19804,"SPOTWGHTS":18841,"WRTWGHTS":18701,"SPOTCHANGE":-963,"WRTCHANGE":-1103,"PREWHSTOCKS":196,"WHSTOCKS":1299,"WHSTOCKCHANGE":1103,"ROWORDER":26,"ROWSTATUS":"0"},{"VARNAME":"铜$$COPPER","VARSORT":0,"REGNAME":"江苏$$Jiangsu","REGSORT":2,"WHABBRNAME":"上港物流苏州$$SIPG Logistics Suzhou","WHROWS":6,"WGHTUNIT":"2","PRESPOTWGHTS":0,"PREWRTWGHTS":0,"SPOTWGHTS":0,"WRTWGHTS":0,"SPOTCHANGE":0,"WRTCHANGE":0,"PREWHSTOCKS":51894,"WHSTOCKS":52197,"WHSTOCKCHANGE":303,"ROWORDER":84,"ROWSTATUS":"0"},{"VARNAME":"铜$$COPPER","VARSORT":0,"REGNAME":"江苏$$Jiangsu","REGSORT":2,"WHABBRNAME":"无锡国联$$Wuxi Guolian","WHROWS":6,"WGHTUNIT":"2","PRESPOTWGHTS":11052,"PREWRTWGHTS":11052,"SPOTWGHTS":13257,"WRTWGHTS":13257,"SPOTCHANGE":2205,"WRTCHANGE":2205,"PREWHSTOCKS":8948,"WHSTOCKS":6743,"WHSTOCKCHANGE":-2205,"ROWORDER":318,"ROWSTATUS":"0"},{"VARNAME":"铜$$COPPER","VARSORT":0,"REGNAME":"江苏$$Jiangsu","REGSORT":2,"WHABBRNAME":"添马行物流$$Timax Logistics","WHROWS":6,"WGHTUNIT":"2","PRESPOTWGHTS":8090,"PREWRTWGHTS":7087,"SPOTWGHTS":8842,"WRTWGHTS":8842,"SPOTCHANGE":752,"WRTCHANGE":1755,"PREWHSTOCKS":12913,"WHSTOCKS":11158,"WHSTOCKCHANGE":-1755,"ROWORDER":345,"ROWSTATUS":"0"},{"VARNAME":"铜$$COPPER","VARSORT":0,"REGNAME":"江苏$$Jiangsu","REGSORT":2,"WHABBRNAME":"常州融达$$Changzhou Rongda","WHROWS":6,"WGHTUNIT":"2","PRESPOTWGHTS":18838,"PREWRTWGHTS":18339,"SPOTWGHTS":17138,"WRTWGHTS":17038,"SPOTCHANGE":-1700,"WRTCHANGE":-1301,"PREWHSTOCKS":1661,"WHSTOCKS":2962,"WHSTOCKCHANGE":1301,"ROWORDER":349,"ROWSTATUS":"0"},{"VARNAME":"铜$$COPPER","VARSORT":0,"REGNAME":"江苏$$Jiangsu","REGSORT":2,"WHABBRNAME":"合计$$Subtotal","WHROWS":6,"WGHTUNIT":"2","PRESPOTWGHTS":57784,"PREWRTWGHTS":56282,"SPOTWGHTS":58078,"WRTWGHTS":57838,"SPOTCHANGE":294,"WRTCHANGE":1556,"PREWHSTOCKS":75612,"WHSTOCKS":74359,"WHSTOCKCHANGE":-1253,"ROWORDER":100000,"ROWSTATUS":"1"},{"VARNAME":"铜$$COPPER","VARSORT":0,"REGNAME":"浙江$$Zhejiang","REGSORT":3,"WHABBRNAME":"国储837处$$SRB 837","WHROWS":3,"WGHTUNIT":"2","PRESPOTWGHTS":9182,"PREWRTWGHTS":9182,"SPOTWGHTS":9182,"WRTWGHTS":9182,"SPOTCHANGE":0,"WRTCHANGE":0,"PREWHSTOCKS":10818,"WHSTOCKS":10818,"WHSTOCKCHANGE":0,"ROWORDER":324,"ROWSTATUS":"0"},{"VARNAME":"铜$$COPPER","VARSORT":0,"REGNAME":"浙江$$Zhejiang","REGSORT":3,"WHABBRNAME":"宁波九龙仓$$Ningbo Jiulongcang","WHROWS":3,"WGHTUNIT":"2","PRESPOTWGHTS":0,"PREWRTWGHTS":0,"SPOTWGHTS":0,"WRTWGHTS":0,"SPOTCHANGE":0,"WRTCHANGE":0,"PREWHSTOCKS":10000,"WHSTOCKS":10000,"WHSTOCKCHANGE":0,"ROWORDER":327,"ROWSTATUS":"0"},{"VARNAME":"铜$$COPPER","VARSORT":0,"REGNAME":"浙江$$Zhejiang","REGSORT":3,"WHABBRNAME":"合计$$Subtotal","WHROWS":3,"WGHTUNIT":"2","PRESPOTWGHTS":9182,"PREWRTWGHTS":9182,"SPOTWGHTS":9182,"WRTWGHTS":9182,"SPOTCHANGE":0,"WRTCHANGE":0,"PREWHSTOCKS":20818,"WHSTOCKS":20818,"WHSTOCKCHANGE":0,"ROWORDER":100000,"ROWSTATUS":"1"},{"VARNAME":"铜$$COPPER","VARSORT":0,"REGNAME":"江西$$Jiangxi","REGSORT":5,"WHABBRNAME":"江西国储$$Jiangxi Guochu","WHROWS":1,"WGHTUNIT":"2","PRESPOTWGHTS":274,"PREWRTWGHTS":74,"SPOTWGHTS":274,"WRTWGHTS":74,"SPOTCHANGE":0,"WRTCHANGE":0,"PREWHSTOCKS":2926,"WHSTOCKS":2926,"WHSTOCKCHANGE":0,"ROWORDER":343,"ROWSTATUS":"0"},{"VARNAME":"铜$$COPPER","VARSORT":0,"REGNAME":"","REGSORT":999999999,"WHABBRNAME":"保税商品总计$$Total (Bonded)","WHROWS":1,"WGHTUNIT":"2","PRESPOTWGHTS":18,"PREWRTWGHTS":0,"SPOTWGHTS":18,"WRTWGHTS":0,"SPOTCHANGE":0,"WRTCHANGE":0,"PREWHSTOCKS":60000,"WHSTOCKS":60000,"WHSTOCKCHANGE":0,"ROWORDER":180000,"ROWSTATUS":"2"},{"VARNAME":"铜$$COPPER","VARSORT":0,"REGNAME":"","REGSORT":999999999,"WHABBRNAME":"完税商品总计$$Total (Tax included)","WHROWS":1,"WGHTUNIT":"2","PRESPOTWGHTS":257302,"PREWRTWGHTS":161607,"SPOTWGHTS":245160,"WRTWGHTS":150476,"SPOTCHANGE":-12142,"WRTCHANGE":-11131,"PREWHSTOCKS":704181,"WHSTOCKS":734125,"WHSTOCKCHANGE":29944,"ROWORDER":190000,"ROWSTATUS":"2"},{"VARNAME":"铜$$COPPER","VARSORT":0,"REGNAME":"","REGSORT":999999999,"WHABBRNAME":"总计$$Total","WHROWS":1,"WGHTUNIT":"2","PRESPOTWGHTS":257320,"PREWRTWGHTS":161607,"SPOTWGHTS":245178,"WRTWGHTS":150476,"SPOTCHANGE":-12142,"WRTCHANGE":-11131,"PREWHSTOCKS":764181,"WHSTOCKS":794125,"WHSTOCKCHANGE":29944,"ROWORDER":200000,"ROWSTATUS":"2"},{"VARNAME":"铝$$ALUMINIUM","VARSORT":1,"REGNAME":"上海$$Shanghai","REGSORT":0,"WHABBRNAME":"国储天威$$Guochutianwei","WHROWS":14,"WGHTUNIT":"2","PRESPOTWGHTS":33061,"PREWRTWGHTS":32693,"SPOTWGHTS":33050,"WRTWGHTS":32693,"SPOTCHANGE":-11,"WRTCHANGE":0,"PREWHSTOCKS":7241,"WHSTOCKS":7241,"WHSTOCKCHANGE":0,"ROWORDER":16,"ROWSTATUS":"0"},{"VARNAME":"铝$$ALUMINIUM","VARSORT":1,"REGNAME":"上海$$Shanghai","REGSORT":0,"WHABBRNAME":"国储外高桥$$Guochu Waigaoqiao","WHROWS":14,"WGHTUNIT":"2","PRESPOTWGHTS":0,"PREWRTWGHTS":0,"SPOTWGHTS":0,"WRTWGHTS":0,"SPOTCHANGE":0,"WRTCHANGE":0,"PREWHSTOCKS":6600,"WHSTOCKS":6600,"WHSTOCKCHANGE":0,"ROWORDER":17,"ROWSTATUS":"0"},{"VARNAME":"铝$$ALUMINIUM","VARSORT":1,"REGNAME":"上海$$Shanghai","REGSORT":0,"WHABBRNAME":"中储吴淞$$Zhongchu Wusong","WHROWS":14,"WGHTUNIT":"2","PRESPOTWGHTS":7859,"PREWRTWGHTS":7859,"SPOTWGHTS":7859,"WRTWGHTS":7859,"SPOTCHANGE":0,"WRTCHANGE":0,"PREWHSTOCKS":36603,"WHSTOCKS":35318,"WHSTOCKCHANGE":-1285,"ROWORDER":25,"ROWSTATUS":"0"},{"VARNAME":"铝$$ALUMINIUM","VARSORT":1,"REGNAME":"上海$$Shanghai","REGSORT":0,"WHABBRNAME":"上港物流$$SIPG Logistics","WHROWS":14,"WGHTUNIT":"2","PRESPOTWGHTS":36551,"PREWRTWGHTS":30001,"SPOTWGHTS":32948,"WRTWGHTS":24508,"SPOTCHANGE":-3603,"WRTCHANGE":-5493,"PREWHSTOCKS":35457,"WHSTOCKS":42668,"WHSTOCKCHANGE":7211,"ROWORDER":27,"ROWSTATUS":"0"},{"VARNAME":"铝$$ALUMINIUM","VARSORT":1,"REGNAME":"上海$$Shanghai","REGSORT":0,"WHABBRNAME":"上海裕强$$R&S Logistics","WHROWS":14,"WGHTUNIT":"2","PRESPOTWGHTS":0,"PREWRTWGHTS":0,"SPOTWGHTS":0,"WRTWGHTS":0,"SPOTCHANGE":0,"WRTCHANGE":0,"PREWHSTOCKS":5000,"WHSTOCKS":5000,"WHSTOCKCHANGE":0,"ROWORDER":28,"ROWSTATUS":"0"},{"VARNAME":"铝$$ALUMINIUM","VARSORT":1,"REGNAME":"上海$$Shanghai","REGSORT":0,"WHABBRNAME":"裕强闵行$$R&S Logistics MHC","WHROWS":14,"WGHTUNIT":"2","PRESPOTWGHTS":3002,"PREWRTWGHTS":1781,"SPOTWGHTS":2641,"WRTWGHTS":1503,"SPOTCHANGE":-361,"WRTCHANGE":-278,"PREWHSTOCKS":15173,"WHSTOCKS":15830,"WHSTOCKCHANGE":657,"ROWORDER":29,"ROWSTATUS":"0"},{"VARNAME":"铝$$ALUMINIUM","VARSORT":1,"REGNAME":"上海$$Shanghai","REGSORT":0,"WHABBRNAME":"中储大场$$Zhongchu Dachang","WHROWS":14,"WGHTUNIT":"2","PRESPOTWGHTS":32484,"PREWRTWGHTS":30141,"SPOTWGHTS":32061,"WRTWGHTS":29742,"SPOTCHANGE":-423,"WRTCHANGE":-399,"PREWHSTOCKS":63915,"WHSTOCKS":64539,"WHSTOCKCHANGE":624,"ROWORDER":38,"ROWSTATUS":"0"},{"VARNAME":"铝$$ALUMINIUM","VARSORT":1,"REGNAME":"上海$$Shanghai","REGSORT":0,"WHABBRNAME":"同盛松江$$Tongsheng Songjiang","WHROWS":14,"WGHTUNIT":"2","PRESPOTWGHTS":2427,"PREWRTWGHTS":2427,"SPOTWGHTS":2427,"WRTWGHTS":2427,"SPOTCHANGE":0,"WRTCHANGE":0,"PREWHSTOCKS":17514,"WHSTOCKS":17514,"WHSTOCKCHANGE":0,"ROWORDER":315,"ROWSTATUS":"0"},{"VARNAME":"铝$$ALUMINIUM","VARSORT":1,"REGNAME":"上海$$Shanghai","REGSORT":0,"WHABBRNAME":"外运华东张华浜$$Sinotrans Eastern Zhanghuabang","WHROWS":14,"WGHTUNIT":"2","PRESPOTWGHTS":23748,"PREWRTWGHTS":23748,"SPOTWGHTS":23748,"WRTWGHTS":23748,"SPOTCHANGE":0,"WRTCHANGE":0,"PREWHSTOCKS":16252,"WHSTOCKS":16252,"WHSTOCKCHANGE":0,"ROWORDER":340,"ROWSTATUS":"0"},{"VARNAME":"铝$$ALUMINIUM","VARSORT":1,"REGNAME":"上海$$Shanghai","REGSORT":0,"WHABBRNAME":"添马行松江$$Timax Songjiang","WHROWS":14,"WGHTUNIT":"2","PRESPOTWGHTS":0,"PREWRTWGHTS":0,"SPOTWGHTS":0,"WRTWGHTS":0,"SPOTCHANGE":0,"WRTCHANGE":0,"PREWHSTOCKS":20000,"WHSTOCKS":20000,"WHSTOCKCHANGE":0,"ROWORDER":344,"ROWSTATUS":"0"},{"VARNAME":"铝$$ALUMINIUM","VARSORT":1,"REGNAME":"上海$$Shanghai","REGSORT":0,"WHABBRNAME":"全胜物流$$Quansheng Logistics","WHROWS":14,"WGHTUNIT":"2","PRESPOTWGHTS":18776,"PREWRTWGHTS":18772,"SPOTWGHTS":18776,"WRTWGHTS":18772,"SPOTCHANGE":0,"WRTCHANGE":0,"PREWHSTOCKS":1228,"WHSTOCKS":1228,"WHSTOCKCHANGE":0,"ROWORDER":346,"ROWSTATUS":"0"},{"VARNAME":"铝$$ALUMINIUM","VARSORT":1,"REGNAME":"上海$$Shanghai","REGSORT":0,"WHABBRNAME":"同盛洋山(保税)$$Tongsheng Yangshan (Bonded)","WHROWS":14,"WGHTUNIT":"2","PRESPOTWGHTS":0,"PREWRTWGHTS":0,"SPOTWGHTS":0,"WRTWGHTS":0,"SPOTCHANGE":0,"WRTCHANGE":0,"PREWHSTOCKS":10000,"WHSTOCKS":10000,"WHSTOCKCHANGE":0,"ROWORDER":381,"ROWSTATUS":"0"},{"VARNAME":"铝$$ALUMINIUM","VARSORT":1,"REGNAME":"上海$$Shanghai","REGSORT":0,"WHABBRNAME":"中储临港(保税)$$Zhongchu LinGang (Bonded)","WHROWS":14,"WGHTUNIT":"2","PRESPOTWGHTS":0,"PREWRTWGHTS":0,"SPOTWGHTS":0,"WRTWGHTS":0,"SPOTCHANGE":0,"WRTCHANGE":0,"PREWHSTOCKS":10000,"WHSTOCKS":10000,"WHSTOCKCHANGE":0,"ROWORDER":383,"ROWSTATUS":"0"},{"VARNAME":"铝$$ALUMINIUM","VARSORT":1,"REGNAME":"上海$$Shanghai","REGSORT":0,"WHABBRNAME":"合计$$Subtotal","WHROWS":14,"WGHTUNIT":"2","PRESPOTWGHTS":157908,"PREWRTWGHTS":147422,"SPOTWGHTS":153510,"WRTWGHTS":141252,"SPOTCHANGE":-4398,"WRTCHANGE":-6170,"PREWHSTOCKS":244983,"WHSTOCKS":252190,"WHSTOCKCHANGE":7207,"ROWORDER":100000,"ROWSTATUS":"1"},{"VARNAME":"铝$$ALUMINIUM","VARSORT":1,"REGNAME":"广东$$Guangdong","REGSORT":1,"WHABBRNAME":"广储830$$Guangchu830","WHROWS":6,"WGHTUNIT":"2","PRESPOTWGHTS":9155,"PREWRTWGHTS":4391,"SPOTWGHTS":8014,"WRTWGHTS":4391,"SPOTCHANGE":-1141,"WRTCHANGE":0,"PREWHSTOCKS":13609,"WHSTOCKS":13609,"WHSTOCKCHANGE":0,"ROWORDER":6,"ROWSTATUS":"0"},{"VARNAME":"铝$$ALUMINIUM","VARSORT":1,"REGNAME":"广东$$Guangdong","REGSORT":1,"WHABBRNAME":"中储晟世$$Zhongchu Shengshi","WHROWS":6,"WGHTUNIT":"2","PRESPOTWGHTS":20000,"PREWRTWGHTS":5511,"SPOTWGHTS":20000,"WRTWGHTS":5511,"SPOTCHANGE":0,"WRTCHANGE":0,"PREWHSTOCKS":14489,"WHSTOCKS":14489,"WHSTOCKCHANGE":0,"ROWORDER":8,"ROWSTATUS":"0"},{"VARNAME":"铝$$ALUMINIUM","VARSORT":1,"REGNAME":"广东$$Guangdong","REGSORT":1,"WHABBRNAME":"南储仓储$$Nanchu","WHROWS":6,"WGHTUNIT":"2","PRESPOTWGHTS":15437,"PREWRTWGHTS":427,"SPOTWGHTS":13097,"WRTWGHTS":427,"SPOTCHANGE":-2340,"WRTCHANGE":0,"PREWHSTOCKS":29573,"WHSTOCKS":29573,"WHSTOCKCHANGE":0,"ROWORDER":12,"ROWSTATUS":"0"},{"VARNAME":"铝$$ALUMINIUM","VARSORT":1,"REGNAME":"广东$$Guangdong","REGSORT":1,"WHABBRNAME":"中金圣源$$Zhongjinshengyuan","WHROWS":6,"WGHTUNIT":"2","PRESPOTWGHTS":16533,"PREWRTWGHTS":3121,"SPOTWGHTS":18939,"WRTWGHTS":3121,"SPOTCHANGE":2406,"WRTCHANGE":0,"PREWHSTOCKS":16879,"WHSTOCKS":16879,"WHSTOCKCHANGE":0,"ROWORDER":342,"ROWSTATUS":"0"},{"VARNAME":"铝$$ALUMINIUM","VARSORT":1,"REGNAME":"广东$$Guangdong","REGSORT":1,"WHABBRNAME":"广东炬申$$GuangDong JUSHEN","WHROWS":6,"WGHTUNIT":"2","PRESPOTWGHTS":8365,"PREWRTWGHTS":2446,"SPOTWGHTS":7692,"WRTWGHTS":2072,"SPOTCHANGE":-673,"WRTCHANGE":-374,"PREWHSTOCKS":27554,"WHSTOCKS":27928,"WHSTOCKCHANGE":374,"ROWORDER":368,"ROWSTATUS":"0"},{"VARNAME":"铝$$ALUMINIUM","VARSORT":1,"REGNAME":"广东$$Guangdong","REGSORT":1,"WHABBRNAME":"合计$$Subtotal","WHROWS":6,"WGHTUNIT":"2","PRESPOTWGHTS":69490,"PREWRTWGHTS":15896,"SP...TCHANGE":"","WRTCHANGE":0,"PREWHSTOCKS":60000,"WHSTOCKS":60000,"WHSTOCKCHANGE":0,"ROWORDER":81,"ROWSTATUS":"0"},{"VARNAME":"热轧卷板$$HOT ROLLED COILS","VARSORT":14,"REGNAME":"江苏$$Jiangsu","REGSORT":2,"WHABBRNAME":"外运华东苏州$$Sinotrans Eastern Suzhou","WHROWS":8,"WGHTUNIT":"2","PRESPOTWGHTS":"","PREWRTWGHTS":0,"SPOTWGHTS":"","WRTWGHTS":0,"SPOTCHANGE":"","WRTCHANGE":0,"PREWHSTOCKS":45000,"WHSTOCKS":45000,"WHSTOCKCHANGE":0,"ROWORDER":83,"ROWSTATUS":"0"},{"VARNAME":"热轧卷板$$HOT ROLLED COILS","VARSORT":14,"REGNAME":"江苏$$Jiangsu","REGSORT":2,"WHABBRNAME":"中储南京$$Zhongchu Nanjing","WHROWS":8,"WGHTUNIT":"2","PRESPOTWGHTS":"","PREWRTWGHTS":5532,"SPOTWGHTS":"","WRTWGHTS":4610,"SPOTCHANGE":"","WRTCHANGE":-922,"PREWHSTOCKS":39468,"WHSTOCKS":40390,"WHSTOCKCHANGE":922,"ROWORDER":86,"ROWSTATUS":"0"},{"VARNAME":"热轧卷板$$HOT ROLLED COILS","VARSORT":14,"REGNAME":"江苏$$Jiangsu","REGSORT":2,"WHABBRNAME":"无锡国联$$Wuxi Guolian","WHROWS":8,"WGHTUNIT":"2","PRESPOTWGHTS":"","PREWRTWGHTS":0,"SPOTWGHTS":"","WRTWGHTS":0,"SPOTCHANGE":"","WRTCHANGE":0,"PREWHSTOCKS":45000,"WHSTOCKS":45000,"WHSTOCKCHANGE":0,"ROWORDER":318,"ROWSTATUS":"0"},{"VARNAME":"热轧卷板$$HOT ROLLED COILS","VARSORT":14,"REGNAME":"江苏$$Jiangsu","REGSORT":2,"WHABBRNAME":"玖隆物流$$JIULONG STEEL LOGISTICS","WHROWS":8,"WGHTUNIT":"2","PRESPOTWGHTS":"","PREWRTWGHTS":605,"SPOTWGHTS":"","WRTWGHTS":292,"SPOTCHANGE":"","WRTCHANGE":-313,"PREWHSTOCKS":149395,"WHSTOCKS":149708,"WHSTOCKCHANGE":313,"ROWORDER":531,"ROWSTATUS":"0"},{"VARNAME":"热轧卷板$$HOT ROLLED COILS","VARSORT":14,"REGNAME":"江苏$$Jiangsu","REGSORT":2,"WHABBRNAME":"合计$$Subtotal","WHROWS":8,"WGHTUNIT":"2","PRESPOTWGHTS":"","PREWRTWGHTS":6137,"SPOTWGHTS":"","WRTWGHTS":4902,"SPOTCHANGE":"","WRTCHANGE":-1235,"PREWHSTOCKS":758863,"WHSTOCKS":760098,"WHSTOCKCHANGE":1235,"ROWORDER":100000,"ROWSTATUS":"1"},{"VARNAME":"热轧卷板$$HOT ROLLED COILS","VARSORT":14,"REGNAME":"浙江$$Zhejiang","REGSORT":3,"WHABBRNAME":"康运崇贤库$$Kangyun Chongxian","WHROWS":3,"WGHTUNIT":"2","PRESPOTWGHTS":"","PREWRTWGHTS":0,"SPOTWGHTS":"","WRTWGHTS":0,"SPOTCHANGE":"","WRTCHANGE":0,"PREWHSTOCKS":36000,"WHSTOCKS":36000,"WHSTOCKCHANGE":0,"ROWORDER":68,"ROWSTATUS":"0"},{"VARNAME":"热轧卷板$$HOT ROLLED COILS","VARSORT":14,"REGNAME":"浙江$$Zhejiang","REGSORT":3,"WHABBRNAME":"宁波九龙仓$$Ningbo Jiulongcang","WHROWS":3,"WGHTUNIT":"2","PRESPOTWGHTS":"","PREWRTWGHTS":0,"SPOTWGHTS":"","WRTWGHTS":0,"SPOTCHANGE":"","WRTCHANGE":0,"PREWHSTOCKS":60000,"WHSTOCKS":60000,"WHSTOCKCHANGE":0,"ROWORDER":327,"ROWSTATUS":"0"},{"VARNAME":"热轧卷板$$HOT ROLLED COILS","VARSORT":14,"REGNAME":"浙江$$Zhejiang","REGSORT":3,"WHABBRNAME":"合计$$Subtotal","WHROWS":3,"WGHTUNIT":"2","PRESPOTWGHTS":"","PREWRTWGHTS":0,"SPOTWGHTS":"","WRTWGHTS":0,"SPOTCHANGE":"","WRTCHANGE":0,"PREWHSTOCKS":96000,"WHSTOCKS":96000,"WHSTOCKCHANGE":0,"ROWORDER":100000,"ROWSTATUS":"1"},{"VARNAME":"热轧卷板$$HOT ROLLED COILS","VARSORT":14,"REGNAME":"天津$$Tianjin","REGSORT":8,"WHABBRNAME":"中储陆通$$Zhongchu Lutong","WHROWS":1,"WGHTUNIT":"2","PRESPOTWGHTS":"","PREWRTWGHTS":0,"SPOTWGHTS":"","WRTWGHTS":0,"SPOTCHANGE":"","WRTCHANGE":0,"PREWHSTOCKS":60000,"WHSTOCKS":60000,"WHSTOCKCHANGE":0,"ROWORDER":40,"ROWSTATUS":"0"},{"VARNAME":"热轧卷板$$HOT ROLLED COILS","VARSORT":14,"REGNAME":"湖北$$Hubei","REGSORT":9999,"WHABBRNAME":"中储汉口$$Zhongchu Hankou","WHROWS":1,"WGHTUNIT":"2","PRESPOTWGHTS":"","PREWRTWGHTS":0,"SPOTWGHTS":"","WRTWGHTS":0,"SPOTCHANGE":"","WRTCHANGE":0,"PREWHSTOCKS":12000,"WHSTOCKS":12000,"WHSTOCKCHANGE":0,"ROWORDER":88,"ROWSTATUS":"0"},{"VARNAME":"热轧卷板$$HOT ROLLED COILS","VARSORT":14,"REGNAME":"","REGSORT":999999999,"WHABBRNAME":"总计$$Total","WHROWS":1,"WGHTUNIT":"2","PRESPOTWGHTS":"","PREWRTWGHTS":6137,"SPOTWGHTS":"","WRTWGHTS":4902,"SPOTCHANGE":"","WRTCHANGE":-1235,"PREWHSTOCKS":1088863,"WHSTOCKS":1090098,"WHSTOCKCHANGE":1235,"ROWORDER":200000,"ROWSTATUS":"2"}],"o_cursorine":[{"VARNAME":"中质含硫原油$$Medium Sour Crude Oil","VARSORT":"2","REGNAME":"上海$$Shanghai","REGSORT":"1","WHABBRNAME":"洋山石油$$Yangshan Shengang","WHROWS":"3","OILROWS":"2","WGHTUNIT":"3","OILID":"006","OILNAME":"巴士拉轻油$$Basra Light","PRESPOTWGHTS":"0","PREWRTWGHTS":"650000","SPOTWGHTS":"0","WRTWGHTS":"650000","SPOTCHANGE":"0","WRTCHANGE":"0","PREWHSTOCKS":"--","WHSTOCKS":"--","WHSTOCKCHANGE":"--","ROWORDER":"8","ROWSTATUS":"0"},{"VARNAME":"中质含硫原油$$Medium Sour Crude Oil","VARSORT":"2","REGNAME":"上海$$Shanghai","REGSORT":"1","WHABBRNAME":"洋山石油$$Yangshan Shengang","WHROWS":"3","OILROWS":"2","WGHTUNIT":"3","OILID":"","OILNAME":"小计$$Subtotal","PRESPOTWGHTS":"0","PREWRTWGHTS":"650000","SPOTWGHTS":"0","WRTWGHTS":"650000","SPOTCHANGE":"0","WRTCHANGE":"0","PREWHSTOCKS":"610000","WHSTOCKS":"610000","WHSTOCKCHANGE":"0","ROWORDER":"8","ROWSTATUS":"0"},{"VARNAME":"中质含硫原油$$Medium Sour Crude Oil","VARSORT":"2","REGNAME":"上海$$Shanghai","REGSORT":"1","WHABBRNAME":"合计$$Subtotal","WHROWS":"3","OILROWS":"1","WGHTUNIT":"3","OILID":"","OILNAME":"","PRESPOTWGHTS":"0","PREWRTWGHTS":"650000","SPOTWGHTS":"0","WRTWGHTS":"650000","SPOTCHANGE":"0","WRTCHANGE":"0","PREWHSTOCKS":"610000","WHSTOCKS":"610000","WHSTOCKCHANGE":"0","ROWORDER":"100000","ROWSTATUS":"1"},{"VARNAME":"中质含硫原油$$Medium Sour Crude Oil","VARSORT":"2","REGNAME":"浙江$$Zhejiang","REGSORT":"2","WHABBRNAME":"中国石化册子岛$$SPRC Cezidao","WHROWS":"7","OILROWS":"2","WGHTUNIT":"3","OILID":"006","OILNAME":"巴士拉轻油$$Basra Light","PRESPOTWGHTS":"0","PREWRTWGHTS":"0","SPOTWGHTS":"0","WRTWGHTS":"0","SPOTCHANGE":"0","WRTCHANGE":"0","PREWHSTOCKS":"--","WHSTOCKS":"--","WHSTOCKCHANGE":"--","ROWORDER":"2","ROWSTATUS":"0"},{"VARNAME":"中质含硫原油$$Medium Sour Crude Oil","VARSORT":"2","REGNAME":"浙江$$Zhejiang","REGSORT":"2","WHABBRNAME":"中国石化册子岛$$SPRC Cezidao","WHROWS":"7","OILROWS":"2","WGHTUNIT":"3","OILID":"","OILNAME":"小计$$Subtotal","PRESPOTWGHTS":"0","PREWRTWGHTS":"0","SPOTWGHTS":"0","WRTWGHTS":"0","SPOTCHANGE":"0","WRTCHANGE":"0","PREWHSTOCKS":"3036000","WHSTOCKS":"3036000","WHSTOCKCHANGE":"0","ROWORDER":"2","ROWSTATUS":"0"},{"VARNAME":"中质含硫原油$$Medium Sour Crude Oil","VARSORT":"2","REGNAME":"浙江$$Zhejiang","REGSORT":"2","WHABBRNAME":"中油大榭$$PetroChina Daxie","WHROWS":"7","OILROWS":"2","WGHTUNIT":"3","OILID":"","OILNAME":"","PRESPOTWGHTS":"0","PREWRTWGHTS":"0","SPOTWGHTS":"0","WRTWGHTS":"0","SPOTCHANGE":"0","WRTCHANGE":"0","PREWHSTOCKS":"--","WHSTOCKS":"--","WHSTOCKCHANGE":"--","ROWORDER":"3","ROWSTATUS":"0"},{"VARNAME":"中质含硫原油$$Medium Sour Crude Oil","VARSORT":"2","REGNAME":"浙江$$Zhejiang","REGSORT":"2","WHABBRNAME":"中油大榭$$PetroChina Daxie","WHROWS":"7","OILROWS":"2","WGHTUNIT":"3","OILID":"","OILNAME":"小计$$Subtotal","PRESPOTWGHTS":"0","PREWRTWGHTS":"0","SPOTWGHTS":"0","WRTWGHTS":"0","SPOTCHANGE":"0","WRTCHANGE":"0","PREWHSTOCKS":"2323000","WHSTOCKS":"2323000","WHSTOCKCHANGE":"0","ROWORDER":"3","ROWSTATUS":"0"},{"VARNAME":"中质含硫原油$$Medium Sour Crude Oil","VARSORT":"2","REGNAME":"浙江$$Zhejiang","REGSORT":"2","WHABBRNAME":"中化兴中$$Sinochem-Xingzhong","WHROWS":"7","OILROWS":"2","WGHTUNIT":"3","OILID":"006","OILNAME":"巴士拉轻油$$Basra Light","PRESPOTWGHTS":"0","PREWRTWGHTS":"1001000","SPOTWGHTS":"0","WRTWGHTS":"1001000","SPOTCHANGE":"0","WRTCHANGE":"0","PREWHSTOCKS":"--","WHSTOCKS":"--","WHSTOCKCHANGE":"--","ROWORDER":"5","ROWSTATUS":"0"},{"VARNAME":"中质含硫原油$$Medium Sour Crude Oil","VARSORT":"2","REGNAME":"浙江$$Zhejiang","REGSORT":"2","WHABBRNAME":"中化兴中$$Sinochem-Xingzhong","WHROWS":"7","OILROWS":"2","WGHTUNIT":"3","OILID":"","OILNAME":"小计$$Subtotal","PRESPOTWGHTS":"0","PREWRTWGHTS":"1001000","SPOTWGHTS":"0","WRTWGHTS":"1001000","SPOTCHANGE":"0","WRTCHANGE":"0","PREWHSTOCKS":"1100000","WHSTOCKS":"1100000","WHSTOCKCHANGE":"0","ROWORDER":"5","ROWSTATUS":"0"},{"VARNAME":"中质含硫原油$$Medium Sour Crude Oil","VARSORT":"2","REGNAME":"浙江$$Zhejiang","REGSORT":"2","WHABBRNAME":"合计$$Subtotal","WHROWS":"7","OILROWS":"1","WGHTUNIT":"3","OILID":"","OILNAME":"","PRESPOTWGHTS":"0","PREWRTWGHTS":"1001000","SPOTWGHTS":"0","WRTWGHTS":"1001000","SPOTCHANGE":"0","WRTCHANGE":"0","PREWHSTOCKS":"6459000","WHSTOCKS":"6459000","WHSTOCKCHANGE":"0","ROWORDER":"100000","ROWSTATUS":"1"},{"VARNAME":"中质含硫原油$$Medium Sour Crude Oil","VARSORT":"2","REGNAME":"山东$$Shandong","REGSORT":"3","WHABBRNAME":"中国石化日照$$SPRC Rizhao","WHROWS":"5","OILROWS":"2","WGHTUNIT":"3","OILID":"","OILNAME":"","PRESPOTWGHTS":"0","PREWRTWGHTS":"0","SPOTWGHTS":"0","WRTWGHTS":"0","SPOTCHANGE":"0","WRTCHANGE":"0","PREWHSTOCKS":"--","WHSTOCKS":"--","WHSTOCKCHANGE":"--","ROWORDER":"1","ROWSTATUS":"0"},{"VARNAME":"中质含硫原油$$Medium Sour Crude Oil","VARSORT":"2","REGNAME":"山东$$Shandong","REGSORT":"3","WHABBRNAME":"中国石化日照$$SPRC Rizhao","WHROWS":"5","OILROWS":"2","WGHTUNIT":"3","OILID":"","OILNAME":"小计$$Subtotal","PRESPOTWGHTS":"0","PREWRTWGHTS":"0","SPOTWGHTS":"0","WRTWGHTS":"0","SPOTCHANGE":"0","WRTCHANGE":"0","PREWHSTOCKS":"2024000","WHSTOCKS":"2024000","WHSTOCKCHANGE":"0","ROWORDER":"1","ROWSTATUS":"0"},{"VARNAME":"中质含硫原油$$Medium Sour Crude Oil","VARSORT":"2","REGNAME":"山东$$Shandong","REGSORT":"3","WHABBRNAME":"青岛港董家口$$Qingdao port DJK","WHROWS":"5","OILROWS":"2","WGHTUNIT":"3","OILID":"","OILNAME":"","PRESPOTWGHTS":"0","PREWRTWGHTS":"0","SPOTWGHTS":"0","WRTWGHTS":"0","SPOTCHANGE":"0","WRTCHANGE":"0","PREWHSTOCKS":"--","WHSTOCKS":"--","WHSTOCKCHANGE":"--","ROWORDER":"7","ROWSTATUS":"0"},{"VARNAME":"中质含硫原油$$Medium Sour Crude Oil","VARSORT":"2","REGNAME":"山东$$Shandong","REGSORT":"3","WHABBRNAME":"青岛港董家口$$Qingdao port DJK","WHROWS":"5","OILROWS":"2","WGHTUNIT":"3","OILID":"","OILNAME":"小计$$Subtotal","PRESPOTWGHTS":"0","PREWRTWGHTS":"0","SPOTWGHTS":"0","WRTWGHTS":"0","SPOTCHANGE":"0","WRTCHANGE":"0","PREWHSTOCKS":"2392000","WHSTOCKS":"2392000","WHSTOCKCHANGE":"0","ROWORDER":"7","ROWSTATUS":"0"},{"VARNAME":"中质含硫原油$$Medium Sour Crude Oil","VARSORT":"2","REGNAME":"山东$$Shandong","REGSORT":"3","WHABBRNAME":"合计$$Subtotal","WHROWS":"5","OILROWS":"1","WGHTUNIT":"3","OILID":"","OILNAME":"","PRESPOTWGHTS":"0","PREWRTWGHTS":"0","SPOTWGHTS":"0","WRTWGHTS":"0","SPOTCHANGE":"0","WRTCHANGE":"0","PREWHSTOCKS":"4416000","WHSTOCKS":"4416000","WHSTOCKCHANGE":"0","ROWORDER":"100000","ROWSTATUS":"1"},{"VARNAME":"中质含硫原油$$Medium Sour Crude Oil","VARSORT":"2","REGNAME":"广东$$Guangdong","REGSORT":"4","WHABBRNAME":"中油湛江$$PetroChina Zhanjiang","WHROWS":"3","OILROWS":"2","WGHTUNIT":"3","OILID":"006","OILNAME":"巴士拉轻油$$Basra Light","PRESPOTWGHTS":"0","PREWRTWGHTS":"162000","SPOTWGHTS":"0","WRTWGHTS":"162000","SPOTCHANGE":"0","WRTCHANGE":"0","PREWHSTOCKS":"--","WHSTOCKS":"--","WHSTOCKCHANGE":"--","ROWORDER":"4","ROWSTATUS":"0"},{"VARNAME":"中质含硫原油$$Medium Sour Crude Oil","VARSORT":"2","REGNAME":"广东$$Guangdong","REGSORT":"4","WHABBRNAME":"中油湛江$$PetroChina Zhanjiang","WHROWS":"3","OILROWS":"2","WGHTUNIT":"3","OILID":"","OILNAME":"小计$$Subtotal","PRESPOTWGHTS":"0","PREWRTWGHTS":"162000","SPOTWGHTS":"0","WRTWGHTS":"162000","SPOTCHANGE":"0","WRTCHANGE":"0","PREWHSTOCKS":"2078000","WHSTOCKS":"2078000","WHSTOCKCHANGE":"0","ROWORDER":"4","ROWSTATUS":"0"},{"VARNAME":"中质含硫原油$$Medium Sour Crude Oil","VARSORT":"2","REGNAME":"广东$$Guangdong","REGSORT":"4","WHABBRNAME":"合计$$Subtotal","WHROWS":"3","OILROWS":"1","WGHTUNIT":"3","OILID":"","OILNAME":"","PRESPOTWGHTS":"0","PREWRTWGHTS":"162000","SPOTWGHTS":"0","WRTWGHTS":"162000","SPOTCHANGE":"0","WRTCHANGE":"0","PREWHSTOCKS":"2078000","WHSTOCKS":"2078000","WHSTOCKCHANGE":"0","ROWORDER":"100000","ROWSTATUS":"1"},{"VARNAME":"中质含硫原油$$Medium Sour Crude Oil","VARSORT":"2","REGNAME":"辽宁$$Liaoning","REGSORT":"5","WHABBRNAME":"中油大连$$PetroChina Dalian","WHROWS":"3","OILROWS":"2","WGHTUNIT":"3","OILID":"003","OILNAME":"阿曼原油$$Oman","PRESPOTWGHTS":"0","PREWRTWGHTS":"300000","SPOTWGHTS":"0","WRTWGHTS":"300000","SPOTCHANGE":"0","WRTCHANGE":"0","PREWHSTOCKS":"--","WHSTOCKS":"--","WHSTOCKCHANGE":"--","ROWORDER":"6","ROWSTATUS":"0"},{"VARNAME":"中质含硫原油$$Medium Sour Crude Oil","VARSORT":"2","REGNAME":"辽宁$$Liaoning","REGSORT":"5","WHABBRNAME":"中油大连$$PetroChina Dalian","WHROWS":"3","OILROWS":"2","WGHTUNIT":"3","OILID":"","OILNAME":"小计$$Subtotal","PRESPOTWGHTS":"0","PREWRTWGHTS":"300000","SPOTWGHTS":"0","WRTWGHTS":"300000","SPOTCHANGE":"0","WRTCHANGE":"0","PREWHSTOCKS":"1800000","WHSTOCKS":"1800000","WHSTOCKCHANGE":"0","ROWORDER":"6","ROWSTATUS":"0"},{"VARNAME":"中质含硫原油$$Medium Sour Crude Oil","VARSORT":"2","REGNAME":"辽宁$$Liaoning","REGSORT":"5","WHABBRNAME":"合计$$Subtotal","WHROWS":"3","OILROWS":"1","WGHTUNIT":"3","OILID":"","OILNAME":"","PRESPOTWGHTS":"0","PREWRTWGHTS":"300000","SPOTWGHTS":"0","WRTWGHTS":"300000","SPOTCHANGE":"0","WRTCHANGE":"0","PREWHSTOCKS":"1800000","WHSTOCKS":"1800000","WHSTOCKCHANGE":"0","ROWORDER":"100000","ROWSTATUS":"1"},{"VARNAME":"中质含硫原油$$Medium Sour Crude Oil","VARSORT":"2","REGNAME":"","REGSORT":"999999999","WHABBRNAME":"总计$$Total","WHROWS":"","OILROWS":"","WGHTUNIT":"3","OILID":"","OILNAME":"","PRESPOTWGHTS":"0","PREWRTWGHTS":"2113000","SPOTWGHTS":"0","WRTWGHTS":"2113000","SPOTCHANGE":"0","WRTCHANGE":"0","PREWHSTOCKS":"15363000","WHSTOCKS":"15363000","WHSTOCKCHANGE":"0","ROWORDER":"200000","ROWSTATUS":"2"}],"o_cursorau":[{"PREWRTWGHTS":3651,"WRTWGHTS":3450,"WRTCHANGE":-201,"WGHTUNIT":"1"}],"o_cursorfu":[{"VARNAME":"燃料油$$FUEL OIL","VARSORT":"8","REGNAME":"上海$$Shanghai","REGSORT":"0","WHABBRNAME":"洋山石油$$Yangshan Shengang","WHROWS":"3","WGHTUNIT":"2","PRESPOTWGHTS":"7335","PREWRTWGHTS":"0","SPOTWGHTS":"7335","WRTWGHTS":"0","SPOTCHANGE":"0","WRTCHANGE":"0","GRDNAME":"RMG380（硫Ⅰ级）","PREWHSTOCKS":"--","WHSTOCKS":"--","WHSTOCKCHANGE":"--","ROWORDER":"58","ROWSTATUS":"0"},{"VARNAME":"燃料油$$FUEL OIL","VARSORT":"8","REGNAME":"上海$$Shanghai","REGSORT":"0","WHABBRNAME":"洋山石油$$Yangshan Shengang","WHROWS":"3","WGHTUNIT":"2","PRESPOTWGHTS":"7335","PREWRTWGHTS":"0","SPOTWGHTS":"7335","WRTWGHTS":"0","SPOTCHANGE":"0","WRTCHANGE":"0","GRDNAME":"小计$$Subtotal","PREWHSTOCKS":"200000","WHSTOCKS":"200000","WHSTOCKCHANGE":"0","ROWORDER":"100000","ROWSTATUS":"0"},{"VARNAME":"燃料油$$FUEL OIL","VARSORT":"8","REGNAME":"上海$$Shanghai","REGSORT":"0","WHABBRNAME":"合计$$Subtotal","WHROWS":"3","WGHTUNIT":"2","PRESPOTWGHTS":"7335","PREWRTWGHTS":"0","SPOTWGHTS":"7335","WRTWGHTS":"0","SPOTCHANGE":"0","WRTCHANGE":"0","GRDNAME":"","PREWHSTOCKS":"200000","WHSTOCKS":"200000","WHSTOCKCHANGE":"0","ROWORDER":"100000","ROWSTATUS":"2"},{"VARNAME":"燃料油$$FUEL OIL","VARSORT":"8","REGNAME":"浙江$$Zhejiang","REGSORT":"3","WHABBRNAME":"海洋仓储$$Zhejiang Offshore","WHROWS":"5","WGHTUNIT":"2","PRESPOTWGHTS":"26000","PREWRTWGHTS":"0","SPOTWGHTS":"26000","WRTWGHTS":"0","SPOTCHANGE":"0","WRTCHANGE":"0","GRDNAME":"RMG380（硫Ⅰ级）","PREWHSTOCKS":"--","WHSTOCKS":"--","WHSTOCKCHANGE":"--","ROWORDER":"59","ROWSTATUS":"0"},{"VARNAME":"燃料油$$FUEL OIL","VARSORT":"8","REGNAME":"浙江$$Zhejiang","REGSORT":"3","WHABBRNAME":"海洋仓储$$Zhejiang Offshore","WHROWS":"5","WGHTUNIT":"2","PRESPOTWGHTS":"26000","PREWRTWGHTS":"0","SPOTWGHTS":"26000","WRTWGHTS":"0","SPOTCHANGE":"0","WRTCHANGE":"0","GRDNAME":"小计$$Subtotal","PREWHSTOCKS":"57000","WHSTOCKS":"57000","WHSTOCKCHANGE":"0","ROWORDER":"100000","ROWSTATUS":"0"},{"VARNAME":"燃料油$$FUEL OIL","VARSORT":"8","REGNAME":"浙江$$Zhejiang","REGSORT":"3","WHABBRNAME":"中化兴中$$Sinochem-Xingzhong","WHROWS":"5","WGHTUNIT":"2","PRESPOTWGHTS":"150000","PREWRTWGHTS":"9190","SPOTWGHTS":"150000","WRTWGHTS":"9190","SPOTCHANGE":"0","WRTCHANGE":"0","GRDNAME":"RMG380（硫Ⅰ级）","PREWHSTOCKS":"--","WHSTOCKS":"--","WHSTOCKCHANGE":"--","ROWORDER":"57","ROWSTATUS":"0"},{"VARNAME":"燃料油$$FUEL OIL","VARSORT":"8","REGNAME":"浙江$$Zhejiang","REGSORT":"3","WHABBRNAME":"中化兴中$$Sinochem-Xingzhong","WHROWS":"5","WGHTUNIT":"2","PRESPOTWGHTS":"150000","PREWRTWGHTS":"9190","SPOTWGHTS":"150000","WRTWGHTS":"9190","SPOTCHANGE":"0","WRTCHANGE":"0","GRDNAME":"小计$$Subtotal","PREWHSTOCKS":"140810","WHSTOCKS":"140810","WHSTOCKCHANGE":"0","ROWORDER":"100000","ROWSTATUS":"0"},{"VARNAME":"燃料油$$FUEL OIL","VARSORT":"8","REGNAME":"浙江$$Zhejiang","REGSORT":"3","WHABBRNAME":"合计$$Subtotal","WHROWS":"5","WGHTUNIT":"2","PRESPOTWGHTS":"176000","PREWRTWGHTS":"9190","SPOTWGHTS":"176000","WRTWGHTS":"9190","SPOTCHANGE":"0","WRTCHANGE":"0","GRDNAME":"","PREWHSTOCKS":"197810","WHSTOCKS":"197810","WHSTOCKCHANGE":"0","ROWORDER":"100000","ROWSTATUS":"2"},{"VARNAME":"燃料油$$FUEL OIL","VARSORT":"8","REGNAME":"","REGSORT":"999999999","WHABBRNAME":"总计$$Total","WHROWS":"1","WGHTUNIT":"2","PRESPOTWGHTS":"183335","PREWRTWGHTS":"9190","SPOTWGHTS":"183335","WRTWGHTS":"9190","SPOTCHANGE":"0","WRTCHANGE":"0","GRDNAME":"","PREWHSTOCKS":"397810","WHSTOCKS":"397810","WHSTOCKCHANGE":"0","ROWORDER":"200000","ROWSTATUS":"3"}],"o_cursormonwrtexpr":[],"o_cursororigincont":[],"o_code":"0","o_msg":"库存周报查询成功","report_date":"20190412","update_date":"20190412 20:00:52","print_date":"20190412 20:00:59"}

        */

    }
}
