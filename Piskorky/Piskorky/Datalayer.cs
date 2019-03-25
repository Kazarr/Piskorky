using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace Piskorky
{
    public static class Datalayer
    {
        public static bool Save(Logic logic, DataGridView dtgw_PlaingField)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(logic.Settings.ToString());
            sb.Append(logic.ToString(dtgw_PlaingField));
            File.AppendAllText("Piskorky.txt",sb.ToString());
            return false; 
        }
        public static Logic Load(string path, DataGridView dtgw_PlaingField)
        {
            Logic logic = new Logic();
            int size;
            int winCondition;
            int turn;
            if (File.Exists(path))
            {
                string[] loadedLines = File.ReadAllLines(path);
                string[] loadedLogic = loadedLines[0].Split('\t');
                size = int.Parse(loadedLogic[0]);
                winCondition = int.Parse(loadedLogic[1]);
                turn = int.Parse(loadedLogic[2]);
                Settings settings = new Settings(size, winCondition);
                for (int j = 3; j < loadedLogic.Length; j += 2) //načítam hráčov
                {
                    settings.Players.Add(new Player(loadedLogic[j], loadedLogic[j + 1]));
                }
                logic.Settings = settings;
                for(int i = 1; i < loadedLines.Length; i++) // idem prechádzať súradnice znakov na datagridview
                {                                     
                    string[] loadedMarks = loadedLines[i].Split('\n');
                    for(int j = 0; j < loadedMarks.Length; j++) // jeden riadok so súradnicami
                    {
                        string[] loadedMark = loadedMarks[j].Split(' ');
                        double part = Math.Ceiling((double)loadedMarks.Length / settings.Players.Count); // lajny rozdelené po tom koľko má jednotlivý hráč zapísať.

                        if(j < part)
                        {

                        }
                        dtgw_PlaingField[int.Parse(loadedMark[0]), int.Parse(loadedMark[1])]
                    }
                        
                }
                
            }
            return logic;
            
        }
    }
}
