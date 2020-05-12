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

namespace OdevErenKorokmaz
{
    public partial class Form1 : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=hasta_bilgisi.accdb");

        //Ödev Eren Korkmaz B1810.032074//Ödev Eren Korkmaz B1810.032074


        public Form1()
        {
            InitializeComponent();
        }
        void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            richTextBox1.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        { }

        public void il_listele()
        {
            string iller = "Adana , Adıyaman , Afyonkarahisar , Ağrı , Aksaray , Amasya , Ankara , Antalya , Ardahan , Artvin, Aydın, Balıkesir, Bartın, Batman, Bayburt, Bilecik, Bingöl, Bitlis, Bolu, Burdur, Bursa, Çanakkale, Çankırı, Çorum, Denizli, Diyarbakır, Düzce, Edirne, Elazığ, Erzincan, Erzurum, Eskişehir, Gaziantep, Giresun, Gümüşhane, Hakkâri, Hatay, Iğdır, Isparta, İstanbul, İzmir, Kahramanmaraş, Karabük, Karaman, Kars, Kastamonu, Kayseri, Kilis, Kırıkkale, Kırklareli, Kırşehir, Kocaeli, Konya, Kütahya, Malatya, Manisa, Mardin, Mersin, Muğla, Muş, Nevşehir, Niğde, Ordu, Osmaniye, Rize, Sakarya, Samsun, Şanlıurfa, Siirt, Sinop, Sivas, Şırnak, Tekirdağ, Tokat, Trabzon, Tunceli, Uşak, Van, Yalova, Yozgat, Zonguldak";
            string[] il = iller.Split(',');
            foreach (var item in il)
            {
                comboBox2.Items.Add(item.Trim());
            }
        }

        public void kan_listele()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("A rh +"); comboBox1.Items.Add("A rh -");
            comboBox1.Items.Add("B rh +"); comboBox1.Items.Add("B rh -");
            comboBox1.Items.Add("0 rh +"); comboBox1.Items.Add("0 rh -");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand kisi_oku = new OleDbCommand();
            kisi_oku.Connection = baglanti;
            OleDbDataAdapter da;
            DataTable dt;
            string sql = "select * from tbl_hasta where isim like 'A%'";

