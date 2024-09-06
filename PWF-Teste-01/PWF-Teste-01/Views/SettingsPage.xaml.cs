using System.Windows.Controls;

using PWF_Teste_01.ViewModels;

namespace PWF_Teste_01.Views
{
    public partial class SettingsPage : Page
    {
        public SettingsPage(SettingsViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
