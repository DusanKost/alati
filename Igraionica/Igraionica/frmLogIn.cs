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
    public partial class frmLogIn : Form
    {
        SqlConnection konekcija = new SqlConnection(Konekcija.cnn);
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnProveri_Click(object sender, EventArgs e)
        {
            try
            {
                konekcija.Open();
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT COUNT(*) FROM AdminAcc WHERE username='" +
                    tbUsername.Text + "' AND pass='" +
                    tbPass.Text + "'", konekcija);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    DialogResult = DialogResult.OK;
                    Close();
                    
                }
                else
                    MessageBox.Show("Pogresan username ili password");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Greska: " + ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
