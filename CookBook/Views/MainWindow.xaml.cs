using System.Windows;

namespace CookBook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {

            Close();
        }
    }
}
