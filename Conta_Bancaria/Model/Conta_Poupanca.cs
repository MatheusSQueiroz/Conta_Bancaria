using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_Bancaria.Model
{
    public class Conta_Poupanca : Conta
    {
        private int aniversario;

        public Conta_Poupanca(int numero, int agencia, int tipo, string titular, decimal saldo, int aniversario) 
            : base(numero, agencia, tipo, titular, saldo)
        {
            this.aniversario = aniversario;
        }

        public int getAniversario()
        {
            return this.aniversario;
        }

        public void SetAniversario(int aniversario)
        {
            this.aniversario = aniversario;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Aniversário da conta: {this.aniversario}");
            Console.WriteLine("**************************************************************");
        }
    }
}
