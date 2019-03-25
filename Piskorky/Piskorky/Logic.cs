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

        public Logic() { }
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

		public void Mark(DataGridView dtgw_PlaingField, DataGridViewCellEventArgs e)
		{
			dtgw_PlaingField[e.ColumnIndex, e.RowIndex].Value = Settings.Players[Settings.Turn % Settings.Players.Count].Mark;
            Settings.Turn++;
		}

        public bool IsWin(DataGridView dtgw_PlaingField, DataGridViewCellEventArgs e)
        {
            int count = 0;

            for(int i = 0; i < dtgw_PlaingField.Columns.Count; i++)
            {
                for(int j = 0; j < dtgw_PlaingField.Rows.Count; j++)
                {
                    foreach(Player p in Settings.Players)
                    {
                        count = 0;
                        if(dtgw_PlaingField[i,j].Value != null)
                        {
                            if (dtgw_PlaingField[i, j].Value.Equals(p.Mark))
                            {
                                for (int k = i; k < dtgw_PlaingField.Columns.Count; k++)
                                {
                                    if (dtgw_PlaingField[i, j].Value.Equals(dtgw_PlaingField[k, j].Value))
                                    {
                                        count++;
                                        if (count == Settings.WinCondition)
                                        {
                                            return true;
                                        }
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                count = 0;
                                for (int k = j; k < dtgw_PlaingField.Columns.Count; k++)
                                {
                                    if (dtgw_PlaingField[i, j].Value.Equals(dtgw_PlaingField[i, k].Value))
                                    {
                                        count++;
                                        if (count == Settings.WinCondition)
                                        {
                                            return true;
                                        }
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                count = 0;
                                for (int k = 0; k < Settings.WinCondition; k++)
                                {
                                    if (dtgw_PlaingField[i, j].Value.Equals(dtgw_PlaingField[k, k].Value))
                                    {
                                        count++;
                                        if (count == Settings.WinCondition)
                                        {
                                            return true;
                                        }
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                count = 0;
                                for (int k = 0; k < Settings.WinCondition; k++)
                                {
                                    if ((j - k) > 0 && (i +k) < dtgw_PlaingField.ColumnCount)
                                    {
                                        if (dtgw_PlaingField[i, j].Value.Equals(dtgw_PlaingField[i + k, j - k].Value))
                                        {
                                            count++;
                                            if (count == Settings.WinCondition)
                                            {
                                                return true;
                                            }
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }
        public string ToString(DataGridView dtgw_PlaingField)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n");
            for(int i = 0; i < dtgw_PlaingField.RowCount; i++)
            {
                for(int j = 0; j < dtgw_PlaingField.ColumnCount; j++)
                {
                    foreach(Player p in Settings.Players)
                    {
                        if(dtgw_PlaingField[i, j].Value != null)
                        {
                            if (dtgw_PlaingField[i, j].Value.Equals(p.Mark))
                            {
                                sb.Append($"{i}");
                                sb.Append(" ");
                                sb.Append($"{j}");
                                sb.Append("\n");
                            }
                        }
                    }
                    
                }
            }
            return sb.ToString();
        }
	}
}
