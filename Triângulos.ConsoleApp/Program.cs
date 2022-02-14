using System;

namespace Triângulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String opcao;
            do
            {
                int lado1, lado2, lado3;

                Console.WriteLine(" digite 1 para verificar qual o tipo de triângulo");
                Console.WriteLine(" digite S para sair");
                opcao = Console.ReadLine();


                switch (opcao)
                {
                    case "1":
                        Console.WriteLine(" Digite o valor do lado 1: ");
                        lado1 = int.Parse(Console.ReadLine());

                        Console.WriteLine(" Digite o valor do lado 2: ");
                        lado2 = int.Parse(Console.ReadLine());

                        Console.WriteLine(" Digite o valor do lado 3: ");
                        lado3 = int.Parse(Console.ReadLine());

                       


                        if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
                        {
                            Console.WriteLine(" Existe um triângulo ");

                            if (lado1 == lado2 && lado2 == lado3)
                                Console.WriteLine(" Triângulo equilátero ");
                            else if (lado1 == lado2 && lado1 == lado3 && lado2 == lado3)
                                Console.WriteLine(" Triângulo isósceles ");
                            else
                                Console.WriteLine(" Triângulo escaleno ");


                        }
                        else Console.WriteLine(" Trângulo inválido ");

                        break;
                    case "S":
                        break;

                }

            }
            while (opcao == "1");

        }
    }
}

