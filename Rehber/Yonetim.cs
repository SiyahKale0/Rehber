using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Rehber
{

    public partial class Yonetim : Form
    {
        private SQLiteConnection sqliteConnection;
        public Yonetim()
        {
            InitializeComponent();
            sqliteConnection = new SQLiteConnection("Data Source=veritabani.db;Version=3;");
            CreateTable();
            VerileriGetir();
        }

        private void CreateTable()
        {
            using (SQLiteCommand cmd = new SQLiteCommand())
            {
                cmd.Connection = sqliteConnection;
                cmd.CommandText = "CREATE TABLE IF NOT EXISTS Kullanicilar (Id INTEGER PRIMARY KEY AUTOINCREMENT, Adi TEXT, Soyadi TEXT, TelNo TEXT)";

                sqliteConnection.Open();
                cmd.ExecuteNonQuery();
                sqliteConnection.Close();
            }
        }

        private void Ekle(string ad, string soyad, string tel)
        {
            using (SQLiteCommand cmd = new SQLiteCommand())
            {
                cmd.Connection = sqliteConnection;
                cmd.CommandText = "INSERT INTO Kullanicilar (Adi, Soyadi, TelNo) VALUES (@adi, @soyadi, @tel)";
                cmd.Parameters.AddWithValue("@adi", ad);
                cmd.Parameters.AddWithValue("@soyadi", soyad);
                cmd.Parameters.AddWithValue("@tel", tel);

                sqliteConnection.Open();
                cmd.ExecuteNonQuery();
                sqliteConnection.Close();
            }
        }

        private void Sil(int id)
        {
            using (SQLiteCommand cmd = new SQLiteCommand())
            {
                cmd.Connection = sqliteConnection;
                cmd.CommandText = "DELETE FROM Kullanicilar WHERE Id = @id";
                cmd.Parameters.AddWithValue("@id", id);

                sqliteConnection.Open();
                cmd.ExecuteNonQuery();
                sqliteConnection.Close();
            }
        }

        private void Guncelle(int id, string ad, string soyadi, string tel)
        {
            using (SQLiteCommand cmd = new SQLiteCommand())
            {
                cmd.Connection = sqliteConnection;
                cmd.CommandText = "UPDATE Kullanicilar SET Adi = @adi, Soyadi = @soyadi, TelNo = @tel WHERE Id = @id";
                cmd.Parameters.AddWithValue("@adi", ad);
                cmd.Parameters.AddWithValue("@soyadi", soyadi);
                cmd.Parameters.AddWithValue("@tel", tel);
                cmd.Parameters.AddWithValue("@id", id);

                sqliteConnection.Open();
                cmd.ExecuteNonQuery();
                sqliteConnection.Close();
            }
        }

        private void Temizle()
        {
            adTB.Text = "";
            soyadTB.Text = "";
            telTB.Text = "";
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            Ekle(adTB.Text, soyadTB.Text, telTB.Text);
            VerileriGetir();
            Temizle();
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int secilenId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                Sil(secilenId);
                VerileriGetir();
                Temizle();
            }
            else
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin.");
            }
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int secilenId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                Guncelle(secilenId, adTB.Text, soyadTB.Text, telTB.Text);
                VerileriGetir();
                Temizle();
            }
            else
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin.");
            }
        }

        private void VerileriGetir()
        {
            using (SQLiteDataAdapter sda = new SQLiteDataAdapter("SELECT * FROM Kullanicilar", sqliteConnection))
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    if (col.Name == "Adi")
                    {
                        adTB.Text = row.Cells[col.Index].Value.ToString();
                    }
                    else if (col.Name == "Soyadi")
                    {
                        soyadTB.Text = row.Cells[col.Index].Value.ToString();
                    }
                    else if (col.Name == "TelNo")
                    {
                        telTB.Text = row.Cells[col.Index].Value.ToString();
                    }
                }
            }
        }

      
        private void VeriAyikla()
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                DataView dv = ((DataTable)dataGridView1.DataSource).DefaultView;
                string ayiklanan = "";

                if (!string.IsNullOrEmpty(adTB.Text))
                {
                    ayiklanan += string.Format("Adi LIKE '{0}%'", adTB.Text);
                }

                if (!string.IsNullOrEmpty(soyadTB.Text))
                {
                    if (!string.IsNullOrEmpty(ayiklanan))
                    {
                        ayiklanan += " AND ";
                    }
                    ayiklanan += string.Format("Soyadi LIKE '{0}%'", soyadTB.Text);
                }

                if (!string.IsNullOrEmpty(telTB.Text))
                {
                    if (!string.IsNullOrEmpty(ayiklanan))
                    {
                        ayiklanan += " AND ";
                    }
                    ayiklanan += string.Format("TelNo LIKE '{0}%'", telTB.Text);
                }

                dv.RowFilter = ayiklanan;
            }
        }

        private void adTB_TextChanged(object sender, EventArgs e)
        {
            VeriAyikla();
        }

        private void soyadTB_TextChanged(object sender, EventArgs e)
        {
            VeriAyikla();
        }

        private void telTB_TextChanged(object sender, EventArgs e)
        {
            VeriAyikla();
        }
    }
}
