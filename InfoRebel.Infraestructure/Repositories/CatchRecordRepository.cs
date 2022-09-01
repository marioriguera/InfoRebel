
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using InfoRebel.Domain;
using InfoRebel.Domain.Repositories;
using InfoRebel.Domain.Services;
using InfoRebel.Domain.Services.Exceptions;

namespace InfoRebel.Infrastructure.Repositories
{
    public class CatchRecordRepository : ICatchRecordRepository
    {
        private readonly InfoRebelContext _context;

        private readonly IValidatorService _validatorService;

        /// <exception cref="ArgumentNullException"><paramref name="context"/> is <see langword="null" />.</exception>
        public CatchRecordRepository(InfoRebelContext context, IValidatorService validator)
        {
            if (_context == null)
                throw new ArgumentNullException("context");

            if (validator == null)
                throw new ArgumentNullException("validator");

            _context = context;
            _validatorService = validator;
        }

        #region ICatchRecordRepository

        /// <exception cref="ValidatorException">Domain entity not valid.</exception>
        public void Add(CatchRecord catchRecord)
        {
            ICollection<ValidationResult> validationResult;

            if (_validatorService.TryValidate(catchRecord, out validationResult))
            {
                _context.CatchRecords.Add(catchRecord);
            }
            else
            {
                throw new ValidatorException(validationResult);
            }
        }

        #endregion
    }
}
