using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfpLauncher.Lib;

namespace OfpLauncher
{
    public partial class frmServer : Form
    {
        public frmServer()
        {
            InitializeComponent();
        }

        private void frmServer_Load(object sender, EventArgs e)
        {
            // 
        }
    }
}

//Server Options
//Parameter	Default	Description
//hostname	""	Name of the server displayed in the server browser. If left empty then computer name is used.
//password	""	Password required to connect to the server.
//passwordAdmin	""	Password needed to log in as the server admin.
//reportingIP	"master.gamespy.com"	Address of the master server which makes your server public. Gamespy shutdown in 2014. Current community master server is master.ofpisnotdead.com
//motd[]  { } Messages displayed when player joins the server ("message of the day").
//motdInterval 5   Delay in seconds between motd[] messages.
//voteMissionPlayers  1   How many players must connect to the server before mission selection screen is displayed (where players can vote for a mission).
//voteThreshold 0.5 Percentage of votes needed to confirm a vote.
//maxPlayers	64	Maximum number of players that can connect to the server.
//kickDuplicate	0	Kick players with duplicated game ID (0 - disabled, 1 - enabled).
//equalModRequired 0   Reject players that did not launch the game with the same -mod= startup parameter as the server (0 - disabled, 1 - enabled).
//checkFiles[] { } List of files to check for the integrity CRC check. Message will appear if the file on client doesn't match the file on server. You may select files inside pbos. Beware of checking large files, which takes serious processing on the server and can cause various issues.
//voiceOverNet	1	Enable in-game voice communication (0 - disabled, 1 - enabled). It works only on DirectPlay which is not recommended to be used.
//Mission rotation
//Server can automatically select mission from a list if there is at least one player connected. Once the mission is done and if there are still players on the server, it will automatically switch to the next one in the cycle.

//The list is created by adding "class Missions" to the configuration. Each child class defines a mission.Their properties are as follows:

//Parameter Description
//template Mission file name (without.PBO extension) from the MPMissions folder.
//cadetMode Difficulty mode: 0 for Veteran or 1 for Cadet.
//param1 Default value for the mission's first parameter (defined in mission's description.ext)
//param2 Default value for the mission's second parameter (defined in mission's description.ext)