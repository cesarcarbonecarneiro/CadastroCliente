using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroPessoaBack.Data
{
    public class Endereco
    {
        public virtual int Id { get; set; }
        public virtual int PessoaId { get; set; }
        public virtual string Distrito { get; set; }
        public virtual string Bairro { get; set; }
        public virtual string Logradouro { get; set; }
        public virtual string Numero { get; set; }
        public virtual string Complemento { get; set; }
    }
}
