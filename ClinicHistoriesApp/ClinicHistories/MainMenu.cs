using ClinicHistories.Contracts;
using ClinicHistories.Services;

namespace ClinicHistories
{
    public partial class MainMenu : Form
    {
        private readonly IPatientService patientService;

        public MainMenu(IPatientService patientService)
        {
            InitializeComponent();
            this.patientService = patientService;
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {

        }
    }
}