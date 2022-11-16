using ClinicHistories.Models;

namespace ClinicHistories.Services
{
    public interface IPatientService
    {
        public void CreatePatient(Patient patient);
    }
}
