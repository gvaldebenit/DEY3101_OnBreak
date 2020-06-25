using ClassBiblioteca;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBreak.Validaciones
{
    public class ValidationCliente : AbstractValidator<Clientes>
    {
        public ValidationCliente()
        {
            RuleFor(c => c.NombreContacto)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull().WithMessage("Nombre de Contacto no puede estar vacío")
                .Length(3, 50).WithMessage("Nombre de Contacto debe tener entre 3 y 50 caracteres");
            RuleFor(c => c.Direccion)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Dirección no puede estar vacía")
                .Length(3, 30).WithMessage("Dirección debe tener entre 3 y 30 caracteres");
            RuleFor(c => c.RazonSocial)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Razón Social no puede estar vacía")
                .Length(3, 50).WithMessage("Razón Social debe tener entre 3 y 50 caracteres");
            RuleFor(c => c.EmailContacto)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Email Contacto no puede estar vacío")
                .Length(3, 50).WithMessage("Email Contacto debe tener entre 3 y 50 caracteres");
            RuleFor(c => c.Telefono)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Telefono Contacto no puede estar vacío")
                .MaximumLength(15).WithMessage("Telefono Contacto debe tener máximo 15 caracteres");
        }



    }
}
