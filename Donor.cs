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
    public partial class Donor: Form
    {
        public Donor()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-ASIYA;Initial Catalog=db.KanBankası;Integrated Security=True;Encrypt=False");
        private void Reset()
        {
            txtDonorAdSoyad.Text = "";
            txtDonorYas.Text = "";
            txtDonorCinsiyet.Text = "";
            txtDonorTelefon.Text = "";
            cmbDonorAdres.Text = "";
            cmbDonorKanGrubu.Text = "";
        }
    
        private void Donor_Load(object sender, EventArgs e)
        {

        }

        private void bnfBtnKaydet_Click(object sender, EventArgs e)
        {
            if (txtDonorAdSoyad.Text == "" || txtDonorYas.Text == "" || txtDonorCinsiyet.SelectedIndex == -1 || txtDonorTelefon.Text == "" || cmbDonorAdres.Text == "" || cmbDonorKanGrubu.SelectedIndex == -1)
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    string query = "insert into Donor_tbl values ('" + txtDonorAdSoyad.Text + "'," + txtDonorYas.Text + ",'" + txtDonorCinsiyet.SelectedItem.ToString() + "','" + txtDonorTelefon.Text + "','" + cmbDonorAdres.Text + "','" + cmbDonorKanGrubu.SelectedItem.ToString() + "')";
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Donor Başarıyla Kaydedildi");
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
