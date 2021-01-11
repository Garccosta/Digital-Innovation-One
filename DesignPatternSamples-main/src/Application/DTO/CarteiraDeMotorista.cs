using System;

namespace DesignPatternSamples.Application.DTO
{
    public class CarteiraDeMotorista
    {
        public int Registro { get; set; }
        public int Pontos { get; set; }
        public string UF { get; set; }
        public DateTime DataDeEmissao { get; set; }
        public DateTime Validade { get; set; }

    }
}