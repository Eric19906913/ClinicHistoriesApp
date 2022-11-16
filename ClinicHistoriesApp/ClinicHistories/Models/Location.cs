namespace ClinicHistories.Models
{
    public class Location
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public string Address { get; set; } = null!;

        public string City { get; set; } = null!;

        public string State { get; set; } = null!;

        public string PostalCode { get; set; } = null!;
    }
}
