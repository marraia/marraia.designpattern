using marraia.designpatterns.Factory.Entidades.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace marraia.designpatterns.Factory
{
    public abstract class VeiculoFactory
    {
        public abstract IVeiculo ObterCalculoVeiculo(string veiculo);
    }
}
