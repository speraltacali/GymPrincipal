﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using GE.Dominio.Base;

namespace GE.Dominio.Entity.Entidades
{
    [Table("Factura")]
    public class Factura : EntityBase
    {
        public string NumeroFactura { get; set; }

        public DateTime FechaOperacion { get; set; }

        public decimal SubTotal { get; set; }

        public decimal Total { get; set; }

        public long ClienteId { get; set; }

        //*****************************************************//
        
        public virtual Cliente Cliente { get; set; }

    }
}
