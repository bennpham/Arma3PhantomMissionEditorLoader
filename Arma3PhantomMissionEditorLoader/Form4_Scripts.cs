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
	public partial class Form4_Scripts : Form
	{
		// Constants
		private const String FOLDER_FUNCTION = "functions";
		private const String COMMON_HPP = "common.hpp";

		// Constants Scripts to Choose
		private const String SCRIPT_FHQ_FORCETRACKER = "fhq_forcetracker.hpp";
		private const String SCRIPT_FOLDER_FHQ_FORCETRACKER = "FHQ_forcetracker";
		private const String SCRIPT_FHQ_MARKERPATROL = "fhq_markerPatrol.hpp";
		private const String SCRIPT_FOLDER_FHQ_MARKERPATROL = "FHQ_markerPatrol";
		private const String SCRIPT_FHQ_SAFEADDLOADOUT = "fhq_safeAddLoadout.hpp";
		private const String SCRIPT_FOLDER_FHQ_SAFEADDLOADOUT = "FHQ_safeAddLoadout";
		private const String SCRIPT_FHQ_TASKTRACKER = "fhq_tasktracker.hpp";
		private const String SCRIPT_FOLDER_FHQ_TASKTRACKER = "FHQ_tasktracker";
		private const String SCRIPT_FHQ_WEATHEREFFECT = "fhq_weatherEffect.hpp";
		private const String SCRIPT_FHQ_WEATHEREFFECT_FSM = "weatherEffects.fsm";
		private const String SCRIPT_FOLDER_FHQ_WEATHEREFFECT = "FHQ_WeatherEffect";
		private const String SCRIPT_FOLDER_TAW_VD = "taw_vd";

		private String missionDirectory;
		private Dictionary<String, Object> parameters;

		public Form4_Scripts(String missionDirectory, Dictionary<String, Object> parameters)
		{
			InitializeComponent();
			this.missionDirectory = missionDirectory;
			this.parameters = parameters;
		}

		private void scripts_button_Click(object sender, EventArgs e)
		{
			// Create functions folder to put scripts in
			System.IO.Directory.CreateDirectory(System.IO.Path.Combine(this.missionDirectory, FOLDER_FUNCTION));

			using (System.IO.StreamWriter sw = new System.IO.StreamWriter(System.IO.Path.Combine(this.missionDirectory, FOLDER_FUNCTION, COMMON_HPP)))
			{
				// Initialize Default common.hpp
				sw.WriteLine("#define INTERNAL_FUNCTION(x)				\\");
				sw.WriteLine("	class x									\\");
				sw.WriteLine("	{										\\");
				sw.WriteLine("		description = \"Internal Function\";	\\");
				sw.WriteLine("	};");
				sw.WriteLine("");
				sw.WriteLine("#define EXPORTED_FUNCTION(x,y)				\\");
				sw.WriteLine("	class x									\\");
				sw.WriteLine("	{										\\");
				sw.WriteLine("		description = y;					\\");
				sw.WriteLine("	};");
				sw.WriteLine("");
				
				// Generate TAW View Distance
				if (TAW_view_distance_checkbox.Checked)
				{
					sw.WriteLine("#include \"taw_vd\\CfgFunctions.hpp\"");
					sw.WriteLine("");
					copyFolder(SCRIPT_FOLDER_TAW_VD);
				}

				sw.WriteLine("class FHQ");
				sw.WriteLine("{");

				// Generate FHQ Force Tracker
				if (FHQ_force_tracker_checkbox.Checked)
				{
					sw.WriteLine("	#include \"fhq_forcetracker.hpp\"");
					generateScript(SCRIPT_FHQ_FORCETRACKER, SCRIPT_FOLDER_FHQ_FORCETRACKER);
				}

				// Generate FHQ Marker Patrol
				if (FHQ_marker_patrol_checkbox.Checked)
				{
					sw.WriteLine("	#include \"fhq_markerPatrol.hpp\"");
					generateScript(SCRIPT_FHQ_MARKERPATROL, SCRIPT_FOLDER_FHQ_MARKERPATROL);
				}

				// Generate FHQ Safe Add Loadout
				if (FHQ_safe_add_loadout_checkbox.Checked)
				{
					sw.WriteLine("	#include \"fhq_safeAddLoadout.hpp\"");
					generateScript(SCRIPT_FHQ_SAFEADDLOADOUT, SCRIPT_FOLDER_FHQ_SAFEADDLOADOUT);
				}

				// Generate FHQ Weather Effect
				if (FHQ_weather_effect_checkbox.Checked)
				{
					sw.WriteLine("	#include \"fhq_weatherEffect.hpp\"");
					generateScript(SCRIPT_FHQ_WEATHEREFFECT, SCRIPT_FOLDER_FHQ_WEATHEREFFECT);
					copyFile(SCRIPT_FHQ_WEATHEREFFECT_FSM);
				}

				// Generate FHQ Task Tracker by default
				sw.WriteLine("	#include \"fhq_tasktracker.hpp\"");
				generateScript(SCRIPT_FHQ_TASKTRACKER, SCRIPT_FOLDER_FHQ_TASKTRACKER);

				sw.WriteLine("};");
			}

			// Load parameters to add into init if needed
			if (FHQ_detected_by_checkbox.Checked)
			{
				this.parameters.Add("init_FHQ_Detected_By", 
					"// FHQ detection script\n" +
					"FHQ_fnc_detectedBy = {\n" +
					"	private _detectList = _this select 0;\n" +
					"	private _triggerList = _this select 1;\n" +
					"\n" +
					"	private _knowledge = 0;" +
					"\n" +
					"	{\n" +
					"		private _unit = _x;\n" +
					"		if (alive _unit) then {\n" +
					"			_knowledge = _knowledge + ({(_unit knowsAbout _x) > 0} count _detectList);\n" +
					"		};\n" +
					"	} forEach _triggerList;\n" +
					"\n" +
					"	_knowledge > 0\n" +
					"};");
			}
			if (FHQ_weather_effect_checkbox.Checked)
			{
				this.parameters.Add("init_FHQ_Weather_Script", "call compile preProcessFileLineNumbers \"scripts\\weatherScript.sqf\";");
			}
			if (TAW_view_distance_checkbox.Checked)
			{
				this.parameters.Add("init_TAW_View_Distance", new List<String>());
			}

			// Go to Form 5 Debriefing Page or scripts settings
			this.Hide();
			if (FHQ_weather_effect_checkbox.Checked)
			{
				Form4a_FHQ_Weather_Effect new_form = new Form4a_FHQ_Weather_Effect(this.missionDirectory, this.parameters);
				new_form.ShowDialog();
			}
			else
			{
				Form5_Debrief new_form = new Form5_Debrief(this.missionDirectory, this.parameters);
				new_form.ShowDialog();
			}
		}

		private void generateScript(String script, String scriptFolder)
		{
			copyFile(script);
			copyFolder(scriptFolder);
		}

		private void copyFile(String file)
		{
			System.IO.File.Copy(System.IO.Path.Combine(FOLDER_FUNCTION, file),
				System.IO.Path.Combine(this.missionDirectory, FOLDER_FUNCTION, file));
		}

		private void copyFolder(String folder)
		{
			Helper.copyDirectory(System.IO.Path.Combine(FOLDER_FUNCTION, folder),
				System.IO.Path.Combine(this.missionDirectory, FOLDER_FUNCTION, folder));
		}
	}
}
