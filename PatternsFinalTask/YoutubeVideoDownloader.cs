using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode.Converter;

namespace PatternsFinalTask
{
    public static class YoutubeVideoDownloader
    {
        private static string outputPath = Path.Combine("bin", "Debug", "net6.0", "VideoExample.mp4");

        public static void ChangeOutputPath(string newPath)
        {
            outputPath = newPath;
        }
        public static void Download(YoutubeVideo video)
        {
            YoutubeAPI.client.Videos.DownloadAsync(video.Url, outputPath);
        }
    }
}
