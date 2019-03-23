using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piskorky
{
    public class Logic
    {
		public Settings Settings { get; set; }

		public Logic()
		{
		}
        public Logic(Settings settings)
        {
			Settings = settings;
        }
		public void CreatePlaingFiled(int size, DataGridView dtgw_PlaingField)
		{
			for (int i = 0; i < size; i++)
			{
				dtgw_PlaingField.Columns.Add($"{i}", $"{i}");
				dtgw_PlaingField.Rows.Add();
			}
		}

		public void Mark(DataGridView dtgw_PlaingField, DataGridViewCellEventArgs e, int turn)
		{
			dtgw_PlaingField[e.ColumnIndex, e.RowIndex].Value = Settings.Players[turn % Settings.Players.Count].Mark;
		}

		public bool IsWin(DataGridView dtgw_PlaingField, DataGridViewCellEventArgs e)
		{
			int countHorizontal = 0;
			int countVertical = 0;
			//int countDiagonalUp = 0;
			//int countDiagonalDown = 0;
			int countDiagonal = 0;
			//if (!(countHorizontal == Settings.WinCondition || 
			//	countVertical == Settings.WinCondition || 
			//	countDiagonalDown == Settings.WinCondition || 
			//	countDiagonalUp == Settings.WinCondition))
				if (!(countHorizontal == Settings.WinCondition ||
				countVertical == Settings.WinCondition ||
				countDiagonal== Settings.WinCondition))
				{
				foreach (Player p in Settings.Players)
				{
					for (int i = 0; i < dtgw_PlaingField.ColumnCount; i++)
					{
						if (dtgw_PlaingField[i,0].Value.Equals(p.Mark)) countHorizontal++;
						for (int j = 0; j < dtgw_PlaingField.RowCount; j++)
						{
							if (dtgw_PlaingField[i,j].Value.Equals(p.Mark)) countVertical++;
							if (dtgw_PlaingField[i,j].Value.Equals(p.Mark) && dtgw_PlaingField.Columns[i].Equals(p.Mark)) countDiagonal++;
						}
					}
				}
				
				return true;
			}
			return false;
		}
	}
}
