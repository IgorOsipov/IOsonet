namespace IOsonet.Models
{
    public class FriendShip
    {
        public Profile PrimaryProfile { get; set; }
        public string PrimaryProfileId { get; set; }

        public Profile FriendProfile { get; set; }
        public string FriendProfileId { get; set; }
    }
}
