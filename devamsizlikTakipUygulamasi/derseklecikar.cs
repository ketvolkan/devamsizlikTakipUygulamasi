using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace devamsizlikTakipUygulamasi
{
    public partial class derseklecikar : Form
    {
        public derseklecikar()
        {
            InitializeComponent();
        }
        Form1 frm = new Form1();
        void cmbxagetir()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            OleDbConnection baglanti = new OleDbConnection(frm.connstring);
            baglanti.Open();
            string getir = "select * from turler";
            OleDbCommand komut = new OleDbCommand(getir, baglanti);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["tur"]);
            }
            string getir2 = "select * from dersler";
            OleDbCommand komut2 = new OleDbCommand(getir2, baglanti);
            OleDbDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox1.Items.Add(dr2["Ders"]);
            }
            baglanti.Close();
        }
        private void Derseklecikar_Load(object sender, EventArgs e)
        {
            cmbxagetir();
        }
        void dersiekle()
        {
            OleDbConnection baglanti = new OleDbConnection(frm.connstring);
            baglanti.Open();
            string duzenle = "insert into dersler(Ders,tur,akts) values(@ders,@tur,@akts) ";
            OleDbCommand komut = new OleDbCommand(duzenle, baglanti);
            komut.Parameters.AddWithValue("@ders", textBox1.Text);
            komut.Parameters.AddWithValue("@tur", comboBox2.Text);
            komut.Parameters.AddWithValue("@akts", textBox3.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            cmbxagetir();
        }
        void dersisil()
        {
            OleDbConnection baglanti = new OleDbConnection(frm.connstring);
            baglanti.Open();
            string getir = "delete * from dersler where Ders = '"+comboBox1.Text+"'";
            OleDbCommand komut = new OleDbCommand(getir, baglanti);
            komut.ExecuteNonQuery();
            cmbxagetir();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            dersiekle();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dersisil();
        }
    }
}
