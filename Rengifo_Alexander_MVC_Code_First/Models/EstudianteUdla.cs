using System.ComponentModel.DataAnnotations;

namespace Rengifo_Alexander_MVC_Code_First.Models
{
    public class EstudianteUdla
    {
        public EstudianteUdla()

        {

            FechaNacimiento = new DateTime (0001, 01, 01);
            IdBanner = 1234;
            Nombre = "Nombre estudiante";
        
        }
        [Key] public required int IdBanner { get; set; }
        public required string Nombre { get; set; }
        public required DateTime FechaNacimiento { get; set; }

        
        /// <summary>
        /// Interconexiones entre modelos
        /// </summary>
        public RecintoVacunacion Reciento { get; set; }
        public Vacuna Vacuna { get; set; }
    }
}
