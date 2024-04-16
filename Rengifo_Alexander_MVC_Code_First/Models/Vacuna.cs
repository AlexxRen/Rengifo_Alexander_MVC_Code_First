using System.ComponentModel.DataAnnotations;

namespace Rengifo_Alexander_MVC_Code_First.Models
{
    public class Vacuna
    {
        public Vacuna() 

        {
            IdVacuna = 1234;
            Nombre = "Nombre Vacuna";
            PaisProcedencia = "Procedencia Vacuna";
        }
        [Key] public required int IdVacuna { get; set; }
        public required string Nombre { get; set; }
        public required string PaisProcedencia { get; set; }

    }
}
