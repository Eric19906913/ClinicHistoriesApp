using ClinicHistories.Models;

namespace ClinicHistories.Services
{
    public class PatientService : IPatientService
    {
        public void CreatePatient(Patient patient)
        {
            // TODO: search in the DB if we have this patient, if so maybe we should update it?.
            Console.WriteLine("Some message");
        }
    }
}
