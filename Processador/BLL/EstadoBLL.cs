using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using MODEL;

namespace BLL
{
    public class EstadoBLL
    {
        public List<EstadoINFO> ListarEstados(EstadoINFO estado)
        {
            EstadoDAL estadoDAL = new EstadoDAL();
            return estadoDAL.Listar(estado);
        }
    }
}
