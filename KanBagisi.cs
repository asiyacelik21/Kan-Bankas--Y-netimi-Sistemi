using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class KanBagisi: Form
    {
        public KanBagisi()
        {
            InitializeComponent();
            Uyeler();
            KanStok();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-ASIYA;Initial Catalog=db.KanBankası;Integrated Security=True;Encrypt=False");

        private void Uyeler()

        {
            baglanti.Open();
            string query = "select *from  Donor_tbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            KanBagisiDGV.DataSource = ds.Tables[0];
            baglanti.Close();

        }

        private void KanStok()

        {
            baglanti.Open();
            string query = "select *from  Kan_tbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            KStoguDGV.DataSource = ds.Tables[0];
            baglanti.Close();

        }


        private void KBagisiDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDAdSoyad.Text = KStoguDGV.SelectedRows[0].Cells[1].Value.ToString();
            txtDKanGrubu.Text = KStoguDGV.SelectedRows[0].Cells[6].Value.ToString();
            Stok(txtDKanGrubu.Text);
        }
        private void Reset()
        {
            txtDAdSoyad.Text = "";
            txtDKanGrubu.Text = "";
        }

        int eskistok;
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
                eskistok = Convert.ToInt32(dr["KStok"].ToString());
            }
            baglanti.Close();

        }

     
        private void KanBagisi_Load(object sender, EventArgs e)
        {

        }

        private void bnfBtnKanBagisi_Click(object sender, EventArgs e)
        {
            if (txtDAdSoyad.Text == "")
            {
                MessageBox.Show("Bir Donor Seçiniz");
            }
            else
            {
                try
                {
                    int stok = eskistok + 1;
                    string query = "update Kan_tbl set KStok='" + stok + " where KGrup='" + txtDKanGrubu.Text + "';";
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("bağış başarılı");
                    baglanti.Close();
                    Reset();
                    KanStok();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hatalı Mesaj");
                }
            }
        }
    }
}
