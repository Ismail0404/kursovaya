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
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace kursovaya
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection=null;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Database1"].ConnectionString);

            sqlConnection.Open();

            if (sqlConnection.State == ConnectionState.Open)
            {
                MessageBox.Show("Ok");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(
                $"INSERT INTO [Table241] (Nachalo_soobsheniya, Kod_soobsheniya, Kod_stancii_peredachi_soobsheniya, Poryadkoviy_nomer_soobsheniya, Data_vremya, Kod_operatcii, Poryadkoviy_nomer_stroki, Nomer_vagona, Otmetka_o_rolikovih_podshibnikah, Ves_v_centnerax, Kod_stancii_naznacheniya_vagona, Kod_gruza, Kod_gruzopoluchatelya, Kod_gruzootpravitelya, Konec_soobsheniya) VALUES (@Nachalo_soobsheniya, @Kod_soobsheniya, @Kod_stancii_peredachi_soobsheniya, @Poryadkoviy_nomer_soobsheniya, @Data_vremya, @Kod_operatcii, @Poryadkoviy_nomer_stroki, @Nomer_vagona, @Otmetka_o_rolikovih_podshibnikah, @Ves_v_centnerax, @Kod_stancii_naznacheniya_vagona, @Kod_gruza, @Kod_gruzopoluchatelya, @Kod_gruzootpravitelya, @Konec_soobsheniya)",
                sqlConnection);


            command.Parameters.AddWithValue("Nachalo_soobsheniya", textBox1.Text);
            command.Parameters.AddWithValue("Kod_soobsheniya", textBox2.Text);
            command.Parameters.AddWithValue("Kod_stancii_peredachi_soobsheniya", textBox3.Text);
            command.Parameters.AddWithValue("Poryadkoviy_nomer_soobsheniya", textBox4.Text);

            DateTime date = DateTime.Parse(textBox5.Text);
            command.Parameters.AddWithValue("Data_vremya", $"{date.Month}.{date.Day}.{date.Year} {date.Hour}:{date.Minute}");

            command.Parameters.AddWithValue("Kod_operatcii", textBox6.Text);
            command.Parameters.AddWithValue("Poryadkoviy_nomer_stroki", textBox7.Text);
            command.Parameters.AddWithValue("Nomer_vagona", textBox8.Text);
            command.Parameters.AddWithValue("Otmetka_o_rolikovih_podshibnikah", textBox9.Text);
            command.Parameters.AddWithValue("Ves_v_centnerax", textBox10.Text);
            command.Parameters.AddWithValue("Kod_stancii_naznacheniya_vagona", textBox11.Text);
            command.Parameters.AddWithValue("Kod_gruza", textBox12.Text);
            command.Parameters.AddWithValue("Kod_gruzopoluchatelya", textBox13.Text);
            command.Parameters.AddWithValue("Kod_gruzootpravitelya", textBox14.Text);
            command.Parameters.AddWithValue("Konec_soobsheniya", textBox15.Text);


            MessageBox.Show(command.ExecuteNonQuery().ToString());
            MessageBox.Show("Данные сохранены");
        }

    }
    }

