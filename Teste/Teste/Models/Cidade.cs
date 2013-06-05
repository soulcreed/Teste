using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Teste.Models;
using System.ComponentModel.DataAnnotations;
namespace Teste.Models
{
    public class Cidade
    {
        public int Codigo { get; set; }
        public Estado Estado { get; set; }
        public string Nome { get; set; }
        public Boolean Capital { get; set; }
    }
}