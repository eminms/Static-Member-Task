namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1.New player add:");
                Console.WriteLine("2.Change Score:");
                Console.WriteLine("3.Remove Player:");
                Console.WriteLine("4.Show All Info:");
                Console.WriteLine("5.Exit.");
                Console.Write("Choice:");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Player Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Player Score: ");
                        int score = int.Parse(Console.ReadLine());
                        new GamePlayer(name, score);
                        break;
                    case "2":
                        Console.Write("Enter Player ID to change score: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Enter New Score: ");
                        int newScore = int.Parse(Console.ReadLine());
                        var player = Array.Find(GamePlayer.players, p => p.PlayerId == id);
                        if (player != null)
                        {
                            player.UpdateScore(newScore);
                        }
                        else
                        {
                            Console.WriteLine("Player not found.");
                        }
                        break;
                    case "3":
                        GamePlayer.RemovePlayer();
                        break;
                    case "4":
                        GamePlayer.ShowAllInfo();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Wrong chice.");
                        break;

                }

            }
        }
    }
}
