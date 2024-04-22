using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public class GameStatistics
 {

    Dictionary<int, List<int>> scoringStats;
    List<int> pressesOrder;
    public GameStatistics()
    {
        scoringStats = new Dictionary<int, List<int>>();
        pressesOrder = new List<int>();
    }

    public void reportStatistic(int timerid, int framesLate)
    {
        if (!scoringStats.ContainsKey(timerid))
        {
            scoringStats[timerid] = new List<int>();
        }
        scoringStats[timerid].Add(framesLate);
        
        pressesOrder.Add(timerid);
    }

    public void fillInTableWithEachRoundLateness(DataGridView blanktable)
    {
        blanktable.Columns.Clear();

        // Go over every timer
        for (int round = 1; round <= scoringStats.Count; ++round)
        {
            // Add the column
            blanktable.Columns.Add(round.ToString(), "Round " + round.ToString() + ":");

            //blanktable.Columns[round - 1].Resizable = DataGridViewTriState.True;


            int cellToPut = 0;

            blanktable.Rows.Add(2);

            for (int timer = 1; timer <= round; ++timer)
            {
                
                int dataToPutInCell = scoringStats[timer][(round - timer) * 2];
                blanktable[round - 1, cellToPut++].Value = dataToPutInCell.ToString();
                dataToPutInCell = scoringStats[timer][(round - timer) * 2 + 1];
                blanktable[round - 1, cellToPut++].Value = dataToPutInCell.ToString();
            }

        }
    }
    public void fillInTableWithEachRoundOrder(DataGridView blanktable)
    {
        blanktable.Columns.Clear();

        int byTwoCount = 0;
        int byTwoMax = 0;
        
        for (int i = 0; i<pressesOrder.Count; ++i)
        {
            if (byTwoCount == byTwoMax)
            {
                byTwoCount = 0;
                byTwoMax += 2;

                blanktable.Columns.Add((byTwoMax / 2).ToString(), "Round: " + (byTwoMax / 2).ToString());
                blanktable.Rows.Add(2);
            }

            blanktable[byTwoMax / 2 - 1, byTwoCount].Value = pressesOrder[i];
            ++byTwoCount;

        }
    }
    


    public int roundNumber;

 }
