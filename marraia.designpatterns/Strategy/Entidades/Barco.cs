using marraia.designpatterns.Strategy.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace marraia.designpatterns.Strategy.Entidades
{
    public class Barco : ITransporte
    {
        public PontoMapa ObterInformacoes()
        {
            return new PontoMapa() { Latitude = 3000, Longitude = 4000, Meio = "Barco" };
        }
    }
}
