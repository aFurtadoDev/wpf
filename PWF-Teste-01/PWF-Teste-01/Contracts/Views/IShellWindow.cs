using System.Windows.Controls;

using MahApps.Metro.Controls;

using PWF_Teste_01.Behaviors;

namespace PWF_Teste_01.Contracts.Views
{
    public interface IShellWindow
    {
        Frame GetNavigationFrame();

        void ShowWindow();

        void CloseWindow();

        Frame GetRightPaneFrame();

        SplitView GetSplitView();

        RibbonTabsBehavior GetRibbonTabsBehavior();
    }
}
