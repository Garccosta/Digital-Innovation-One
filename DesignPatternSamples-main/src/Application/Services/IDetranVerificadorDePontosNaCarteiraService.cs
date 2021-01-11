using DesignPatternSamples.Application.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Application.Services
{
    public interface IDetranVerificadorDePontosNaCarteiraService
    {
        Task<IEnumerable<PontosNaCarteira>> ConsultarPontosNaCarteira(CarteiraDeMotorista carteira);

    }
}