using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piskorky
{
	public class Settings
	{
		public int Size { get; private set; }
		public int WinCondition { get; private set; }
		public List<Player> Players{ get; }

		public Settings(int size, int winCondition)
		{
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
	}
}
