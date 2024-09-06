using System.Threading.Tasks;

namespace PWF_Teste_01.Contracts.Activation
{
    public interface IActivationHandler
    {
        bool CanHandle();

        Task HandleAsync();
    }
}
