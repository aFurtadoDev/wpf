using System.Collections.Generic;
using System.Threading.Tasks;

using PWF_Teste_01.Core.Models;

namespace PWF_Teste_01.Core.Contracts.Services
{
    public interface ISampleDataService
    {
        Task<IEnumerable<SampleOrder>> GetContentGridDataAsync();

        Task<IEnumerable<SampleOrder>> GetGridDataAsync();

        Task<IEnumerable<SampleOrder>> GetListDetailsDataAsync();
    }
}
