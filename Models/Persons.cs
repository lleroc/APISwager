using System.ComponentModel.DataAnnotations;

namespace APISwager.Models
{
    public class Persons
    {
        public int Id { get; set; }
        public string codigo_cliente { get; set; } 
        public string apellido_contacto { get; set; }
        public string nombre_contacto { get; set; }
    }
}
