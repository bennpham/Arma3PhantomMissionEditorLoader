﻿using System;
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

		public String missionSQM;
		public String missionDirectory;

		public Form2_MissionSqmSettings(String missionSQM, String missionDirectory)
		{
			InitializeComponent();
			this.missionSQM = missionSQM;
			this.missionDirectory = missionDirectory;
		}

		private void missionsqm_button_Click(object sender, EventArgs e)
		{
			// Rename old mission.sqm to mission.sqm.old in case file gets corrupted
			System.IO.File.Move(this.missionSQM, System.IO.Path.Combine(this.missionDirectory, MISSION_SQM_BACKUP));
			
			// #3 Setup mission.sqm settings from extracted settings above 
			String line = null;
			using (System.IO.StreamReader sr = new System.IO.StreamReader(System.IO.File.OpenWrite(this.missionSQM)))
			{
				using (System.IO.StreamWriter sw = new System.IO.StreamWriter(MISSION_SQM_BACKUP))
				{
					while ((line = sr.ReadLine()) != null)
					{
						// TODO IF ELSE STATEMENT 
						if (line.Contains("TODO"))
						{
							// TODO
						}
						else
						{
							// TODO
						}
					}
				}
			}

			// TODO RENAME OLD FILE AND REPLACE WITH NEW FILE
			// #4 Generate infotext
			//		Pick Name of Mission to Display (already have date and Author)

		}
	}
}
