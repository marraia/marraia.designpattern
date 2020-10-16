using marraia.designpatterns.Facade.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace marraia.designpatterns.Facade
{
    public class CarroFacade
    {
        CarroAcessorios acessorios;
        CarroModelo carroModelo;
        CarroMotor carroMotor;

        public CarroFacade()
        {
            acessorios = new CarroAcessorios();
            carroModelo = new CarroModelo();
            carroMotor = new CarroMotor();
        }

        public string ObterInformacoes()
        {
            var info = string.Empty;
            foreach (var item in acessorios.Acessorios)
            {
                info += "=>" + item;
            }

            info += carroModelo.NomeModelo;
            info += carroMotor.Cilindradas;

            return info;
        }
    }
}
