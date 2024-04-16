using System.ComponentModel.DataAnnotations;

namespace Rengifo_Alexander_MVC_Code_First.Models
{
    public class RecintoVacunacion
    {
        public RecintoVacunacion() 
        
        {
           IdRecinto = 01234;
           Ciudad = "Cuidad";
           Direccion = "Direccion no establecida";
        
        }
        [Key] public required int IdRecinto { get; set;}
        public required string Direccion { get; set;}

        public required string Ciudad { get; set;}

    }
}
