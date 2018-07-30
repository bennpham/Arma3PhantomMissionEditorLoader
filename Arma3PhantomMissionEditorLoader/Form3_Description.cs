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
	public partial class Form3_Description : Form
	{
		private const String DESCRIPTION = "description.ext";
		private const String INIT = "init.sqf";

		private const String FOLDER_SCRIPTS = "scripts";
		private const String INFOTEXT = "infotext.sqf";
		private const String PARAMETERS = "parameters.hpp";
		private const String BRIEFING_LOADOUT = "briefing_loadout.hpp";

		// Info Text information
		private String missionDirectory;
		private String date;
		private String hour;
		private String minute;
		private String author;

		// Description ext information
		private String onLoadName;
		private String onLoadMission;
		private String minPlayers;
		private String maxPlayers;

		public Form3_Description(String missionDirectory, String date, String hour, String minute, String author, 
			String onLoadName, String onLoadMission, String minPlayers, String maxPlayers)
		{
			InitializeComponent();
			this.missionDirectory = missionDirectory;
			this.date = date;
			this.hour = hour;
			this.minute = minute;
			this.author = author;

			this.onLoadName = onLoadName;
			this.onLoadMission = onLoadMission;
			this.minPlayers = minPlayers;
			this.maxPlayers = maxPlayers;

			initializeInformation();
		}

		private void description_button_Click(object sender, EventArgs e)
		{
			Environment.Exit(0); // TODO Placeholder
		}

		/* Initialize Date and Author */
		private void initializeInformation()
		{
			this.label_datetime.Text = this.date + " | " + this.hour + ":" + this.minute + ":00";
			this.label_created_by.Text = "Created By " + this.author;
		}
	}
}