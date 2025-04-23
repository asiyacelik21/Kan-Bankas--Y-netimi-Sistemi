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
    public partial class HastaListesi: Form
    {
        public HastaListesi()
        {
            InitializeComponent();
            Uyeler();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-ASIYA;Initial Catalog=db.KanBankası;Integrated Security=True;Encrypt=False");

        private void Uyeler()

        {
            baglanti.Open();
            string query = "select *from  Hasta_tbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            HastaDGV.DataSource = ds.Tables[0];
            baglanti.Close();

        }
        private void HastaListesi_Load(object sender, EventArgs e)
        {

        }
        int key = 0;
        private void HastaDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtHAdSoyad.Text = HastaDGV.SelectedRows[0].Cells[1].Value.ToString();
            txtHYas.Text = HastaDGV.SelectedRows[0].Cells[2].Value.ToString();
            txtHTelefon.Text = HastaDGV.SelectedRows[0].Cells[3].Value.ToString();
            txtHCinsiyet.Text = HastaDGV.SelectedRows[0].Cells[4].Value.ToString();
            txtHKanGrubu.Text = HastaDGV.SelectedRows[0].Cells[5].Value.ToString();
            txtHAdres.Text = HastaDGV.SelectedRows[0].Cells[6].Value.ToString();
            if (txtHAdSoyad.Text=="")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(HastaDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void Reset()
        {
            txtHAdSoyad.Text = "";
            txtHYas.Text = "";
            txtHCinsiyet.Text = "";
            txtHTelefon.Text = "";
            txtHAdres.Text = "";
            txtHKanGrubu.Text = "";
            key = 0;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            HastaListesi HL = new HastaListesi();
            HL.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

            Hasta HL = new Hasta();
            HL.Show();
            this.Hide();
        }


        private void bnfBtnDuzenle_Click(object sender, EventArgs e)
        {
            if (txtHAdSoyad.Text == "" || txtHYas.Text == "" || txtHTelefon.Text == "" || txtHCinsiyet.SelectedIndex == -1 || txtHKanGrubu.SelectedIndex == -1 || txtHAdres.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    string query = "update Hasta_tbl set HAdSoyad='" + txtHAdSoyad.Text + "',HYas=" + txtHYas.Text + ",HTelefon='" + txtHTelefon.Text + "',HCinsiyet='" + txtHCinsiyet.SelectedItem.ToString() + "',HKanGrubu='" + txtHKanGrubu.SelectedItem.ToString() + "',HAdres='" + txtHAdres.Text + "' where HNum=" + key + ";";
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Hasta Başarıyla Güncellendi");
                    Reset();
                    Uyeler();
                    baglanti.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Hatalı Mesaj");
                }
            }
        }

        private void bnfBtnSil_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("silinecek hastayı seçiniz");
            }
            else
            {
                try
                {
                    string query = "delete from Hasta_tbl where HNum = " + key + ";";
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Hasta Başarıyla silindi");
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
