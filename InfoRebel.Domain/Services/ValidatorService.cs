using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InfoRebel.Domain.Services
{
    public class ValidatorService : IValidatorService
    {
        public bool TryValidate<TEntity>(TEntity entity, out ICollection<ValidationResult> results)
            where TEntity : class
        {
            var context = new ValidationContext(entity, serviceProvider: null, items: null);
            results = new List<ValidationResult>();
            return Validator.TryValidateObject(entity, context, results, validateAllProperties: true);
        }
    }
}
