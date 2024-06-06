using CompanionBusiness;
using CompanionDomain;

namespace RefactoredFormApp
{
    public partial class NewResourceForm : Form
    {
        private readonly Project _currentProject;

        private readonly Resource _projectResource = new();

        public NewResourceForm(Project project)
        {
            InitializeComponent();

            cmbbxResourceState.DataSource = Enum.GetValues(typeof(ResourceState));

            _currentProject = project;
        }

        private void btnLocalFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txbxResourcePath.Text = openFileDialog.FileName;
            }
        }

        private void btnSubmitNewResource_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbxResourcePath.Text))
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
