using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_Bancaria.Model
{
    public class Conta_Corrente : Conta
    {
        private decimal limite;

        public Conta_Corrente(int numero, int agencia, int tipo, string titular, decimal saldo, decimal limite) 
            : base(numero, agencia, tipo, titular, saldo)
        {
            this.limite = limite;
        }

        public decimal GetLimite()
        {
            return this.limite;
        }

        public void SetLimite(decimal limite)
        {
            this.limite = limite;
        }
        
        // Sobrescrevendo o metodo sacar(Polimorfismo)
        public override bool Sacar(decimal valor)
        {
            if (this.GetSaldo() + this.limite < valor)
            {
                Console.WriteLine("Saldo insuficiente!");
                return false;
            }

            this.SetSaldo(this.GetSaldo() - valor);
            return true;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Limite da conta: {this.limite}");
            Console.WriteLine("**************************************************************");
        }
    }
}
