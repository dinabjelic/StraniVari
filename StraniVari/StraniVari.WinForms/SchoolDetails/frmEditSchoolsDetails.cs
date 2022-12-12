using StraniVari.Core.Requests;

namespace StraniVari.WinUI.SchoolDetails
{
    public partial class frmEditSchoolsDetails : Form
    {
        public frmEditSchoolsDetails()
        {
            InitializeComponent();
        }

        public frmEditSchoolsDetails(EventSchoolUpdateRequest selectedElement)
        {
            SelectedElement = selectedElement;
        }

        public EventSchoolUpdateRequest SelectedElement { get; }

        private void frmEditSchoolsDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
