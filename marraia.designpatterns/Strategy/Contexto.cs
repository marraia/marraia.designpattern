using marraia.designpatterns.Strategy.Abstract;
using marraia.designpatterns.Strategy.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace marraia.designpatterns.Strategy
{
    public class Contexto
    {
        private ITransporte _transporte;

        public Contexto() { }
        public Contexto(ITransporte transporte)
        {
            _transporte = transporte;
        }
        public void SetTransporte(ITransporte transporte)
        {
            this._transporte = transporte;
        }

        public PontoMapa ObterInformacoes()
        {
            return this._transporte.ObterInformacoes();
        }
    }
}
