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

namespace WindowsFormsApp1
{
    public partial class Hasta: Form
    {
        public Hasta()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-ASIYA;Initial Catalog=db.KanBankası;Integrated Security=True;Encrypt=False");
        private void Reset()
        {
            txtHAdSoyad.Text = "";
            txtHYas.Text = "";
            txtHCinsiyet.Text = "";
            txtHTelefon.Text = "";
            txtHAdres.Text = "";
            txtHKanGrubu.Text = "";
        }
    

        private void label5_Click(object sender, EventArgs e)
        {

            Hasta HL = new Hasta();
            HL.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            HastaListesi HL = new HastaListesi();
            HL.Show();
            this.Hide();
        }

        private void bnfBtnKaydet_Click(object sender, EventArgs e)
        {

            if (txtHAdSoyad.Text == "" || txtHYas.Text == "" || txtHTelefon.Text == "" || txtHCinsiyet.SelectedIndex == -1 || txtHKanGrubu.SelectedIndex == -1 || txtHAdres.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    string query = "insert into Hasta_tbl values ('" + txtHAdSoyad.Text + "'," + txtHYas.Text + ",'" + txtHTelefon.Text + "','" + txtHCinsiyet.SelectedItem.ToString() + "','" + txtHKanGrubu.SelectedItem.ToString() + "','" + txtHAdres.Text + "')";
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Hasta Başarıyla Kaydedildi");
                    Reset();
                    baglanti.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Hatalı Mesaj");
                }
            }
        }
    }
}
