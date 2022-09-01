using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InfoRebel.Domain.Services
{
    /// <summary>
    /// Contrato del servicio de validacion de entidades
    /// </summary>
    public interface IValidatorService
    {
        /// <summary>
        /// Validacion de la entidades de dominio
        /// </summary>
        /// <typeparam name="TEntity">Tipo de la entidad que se desea validar</typeparam>
        /// <param name="entity">Instancia que se desea validar</param>
        /// <param name="results">Resultado de la validacion</param>
        /// <returns>Retorna true si la instancia es validad</returns>
        bool TryValidate<TEntity>(TEntity entity, out ICollection<ValidationResult> results)
            where TEntity : class;
    }
}