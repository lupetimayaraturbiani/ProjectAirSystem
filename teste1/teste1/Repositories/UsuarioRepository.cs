using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teste1.Models;

namespace teste1.Repositories
{
    class UsuarioRepository
    {
        private static List<Usuario> usuarios;

        private static int contador = 1;


        public UsuarioRepository()
        {
            if (usuarios == null)
            {
                usuarios = new List<Usuario>();

                usuarios.Add(new Usuario
                {
                    id = 1,
                    nome = "Claudia",
                    sobrenome = "Santos",
                    endereco = "Rua NaoLigo",
                    numero = "21",
                    usuario = "claudiaS2",
                    senha = "1234"
                });

                contador++;
                usuarios.Add(new Usuario
                {
                    id = 2,
                    nome = "Judson",
                    sobrenome = "Silva",
                    endereco = "Rua NaoSei",
                    numero = "3442",
                    usuario = "judinho",
                    senha = "1234"
                });
            }
        }

        public List<Usuario> buscarTodos()
        {
            return usuarios;
        }

        public void adicionar(Usuario usuario)
        {
            usuario.id = contador;

            usuarios.Add(usuario);
            contador++;
        }

        public void editar(Usuario usuario)
        {
            Usuario u = usuarios.Find(x => x.id == usuario.id);
            usuarios[usuarios.IndexOf(u)] = usuario;
        }

        public void deletar(int id)
        {
            Usuario usuario = usuarios.Find(x => x.id == id);

            usuarios.Remove(usuario);
        }
    }
}
