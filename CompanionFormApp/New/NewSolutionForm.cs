using CompanionDomain.Objects;

#pragma warning disable IDE1006 // Naming Styles

namespace CompanionFormApp.New
{
    public partial class NewSolutionForm : Form
    {
        private readonly PathBuilder _pathBuilder;

        public string SanitizedName = "";

        public NewSolutionForm(PathBuilder pathBuilder)
        {
            InitializeComponent();

            _pathBuilder = pathBuilder;
        }

        private void btnAccept_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbxSolutionName.Text)) { return; }

            var confirmMsg = $"Are you sure you want to create a new Solution with \'{txbxSolutionName.Text}\' as the name?";
            var captionMsg = "Confirm New Solution?";

            SanitizedName = RegularExpressions.InvalidCharactersRegex().Replace(txbxSolutionName.Text, "");

            if (MessageBox.Show($"{confirmMsg}", $"{captionMsg}", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                var newSolutionPath = $"{_pathBuilder.AppDirectory.PortfolioDir}\\{SanitizedName}";
                var newSolutionName = $"{SanitizedName}.sln";

                Directory.CreateDirectory(newSolutionPath);

                try
                {
                    File.WriteAllLines($"{newSolutionPath}\\{newSolutionName}", HeaderInfo.VisualStudioHeader);

                    Close();

                    Dispose();

                    this.DialogResult = DialogResult.Yes;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An exception was thrown: {ex}");
                }
            }
            else return;
        }

        private void txbxSolutionName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                btnAccept.PerformClick();
            }
        }
    }
}
