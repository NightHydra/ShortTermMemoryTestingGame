using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class Counter
{
    public Counter(Random rng, ScoreBoard scoreSystem, int framesTimerLasts, GameStatistics
           statsObject)
    {
        ++total_timer_count;

        timerId = total_timer_count;

        // Static variables that can / will be used by all instances

        // Create a grid of large boxes where the bars can be located ie.

#if false

    ---------------------------------------
    |        |          |         |       |
    |        |          |         |       |
    |        |          |         |       |
    ---------------------------------------
    |        |          |         |       |
    |        |          |         |       |
    |        |          |         |       |
    ---------------------------------------
    |        |          |         |       |
    |        |          |         |       |
    |        |          |         |       |
    ---------------------------------------


#endif




        fullBarFrameCount = framesTimerLasts;

        rnd = rng;
        thescoreboard = scoreSystem;

        progBar = new ProgressBar();

        progBar.Location = generateRandomPoint();
        progBar.Size = new Size(KeyVars.TIMERWIDTH, KeyVars.TIMERHEIGHT);

        progBar.Click += new EventHandler(onClick);


        overflowFrameCount = 0;

        // Initially we set the timer to 0 frames
        frameCount = 0;


        overallGameStats = statsObject;
        

    }

    private Point generateRandomPoint()
    {
        Point toReturn = pointsToPlaceTimer.ElementAt(rnd.Next(0, pointsToPlaceTimer.Count));

        pointsToPlaceTimer.Remove(toReturn);

        return toReturn;
    }

    public void incrementTime()
    {
        

        if (frameCount < fullBarFrameCount)
        {
            ++frameCount;
            progBar.Value = (frameCount * 100) / fullBarFrameCount;
        }
        else
        {
            ++overflowFrameCount;
            if (overflowFrameCount > KeyVars.MAXOVERFLOW)
            {
                thescoreboard.subtractFromScore(KeyVars.LATE_CLICK_PENALTY);
                resetTimer();
            }
        }
    }

    public void resetTimer()
    {
        overallGameStats.reportStatistic(timerId, overflowFrameCount);
        frameCount = overflowFrameCount;

        progBar.Value = (frameCount * 100) / fullBarFrameCount;
        overflowFrameCount = 0;

        progBar.ForeColor = Color.Green;
    }

    // The function that handles what the button does on the click
    private void onClick(object sender, EventArgs e)
    {
        

        if (progBar.Value != 100)
        {
            thescoreboard.subtractFromScore(KeyVars.EARLY_CLICK_PENALTY);
        }
        else
        {
            thescoreboard.addToScore(
                (KeyVars.MAXOVERFLOW - overflowFrameCount) / KeyVars.SCORE_PRE_DIVISOR *
                KeyVars.SCORE_POST_MULTIPLIER);
            
            resetTimer();
            
        }
    }

    public static void initializeValidCoors()
    {
        for (int i = 20; i < KeyVars.DEFAULTWIDTH;
        i += (int)(KeyVars.TIMERWIDTH * KeyVars.STARTING_POINT_BOX_RATIO))
        {
            for (int j = 20; j < KeyVars.DEFAULTHEIGHT;
                j += (int)(KeyVars.TIMERHEIGHT * KeyVars.STARTING_POINT_BOX_RATIO))
            {
                pointsToPlaceTimer.Add(new Point(i, j));
            }
        }
    }




    // The progress bar

    private ProgressBar progBar;
    public ProgressBar getProgBar() { return progBar; }
    
    private int overflowFrameCount;
    
    public int frameCount;
    public int fullBarFrameCount;

    Random rnd;

    // Storing the overall scoreboard
    ScoreBoard thescoreboard;

    // Initialize the hashset of locations to place this
    static HashSet<Point> pointsToPlaceTimer = new HashSet<Point>();

    static int total_timer_count = 0;
    int timerId;

    GameStatistics overallGameStats;

}
