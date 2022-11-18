namespace ClinicHistories.Models
{
    public class Patient
    {
        public Guid Id { get; set; }

        public string Dni { get; set; } = null!;

        public string Name { get; set; } = null!;

        public string Surname { get; set; } = null!;

        public DateTime DateOfBirth { get; set; }

        public int? Age { get => DateTime.Now.Year - DateOfBirth.Year; }

        public Location Location { get; set; } = null!;

        public IEnumerable<Phone> Phones { get; set; } = new List<Phone>();

        public HealthCare? HealthCare { get; set; }
    }
}
