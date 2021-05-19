using System.Windows;

namespace PointOfSale
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

        public void SwapScreenMain(UIElement element)
        {
            MainContainer.Child = element;
        }
    }
}
