using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanionFormApp.primaryForm
{
    public partial class TicketSystemForm : Form
    {
        private Form _parentForm;

        public TicketSystemForm(GitWrapperForm form)
        {
            InitializeComponent();

            _parentForm = form;
        }

        private void TicketSystemForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parentForm.Show();
        }
    }
}
