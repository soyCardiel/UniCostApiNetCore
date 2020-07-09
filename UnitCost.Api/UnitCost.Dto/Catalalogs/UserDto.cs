using System;
using System.Collections.Generic;
using System.Text;

namespace UnitCost.Dto.Catalalogs
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Psswrd { get; set; }
        public DateTime? Birthdate { get; set; }
    }
}
