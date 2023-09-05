using Conta_Bancaria.Controller;
using Conta_Bancaria.Model;

namespace Conta_Bancaria
{
    internal class Program
    {
        private static ConsoleKeyInfo consoleKeyInfo;

        static void Main(string[] args)
        {
            int option, agencia, tipo, aniversario, numero;
            string? titular;
            decimal saldo, limite;

            ContaController contas = new();

            Conta_Corrente cc1 = new Conta_Corrente(contas.GerarNumero(), 987, 1, "Queiroz", 900000.00M, 10000);
            contas.Cadastrar(cc1);
         

            Conta_Poupanca cp1 = new Conta_Poupanca(contas.GerarNumero(), 987, 2, "Bugson", 900000.00M, 05);
            contas.Cadastrar(cp1);

            

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


                //Tratamento de exceção para impedir digitação de string
                try
                {
                     
                    option = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Digite um número entre 1 e 9!");
                    option = 0;
                    Console.ResetColor();
                }



                if(option == 9)
                {
                    Console.WriteLine("\nBanco do Brazil com Z, o seu futuro começa aqui!");
                    Sobre();
                    System.Environment.Exit(0);
                }

                switch(option)
                {
                    case 1: 
                        
                        Console.WriteLine("Criar conta:\n");

                        Console.Write("Digite o número da agência: ");
                        agencia = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Digite o nome do(a) titular: ");
                        titular = Console.ReadLine();

                        titular ??= string.Empty;

                        do {
                            Console.Write("Digite o tipo da conta: ");
                            tipo = Convert.ToInt32(Console.ReadLine());

                        }while( tipo != 1 && tipo != 2);

                        Console.Write("Digite o saldo da conta: ");
                        saldo = Convert.ToDecimal(Console.ReadLine());


                        switch (tipo)
                        {
                            case 1:
                                Console.Write("Digite o limite da conta: ");
                                limite = Convert.ToDecimal(Console.ReadLine());
                                contas.Cadastrar(new Conta_Corrente(contas.GerarNumero(), agencia, tipo,
                                                                    titular, saldo, limite));
                            break;

                            case 2:
                                Console.Write("Digite o dia de aniversário da conta: ");
                                aniversario = Convert.ToInt32(Console.ReadLine());
                                contas.Cadastrar(new Conta_Poupanca(contas.GerarNumero(), agencia, tipo,
                                                                    titular, saldo, aniversario));
                            break;

                        }


                        KeyPress();
                        break;

                    case 2: 
                        
                        Console.WriteLine("Listar todas as contas:\n");

                        contas.ListarTodas();

                        KeyPress();
                        break;

                    case 3: 
                        
                        Console.WriteLine("Buscar conta por número:\n");

                        Console.WriteLine("Digite o Nº da conta: ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        contas.ProcurarPorNumero(numero);
                        
                        KeyPress();
                        break;

                    case 4: 
                        Console.WriteLine("Atualizar dados da conta:\n");

                        Console.WriteLine("Digite o Nº da conta: ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        var conta = contas.BuscarNaCollection(numero);

                        if (conta is not null)
                        {

                            Console.Write("Digite o número da agência: ");
                            agencia = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Digite o nome do(a) titular: ");
                            titular = Console.ReadLine();

                            titular ??= string.Empty;

                            Console.Write("Digite o saldo da conta: ");
                            saldo = Convert.ToDecimal(Console.ReadLine());

                            tipo = conta.GetTipo();


                            switch (tipo)
                            {
                                case 1:
                                    Console.Write("Digite o limite da conta: ");
                                    limite = Convert.ToDecimal(Console.ReadLine());
                                    contas.Atualizar(new Conta_Corrente(numero, agencia, tipo,
                                                                        titular, saldo, limite));
                                    break;

                                case 2:
                                    Console.Write("Digite o dia de aniversário da conta: ");
                                    aniversario = Convert.ToInt32(Console.ReadLine());
                                    contas.Atualizar(new Conta_Poupanca(numero, agencia, tipo,
                                                                        titular, saldo, aniversario));
                                    break;

                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Não foi possivel localizar a conta Nº {numero}...");
                            Console.ResetColor();
                        }


                        KeyPress();
                        break;

                    case 5: 
                        
                        Console.WriteLine("Apagar conta:\n");

                        Console.WriteLine("Digite o Nº da conta: ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        contas.Deletar(numero);

                        KeyPress();
                        break;

                    case 6: 
                        
                        Console.WriteLine("Sacar:\n");

                        KeyPress();
                        break;

                    case 7: 
                        
                        Console.WriteLine("Depositar:\n");

                        KeyPress();
                        break;

                    case 8: 
                        
                        Console.WriteLine("Transferência de valores entre contas:\n");

                        KeyPress();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Digite uma opção válida!");
                        Console.ResetColor();

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