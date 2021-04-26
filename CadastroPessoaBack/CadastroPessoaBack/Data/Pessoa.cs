using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroPessoaBack.Data
{
    public class Pessoa
    {
        internal object endereco;

        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Cpf { get; set; }
        public virtual string Email { get; set; }
        public virtual DateTime DataNascimento { get; set; }
        public virtual ICollection<Endereco> Enderecos { get; set; }

    }
}
