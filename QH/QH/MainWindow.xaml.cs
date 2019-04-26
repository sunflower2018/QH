using System.Windows;
using QH.ViewModel;
using QH.Command;

namespace QH
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Closing += (s, e) => ViewModelLocator.Cleanup();
        }

        private void menuItem导入_Click(object sender, RoutedEventArgs e)
        {
            ImportDataWindow window = new ImportDataWindow();
            window.ShowDialog();
        }
    }
}