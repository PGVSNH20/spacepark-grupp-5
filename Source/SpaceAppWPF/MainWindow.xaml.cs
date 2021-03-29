using System.Windows;

namespace SpaceAppWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var searchPage = new SearchPage();
            InitializeComponent();
            mainWindow.Navigate(searchPage);
        }
    }
}