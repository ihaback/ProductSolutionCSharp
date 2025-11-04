using System.Windows;
using Presentation.WPFApp.ViewModels;

namespace Presentation.WPFApp
{
    public partial class MainWindow : Window
    {
        public MainWindow(MainViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}