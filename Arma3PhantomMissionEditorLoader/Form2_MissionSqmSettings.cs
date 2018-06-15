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

		private String missionSQM;
		private String missionDirectory;

		// Check to see if all sections of mission.sqm is handled (ScenarioData, CustomAttributes, Intel)
		private bool isHandledScenarioData;
		private bool isHandledCustomAttributes;
		private bool isHandledIntel;

		// Parameters for each sections of the mission.sqm (ScenarioData, CustomAttributes, Intel)
		//	If there are still any parameters that are not set, fill them in.
		private Dictionary<string, bool> scenarioDataDict;
		private Dictionary<string, bool> customAttributesDict;
		private Dictionary<string, bool> intelDict;

		public Form2_MissionSqmSettings(String missionSQM, String missionDirectory)
		{
			InitializeComponent();
			this.missionSQM = missionSQM;
			this.missionDirectory = missionDirectory;

			isHandledScenarioData = false;
			isHandledCustomAttributes = false;
			isHandledIntel = false;

			scenarioDataDict = new Dictionary<string, bool>()
			{
				{"author", false }, {"overviewText", false }, {"overViewPicture", false }, {"onLoadMission", false },
				{"loadScreen", false }, {"aIKills", false }, {"respawn", false }, {"class Header", false }
			};
			customAttributesDict = new Dictionary<string, bool>()
			{
				{"class Category" , false}, {"name=\"Multiplayer\";" , false}, {"property=\"RespawnTemplates\";", false}
			};
			intelDict = new Dictionary<string, bool>()
			{
				{"overviewText", false}, {"resistanceWest", false}, {"resistanceEast", false}, {"timeOfChanges", false},
				{"startWeather", false}, {"startFog", false}, {"forecastWeather", false}, {"forecastFog", false},
				{"year", false}, {"day", false}, {"hour", false}, {"minute", false},
				{"startFogBase", false}, {"forecastFogBase", false}, {"startFogDecay", false}, {"forecastFogDecay", false},
			};
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

								bool cmdNotAvail = true;
								foreach (String cmd in scenarioDataDict.Keys)
								{
									if (line.Contains(cmd))
									{
										cmdNotAvail = false;
										switch (cmd)
										{
											case "author":
												sw.WriteLine("	author=\"" + textbox_author.Text.Replace("\"", "\"\"") + "\";");
												break;
											case "overviewText":
												sw.WriteLine("	overviewText=\"" + textbox_overview_text.Text.Replace("\"", "\"\"") + "\";");
												break;
											case "overViewPicture":
												break;
											case "onLoadMission":
												break;
											case "loadScreen":
												break;
											case "aIKills":
												break;
											case "respawn":
												break;
											case "class Header":
												break;
										}
									}
								}
								if (cmdNotAvail)
								{
									sw.WriteLine(line);
								}
							}
							while (editingCustomAttributes && (line = sr.ReadLine()) != null)
							{
								isHandledCustomAttributes = true;

								bool cmdNotAvail = true;
								foreach (String cmd in customAttributesDict.Keys)
								{
									if (line.Contains(cmd))
									{
										cmdNotAvail = false;
										switch (cmd)
										{ 
											case "class Category":
												break;
											case "name=\"Multiplayer\";":
												break;
											case "property=\"RespawnTemplates\";":
												break;
										}
									}
								}
								if (cmdNotAvail)
								{
									sw.WriteLine(line);
								}
							}
							while (editingIntel && (line = sr.ReadLine()) != null)
							{
								isHandledIntel = true;

								bool cmdNotAvail = true;
								foreach (String cmd in intelDict.Keys)
								{
									if (line.Contains(cmd))
									{
										cmdNotAvail = false;
										switch (cmd)
										{
											case "overviewText":
												break;
											case "resistanceWest":
												break;
											case "resistanceEast":
												break;
											case "timeOfChanges":
												break;
											case "startWeather":
												break;
											case "startFog":
												break;
											case "forecastWeather":
												break;
											case "forecastFog":
												break;
											case "startFogBase":
												break;
											case "forecastFogBase":
												break;
											case "startFogDecay":
												break;
											case "forecastFogDecay":
												break;
											case "year":
												break;
											case "day":
												break;
											case "hour":
												break;
											case "minute":
												break;
										}
									}
								}
								if (cmdNotAvail)
								{
									sw.WriteLine(line);
								}
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
