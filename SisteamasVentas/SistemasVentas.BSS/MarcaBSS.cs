using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
    public class MarcaBSS
    {
        MarcaDAL dal = new MarcaDAL();
        public DataTable ListarMarcaBss()
        {
            return dal.ListarMarcaDal();
        }
    }
}
