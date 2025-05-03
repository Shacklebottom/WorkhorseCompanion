using CompanionDomain.Engines;
using CompanionDomain.Enums;
using CompanionDomain.Objects;

#pragma warning disable IDE1006

namespace CompanionFormApp.New
{
    public partial class NewResourceForm : Form
    {
        private PathBuilder _pathBuilder;

        private ResourceEngine? _resourceEngine;

        public ResourceState? ResourceCategory;

        public NewResourceForm(PathBuilder pathBuilder)
        {
            InitializeComponent();

            _pathBuilder = pathBuilder;
     
            cmbbxResourceState.DataSource = Enum.GetValues(typeof(ResourceState));
        }

        private void cmbbxResourceState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((ResourceState?)cmbbxResourceState.SelectedItem == ResourceState.Image)
            {
                btnFindPath.Visible = true;
                lblFileExtension.Visible = true;
                txbxFileExtension.Visible = true;
                lblNameResource.Visible = true;
                txbxNameResource.Visible = true;
            }
            else if ((ResourceState?)cmbbxResourceState.SelectedItem == ResourceState.Website)
            {
                btnFindPath.Visible = false;
                lblFileExtension.Visible = false;
                txbxFileExtension.Visible = false;
                lblNameResource.Visible = false;
                txbxNameResource.Visible = false;
            }
            else if ((ResourceState?)cmbbxResourceState.SelectedItem == ResourceState.Document)
            {
                btnFindPath.Visible = true;
                lblFileExtension.Visible = true;
                txbxFileExtension.Visible = true;
                lblNameResource.Visible = true;
                txbxNameResource.Visible = true;
            }
        }

        private void btnFindPath_Clicked(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var selectedFile = openFileDialog.FileName;
                txbxResourcePath.Text = selectedFile;
            }
        }

        private void btnAccept_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbxResourcePath.Text) ||
                (string.IsNullOrWhiteSpace(txbxNameResource.Text) && txbxNameResource.Visible == true) ||
                (string.IsNullOrWhiteSpace(txbxFileExtension.Text) && txbxFileExtension.Visible == true))
            { return; }

            var confirmMsg = $"Are you sure you want to create a new Resource with the type {cmbbxResourceState.Text}?";
            var captionMsg = "Confirm Resource?";

            if (MessageBox.Show($"{confirmMsg}", $"{captionMsg}", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                Resource newResource = new()
                {
                    State = cmbbxResourceState.SelectedItem as ResourceState?,
                    Path = txbxResourcePath.Text,
                    Name = RegularExpressions.InvalidCharactersRegex().Replace(txbxNameResource.Text, ""),
                    FileExtension = txbxFileExtension.Text
                };
                
                ResourceCategory = newResource.State;

                _resourceEngine = new(newResource, _pathBuilder);

                if (!string.IsNullOrWhiteSpace(_resourceEngine.ResourceError))
                {
                    MessageBox.Show($"A resource error occurred: {_resourceEngine.ResourceError}");

                    return;
                }
            }

            Close();

            Dispose();

            this.DialogResult = DialogResult.Yes;
        }
    }
}
