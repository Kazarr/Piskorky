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

		//public bool IsWin(DataGridView dtgw_PlaingField, DataGridViewCellEventArgs e)
		//{
		//	int countHorizontal = 0;
		//	int countVertical = 0;
		//	//int countDiagonalUp = 0;
		//	//int countDiagonalDown = 0;
		//	int countDiagonal = 0;
		//	//if (!(countHorizontal == Settings.WinCondition || 
		//	//	countVertical == Settings.WinCondition || 
		//	//	countDiagonalDown == Settings.WinCondition || 
		//	//	countDiagonalUp == Settings.WinCondition))
		//	if (!(countHorizontal == Settings.WinCondition ||
		//	countVertical == Settings.WinCondition ||
		//	countDiagonal== Settings.WinCondition))
		//	{
               
		//	    foreach (Player p in Settings.Players)
		//	    {
  //                  countHorizontal = 1;
  //                  countVertical = 1;
  //                  countDiagonal = 1;
  //                  string previousMark = "";
  //                  int previousMarkColumn = 0;
  //                  int previousMarkRow = 0;
  //                  for (int i = 0; i < dtgw_PlaingField.ColumnCount; i++)
		//		    {
  //                      //if (null != dtgw_PlaingField[i,0].Value)
  //                      //{
  //                      //if (dtgw_PlaingField[i, 0].Value.Equals(p.Mark)) countHorizontal++;
  //                      //}
		//		        for (int j = 0; j < dtgw_PlaingField.RowCount; j++)
		//		        {
  //                          if (dtgw_PlaingField[i, j].Value != null)
  //                          {
  //                              if (dtgw_PlaingField[i, j].Value.Equals(p.Mark))
  //                              {
  //                                  if (previousMark.Equals(dtgw_PlaingField[i, j].Value) &&
  //                                      previousMarkColumn == dtgw_PlaingField.Columns.IndexOf(dtgw_PlaingField.Columns[i]))
  //                                  {
  //                                      previousMarkColumn = dtgw_PlaingField.Columns.IndexOf(dtgw_PlaingField.Columns[i]);
  //                                      previousMarkRow = dtgw_PlaingField.Rows.IndexOf(dtgw_PlaingField.Rows[j]);
  //                                      previousMark = (string)dtgw_PlaingField[i, j].Value;
  //                                      countVertical++;
  //                                      if (countVertical == Settings.WinCondition)
  //                                      {
  //                                          return true;
  //                                      }
  //                                  }
  //                                  else if (previousMark.Equals(dtgw_PlaingField[i, j].Value) &&
  //                                      previousMarkRow == dtgw_PlaingField.Rows.IndexOf(dtgw_PlaingField.Rows[j]))
  //                                  {
  //                                      countVertical++;
  //                                      if (countVertical == Settings.WinCondition)
  //                                      {
  //                                          return true;
  //                                      }
  //                                  }else
  //                                  {
  //                                      previousMarkColumn = dtgw_PlaingField.Columns.IndexOf(dtgw_PlaingField.Columns[i]);
  //                                      previousMarkRow = dtgw_PlaingField.Rows.IndexOf(dtgw_PlaingField.Rows[j]);
  //                                      previousMark = (string)dtgw_PlaingField[i, j].Value;
  //                                  }
  //                              }
  //                              //if (dtgw_PlaingField[i, j].Value.Equals(p.Mark))
  //                              //{
  //                              //    
  //                              //    if (previousMark.Equals(p.Mark))
  //                              //    {
  //                              //        countVertical++;
  //                              //        if (countVertical == Settings.WinCondition)
  //                              //        {
  //                              //            return true;
  //                              //        }
  //                              //    }
                                    
  //                              //}

  //                              if (dtgw_PlaingField[i, j].Value.Equals(p.Mark) && dtgw_PlaingField.Columns[i].Equals(p.Mark))
  //                              {
  //                                  if(countDiagonal == Settings.WinCondition)
  //                                  {
  //                                      countDiagonal++;
  //                                  }
  //                              }
                                
  //                          }
		//		        }
		//	        }
		//        }
		//	}
  //          return false;
		//}
	}
}
