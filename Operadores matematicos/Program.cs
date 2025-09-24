using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_matematicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1 = 15.5;
            double numero2 = 10;
            double resultado = numero1 + numero2;   
            Console.WriteLine("Resultado de " + numero1 + " + " + numero2 + " = " + resultado);

            // Subtração
            double resultadoSubtracao = numero1 - numero2;
            Console.WriteLine("Resultado de " + numero1 + " - " + numero2 + " = " + resultadoSubtracao);

            // Multiplicação
            double resultadoMultiplicacao = numero1 * numero2;
            Console.WriteLine("Resultado de " + numero1 + " * " + numero2 + " = " + resultadoMultiplicacao);

            // Divisão
            double resultadoDivisao = numero1 / numero2;
            Console.WriteLine("Resultado de " + numero1 + " / " + numero2 + " = " + resultadoDivisao);

            //Resto da divisão
            int numero3 = 4;
            int numero4 = 3;
            int resultadoResto = numero3 % numero4; // Resto da divisão entre 4/3
            Console.WriteLine($"O resto da divisão entre {numero3} e {numero4} é: {resultadoResto}");

            //Somar ou subtrair um valor ao conteudo de uma variável
            double numero5 = 10;
            numero5 = numero5 + 10; // Adiciona 10 ao valor atual de numero5
            // ou escreva assim:
            numero5 = 10;
            numero5 += 10; //resultado é 20

            //isto feito a cima valhe tanto para divisao, multiplicação e subtração


            //incremento e decremento
            double numero6 = 2;
            double numero7 = 2;
            Console.WriteLine($"Se eu adicionar ++ a variavel ela ganhara 1 em sua soma, e se eu adicionar -- à variavel ela perdera 1: " +
            $"\n Numero 6 valhe 2, mas agora valhe {++numero6}" +
            $"\n Numero 7 valhe 2 mas agora valhe {--numero7}");
            Console.WriteLine("\n\n Apenas lembresse que precisa colocar tanto o ++ quanto o -- à esquerda da variavel, se colocar a direita nao ira funcionar\n Ex: {++numero12} ou {--numero12}");

            //Potenciação
            double potenciacao = Math.Pow(4,2); // O valor da base é 4 e o expoente é 2
            Console.WriteLine($"O valor da potenciação de 4 elecado a 2 é: {potenciacao}");

            //Radiciação

            double raiz = 3;
            double radiciacao = Math.Pow(27, 1 / raiz); // metodo para fazer raiz, coloca o valor do numero e depois 1 dividido pela raiz que deseja fazer
            Console.WriteLine($"O valor da radiciação de 27 é: {radiciacao}");

            //Maximo e o minimo

            double maximo = Math.Max(4, 8); // Retorna o maior valor entre 4 e 8, no caso 8
            Console.WriteLine(maximo);

            double minimo = Math.Min(4, 8); // Retorna o menor valor entre 4 e 8, no caso 4










        }
    }
}
