using System;
using System.Globalization;

namespace Exercicio2RaioDoCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro 
            //casas decimais conforme exemplos.
            double n = 3.14159;
            Console.WriteLine("Digite um Valor Para Cancular a AREA do Circulo");
            double raio = double.Parse (Console.ReadLine(),CultureInfo.InvariantCulture);

            double area = n * Math.Pow(raio,2.0);

            Console.WriteLine("AREA : " + area.ToString("F4"),CultureInfo.InvariantCulture);
            
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");//Quebra de Linha

            //Fazer um programa para ler quatro valores inteiros A, B, C e D.A seguir, calcule e mostre a diferença do produto
            //de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

            Console.WriteLine("Digite os Valores Respectivos de A,B,C e D para Calcular a Diferencia :");

            string[] v = Console.ReadLine().Split(' ');
            int a = int.Parse(v[0]);
            int b = int.Parse(v[1]);
            int c = int.Parse(v[2]);
            int d = int.Parse(v[3]);

            int soma = (a * b) - (c * d);

            Console.WriteLine("Diferenca ente A e B por C e D é :" + soma);
            
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");//quebra de Linha

            //Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o 
            //código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago
            
            Console.WriteLine("Digite o Numero da Peça 1 a Quantidade Desejada eo Preço : ");
            string[] v1= Console.ReadLine().Split(' ');
            double t1;
            int x1 = int.Parse(v1[0]);
            int x2 = int.Parse(v1[1]);
            double x3 = double.Parse(v1[2],CultureInfo.InvariantCulture);

            if (x2 > 1)
            {
                t1 = x2 *x3;
            }
            else { t1 = x3; }
            
            Console.WriteLine("Digite o Numero da Peça 2 a Quantidade Desejada eo Preço : ");
            string[] v2 = Console.ReadLine().Split(' ');
            double t2;
            int y1 = int.Parse(v2[0]);
            int y2 = int.Parse(v2[1]);
            double y3 = double.Parse(v2[2], CultureInfo.InvariantCulture);
            if (y2 > 1)
            {
                t2 = y2 * y3;
            }
            else { t2 = y3; }

            double total = t1 + t2;

            Console.WriteLine("TOTAL A PAGAR : " + total.ToString("F2"), CultureInfo.InvariantCulture);

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            /*Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. 
             * Em seguida, calcule e mostre:
            a) a área do triângulo retângulo que tem A por base e C por altura. = Area = base * altura / 2
            b) a área do círculo de raio C. (pi = 3.14159)= area = numero PI * raio ²
            c) a área do trapézio que tem A e B por bases e C por altura.= Area = (Base Maior + base Menor) / 2 * Altura
            d) a área do quadrado que tem lado B. = Area = Lados * Lados
            e) a área do retângulo que tem lados A e B = Area = Base*Altura   */

            Console.WriteLine("Digite os Valores Respectivos de A,B e C");
            string[] vet = Console.ReadLine().Split(' ');
            double A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double C = double.Parse(vet[2], CultureInfo.InvariantCulture);
            double at = (A * C) / 2;//Area do Triangulo
            double pi = 3.14159;
            double ac = pi * Math.Pow(C, 2.0);//Area do Circulo
            double atz = (A + B) / 2 * C;//Area do Trapézio
            double aq = B * B;// Area do Quadrado
            double ar = A * B;//Area do Retangulo
            Console.WriteLine("Area do Triangulo : " + at.ToString("F4"),CultureInfo.InvariantCulture);
            Console.WriteLine("Area do Circulo : " + ac.ToString("F4"),CultureInfo.InvariantCulture);
            Console.WriteLine("Area do Trapézio : " + atz.ToString("F4"),CultureInfo.InvariantCulture);
            Console.WriteLine("Area do Quadrado : " + aq.ToString("F4"),CultureInfo.InvariantCulture);
            Console.WriteLine("Area do Retangulo : " +ar.ToString("F2"),CultureInfo.InvariantCulture);





        }
    }
}
