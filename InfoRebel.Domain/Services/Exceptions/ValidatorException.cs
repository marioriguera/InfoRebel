using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InfoRebel.Domain.Services.Exceptions
{
    public class ValidatorException : ApplicationException
    {
        public ValidatorException()
            : base("Domain entity not valid")
        {
        }

        public ValidatorException(ICollection<ValidationResult> errors)
        {
            Errors = errors;
        }

        public ValidatorException(ICollection<ValidationResult> errors, Exception inner)
            : base("Domain entity not valid", inner)
        {
            Errors = errors;
        }

        public ICollection<ValidationResult> Errors { get; private set; }
    }
}
