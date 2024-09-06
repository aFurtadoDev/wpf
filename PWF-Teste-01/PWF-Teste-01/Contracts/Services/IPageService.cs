using System;
using System.Windows.Controls;

namespace PWF_Teste_01.Contracts.Services
{
    public interface IPageService
    {
        Type GetPageType(string key);

        Page GetPage(string key);
    }
}
