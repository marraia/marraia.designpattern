using marraia.designpatterns.Strategy.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace marraia.designpatterns.Strategy.Entidades
{
    public class Aviao : ITransporte
    {
        public PontoMapa ObterInformacoes()
        {
            return new PontoMapa() { Latitude = 1000, Longitude = 2000, Meio = "Avião" };
        }
    }
}
