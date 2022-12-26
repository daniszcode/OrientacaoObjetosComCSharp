using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetosComCSharp.Cliente
{
    internal class Titular
    {
        public int id;
        public string nome;
        public double renda;
        public string profissao;
        public bool is_standard;
        public bool is_premium;
        public bool is_gold;

        public void setTipoClienteCliente()
        {
            if (renda <= 4999.99)
            {
                Console.WriteLine("é Standard");

                Standard.is_standard = true;
                is_standard = true;
                Standard.renda = renda;
                //limite_transação = 1000
                return;
            }
            else
            {
                Standard.is_standard = false;
                is_standard = false;
            }


            if (renda >= 5000 && renda <= 17.999)
            {
                Console.WriteLine("é Gold");

                Gold.is_gold = true;
                is_gold = true;
                Gold.renda = renda;
                //limite_transação = 5000
                return;

            }
            else
            {
                Gold.is_gold = false;
                is_gold = false;
            }



            if (renda > 17.999)
            {
                Console.WriteLine("é premium");
                Premium.is_premium = true;
                is_premium = true;
                Premium.renda = renda;
                //limite_transação = não tem
                return;
            }
            else
            {
                Premium.is_premium = false;
                is_premium = false;
            }
        }
    }

}
