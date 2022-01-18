﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiCliente.Domain.Entity
{
    public class Cidade
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Nome é obrigatório")]
        public string Nome { get; set; }
        [StringLength(2, ErrorMessage = "O Campo estado deve conter no máximo 2 caracteres")]
        public string Estado { get; set; }
        public ICollection<Cliente> Clientes { get; set; }
    }
}