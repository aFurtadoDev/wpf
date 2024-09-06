using System.Windows.Controls;

using PWF_Teste_01.ViewModels;

namespace PWF_Teste_01.Views
{
    public partial class ContentGridPage : Page
    {
        public ContentGridPage(ContentGridViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
