using CompanionDomain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

namespace CompanionFormApp.tsmiNew
{
    public partial class NewDocumentationForm : Form
    {
        public NewDocumentationForm()
        {
            InitializeComponent();

            cmbbxDocumentationSource.DataSource = Enum.GetValues(typeof(SourceType));
        }

        private void btnAccept_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbxExternalSource.Text) || string.IsNullOrWhiteSpace(txbxInternalSource.Text))
            {
                return;
            }
            else if (!string.IsNullOrWhiteSpace(txbxExternalSource.Text))
            {

            }
            else if (!string.IsNullOrWhiteSpace(txbxInternalSource.Text))
            {

            }
        }
    }
}
