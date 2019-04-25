using System.ComponentModel.DataAnnotations;

namespace clienteback.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        [Required]
        [Display(Name="Client Name")]
        public string Name { get; set; }

        public int mail { get; set; }
    }
}