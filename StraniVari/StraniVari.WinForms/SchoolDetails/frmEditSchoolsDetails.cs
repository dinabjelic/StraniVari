using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.SchoolDetails
{
    public partial class frmEditSchoolsDetails : Form
    {
        ApiService _apiServiceEventSchool = new ApiService("EventSchool");
        public GetSchoolsForEventResponse _selectedSchool { get; }
        public EventUpsertRequest _selectedEvent { get; }

        public frmEditSchoolsDetails(GetSchoolsForEventResponse selectedSchool = null, EventUpsertRequest selectedEvent=null) 
        {
            InitializeComponent();
            _selectedEvent = selectedEvent;
            _selectedSchool = selectedSchool;
        }

        private void frmEditSchoolsDetails_Load(object sender, EventArgs e)
        {
            txtName.Text = _selectedEvent.Name;
            txtTheme.Text = _selectedEvent.StraniVariTheme;
            txtStartDate.Text = _selectedEvent.StartDate.ToString("D");
            txtEndDate.Text = _selectedEvent.EndDate.ToString("D");

            txtNumberOfChildren.Text = _selectedSchool.NumberOfChildren.ToString();
            txtSchoolAddress.Text = _selectedSchool.SchoolAddress;
            txtSchoolCity.Text = _selectedSchool.SchoolCity;
            txtSchoolName.Text = _selectedSchool.SchoolName;
        }

        private async void btnEditSchoolDetails_Click(object sender, EventArgs e)
        {
            var editedDetails = new EventSchoolUpdateRequest
            {
                EventSchoolId = _selectedSchool.SchoolEventId,
                NumberOfChildren = Int32.Parse(txtNumberOfChildren.Text)
            };

            if(editedDetails != null)
            {
                await _apiServiceEventSchool.Update<ResponseResult>(editedDetails);
                MessageBox.Show("Details successfully updated.", "Infomation", MessageBoxButtons.OK);
            }
            this.DialogResult = DialogResult.OK;
            Close();

            var principalForm = Application.OpenForms.OfType<frmSchoolsEventDetails>().FirstOrDefault();
            principalForm.frmSchoolsEventDetails_Load(sender,e);
        }
    }
}
