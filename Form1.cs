using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace COGS_Final
{


    public partial class Form1 : Form
    {
        public int frameCount = 0;

        List<Counter> counterList = new List<Counter>();

        Random rnd = new Random();

        

        int framesTimerLasts;

        // An integer for keeping track of the round number
        int roundNumber = 1;

        public bool playingGame = true;

        // A varibale to know what frame to spawn the next timer
        int frameToSpawnTimer = -1;

        // Keep track of what frame we spawn on so two timers dont go off simultaneously
        static HashSet<int> validFramesToSpawn = new HashSet<int>();

        ScoreBoard scoreSystem;

        GameStatistics gameStatistics;

        public Form1()
        {
            // Set the size to a default
            InitializeComponent();

            scoringlabel.Location = new Point(KeyVars.DEFAULTWIDTH + 200, KeyVars.DEFAULTHEIGHT + 150);

            scoreSystem = new ScoreBoard(scoringlabel);

            gameStatistics = new GameStatistics();

            // Set up the valid Frames to Spawn

            int timeOnTimer = rnd.Next(3500, 4500);
            framesTimerLasts = timeToFrames(timeOnTimer);

            // Put all the valid frames we can spawn in the hashset
            for (int i = KeyVars.SPAWN_FRAME_DIFFERENCE; i < framesTimerLasts - KeyVars.SPAWN_FRAME_DIFFERENCE; ++i)
            {
                validFramesToSpawn.Add(i);
            }

            // Set the valid coordinates we can spawn
            Counter.initializeValidCoors();

            SpawnNewTimer();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Increment the frame counter
            ++frameCount;

            if (roundNumber == KeyVars.NUMBER_OF_ROUNDS && frameCount == framesTimerLasts + KeyVars.MAXOVERFLOW+3)
            {
                StatisticsPage.prevGameStats = gameStatistics;
                StatisticsPage statsForm = new StatisticsPage();

                statsForm.Show();

                this.Close();
                timer1.Enabled = false;
            }

            // A full round is how long two timers last
            if (frameCount == framesTimerLasts * (2))
            {
                frameCount = 0; 
                ++roundNumber;

                frameToSpawnTimer = generateFrameToSpawn();
            }

            foreach (Counter timer in counterList)
            {
                timer.incrementTime();
            }
            
            if (frameCount == frameToSpawnTimer)
            {
                SpawnNewTimer();
            }
            
        }


        private void SpawnNewTimer()
        {

            Counter newCounter = new Counter(rnd, scoreSystem, framesTimerLasts, gameStatistics);
            this.Controls.Add(newCounter.getProgBar());

            counterList.Add(newCounter);
        }

        // @time is the time to convert in MS
        // Assume 60 frames / s
        private int timeToFrames(int time)
        {
            return time / 1000 * 60;
        }

        private int generateFrameToSpawn()
        {

            int frameToSpawn = validFramesToSpawn.ElementAt(rnd.Next(0, validFramesToSpawn.Count()));

            int start = KeyVars.SPAWN_FRAME_DIFFERENCE;
            int end = framesTimerLasts - KeyVars.SPAWN_FRAME_DIFFERENCE;

            if (start < frameToSpawn - KeyVars.SPAWN_FRAME_DIFFERENCE)
            {
                start = frameToSpawn - KeyVars.SPAWN_FRAME_DIFFERENCE;
            }
            if (end > frameToSpawn + KeyVars.SPAWN_FRAME_DIFFERENCE)
            {
                end = frameToSpawn + KeyVars.SPAWN_FRAME_DIFFERENCE;
            }
            
            for (int i = start; i<end; ++i)
            {
                validFramesToSpawn.Remove(i);
            }
            return frameToSpawn;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}
