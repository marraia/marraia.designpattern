using marraia.designpatterns.Factory.Entidades.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace marraia.designpatterns.Factory.Entidades
{
    public class Caminhao : IVeiculo
    {
        public double Calcular(double valor)
        {
            return valor + (valor * 0.30);
        }
    }
}
