namespace ClinicHistories.Contracts
{
    public record PatientDto
    {
        public string Dni { get; set; } = null!;

        public string Name { get; set; } = null!;

        public string Surname { get; set; } = null!;

        public DateTime DateOfBirth { get; set; }

        public int? Age { get => DateTime.Now.Year - DateOfBirth.Year; }
    }
}
