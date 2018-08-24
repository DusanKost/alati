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
using System.IO;

namespace Igraionica
{
    public partial class frmSony : Form
    {
        SqlConnection konekcija = new SqlConnection(Konekcija.cnn);
        Akaunt ak;
        Queue<Akaunt> akaunti;
        public frmSony()
        {
            akaunti = new Queue<Akaunt>();
            InitializeComponent();
        }

        private void frmSony_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'igraionicaDataSet.TipSony' table. You can move, or remove it, as needed.
            this.tipSonyTableAdapter.Fill(this.igraionicaDataSet.TipSony);
            // TODO: This line of code loads data into the 'igraionicaDataSet.AccSony' table. You can move, or remove it, as needed.
            this.accSonyTableAdapter.Fill(this.igraionicaDataSet.AccSony);
            groupBox1.Enabled = false;

        }
        private void query() {
            try
            {
                listBox1.Items.Clear();
                konekcija.Open();
                using (SqlCommand komanda = new SqlCommand(@"select username 
                from AccSony where TipS =@ID", konekcija))
                {
                    komanda.Parameters.Add(new SqlParameter
                        ("ID", comboBox1.SelectedValue));
                    SqlDataReader sdr = komanda.ExecuteReader();
                    while (sdr.Read())
                    {
                        listBox1.Items.Add(sdr.GetValue(0).ToString());
                    }
                }
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
        private void noviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            frmSonyNovi frm = new frmSonyNovi();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ak = new Akaunt(frm.Aka.Sifra, frm.Aka.Username,
                    frm.Aka.Pass,frm.Aka.Tip);
                akaunti.Enqueue(ak);
                accSonyTableAdapter.Insert(frm.Aka.Sifra,frm.Aka.Username,
                    frm.Aka.Pass,frm.Tip);
                accSonyTableAdapter.Fill(igraionicaDataSet.AccSony);
            }
        }

        private void stampajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("AccSony.txt");
            foreach (Akaunt a in akaunti)
            {
                sw.WriteLine(a.ToString());
            }
            sw.Close();
            MessageBox.Show("Uspesno ste Odstampali podatke");
        }

        private void pretraziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                query();
            }
        }

        private void obrisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    konekcija.Open();
                    using (SqlCommand komanda  = new SqlCommand(@"delete from
                    AccSony where Sifra =@ID", konekcija))
                    {
                        komanda.Parameters.Add(new SqlParameter("ID",
                            int.Parse (dataGridView1.SelectedRows[0].Cells[0].Value.ToString())));

                        komanda.ExecuteScalar();
                        MessageBox.Show("Izabrani kandidat je izbrisan");
                        dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                    }
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
        }
    }
}
