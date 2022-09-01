using System;
using System.ComponentModel.DataAnnotations;

namespace InfoRebel.Domain.Entities
{

    /// <summary>
    /// Registro de captura
    /// </summary>
    public class CatchRecord : Entity
    {
        /// <summary>
        /// Id del caza recompensas que realiza la entrega
        /// </summary>
        [Required]
        public Guid BountyHuntingId { get; set; }
        /// <summary>
        /// Caza recompensas que realiza la entrega
        /// </summary>
        public BountyHunting BountyHunting { get; set; }

        /// <summary>
        /// Id de la carcel donde se realiza la entrega
        /// </summary>
        public Guid? JailId { get; set; }
        /// <summary>
        /// Carcel donde se realiza la entrega
        /// </summary>
        public Jail Jail { get; set; }

        /// <summary>
        /// Fecha de la captura
        /// </summary>
        [Required]
        public DateTime Date { get; set; }

        /// <summary>
        /// Monto pagado por la captura
        /// </summary>
        [Required]
        public decimal Amount { get; set; }

        /// <summary>
        /// Estado del rebelde a la hora de ser entregado
        /// </summary>
        [Required]
        [StringLength(500)]
        public string HealthStatus { get; set; }

        /// <summary>
        /// Estatus organico (vivo o muerto)
        /// </summary>
        public bool OrganicStatus { get; set; }

        /// <summary>
        /// Id del Rebelde capturado 
        /// </summary>
        [Required]
        public Guid RebelId { get; set; }
        /// <summary>
        /// Rebelde capturado
        /// </summary>
        public Rebel Rebel { get; set; }
    }
}
