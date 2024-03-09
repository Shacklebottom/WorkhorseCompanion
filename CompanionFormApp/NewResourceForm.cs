using CompanionBusiness;
using CompanionDomain;

namespace CompanionFormApp
{
    public partial class NewResourceForm : Form
    {
        public Project CurrentProject { get; set; }

        public Resource Resource { get; set; } = new();

        public NewResourceForm(Project project)
        {
            InitializeComponent();

            cmbbxResourceState.DataSource = Enum.GetValues(typeof(ResourceState));

            CurrentProject = project;
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
            Resource.State = (ResourceState)cmbbxResourceState.SelectedItem;

            Resource.Name = txbxResourceName.Text;

            Resource.Path = txbxResourcePath.Text;

            ResourceEngine resourceEngine = new ResourceEngine(Resource, CurrentProject);

            CurrentProject = resourceEngine.CurrentProject;
        }
    }
}
