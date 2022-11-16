using ClinicHistories.Models;
using ClinicHistories.Services;

namespace ClinicHistories
{
    public partial class MainMenu : Form
    {
        private readonly IPatientService patientService;

        public MainMenu(IPatientService patientService)
        {
            InitializeComponent();
            HealthCareNameTextBox.Visible = false;
            HealthCareNumberTextBox.Visible = false;
            this.patientService = patientService;
        }

        private void HasHealthCare_CheckedChanged(object sender, EventArgs e)
        {
            if (HasHealthCare.Checked)
            {
                HealthCareNameTextBox.Visible = true;
                HealthCareNumberTextBox.Visible = true;
                HealthCareNameTextBox.Focus();
            }
            else
            {
                HealthCareNameTextBox.Visible = false;
                HealthCareNumberTextBox.Visible = false;
            }
        }

        private void CreatePatientButton_Click(object sender, EventArgs e)
        {
            patientService.CreatePatient(new Patient());
        }
    }
}