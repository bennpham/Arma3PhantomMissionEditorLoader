using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arma3PhantomMissionEditorLoader
{
	public partial class Form3_Description : Form
	{
		private const String DESCRIPTION = "description.ext";
		private const String INIT = "init.sqf";

		private const String FOLDER_SCRIPTS = "scripts";
		private const String INFOTEXT = "infotext.sqf";
		private const String PARAMETERS = "parameters.hpp";
		private const String BRIEFING_LOADOUT = "briefing_loadout.hpp";

		// Info Text information
		private String missionDirectory;
		private String date;
		private String hour;
		private String minute;
		private String author;

		// Description ext information
		private String onLoadName;
		private String onLoadMission;
		private String minPlayers;
		private String maxPlayers;

		public Form3_Description(String missionDirectory, String date, String hour, String minute, String author, 
			String onLoadName, String onLoadMission, String minPlayers, String maxPlayers)
		{
			InitializeComponent();
			this.missionDirectory = missionDirectory;
			this.date = date;
			this.hour = hour;
			this.minute = minute;
			this.author = author;

			this.onLoadName = onLoadName;
			this.onLoadMission = onLoadMission;
			this.minPlayers = minPlayers;
			this.maxPlayers = maxPlayers;

			initializeInformation();
		}

		private void description_button_Click(object sender, EventArgs e)
		{
			// Write description.ext
			writeDescriptionExt();

			// Create scripts folder 
			System.IO.Directory.CreateDirectory(System.IO.Path.Combine(this.missionDirectory, FOLDER_SCRIPTS));

			// Write infoText
			writeInfoText();

			Environment.Exit(0); // TODO Placeholder
		}

		/* Initialize Date and Author */
		private void initializeInformation()
		{
			this.label_datetime.Text = this.date + " | " + this.hour + ":" + this.minute + ":00";
			this.label_created_by.Text = "Created By " + this.author;
		}

		private void writeDescriptionExt()
		{
			using (System.IO.StreamWriter sw = new System.IO.StreamWriter(System.IO.Path.Combine(this.missionDirectory, DESCRIPTION)))
			{
				sw.WriteLine("overviewPicture = \"images\\loadscreen.jpg\";");
				sw.WriteLine("author=\"" + this.author + "\";");
				sw.WriteLine("loadScreen = \"images\\loadscreen.jpg\";");
				sw.WriteLine(this.onLoadName);
				sw.WriteLine(this.onLoadMission);
				sw.WriteLine("debriefing = 1;");
				sw.WriteLine("");
				sw.WriteLine("allowFunctionsRecompile = 1;");
				sw.WriteLine("");
				sw.WriteLine("class Header");
				sw.WriteLine("{");
				sw.WriteLine("  gameType = Coop;");
				sw.WriteLine("  minPlayers = " + this.minPlayers + ";");
				sw.WriteLine("  maxPlayers = " + this.maxPlayers + ";");
				sw.WriteLine("  playerCountMultipleOf = 1;");
				sw.WriteLine("};");
				sw.WriteLine("");
				sw.WriteLine("respawn = \"SIDE\";");
				sw.WriteLine("respawnDelay = 5;");
				sw.WriteLine("");
				sw.WriteLine("class CfgDebriefing");
				sw.WriteLine("{");
				sw.WriteLine("	#include \"debriefing.hpp\"");
				sw.WriteLine("};");
				sw.WriteLine("");
				sw.WriteLine("class CfgFunctions {");
				sw.WriteLine("	#include \"functions\\common.hpp\"");
				sw.WriteLine("};");
				if (description_params_checkbox.Checked)
				{
					sw.WriteLine("");
					sw.WriteLine("class Params");
					sw.WriteLine("{");
					sw.WriteLine("	#include \"scripts\\parameters.hpp\"");
					sw.WriteLine("};");
				}
				if (description_loadout_checkbox.Checked)
				{
					sw.WriteLine("");
					sw.WriteLine("#include \"scripts\\briefing_loadout.hpp\"");
				}
			}
		}

		private void writeInfoText()
		{
			using (System.IO.StreamWriter sw = new System.IO.StreamWriter(System.IO.Path.Combine(this.missionDirectory, FOLDER_SCRIPTS, INFOTEXT)))
			{
				sw.WriteLine("waitUntil{!(isNil \"BIS_fnc_init\")};");
				sw.WriteLine("sleep 15;");
				sw.WriteLine("	[\"" + this.date + "\", \"" + this.hour + ":" + this.minute + ":00\"] call BIS_fnc_infoText;");
				sw.WriteLine("sleep 3;");
				sw.WriteLine("	" + parseInfoTextTitle() + " call BIS_fnc_infoText;"); 
				sw.WriteLine("sleep 3;");
				sw.WriteLine("	[\"Created by\"," + this.author + "] call BIS_fnc_infoText;");
			}
		}

		private String parseInfoTextTitle()
		{
			String infoTextResult = "[";
			String[] infoTextTitles = infotext_title.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
			foreach (String infoTextTitle in infoTextTitles)
			{
				String infoTextTitleWithQuotes = "\"" + infoTextTitle + "\"";
				infoTextResult += infoTextResult.Equals("[") ? infoTextTitleWithQuotes : ", " + infoTextTitleWithQuotes;
			}
			infoTextResult += "]";

			return infoTextResult;
		}
	}
}
