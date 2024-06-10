using CompanionDomain;

namespace CompanionFormApp.tsmiNew
{
    public partial class NewDocumentationForm : Form
    {
        private AppDirectory _appDirectory = new AppDirectory();

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
                btnFindInternalPath.Visible = false;

                txbxExternalSource.Visible = true;
                lblExternalSource.Visible = true;
            }
            else if ((SourceType?)cmbbxDocumentationSource.SelectedValue == SourceType.Internal)
            {
                txbxExternalSource.Visible = false;
                lblExternalSource.Visible = false;

                txbxInternalSource.Visible = true;
                lblInternalSource.Visible = true;
                btnFindInternalPath.Visible = true;
            }
        }

        private void btnFindInternalPath_Clicked(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void btnAccept_Clicked(object sender, EventArgs e)
        {
            if (txbxExternalSource.Visible)
            {
                if (string.IsNullOrWhiteSpace(txbxExternalSource.Text))
                {
                    return;
                }
                else
                {

                }
            }
            else if (txbxInternalSource.Visible)
            {
                if (string.IsNullOrWhiteSpace(txbxInternalSource.Text))
                {
                    return;
                }
                else
                {

                }
            }
        }
    }
}