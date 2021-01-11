using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Repository;
using DesignPatternSamples.Application.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Application.Implementations
{
    public class DetranVerificadorDePontosNaCarteiraServices : IDetranVerificadorDePontosNaCarteiraService
    {
        private readonly IDetranVerificadorDePontosNaCarteiraFactory _Factory;

        public DetranVerificadorDePontosNaCarteiraServices(IDetranVerificadorDePontosNaCarteiraFactory factory)
        {
            _Factory = factory;
        }

        public Task<IEnumerable<PontosNaCarteira>> ConsultarPontosNaCarteira(CarteiraDeMotorista carteira)
        {
            IDetranVerificadorDePontosNaCarteiraRepository repository = _Factory.Create(carteira.UF);
            return repository.ConsultarPontosNaCarteira(carteira);
        }

    }
}
