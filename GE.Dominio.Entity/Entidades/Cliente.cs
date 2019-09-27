using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GE.Dominio.Base;
using GE.Dominio.Entity.Entidades;
using GE.Dominio.Entity.Enums;

namespace GE.Dominio.Entity
{
    [Table("Cliente")]
    public class Cliente : EntityBase
    {
        [DisplayName("Apellido")]
        [Required]
        [StringLength(150, ErrorMessage = "El campo {1} es obligatorio")]
        public string Apellido { get; set; }

        [DisplayName("Nombre")]
        [Required]
        [StringLength(150, MinimumLength = 4, ErrorMessage = "El campo {1} es obligatorio")]
        public string Nombre { get; set; }

        [DisplayName("Documento")]
        [Required]
        [StringLength(8, ErrorMessage = "El campo {1} es obligatorio")]
        public string Dni { get; set; }

        [DisplayName("Telefono")]
        [Required]
        [StringLength(25, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        public string Telefono { get; set; }

        [DisplayName("Domicilio")]
        [Required]
        [StringLength(300, ErrorMessage = "El campo {1} es obligatorio.")]
        public string Domicilio { get; set; }

        [DisplayName("Fecha de Nacimiento")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        [DisplayName("Sexo")]
        [Required]
        [EnumDataType(typeof(Enums.Sexo))]
        public Sexo Sexo { get; set; }

        [DisplayName("Grupo Sanguineo")]
        [Required]
        [EnumDataType(typeof(Enums.GrupoSanguineo))]
        public GrupoSanguineo GrupoSanguineo { get; set; }

        [DisplayName("Fecha de Ingreso")]
        [DataType(DataType.Date)]
        public DateTime FechaDeIngreso { get; set; }

        //public DateTime FechaVencimineto { get; set; }


        //******************************************************//

        //public virtual ICollection<Factura> Factura { get; set; }


    }
}
