using marraia.designpatterns.Strategy.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace marraia.designpatterns.Strategy.Abstract
{
    public interface ITransporte
    {
        PontoMapa ObterInformacoes();
    }
}
