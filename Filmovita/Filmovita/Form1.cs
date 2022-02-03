using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmovita
{
    public partial class Form1 : Form
    {
        int index;
        

        DataSet ds = new DataSet();
        public Form1()
        {
            
            InitializeComponent();
            string konekcijskiString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Filmovita.accdb";

            OleDbConnection konekcija = new OleDbConnection(konekcijskiString);

            try
            {
                string sqlUpit = "SELECT * FROM fiilmovi";
                OleDbDataAdapter da = new OleDbDataAdapter(sqlUpit, konekcija);

                da.Fill(ds);

                this.resultgrid.DataSource = ds.Tables[0];
                
                godinaIzdanja.Text = string.Empty;
                ocjena.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }

        private void trajanje_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if(!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            
            if (nazivtxt.Text.Length < 2 || zanrrtxt.Text == string.Empty || trajanje.Text == string.Empty || redateljtxt.Text == string.Empty || textBoxLokacija.Text == string.Empty)
            {
                MessageBox.Show("Niste unijeli sve potrebne podatke!");
            }
            else
            {
                string konekcijskiString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Filmovita.accdb";

                OleDbConnection konekcija = new OleDbConnection(konekcijskiString);


                try
                {

                    int trajanje1;
                    int.TryParse(trajanje.Text, out trajanje1);

                    string sqlUpit = "INSERT INTO fiilmovi (naziv, godinaIzdanja, zanr, trajanje, ocjena, redatelj, lokacija) VALUES (@Naziv, @GodinaIzdanja, @Zanr, @Trajanje, @Ocjena, @Redatelj, @Lokacija)";

                    OleDbCommand naredba = new OleDbCommand(sqlUpit, konekcija);

                   
                    naredba.Parameters.AddWithValue("@Naziv", naziv.Text);
                    naredba.Parameters.AddWithValue("@GodinaIzdanja", godinaIzdanja.Value);
                    naredba.Parameters.AddWithValue("@Zanr", comboBoxZanr.SelectedItem);
                    naredba.Parameters.AddWithValue("@Trajanje", trajanje1);
                    naredba.Parameters.AddWithValue("@Ocjena", ocjena.Value);
                    naredba.Parameters.AddWithValue("@Redatelj", redatelj.Text);
                    naredba.Parameters.AddWithValue("@Lokacija", textBoxLokacija.Text);

                    konekcija.Open();

                    int uspjesnoDodanoZapisa = naredba.ExecuteNonQuery();

                    if (uspjesnoDodanoZapisa == 1)
                    {
                        MessageBox.Show("Podaci uspješno dodani!");
                        button_refresh_Click(sender, e);
                        naziv.Text = string.Empty;
                        godinaIzdanja.Text = string.Empty;
                        comboBoxZanr.Text = string.Empty;
                        trajanje.Text = string.Empty;
                        ocjena.Text = string.Empty;
                        redatelj.Text = string.Empty;
                        textBoxLokacija.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Pogreška! Podaci nisu spremljeni!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    konekcija.Close();
                }
            }
        }

        private void delete(int id)
        {
            string konekcijskiString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Filmovita.accdb";

            OleDbConnection konekcija = new OleDbConnection(konekcijskiString);
            string sqlUpit = "DELETE FROM fiilmovi WHERE ID=" + id + "";
            OleDbCommand naredba = new OleDbCommand(sqlUpit, konekcija);
            OleDbDataAdapter da = new OleDbDataAdapter(sqlUpit, konekcija);

            try
            {
                konekcija.Open();
                da.DeleteCommand = konekcija.CreateCommand();
                da.DeleteCommand.CommandText = sqlUpit;

                if (MessageBox.Show("Da li želite obrisati označeni film?", "DELETE", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning )==DialogResult.OK)
                {
                    if (naredba.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Uspješno obrisano!");
                       
                    }
                }       
            }
            catch
            {

            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (nazivtxt.Text.Length < 2 || zanrrtxt.Text == string.Empty || trajanje.Text == string.Empty || redateljtxt.Text == string.Empty || textBoxLokacija.Text == string.Empty)
            {
                MessageBox.Show("Niste unijeli sve potrebne podatke!");
            }
            else
            {
                string konekcijskiString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Filmovita.accdb";

                OleDbConnection konekcija = new OleDbConnection(konekcijskiString);


                try
                {
                    
                    String selected = resultgrid.SelectedRows[0].Cells[0].Value.ToString();
                    int id = Convert.ToInt32(selected);
                    int trajanje1;
                    int.TryParse(trajanje.Text, out trajanje1);

                    string sqlUpit = "UPDATE fiilmovi SET naziv='" + naziv.Text + "',godinaIzdanja='" + godinaIzdanja.Value + "',zanr='" + comboBoxZanr.SelectedItem + "', trajanje='"+ trajanje1 + "', ocjena='" + ocjena.Value + "', redatelj='" + redatelj.Text + "', lokacija='" + textBoxLokacija.Text + "' WHERE ID="+ id +"";

                    OleDbCommand naredba = new OleDbCommand(sqlUpit, konekcija);


                   
                    konekcija.Open();

                    int uspjesnoDodanoZapisa = naredba.ExecuteNonQuery();

                    if (uspjesnoDodanoZapisa == 1)
                    {
                        MessageBox.Show("Podaci uspješno izmijenjeni!");
                        button_refresh_Click(sender, e);
                        naziv.Text = string.Empty;
                        godinaIzdanja.Text = string.Empty;
                        comboBoxZanr.Text = string.Empty;
                        trajanje.Text = string.Empty;
                        ocjena.Text = string.Empty;
                        redatelj.Text = string.Empty;
                        textBoxLokacija.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Pogreška! Podaci nisu spremljeni!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    konekcija.Close();
                }
            }

        }


        private void deletebtn_Click(object sender, EventArgs e)
        {
            String selected = resultgrid.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);
            delete(id);
            button_refresh_Click(sender, e);
            naziv.Text = string.Empty;
            godinaIzdanja.Text = string.Empty;
            comboBoxZanr.Text = string.Empty;
            trajanje.Text = string.Empty;
            ocjena.Text = string.Empty;
            redatelj.Text = string.Empty;
            textBoxLokacija.Text = string.Empty;
        }


        private void button_refresh_Click(object sender, EventArgs e)
        {
            string konekcijskiString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Filmovita.accdb";

            OleDbConnection konekcija = new OleDbConnection(konekcijskiString);

            try
            {
                string sqlUpit = "SELECT * FROM fiilmovi";

                OleDbDataAdapter da = new OleDbDataAdapter(sqlUpit, konekcija);

                DataSet ds = new DataSet();

                da.Fill(ds);

                this.resultgrid.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }

        private void radioButtonMedij_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMedij.Checked)
            {
                textBoxLokacija.Enabled = true;
                textBoxLokacija.Text = "";
            }
        }

        private void radioButtonRacunalo_CheckedChanged(object sender, EventArgs e)
        {
            
            if (radioButtonRacunalo.Checked)
            {
                DialogResult result = folderBrowserDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    textBoxLokacija.Text = folderBrowserDialog1.SelectedPath;
                }
            }
        }

        private void resultgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow row = resultgrid.Rows[index];
                naziv.Text = row.Cells[1].Value.ToString();
                godinaIzdanja.Text = row.Cells[2].Value.ToString();
                comboBoxZanr.Text = row.Cells[3].Value.ToString();
                trajanje.Text = row.Cells[4].Value.ToString();
                ocjena.Text = row.Cells[5].Value.ToString();
                redatelj.Text = row.Cells[6].Value.ToString();
                textBoxLokacija.Text = row.Cells[7].Value.ToString();
            }
            
        }
    }
}
