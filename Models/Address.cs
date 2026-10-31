using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Core_S02.AppDbContexts;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_S02.Models
{
    [Owned]
    internal class Address
    {
        [Required, MaxLength(150)]
        public string Street { get; set; }
        [Required, MaxLength(100)]
        public string City { get; set; }
        [Required, MaxLength(100)]
        public string Country { get; set; }
        [Required, Column("ZipCode"), MaxLength(20)]
        public string PostalCode { get; set; }
    }
}
