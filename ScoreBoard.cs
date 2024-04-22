using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public class ScoreBoard
{
    public ScoreBoard(Label scorelabel)
    {
        playerScore = 0;
        labelToUpdate = scorelabel;
    }
    public void addToScore(int toAdd)
    {
        playerScore += toAdd;

        labelToUpdate.Text = "Score: "+ playerScore.ToString();
    }

    public void subtractFromScore(int toSub)
    {
        playerScore -= toSub;
        labelToUpdate.Text = "Score: " +  playerScore.ToString();
    }

    private int playerScore;
    Label labelToUpdate;

}

