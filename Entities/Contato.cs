using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo_API.Entities
{
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; } = default!;
        public string Telefone { get; set; } = default!;
        public bool Ativo { get; set; }
    }
}