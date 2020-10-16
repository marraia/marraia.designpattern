using marraia.designpatterns.Factory;
using marraia.designpatterns.Factory.Entidades;
using marraia.designpatterns.Factory.Entidades.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace marraia.designpatterns.Calculo
{
    public class CalculoVeiculoFactory : VeiculoFactory
    {
        public override IVeiculo ObterCalculoVeiculo(string veiculo)
        {
            switch (veiculo)
            {
                case "Carro":
                    return new Carro();
                case "Moto":
                    return new Moto();
                case "Caminhao":
                    return new Caminhao();
                default:
                    throw new Exception($"O veiculo {veiculo} não pode ser calculado, pois não faz parte de nossa corretora");
            }
        }
    }
}
