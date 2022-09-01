using System;
using System.ComponentModel.DataAnnotations;

namespace InfoRebel.Domain.Entities
{
    /// <summary>
    /// Escape
    /// </summary>
    public class EscapeRecord : Entity
    {
        /// <summary>
        /// Id del rebelde que escapo
        /// </summary>
        [Required]
        public Guid RebelId { get; set; }
        /// <summary>
        /// Rebelde que escapo
        /// </summary>
        public Rebel Rebel { get; set; }

        /// <summary>
        /// Id de la carcel donde se efectuo el escape
        /// </summary>
        [Required]
        public Guid JailId { get; set; }
        /// <summary>
        /// Carcel donde se efectuo el escape
        /// </summary>
        public Jail Jail { get; set; }

        /// <summary>
        /// Fecha cuando se realizo el escape
        /// </summary>
        [Required]
        public DateTime Date { get; set; }

        /// <summary>
        /// Monto de recompensa
        /// </summary>
        public decimal Amount { get; set; }
    }
}
