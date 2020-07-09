using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UnitCost.DBMigrations.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "VARCHAR(200)")]
        public string Name { get; set; }
    }
}
