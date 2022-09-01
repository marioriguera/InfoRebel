using System;
using System.Linq;
using InfoRebel.Domain;
using InfoRebel.Domain.Repositories;

namespace InfoRebel.Infrastructure.Repositories
{
    public class JailRepository : IJailRepository
    {
        private readonly InfoRebelContext _context;

        /// <exception cref="ArgumentNullException"><paramref name="context"/> is <see langword="null" />.</exception>
        public JailRepository(InfoRebelContext context)
        {
            if (_context == null)
                throw new ArgumentNullException("context");

            _context = context;
        }

        #region IJailRepository

        public IQueryable<Jail> GetAll()
        {
            return _context.Jails;
        }

        #endregion
    }
}
