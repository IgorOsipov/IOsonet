using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IOsonet.Models
{
    public class Posts
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Body is required")]
        public string Body { get; set; }
    }
}