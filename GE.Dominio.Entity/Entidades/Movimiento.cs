using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using GE.Dominio.Base;
using GE.Dominio.Entity.Enums;

namespace GE.Dominio.Entity.Entidades
{
    [Table("Movimiento")]
    public class Movimiento : EntityBase
    {
        public TipoMovimiento TipoMovimiento { get; set; }

        public DateTime FechaActualizacion { get; set; }

        public string Descripcion { get; set; }

        public long CajaId { get; set; }

        //*****************************************************//

        public Caja Caja { get; set; }

    }
}
