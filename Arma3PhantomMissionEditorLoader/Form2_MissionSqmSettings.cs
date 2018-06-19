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
		private bool isHandledScenarioDataHeader;
		private bool isHandledCustomAttributes;
		private bool isHandledIntel;

		// Parameters for each sections of the mission.sqm (ScenarioData, CustomAttributes, Intel)
		//	If there are still any parameters that are not set, fill them in.
		private Dictionary<string, bool> scenarioDataDict;
		private Dictionary<string, bool> scenarioDataHeaderDict;
		private Dictionary<string, bool> customAttributesDict;
		private Dictionary<string, bool> intelDict;

		public Form2_MissionSqmSettings(String missionSQM, String missionDirectory)
		{
			InitializeComponent();
			this.missionSQM = missionSQM;
			this.missionDirectory = missionDirectory;

			isHandledScenarioData = false;
			isHandledScenarioDataHeader = false;
			isHandledCustomAttributes = false;
			isHandledIntel = false;

			scenarioDataDict = new Dictionary<string, bool>()
			{
				{"author", false }, {"overviewText", false }, {"overViewPicture", false }, {"onLoadMission", false },
				{"loadScreen", false }, {"aIKills", false }, {"respawn", false }, {"class Header", false }
			};
			scenarioDataHeaderDict = new Dictionary<string, bool>()
			{
				{"gameType", false }, {"minPlayers", false }, {"maxPlayers", false }
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
								List<string> keys = new List<string>(scenarioDataDict.Keys);
								foreach (String cmd in keys)
								{
									if (line.Contains(cmd))
									{
										cmdNotAvail = false;
										switch (cmd)
										{
											case "author":
												sw.WriteLine("	author=\"" + textbox_author.Text.Replace("\"", "\"\"") + "\";");
												this.scenarioDataDict["author"] = true;
												break;
											case "overviewText":
												sw.WriteLine("	overviewText=\"" + textbox_overview_text.Text.Replace("\"", "\"\"") + "\";");
												this.scenarioDataDict["overviewText"] = true;
												break;
											case "overViewPicture":
												sw.WriteLine("	overViewPicture=\"images\\loadscreen.jpg\";");
												this.scenarioDataDict["overViewPicture"] = true;
												break;
											case "onLoadMission":
												sw.WriteLine("	onLoadMission=\"" + textBox_onLoadMission.Text.Replace("\"", "\"\"") + "\";");
												this.scenarioDataDict["onLoadMission"] = true;
												break;
											case "loadScreen":
												sw.WriteLine("	loadScreen=\"images\\loadscreen.jpg\";");
												this.scenarioDataDict["loadScreen"] = true;
												break;
											case "aIKills":
												if (checkBox_mp_allow_ai_score.Checked)
												{
													sw.WriteLine("	aIKills=1;");
												}
												this.scenarioDataDict["aIKills"] = true;
												break;
											case "respawn":
												sw.WriteLine("	respawn=5;");
												this.scenarioDataDict["respawn"] = true;
												break;
											case "class Header":
												sw.WriteLine(line);
												// Loop through Header for ScenarioData and fill out gameType to Coop
												//	then fill out minplayer and maxplayer
												handleScenarioDataHeader(sr, sw);
												this.scenarioDataDict["class Header"] = true;
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
								List<string> keys = new List<string>(customAttributesDict.Keys);
								foreach (String cmd in keys)
								{
									if (line.Contains(cmd))
									{
										cmdNotAvail = false;
										switch (cmd)
										{
											case "class Category":
												this.customAttributesDict["class Category"] = true;
												break;
											case "name=\"Multiplayer\";":
												this.customAttributesDict["name=\"Multiplayer\";"] = true;
												break;
											case "property=\"RespawnTemplates\";":
												this.customAttributesDict["property=\"RespawnTemplates\";"] = true;
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
								List<string> keys = new List<string>(intelDict.Keys);
								foreach (String cmd in keys)
								{
									if (line.Contains(cmd))
									{
										cmdNotAvail = false;
										switch (cmd)
										{
											case "overviewText":
												this.intelDict["overviewText"] = true;
												break;
											case "resistanceWest":
												this.intelDict["resistanceWest"] = true;
												break;
											case "resistanceEast":
												this.intelDict["resistanceEast"] = true;
												break;
											case "timeOfChanges":
												this.intelDict["timeOfChanges"] = true;
												break;
											case "startWeather":
												this.intelDict["startWeather"] = true;
												break;
											case "startFog":
												this.intelDict["startFog"] = true;
												break;
											case "forecastWeather":
												this.intelDict["forecastWeather"] = true;
												break;
											case "forecastFog":
												this.intelDict["forecastFog"] = true;
												break;
											case "startFogBase":
												this.intelDict["startFogBase"] = true;
												break;
											case "forecastFogBase":
												this.intelDict["forecastFogBase"] = true;
												break;
											case "startFogDecay":
												this.intelDict["stateFogDecay"] = true;
												break;
											case "forecastFogDecay":
												this.intelDict["forecastFogDecay"] = true;
												break;
											case "year":
												this.intelDict["year"] = true;
												break;
											case "day":
												this.intelDict["day"] = true;
												break;
											case "hour":
												this.intelDict["hour"] = true;
												break;
											case "minute":
												this.intelDict["minute"] = true;
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

		// Handles calling functions for ScenarioData Header section
		private void handleScenarioDataHeader(System.IO.StreamReader sr, System.IO.StreamWriter sw)
		{
			String line = null;
			bool editingScenarioHeaderData = true; 

			while (editingScenarioHeaderData && (line = sr.ReadLine()) != null)
			{
				isHandledScenarioDataHeader = true;

				bool cmd2NotAvail = true;
				List<string> keys2 = new List<string>(scenarioDataHeaderDict.Keys);
				foreach (String cmd2 in keys2)
				{
					if (line.Contains(cmd2))
					{
						cmd2NotAvail = false;
						writeScenarioDataHeader(sw, cmd2);
					}
				}
				// Checks unmarked ScenarioData Header items, fill them in, then exit the loop
				if (line.Equals("	};"))
				{
					cmd2NotAvail = false;
					List<string> unusedKeys2 = new List<string>(scenarioDataHeaderDict.Keys);
					foreach (String unusedCmd in unusedKeys2)
					{
						if (!scenarioDataHeaderDict[unusedCmd])
						{
							writeScenarioDataHeader(sw, unusedCmd);
						}
					}
					sw.WriteLine("	};");
					editingScenarioHeaderData = false;
				}

				if (cmd2NotAvail)
				{
					sw.WriteLine(line);
				}
			}
		}

		// Helper function to write scenarioData Header information to mission.sqm
		private void writeScenarioDataHeader(System.IO.StreamWriter sw, String cmd)
		{
			switch (cmd)
			{
				case "gameType":
					sw.WriteLine("		gameType=\"Coop\";");
					this.scenarioDataHeaderDict["gameType"] = true;
					break;
				case "minPlayers":
					sw.WriteLine("		minPlayer=" + min_players.Value.ToString() + ";");
					this.scenarioDataHeaderDict["minPlayers"] = true;
					break;
				case "maxPlayers":
					sw.WriteLine("		maxPlayer=" + max_players.Value.ToString() + ";");
					this.scenarioDataHeaderDict["maxPlayers"] = true;
					break;
			}
		}
	}
}
