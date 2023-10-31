using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsFinalTask
{
    public class YoutubeVideo
    {
        public string? Url { get; private set; }
        public string? Title { get; private set; }
        public string? Description { get; private set; }

        public YoutubeVideo(string url)
        {
            Url = url;
        }

        public void SetData()
        {
            var videosOperations = YoutubeAPI.client.Videos;
            var video = videosOperations.GetAsync(Url).Result;
            Title = video.Title;
            Description = video.Description;
            Console.WriteLine(Title);
            Console.WriteLine(Description);
        }

        public void Download()
        {
            YoutubeVideoDownloader.Download(this);
        }
    }
}
