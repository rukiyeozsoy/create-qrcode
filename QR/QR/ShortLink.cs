using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public ShortLink()
        {
            InitializeComponent();
            Linkiniz.LinkClicked += linkLabel1_LinkClicked;

            shortenedUrls = new Dictionary<string, string>(); // Sözlük oluşturuluyor
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            string longUrl = textLink.Text;

            // Burada kendi URL kısaltma mantığınızı uygulayabilirsiniz
            string shortUrl = ShortenUrl(longUrl);

            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = shortUrl;
            Linkiniz.Links.Clear();
            Linkiniz.Links.Add(link);
            Linkiniz.Text = shortUrl;

            shortenedUrls.Clear();

            shortenedUrls.Add(shortUrl, longUrl);
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
    }
}
