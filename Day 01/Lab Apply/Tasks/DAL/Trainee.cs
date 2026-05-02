using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL
{
    public class Trainee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [EnumDataType(typeof(Gender))]
        public Gender Gender { get; set; }

        [MaxLength(14)]
        public string MobileNo { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        public bool IsGraduated { get; set; }

        [ForeignKey(nameof(Track))]
        public int TrackId { get; set; }

        public virtual Track? Track { get; set; }
    }
}
