using FluentValidation;
using ProEventos.Domain.Entities;

namespace ProEventos.Domain.Validator
{
    public class EventoValidate : AbstractValidator<Evento>
    {
        public EventoValidate()
        {
            RuleFor(x => x)
             .NotEmpty()
             .WithMessage("A entidade não pode ser vazia.")

             .NotNull()
             .WithMessage("A entidade não pode ser nula.");

            RuleFor(x => x.Local)
                .NotNull()
                .WithMessage("O Local não pode ser nulo.")

                .NotEmpty()
                .WithMessage("O Local não pode ser vazio.")

                .MinimumLength(3)
                .WithMessage("O Local deve ter no mínimo 3 caracteres.")

                .MaximumLength(80)
                .WithMessage("O Local deve ter no máximo 80 caracteres.");

            RuleFor(x => x.Email)
                .NotNull()
                .WithMessage("O email não pode ser nulo.")

                .NotEmpty()
                .WithMessage("O email não pode ser vazio.")

                .MinimumLength(10)
                .WithMessage("O email deve ter no mínimo 10 caracteres.")

                .MaximumLength(180)
                .WithMessage("O email deve ter no máximo 180 caracteres.")

                .Matches(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
                .WithMessage("O email informado não é válido.");
        }
    }
}