            da = new OleDbDataAdapter(sql, baglanti);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            kan_listele();
            il_listele();
        }

        public void yenile()
        {
            if (tabControl1.SelectedIndex.Equals(0))
            {
                string sql = "select * from tbl_hasta where isim like 'A%'";
                baglanti.Open();
                OleDbCommand kisi_oku = new OleDbCommand();
                kisi_oku.Connection = baglanti;
                OleDbDataAdapter da;
                DataTable dt;
                da = new OleDbDataAdapter(sql, baglanti);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            if (tabControl1.SelectedIndex.Equals(1))
            {
                string sql = "select * from tbl_hasta where isim like 'b%' or isim like 'c%' or isim like 'd%'";
                baglanti.Open();
                OleDbCommand kisi_oku = new OleDbCommand();
                kisi_oku.Connection = baglanti;
                OleDbDataAdapter da;
                DataTable dt;
                da = new OleDbDataAdapter(sql, baglanti);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            if (tabControl1.SelectedIndex.Equals(2))
            {
                string sql = "select * from tbl_hasta where isim like 'E%'";
                baglanti.Open();
                OleDbCommand kisi_oku = new OleDbCommand();
                kisi_oku.Connection = baglanti;
                OleDbDataAdapter da;
                DataTable dt;
                da = new OleDbDataAdapter(sql, baglanti);
                dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            if (tabControl1.SelectedIndex.Equals(3))
            {
                string sql = "select * from tbl_hasta where isim like 'f%' or isim like 'g%' or isim like 'h%'";
                baglanti.Open();
                OleDbCommand kisi_oku = new OleDbCommand();
                kisi_oku.Connection = baglanti;
                OleDbDataAdapter da;
                DataTable dt;
                da = new OleDbDataAdapter(sql, baglanti);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            if (tabControl1.SelectedIndex.Equals(4))
            {
                string sql = "select * from tbl_hasta where isim like 'ı%' or isim like 'i%' or isim like 'İ%'";
                baglanti.Open();
                OleDbCommand kisi_oku = new OleDbCommand();
                kisi_oku.Connection = baglanti;
                OleDbDataAdapter da;
                DataTable dt;
                da = new OleDbDataAdapter(sql, baglanti);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            if (tabControl1.SelectedIndex.Equals(5))
            {
                string sql = "select * from tbl_hasta where isim like 'j%' or isim like 'k%' or isim like 'l%' or isim like 'm%' or isim like 'n%'";
                baglanti.Open();
                OleDbCommand kisi_oku = new OleDbCommand();
                kisi_oku.Connection = baglanti;
                OleDbDataAdapter da;
                DataTable dt;
                da = new OleDbDataAdapter(sql, baglanti);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            if (tabControl1.SelectedIndex.Equals(6))
            {
                string sql = "select * from tbl_hasta where isim like 'o%' or isim like 'ö%' or isim like 'Ö%' ";
                baglanti.Open();
                OleDbCommand kisi_oku = new OleDbCommand();
                kisi_oku.Connection = baglanti;
                OleDbDataAdapter da;
                DataTable dt;
                da = new OleDbDataAdapter(sql, baglanti);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            if (tabControl1.SelectedIndex.Equals(7))
            {
                string sql = "select * from tbl_hasta where isim like 'p%' or isim like 'r%' or isim like 't%' or isim like 's%'";
                baglanti.Open();
                OleDbCommand kisi_oku = new OleDbCommand();
                kisi_oku.Connection = baglanti;
                OleDbDataAdapter da;
                DataTable dt;
                da = new OleDbDataAdapter(sql, baglanti);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            if (tabControl1.SelectedIndex.Equals(8))
            {
                string sql = "select * from tbl_hasta where isim like 'u%' or isim like 'ü%'";
                baglanti.Open();
                OleDbCommand kisi_oku = new OleDbCommand();
                kisi_oku.Connection = baglanti;
                OleDbDataAdapter da;
                DataTable dt;
                da = new OleDbDataAdapter(sql, baglanti);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            if (tabControl1.SelectedIndex.Equals(9))
            {
                string sql = "select * from tbl_hasta where isim like 'v%' or isim like 'y%' or isim like 'z%'";
                baglanti.Open();
                OleDbCommand kisi_oku = new OleDbCommand();
                kisi_oku.Connection = baglanti;
                OleDbDataAdapter da;
                DataTable dt;
                da = new OleDbDataAdapter(sql, baglanti);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            yenile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="" || textBox2.Text=="" || textBox3.Text=="" || (radioButton1.Checked==false && radioButton2.Checked==false) || richTextBox1.Text=="" || comboBox1.SelectedIndex==0 || comboBox2.Text=="")
            {
                MessageBox.Show("heryeri doldur");
            }
            else { 
            char cinsiyet;
            if (radioButton1.Checked)
            {
                cinsiyet = 'E';
            }
            else
            {
                cinsiyet = 'K';
            }
            string sql="insert into tbl_hasta (isim,d_tarihi,d_yeri,kan_grubu,cinsiyet,adres,tel) values ('"+textBox1.Text.ToString()+ "','" + textBox2.Text.ToString() + "','" +comboBox2.SelectedItem.ToString()+ "','" +comboBox1.SelectedItem.ToString()+ "','" +cinsiyet + "','"+richTextBox1.Text.ToString()+"','"+textBox3.Text.ToString()+"')";
            baglanti.Open();
            OleDbCommand kisi_ekle = new OleDbCommand(sql);
            kisi_ekle.Connection = baglanti;
            kisi_ekle.ExecuteNonQuery();
            baglanti.Close();
                MessageBox.Show("Kayıt Tamam");
            yenile();
            }

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "delete from tbl_Randevu where randevu_hasta_id=" + dataGridView1.CurrentRow.Cells[0].Value.ToString();
            
            baglanti.Open();
            OleDbCommand kisi_sil = new OleDbCommand(sql);
            kisi_sil.Connection = baglanti;
            kisi_sil.ExecuteNonQuery();

            sql = "delete from tbl_hasta where hasta_id=" + dataGridView1.CurrentRow.Cells[0].Value.ToString();
            OleDbCommand randevu_sil = new OleDbCommand(sql);
            randevu_sil.Connection = baglanti;
            randevu_sil.ExecuteNonQuery();
            baglanti.Close();
            yenile();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            il_listele();
            comboBox2.Items.Add(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            comboBox2.SelectedIndex = (comboBox2.Items.Count)-1;
            kan_listele();
            comboBox1.Items.Add(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            comboBox1.SelectedIndex = (comboBox1.Items.Count) - 1;
            richTextBox1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[5].Value.ToString()=="E")
            {
                radioButton1.Checked = true;
            }
            else { radioButton2.Checked = true; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            char cinsiyet;
            if (radioButton1.Checked)
            {
                cinsiyet = 'E';
            }
            else
            {
                cinsiyet = 'K';
            }
            string sql = "update tbl_hasta set isim='" + textBox1.Text.ToString() + "',d_tarihi='" + textBox2.Text.ToString() + "',d_yeri='" + comboBox2.SelectedItem.ToString() + "',kan_grubu='" + comboBox1.SelectedItem.ToString() + "',cinsiyet='" + cinsiyet + "',adres='" + richTextBox1.Text.ToString() + "',tel='" + textBox3.Text.ToString() + "' where hasta_id="+dataGridView1.CurrentRow.Cells[0].Value.ToString();
            baglanti.Open();
            OleDbCommand kisi_ekle = new OleDbCommand(sql);
            kisi_ekle.Connection = baglanti;
            kisi_ekle.ExecuteNonQuery();
            baglanti.Close();
            temizle();
            yenile();
            kan_listele();
            il_listele();
        }
        public static class ControlID
        {
            public static string TextData { get; set; }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            ControlID.TextData = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            this.Hide();
            try
            {
                Application.OpenForms["Form2"].Show();
            }
            catch (Exception)
            {

                Form2 f2 = new Form2();
                f2.Show();
            }
            
           
            
        }

        public static class form
        {
            public static Form1 f1 =new Form1() ;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
