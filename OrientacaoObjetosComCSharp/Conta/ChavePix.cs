using OrientacaoObjetosComCSharp.Conta;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetosComCSharp.Conta
{
    internal class ChavePix
    {
        private string cpf;
        public string Cpf { get; set; }

        private string email;
        public string Email { get; set; }

        private string telefone;
        public string Telefone { get; set; }
    }
}
