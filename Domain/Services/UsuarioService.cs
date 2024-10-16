﻿using Domain.Model;
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
                Usuario? UsuarioToUpdate = _context.Usuarios.Find(Usuario.Id);
                if (UsuarioToUpdate != null)
                {
                    UsuarioToUpdate.IdPersona = Usuario.IdPersona;
                    UsuarioToUpdate.Username = Usuario.Username;
                    UsuarioToUpdate.Password = Usuario.Password;
                    _context.SaveChanges();
                }
            }

        }
    }
}
