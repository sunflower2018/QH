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
          
            string r1= win.Util.Util_Http.HttpGet("http://www.100ppi.com/sf2/day-2018-04-17.html", string.Empty);

        }
   
    }
}
