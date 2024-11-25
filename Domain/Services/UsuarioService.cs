using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class UsuarioService
    {
        //private readonly AcademiaContext _context;
        public void Add(Usuario Usuario)
        {
            using (var _context = new AcademiaContext())
            {
                _context.Usuarios.Add(Usuario);
                _context.SaveChanges();
            }

        }

        public void Delete(int id)
        {
            using (var _context = new AcademiaContext())
            {
                Usuario? UsuarioToDelete = _context.Usuarios.Find(id);
                if (UsuarioToDelete != null)
                {
                    _context.Usuarios.Remove(UsuarioToDelete);
                    _context.SaveChanges();
                }
            }
        }
        public Usuario? Get(int id)
        {
            using (var _context = new AcademiaContext())
            {
                return _context.Usuarios.Find(id);
            }

        }

        public int CountUsuario()
        {
            using(var _context = new AcademiaContext())
            {
                return _context.Usuarios.Count();
            }
        }

        public Usuario Authenticate(string user, string pass)
        {
            using(var _context = new AcademiaContext())
            {
                Usuario rta = _context.Usuarios.Single(u=> u.Username == user && u.Password == pass);
                return rta;
            }
        }

        public bool CheckDuplicate(string user, int id)
        {
            using (var _context = new AcademiaContext())
            {
                Usuario rta = _context.Usuarios.Single(u => u.Username == user);
                if(rta != null)
                {
                    if(rta.Id == id)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
        }

        public IEnumerable<Usuario> GetAll()
        {
            using (var _context = new AcademiaContext())
            {
                return _context.Usuarios.ToList();
            }
        }
        public void Update(Usuario Usuario)
        {
            using (var _context = new AcademiaContext())
            {
                Usuario? UsuarioToUpdate = _context.Usuarios.Find(Usuario.Id, Usuario.IdPersona);
                if (UsuarioToUpdate != null)
                {
                    UsuarioToUpdate.Username = Usuario.Username;
                    UsuarioToUpdate.Password = Usuario.Password;
                    _context.SaveChanges();
                }
            }

        }
    }
}
