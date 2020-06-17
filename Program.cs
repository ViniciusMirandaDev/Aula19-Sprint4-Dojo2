using System;

namespace Aula19_Sprint4_Dojo2
{
    class Program
    {
        static void Main(string[] args)
        {
            IngressoVIP palmeiras = new IngressoVIP();
            palmeiras.IngressoPreco= 25.5f;
            palmeiras.ImprimirValor();
            palmeiras.AdicionarValor();
        }
    }
}
