using CompanionDomain.Engines;
using CompanionDomain.Enums;
using CompanionDomain.Objects;

#pragma warning disable IDE1006

namespace CompanionFormApp.New
{
    public partial class NewResourceForm : Form
    {
        private Project _currentProject { get; set; }

        private ResourceEngine? _resourceEngine;

        public NewResourceForm(Project currentProject)
        {
            InitializeComponent();

            _currentProject = currentProject;

            cmbbxResourceState.DataSource = Enum.GetValues(typeof(ResourceState));
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
                string.IsNullOrWhiteSpace(txbxNameResource.Text) || 
                string.IsNullOrWhiteSpace(txbxFileExtension.Text)) 
            { return; }

            var confirmMsg = $"Are you sure you want to create a new Resource with the type {cmbbxResourceState.Text}?";

            var captionMsg = "Confirm Resource?";

            if (MessageBox.Show($"{confirmMsg}", $"{captionMsg}", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                Resource newResource = new()
                {
                    State = cmbbxResourceState.SelectedItem as ResourceState?,
                    Path = txbxResourcePath.Text,
                    Name = txbxNameResource.Text,
                    FileExtension = txbxFileExtension.Text
                };

                _resourceEngine = new(newResource, _currentProject);

                if (!string.IsNullOrWhiteSpace(_resourceEngine.ResourceError))
                {
                    MessageBox.Show($"A resource error occurred: {_resourceEngine.ResourceError}");
                }
            }

            Close();

            Dispose();
        }
    }
}
