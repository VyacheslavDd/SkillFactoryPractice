using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsFinalTask
{
    public class GetVideoInfoAction : IAction
    {
        private YoutubeVideo video;
        public GetVideoInfoAction(YoutubeVideo video) 
        {
            this.video = video;
        }
        public void Cancel()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            video.SetData();
        }
    }
}
