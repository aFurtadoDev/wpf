using System.Windows.Controls;

using PWF_Teste_01.ViewModels;

namespace PWF_Teste_01.Views
{
    public partial class ListDetailsPage : Page
    {
        public ListDetailsPage(ListDetailsViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
