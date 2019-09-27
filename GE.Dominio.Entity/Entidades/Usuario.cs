﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using GE.Dominio.Base;

namespace GE.Dominio.Entity.Entidades
{
    [Table("Usuario")]
    public class Usuario : EntityBase
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public bool EstaBloqueado { get; set; }

        //***************************************************//


    }
}
