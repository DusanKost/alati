using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Igraionica
{
    public partial class frmIgraionica : Form
    {
        public frmIgraionica()
        {
            InitializeComponent();
        }
        private void enable() {
            btnUnesiPc.Enabled = true;
            btnUnesiSony.Enabled = true;
            logOffToolStripMenuItem.Enabled = true;
        }
        private void disable()
        {
            btnUnesiPc.Enabled = false;
            btnUnesiSony.Enabled = false;
            logOffToolStripMenuItem.Enabled = false;
        }
        private void frmIgraionica_Load(object sender, EventArgs e)
        {
            disable();
        }

        private void btnUnesiSony_Click(object sender, EventArgs e)
        {
            frmSony frm = new frmSony();
            frm.ShowDialog();
        }

        private void btnUnesiPc_Click(object sender, EventArgs e)
        {
            frmPc frm = new frmPc();
            frm.ShowDialog();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogIn frm = new frmLogIn();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                enable();
            }
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            disable();
        }
    }
}
