using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using FluentValidation;
using FluentValidation.Results;

namespace ProEventos.Domain.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; private set; }

        public DateTime? CreateAt { get; internal set; }

        public DateTime? UpdateAt { get; internal set; }

        [NotMapped]
        internal List<string> _erros;

        [NotMapped]
        public IReadOnlyCollection<string> Errors => _erros;

        [NotMapped]
        public bool Valid => _erros.Count() == 0;
        [NotMapped]
        public bool Invalid => _erros.Count > 0;


        private void AddErrorList(IList<ValidationFailure> errors)
        {
            foreach (var error in errors)
                _erros.Add(error.PropertyName + ": " + error.ErrorMessage);
        }

        internal bool Validate<T, J>(T validator, J obj) where T : AbstractValidator<J>
        {
            var validationResult = validator.Validate(obj);
            if (validationResult.Errors.Count > 0)
            {
                AddErrorList(validationResult.Errors);
                return Invalid;
            }

            return Valid;
        }

        public void UptadeEntity()
        {
            UpdateAt = DateTime.UtcNow;
        }
    }
}
