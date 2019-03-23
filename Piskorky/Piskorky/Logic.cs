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
		//public List<int> table { get;}

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
	}
}
