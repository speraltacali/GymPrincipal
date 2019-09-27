using GE.Dominio.Entity.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GE.IServicio.Cliente.DTO
{
    public  class ClienteDto
    {
        public long Id { get; set; }

        [DisplayName("Apellido")]
        [Required(AllowEmptyStrings =false, ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(150, ErrorMessage = "El campo {1} es obligatorio")]
        public string Apellido { get; set; }

        [DisplayName("Nombre")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(150, MinimumLength = 4, ErrorMessage = "El campo {1} es obligatorio")]
        public string Nombre { get; set; }

        [DisplayName("Documento")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(8)]
        //[Range(8,9, ErrorMessage = "El campo tiene que tener 8 digitos.")]
        public string Dni { get; set; }

        [DisplayName("Telefono")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(25, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        public string Telefono { get; set; }

        [DisplayName("Domicilio")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(300, ErrorMessage = "El campo {1} es obligatorio.")]
        public string Domicilio { get; set; }

        [DisplayName("Fecha de Nacimiento")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio")]
        [DataType(DataType.Date)]
        
        public DateTime FechaNacimiento { get; set; }

        [DisplayName("Sexo")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio")]
        [EnumDataType(typeof(Dominio.Entity.Enums.Sexo))]
        public Sexo Sexo { get; set; }

        [DisplayName("Grupo Sanguineo")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio")]
        [EnumDataType(typeof(Dominio.Entity.Enums.GrupoSanguineo))]
        public GrupoSanguineo GrupoSanguineo { get; set; }

        [DisplayName("Fecha de Ingreso")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio")]
        [DataType(DataType.Date)]
        public DateTime FechaDeIngreso { get; set; }
        /*public DateTime FechaVencimineto { get; set; }*/
    }
}
