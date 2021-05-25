using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseTransactions.Models
{
    public class People
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Pole Imię - jest wymagane")]
        [Column(Order = 1)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Pole Nazwisko - jest wymagane")]
        [Column(Order = 2)]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Pole Miasto - jest wymagane")]
        [Column(Order = 3)]
        public string Town { get; set; }
        [Required(ErrorMessage = "Pole Kraj - jest wymagane")]
        [Column(Order = 4)]
        public string Country { get; set; }
        [Column(Order = 5)]
        public string PostCode { get; set; }
        [Column(Order = 6)]
        public bool IsActive { get; set; }
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreationDate { get; set; }
    }
}
