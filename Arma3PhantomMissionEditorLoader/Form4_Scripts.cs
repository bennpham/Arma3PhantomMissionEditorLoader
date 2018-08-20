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
		private const String SCRIPT_FHQ_MARKERPATROL = "fhq_markerPatrol.hpp";
		private const String SCRIPT_FOLDER_FHQ_MARKERPATROL = "FHQ_markerPatrol";
		private const String SCRIPT_FHQ_SAFEADDLOADOUT = "fhq_safeAddLoadout.hpp";
		private const String SCRIPT_FOLDER_FHQ_SAFEADDLOADOUT = "FHQ_safeAddLoadout";
		private const String SCRIPT_FHQ_TASKTRACKER = "fhq_tasktracker.hpp";
		private const String SCRIPT_FOLDER_FHQ_TASKTRACKER = "FHQ_tasktracker";

		private String missionDirectory;

		public Form4_Scripts(String missionDirectory)
		{
			InitializeComponent();
			this.missionDirectory = missionDirectory;
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
				sw.WriteLine("class FHQ");
				sw.WriteLine("{");

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

				// Generate FHQ Task Tracker by default
				sw.WriteLine("	#include \"fhq_tasktracker.hpp\"");
				generateScript(SCRIPT_FHQ_TASKTRACKER, SCRIPT_FOLDER_FHQ_TASKTRACKER);

				sw.WriteLine("};");
			}

			// Go to Form 5 Debriefing Page
			this.Hide(); 
			Form5_Debrief new_form = new Form5_Debrief(this.missionDirectory); 
			new_form.ShowDialog(); 
		}

		private void generateScript(String script, String scriptFolder)
		{
			System.IO.File.Copy(System.IO.Path.Combine(FOLDER_FUNCTION, script),
				System.IO.Path.Combine(this.missionDirectory, FOLDER_FUNCTION, script));
			Helper.copyDirectory(System.IO.Path.Combine(FOLDER_FUNCTION, scriptFolder),
				System.IO.Path.Combine(this.missionDirectory, FOLDER_FUNCTION, scriptFolder));
		}
	}
}
