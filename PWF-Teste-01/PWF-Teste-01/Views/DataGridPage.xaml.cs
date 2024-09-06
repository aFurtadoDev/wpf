using System.Windows.Controls;

using PWF_Teste_01.ViewModels;

namespace PWF_Teste_01.Views
{
    public partial class DataGridPage : Page
    {
        public DataGridPage(DataGridViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
