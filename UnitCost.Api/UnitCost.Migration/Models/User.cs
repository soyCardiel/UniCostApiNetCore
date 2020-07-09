using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UnitCost.DBMigrations.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "VARCHAR(200)")]
        public string Firstname { get; set; }
        [Column(TypeName = "VARCHAR(200)")]
        public string Lastname { get; set; }
        [Column(TypeName = "VARCHAR(200)")]
        public string Email { get; set; }
        [Column(TypeName = "VARCHAR(200)")]
        public string Psswrd { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime Birthdate { get; set; }
    }
}
