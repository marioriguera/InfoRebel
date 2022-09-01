using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InfoRebel.Domain.Entities
{
    /// <summary>
    /// Rebelde
    /// </summary>
    public class Rebel : Entity
    {
        public List<Position> Positions { get; set; }

        public List<CatchRecord> CatchRecords { get; set; }

        public List<EscapeRecord> EscapeRecords { get; set; }

        /// <summary>
        /// Recompensa
        /// </summary>
        [Required]
        public decimal Reward { get; set; }

        /// <summary>
        /// Id del Planeta Natal donde nacio
        /// </summary>
        [Required]
        public Guid PlanetId { get; set; }
        /// <summary>
        /// Planeta Natal
        /// </summary>
        public Planet Planet { get; set; }

        /// <summary>
        /// Id de la especie
        /// </summary>
        [Required]
        public Guid SpeciesId { get; set; }
        /// <summary>
        /// Especie
        /// </summary>
        public Species Species { get; set; }

        /// <summary>
        /// Nombre
        /// </summary>
        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        /// <summary>
        /// Sexo
        /// </summary>
        public bool Gender { get; set; }

        /// <summary>
        /// Esta libre
        /// </summary>
        public bool IsFree { get; set; }

        /// <summary>
        /// Edad
        /// </summary>
        [Required]
        public int Age { get; set; }

        /// <summary>
        /// Esta eliminado, no debe ser considerado para las lecturas de informacion
        /// </summary>
        public bool IsDelete { get; set; }

        /// <summary>
        /// Razon de la eliminacion
        /// </summary>
        public string ReasonForRemoval{ get; set; }
    }
}
