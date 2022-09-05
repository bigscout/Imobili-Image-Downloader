using System.Drawing.Drawing2D;
using System.Drawing;
using System.Drawing.Imaging;
using System.Resources;
using System.Windows.Forms;
using System.ComponentModel;
using System.Net;
using System.Xml;
using HtmlAgilityPack;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Serialization;
using System.Runtime.InteropServices;
using System.Net.Http;

namespace Imobili_Image_Downloader
{
    public partial class ImageDownloader : Form
    {

        List<string> listurl = new List<string>();
        static string codigo = string.Empty;

        static bool anySite = false;

        static int count = 0;

        [DllImport("wininet.dll")]
        private extern static Boolean InternetGetConnectedState(out int Description, int ReservedValue);

        public ImageDownloader()
        {
            InitializeComponent();
        }

        private void trackSize_ValueChanged(object sender, EventArgs e)
        {
            this.numSize.Value = this.trackSize.Value;
            generate_preview();
        }

        private void trackTransparency_ValueChanged(object sender, EventArgs e)
        {
            this.numTransparency.Value = this.trackTransparency.Value;
            generate_preview();
        }

        private void numSize_ValueChanged(object sender, EventArgs e)
        {
            this.trackSize.Value = (int)this.numSize.Value;
            generate_preview();
            Properties.Settings.Default.size = this.numSize.Value;
            Properties.Settings.Default.Save();
        }

        private void numTransparency_ValueChanged(object sender, EventArgs e)
        {
            this.trackTransparency.Value = (int)this.numTransparency.Value;
            generate_preview();
            Properties.Settings.Default.transparency = this.numTransparency.Value;
            Properties.Settings.Default.Save();
        }

