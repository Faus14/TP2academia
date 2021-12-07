﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;


namespace Business.Logic
{
    public class UsuarioLogic : BusinessLogic
    {
        Data.Database.UsuarioAdapter UsuarioData;
        public UsuarioLogic()
        {
            UsuarioData = new Data.Database.UsuarioAdapter();

        }
        public List<Usuario> GetAll()
        {
            List<Usuario> usuarios = UsuarioData.GetAll();
            return usuarios;
        }


        public Usuario GetOne(int id)
        {
            Usuario user = UsuarioData.GetOne(id);
            return user;
        }

        public void Delete(int id)
        {
            UsuarioData.Delete(id);
        }


        public void Save(Usuario usuario)
        {
            UsuarioData.Save(usuario);
        }

        /*
         *metodo para el login
         public Usuario Login(int id, String pass)
        {
            Usuario user = UsuarioData.Login(id, pass);
            return user;
        }
         
         */

    }
}
