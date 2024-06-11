using CompanionDomain;

#pragma warning disable IDE1006 // Naming Styles

namespace CompanionFormApp.tsmiNew
{
    public partial class NewDocumentationForm : Form
    {
        private readonly AppDirectory _appDirectory = new();

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
                lblRenameInternalDocumentation.Visible = false;
                txbxRenameInternalDocumentation.Visible = false;

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
                lblRenameInternalDocumentation.Visible = true;
                txbxRenameInternalDocumentation.Visible = true;
            }
        }

        private void btnFindInternalPath_Clicked(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var selectedFile = openFileDialog.FileName;
                txbxInternalSource.Text = selectedFile;
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
                    var externalPaths = File.ReadAllLines(_appDirectory.CombinedExternalPath).ToList();

                    externalPaths.Add(txbxExternalSource.Text);

                    File.WriteAllLines(_appDirectory.CombinedExternalPath, externalPaths);

                    Close();
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
                    var newName = txbxRenameInternalDocumentation.Text;

                    var fileExtention = txbxInternalSource.Text.Split(".").Last();

                    File.Move(txbxInternalSource.Text, $"{_appDirectory.InternalDir}\\{newName}.{fileExtention}");

                    Close();
                }
            }
        }
    }
}