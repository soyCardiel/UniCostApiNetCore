using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UnitCost.Dto.Catalalogs
{
    [Table("MeasureUnit")]
    public class MeasureUnitDto
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
    }
}
