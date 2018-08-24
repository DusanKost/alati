using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Igraionica
{
    public partial class frmSonyNovi : Form
    {
        Akaunt aka;
        int tip;

        internal Akaunt Aka
        {
            get
            {
                return aka;
            }
        }

        public int Tip
        {
            get
            {
                return tip;
            }
        }

        public frmSonyNovi()
        {
            InitializeComponent();
        }

        private void frmSonyNovi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'igraionicaDataSet.TipSony' table. You can move, or remove it, as needed.
            this.tipSonyTableAdapter.Fill(this.igraionicaDataSet.TipSony);

        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbSifra.Text) &&
                !string.IsNullOrEmpty(tbUsername.Text) &&
                !string.IsNullOrEmpty(tbPass.Text) &&
                cbTip.SelectedIndex != -1)
            {
                aka = new Akaunt(int.Parse(tbSifra.Text), tbUsername.Text,
                    tbPass.Text, cbTip.Text);
                tip = int.Parse(cbTip.SelectedValue.ToString());
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Sva polja moraju biti popunjena");
            }
        }
    }
}
