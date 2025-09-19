using System;
using System.ComponentModel.DataAnnotations;

namespace Relacionamentos3
{
    public class UsuarioEndereco
    {
        public UInt64 UsuarioId { get; set; }
        [Required]
        public Usuario Usuario { get; set; }

        public UInt64 EnderecoId { get; set; }
        [Required]
        public Endereco Endereco { get; set; }
    }
}
