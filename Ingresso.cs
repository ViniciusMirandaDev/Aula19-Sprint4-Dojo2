using System;

namespace Aula19_Sprint4_Dojo2
{
    public class Ingresso
    {
        public float IngressoPreco { get; set;}

        public void ImprimirValor(){
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("O valor do ingresso é: {0:c}", IngressoPreco);
        }
    }
}