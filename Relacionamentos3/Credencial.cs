using System;
using System.ComponentModel.DataAnnotations;


namespace Relacionamentos3
{
    public class Credencial
    {
        public UInt64 Id { get; set; }
        private String? _email;
        [Required]
        [MaxLength(250)]
        public String? Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("O email não pode ser nulo ou vazio");
                }
                if (value.Length > 250)
                {
                    throw new ArgumentException("O email não pode ter mais de 250 caracteres");
                }
                _email = value;
            }
        }
        private String? _senha;
        [Required]
        [MaxLength(20)]
        public String? Senha
        {
            get
            {
                return _senha;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("A senha não pode ser nula");
                }
                if (value.Length < 8 || value.Length > 20)
                {
                    throw new ArgumentException("A senha deve ter entre 8 e 20 caracteres");
                }
                _senha = value;
            }
        }
        public Usuario Usuario { get; set; }
    }
}
