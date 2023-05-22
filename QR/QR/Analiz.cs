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

namespace QR
{
    public partial class Analiz : Form
    {

        string connectionString = "server = Rukiye; database = QrDb; integrated security = true;";
        private SqlConnection baglanti;
        public Analiz()
        {
            InitializeComponent();
            baglanti = new SqlConnection(connectionString);
        }

        public void UpdateTaramaSonucu(string qrData)
        {
            // Veritabanında ilgili QR kodun tarama sonucunu güncelle
            string updateQuery = "UPDATE QrCodes SET TaramaSonucu = TaramaSonucu + 1 WHERE QrData = @QRData";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@QRData", qrData);

                connection.Open();
                command.ExecuteNonQuery();
            }

            // Analizleri yenile
            YenileAnalizler();
        }

        private void Analiz_Load(object sender, EventArgs e)
        {
            // Analizleri yükle
            YenileAnalizler();
        }

        private void YenileAnalizler()
        {
            string query = "SELECT QrCodes.ID, QrCodes.QrData, COUNT(*) AS TaramaSonucu " +
                           "FROM QrCodes " +
                           "LEFT  JOIN Taramalar ON QrCodes.ID = Taramalar.QRKodID " +
                           "GROUP BY QrCodes.ID, QrCodes.QrData";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }
    }
}
