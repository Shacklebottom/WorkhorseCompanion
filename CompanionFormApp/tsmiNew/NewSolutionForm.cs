
using CompanionDomain;

namespace CompanionFormApp.tsmiNew
{
    public partial class NewSolutionForm : Form
    {
        private readonly AppDirectory _appDirectory = new();

        public NewSolutionForm()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbxSolutionName.Text)) { return; }

            if (MessageBox.Show(
                $"Are you sure you want to create a new Solution with \'{txbxSolutionName.Text}\' as the name?",
                "Confirm New Solution?",
                MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                var newSolutionPath = $"{_appDirectory.PortfolioDir}\\{txbxSolutionName.Text}";

                var newSolutionName = $"{txbxSolutionName.Text}.sln";

                Directory.CreateDirectory(newSolutionPath);

                try
                {
                    File.WriteAllLines($"{newSolutionPath}\\{newSolutionName}", HeaderInfo.VisualStudioHeader);

                    Close();

                    Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An exception was thrown: {ex}");
                }
            }
            else return;
        }
    }
}
