using System.Windows.Controls;

using PWF_Teste_01.ViewModels;

namespace PWF_Teste_01.Views
{
    public partial class MainPage : Page
    {
        public MainPage(MainViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
