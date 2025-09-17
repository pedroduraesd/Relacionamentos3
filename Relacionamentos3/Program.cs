using System;

namespace Relacionamentos3
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Repository repository = new Repository();
            Usuario u1 = new Usuario();
            u1.Nome = "Predo";
            Credencial c1 = new Credencial();
            c1.Email = "predo@gmail.com";
            c1.Senha = "123456789";
            Telefone t1 = new Telefone();
            t1.Ddd = 38;
            t1.Numero = 991056750;
            Telefone t2 = new Telefone();
            t2.Ddd = 38;
            t2.Numero = 999255410;
            Telefone t3 = new Telefone();
            t3.Ddd = 34;
            t3.Numero = 997419331;

            u1.Credencial = c1;
            c1.Usuario = u1;
            
            u1.AddTelefone(t1);
            u1.AddTelefone(t2);
            u1.AddTelefone(t3);

            UsuarioRepository.SaveOrUpdate(u1);

            //Usuario usuarioAux = UsuarioRepository.FindByIdWithCredencial(1);
            //Console.WriteLine(usuarioAux.Nome);
            //Console.WriteLine(usuarioAux.Credencial.Email);
            //Console.WriteLine(usuarioAux.Credencial.Senha);
            //Credencial credencialAux = CredencialRepository.FindByIdWithUsuario(1);
            //Console.WriteLine(credencialAux.Email);
            //Console.WriteLine(credencialAux.Senha);
            //Console.WriteLine(credencialAux.Usuario.Nome);

            foreach (Telefone t in u1.Telefones)
            {
                Console.WriteLine($"({t.Ddd}){t.Numero} ");
            }
        }
    }
}
