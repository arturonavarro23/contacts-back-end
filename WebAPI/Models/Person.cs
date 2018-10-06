using System;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Person
    {
        public int ID { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        [StringLength(1)]
        public string Gender { get; set; }
        [StringLength(50)]
        public string Phone { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [StringLength(100)]
        public string Address { get; set; }
        [StringLength(50)]
        public string City { get; set; }
    }
}
