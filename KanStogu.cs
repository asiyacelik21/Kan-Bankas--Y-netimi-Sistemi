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
    public partial class KanStogu: Form
    {
        public KanStogu()
        {
            InitializeComponent();
            KanStok();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-ASIYA;Initial Catalog=db.KanBankası;Integrated Security=True;Encrypt=False");
       

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

        private void KanStogu_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            KanTransferi kant = new KanTransferi();
            kant.Show();
            this.Hide();
        }
    }
}