        private void chk_config_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_config.Checked)
            {
                this.Size = new Size(this.Width, 630);
                return;
            }
            this.Size = new Size(this.Width, 200);
        }

        private void ImageDownloader_Load(object sender, EventArgs e)
        {
            this.Size = new Size(this.Width, 200);
            load_settings();
            generate_preview();
        }

        private void btn_selectLogo_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    this.tbx_logo.Text = open.FileName.ToString();                    
                    generate_preview();
                    Properties.Settings.Default.logo = open.FileName.ToString();
                    Properties.Settings.Default.Save();
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }

        private void rdo_topLeft_CheckedChanged(object sender, EventArgs e)
        {
            generate_preview();
            Properties.Settings.Default.position = 1;
            Properties.Settings.Default.Save();
        }

        private void rdo_topCenter_CheckedChanged(object sender, EventArgs e)
        {
            generate_preview();
            Properties.Settings.Default.position = 2;
            Properties.Settings.Default.Save();
        }

        private void rdo_topRight_CheckedChanged(object sender, EventArgs e)
        {
            generate_preview();
            Properties.Settings.Default.position = 3;
            Properties.Settings.Default.Save();
        }

        private void rdo_middleLeft_CheckedChanged(object sender, EventArgs e)
        {
            generate_preview();
            Properties.Settings.Default.position = 4;
            Properties.Settings.Default.Save();
        }

        private void rdo_center_CheckedChanged(object sender, EventArgs e)
        {
            generate_preview();
            Properties.Settings.Default.position = 5;
            Properties.Settings.Default.Save();
        }

        private void rdo_middleRight_CheckedChanged(object sender, EventArgs e)
        {
            generate_preview();
            Properties.Settings.Default.position = 6;
            Properties.Settings.Default.Save();
        }

        private void rdo_bottomLeft_CheckedChanged(object sender, EventArgs e)
        {
            generate_preview();
            Properties.Settings.Default.position = 7;
            Properties.Settings.Default.Save();
        }

        private void rdo_bottomCenter_CheckedChanged(object sender, EventArgs e)
        {
            generate_preview();
            Properties.Settings.Default.position = 8;
            Properties.Settings.Default.Save();
        }

        private void rdo_bottomRight_CheckedChanged(object sender, EventArgs e)
        {
            generate_preview();
            Properties.Settings.Default.position = 9;
            Properties.Settings.Default.Save();
        }

        private void chk_addLogo_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_addLogo.Checked)
            {
                Properties.Settings.Default.addLogo = true;
            }
            else
            {
                Properties.Settings.Default.addLogo = false;
            }
            Properties.Settings.Default.Save();
        }

        private async void btn_download_Click(object sender, EventArgs e)
        {
            if (IsConnected())
            {
                if (!this.tbx_link.Text.Equals("") && !this.tbx_link.Text.Equals(" ") && this.tbx_link.Text != null)
                {
                    if (this.tbx_link.Text.Contains("https://") || this.tbx_link.Text.Contains("http://") && this.tbx_link.Text.Contains("imovel"))
                    {
                        this.btn_cancel.Enabled = true;

                        this.tbx_link.Enabled = false;
                        this.btn_download.Enabled = false;

                        this.tssl_status.Text = string.Empty;
                        this.tssp_progresso.Value = 0;

                        var link = this.tbx_link.Text;

                        var checkLink = await CheckLink(link);

                        anySite = false;

                        if (!checkLink)
                        {
                            DialogResult dialogResult = MessageBox.Show("O link utilizado não parece pertencer a plataforma suportada pelo programa.\n\nVocê gostaria de tentar fazer o download das imagens do link mesmo assim?", "Link Desconhecido", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (dialogResult == DialogResult.Yes)
                            {
                                anySite = true;
                            }
                            else
                            {
                                return;
                            }
                        }

                        codigo = string.Empty;
                        //codigo = await Codigo(link);

                        listurl.Clear();
                        listurl = await Anuncio(link);

                        this.bgw_download.RunWorkerAsync();
                    }
                    else
                    {
                        MessageBox.Show("O link deve ser diretamente do imóvel que você deseja as imagens.\n\nExemplo: https://www.imobiliaria.com.br/imovel/casa-na-praia/ref23434", "Link Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("O link deve ser diretamente do imóvel que você deseja as imagens.\n\nExemplo: https://www.imobiliaria.com.br/imovel/casa-na-praia/ref23434", "Link Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Você parece não estar conectado a internet. Por favor, verifique sua conexão e tente novamente.", "Falha na Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (this.bgw_download.IsBusy)
            {
                this.bgw_download.CancelAsync();
            }
            this.btn_cancel.Enabled = false;

            this.tbx_link.Enabled = true;
            this.btn_download.Enabled = true;

            this.tssl_status.Text = "Download Cancelado...";
        }

        private void chk_openFolder_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_openFolder.Checked)
            {
                Properties.Settings.Default.openFolder = true;
            }
            else
            {
                Properties.Settings.Default.openFolder = false;
            }

            Properties.Settings.Default.Save();
        }

        // Um método que verifica se esta conectado
        public static Boolean IsConnected()
        {
            int Description;
            return InternetGetConnectedState(out Description, 0);
        }

        private void load_settings()
        {
            if (Properties.Settings.Default.position > 9 || Properties.Settings.Default.position == 0)
            {
                Properties.Settings.Default.position = 5;
                Properties.Settings.Default.Save();
            }

            if (Properties.Settings.Default.position == 1)
            {
                this.rdo_topLeft.Checked = true;
            }
            if (Properties.Settings.Default.position == 2)
            {
                this.rdo_topCenter.Checked = true;
            }
            if (Properties.Settings.Default.position == 3)
            {
                this.rdo_topRight.Checked = true;
            }
            if (Properties.Settings.Default.position == 4)
            {
                this.rdo_middleLeft.Checked = true;
            }
            if (Properties.Settings.Default.position == 5)
            {
                this.rdo_center.Checked = true;
            }
            if (Properties.Settings.Default.position == 6)
            {
                this.rdo_middleRight.Checked = true;
            }
            if (Properties.Settings.Default.position == 7)
            {
                this.rdo_bottomLeft.Checked = true;
            }
            if (Properties.Settings.Default.position == 8)
            {
                this.rdo_bottomCenter.Checked = true;
            }
            if (Properties.Settings.Default.position == 9)
            {
                this.rdo_bottomRight.Checked = true;
            }

            this.numSize.Value = Properties.Settings.Default.size;
            this.numTransparency.Value = Properties.Settings.Default.transparency;

            if (Properties.Settings.Default.addLogo)
            {
                this.chk_addLogo.Checked = Properties.Settings.Default.addLogo;
            }

            if (Properties.Settings.Default.openFolder)
            {
                this.chk_openFolder.Checked = Properties.Settings.Default.openFolder;
            }

            if (!Properties.Settings.Default.logo.Equals(String.Empty))
            {
                this.tbx_logo.Text = Properties.Settings.Default.logo;
            }
        }

        private async Task<bool> CheckLink(string url)
        {
            var ok = false;
            var httpClient = new HttpClient();

            try
            {
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                var html = await httpClient.GetStringAsync(url);

                if (html.Contains("kenlo.io") || html.Contains("ingaia.com.br"))
                {
                    ok = true;
                }
            }
            catch { }
            finally { httpClient.Dispose(); }

            return ok;
        }

        private void Bgw_download_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (listurl.Count >= 1)
                {
                    if (!Directory.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, codigo)))
                    {
                        Directory.CreateDirectory(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, codigo));
                    }

                    count = 0;

                    for (var x = 0; x < listurl.Count; x++)
                    {
                        var file = listurl[x];

                        DownloadImage(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, codigo), new Uri(file), new HttpClient());

                        int progress = (int)(((x + 1) / (double)listurl.Count) * 100.0);
                        this.bgw_download.ReportProgress(progress);

                        if (this.bgw_download.CancellationPending)
                        {
                            e.Cancel = true;
                            this.bgw_download.ReportProgress(0);
                            return;
                        }
                    }
                }
            }
            catch { }
        }

        private void Bgw_download_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

                this.Invoke(new Action(() =>
                {
                    this.tssp_progresso.Value = e.ProgressPercentage;
                }));              
            
        }

        private void Bgw_download_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                this.btn_cancel.Enabled = false;

                this.tbx_link.Enabled = true;
                this.btn_download.Enabled = true;

                this.tssl_status.Text = "Download cancelado pelo usuário!";
            }
            else if (e.Error != null)
            {
                this.btn_cancel.Enabled = false;

                this.tbx_link.Enabled = true;
                this.btn_download.Enabled = true;

                this.tssl_status.Text = "Erro ao fazer download das imagens, tente novamente!";
            }
            else
            {
                this.btn_cancel.Enabled = false;

                this.tbx_link.Enabled = true;
                this.btn_download.Enabled = true;

                this.tbx_link.Clear();

                this.tssl_status.Text = "Download concluído com sucesso!";

                if (Properties.Settings.Default.openFolder && Directory.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, codigo))) {
                    System.Diagnostics.Process.Start("explorer.exe", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, codigo));
                }
            }
        }

        private static async Task<List<string>> Anuncio(string link)
        {
            List<string> imgs = new List<string>();

            try
            {
                var url = link;
                var httpClient = new HttpClient();
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                var html = await httpClient.GetStringAsync(url);

                var doc = new HtmlAgilityPack.HtmlDocument();

                doc.LoadHtml(html);

                HtmlNode code = HtmlNode.CreateNode(String.Empty);

                if (doc.DocumentNode.SelectSingleNode("//span[@class='property-reference']") != null)
                {
                    code = doc.DocumentNode.SelectSingleNode("//span[@class='property-reference']");
                }
                if (doc.DocumentNode.SelectSingleNode("//div[@class='codigo']") != null)
                {
                    code = doc.DocumentNode.SelectSingleNode("//div[@class='codigo']");
                }

                codigo = code != null ? code.InnerText : "ANY-" + DateTime.Now.Ticks.ToString();

                HtmlNodeCollection nodes = new HtmlNodeCollection(doc.DocumentNode.ParentNode);

                if (anySite == true)
                {
                    nodes = doc.DocumentNode.SelectNodes(".//img");
                    foreach (HtmlNode node in nodes)
                    {
                        if (node.Attributes["src"].Value.Contains("http://") || node.Attributes["src"].Value.Contains("https"))
                        {
                            var img = node.Attributes["src"].Value;
                            imgs.Add(img);
                        }
                    }
                }
                else
                {
                    if (doc.DocumentNode.SelectNodes(".//div[@class='container-all-images']//picture[@class='thumbnail']/img") != null)
                    {
                        nodes = doc.DocumentNode.SelectNodes(".//div[@class='container-all-images']//picture[@class='thumbnail']/img");
                        foreach (HtmlNode node in nodes)
                        {
                            var img = node.Attributes["src"].Value;
                            imgs.Add(img);
                        }
                    }

                    else if (doc.DocumentNode.SelectNodes("//div[@class='slide-image']/img") != null)
                    {
                        nodes = doc.DocumentNode.SelectNodes("//div[@class='slide-image']/img");
                        foreach (HtmlNode node in nodes)
                        {
                            var img = node.Attributes["data-src"].Value;
                            imgs.Add(img);
                        }
                    }
                    else if (doc.DocumentNode.SelectNodes("//div[@class='item']/img") != null)
                    {
                        nodes = doc.DocumentNode.SelectNodes("//div[@class='item']/img");
                        foreach (HtmlNode node in nodes)
                        {
                            var img = node.Attributes["src"].Value;
                            imgs.Add(img);
                        }
                    }
                }

            } catch { }

            return imgs;
        }

        private async void DownloadImage(string folderImagesPath, Uri url, HttpClient client)
        {
            try
            {
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                var response = await client.GetAsync(url);
                if (response != null && response.StatusCode == HttpStatusCode.OK)
                {
                    var stream = await response.Content.ReadAsStreamAsync();
                    Image image = Image.FromStream(stream);
                    if (image.Width > 50 && image.Height > 50)
                    {
                       FotologoAsync(folderImagesPath, image);
                    }
                }
            }
            catch { }
            finally
            {
                client.Dispose();
            }
        }

        private void generate_preview()
        {
            Bitmap logoPath = Properties.Resources.image_placeholder;

            if (File.Exists(this.tbx_logo.Text))
            {
                logoPath = new Bitmap(this.tbx_logo.Text);
            }

            ColorMatrix matrix = new ColorMatrix();
            ImageAttributes transparency = new ImageAttributes();
            Image image_preview = new Bitmap(this.pbox_preview.Width, this.pbox_preview.Height);

            //Modifica o tamanho da logo mantendo as proporsões de altura e largura
            var desiredWidth = this.pbox_preview.Width * (this.numSize.Value / 100);
            var desiredHeight = this.pbox_preview.Height * (this.numSize.Value / 100);

            double ratioW = (double)desiredWidth / (double)logoPath.Width;
            double ratioH = (double)desiredHeight / (double)logoPath.Height;
            double ratio = ratioW < ratioH ? ratioW : ratioH;
            int suitableWidth = (int)(logoPath.Width * ratio);
            int suitableHeight = (int)(logoPath.Height * ratio);

            Bitmap img = new Bitmap(logoPath, suitableWidth, suitableHeight);

            Graphics g = Graphics.FromImage(image_preview);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.CompositingQuality = CompositingQuality.HighQuality;

            int width = this.pbox_preview.Width;
            int height = this.pbox_preview.Height;

            matrix.Matrix33 = Convert.ToSingle(this.numTransparency.Value / 100);
            transparency.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            g.Clear(Color.Transparent);

            if (this.rdo_topLeft.Checked)
            {
                g.DrawImage(img,
                    new Rectangle(5, 5, width, height),
                    0, 0, width, height,
                    GraphicsUnit.Pixel,
                    transparency);

                //g.DrawImage(img, 5, 5);
            }

            if (this.rdo_topRight.Checked)
            {
                g.DrawImage(img,
                    new Rectangle(((width - img.Width) - 5), 5, width, height),
                    0, 0, width, height,
                    GraphicsUnit.Pixel,
                    transparency);

                //g.DrawImage(img, ((this.pbox_preview.Width - img.Width) - 5), 5);
            }

            if (this.rdo_topCenter.Checked)
            {
                g.DrawImage(img,
                new Rectangle(((width / 2) - (img.Width / 2)), 5, width, height),
                0, 0, width, height,
                GraphicsUnit.Pixel,
                transparency);

                //g.DrawImage(img, ((this.pbox_preview.Width / 2) - (img.Width / 2)), 5);
            }

            if (this.rdo_middleLeft.Checked)
            {
                g.DrawImage(img,
                new Rectangle(5, ((height / 2) - (img.Height / 2)), width, height),
                0, 0, width, height,
                GraphicsUnit.Pixel,
                transparency);

                //g.DrawImage(img, 5, ((this.pbox_preview.Height / 2) - (img.Height / 2)));
            }

            if (this.rdo_center.Checked)
            {
                g.DrawImage(img,
                new Rectangle(((width / 2) - (img.Width / 2)), ((height / 2) - (img.Height / 2)), width, height),
                0, 0, width, height,
                GraphicsUnit.Pixel,
                transparency);

                //g.DrawImage(img, ((this.pbox_preview.Width / 2) - (img.Width / 2)), ((this.pbox_preview.Height / 2) - (img.Height / 2)));
            }

            if (this.rdo_middleRight.Checked)
            {
                g.DrawImage(img,
                new Rectangle(((width - img.Width) - 5), ((height / 2) - (img.Height / 2)), width, height),
                0, 0, width, height,
                GraphicsUnit.Pixel,
                transparency);

                //g.DrawImage(img, ((this.pbox_preview.Width - img.Width) - 5), ((this.pbox_preview.Height / 2) - (img.Height / 2)));
            }

            if (this.rdo_bottomLeft.Checked)
            {
                g.DrawImage(img,
                new Rectangle(5, ((height - img.Height) - 5), width, height),
                0, 0, width, height,
                GraphicsUnit.Pixel,
                transparency);

                //g.DrawImage(img, 5, ((this.pbox_preview.Height - img.Height) - 5));
            }

            if (this.rdo_bottomCenter.Checked)
            {
                g.DrawImage(img,
                new Rectangle(((width / 2) - (img.Width / 2)), ((height - img.Height) - 5), width, height),
                0, 0, width, height,
                GraphicsUnit.Pixel,
                transparency);

                //g.DrawImage(img, ((this.pbox_preview.Width / 2) - (img.Width / 2)), ((this.pbox_preview.Height - img.Height) - 5));
            }

            if (this.rdo_bottomRight.Checked)
            {
                g.DrawImage(img,
                new Rectangle(((width - img.Width) - 5), ((height - img.Height) - 5), width, height),
                0, 0, width, height,
                GraphicsUnit.Pixel,
                transparency);

                //g.DrawImage(img, ((this.pbox_preview.Width - img.Width) - 5), ((this.pbox_preview.Height - img.Height) - 5));
            }

            g.Dispose();
            logoPath.Dispose();
            img.Dispose();
            this.pbox_preview.Image = image_preview;
        }

        private async void FotologoAsync(string path, Image image)
        {
            try
            {
                Image imgImovel = image;
                var width = imgImovel.Width;
                var height = imgImovel.Height;

                Bitmap final = new Bitmap(width, height);

                if (Properties.Settings.Default.addLogo)
                {
                    if (Properties.Settings.Default.logo != "" && File.Exists(Properties.Settings.Default.logo))
                    {
                        Bitmap logoPath = new Bitmap(Properties.Settings.Default.logo);

                        var pos = Properties.Settings.Default.position > 0 || Properties.Settings.Default.position < 10 ? Properties.Settings.Default.position : 5;

                        ColorMatrix matrix = new ColorMatrix();
                        matrix.Matrix33 = Convert.ToSingle(this.numTransparency.Value / 100);
                        ImageAttributes transparency = new ImageAttributes();
                        transparency.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                        //Modifica o tamanho da logo mantendo as proporsões de altura e largura
                        var desiredWidth = width * (this.numSize.Value / 100);
                        var desiredHeight = height * (this.numSize.Value / 100);

                        double ratioW = (double)desiredWidth / (double)logoPath.Width;
                        double ratioH = (double)desiredHeight / (double)logoPath.Height;
                        double ratio = ratioW < ratioH ? ratioW : ratioH;
                        int suitableWidth = (int)(logoPath.Width * ratio);
                        int suitableHeight = (int)(logoPath.Height * ratio);

                        Image imgLogo = new Bitmap(logoPath, suitableWidth, suitableHeight);
                        Graphics g = Graphics.FromImage(final);
                        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        g.SmoothingMode = SmoothingMode.HighQuality;
                        g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                        g.CompositingQuality = CompositingQuality.HighQuality;

                        g.Clear(Color.Transparent);
                        g.DrawImage(imgImovel, 0, 0);

                        if (pos.Equals(1))
                        {
                            g.DrawImage(imgLogo,
                                new Rectangle(5, 5, width, height),
                                0, 0, width, height,
                                GraphicsUnit.Pixel,
                                transparency);
                        }

                        if (pos.Equals(2))
                        {
                            g.DrawImage(imgLogo,
                            new Rectangle(((width / 2) - (imgLogo.Width / 2)), 5, width, height),
                            0, 0, width, height,
                            GraphicsUnit.Pixel,
                            transparency);
                        }

                        if (pos.Equals(3))
                        {
                            g.DrawImage(imgLogo,
                                new Rectangle(((width - imgLogo.Width) - 5), 5, width, height),
                                0, 0, width, height,
                                GraphicsUnit.Pixel,
                                transparency);
                        }

                        if (pos.Equals(4))
                        {
                            g.DrawImage(imgLogo,
                            new Rectangle(5, ((height / 2) - (imgLogo.Height / 2)), width, height),
                            0, 0, width, height,
                            GraphicsUnit.Pixel,
                            transparency);
                        }

                        if (pos.Equals(5))
                        {
                            g.DrawImage(imgLogo,
                            new Rectangle(((width / 2) - (imgLogo.Width / 2)), ((height / 2) - (imgLogo.Height / 2)), width, height),
                            0, 0, width, height,
                            GraphicsUnit.Pixel,
                            transparency);
                        }

                        if (pos.Equals(6))
                        {
                            g.DrawImage(imgLogo,
                            new Rectangle(((width - imgLogo.Width) - 5), ((height / 2) - (imgLogo.Height / 2)), width, height),
                            0, 0, width, height,
                            GraphicsUnit.Pixel,
                            transparency);
                        }

                        if (pos.Equals(7))
                        {
                            g.DrawImage(imgLogo,
                            new Rectangle(5, ((height - imgLogo.Height) - 5), width, height),
                            0, 0, width, height,
                            GraphicsUnit.Pixel,
                            transparency);
                        }

                        if (pos.Equals(8))
                        {
                            g.DrawImage(imgLogo,
                            new Rectangle(((width / 2) - (imgLogo.Width / 2)), ((height - imgLogo.Height) - 5), width, height),
                            0, 0, width, height,
                            GraphicsUnit.Pixel,
                            transparency);
                        }

                        if (pos.Equals(9))
                        {
                            g.DrawImage(imgLogo,
                            new Rectangle(((width - imgLogo.Width) - 5), ((height - imgLogo.Height) - 5), width, height),
                            0, 0, width, height,
                            GraphicsUnit.Pixel,
                            transparency);
                        }

                        g.Dispose();
                        imgLogo.Dispose();
                    }
                }

                imgImovel.Dispose();
                count++;
                final.Save(Path.Combine(path, count.ToString() + ".jpg"), System.Drawing.Imaging.ImageFormat.Jpeg);
                final.Dispose();
            } catch { }
            finally
            {
                image.Dispose();
            }
        }

    }
}