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
    public partial class Form1 : Form
    {
        public string connstring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=devamsizlikDB.accdb";
        public Form1()
        {
            InitializeComponent();
        }
        int derssayisi = 0;
        void cmbxgetir()
        {
            OleDbConnection baglanti = new OleDbConnection(connstring);
            baglanti.Open();
            string getir = "select * from haftalar";
            OleDbCommand komut = new OleDbCommand(getir, baglanti);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cbxhaftalar.Items.Add(dr["hafta"]);
            }
            string getir2 = "select * from durumlar";
            OleDbCommand komut2 = new OleDbCommand(getir2, baglanti);
            OleDbDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cbxdurum.Items.Add(dr2["durum"]);
            }
            baglanti.Close();
        }

        void getir()
        {
            OleDbConnection baglanti = new OleDbConnection(connstring);
            baglanti.Open();
            string getir = "select * from dersler";
            OleDbCommand komut = new OleDbCommand(getir, baglanti);
            OleDbDataReader dr = komut.ExecuteReader();
            int x = 0;
            while (dr.Read())
            {
                x++;
            }
            derssayisi = x;
            dr.Close();
            OleDbCommand komut2 = new OleDbCommand(getir, baglanti);
            OleDbDataReader dr2 = komut.ExecuteReader();            
            int i = 0;
            int boyutW = gbxDersler.Width - 5;
            int boyutH = gbxDersler.Height / derssayisi-17;
            while (dr2.Read())
            {
                Button ders = new Button();
                ders.Width = boyutW;
                ders.Height = boyutH;
                ders.Text = (dr2["Ders"].ToString());
                ders.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
                ders.TextAlign = ContentAlignment.MiddleCenter;
                ders.Name = "ders" + dr2["Id"].ToString();
                ders.BackgroundImageLayout = ImageLayout.Stretch;
                ders.Location = new Point(5, ((boyutH + 15) * i + 15));
                ders.Tag = dr2["Id"].ToString();
                ders.Click += Ders_Click;
                gbxDersler.Controls.Add(ders);
                i++;
            }
            baglanti.Close();
        }
        DataTable tablo = new DataTable();
        void dgvtablolariolsutur()
        {
            tablo.Columns.Add("ID", typeof(int));
            tablo.Columns.Add("Ders", typeof(string));
            tablo.Columns.Add("Hafta", typeof(string));
            tablo.Columns.Add("Durum", typeof(string));
            dataGridView1.DataSource = tablo;
        }
        void datalarigetir(string dersad)
        {
            tablo.Clear();
            OleDbConnection baglanti = new OleDbConnection(connstring);
            baglanti.Open();
            string getir = "select * from devamsizlik where ders = '"+dersad+"'";
            OleDbCommand komut = new OleDbCommand(getir, baglanti);
            OleDbDataReader dr = komut.ExecuteReader();
            for (int i = 1; i <= 15; i++)
            {
                tablo.Rows.Add(i, lbldersad.Text,"Hafta "+ i.ToString(), "İzlendi Veya Bilinmiyor");
            }
            while (dr.Read())
            {
                string h = dr["hafta"].ToString();
                int hafta = Convert.ToInt32(h.Substring(6,h.Length-6));
                dataGridView1.Rows[hafta-1].Cells[3].Value =dr["Durum"];


            }
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        void durumekleme()
        {
            if (cbxdurum.Text != "" && cbxhaftalar.Text != "" )
            {
                OleDbConnection baglanti2 = new OleDbConnection(connstring);
                baglanti2.Open();
                string getir2 = "select Count(*) as sayi from devamsizlik where hafta = '" + cbxhaftalar.Text + "' AND ders = '" + lbldersad.Text + "'";
                OleDbCommand komut2 = new OleDbCommand(getir2, baglanti2);
                
                OleDbDataReader datareader = komut2.ExecuteReader();
                int i = 0;
                while (datareader.Read())
                {
                    i = Convert.ToInt32(datareader["sayi"]);
                }
                if (i < 1)
                {
                    OleDbConnection baglanti = new OleDbConnection(connstring);
                    baglanti.Open();
                    string ekle = "insert into devamsizlik(ders,hafta,durum) values(@ders,@hafta,@durum) ";
                    OleDbCommand komut = new OleDbCommand(ekle, baglanti);
                    komut.Parameters.AddWithValue("@ders", lbldersad.Text);
                    komut.Parameters.AddWithValue("@hafta", cbxhaftalar.Text);
                    komut.Parameters.AddWithValue("@durum", cbxdurum.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }
                else if (i == 1)
                {
                    OleDbConnection baglanti = new OleDbConnection(connstring);
                    baglanti.Open();
                    string duzenle = "update devamsizlik set durum = @durum where hafta = @hafta AND ders = @ders"; ;
                    OleDbCommand komut = new OleDbCommand(duzenle, baglanti);
                    komut.Parameters.AddWithValue("@durum", cbxdurum.Text);
                    komut.Parameters.AddWithValue("@hafta", cbxhaftalar.Text);
                    komut.Parameters.AddWithValue("@ders", lbldersad.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }     
                baglanti2.Close();
                datalarigetir(lbldersad.Text);
            }
            else
            {
                MessageBox.Show("Lütfen Hafta ve Durum Seçiniz!");
            }
            
        }
        void labellaridoldur(string dersad)
        {
            OleDbConnection baglanti2 = new OleDbConnection(connstring);
            baglanti2.Open();
            string getir2 = "select durum,COUNT(durum) AS Sayi from devamsizlik where ders = '"+lbldersad.Text+"' GROUP BY durum;";
            OleDbCommand komut2 = new OleDbCommand(getir2, baglanti2);
            OleDbDataReader dr = komut2.ExecuteReader();
            int i = 0;
            while(dr.Read())
            {
                if (i==0)
                {
                    
                    lblcanli.Text = "Canlı İzlenen : " + dr["Sayi"].ToString();
                }
                else if (i==1)
                {
                    lblizlenmeyen.Text = "İzlenmeye : " + dr["Sayi"].ToString();
                }
                else
                {
                    lbltekrar.Text = "Tekrarı İzlenen : " + dr["Sayi"].ToString();
                }
                i++;             
            }
        }
        private void Ders_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lbldersad.Text = btn.Text;
            datalarigetir(lbldersad.Text);
            labellaridoldur(lbldersad.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getir();
            dgvtablolariolsutur();
            cmbxgetir();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            durumekleme();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            derseklecikar frm = new derseklecikar();
            frm.ShowDialog();
        }
    }
}
