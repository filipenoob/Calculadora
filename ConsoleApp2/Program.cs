using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomedeusuario = "";
            int operaçãoMatematica = 0;

            float numero1 = 0;
            float numero2 = 0;
            float resultado = 0;

            while (true)
            {


                Console.WriteLine("Por favor, insira seu Nome:");
                nomedeusuario = Console.ReadLine();

                Console.WriteLine($"Olá {nomedeusuario}, escolha uma das operações:");

                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Divisão");
                Console.WriteLine("4 - Multiplicação");
                Console.WriteLine("5 - Módulo");


                Console.Write("insira a opção desejada: ");

                try
                {
                    operaçãoMatematica = int.Parse(Console.ReadLine());
                }
                catch
                {
                    operaçãoMatematica = 0;

                }


                switch (operaçãoMatematica)
                {
                    case 1: //Adição
                        Console.WriteLine("Operação desejada, Adição");
                        break;
                    case 2: // Subtração
                        Console.WriteLine("Operação desejada, Subtração");
                        break;
                    case 3: // Divisão
                        Console.WriteLine("Operação desejada, Divisão");
                        break;
                    case 4: //Multiplicação
                        Console.WriteLine("Operação desejada, Multiplicação");
                        break;
                    case 5: //Modulo
                        Console.WriteLine("Operação desejada, Módulo");
                        break;
                    default:
                        operaçãoMatematica = 0;
                        Console.WriteLine("operação inválida :(");
                        break;

                }
                if (operaçãoMatematica > 0)

                {

                    bool converteucorretamente = false;


                    while (!converteucorretamente)
                    {
                        Console.Write("insira o 1º numero:");
                        converteucorretamente = float.TryParse(Console.ReadLine(), out numero1);

                        if (!converteucorretamente)
                            Console.WriteLine("Numero invalido, tente novamente !!!");
                    }
                    converteucorretamente = false;

                    while (!converteucorretamente)
                    {
                        Console.Write("insira o 2º numero:");
                        converteucorretamente = float.TryParse(Console.ReadLine(), out numero2);

                        if (!converteucorretamente)
                            Console.WriteLine("Numero inválido, tente novamente !!!");
                    }


                    if (operaçãoMatematica == 1) // Adição
                        resultado = numero1 + numero2;

                    else if (operaçãoMatematica == 2) // Subtração
                        resultado = numero1 - numero2;

                    else if (operaçãoMatematica == 3) // Divisão
                        resultado = numero1 / numero2;

                    else if (operaçãoMatematica == 4) // Multiplicação
                        resultado = numero1 * numero2;

                    else if (operaçãoMatematica == 5)// Módulo 
                        resultado = numero1 % numero2;


                    Console.WriteLine($"{nomedeusuario} o resultado da operação matemática é: {resultado}");


                }
                Console.WriteLine("");
            }

            // Console.ReadKey();
        }
    }
}
        
    

