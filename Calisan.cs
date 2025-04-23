using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace WindowsFormsApp1
{
    public partial class Calisan : Form
    {
        public Calisan()
        {
            InitializeComponent();
            Uyeler();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-ASIYA;Initial Catalog=db.KanBankası;Integrated Security=True;Encrypt=False");

        private void label9_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void Reset()
        {
            txtCalAdSoyad.Text = "";
            txtCalSifre.Text = "";
            key = 0;
        }


        private void Uyeler()

        {
            baglanti.Open();
            string query = "select *from Calisan_tbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CalisanDGV.DataSource = ds.Tables[0];
            baglanti.Close();

        }

        int key = 0;
        private void CalisanDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           txtCalAdSoyad.Text = CalisanDGV.SelectedRows[0].Cells[1].Value.ToString();
           txtCalSifre.Text = CalisanDGV.SelectedRows[0].Cells[2].Value.ToString();
            if (txtCalAdSoyad.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(CalisanDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }



        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (txtCalAdSoyad.Text == "" || txtCalSifre.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    string query = "insert into Calisan_tbl values ('" + txtCalAdSoyad.Text + "','" + txtCalSifre.Text + "')";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Çalışan Başarıyla Kaydedildi");
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

        private void bnfBtnDuzenle_Click(object sender, EventArgs e)
        {
            if (txtCalAdSoyad.Text == "" || txtCalSifre.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    string query = "update Calisan_tbl set CalID='" + txtCalAdSoyad.Text + "',CalSifre='" + txtCalSifre.Text + "' where CalNum=" + key + ";";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Çalışan Başarıyla Güncellendi");
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
                MessageBox.Show("silinecek çalışanı seçiniz");
            }
            else
            {
                try
                {
                    string query = "delete from Calisan_tbl where CalNum = " + key + ";";
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Çalışan Başarıyla silindi");
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
    

