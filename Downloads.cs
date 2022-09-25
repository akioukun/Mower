using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grass
{
    internal class Downloads
    {



        public static async Task<string> downloadFileAsync(string url, string path)
        {

            using (WebClient client = new WebClient())
            {


                await client.DownloadFileTaskAsync(new Uri(url), path);

            }


            return url;
            return path;
        }


        public static async Task<object> DownloadFileAsyncyes(string url, string path)
        {

            using (WebClient client = new WebClient())
            {


                await client.DownloadFileTaskAsync(new Uri(url), path);

            }

            throw new NotImplementedException();
        }

      

        

    }
}
