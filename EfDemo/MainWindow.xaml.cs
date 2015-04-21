using System.Windows;
using EfDemo.View_Models.Windows;

namespace EfDemo
{
    public partial class MainWindow : Window
    {
        private readonly MainWindowVm _mainWindowVm;

        public MainWindow()
        {
            InitializeComponent();

            DataContext = _mainWindowVm = new MainWindowVm();

            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            _mainWindowVm.InitTabVms();
        }
    }
}
