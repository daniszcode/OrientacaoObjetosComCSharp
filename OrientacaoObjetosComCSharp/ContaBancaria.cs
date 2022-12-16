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

        public void DepositarSaldo(double valor)
        {
            this.saldo += valor;
        }

        //cadastro de cliente
        //transações permitidas:
        //saque
        //transferência
        //pix

    }

    internal class Cliente
    {
        public int id;
        public string nome;
        public double renda;
        public string profissão;
        public Standard standard;
        public Premium premium;
        public Gold gold;
        public void setClienteStandard()
        { 
        if (this.renda <= 4999.99)
        {
                Standard.is_standard = true;
                Standard.renda = this.renda;
                //limite_transação = 1000
        }
        
        }
        public void setClienteGold()
        {
            if (this.renda >= 18.000)
            {
                Gold.is_gold = true; 
                Gold.renda = this.renda;
                //limite_transação = 5000

            }

        }

        public void setClientePremium()
        {
            if (this.renda >= 5000 && this.renda <= 17.999)
            {
                Premium.is_premium = true;
                Premium.renda = this.renda;
                //limite_transação = não tem
            }

        }
    }

  
}
