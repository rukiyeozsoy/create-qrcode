using FastReport.DataVisualization.Charting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR
{
    public partial class ShortLink : Form
    {
        private Dictionary<string, string> shortenedUrls; // Kısaltılan URL'leri tutmak için bir sözlük

        string baglantiCumlesi = "server = Rukiye; database = QrDb; integrated security = true;";
        private SqlConnection baglanti;
        public ShortLink()
        {
            InitializeComponent();
            Linkiniz.LinkClicked += linkLabel1_LinkClicked;

            shortenedUrls = new Dictionary<string, string>(); // Sözlük oluşturuluyor

            baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
        }

        private void InsertLinkTableToDatabase(string title, string longLink, string shortLink)
        {
            using (SqlConnection connection = new SqlConnection(baglantiCumlesi))
            {
                connection.Open();
                string kayitEkleSorgusu = "INSERT INTO LinkTable (Title, longLink, shortLink) VALUES (@Title, @longLink, @shortLink)";
                SqlCommand komut = new SqlCommand(kayitEkleSorgusu, connection);

                komut.Parameters.AddWithValue("@Title", title);
                komut.Parameters.AddWithValue("@longLink", longLink);
                komut.Parameters.AddWithValue("@shortLink", shortLink);
                komut.ExecuteNonQuery();
            }
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            string longUrl = textLink.Text;


            string shortUrl = ShortenUrl(longUrl);

            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = shortUrl;
            Linkiniz.Links.Clear();
            Linkiniz.Links.Add(link);
            Linkiniz.Text = shortUrl;

            shortenedUrls.Clear();

            shortenedUrls.Add(shortUrl, longUrl);

            InsertLinkTableToDatabase("Link Title", longUrl, shortUrl); 

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = (string)e.Link.LinkData;


            // Doğru URL'yi belirleyin
            if (shortenedUrls.ContainsKey(url))
            {
                string targetUrl = shortenedUrls[url];

                // Opera tarayıcısını açmak için Process.Start kullanın
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "C:\\Users\\ASUS\\AppData\\Local\\Programs\\Opera\\opera.exe";
                psi.Arguments = targetUrl;
                Process.Start(psi);
            }
        }

        private string ShortenUrl(string longUrl)
        {
            // Kısaltma mantığınızı burada uygulayın

            // Örnek olarak, kısaltılan URL'yi bir özel karakter dizisi ve rastgele sayılarla oluşturma
            string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            int length = 8;
            Random random = new Random();
            StringBuilder shortUrlBuilder = new StringBuilder();


            string shortUrl;

            do
            {
                shortUrlBuilder.Clear();

                for (int i = 0; i < length; i++)
                {
                    shortUrlBuilder.Append(characters[random.Next(characters.Length)]);
                }

                shortUrl = shortUrlBuilder.ToString();
            }
            while (shortenedUrls.ContainsKey(shortUrl));

            // Kısaltılan URL'yi veritabanına kaydetmek yerine sözlüğe ekleyin
            shortenedUrls.Add(shortUrl, longUrl);

            return shortUrl;
        }

        private void ShortLink_Load(object sender, EventArgs e)
        {
            string sorgu = "SELECT Title, longLink, shortLink FROM LinkTable ORDER BY ID DESC";
            SqlDataAdapter adapter = new SqlDataAdapter(sorgu, baglanti);
            DataTable LinkTable = new DataTable();
            adapter.Fill(LinkTable);

            dataGridView1.DataSource = LinkTable; // DataGridView kontrolüne verileri bağlama

            // Sütun genişliklerini ayarlama
            dataGridView1.Columns["Title"].Width = 200;
            dataGridView1.Columns["longLink"].Width = 200;
            dataGridView1.Columns["shortLink"].Width = 200;

            dataGridView1.RowTemplate.Height = 200;

            shortenedUrls.Clear();
            foreach (DataRow row in LinkTable.Rows)
            {
                string shortLink = row["shortLink"].ToString();
                string longLink = row["longLink"].ToString();

                shortenedUrls.Add(shortLink, longLink);
            }
            dataGridView1.AllowUserToAddRows = false;
            baglanti.Close();
        }
    }
}
