using marraia.designpatterns.Calculo;
using marraia.designpatterns.Strategy;
using marraia.designpatterns.Strategy.Entidades;
using System;

namespace marraia.designpatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Factory
            /*while (true)
            {
                Console.WriteLine("============ BEM VINDO A CORRETORA MARRAIA =======================");
                Console.WriteLine("Selecione o tipo de veiculo para calculo");
                Console.WriteLine("1-Carro | 2-Moto | 3-Caminhao");
                var opcao = int.Parse(Console.ReadLine());
                var tipo = string.Empty;

                switch (opcao)
                {
                    case 1:
                        tipo = "Carro";
                        break;
                    case 2:
                        tipo = "Moto";
                        break;
                    case 3:
                        tipo = "Caminhao";
                        break;
                    default:
                        break;
                }

                Console.WriteLine($"Informe o valor do veiculo {tipo}");
                var valor = double.Parse(Console.ReadLine());

                var seguro = new CalculoVeiculoFactory();
                var veiculo = seguro.ObterCalculoVeiculo(tipo);
                var valorSeguro = veiculo.Calcular(valor);

                Console.WriteLine($"Valor do Seguro -> {tipo} é de R$ {valorSeguro}");
            }*/
            #endregion

            #region Strategy
            var contexto = new Contexto();
            contexto.SetTransporte(new Barco());
            var pontoBarco = contexto.ObterInformacoes();
            Console.WriteLine($"Informaçoes do {pontoBarco.Meio} => Long: {pontoBarco.Longitude}");

            contexto.SetTransporte(new Aviao());
            var pontoAviao = contexto.ObterInformacoes();
            Console.WriteLine($"Informaçoes do {pontoAviao.Meio} => Long: {pontoAviao.Longitude}");

            Console.ReadKey();
            #endregion


        }
    }
}
