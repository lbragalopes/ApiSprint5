﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCliente.Domain.Entity
{
    public class Cidade 
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Estado { get; set; }
        public ICollection<Cliente> Clientes { get; set; }

    }
}