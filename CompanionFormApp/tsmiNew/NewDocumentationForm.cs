using CompanionDomain;

namespace CompanionFormApp.tsmiNew
{
    public partial class NewDocumentationForm : Form
    {
        public NewDocumentationForm()
        {
            InitializeComponent();

            cmbbxDocumentationSource.DataSource = Enum.GetValues(typeof(SourceType));
        }

        private void cmbbxDocumentationSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((SourceType?)cmbbxDocumentationSource.SelectedValue == SourceType.External)
            {
                txbxInternalSource.Visible = false;
                lblInternalSource.Visible = false;

                txbxExternalSource.Visible = true;
                lblExternalSource.Visible = true;
            }
            else if ((SourceType?)cmbbxDocumentationSource.SelectedValue == SourceType.Internal)
            {
                txbxExternalSource.Visible= false;
                lblExternalSource.Visible= false;

                txbxInternalSource.Visible = true;
                lblInternalSource.Visible = true;
            }
        }

        private void btnAccept_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbxExternalSource.Text) || string.IsNullOrWhiteSpace(txbxInternalSource.Text))
            {
                return;
            }
            else if (!string.IsNullOrWhiteSpace(txbxExternalSource.Text))
            {

            }
            else if (!string.IsNullOrWhiteSpace(txbxInternalSource.Text))
            {

            }
        }
    }
}
