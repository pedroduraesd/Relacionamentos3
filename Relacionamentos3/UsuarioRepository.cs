using System;
using Microsoft.EntityFrameworkCore;

namespace Relacionamentos3
{
    public class UsuarioRepository
    {
        public static void SaveOrUpdate(Usuario usuario)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (usuario.Id == 0)
                    {
                        dbContext.Usuarios.Add(usuario);
                    }
                    else
                    {
                        dbContext.Entry(usuario).State = EntityState.Modified;
                    }
                    dbContext.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }
        public static Usuario? FindById(UInt64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Usuarios.Find(id);
                }
            }
            catch
            {
                throw;
            }
        }
        public static Usuario? FindByIdWithCredencial(UInt64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Usuarios.Include("Credencial").Where(u => u.Id == id).FirstOrDefault<Usuario>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
