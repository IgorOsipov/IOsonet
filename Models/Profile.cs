using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace IOsonet.Models
{
    public class Profile : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string AvaPath { get; set; }
        public List<Posts> Posts { get; set; }
        public virtual ICollection<FriendShip> Friends { get; set; }
        public virtual ICollection<FriendShip> FriendsOf { get; set; }
    }
}