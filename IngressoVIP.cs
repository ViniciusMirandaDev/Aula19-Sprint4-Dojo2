using System;

namespace Aula19_Sprint4_Dojo2
{
    public class IngressoVIP : Ingresso
    {
        public float ValorAdicional = 20.0f;

        public void AdicionarValor(){
            float valorVIP = IngressoPreco + ValorAdicional;
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine("O valor do ingresso VIP é: {0:c}", valorVIP);
        }
    }
}