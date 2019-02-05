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
	public partial class Form4a_FHQ_Weather_Effect : Form
	{
		// Constants
		private const String WEATHER_SCRIPTS = "weatherScript.sqf";
		private const String FOLDER_SCRIPTS = "scripts";

		private String missionDirectory;
		private Dictionary<String, Object> parameters;
		private bool firstItemAdded;

		public Form4a_FHQ_Weather_Effect(String missionDirectory, Dictionary<String, Object> parameters)
		{
			InitializeComponent();
			this.missionDirectory = missionDirectory;
			this.parameters = parameters;
			firstItemAdded = false;
		}

		private void scripts_button_Click(object sender, EventArgs e)
		{
			using (System.IO.StreamWriter sw = new System.IO.StreamWriter(System.IO.Path.Combine(this.missionDirectory, FOLDER_SCRIPTS, WEATHER_SCRIPTS), true))
			{
				sw.WriteLine("if (hasInterface) then {");
				sw.WriteLine("    _handle = [");
				sw.WriteLine("        cameraOn,");
				sw.WriteLine("        [");
				if (fog_checkbox.Checked)
				{
					sw.Write("            [\"fog\", {true}]");
					firstItemAdded = true;
				}
				if (sand_checkbox.Checked)
				{
					if (firstItemAdded)
					{
						sw.WriteLine(",");
					}
					sw.Write("            [\"sand\", {true}]");
					firstItemAdded = true;
				}
				if (snow_checkbox.Checked)
				{
					if (firstItemAdded)
					{
						sw.WriteLine(",");
					}
					sw.Write("            [\"snow\", {true}]");
					firstItemAdded = true;
				}
				if (wind_checkbox.Checked)
				{
					if (firstItemAdded)
					{
						sw.WriteLine(",");
					}
					sw.Write("            [\"wind\", {true}]");
					firstItemAdded = true;
				}
				sw.WriteLine("");
				sw.WriteLine("        ]");
				sw.WriteLine("    ] call FHQ_fnc_weatherEffect;");
				sw.WriteLine("    FHQ_weather = _handle;");
				if (fog_checkbox.Checked)
				{
					sw.WriteLine("    [_handle, \"fogInterval\", " + fogInterval.Value.ToString() + "] call FHQ_fnc_setWeatherEffect;");
				}
				if (sand_checkbox.Checked)
				{
					sw.WriteLine("    [_handle, \"sandInterval\", " + sandInterval.Value.ToString() + "] call FHQ_fnc_setWeatherEffect;");
				}
				if (snow_checkbox.Checked)
				{
					sw.WriteLine("    [_handle, \"snowInterval\", " + snowInterval.Value.ToString() + "] call FHQ_fnc_setWeatherEffect;");
				}
				if (wind_checkbox.Checked)
				{
					sw.WriteLine("    [_handle, \"windInterval\", " + windInterval.Value.ToString() + "] call FHQ_fnc_setWeatherEffect;");
				}
				sw.WriteLine("};");
			}

			// Go to Form 5 or next Form 4 Scripts
			this.Hide();
			if (this.parameters.ContainsKey("TAW_View_Distance"))
			{
				Form4a_TAW_View_Distance new_form = new Form4a_TAW_View_Distance(this.missionDirectory, this.parameters);
				new_form.ShowDialog();
			}
			else
			{
				Form5_Debrief new_form = new Form5_Debrief(this.missionDirectory, this.parameters);
				new_form.ShowDialog();
			}
		}
	}
}
