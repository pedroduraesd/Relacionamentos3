using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Relacionamentos3
{
    public class Endereco
    {
        public UInt64 Id { get; set; }
        public String TipoLogradouro { get; set; }
        public String Logradouro { get; set; }
        public UInt16 Numero {  get; set; }
        public String Bairro { get; set; }
        public UInt32 Cep { get; set; }
        public List<Usuario> Usuarios { get; set; }
    }
}
