using System;

namespace LazyObjectInstalation
{
    class AllTracks
    {
        private Song[] _allsongs = new Song[10000];
        public AllTracks()
        {
            Console.WriteLine("Fiiling up the songs!");
        }
    }
}