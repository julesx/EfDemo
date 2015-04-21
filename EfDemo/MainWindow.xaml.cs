using System.Windows;
using EfDemo.View_Models.Windows;

namespace EfDemo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainWindowVm();


        }
    }
}
