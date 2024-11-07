using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface IUsuarioService
    {
        void Add(Usuario Usuario);

        void Delete(int id);

        Usuario? Get(int id);

        int CountUsuario();

        bool Authenticate(string user, string pass);

        IEnumerable<Usuario> GetAll();

        void Update(Usuario Usuario);
    }
}
