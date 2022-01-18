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
    public class CidadeValidation : AbstractValidator<CidadeDto>

    {

        public CidadeValidation()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("NOME é obrigatório.")
                .NotNull().WithMessage("NOME é obrigatório.")
                .MaximumLength(20).WithMessage("O nome deve conter no máximo 20 caracteres");


            RuleFor(c => c.Estado)
                .NotEmpty().WithMessage("ESTADO é obrigatório.")
                .NotNull().WithMessage("ESTADO é obrigatório.")
                .MaximumLength(2).WithMessage("O Estado deve conter no máximo 2 caracteres");

        }


    }
}
