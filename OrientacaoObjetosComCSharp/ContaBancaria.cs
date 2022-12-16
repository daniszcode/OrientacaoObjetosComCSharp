using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetosComCSharp
{
    internal class ContaBancaria
    {
        public int numero_agencia;
        public string conta;
        public string titular;
        public double saldo;
        public ChavePix chavePix;
        public void depositarSaldo(double valor)
        {
            this.saldo += valor;
        }

        public double transferirSaldo(double valor, ContaBancaria destino)
        {
            this.saldo -= valor;
            destino.saldo = valor;
            Console.WriteLine($"Você transferiu {valor}, para a conta: {destino.conta}, seu saldo agora é: {saldo}");
            return valor;
        }

        public void sacarSaldo(double valor)
        {
            if (valor > 0 && valor < this.saldo)
            {

                this.saldo -= valor;
                Console.WriteLine($"Você sacou {valor} do seu saldo, restando {this.saldo}");
            }
            else
            {
                Console.WriteLine($"Você não tem saldo suficiente, seu saldo é: {this.saldo}");

            }
        }

        //cadastro de cliente
        //transações permitidas:
        //saque
        //transferência
        //pix

    }

    internal class Cliente : ContaBancaria
    {
         public int id;
         public string nome;
         public double renda;
         public string profissao;
         public bool is_standard;
         public bool is_premium;
         public bool is_gold;
        public void setClienteStandard()
        { 
        if (this.renda <= 4999.99)
        {
                Standard.is_standard = true;
                this.is_standard = true;
                Standard.renda = this.renda;
                //limite_transação = 1000
        }
        
        }
        public void setClienteGold()
        {
            if (this.renda >= 18.000)
            {
                Gold.is_gold = true;
                this.is_gold = true;
                Gold.renda = this.renda;
                //limite_transação = 5000

            }

        }

        public void setClientePremium()
        {
            if (this.renda >= 5000 && this.renda <= 17.999)
            {
                Premium.is_premium = true;
                this.is_premium = true;
                Premium.renda = this.renda;
                //limite_transação = não tem
            }

        }
    }

  
}
