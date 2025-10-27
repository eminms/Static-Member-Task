using System.Numerics;

namespace ConsoleApp2
{
    internal class GamePlayer
    {
        public string PlayerName { get; set; }
        public int Score { get; set; }
        public int PlayerId { get; set; }
        public static int TotalPlayers = 0;
        public static int HigestScore = 0;
        public static int NextId = 1;
        public static GamePlayer[] players = new GamePlayer[0];
        public GamePlayer(string playerName, int score)
        {
            PlayerName = playerName;
            Score = score;
            PlayerId = NextId++;
            Array.Resize(ref players, players.Length + 1);
            players[players.Length - 1] = this;
            TotalPlayers++;
            if (score > HigestScore)
            {
                HigestScore = score;
            }
        }
        public void UpdateScore(int newScore)
        {
            Score = newScore;
            foreach (var player in players)
            {
                if (player.Score > HigestScore)
                    HigestScore = player.Score;
            }
        }
        public static void RemovePlayer()
        {
            if (TotalPlayers == 0) return;
            Array.Resize(ref players, players.Length - 1);
            TotalPlayers--;
            HigestScore = 0;
            foreach (var player in players)
            {
                if (player.Score > HigestScore)
                    HigestScore = player.Score;
            }

        }
        public static void ShowAllInfo()
        {
            Console.WriteLine($"Total Players: {TotalPlayers}");
            Console.WriteLine($"Highest Score: {HigestScore}");
            foreach (var player in players)
            {
                Console.WriteLine($"Player ID: {player.PlayerId}, Name: {player.PlayerName}, Score: {player.Score}");
            }
        }

    }
}