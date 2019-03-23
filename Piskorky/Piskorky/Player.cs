using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piskorky
{
	public class Player
	{
		public string Name { get; set; }
		public string Mark { get; private set; }

		public Player(string name, string mark)
		{
			Name = name;
			Mark = mark;
		}
	}
}
