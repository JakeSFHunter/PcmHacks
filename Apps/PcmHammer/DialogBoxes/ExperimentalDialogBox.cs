using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcmHacking
{
    /// <summary>
    /// This form reminds the user to pause before attempting a full read.
    /// </summary>
    public partial class ExperimentalDialogBox : Form
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public ExperimentalDialogBox()
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();
        }

        /// <summary>
        /// Start the timer when the dialog box loads.
        /// </summary>
        private void ExperimentalDialogBox_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Close the form with an "OK" result.
        /// </summary>
        private void continueButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Close the form with a "Cancel" result.
        /// </summary>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
