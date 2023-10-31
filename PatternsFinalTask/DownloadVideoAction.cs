using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsFinalTask
{
    public class DownloadVideoAction : IAction
    {
        private YoutubeVideo video;

        public DownloadVideoAction(YoutubeVideo video) 
        {
            this.video = video;
        }

        public void Cancel()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            video.Download();
        }
    }
}
