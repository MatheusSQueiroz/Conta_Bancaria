using Conta_Bancaria.Model;

namespace Conta_Bancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;

            Conta c1 = new Conta(1, 123, 1, "Matheus", 1000000.00M);
            c1.Visualizar();


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
                        break; 
                    
                    case 2: Console.WriteLine("Listar todas as contas:\n");
                        break; 
                    
                    case 3: Console.WriteLine("Buscar conta por número:\n");
                        break; 
                    
                    case 4: Console.WriteLine("Atualizar dados da conta:\n");
                        break; 
                    
                    case 5: Console.WriteLine("Apagar conta:\n");
                        break;
                   
                    case 6: Console.WriteLine("Sacar:\n");
                        break;
                   
                    case 7: Console.WriteLine("Depositar:\n");
                        break;
                    
                    case 8: Console.WriteLine("Transferência de valores entre contas:\n");
                        break;

                    default:
                        Console.WriteLine("Digite uma opção válida!");
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
    }
}