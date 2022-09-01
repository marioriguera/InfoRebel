
using System;
using System.ComponentModel.DataAnnotations;

namespace InfoRebel.Domain.Entities
{

    /// <summary>
    /// Entidad base
    /// </summary>
    public class Entity
    {
        /// <summary>
        /// Id
        /// </summary>
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Retorna el codigo hash de la entidad
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        /// <summary>
        /// Retorna un string que identifica la instancia     
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("[{0} {1}]", GetType().Name, Id);
        }

        /// <summary>
        /// Comparacion con otra instancia 
        /// </summary>
        /// <param name="obj">Instancia que se desea comparar</param>
        /// <returns>True si es igual y falso si es distinto</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is Entity))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = (Entity)obj;
            var typeOfThis = GetType();
            var typeOfOther = other.GetType();
            if (!typeOfThis.IsAssignableFrom(typeOfOther) && !typeOfOther.IsAssignableFrom(typeOfThis))
            {
                return false;
            }

            return Id.Equals(other.Id);
        }
    }
}
