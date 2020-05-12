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
using System.Collections;

namespace OdevErenKorokmaz
{
    public partial class Form2 : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=hasta_bilgisi.accdb");
        DataTable veri_tablosu = new DataTable();

        //Ödev Eren Korkmaz B1810.032074//Ödev Eren Korkmaz B1810.032074

        public Form2()
        {
            InitializeComponent();
        }
        public  void yenile() {
            string id = Form1.ControlID.TextData;
            baglanti.Open();
            OleDbCommand kisi_oku = new OleDbCommand();
            kisi_oku.Connection = baglanti;
            string sql = "select isim from tbl_hasta where hasta_id=" + id;
            kisi_oku.CommandText = sql;
            textBox3.Text = Convert.ToString(kisi_oku.ExecuteScalar());
            OleDbDataAdapter da;
            DataTable dt;
            sql = "SELECT tbl_Randevu.randevu_id as [Randevu No], tbl_Hasta.isim as [Hasta İsim Soyisim], tbl_Randevu.randevu_tarihi as [Randevu Tarihi], tbl_Randevu.teşhis as Teşhis, tbl_Randevu.tedavi as Tedavi, tbl_İlaç.ilaç_adı as [Verilen ilaç] FROM tbl_İlaç INNER JOIN(tbl_Hasta INNER JOIN tbl_Randevu ON tbl_Hasta.hasta_id = tbl_Randevu.randevu_hasta_id) ON tbl_İlaç.ilaç_id = tbl_Randevu.verilen_ilaç_id where tbl_Randevu.randevu_hasta_id=" + id;
            da = new OleDbDataAdapter(sql, baglanti);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        public void ilac_listele()
        {
            baglanti.Open();
            OleDbCommand ilac_oku = new OleDbCommand();
            ilac_oku.Connection = baglanti;
            ilac_oku.CommandText = "select * from tbl_İlaç";
            OleDbDataReader okuyucu = ilac_oku.ExecuteReader();
            comboBox1.Items.Clear();
            while (okuyucu.Read())
            {
                comboBox1.Items.Add(okuyucu["ilaç_adı"].ToString());
                
            }
            baglanti.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            string id = Form1.ControlID.TextData;

            yenile();

            ilac_listele();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox5.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            ilac_listele();
            comboBox1.Items.Add(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            comboBox1.SelectedIndex = comboBox1.Items.Count-1;
            
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

            try
            {
                Application.OpenForms["Form1"].Show();
            }
            catch (Exception)
            {

                Environment.Exit(1);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Form1"].Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            Environment.Exit(1);
            
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Beige;
        }

        public void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();

            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            dateTimePicker1.ResetText();
            comboBox1.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbCommand ilacid = new OleDbCommand();
            ilacid.Connection = baglanti;
            ilacid.CommandText = "select ilaç_id from tbl_ilaç where ilaç_adı='"+comboBox1.SelectedItem.ToString()+"'";
            baglanti.Open();
            string ilac_id;
            ilac_id = ilacid.ExecuteScalar().ToString();
            baglanti.Close();

            string sql = "insert into tbl_Randevu (randevu_hasta_id,teşhis,tedavi,randevu_tarihi,verilen_ilaç_id) values ('" +Form1.ControlID.TextData+ "','" + textBox5.Text.ToString() + "','" +textBox6.Text.ToString() + "','" + dateTimePicker1.Value.ToShortDateString().ToString() + "','"+ilac_id+"')";
            baglanti.Open();
            OleDbCommand kisi_ekle = new OleDbCommand(sql);
            kisi_ekle.Connection = baglanti;
            kisi_ekle.ExecuteNonQuery();
            baglanti.Close();

            yenile();
            temizle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbCommand ilacid = new OleDbCommand();
            ilacid.Connection = baglanti;
            ilacid.CommandText = "select ilaç_id from tbl_ilaç where ilaç_adı='" + comboBox1.SelectedItem.ToString() + "'";
            baglanti.Open();
            string ilac_id;
            ilac_id = ilacid.ExecuteScalar().ToString();
            baglanti.Close();

            string id = Form1.ControlID.TextData;
            string sql = "update tbl_Randevu set randevu_hasta_id='" + id + "',teşhis='" + textBox5.Text.ToString() + "',tedavi='" + textBox6.Text.ToString()+"',randevu_tarihi='"+dateTimePicker1.Value.ToShortDateString().ToString()+"',verilen_ilaç_id='"+ilac_id+"' where randevu_id="+dataGridView1.CurrentRow.Cells[0].Value.ToString();
            baglanti.Open();
            OleDbCommand kisi_ekle = new OleDbCommand(sql);
            kisi_ekle.Connection = baglanti;
            kisi_ekle.ExecuteNonQuery();
            baglanti.Close();
            yenile();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "delete from tbl_Randevu where randevu_id=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() ;
            baglanti.Open();
            OleDbCommand randevu_sil = new OleDbCommand(sql);
            randevu_sil.Connection = baglanti;
            randevu_sil.ExecuteNonQuery();
            baglanti.Close();
            yenile();
            temizle();
        }
    }
}
