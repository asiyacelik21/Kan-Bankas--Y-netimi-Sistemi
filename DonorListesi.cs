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
    public partial class DonorListesi: Form
    {
        public DonorListesi()
        {
            InitializeComponent();
            Uyeler();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-ASIYA;Initial Catalog=db.KanBankası;Integrated Security=True;Encrypt=False");

        private void Uyeler()

        {
            baglanti.Open();
            string query = "select *from Donor_tbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DonorDGV.DataSource = ds.Tables[0];
            baglanti.Close();

        }
        private void DonorListesi_Load(object sender, EventArgs e)
        {

        }

        private void DonorDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
