using System.Collections.Generic;

namespace InfoRebel.Domain.Entities
{
    /// <summary>
    /// Cárcel    
    /// </summary>
    public class Jail : Entity
    {
        /// <summary>
        /// Nombre
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Lista de personas registradas en la carcel
        /// </summary>
        public List<CatchRecord> CatchRecords { get; set; }

        /// <summary>
        /// Listado de escapes en la carcel
        /// </summary>
        public List<EscapeRecord> EscapeRecords { get; set; }
    }
}
