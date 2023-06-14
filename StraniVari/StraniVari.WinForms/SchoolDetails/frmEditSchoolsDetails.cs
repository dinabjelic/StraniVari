using StraniVari.Common.Constants;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
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
            if (ValidateEntry())
            {
                //int numberOfChildren;
                //if (!int.TryParse(txtNumberOfChildren.Text, out numberOfChildren))
                //{
                //    MessageBox.Show("Please enter a valid integer value for the number of children.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}

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

            var principalForm = Application.OpenForms.OfType<frmSchoolsEventDetails>().FirstOrDefault();
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
