using Microsoft.VisualBasic;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace QR
{
    public partial class QrCode : Form
    {
        string baglantiCumlesi = "server = Rukiye; database = QrDb; integrated security = true;";
        private SqlConnection baglanti;
        public QrCode()
        {
            InitializeComponent();
            baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
        }

        private byte[] ConvertImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void QRCodeScanned(string scannedData)
        {
            // QR kod tarandığında bu metoda taranan QR kodun değeri geçirilir
            // Veritabanında ilgili QR kodun analizini güncellemek için burada gerekli işlemleri yapabilirsiniz

            // Örneğin, QR kodunun tarama sonucunu analiz formunda güncelleyebilirsiniz
            Analiz analizForm = System.Windows.Forms.Application.OpenForms.OfType<Analiz>().FirstOrDefault();
            if (analizForm != null)
            {
                analizForm.UpdateTaramaSonucu(scannedData);
            }
        }


        private void InsertQrCodeToDatabase(Image qrImage, string qrData, int qrCodeSize)
        {
            string kayitEkleSorgusu = "INSERT INTO QrCodes (Image, QrData, Size) VALUES (@Image, @QrData, @Size)";
            SqlCommand komut = new SqlCommand(kayitEkleSorgusu, baglanti);
            komut.Parameters.AddWithValue("@Image", ConvertImageToByteArray(qrImage));
            komut.Parameters.AddWithValue("@QrData", qrData);
            komut.Parameters.AddWithValue("@Size", qrCodeSize);
            komut.ExecuteNonQuery();
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            pictureBox1.Size = new System.Drawing.Size(350, 350);
            string qrData = textQR.Text;

            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
            var myData = QG.CreateQrCode(qrData, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(myData);
            pictureBox1.Image = code.GetGraphic(13);

            // QR kodunun resmi
            Image qrImage = pictureBox1.Image;

            // QR kodunun boyutu
            int qrCodeSize = 13;

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


            // Veritabanına QR kodu verisini, boyutunu ve diğer bilgileri kaydetmek için
            InsertQrCodeToDatabase(qrImage, qrData, qrCodeSize);
        }
        private void QrCode_Load_1(object sender, EventArgs e)
        {
            string sorgu = "SELECT QrData, Image FROM QrCodes ORDER BY ID DESC";
            SqlDataAdapter adapter = new SqlDataAdapter(sorgu, baglanti);
            DataTable QrCodes = new DataTable();
            adapter.Fill(QrCodes);

            dataGridView1.DataSource = QrCodes; // DataGridView kontrolüne verileri bağlama

            // Sütun genişliklerini ayarlama
            dataGridView1.Columns["QrData"].Width = 200; // QrData sütunu için genişlik
            dataGridView1.Columns["Image"].Width = 400;// Image sütunu için genişlik

            dataGridView1.RowTemplate.Height = 400;
        }



        private void QrCode_FormClosing(object sender, FormClosingEventArgs e)
        {
            baglanti.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void ıconButton1_Click(object sender, EventArgs e)
        { }
    }
}
