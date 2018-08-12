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
				sw.Write("#define INTERNAL_FUNCTION(x)				\\");
				sw.Write("	class x									\\");
				sw.Write("	{										\\");
				sw.Write("		description = \"Internal Function\";	\\");
				sw.Write("	};");
				sw.Write("");
				sw.Write("#define EXPORTED_FUNCTION(x,y)				\\");
				sw.Write("	class x									\\");
				sw.Write("	{										\\");
				sw.Write("		description = y;					\\");
				sw.Write("	};");
				sw.Write("");
				sw.Write("class FHQ");
				sw.Write("{");
				
				// Generate FHQ Task Tracker by default
				sw.Write("	#include \"fhq_tasktracker.hpp\"");
				generateScript_FHQ_TaskTracker();

				sw.Write("};");
			}

			Environment.Exit(0); // TODO Placeholder
		}

		private void generateScript_FHQ_TaskTracker()
		{
			System.IO.File.Copy(SCRIPT_FHQ_TASKTRACKER, System.IO.Path.Combine(this.missionDirectory, FOLDER_FUNCTION, SCRIPT_FHQ_TASKTRACKER));
			// TODO Copy Directory
		}
	}
}
