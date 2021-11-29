using System;

namespace Classes
{
    partial class CD_Player
    {
        private bool play;
        private bool stop;
        private double counter;
        private int nmbrsOfTracks;
        private double trackLength;
        private double CDLength;
        private static int cdCapacity = 700; //700 мб
        private string cdName;
        private string[] trackList;
        private static string playerName;

        public CD_Player()
        {
            play = false;
            stop = false;
            counter = 0;
            nmbrsOfTracks = 0;
            trackLength = 0;
            CDLength = trackLength * nmbrsOfTracks;
            cdName = "No name";
            trackList = null;
            playerName = "BBPlayer";
        }
        public CD_Player(int NmbrsOfTracks, string CdName, string[] TrackList)
        {
            play = false;
            stop = true;
            counter = 0;
            nmbrsOfTracks = NmbrsOfTracks;
            trackLength = 0;
            CDLength = trackLength * nmbrsOfTracks;
            cdName = CdName;
            trackList = TrackList;
            playerName = "BBPlayer";
        }
        static CD_Player()
        {
            string playerName = "BBPlayer"; //BurningBornPlayer
        }
        public bool Play(ref bool play)
        {
            stop = false;
            return play = true;
        }
        public bool Stop(ref bool stop)
        {
            play = false;
            return stop = true;
        }

        public static CD_Player operator +(CD_Player one, CD_Player two)
        {
            CD_Player temp = new CD_Player { };
            temp.nmbrsOfTracks = one.nmbrsOfTracks + two.nmbrsOfTracks;
            temp.CDLength = one.CDLength + two.CDLength;
            return temp;
        }
        public int NmbrsOfTracks
        {
            get { return nmbrsOfTracks; }
            set { nmbrsOfTracks = value; }
        }
        public string CdName
        {
            get { return cdName; }
            set { cdName = value; }
        }
        public void Display()
        {
            Console.WriteLine($"CD Name: {cdName} \n");
            int num = 1;
            if (trackList != null)
                foreach (string elem in trackList)
                    Console.WriteLine($"{num++}. {elem}");

        }
        partial void ListPrint();


    }
    class Program
    {

        static void Main(string[] args)
        {

            string[] trackList = new string[] { "Du hast", "America", "Muter" };
            CD_Player Rock = new CD_Player(3, "Rammshtein", trackList);
            Rock.Display();
            bool play = false, stop = false;
            Rock.Play(ref play);
            Rock.Stop(ref stop);

            CD_Player[] RandomList = new CD_Player[5];
            for (int i = 0; i < RandomList.Length; i++)
            {
                RandomList[i] = new CD_Player();
            }

            foreach (CD_Player elem in RandomList)
                elem.Display();
        }
    }
}
