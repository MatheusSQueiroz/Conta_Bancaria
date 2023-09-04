using Conta_Bancaria.Model;

namespace Conta_Bancaria
{
    internal class Program
    {
        private static ConsoleKeyInfo consoleKeyInfo;

        static void Main(string[] args)
        {
            int option;

            Conta_Corrente cc1 = new Conta_Corrente(2, 987, 1, "Queiroz", 900000.00M, 10000);
            cc1.Visualizar();

            cc1.Sacar(1000000.00M);

            cc1.Visualizar();

            cc1.Depositar(5000);

            cc1.Visualizar();

            Conta_Poupanca cp1 = new Conta_Poupanca(3, 987, 2, "Zézinho", 900000.00M, 05);

            cp1.Visualizar();

            cp1.Depositar(10000);

            cp1.Visualizar();

            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                Console.WriteLine("**************************************************************");
                Console.WriteLine("*                                                            *");
                Console.WriteLine("*                                                            *");
                Console.WriteLine("*                    BANCO DO BRAZIL COM Z                   *");
                Console.WriteLine("*                                                            *");
                Console.WriteLine("*                                                            *");
                Console.WriteLine("**************************************************************");
                Console.WriteLine("*                1 - Criar conta                             *");
                Console.WriteLine("*                2 - Listar todas as contas                  *");
                Console.WriteLine("*                3 - Buscar conta por número                 *");
                Console.WriteLine("*                4 - Atualizar dados da conta                *");
                Console.WriteLine("*                5 - Apagar Conta                            *");
                Console.WriteLine("*                6 - Sacar                                   *");
                Console.WriteLine("*                7 - Depositar                               *");
                Console.WriteLine("*                8 - Transferir valores entre contas         *");
                Console.WriteLine("*                9 - Sair                                    *");
                Console.WriteLine("**************************************************************");
                Console.WriteLine("*                Entre com a opção desejada:                 *");
                Console.WriteLine("**************************************************************");
                option = Convert.ToInt32(Console.ReadLine());

                if(option == 9)
                {
                    Console.WriteLine("\nBanco do Brazil com Z, o seu futuro começa aqui!");
                    Sobre();
                    System.Environment.Exit(0);
                }

                switch(option)
                {
                    case 1: Console.WriteLine("Criar conta:\n");

                        KeyPress();
                        break;

                    case 2: Console.WriteLine("Listar todas as contas:\n");

                        KeyPress();
                        break;

                    case 3: Console.WriteLine("Buscar conta por número:\n");

                        KeyPress();
                        break;

                    case 4: Console.WriteLine("Atualizar dados da conta:\n");

                        KeyPress();
                        break;

                    case 5: Console.WriteLine("Apagar conta:\n");

                        KeyPress();
                        break;

                    case 6: Console.WriteLine("Sacar:\n");

                        KeyPress();
                        break;

                    case 7: Console.WriteLine("Depositar:\n");

                        KeyPress();
                        break;

                    case 8: Console.WriteLine("Transferência de valores entre contas:\n");

                        KeyPress();
                        break;

                    default:
                        Console.WriteLine("Digite uma opção válida!");

                        KeyPress();
                        break;
                }
            }
        }

        static void Sobre()
        {
            Console.WriteLine("\n**************************************************************");
            Console.WriteLine("Projeto desenvolvido por: ");
            Console.WriteLine("Matheus Queiroz - matheusqrz.dev@gmail.com ");
            Console.WriteLine("Github - https://github.com/MatheusSQueiroz ");
            Console.WriteLine("**************************************************************");
        }

        static void KeyPress()
        {
            do
            {
                Console.Write("\nPressione Enter para Continuar...");
                consoleKeyInfo = Console.ReadKey();
            } while (consoleKeyInfo.Key != ConsoleKey.Enter);
        }
    }
}