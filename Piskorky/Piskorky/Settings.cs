using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piskorky
{
	public class Settings
	{
		public int Size { get; set; }
		public int WinCondition { get; set; }
        public int Turn { get; set; }
		public List<Player> Players{ get; }

		public Settings(int size, int winCondition)
		{
            Turn = 0;
			Size = size;
			WinCondition = winCondition;
			Players = new List<Player>(5);
		}

		public void AddPlayer(Player player)
		{
			Players.Add(player);
		}
		public void AddPlayer()
		{
			Player player = new Player("Player", "X");
			Players.Add(player);
		}
		public void AddPlayers(int count, Player player)
		{
			for (int i = 0; i < count; i++)
			{

				Players.Add(new Player("Player" + i + 1, "X"));
			}
		}

        override
        public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Size);
            sb.Append("\t");
            sb.Append(WinCondition);
            sb.Append("\t");
            sb.Append(Turn);
            sb.Append("\t");
            foreach (Player p in Players)
            {
                sb.Append(p.ToString());
            }
            return sb.ToString();
        }
	}
}
