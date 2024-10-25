
namespace Web.Models
{
    public class Owner : EntityBase
    {
        public string FullName { get; set; }
        public string Profile { get; set; }
        public string Image { get; set; }

        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}
