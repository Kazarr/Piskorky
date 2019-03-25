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

        override
        public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append("\t");
            sb.Append(Mark);
            sb.Append("\t");
            sb.ToString().Substring(0,sb.ToString().Length-1);
            return sb.ToString();
        }
	}
}
