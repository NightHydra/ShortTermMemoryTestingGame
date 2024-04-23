using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


static class KeyVars
{
    // Default Screen Size
    public const int DEFAULTWIDTH = 800;
    public const int DEFAULTHEIGHT = 600;

    // How the timers look
    public const int TIMERWIDTH = 80;
    public const int TIMERHEIGHT = 40;

    // Somes defines dealing with the operation of each timer
    public const int MAXOVERFLOW = 80;

    // Restricting how many frames apart timers may go off
    public const int SPAWN_FRAME_DIFFERENCE = 5;

    // The ratio of the possible points of the big boxes to
    //     the timers
    public const double STARTING_POINT_BOX_RATIO = 1.2;

    // Score Pre-Divider
    public const int SCORE_PRE_DIVISOR = 3;

    public const int SCORE_POST_MULTIPLIER = 10;

    // Penaltys
    public const int EARLY_CLICK_PENALTY = 100;
    public const int LATE_CLICK_PENALTY = 300;

    // The number of rounds
    public const int NUMBER_OF_ROUNDS = 12;






}

