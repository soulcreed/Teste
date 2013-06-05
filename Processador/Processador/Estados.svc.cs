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
    public class Estados : IEstado
    {
        public void Cadastrar(Estado estado)
        {
            throw new NotImplementedException();
        }
        public void Alterar(Estado estado)
        {
            throw new NotImplementedException();
        }
        public void Deletar(Estado estado)
        {
            throw new NotImplementedException();
        }
        public List<Estado> Consultar(Estado estado)
        {
            EstadoBLL estadoBLL = new EstadoBLL();
            var estadoInfo = estadoBLL.ListarEstados(ObjForInfoEstado(estado));
            List<Estado> objEstado = new List<Estado>();
            foreach(EstadoINFO rsFor in estadoInfo){
                objEstado.Add(InfoForObjEstado(rsFor));
            }
            return objEstado;
        }
        public static EstadoINFO ObjForInfoEstado(Estado objEstado)
        {
            var rsEstadoINFO = new EstadoINFO();
            rsEstadoINFO.Codigo = objEstado.Codigo;
            rsEstadoINFO.Nome = objEstado.Nome;
            rsEstadoINFO.Pais = objEstado.Pais;
            rsEstadoINFO.Regiao = objEstado.Regiao;
            rsEstadoINFO.Sigla = objEstado.Sigla;
            return rsEstadoINFO;
        }
        public static Estado InfoForObjEstado(EstadoINFO estadoINFO)
        {
            var rsObjEstado = new Estado();
            rsObjEstado.Codigo = estadoINFO.Codigo;
            rsObjEstado.Nome = estadoINFO.Nome;
            rsObjEstado.Pais = estadoINFO.Pais;
            rsObjEstado.Regiao = estadoINFO.Regiao;
            rsObjEstado.Sigla = estadoINFO.Sigla;
            return rsObjEstado;
        }
    }
}
