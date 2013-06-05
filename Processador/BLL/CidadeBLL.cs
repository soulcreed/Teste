using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using MODEL;

namespace BLL
{
    public class CidadeBLL
    {
        public void Cadastrar(CidadeINFO cidade)
        {
            CidadeDAL cidadeDAL = new CidadeDAL();
            cidadeDAL.Cadastrar(cidade);
        }
    }
}
