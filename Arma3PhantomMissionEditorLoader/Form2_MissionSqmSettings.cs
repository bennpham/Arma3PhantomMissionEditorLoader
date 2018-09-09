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
		private const String LOADSCREEN = "loadscreen.jpg";
		private const String FOLDER_IMAGES = "images";

		private String missionSQM;
		private String missionDirectory;

		// Check to see if all sections of mission.sqm is handled (ScenarioData, CustomAttributes, Intel)
		private bool isHandledScenarioData;
		private bool isHandledCustomAttributes;
		private bool isHandledIntel;
		private bool isCheckIntel;

		// Parameters for each sections of the mission.sqm (ScenarioData, CustomAttributes, Intel)
		//	If there are still any parameters that are not set, fill them in.
		private Dictionary<string, bool> scenarioDataDict;
		private Dictionary<string, bool> scenarioDataHeaderDict;
		private Dictionary<string, bool> intelDict;

		public Form2_MissionSqmSettings(String missionSQM, String missionDirectory)
		{
			InitializeComponent();
			this.missionSQM = missionSQM;
			this.missionDirectory = missionDirectory;

			isHandledScenarioData = false;
			isHandledCustomAttributes = false;
			isHandledIntel = false;
			isCheckIntel = false;

			scenarioDataDict = new Dictionary<string, bool>()
			{
				{"author", false }, {"overviewText", false }, {"overViewPicture", false }, {"onLoadMission", false },
				{"loadScreen", false }, {"aIKills", false }, {"respawn", false }, {"enableTeamSwitch", false}, {"class Header", false }
			};
			scenarioDataHeaderDict = new Dictionary<string, bool>()
			{
				{"gameType", false }, {"minPlayers", false }, {"maxPlayers", false }
			};
			intelDict = new Dictionary<string, bool>()
			{
				{"overviewText", false}, {"resistanceWest", false}, {"resistanceEast", false}, {"timeOfChanges", false},
				{"startWeather", false}, {"startFog", false}, {"forecastWeather", false}, {"forecastFog", false},
				{"year", false}, {"month", false}, {"day", false}, {"hour", false}, {"minute", false},
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
						/* Check to see whether we're editing mission.sqm or if not, just copy the mission.sqm 
						 *	line as is, otherwise, modify that attribute for the mission.sqm */
						if (editingScenarioData || editingCustomAttributes || editingIntel)
						{
							sw.WriteLine(line); // Writes open bracket to mission.sqm

							editingScenarioData = handleScenarioData(sr, sw, editingScenarioData);
							editingCustomAttributes = handleCustomAttributes(sr, sw, editingCustomAttributes);
							editingIntel = handleIntel(sr, sw, editingIntel);
						}
						else
						{
							sw.WriteLine(line);
						}

						/* If line contains either class ScenarioData, class CustomAttributes, or 
						 *  class Intel, enable editing for them and modify their parameters based on 
						 *  whatever the user set them to be. */
						if (line.Equals("class ScenarioData"))
						{
							editingScenarioData = true;
						}
						else if (line.Equals("class CustomAttributes"))
						{
							editingCustomAttributes = true;
						}
						else if (line.Equals("	class Intel"))
						{
							editingIntel = true;
						}

						/* If mission header is found, prepare to check for Intel. 
						 * If it doesn't exist, create it. */
						if (line.Equals("class Mission"))
						{
							isCheckIntel = true;
						}
						if (isCheckIntel && !isHandledIntel && line == "};")
						{
							sw.WriteLine("	class Intel");
							sw.WriteLine("	{");
							List<string> unusedKeys = new List<string>(intelDict.Keys);
							foreach (String unusedCmd in unusedKeys)
							{
								if (!intelDict[unusedCmd])
								{
									writeIntel(sr, sw, unusedCmd);
								}
							}
							sw.WriteLine("	};");
						}
					}

					if (!isHandledScenarioData)
					{
						sw.WriteLine("class ScenarioData");
						sw.WriteLine("{");
						List<string> unusedKeys = new List<string>(scenarioDataDict.Keys);
						foreach (String unusedCmd in unusedKeys)
						{
							if (!scenarioDataDict[unusedCmd])
							{
								writeScenarioData(sr, sw, unusedCmd, null);
								if (unusedCmd.Equals("class Header"))
								{
									sw.WriteLine("	{");
									List<string> unusedKeys2 = new List<string>(scenarioDataHeaderDict.Keys);
									foreach (String unusedCmd2 in unusedKeys2)
									{
										if (!scenarioDataHeaderDict[unusedCmd2])
										{
											writeScenarioDataHeader(sw, unusedCmd2);
										}
									}
									sw.WriteLine("	};");
								}
							}
						}
						sw.WriteLine("};");
					}
					if (!isHandledCustomAttributes)
					{
						sw.WriteLine("class CustomAttributes");
						sw.WriteLine("{");
						handleCustomAttributes(sr, sw, true);
					}
					if (!isHandledIntel)
					{
						sw.WriteLine("class Mission");
						sw.WriteLine("{");
						sw.WriteLine("	class Intel");
						sw.WriteLine("	{");
						List<string> unusedKeys = new List<string>(intelDict.Keys);
						foreach (String unusedCmd in unusedKeys)
						{
							if (!intelDict[unusedCmd])
							{
								writeIntel(sr, sw, unusedCmd);
							}
						}
						sw.WriteLine("	};");
						sw.WriteLine("};");
					}
				}
			}

			// Copy placeholder loadscreen image to images folder
			System.IO.Directory.CreateDirectory(System.IO.Path.Combine(this.missionDirectory, FOLDER_IMAGES));
			System.IO.File.Copy(LOADSCREEN, System.IO.Path.Combine(this.missionDirectory, FOLDER_IMAGES, LOADSCREEN));

			// GoTo Generate infotext Form
			//		Pick Name of Mission to Display (already have date and Author)
			this.Hide();
			Form3_Description form3_description = new Form3_Description(this.missionDirectory, date.Text,
				formatTimeString(this.hour.Value.ToString()), formatTimeString(this.minute.Value.ToString()), 
				textbox_author.Text,
				"OnLoadName = \"" + textBox_onLoadName.Text.Replace("\"", "\"\"").Replace(Environment.NewLine, " ") + "\";",
				"OnLoadMission =\"" + textBox_onLoadMission.Text.Replace("\"", "\"\"").Replace(Environment.NewLine, " ") + "\";",
				min_players.Value.ToString(), max_players.Value.ToString());
			form3_description.ShowDialog();
		}

		/*===========================================================
		 *  SCENARIO DATA
		 *===========================================================*/
		// Handles calling functions for ScenarioData section
		private bool handleScenarioData(System.IO.StreamReader sr, System.IO.StreamWriter sw, bool editingScenarioData)
		{
			String line = null;
			while (editingScenarioData && (line = sr.ReadLine()) != null)
			{
				isHandledScenarioData = true;

				bool cmdNotAvail = true;
				List<string> keys = new List<string>(scenarioDataDict.Keys);
				foreach (String cmd in keys)
				{
					if (cmd.Equals((line.Trim().Split('='))[0]))
					{
						cmdNotAvail = false;
						writeScenarioData(sr, sw, cmd, line);
					}
				}
				// Checks unmarked ScenarioData items, fill them in, then exit the loop
				if (line.Equals("};"))
				{
					cmdNotAvail = false;
					List<string> unusedKeys = new List<string>(scenarioDataDict.Keys);
					foreach (String unusedCmd in unusedKeys)
					{
						if (!scenarioDataDict[unusedCmd])
						{
							writeScenarioData(sr, sw, unusedCmd, line);
						}
					}
					sw.WriteLine("};");
					editingScenarioData = false;
				}

				if (cmdNotAvail)
				{
					sw.WriteLine(line);
				}
			}
			return false;
		}

		// Helper function to write scenarioData information to mission.sqm
		private void writeScenarioData(System.IO.StreamReader sr, System.IO.StreamWriter sw, String cmd, String line)
		{
			switch (cmd)
			{
				case "author":
					sw.WriteLine("	author=\"" + textbox_author.Text.Replace("\"", "\"\"") + "\";");
					this.scenarioDataDict["author"] = true;
					break;
				case "overviewText":
					sw.WriteLine("	overviewText=\"" + textbox_overview_text.Text.Replace("\"", "\"\"").Replace(Environment.NewLine, "\" \\n \"") + "\";");
					this.scenarioDataDict["overviewText"] = true;
					break;
				case "overViewPicture":
					sw.WriteLine("	overViewPicture=\"images\\loadscreen.jpg\";");
					this.scenarioDataDict["overViewPicture"] = true;
					break;
				case "onLoadMission":
					sw.WriteLine("	onLoadMission=\"" + textBox_onLoadMission.Text.Replace("\"", "\"\"").Replace(Environment.NewLine, " ") + "\";");
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
				case "enableTeamSwitch":
					if (!checkBox_mp_enable_team_switch.Checked)
					{
						sw.WriteLine("	enableTeamSwitch=0;");
					}
					this.scenarioDataDict["enableTeamSwitch"] = true;
					break;
				case "class Header":
					sw.WriteLine("	class Header");
					// Loop through Header for ScenarioData and fill out gameType to Coop
					//	then fill out minplayer and maxplayer
					handleScenarioDataHeader(sr, sw, line);
					this.scenarioDataDict["class Header"] = true;
					break;
			}
		}

		// Handles calling functions for ScenarioData Header section
		private void handleScenarioDataHeader(System.IO.StreamReader sr, System.IO.StreamWriter sw, String line) 
		{
			bool editingScenarioHeaderData = true; 
			if (line == null)
			{
				line = sr.ReadLine();
			}
			while (editingScenarioHeaderData && line != null)
			{
				// Add closing brackets if Header was barely created
				if (line.Equals("};"))
				{
					sw.WriteLine("	{");
				}

				bool cmd2NotAvail = true;
				List<string> keys2 = new List<string>(scenarioDataHeaderDict.Keys);
				foreach (String cmd2 in keys2)
				{
					if (cmd2.Equals((line.Trim().Split('='))[0]))
					{
						cmd2NotAvail = false;
						writeScenarioDataHeader(sw, cmd2);
					}
				}
				// Checks unmarked ScenarioData Header items, fill them in, then exit the loop
				if (line.Equals("	};") || line.Equals("};"))
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
				if (editingScenarioHeaderData)
				{
					line = sr.ReadLine();
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
					sw.WriteLine("		minPlayers=" + min_players.Value.ToString() + ";");
					this.scenarioDataHeaderDict["minPlayers"] = true;
					break;
				case "maxPlayers":
					sw.WriteLine("		maxPlayers=" + max_players.Value.ToString() + ";");
					this.scenarioDataHeaderDict["maxPlayers"] = true;
					break;
			}
		}

		/*===========================================================
		 *  CUSTOM ATTRIBUTES
		 *===========================================================*/
		// Handles calling functions for CustomAttributes
		/* WARNING! If you previous have other CustomAttributes values, they'll be removed and overwritten by the ones 
		 *	generated in this file
		 */
		private bool handleCustomAttributes(System.IO.StreamReader sr, System.IO.StreamWriter sw, bool editingCustomAttributes)
		{
			if (editingCustomAttributes)
			{
				isHandledCustomAttributes = true;
				sw.WriteLine("	class Category0");
				sw.WriteLine("	{");
				sw.WriteLine("		name=\"Multiplayer\";");
				sw.WriteLine("		class Attribute0");
				sw.WriteLine("		{");
				sw.WriteLine("			property=\"RespawnButton\";");
				sw.WriteLine("			expression=\"true\";");
				sw.WriteLine("			class Value");
				sw.WriteLine("			{");
				sw.WriteLine("				class data");
				sw.WriteLine("				{");
				sw.WriteLine("					class type");
				sw.WriteLine("					{");
				sw.WriteLine("						type[]=");
				sw.WriteLine("						{");
				sw.WriteLine("							\"SCALAR\"");
				sw.WriteLine("						};");
				sw.WriteLine("					};");
				allowManualRespawn(sw);
				sw.WriteLine("				};");
				sw.WriteLine("			};");
				sw.WriteLine("		};");
				sw.WriteLine("		class Attribute1");
				sw.WriteLine("		{");
				sw.WriteLine("			property=\"RespawnTemplates\";");
				sw.WriteLine("			expression=\"true\";");
				sw.WriteLine("			class Value");
				sw.WriteLine("			{");
				sw.WriteLine("				class data");
				sw.WriteLine("				{");
				sw.WriteLine("					class type");
				sw.WriteLine("					{");
				sw.WriteLine("						type[]=");
				sw.WriteLine("						{");
				sw.WriteLine("							\"ARRAY\"");
				sw.WriteLine("						};");
				sw.WriteLine("					};");
				handleMPTemplatesRuleSets(sw);
				sw.WriteLine("				};");
				sw.WriteLine("			};");
				sw.WriteLine("		};");
				sw.WriteLine("		nAttributes=2;");
				sw.WriteLine("	};");
				sw.WriteLine("};");
				while (true)
				// move StreamReader after CustomAttributes class or end if null
				{
					String readLine = sr.ReadLine();
					if (readLine == null || readLine.Equals("};"))
					{
						return false;
					}
				} 
			}

			return false;
		}

		// Check checkbox for Allow Manual Respawn is on or off then print the corresponding value
		private void allowManualRespawn(System.IO.StreamWriter sw)
		{
			if (checkBox_mp_manual_respawn.Checked)
			{
				sw.WriteLine("					value=1;");
			}
			else
			{
				sw.WriteLine("					value=0;");
			}
		}

		// Handle checkboxes for MP Templates RuleSets (Mission Fail Everyone Dead, SinglePlayer Death Screen, SwitchPlayer on Death
		private void handleMPTemplatesRuleSets(System.IO.StreamWriter sw)
		{
			bool[] checkBoxMPArr = new bool[] { checkBox_mp_mission_fail.Checked, checkBox_mp_sp_death_screen.Checked, checkBox_mp_switch_char.Checked }; 
			int itemsCount = checkBoxMPArr.Count(c => c == true);

			if (checkBox_mp_mission_fail.Checked || checkBox_mp_sp_death_screen.Checked || checkBox_mp_switch_char.Checked)
			{
				sw.WriteLine("					class value");
				sw.WriteLine("					{");
				sw.WriteLine("						items=" + itemsCount.ToString() + ";");
				printMPTemplatesRuleSet(sw, itemsCount);
				sw.WriteLine("					};");
			}
		}

		// Pass itemCount & StreamWriter of how many MP Templates Rule Sets & print each checked MP Template Rule Set
		private void printMPTemplatesRuleSet(System.IO.StreamWriter sw, int itemsCount)
		{
			List<string> ruleSetList = new List<string>();
			if (checkBox_mp_mission_fail.Checked)
			{
				ruleSetList.Add("EndMission");
			}
			if (checkBox_mp_sp_death_screen.Checked)
			{
				ruleSetList.Add("None");
			}
			if (checkBox_mp_switch_char.Checked)
			{
				ruleSetList.Add("SwitchPlayer");
			}

			for (int i = 0; i < itemsCount; i++)
			{
				sw.WriteLine("						class Item" + i.ToString());
				sw.WriteLine("						{");
				sw.WriteLine("							class data");
				sw.WriteLine("							{");
				sw.WriteLine("								class type");
				sw.WriteLine("								{");
				sw.WriteLine("									type[]=");
				sw.WriteLine("									{");
				sw.WriteLine("										\"STRING\"");
				sw.WriteLine("									};");
				sw.WriteLine("								};");
				sw.WriteLine("								value=\"" + ruleSetList[i] + "\";"); 
				sw.WriteLine("							};");
				sw.WriteLine("						};");
			}
		}

		/*===========================================================
		 *  INTEL
		 *===========================================================*/
		// Handle calling functions for Intel section
		private bool handleIntel(System.IO.StreamReader sr, System.IO.StreamWriter sw, bool editingIntel)
		{
			String line = null;
			while (editingIntel && (line = sr.ReadLine()) != null)
			{
				isHandledIntel = true;

				bool cmdNotAvail = true;
				List<string> keys = new List<string>(intelDict.Keys);
				foreach (String cmd in keys)
				{
					if (cmd.Equals((line.Trim().Split('='))[0]))
					{
						cmdNotAvail = false;
						writeIntel(sr, sw, cmd);
					}
				}
				// Checks unmarked Intel items, fill them in, then exit the loop
				if (line.Equals("	};"))
				{
					cmdNotAvail = false;
					List<string> unusedKeys = new List<string>(intelDict.Keys);
					foreach (String unusedCmd in unusedKeys)
					{
						if (!intelDict[unusedCmd])
						{
							writeIntel(sr, sw, unusedCmd);
						}
					}
					sw.WriteLine("	};");
					editingIntel = false;
				}

				if (cmdNotAvail)
				{
					sw.WriteLine(line);
				}
			}

			return false;
		}

		// Helper function to write Intel information to mission.sqm
		private void writeIntel(System.IO.StreamReader sr, System.IO.StreamWriter sw, String cmd)
		{
			string[] dateTimeArr = date.Value.ToString("yyyy-M-d").Split('-');
			switch (cmd)
			{
				case "overviewText":
					sw.WriteLine("		overviewText=\"" + summary.Text.Replace("\"", "\"\"").Replace(Environment.NewLine, " ") + "\"");
					this.intelDict["overviewText"] = true;
					break;
				case "resistanceWest":
					String resistanceWest = west_checkbox.Checked ? "resistanceWest=1;" : "resistanceWest=0;";
					sw.WriteLine("		" + resistanceWest);
					this.intelDict["resistanceWest"] = true;
					break;
				case "resistanceEast":
					String resistanceEast = east_checkbox.Checked ? "resistanceEast=1;" : "resistanceEast=0;";
					sw.WriteLine("		" + resistanceEast);
					this.intelDict["resistanceEast"] = true;
					break;
				case "timeOfChanges":
					decimal toc = (toc_hour.Value * 3600) + (toc_minutes.Value * 60) + (toc_seconds.Value);
					toc = toc > 28800 ? 28800 : toc;
					sw.WriteLine("		timeOfChanges=" + toc.ToString() + ";");
					this.intelDict["timeOfChanges"] = true;
					break;
				case "startWeather":
					decimal startWeather = overcastStart.Value / 100;
					sw.WriteLine("		startWeather=" + startWeather.ToString() + ";");
					this.intelDict["startWeather"] = true;
					break;
				case "startFog":
					decimal startFog = fogStart.Value / 100;
					sw.WriteLine("		startFog=" + startFog.ToString() + ";");
					this.intelDict["startFog"] = true;
					break;
				case "forecastWeather":
					decimal forecastWeather = overcastForecast.Value / 100;
					sw.WriteLine("		forecastWeather=" + forecastWeather.ToString() + ";");
					this.intelDict["forecastWeather"] = true;
					break;
				case "forecastFog":
					decimal forecastFog = fogForecast.Value / 100;
					sw.WriteLine("		forecastFog=" + forecastFog.ToString() + ";");
					this.intelDict["forecastFog"] = true;
					break;
				case "startFogBase":
					decimal startFogBase = fogStartBase.Value;
					sw.WriteLine("		startFogBase=" + startFogBase.ToString() + ";");
					this.intelDict["startFogBase"] = true;
					break;
				case "forecastFogBase":
					decimal forecastFogBase = fogForecastBase.Value;
					sw.WriteLine("		forecastFogBase=" + forecastFogBase.ToString() + ";");
					this.intelDict["forecastFogBase"] = true;
					break;
				case "startFogDecay":
					decimal startFogDecay = fogStartDecay.Value / 100;
					sw.WriteLine("		startFogDecay=" + startFogDecay.ToString() + ";");
					this.intelDict["startFogDecay"] = true;
					break;
				case "forecastFogDecay":
					decimal forecastFogDecay = fogForecastDecay.Value / 100;
					sw.WriteLine("		forecastFogDecay=" + forecastFogDecay.ToString() + ";");
					this.intelDict["forecastFogDecay"] = true;
					break;
				case "year":
					sw.WriteLine("		year=" + dateTimeArr[0] + ";");
					this.intelDict["year"] = true;
					break;
				case "month":
					sw.WriteLine("		month=" + dateTimeArr[1] + ";");
					this.intelDict["month"] = true;
					break;
				case "day":
					sw.WriteLine("		day=" + dateTimeArr[2] + ";");
					this.intelDict["day"] = true;
					break;
				case "hour":
					sw.WriteLine("		hour=" + hour.Value.ToString() + ";");
					this.intelDict["hour"] = true;
					break;
				case "minute":
					sw.WriteLine("		minute=" + minute.Value.ToString() + ";");
					this.intelDict["minute"] = true;
					break;
			}
		}

		/* Take a string that is a number, and append an extra 0 in front if its single digit */
		private String formatTimeString(String time)
		{
			return time.Length == 1 ? "0" + time : time;
		}
	}
}
