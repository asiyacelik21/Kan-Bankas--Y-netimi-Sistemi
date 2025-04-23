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
    public partial class KanTransferi : Form
    {
        public KanTransferi()
        {
            InitializeComponent();
            fillHastaCb();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-ASIYA;Initial Catalog=db.KanBankası;Integrated Security=True;Encrypt=False");
        private void fillHastaCb()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select HNum from Hasta_tbl", baglanti);
            SqlDataReader rdr;
            rdr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("HNum", typeof(int));
            dt.Load(rdr);
            hastaIDcb.ValueMember = "HNum";
            hastaIDcb.DataSource = dt;
            baglanti.Close();
        }



        private void VeriAl()
        {
            baglanti.Open();
            string query = "select * from Hasta_tbl where HNum=" + hastaIDcb.SelectedValue.ToString() + "";
            SqlCommand komut = new SqlCommand(query, baglanti);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(komut);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtHAdSoyad.Text = dr["HAdSoyad"].ToString();
                txtKGrup.Text = dr["HKGrub"].ToString();
            }
            baglanti.Close();

        }

        int stok = 0;
        private void Stok(string KGrup)
        {
            baglanti.Open();
            string query = "select*from Kan_tbl where KGrup='" + KGrup + "'";
            SqlCommand komut = new SqlCommand(query, baglanti);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(komut);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                stok = Convert.ToInt32(dr["KStok"].ToString());
            }
            baglanti.Close();

        }

        private void hastaIDcb_SizeChanged(object sender, EventArgs e)
        {
            VeriAl();
            Stok(txtKGrup.Text);
            if (stok > 0)
            {
                btnTransfer.Visible = true;
                uygunlbl.Text = "stok uygun";
                uygunlbl.Visible = true;
            }
            else
            {
                uygunlbl.Text = "stok uygun değil";
                uygunlbl.Visible = true;
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Hasta ha = new Hasta();
            ha.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Hasta ha = new Hasta();
            ha.Show();
            this.Hide();
        }

        private void Reset()
        {
            txtHAdSoyad.Text = "";
            txtKGrup.Text = "";
            uygunlbl.Visible = false;
            btnTransfer.Visible = false;
        }

        private void KanGuncelle()
        {
            int YeniStok = stok - 1;
            try
            {
                string query = "update Kan_tbl set KStok=" + YeniStok + " where KGrup='" + txtKGrup.Text + "';";
                SqlCommand komut = new SqlCommand(query, baglanti);
                baglanti.Open();
                komut.ExecuteNonQuery();
               // MessageBox.Show("Hasta Başarıyla Güncellendi");
                baglanti.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Hatalı Mesaj");
            }
        }

      
        private void label7_Click(object sender, EventArgs e)
        {
            KanStogu ks = new KanStogu();
            ks.Show();
            this.Hide();
        }

        private void bnfBtnTransfer_Click(object sender, EventArgs e)
        {

            if (txtHAdSoyad.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    string query = "insert into Transfer_tbl values ('" + txtHAdSoyad.Text + "','" + txtKGrup.Text + "')";
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Transfer Başarılı");
                    baglanti.Close();
                    Reset();
                    Stok(txtKGrup.Text);
                    KanGuncelle();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Hatalı Mesaj");
                }


            }
        }
    }
}
