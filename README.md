# Arma 3 Phantom Mission Editor Loader

<p align="center">
<a href="https://github.com/bennpham/Arma3PhantomMissionEditorLoader/releases/tag/v1.2.0"><img src="https://img.shields.io/badge/Version-1.2.0-blue.svg" alt="Download Mission Loader" /></a>
</p>

An application to modify my Arma 3 <b>mission.sqm</b> file to set the settings that I need in one go and generate some basic scripts to help me focus on unit placement and making the missions rather than copying over the same files for my template and modifying them separately instead.

## Usage
### Getting Started
* Create a new mission in Arma 3 mission
* Unbinarize your mission and save it
* Make sure only the <b>mission.sqm</b> is inside the folder
* Run the Mission Editor Loader and select the path to your new mission folder that contains just the unbinarize <b>mission.sqm</b> file and click new
### Editing Mission.sqm
* Fill out all of the information on the first form that appears
* This form should modify some information on your <b>mission.sqm</b> and <b>description.ext</b> including author information, mission overview text, Multiplayer settings, mission summary, weather settings, and etc.
* By default, this application is <b>SIDE</b> respawn only and is meant for no respawn/revive type of coop gameplay.
* Click okay when you are done
### Editing Description.ext & Infotext Script
* Check off <b>Description Params (Player Count Scale)</b> if you want in game parameters to scale units or other settings for the players in game.
	* You'll need to do that manually through the <b>init.sqf</b> or <b>triggers</b>
* Check off <b>Description Params (FHQ Difficulty)</b> if you want to delete units base on MP difficulty settings.
	* You can do that manually or use [FHQ Eden Tool](http://ciahome.net/forum/showthread.php?tid=3935) which is highly recommended for this step.
* Check out <b>Description Loadout</b> if you want to setup briefing loadouts.
	* This is for Singleplayer only and you'll have to handle those manually in <b>scripts/briefing_loadout.hpp</b>.
* Check off <b>Init ACE Extra</b> if you want to add extra equipment to units, vehicles, or ammoboxes if the server or player has ACE loaded.
	* You'll need to do that manually in the ACE condition block in <b>init.sqf</b>.
	* You'll also want to refer to [ACE 3 Mod Classname Wiki](https://ace3mod.com/wiki/class-names.html).
* Check off <b>Init Zeus</b> if you want to have all units placed in the editor is controllable by zeus players.
	* You can place 3 zeus slots named `zeus_mod1`, `zeus_mod2`, `zeus_mod3` yourself or you can place them in via my mission composition.
* The default info text will display the date and time, followed by the text you inputted in the text box, then your name (as the author)
### Scripts to Enable
* By default, FHQ TaskTracker will always be enabled.
* You can choose to enable additional scripts here.
* If you need help on additional setup for any of the scripts or description parameters that requires it, refer to [the setup guide](https://github.com/bennpham/Arma3PhantomMissionEditorLoader/blob/master/SETUP.md).
* The following parameters will require additional setup:
	* Description Params (Player Count Scale)
	* Description Params (FHQ Difficulty)
	* Description Loadout (Singleplayer Only)
	* Init ACE Extra
	* FHQ Detected By
	* FHQ Force Tracker
	* FHQ Marker Patrol
	* FHQ Safe Add Loadout

### Debriefing Editor
* This setups the <b>debriefing</b> section of <b>description.ext</b> and is located in <b>debriefing.hpp</b>
* You can setup the default class name (they must be unique) for win or lose condition or any other custom conditions you have for how your mission can end
### Briefing Editor
* Writes the briefing title and description that'll be loaded by FHQ Task Tracker
* You can also use <b>Text</b>, <b>Color</b>, or <b>Marker</b> to customize briefing description marker and text color
### Briefing Task Editor
* Writes the briefing task that'll be loaded by FHQ Task Tracker
* Task Name must be unique (I recommend naming something like task1, task2, ... taskN)
* You can also use <b>Text</b>, <b>Color</b>, or <b>Marker</b> to customize task description marker and text color
* Only 1 task state can be assigned
### Final Notes
* When everything is good and done, feel free to delete your <b>mission.sqm.old</b> and re-binarize your <b>mission.sqm</b>.

## Notes
* If you break your <b>mission.sqm</b> in any way, you can delete it and rename the <b>mission.sqm.old</b> (which is the backup of your old <b>mission.sqm</b> before editing)
* If you made a few mistakes with your initial setups with using this tool, you can manually go back and change them in the mission editor if it is a weather setting or other setting in game OR open the files that you would like to modify with your favorite text editor.

## Credits
* <a href="http://ciahome.net/">Comrades in Arms</a>
* Varanon & Alwarren for FHQ scripts
