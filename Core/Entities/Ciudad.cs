using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

    public class Ciudad
    {
        public string Nombre { get; set; }
        public int IdDepartamentoFk { get; set; }
        // public string Nombre { get; set; }
    }