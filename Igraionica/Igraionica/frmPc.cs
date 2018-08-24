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
    public partial class frmPc : Form
    {
        SqlConnection konekcija = new SqlConnection(Konekcija.cnn);
        Akaunt ak;
        Queue<Akaunt> akaunti;
        public frmPc()
        {
            akaunti = new Queue<Akaunt>();
            InitializeComponent();
        }

        private void frmPc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'igraionicaDataSet.TipPc' table. You can move, or remove it, as needed.
            this.tipPcTableAdapter.Fill(this.igraionicaDataSet.TipPc);
            // TODO: This line of code loads data into the 'igraionicaDataSet.AccPc' table. You can move, or remove it, as needed.
            this.accPcTableAdapter.Fill(this.igraionicaDataSet.AccPc);
            groupBox1.Enabled = false;

        }
        private void query()
        {
            try
            {
                listBox1.Items.Clear();
                konekcija.Open();
                using (SqlCommand komanda = new SqlCommand(@"select username 
                from AccPc where TipP =@ID", konekcija))
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
            frmPcNovi frm = new frmPcNovi();
            groupBox1.Enabled = false;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ak = new Akaunt(frm.Aka.Sifra, frm.Aka.Username,
                    frm.Aka.Pass, frm.Aka.Tip);
                akaunti.Enqueue(ak);
                accPcTableAdapter.Insert(frm.Aka.Sifra, frm.Aka.Username,
                    frm.Aka.Pass, frm.Tip);
                accPcTableAdapter.Fill(igraionicaDataSet.AccPc);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                query();
            }
        }

        private void pretraziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void stampajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("AccPc.txt");
            foreach (Akaunt a in akaunti)
            {
                sw.WriteLine(a.ToString());
            }
            sw.Close();
            MessageBox.Show("Uspesno ste Odstampali podatke");
        }

        private void obrisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    konekcija.Open();
                    using (SqlCommand komanda = new SqlCommand(@"delete from
                    AccPc where Sifra =@ID", konekcija))
                    {
                        komanda.Parameters.Add(new SqlParameter("ID",
                            int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString())));

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
