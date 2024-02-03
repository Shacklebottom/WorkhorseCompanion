
namespace CompanionFormApp

{
    //tsmi = tool strip menu item
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void tsmi_AddProject_clicked(object sender, EventArgs e)
        {
            NewProjectForm newProjectForm = new NewProjectForm();
            newProjectForm.ShowDialog();
        }
    }
}
