using System.ComponentModel.DataAnnotations;

namespace segundaParcial.Data
{
    public class Persona
    {
        [Required(ErrorMessage = "El # de inventario es Reuerido")]
        [MaxLength(100, ErrorMessage = "Debe ser un valor positivo y unico Valido")]
        public string? Inventario { get; set; }

        [Required(ErrorMessage = "Requiere nombre de Producto")]
        [MaxLength(10, ErrorMessage = "Maximo 10 letras")]
        public string? Nombre { get; set; }


        public enum Departamento
        {
            Frutas,
            Verduras,
            Lacteos
        }
        public Departamento SelectedDepartamento { get; set; }
        

    }
}
