namespace IOsonet.Models
{
    public class Profile
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AvaPath { get; set; }
        public List<Posts> Posts { get; set; }
        
    }
}