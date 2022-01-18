﻿using ApiCliente.Application.DTO;
using ApiCliente.Domain.Entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCliente.Domain.Validations
{
    public class ClienteValidation : AbstractValidator<ClienteDto>
    {
        public ClienteValidation()
        {
            RuleFor(c => c.Cep)
                 .NotEmpty().WithMessage("CEP é obrigatório.")
                 .NotNull().WithMessage("CEP é obrigatório.")
                 .Matches(@"^[0-9]{8}").WithMessage("O CEP informado é inválido.");
            

            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("NOME é obrigatório.")
                .NotNull().WithMessage("NOME é obrigatório.")
                .MaximumLength(50).WithMessage("O nome deve conter no máximo 50 caracteres");
        }
    }
}