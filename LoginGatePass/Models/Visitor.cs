using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoginGatePass.Models
{
    public class Visitor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public uint Telephone { get; set; }

        public string Company { get; set; }

        [Required]
        public string Purpose { get; set; }

        [Required]
        public string DateBooked { get; set; }

        [Required]
        public uint VisitorCount { get; set; }
    }
}
