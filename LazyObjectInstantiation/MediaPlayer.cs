using System;

namespace LazyObjectInstalation
{
    class MediaPlayer
    {
        public void Play() { }
        public void Pause() { }
        public void Stop() { }
        private Lazy<AllTracks> _allSongs = new Lazy<AllTracks>(() =>
        {
            Console.WriteLine("Creating AllTracks object!");
            return new AllTracks();
        }
        );
        public AllTracks GetAllTracks()
        {
            return _allSongs.Value;
        }

    }
}