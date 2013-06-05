using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MODEL;
using BLL;

namespace Processador
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Cidades : ICidade
    {
        public void Cadastrar(Cidade cidade)
        {
            CidadeBLL cidadeBLL = new CidadeBLL();
            cidadeBLL.Cadastrar(ObjForInfoEstado(cidade));
        }
        public void Alterar(Cidade cidade)
        {
            throw new NotImplementedException();
        }
        public void Deletar(Cidade cidade)
        {
            throw new NotImplementedException();
        }
        public List<Cidade> Consultar(Cidade cidade)
        {
            throw new NotImplementedException();
        }
        public static CidadeINFO ObjForInfoEstado(Cidade objCidade)
        {
            var rscidadeINFO = new CidadeINFO();
            rscidadeINFO.Estado = new EstadoINFO();
            rscidadeINFO.Codigo = objCidade.Codigo;
            rscidadeINFO.Nome = objCidade.Nome;
            rscidadeINFO.Capital = objCidade.Capital;
            rscidadeINFO.Estado.Codigo = objCidade.Estado.Codigo;
            return rscidadeINFO;
        }
        public static Cidade InfoForObjEstado(CidadeINFO cidadeINFO)
        {
            var rsObjCidade = new Cidade();
            rsObjCidade.Codigo = cidadeINFO.Codigo;
            rsObjCidade.Nome = cidadeINFO.Nome;
            rsObjCidade.Estado.Codigo = cidadeINFO.Estado.Codigo;
            rsObjCidade.Capital = cidadeINFO.Capital;
            return rsObjCidade;
        }
    }
}
