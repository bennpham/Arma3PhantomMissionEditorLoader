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
		private const String FOLDER_SCRIPTS = "scripts";
		private const String INFOTEXT = "infotext.sqf";
		private const String BRIEFING = "briefing.sqf";
		private const String DEBRIEFING = "debriefing.hpp";
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

		// Parameters to set init.sqf later
		private Dictionary<String, Object> parameters;

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
			// Set parameters information once button is click to get checkbox latest state
			this.parameters = new Dictionary<String, Object>
			{
				{"description_params", description_params_checkbox.Checked},
				{"init_zeus", init_zeus_checkbox.Checked},
				{"description", new Dictionary<String, Object>
					{
						{"author", author},
						{"onLoadName", onLoadName},
						{"onLoadMission", onLoadMission},
						{"minPlayers", minPlayers},
						{"maxPlayers", maxPlayers},
						{"descriptionParams", description_params_checkbox.Checked},
						{"descriptionLoadout", description_loadout_checkbox.Checked}
					}
				}
			};

			// Create scripts folder 
			System.IO.Directory.CreateDirectory(System.IO.Path.Combine(this.missionDirectory, FOLDER_SCRIPTS));

			// Write infoText
			writeInfoText();

			// Create empty briefing.sqf & debriefing.hpp
			using (System.IO.StreamWriter sw = new System.IO.StreamWriter(System.IO.Path.Combine(this.missionDirectory, FOLDER_SCRIPTS, BRIEFING))) { }
			using (System.IO.StreamWriter sw = new System.IO.StreamWriter(System.IO.Path.Combine(this.missionDirectory, DEBRIEFING))) { }

			// Create parameters.hpp (if available)
			writeParametersHPP();

			// Create briefing_loadout.hpp (if available)
			writeBriefingLoadout();

			// GoTo Scripts Selector Page
			this.Hide();
			Form4_Scripts form4_scripts = new Form4_Scripts(this.missionDirectory, this.parameters);
			form4_scripts.ShowDialog();
		}

		/* Initialize Date and Author */
		private void initializeInformation()
		{
			this.label_datetime.Text = this.date + " | " + this.hour + ":" + this.minute + ":00";
			this.label_created_by.Text = "Created By " + this.author;
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
				sw.WriteLine("	[\"Created by\"," + "\"" + this.author + "\"] call BIS_fnc_infoText;");
			}
		}

		private void writeParametersHPP()
		{
			if (description_params_checkbox.Checked)
			{
				using (System.IO.StreamWriter sw = new System.IO.StreamWriter(System.IO.Path.Combine(this.missionDirectory, FOLDER_SCRIPTS, PARAMETERS)))
				{
					sw.WriteLine("class ScalePlayers");
					sw.WriteLine("{");
					sw.WriteLine("	title = \"Low Player Count Scale Mode\";");
					sw.WriteLine("	values[] = {0, 1};");
					sw.WriteLine("	texts[] = {\"Disable\", \"Enable\"};");
					sw.WriteLine("	default = 0;");
					sw.WriteLine("};");
				}
			}
		}

		private void writeBriefingLoadout()
		{
			if (description_loadout_checkbox.Checked)
			{
				using (System.IO.StreamWriter sw = new System.IO.StreamWriter(System.IO.Path.Combine(this.missionDirectory, FOLDER_SCRIPTS, BRIEFING_LOADOUT))) {}
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
