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
	public partial class Form5_Debrief : Form
	{
		// Constants
		private const String DEBRIEFING = "debriefing.hpp";
		private const String DESCRIPTION = "description.ext";
		private const String INIT = "init.sqf";

		private String missionDirectory;
		private HashSet<String> classNames;
		private Dictionary<String, Object> parameters;

		public Form5_Debrief(String missionDirectory, Dictionary<String, Object> parameters)
		{
			InitializeComponent();
			this.missionDirectory = missionDirectory;
			this.parameters = parameters;
			classNames = new HashSet<string>();
		}

		private void button_add_Click(object sender, EventArgs e)
		{
			System.Text.RegularExpressions.Regex alphanumeric = new System.Text.RegularExpressions.Regex("^[a-zA-Z0-9]*$");

			if (String.IsNullOrWhiteSpace(textbox_classname.Text))
			{
				MessageBox.Show("ERROR: Please fill in a classname!",
					"Empty ClassName",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (!alphanumeric.IsMatch(textbox_classname.Text))
			{
				MessageBox.Show("ERROR: Classnames can only be alphanumeric.",
					"Classname Contains Invalid Characters",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (this.classNames.Contains(textbox_classname.Text.Trim()))
			{
				MessageBox.Show("ERROR: " + textbox_classname.Text + " classname already exists! Please try a different name.", 
					"Classname Already Exist", 
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			// Note: No sanitizing picture Background for now. So either use existing loadscreen.jpg or get the path right.
			else
			{
				this.classNames.Add(textbox_classname.Text.Trim());

				using (System.IO.StreamWriter sw = new System.IO.StreamWriter(System.IO.Path.Combine(this.missionDirectory, DEBRIEFING), true))
				{
					sw.WriteLine("class " + textbox_classname.Text.Trim());
					sw.WriteLine("{");
					sw.WriteLine("	title = \"" + textbox_title.Text.Replace("\"", "\"\"") + "\";");
					sw.WriteLine("	subtitle = \"" + textbox_subtitle.Text.Replace("\"", "\"\"") + "\";");
					sw.WriteLine("	description = \"" + textbox_description.Text.Replace("\"", "\"\"").Replace(Environment.NewLine, " ") + "\";");
					sw.WriteLine("	pictureBackground = \"" + textbox_pictureBackground.Text + "\";");
					sw.WriteLine("}");
					sw.WriteLine("");
				}
			}
		}

		private void button_win_Click(object sender, EventArgs e)
		{
			textbox_classname.Text = "Win";
			textbox_title.Text = "Mission Accomplished";
		}

		private void button_lose_Click(object sender, EventArgs e)
		{
			textbox_classname.Text = "Lose";
			textbox_title.Text = "Mission Failed";
		}

		private void button_complete_Click(object sender, EventArgs e)
		{
			// Write description.ext
			writeDescriptionExt();

			// Write init.sqf
			writeInitSqf();

			// Go to Form 6 Briefing Page
			this.Hide();
			Form6_Briefing new_form = new Form6_Briefing(this.missionDirectory);
			new_form.ShowDialog();
		}

		private void writeDescriptionExt()
		{
			using (System.IO.StreamWriter sw = new System.IO.StreamWriter(System.IO.Path.Combine(this.missionDirectory, DESCRIPTION)))
			{
				Dictionary<String, Object> parameters = (Dictionary<String, Object>) this.parameters["description"];

				sw.WriteLine("overviewPicture = \"images\\loadscreen.jpg\";");
				sw.WriteLine("author=\"" + parameters["author"].ToString() + "\";");
				sw.WriteLine("loadScreen = \"images\\loadscreen.jpg\";");
				sw.WriteLine(parameters["onLoadName"].ToString());
				sw.WriteLine(parameters["onLoadMission"].ToString());
				sw.WriteLine("debriefing = 1;");
				sw.WriteLine("");
				sw.WriteLine("allowFunctionsRecompile = 1;");
				sw.WriteLine("");
				sw.WriteLine("class Header");
				sw.WriteLine("{");
				sw.WriteLine("  gameType = Coop;");
				sw.WriteLine("  minPlayers = " + parameters["minPlayers"].ToString() + ";");
				sw.WriteLine("  maxPlayers = " + parameters["maxPlayers"].ToString() + ";");
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
				if (this.parameters.ContainsKey("init_TAW_View_Distance"))
				{
					sw.WriteLine("#include \"functions\\taw_vd\\GUI.h\"");
				}
				sw.WriteLine("class CfgFunctions {");
				sw.WriteLine("	#include \"functions\\common.hpp\"");
				sw.WriteLine("};");
				if ((bool)parameters["descriptionParams"])
				{
					sw.WriteLine("");
					sw.WriteLine("class Params");
					sw.WriteLine("{");
					sw.WriteLine("	#include \"scripts\\parameters.hpp\"");
					sw.WriteLine("};");
				}
				if ((bool)parameters["descriptionLoadout"])
				{
					sw.WriteLine("");
					sw.WriteLine("#include \"scripts\\briefing_loadout.hpp\"");
				}
			}
		}

		private void writeInitSqf()
		{
			using (System.IO.StreamWriter sw = new System.IO.StreamWriter(System.IO.Path.Combine(this.missionDirectory, INIT)))
			{
				sw.WriteLine("call compile preProcessFileLineNumbers \"scripts\\briefing.sqf\";");
				if (this.parameters.ContainsKey("init_FHQ_Detected_By"))
				{
					sw.WriteLine("");
					sw.WriteLine((String)this.parameters["init_FHQ_Detected_By"]);
				}
				if (this.parameters.ContainsKey("init_TAW_View_Distance"))
				{
					sw.WriteLine("");
					sw.Write(this.parameters["init_TAW_View_Distance"].ToString());
				}
				if ((bool)this.parameters["description_params"])
				{
					sw.WriteLine("");
					sw.WriteLine("// Singleplayer handling");
					sw.WriteLine("if (!isMultiplayer) then {");
					sw.WriteLine("	// TODO");
					sw.WriteLine("};");
					sw.WriteLine("");
					sw.WriteLine("// Scaled Multiplayer handling for small player count");
					sw.WriteLine("_ScalePlayers = \"ScalePlayers\" call BIS_fnc_getParamValue;");
					sw.WriteLine("if (_ScalePlayers == 1 && isServer && isMultiplayer) then {");
					sw.WriteLine("	// TODO");
					sw.WriteLine("};");
					sw.WriteLine("");
					sw.WriteLine("// Fullhouse Multiplayer Handling");
					sw.WriteLine("if (_ScalePlayers == 0 && isServer && isMultiplayer) then {");
					sw.WriteLine("	// TODO");
					sw.WriteLine("};");
				}
				if ((bool)this.parameters["init_zeus"])
				{
					sw.WriteLine("");
					sw.WriteLine("// Initialize stuff for Zeus on server");
					sw.WriteLine("if (isMultiplayer && isServer) then {");
					sw.WriteLine("	{zeus_mod1 addCuratorEditableObjects [[_x],true]} forEach allUnits;");
					sw.WriteLine("	{zeus_mod2 addCuratorEditableObjects [[_x],true]} forEach allUnits;");
					sw.WriteLine("	{zeus_mod3 addCuratorEditableObjects [[_x],true]} forEach allUnits;");
					sw.WriteLine("};");
				}
				sw.WriteLine("");
				if (this.parameters.ContainsKey("FHQ_Weather_Script"))
				{
					sw.WriteLine("call compile preProcessFileLineNumbers \"scripts\\weatherScript.sqf\";");
				}
				sw.WriteLine("call compile preProcessFileLineNumbers \"scripts\\infotext.sqf\";");
			}
		}
	}
}
