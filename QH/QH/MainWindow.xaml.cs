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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            ImportCommand command = new ImportCommand();
            command.Execute(null);
        }
    }
}