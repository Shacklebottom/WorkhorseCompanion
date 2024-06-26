using CompanionDomain.Enums;
using CompanionDomain.Objects;

namespace CompanionFormApp.primaryForms
{
    public partial class JournalSystemForm : Form
    {
        private Project? _currentProject;

        private GitWrapperForm _parentForm;

        public JournalSystemForm(GitWrapperForm parentForm, Project? project)
        {
            InitializeComponent();

            _parentForm = parentForm;

            _currentProject = project;
        }

        #region JOURNAL FORM CLOSING
        private void JournalSystemForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            Hide();

            _parentForm.Show();
        }
        #endregion

    }
}
