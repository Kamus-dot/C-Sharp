using LazyObjectInstalation;

Console.WriteLine("*******Fun With Lazy Instantion*******");
MediaPlayer myPlayer = new MediaPlayer();
myPlayer.Play();
MediaPlayer yourPlayer = new MediaPlayer();
AllTracks yourmusic = yourPlayer.GetAllTracks();
