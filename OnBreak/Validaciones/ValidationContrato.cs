using ClassBiblioteca;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace OnBreak.Validaciones
{
    public class ValidationContrato : AbstractValidator<Contratos>
    {
        public ValidationContrato()
        {
            RuleFor(c => c.Cliente).NotNull().WithMessage("Debe Ingresar el Rut de un Cliente");
            RuleFor(c => c.NombreEvento)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Nombre de Evento no puede estar vacío")
                .Length(3, 50).WithMessage("Nombre de Evento debe tener entre 3 y 50 caracteres");
            RuleFor(c => c.Direccion)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Dirección no puede estar vacía")
                .Length(3, 30).WithMessage("Dirección debe tener entre 3 y 30 caracteres");
            RuleFor(c => c.Total).GreaterThan(0).WithMessage("Debe presionar el Botón Calcular");
            RuleFor(c => c.ModalidadServicio).NotNull().WithMessage("Debe seleccionar una Modalidad");
            RuleFor(c => c.InicioEvento)
                .NotNull().WithMessage("Inicio Evento no puede estar vacío")
                .GreaterThan(DateTime.Now).WithMessage("Inicio del Evento no puede ser menor a Fecha Actual")
                .LessThanOrEqualTo(DateTime.Now.AddMonths(10)).WithMessage("Inicio de Evento no puede ser mayor a 10 meses desde Fecha Actual");
            RuleFor(c => c.TerminoEvento)
                .NotNull().WithMessage("Termino Evento no puede estar vacío")
                .GreaterThan(c => c.InicioEvento).WithMessage("Termino del Evento no puede ser menor a Inicio del Evento")
                .LessThanOrEqualTo(c => c.InicioEvento.AddHours(24)).WithMessage("Termino de Evento no puede Exceder 24 horas desde el Inicio del Evento");
            RuleFor(c => c.Observaciones)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Observaciones no puede estar vacío")
                .MaximumLength(250).WithMessage("Observaciones debe tener máximo 250 caracteres");
        }

    }
}
