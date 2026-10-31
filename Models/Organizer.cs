using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_S02.Models
{
    [Table ("EventOrganizers")]
    internal class Organizer
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(150)]
        public string? CompanyName { get; set; } // Optional property, can be null
        public OrganizerProfile Profile { get; set; } = new();
        public ICollection<Event> Events { get; set; } = new List<Event>();
    }
}
