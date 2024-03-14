﻿using SistemasVentas.DAL;
using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
    public class ClienteBSS
    {
        ClienteDAL dal = new ClienteDAL();
        public DataTable ListarClienteBss()
        {
            return dal.ListarClienteDal();
        }

        public void InsertarClienteBss(Cliente cliente)
        {
            dal.InsertarClienteDAL(cliente);
        }
    }
}
