using System.Net;
using System.Windows.Forms;
using System.IO.Compression;
using ComponentFactory.Krypton.Toolkit;
using System.Runtime.CompilerServices;
using System;
using System.Threading.Tasks;
using AltoHttp;
using System.DirectoryServices.ActiveDirectory;
using System.Linq.Expressions;
using System.Diagnostics;

namespace Grass
{
    public partial class Mower : KryptonForm
    {
        public Mower()
        {
            InitializeComponent();
        }

       

        HttpDownloader httpDownloader;

        
        
       
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
           
            var filePath = string.Empty;

            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            

                OpenFileDialog.InitialDirectory = "c:\\";
                OpenFileDialog.Filter = "global-metadata.dat (*.dat)|*.dat";
                OpenFileDialog.FilterIndex = 1;
                OpenFileDialog.RestoreDirectory = false;
           


            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = OpenFileDialog.FileName;
                try
                {


                    Downloads.DownloadFileAsyncyes("https://github.com/akioukun/Resources/releases/download/3.0/global-metadata-patched.dat", "global-metadata-patched.dat");


                    File.Delete(filePath);

                    Thread.Sleep(5000);

                    Task wait = Task.Factory.StartNew(PleaseWait);
                    Task.WaitAll(wait);

                    File.Move("global-metadata-patched.dat", filePath);
                    MessageBox.Show("Metadata Patched succesfully!");

                }
                catch (Exception o)
                {

                    MessageBox.Show(o.ToString());

                }
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {

           
            var filePath1 = string.Empty;

            OpenFileDialog OpenFileDialog = new OpenFileDialog();

                //nothing

            OpenFileDialog.InitialDirectory = "c:\\";
            OpenFileDialog.Filter = "global-metadata.dat (*.dat)|*.dat";
            OpenFileDialog.FilterIndex = 1;
            OpenFileDialog.RestoreDirectory = true;


            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath1 = OpenFileDialog.FileName;
                try
                {
                    Downloads.downloadFileAsync("https://github.com/akioukun/Resources/releases/download/3.0/global-metadata-unpatched.dat", "global-metadata-unpatched.dat");

                    File.Delete(filePath1);

                    Thread.Sleep(5000);

                    Task wait = Task.Factory.StartNew(PleaseWait);
                    Task.WaitAll(wait);

                    File.Move("global-metadata-unpatched.dat", filePath1);

                    MessageBox.Show("Metadata unpatched succesfully!");
                }
                catch (Exception u)
                {
                    MessageBox.Show(u.ToString());

                }
            }

        }

        public static int PleaseWait()
        {
                
            Thread.Sleep(2000);
            return 2000;
        }

        private void label5_Click(object sender, EventArgs e)
        {
          




        }

        
        public async void button4_Click(object sender, EventArgs e)
        {
                     
                        
            
        }
      
        private void label4_Click_1(object sender, EventArgs e)
        {
            

           


           
            
        }


        public string checkIf(string labelll)
        {


            return null;


             
        }

