using System;

namespace DesignPatternSamples.Application.Repository
{
    public interface IDetranVerificadorDePontosNaCarteiraFactory
    {
        public IDetranVerificadorDePontosNaCarteiraFactory Register(string UF, Type repository);
        public IDetranVerificadorDePontosNaCarteiraRepository Create(string UF);
    }
}
