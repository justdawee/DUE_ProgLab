namespace FELADAT1;

using System;
using System.ComponentModel;
using System.IO;
using System.Net;

public class FileDownload
{
    public bool StartDownload(string url, string localFilePath)
    {
        using (WebClient webClient = new WebClient())
        {
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(webClientDownloadProgressChanged);
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(webClientCompleted);
            Console.WriteLine("Start: " + url);
            webClient.DownloadFileAsync(new Uri(url), localFilePath);
            while (webClient.IsBusy) { }

            long length = new FileInfo(localFilePath).Length;
            return length > 0;
        }
    }

    private void webClientDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
    {
        Console.WriteLine($"{e.ProgressPercentage}% completed.");
    }

    private void webClientCompleted(object sender, AsyncCompletedEventArgs e)
    {
        if (e.Error != null)
            Console.WriteLine("Nem sikerült a letöltés: " + e.Error.Message);
        else if (e.Cancelled)
            Console.WriteLine("Letöltés megszakítva.");
        else
            Console.WriteLine("A fájl sikeresen letöltve.");
    }
}
