using ClinicHistories.Contracts;

namespace ClinicHistories.Services
{
    public interface IPatientService
    {
        public void CreatePatient(PatientDto patient);
    }
}
