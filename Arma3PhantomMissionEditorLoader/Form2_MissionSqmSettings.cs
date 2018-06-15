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
	public partial class Form2_MissionSqmSettings : Form
	{
		private const String MISSION_SQM_BACKUP = "mission.sqm.old";
		private readonly String[] LIST_SCENARIO_DATA = {
			"author", "overviewText", "overViewPicture", "onLoadMission", "loadScreen", "class Header"
		}; 
		private readonly String[] LIST_CUSTOM_ATTRIBUTES = {
			"class Category", "name=\"Multiplayer\";", "property=\"RespawnTemplates\";"
		}; 
		private readonly String[] LIST_INTEL = {
			"overviewText",
			"resistanceWest", "resistanceEast",
			"timeOfChanges",
			"startWeather", "startFog", "forecastWeather", "forecastFog",
			"year", "day", "hour", "minute", 
			"startFogBase", "forecastFogBase", "startFogDecay", "forecastFogDecay"
		}; 

		private String missionSQM;
		private String missionDirectory;

		// Check to see if all sections of mission.sqm is handled (ScenarioData, CustomAttributes, Intel)
		private bool isHandledScenarioData;
		private bool isHandledCustomAttributes;
		private bool isHandledIntel;

		public Form2_MissionSqmSettings(String missionSQM, String missionDirectory)
		{
			InitializeComponent();
			this.missionSQM = missionSQM;
			this.missionDirectory = missionDirectory;

			isHandledScenarioData = false;
			isHandledCustomAttributes = false;
			isHandledIntel = false;
		}

		private void missionsqm_button_Click(object sender, EventArgs e)
		{
			String oldMissionSqm = System.IO.Path.Combine(this.missionDirectory, MISSION_SQM_BACKUP);

			// Rename old mission.sqm to mission.sqm.old in case file gets corrupted
			System.IO.File.Move(this.missionSQM, oldMissionSqm);
			
			// Setup mission.sqm settings from extracted settings above 
			String line = null;
			using (System.IO.StreamReader sr = new System.IO.StreamReader(oldMissionSqm))
			{
				using (System.IO.StreamWriter sw = new System.IO.StreamWriter(this.missionSQM))
				{
					bool editingScenarioData = false;
					bool editingCustomAttributes = false;
					bool editingIntel = false;

					while ((line = sr.ReadLine()) != null)
					{
						if (editingScenarioData || editingCustomAttributes || editingIntel)
						{
							sw.WriteLine(line); // Writes open bracket to mission.sqm

							while (editingScenarioData && (line = sr.ReadLine()) != null)
							{
								isHandledScenarioData = true;
							}
							while (editingCustomAttributes && (line = sr.ReadLine()) != null)
							{
								isHandledCustomAttributes = true;
							}
							while (editingIntel && (line = sr.ReadLine()) != null)
							{
								isHandledIntel = true;
							}
						}
						else if (line.Contains("class ScenarioData"))
						{
							editingScenarioData = true;
						}
						else if (line.Contains("class CustomAttributes"))
						{
							editingCustomAttributes = true;
						}
						else if (line.Contains("	class Intel"))
						{
							editingIntel = true;
						}

						sw.WriteLine(line);	
					}
				}
			}

			// GoTo Generate infotext Form
			//		Pick Name of Mission to Display (already have date and Author)
			Environment.Exit(0); // TODO placeholder
		}
	}
}
