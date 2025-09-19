using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Relacionamentos3
{
    public class Usuario
    {

        public Usuario()
        {
            Telefones = new List<Telefone>();
            UsuariosEnderecos = new List<UsuarioEndereco>();
        }
        public UInt64 Id { get; set; }
        private String? _nome;
        [Required]
        [MaxLength(45)]
        public String? Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("O nome não pode ser nulo ou vazio");
                }
                if(value.Length > 45)
                {
                    throw new ArgumentException("O nome não pode ter mais de 45 caracteres");
                }
                _nome = value;
            }
        }

        [ForeignKey ("credencial_id")]
        public Credencial Credencial { get; set; }

        [ForeignKey ("usuario_id")]
        public List<Telefone> Telefones { get; set; }
        public List<UsuarioEndereco> UsuariosEnderecos { get; set; }

        public void AddTelefone(Telefone telefone)
        {
            Telefones.Add(telefone);
        }
    }
}
