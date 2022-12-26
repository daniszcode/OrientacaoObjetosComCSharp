using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using OrientacaoObjetosComCSharp.Cliente;


namespace OrientacaoObjetosComCSharp.Conta
{
    internal class ContaBancaria
    {
        
        private int numero_agencia;
        public int Numero_agencia
        {
            get { return this.numero_agencia; }
            private set
            {
                if (value > 0)
                {
                    this.numero_agencia = value;
                }
            }
        }
        private string conta;
        public string Conta { get; set; }
   
        private double saldo;
        public double Saldo
        {
            get { return this.saldo; }
            set { if (saldo > 0) this.saldo = value; }
        }

        public static int TotalDeContas { get; private set; }
        public ChavePix chavePix { get; set; }
        public Titular cadastroCliente;


        public void depositarSaldo(double valor)
        {
            saldo += valor;
        }

        public double transferirSaldo(double valor, ContaBancaria destino)
        {
            if (valor < saldo)
            {
                saldo -= valor;
                destino.saldo = valor;
                Console.WriteLine($"Você transferiu {valor}, para a conta: {destino.conta}, seu saldo agora é: {saldo}");
                return valor;
            }
            else
            {
                Console.WriteLine("Você não tem saldo suficiente para essa transação.");
                return valor;
            }
        }

        public void sacarSaldo(double valor)
        {
            if (valor > 0 && valor < saldo)
            {

                saldo -= valor;
                Console.WriteLine($"Você sacou {valor} do seu saldo, restando {saldo}");
            }
            else
            {
                Console.WriteLine($"Você não tem saldo suficiente, seu saldo é: {saldo}");

            }
        }
        //constructor com parametros
        public ContaBancaria(int numero_agencia,  string conta, Titular cadastroCliente)
        {
            this.Numero_agencia = numero_agencia;
            this.Conta = conta;
            this.Saldo = saldo;
            this.chavePix = chavePix;
            this.cadastroCliente = cadastroCliente;
            TotalDeContas++;
        }
        //constructor sem parametros que sobrepõe o constructor  default da classe

        public ContaBancaria()
        {

        }


        //cadastro de cliente
        //transações permitidas:
        //saque
        //transferência
        //pix
        //atributos privados e metodos publicos, manipula os atributos atraves dos metodos;
        //ou podemos usar atributos privados e o "mesmo" atributo publico com get e set 

    }

}
