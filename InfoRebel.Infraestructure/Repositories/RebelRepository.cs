using System;
using System.Linq;
using InfoRebel.Domain;
using InfoRebel.Domain.Repositories;
using InfoRebel.Domain.Services;

namespace InfoRebel.Infrastructure.Repositories
{
    public class RebelRepository : IRebelRepository
    {
        private readonly InfoRebelContext _context;

        private readonly IValidatorService _validatorService;

        /// <exception cref="ArgumentNullException"><paramref name="context"/> is <see langword="null" />.</exception>
        public RebelRepository(InfoRebelContext context, IValidatorService validator)
        {
            if (_context == null)
                throw new ArgumentNullException("context");

            if (validator == null)
                throw new ArgumentNullException("validator");

            _context = context;
            _validatorService = validator;
        }

        #region IRebelRepository

        public void Add(Rebel rebel)
        {
            //TODO:1.Registro de rebeldes. [Capa de Infraestructura]
            
        }

        public void Update(Rebel rebel)
        {
            //TODO:2.Actualización de registro de rebeldes.[Capa de Infraestructura]
          
        }

        public void Remove(Rebel rebel)
        {
            //TODO:3.Eliminación de registro de rebeldes, se deberá dar la razón de dicha eliminación.[Capa de Infraestructura]
        }

        public IQueryable<Rebel> GetAll()
        {
            return _context.Rebels;
        }

        #endregion


       
    }
}
