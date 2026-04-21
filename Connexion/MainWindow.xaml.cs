using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Connexion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ViewModels.ConnexionViewModel();
        }

        private void PwdBox_Changed(object s, RoutedEventArgs e)
            => ((ViewModels.ConnexionViewModel)DataContext).Credentials.MotDePasse = PwdBox.Password;
    }
}