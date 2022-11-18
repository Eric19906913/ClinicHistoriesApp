using ClinicHistories.Contracts;
using ClinicHistories.Infrastructure;
using ClinicHistories.Models;

namespace ClinicHistories.Services
{
    public class PatientService : IPatientService
    {
        private readonly ClinicHistoryDbContext dbContext;

        public PatientService(ClinicHistoryDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void CreatePatient(PatientDto patient)
        {
            var someId = new Guid();

            var location = new Location()
            {
                Address = "calle siempreviva",
                City = "Moreno bajo el puente",
                PostalCode = "888",
                State = "peronia",
                UserId = someId,
            };

            var patientToAdd = new Patient()
            {
                Id = someId,
                DateOfBirth = patient.DateOfBirth,
                Dni = patient.Dni,
                HealthCare = null,
                Location = location,
                Name = patient.Name,
                Phones = new List<Phone>(),
                Surname = patient.Surname,
            };

            dbContext.Patient.Add(patientToAdd);

            dbContext.SaveChanges();
        }
    }
}
