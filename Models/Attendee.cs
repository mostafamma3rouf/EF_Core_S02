using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_S02.Models
{
    [Table ("Attendees")]
    internal class Attendee
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(150)]
        public string FullName { get; set; }
        [Required, MaxLength(200)]
        public string Email { get; set; }
        public Address HomeAddress { get; set; }
        public Badge Badge { get; set; }
    }
}
