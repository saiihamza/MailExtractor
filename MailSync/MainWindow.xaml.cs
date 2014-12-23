using System.Windows;
using MailSync.ViewModel;
using FirstFloor.ModernUI.Windows.Controls;

namespace MailSync
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private const string _imapLogin = "saii@bilog.fr";
        private const string _imapPassword = "OrtH9**78";
        private const int _imapPort = 993;
        private const string _imapServerAddress = "imap.gmail.com";

        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Closing += (s, e) => ViewModelLocator.Cleanup();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}