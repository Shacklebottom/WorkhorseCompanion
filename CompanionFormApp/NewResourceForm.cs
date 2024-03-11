using CompanionBusiness;
using CompanionDomain;

namespace CompanionFormApp
{
    public partial class NewResourceForm : Form
    {
        private Project _currentProject;

        private readonly Resource _projectResource = new();

        public NewResourceForm(Project project)
        {
            InitializeComponent();

            cmbbxResourceState.DataSource = Enum.GetValues(typeof(ResourceState));

            _currentProject = project;
        }

        private void btnLocalFile_clicked(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txbxResourcePath.Text = openFileDialog.FileName;
            }
        }

        private void btnSubmitNewResource_clicked(object sender, EventArgs e)
        {
            if (txbxResourcePath.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please specify resource path");

                return;
            }
            _projectResource.State = (ResourceState)cmbbxResourceState.SelectedItem;

            _projectResource.Path = txbxResourcePath.Text;

            new ResourceEngine(_projectResource, _currentProject);

            
        }
    }
}
