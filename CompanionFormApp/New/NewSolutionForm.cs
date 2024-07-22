using CompanionDomain.Objects;

#pragma warning disable IDE1006 // Naming Styles

namespace CompanionFormApp.New
{
    public partial class NewSolutionForm : Form
    {
        private readonly AppDirectory _appDirectory = new();

        public NewSolutionForm()
        {
            InitializeComponent();
        }

        private void btnAccept_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbxSolutionName.Text)) { return; }

            var confirmMsg = $"Are you sure you want to create a new Solution with \'{txbxSolutionName.Text}\' as the name?";

            var captionMsg = "Confirm New Solution?";

            if (MessageBox.Show($"{confirmMsg}", $"{captionMsg}", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
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
