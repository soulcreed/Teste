using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Processador
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IEstado
    {
        [OperationContract, WebInvoke(Method="POST")]
        void Cadastrar(Estado estado_);
        [OperationContract, WebInvoke(Method="PUT")]
        void Alterar(Estado estado_);
        [OperationContract, WebInvoke(Method="DELETE")]
        void Deletar(Estado estado_);
        [OperationContract, WebInvoke(Method="GET")]
        List<Estado> Consultar(Estado estado_);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Estado
    {
        public int codigo;
        public string nome;
        public string sigla;
        public string pais;
        public string regiao;

        [DataMember]
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        [DataMember]
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        [DataMember]
        public string Sigla
        {
            get { return sigla; }
            set { sigla = value; }
        }

        [DataMember]
        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        [DataMember]
        public string Regiao
        {
            get { return regiao; }
            set { regiao = value; }
        }
    }
}
