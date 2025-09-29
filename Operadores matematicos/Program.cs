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

            Console.WriteLine("Explicação Operadores matematicos em C#\n");
            Console.WriteLine("Aperte 1 para aprender sobre Soma: \nAperte 2 para aprender sobre Subtração:");
            Console.WriteLine("Aperte 3 para aprender sobre Multiplicação: \nAperte 5 para aprender sobre Divisão:");
            Console.WriteLine("Aperte 5 para aprender sobre o Resto da divisão: \nAperte 6 para aprender sobre Potenciação:");
            Console.WriteLine("Aperte 7 para aprender sobre Radiciação: \nAperte 8 para aprender sobre Maximo e o minimo:");
            Console.WriteLine("Aperte 9 para aprender sobre Modulo: \nAperte 10 para aprender sobre Operações trigonométricas:");
            Console.WriteLine("Aperte 11 para aprender a arredondar numeros: \n");
            string input = Console.ReadLine();

            int escolha;
            if (int.TryParse(input, out escolha))
            {
                switch (escolha)
                {
                    case 1:
                        double numero1 = 15;
                        double numero2 = 10;
                        double resultado = numero1 + numero2;
                        Console.WriteLine("\nSoma");
                        Console.WriteLine("Para somar dois valores você ira utilizar o +");
                        Console.WriteLine("\nSe você tem o valor " + numero1 + " e deseja somar com o valor " + numero2 + " você ira iniciar outra variavel somando os dois valores, desta forma:\ndouble resultado = numero1 + numero2;");
                        Console.WriteLine("Exemplo:");
                        Console.WriteLine("Resultado da soma é:" + resultado + "\n");
                        break;

                    case 2:
                        numero1 = 15;
                        numero2 = 10;
                        double resultadoSubtracao = numero1 - numero2;
                        Console.WriteLine("\nSubtração");
                        Console.WriteLine("Para subtrair dois valores você ira utilizar o -");
                        Console.WriteLine("\nSe você tem o valor " + numero1 + " e deseja subtrair com o valor " + numero2 + " você ira iniciar outra variavel subtraindo os dois valores, desta forma:\ndouble resultadoSubtracao = numero1 - numero2;");
                        Console.WriteLine("Exemplo:");
                        Console.WriteLine("Resultado da subtração é:" + resultadoSubtracao + "\n");
                        Console.WriteLine("Se invertermos a ordem das variaveis ficara assim: ");
                        resultadoSubtracao = numero2 - numero1;
                        Console.WriteLine("Resultado da subtração é:" + resultadoSubtracao + "\n");
                        break;

                    case 3:
                        numero1 = 15;
                        numero2 = 10;
                        double resultadoMultiplicacao = numero1 * numero2;
                        Console.WriteLine("\nMultiplicação");
                        Console.WriteLine("Para multiplicar dois valores você ira utilizar o *");
                        Console.WriteLine("\nSe você tem o valor " + numero1 + " e deseja multiplicar com o valor " + numero2 + " você ira iniciar outra variavel multiplicar os dois valores, desta forma:\ndouble resultadoMultiplicacao = numero1 * numero2;");
                        Console.WriteLine("Exemplo:");
                        Console.WriteLine("Resultado da multiplicacão é:" + resultadoMultiplicacao + "\n");
                        Console.WriteLine("Se invertermos a ordem das variaveis o resultado não mudara.");
                        break;

                    case 4:
                        numero1 = 15;
                        numero2 = 10;
                        double resultadoDivisao = numero1 / numero2;
                        Console.WriteLine("\nDivisão");
                        Console.WriteLine("Para dividir dois valores você ira utilizar o /");
                        Console.WriteLine("\nSe você tem o valor " + numero1 + " e deseja dividir com o valor " + numero2 + " você ira iniciar outra variavel dividindo os dois valores, desta forma:\ndouble resultadoDivisao = numero1 / numero2;");
                        Console.WriteLine("Exemplo:");
                        Console.WriteLine("Resultado da divisão é:" + resultadoDivisao + "\n");
                        Console.WriteLine("Se invertermos a ordem das variaveis ficara assim: ");
                        resultadoSubtracao = numero2 / numero1;
                        Console.WriteLine("Resultado da divisão é:" + resultadoDivisao + "\n");
                        break;

                    case 5:
                        int numero3 = 4;
                        int numero4 = 3;
                        int resultadoResto = numero3 % numero4; // Resto da divisão entre 4/3
                        Console.WriteLine("\nResto da divisão");
                        Console.WriteLine("Para fazer o resto da da divisão você ira utilizar o %");
                        Console.WriteLine("\nSe você tem o valor " + numero3 + " e deseja pegar o resto da vicisão com o valor " + numero4 + " você ira iniciar outra variavel dividindo os dois valores, desta forma:\ndouble resultadoDivisao = numero1 / numero2;");
                        Console.WriteLine("Exemplo:");
                        Console.WriteLine("Resto da divisão é:" + resultadoResto + "\n");
                        Console.WriteLine("Se invertermos a ordem das variáveis, o resultado muda.\r\nQuando o número que está sendo dividido é menor que o divisor, o quociente é 0.\r\nPor isso, o resto da divisão será o próprio número dividido.");
                        break;

                    case 6:
                        Console.WriteLine("\nPotenciação");
                        double potenciacao = Math.Pow(4, 2);// O valor da base é 4 e o expoente é 2
                        Console.WriteLine("Para fazer uma potenciação você irá utilizar o método Math.Pow(base, expoente).");
                        Console.WriteLine("\nSe você tem a base 4 e deseja elevar ao expoente 2, você fará assim:\ndouble potenciacao = Math.Pow(4, 2)");
                        Console.WriteLine("\nExemplo:");
                        Console.WriteLine("O valor da potenciação de 4 elevado a 2 é: " + potenciacao + "\n");
                        Console.WriteLine("Lembre-se: o primeiro número é a base, e o segundo é o expoente.");
                        Console.WriteLine("Ou seja: 4^2 significa 4 multiplicado por 4, que resulta em 16.");
                        break;

                    case 7:
                        double raiz = 3;
                        double radiciacao = Math.Pow(27, 1 / raiz); // Aqui fazemos a raiz cúbica de 27
                        Console.WriteLine("\nRadiciação");
                        Console.WriteLine("Para fazer uma radiciação você vai usar o método Math.Pow(base, expoente / pela raiz.");
                        Console.WriteLine("A ideia é: número ^ (1 / índice da raiz).");
                        Console.WriteLine("\nSe você tem o número 27 e deseja calcular a raiz cúbica, faça assim:\ndouble radiciacao = Math.Pow(27, 1 / raiz);");
                        Console.WriteLine("\nExemplo:");
                        Console.WriteLine("O valor da raiz cúbica de 27 é: " + radiciacao + "\n");
                        Console.WriteLine("Lembre-se: a radiciação é o inverso da potenciação.");
                        Console.WriteLine("Ou seja, a raiz cúbica de 27 é 3, pois 3^3 = 27.");
                        break;

                    case 8:
                        double maximo = Math.Max(4, 8); // Retorna o maior valor entre dois números
                        double minimo = Math.Min(4, 8); // Retorna o menor valor entre dois números
                        Console.WriteLine("\nMáximo e Mínimo");
                        Console.WriteLine("Para descobrir o maior ou menor valor entre dois números usamos o método Math. :");
                        Console.WriteLine("Math.Max(valor1, valor2) retorna o maior valor entre os dois numeros");
                        Console.WriteLine("Math.Min(valor1, valor2) retonra o menor valor entre os dois numeros");
                        Console.WriteLine("\nExemplo com os números 4 e 8:");
                        Console.WriteLine("O maior valor é: " + maximo);
                        Console.WriteLine("O menor valor é: " + minimo + "\n");
                        break;

                    case 9:
                        double modulo = Math.Abs(-10); // O valor será 10
                        Console.WriteLine("\nMódulo");
                        Console.WriteLine("O módulo (ou valor absoluto) transforma qualquer número em positivo, para isso usamoso método Math.Abs(valor) :");
                        Console.WriteLine("\nExemplo com o número -10:");
                        Console.WriteLine($"O módulo de -10 é: {modulo} \n");
                        Console.WriteLine("Lembre-se: o módulo ignora o sinal do número.");
                        Console.WriteLine("Ou seja, -10 vira 10, e 10 continua sendo 10.");
                        break;

                    case 10:
                        Console.WriteLine("\nOperações trigonométricas");
                        break;

                    case 11:
                        double num = 3.33;
                        double arreddondandoParaCima = Math.Ceiling(num);
                        Console.WriteLine("\nArredondamento de números");
                        Console.WriteLine("Para arredondar números você ira utilizar do método Math.Ceiling(valor) para arredondar para cima e Math.Floor(valor) para arredondar para baixo.");
                        Console.WriteLine($"O numero 3.33 arredondado para cima ficara: {arreddondandoParaCima}");
                        double num1 = 5.55;
                        double arredondandoParaBaixo = Math.Floor(num1);
                        Console.WriteLine($"O numero 5.55 arredondado para baixo ficara:{arredondandoParaBaixo}");
                        break;

                    case 12:
                        double base10 = Math.Log10(100); 
                        double baseE1 = Math.Log(Math.E); 
                        double baseE2 = Math.Log(Math.E * Math.E * Math.E); // resultado é 3, pois e^3 = e * e * e
                        Console.WriteLine("\nLogaritmo");
                        Console.WriteLine("O logaritmo responde à pergunta:");
                        Console.WriteLine("'Qual expoente devo colocar na BASE para chegar no NÚMERO?'\n");
                        Console.WriteLine("No logaritmo temos 3 partes:");
                        Console.WriteLine("Base - o número fixo usado na potência");
                        Console.WriteLine("Expoente - o valor que queremos descobrir");
                        Console.WriteLine("Resultado - o número que obtemos com a potência\n");
                        Console.WriteLine("Ex 1: Logaritmo de base 10");
                        Console.WriteLine("Math.Log10(100) = " + base10);
                        Console.WriteLine("Aqui: BASE = 10, NÚMERO = 100, EXPOENTE = 2 (pois 10^2 = 100)\n");
                        Console.WriteLine("Ex 2: Logaritmo natural (base 'e')");
                        Console.WriteLine("O número 'e' é uma constante matemática ≈ 2,718, usada muito em cálculos científicos.");
                        Console.WriteLine("Math.Log(Math.E) = " + baseE1);
                        Console.WriteLine("Aqui: BASE = e, NÚMERO = e, EXPOENTE = 1 (pois e^1 = e)\n");
                        Console.WriteLine("Ex 3: Logaritmo natural de e³");
                        Console.WriteLine("Math.Log(e^3) = " + baseE2);
                        Console.WriteLine("Aqui: BASE = e, NÚMERO = e^3, EXPOENTE = 3 (pois e^3 = e * e * e)\n");
                        break;

                    case 13:
                        Console.WriteLine("\nOperadores de incremento e decremento");
                        double numero6 = 2;
                        Console.WriteLine($"Se eu adicionar ++ a variavel ela ganhara 1 em sua soma, e se eu adicionar -- à variavel ela perdera 1: " +
                        $"\n Numero 6 valhe 2, mas agora valhe {++numero6}" +
                        $"\n Numero 7 valhe 2 mas agora valhe {--numero6}");
                        Console.WriteLine("\n\n Apenas lembresse que precisa colocar tanto o ++ quanto o -- à esquerda da variavel, se colocar a direita nao ira funcionar\n Ex: {++numero12} ou {--numero12}");


                        break;

                }
            }
            else
            {
                Console.WriteLine("Entrada inválida! Digite um número.");

            }



            //colocar depois 

            //Somar ou subtrair um valor ao conteudo de uma variável
            double numero5 = 10;
           numero5 = numero5 + 10; // Adiciona 10 ao valor atual de numero5
            // ou escreva assim:
           numero5 = 10;
           numero5 += 10; //resultado é 20

            //isto feito a cima valhe tanto para divisao, multiplicação e subtração
          //
            //incremento e decremento
 

            //
            //operacoes trigonometricas

            double angulo = 30 * (2*Math.PI) / 360; // fazer assim para converter graus em radianos
            double seno = Math.Sin(angulo); // Seno do angulo
            Console.WriteLine(angulo);
            //Seno - Sin
            //Cosseno - Cos
            //Tangente - Tan


            //Arcseno - Asin
            //Arccosseno - Acos
            //Arctangente - Atan

            double arcSeno = Math.Asin(seno); // transforma o valor do seno em angulo
            Console.WriteLine(arcSeno); // deu o angulo em radianos
            double arcSenoGraus = arcSeno * 360 / (2 * Math.PI);
            Console.WriteLine(arcSenoGraus); // deu o angulo em graus





        }
    }
}
