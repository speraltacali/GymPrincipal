﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using GE.Dominio.Base;
using GE.Dominio.Entity.Enums;

namespace GE.Dominio.Entity.Entidades
{
    [Table("Persona")]
    public abstract class Persona : EntityBase
    {
        public string Apellido { get; set; }

        public string Nombre { get; set; }

        public string Dni { get; set; }

        public string Telefono { get; set; }

        public string Domicilio { get; set; }

        public string Mail { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public Sexo Sexo { get; set; }

    }
}