        private void kryptonPalette1_PalettePaint(object sender, Krypton.Toolkit.PaletteLayoutEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void HttpDownloader_progressBar1_Click(object sender, AltoHttp.ProgressChangedEventArgs e)
        {
           
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

            
        }  
       
        public void button5_Click(object sender, EventArgs e)
        {

            Directory.CreateDirectory("GrasscutterServer\\Grasscutter-development");


            using (var client = new WebClient())
            {

                client.DownloadFile("https://github.com/akioukun/Resources/releases/download/3.0/Grasscutter-development1.zip", "GrassDev.zip");
            }

            httpDownloader = new HttpDownloader("https://github.com/akioukun/Resources/releases/download/3.0/Resources1.zip", "Resources1.zip");
            httpDownloader.DownloadCompleted += HttpDownloader_DownloadCompleted;
            httpDownloader.ProgressChanged += HttpDownloader_ProgressChanged;
            httpDownloader.Start();
            Thread.Sleep(5000);
            if (httpDownloader != null)
            {
                MessageBox.Show("Resources installed!");
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private async void HttpDownloader_ProgressChanged(object sender, AltoHttp.ProgressChangedEventArgs e)
        {

            progressBar1.Value = (int)e.Progress;
           

        }
        private async void HttpDownloader_DownloadCompleted(object sender, EventArgs e)
        {
            try
            {
            }
            catch(Exception b)
            {


                this.Invoke((MethodInvoker)delegate
                {

                   

                });
            }

            }

        

      

        private void Pause_Click(object sender, EventArgs e)
        {
            if (httpDownloader != null)
                httpDownloader.Pause();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            if (httpDownloader != null)
                httpDownloader.Resume();
        }

        public void button6_Click(object sender, EventArgs e)
        {
            

            try
            {

                using (var client = new WebClient())
                {

                    client.DownloadFile("https://github.com/akioukun/Resources/releases/download/3.0/StartServer.bat", "StartServer.bat");
                }

                httpDownloader = new HttpDownloader("https://jenkins.4benj.com/job/Grasscutters/job/Grasscutter/lastSuccessfulBuild/artifact/grasscutter-1.3.2-dev.jar", "GrasscutterServer\\Grasscutter-development\\grasscutter-1.3.2-dev.jar");
            httpDownloader.DownloadCompleted += HttpDownloader_DownloadCompleted;
            httpDownloader.ProgressChanged += HttpDownloader_ProgressChanged;
            httpDownloader.Start();

            }
            catch (System.IO.IOException)
            {

                
            }
            
            Thread.Sleep(5000);
            MessageBox.Show("Grasscutter Installed! Press Ok for the extraction of resources!");
            try
            {

                if (File.Exists("Resources1.zip"))
                {
                    string zipFilePath = @"Resources1.zip";
                    string extractionPath = "GrasscutterServer\\Grasscutter-development\\resources";
                    ZipFile.ExtractToDirectory(zipFilePath, extractionPath);
                   
                    string zipFilePath1 = @"GrassDev.zip";
                    string extractionPath1 = "GrasscutterServer\\Grasscutter-development";
                    ZipFile.ExtractToDirectory(zipFilePath1, extractionPath1);

                    MessageBox.Show("Resources extracted!");

                }

                else
                {

                    MessageBox.Show("Make sure to install grasscutter resources first!");
                }
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Error: Already extracted.");
            }


           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (File.Exists("StartServer.bat"))
                {

                Process.Start("StartServer.bat");

            }
            else
            {

                MessageBox.Show("Install grasscutter first!");
            }

           
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            MessageBox.Show("Proxy feature currently disabled for maintanance, please use an alternative!");
            /*
            if (!File.Exists("cert.bat"))
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://github.com/akioukun/Resources/releases/download/3.0/cert.bat", "cert.bat");

                }
                Process.Start("cert.bat");
            }
            
            using (var client = new WebClient())
            {
                client.DownloadFile("https://github.com/akioukun/Resources/releases/download/3.0/mitmproxy.exe", "mitmproxy.exe");

            }

            using (var client = new WebClient())
            {
                client.DownloadFile("https://github.com/akioukun/Resources/releases/download/3.0/mitmdump.exe", "mitmdump.exe");

            }

            using (var client = new WebClient())
            {
                client.DownloadFile("https://github.com/akioukun/Resources/releases/download/3.0/proxy.py", "proxy.py");

            }
            using (var client = new WebClient())
            {
                client.DownloadFile("https://github.com/akioukun/Resources/releases/download/3.0/proxy_config.py", "proxy_config.py");

            }

            using (var client = new WebClient())
            {
                client.DownloadFile("https://github.com/akioukun/Resources/releases/download/3.0/proxy.bat", "proxy.bat");
            }
            Thread.Sleep(5000);


            Process.Start("proxy.bat");

            Thread.Sleep(2000);
            MessageBox.Show("Proxy started!");

            */

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (File.Exists("C:\\Program Files\\Genshin Impact\\Genshin Impact game\\GenshinImpact.exe"))
            {

                Process.Start("C:\\Program Files\\Genshin Impact\\Genshin Impact game\\GenshinImpact.exe");


            }
            else
            {


                MessageBox.Show("Genshin Impact not found, please select manually!");

                var filePath = string.Empty;

                OpenFileDialog OpenFileDialog = new OpenFileDialog();


                OpenFileDialog.InitialDirectory = "c:\\";
                OpenFileDialog.Filter = "GenshinImpact (*.exe)|*.exe";
                OpenFileDialog.FilterIndex = 1;
                OpenFileDialog.RestoreDirectory = false;
               


                if (OpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = OpenFileDialog.FileName;
                    try
                    {

                        Process.Start(filePath);

                    }
                    catch (Exception o)
                    {

                        MessageBox.Show(o.ToString());

                    }
                }

            }
        }
    }
}
