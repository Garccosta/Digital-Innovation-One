using DesignPatternSamples.Application.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Application.Repository
{
    public interface IDetranVerificadorDePontosNaCarteiraRepository
    {
        Task<IEnumerable<PontosNaCarteira>> ConsultarPontosNaCarteira(CarteiraDeMotorista carteira);
    }
}
