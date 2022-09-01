using System;
using System.ComponentModel.DataAnnotations;

namespace InfoRebel.Domain.Entities
{
    /// <summary>
    /// Posicion
    /// </summary>
    public class Position : Entity
    {
        /// <summary>
        /// Latitud
        /// </summary>
        [Required]
        public double Latitude { get; set; }

        /// <summary>
        /// Longitud
        /// </summary>
        [Required]
        public double Longitude { get; set; }

        /// <summary>
        /// Id del planeta donde se encuentra
        /// </summary>
        [Required]
        public Guid PlanetId { get; set; }
        /// <summary>
        /// Planeta donde se encuentra
        /// </summary>
        public Planet Planet { get; set; }

        /// <summary>
        /// Fecha cuando el rebelde estuvo ubicado en la posicion
        /// </summary>
        [Required]
        public DateTime Date { get; set; }
    }
}
