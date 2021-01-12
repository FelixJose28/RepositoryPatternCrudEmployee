using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPatternCrudEmployee.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="El nombre es requerido")]
        [Display(Name ="Nombre")]
        public string Name { get; set; }

        [Required(ErrorMessage = "La dirrecion es requerida")]
        [Display(Name = "Direccion")]
        public string Address { get; set; }


        [Required(ErrorMessage = "El salario es requerido")]
        [Display(Name = "Salario")]
        public int Salary { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name="Correo")]
        public string Email { get; set; }

    }
}
