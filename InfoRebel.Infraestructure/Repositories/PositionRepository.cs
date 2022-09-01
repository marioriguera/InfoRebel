
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using InfoRebel.Domain;
using InfoRebel.Domain.Repositories;
using InfoRebel.Domain.Services;
using InfoRebel.Domain.Services.Exceptions;

namespace InfoRebel.Infrastructure.Repositories
{
    public class PositionRepository : IPositionRepository
    {
        private readonly InfoRebelContext _context;

        private readonly IValidatorService _validatorService;

        /// <exception cref="ArgumentNullException"><paramref name="context"/> is <see langword="null" />.</exception>
        public PositionRepository(InfoRebelContext context , IValidatorService validator)
        {
            if (_context == null)
                throw new ArgumentNullException("context");

            if (validator == null)
                throw new ArgumentNullException("validator");

            _context = context;
            _validatorService = validator;
        }

        #region IPositionRepository

        /// <exception cref="ValidatorException">Domain entity not valid.</exception>
        public void Add(Position position)
        {
            ICollection<ValidationResult> validationResult;

            if (_validatorService.TryValidate(position, out validationResult))
            {
                _context.Positions.Add(position);
            }
            else
            {
                throw new ValidatorException(validationResult);
            }
        }

        #endregion
    }
}
