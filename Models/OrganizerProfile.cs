using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_S02.Models
{
    internal class OrganizerProfile
    {
        public int Id { get; set; }
        public string Biography { get; set; }
        public string WebsiteUrl { get; set; }
        public string LogoPath { get; set; }
        public int OrganizerId { get; set; }
        public Organizer Organizer { get; set; }
    }
}
