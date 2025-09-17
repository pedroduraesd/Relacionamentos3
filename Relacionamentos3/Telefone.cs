using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Relacionamentos3
{
    public class Telefone
    {
        public UInt64 Id { get; set; }
        public Byte Ddd { get; set; }
        public UInt32 Numero {  get; set; }
    }
}
