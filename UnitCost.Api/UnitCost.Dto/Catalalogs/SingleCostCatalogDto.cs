using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UnitCost.Dto.Catalalogs
{
    [Table("SingleCostCatalog")]
    public class SingleCostCatalogDto
    {
        [Key]
        public int Id { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int UnitId { get; set; }
        public decimal Cost { get; set; }
    }
}
