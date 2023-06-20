using Microsoft.VisualBasic;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Kamar2 : Form
    {

        public Kamar2()
        {
            InitializeComponent();
            InitializeComponent();
            InitializeComponent();
            

            //NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password=afif2701");
            //conn.Open();
            //NpgsqlCommand cmd = new NpgsqlCommand(conn);
            //cmd.CommandType = CommandType.Text
            //cmd.CommandType = "UPDATE detail_kamar set status_kamar = @statusKamar where nomor_kamar = {comboBox1.Text}";
            //    cmd.Parameters.AddWithValue(("@statuskamar"),comboBox2.Text);
            //    cmd.Parameters.AddWithValue(("@nomorkamar"), comboBox2.Text);
            //    cmd.ExecuteNonQuery();
            //    cmd.Dispose();
            //    conn.Close();


        }

        private NpgsqlConnection conn;
        private NpgsqlCommand cmd;
        private String conString = String.Format("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password=afif2701");
        private string sql;

        private void Kamar2_Resize(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboBox1.Text);

            NpgsqlConnection conn = new NpgsqlConnection(conString);
            {
                conn.Open();
                string sql = $"update detail_kamar set status_kamar = {comboBox2.Text} where id_detail_kamar = {comboBox1.Text}";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue(new NpgsqlParameter("@nomor_kamar", comboBox1.Text));
                cmd.Parameters.AddWithValue(new NpgsqlParameter("@status_kamar", comboBox2.Text));
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("sukses");
            }

        }
    }
}
