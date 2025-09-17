using System;
using Microsoft.EntityFrameworkCore;

namespace Relacionamentos3
{
    public class CredencialRepository
    {
        public static Credencial? FindByIdWithUsuario(UInt64 id)
        {
            try
            {
                using(Repository dbContext = new Repository())
                {
                    return dbContext.Credenciais.Include("Usuario").Where(c => c.Id == id).FirstOrDefault<Credencial>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
