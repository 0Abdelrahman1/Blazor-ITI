using System.ComponentModel.DataAnnotations;

namespace SharedEntities
{
    public class Track
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [MinLength(3)]
        public string Description { get; set; }
    }
}
