using System.ComponentModel.DataAnnotations;

namespace IOsonet.Models
{
    public class Profile
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string AvaPath { get; set; }
        public List<Posts> Posts { get; set; }
        public List<Profile> FriendsProfiles { get; set; }
        
    }
}