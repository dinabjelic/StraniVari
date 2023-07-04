using StraniVari.Common.Constants;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.WinUI.EventDetails;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.SchoolDetails
{
    public partial class frmEditSchoolsDetails : Form
    {
        ApiService _apiServiceEventSchool = new ApiService("EventSchool");
        ApiService _apiServiceEventSchoolDetails = new ApiService("EventSchool/get");

        public GetSchoolsForEventResponse _selectedSchool { get; }
        public EventUpsertRequest _selectedEvent { get; }

        public frmEditSchoolsDetails(GetSchoolsForEventResponse selectedSchool = null, EventUpsertRequest selectedEvent = null)
        {
            InitializeComponent();
            _selectedEvent = selectedEvent;
            _selectedSchool = selectedSchool;
        }

        private void frmEditSchoolsDetails_Load(object sender, EventArgs e)
        {
            txtNumberOfChildren.Text = _selectedSchool.NumberOfChildren.ToString();
            txtSchoolAddress.Text = _selectedSchool.SchoolAddress;
            txtSchoolCity.Text = _selectedSchool.SchoolCity;
            txtSchoolName.Text = _selectedSchool.SchoolName;

            
        }

        private async void btnEditSchoolDetails_Click(object sender, EventArgs e)
        {
            if (ValidateEntry())
            {
                var editedDetails = new EventSchoolUpdateRequest
                {
                    EventSchoolId = _selectedSchool.SchoolEventId,
                    NumberOfChildren = Int32.TryParse(txtNumberOfChildren.Text, out var result) ? result : 0
                };

                if (editedDetails != null)
                {
                    await _apiServiceEventSchool.Update<ResponseResult>(editedDetails, editedDetails.EventSchoolId);
                    MessageBox.Show("Details successfully updated.", "Infomation", MessageBoxButtons.OK);
                }
                this.DialogResult = DialogResult.OK;
                Close();
            }

            var principalForm = Application.OpenForms.OfType<frmEventTabs>().FirstOrDefault();
            principalForm.frmSchoolsEventDetails_Load(sender, e);
        }

        private bool ValidateEntry()
        {
            return ValidateControl(txtNumberOfChildren, Constants.RequiredValue);
        }

        private bool ValidateControl(Control control, string message)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
            {
                err.SetError(control, message);
                return false;
            }
            err.Clear();
            return true;
        }
    }
}
