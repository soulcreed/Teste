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
    public interface ICidade
    {
        [OperationContract, WebInvoke(Method = "POST")]
        void Cadastrar(Cidade cidade_);
        [OperationContract, WebInvoke(Method = "PUT")]
        void Alterar(Cidade cidade_);
        [OperationContract, WebInvoke(Method = "DELETE")]
        void Deletar(Cidade cidade_);
        [OperationContract, WebInvoke(Method = "GET")]
        List<Cidade> Consultar(Cidade cidade_);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Cidade
    {
        public int codigo { get; set; }
        public Estado estado { get; set; }
        public string nome { get; set; }
        public Boolean capital { get; set; }

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
        public Estado Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        [DataMember]
        public bool Capital
        {
            get { return capital; }
            set { capital = value; }
        }
    }
}
