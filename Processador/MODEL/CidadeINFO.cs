using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MODEL;

namespace MODEL
{
    public class CidadeINFO
    {
        public int Codigo { get; set; }
        public EstadoINFO Estado { get; set; }
        public string Nome { get; set; }
        public Boolean Capital { get; set; }
    }
}
