
using PatternsFinalTask;
using YoutubeExplode;

const string URL = "https://www.youtube.com/watch?v=gG5nPyFvhpM";

YoutubeAPI.client = new YoutubeClient();
var actor = new Actor();
var video = new YoutubeVideo(URL);
actor.SetCommand(new GetVideoInfoAction(video));
actor.Run();
actor.SetCommand(new DownloadVideoAction(video));
actor.Run();

