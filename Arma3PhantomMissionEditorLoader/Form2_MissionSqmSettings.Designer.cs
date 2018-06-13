namespace Arma3PhantomMissionEditorLoader
{
	partial class Form2_MissionSqmSettings
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.title_general = new System.Windows.Forms.Label();
			this.missionsqm_button = new System.Windows.Forms.Button();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.label_author = new System.Windows.Forms.Label();
			this.label_overview_text = new System.Windows.Forms.Label();
			this.textbox_author = new System.Windows.Forms.TextBox();
			this.textbox_overview_text = new System.Windows.Forms.TextBox();
			this.label_independent = new System.Windows.Forms.Label();
			this.west_checkbox = new System.Windows.Forms.CheckBox();
			this.east_checkbox = new System.Windows.Forms.CheckBox();
			this.title_multiplayer = new System.Windows.Forms.Label();
			this.label_min_players = new System.Windows.Forms.Label();
			this.label_max_players = new System.Windows.Forms.Label();
			this.min_players = new System.Windows.Forms.NumericUpDown();
			this.max_players = new System.Windows.Forms.NumericUpDown();
			this.label_respawn_delay = new System.Windows.Forms.Label();
			this.respawn_delay = new System.Windows.Forms.NumericUpDown();
			this.label_summary = new System.Windows.Forms.Label();
			this.summary = new System.Windows.Forms.TextBox();
			this.checkBox_mp_mission_fail = new System.Windows.Forms.CheckBox();
			this.checkBox_mp_sp_death_screen = new System.Windows.Forms.CheckBox();
			this.checkBox_mp_switch_char = new System.Windows.Forms.CheckBox();
			this.checkBox_mp_manual_respawn = new System.Windows.Forms.CheckBox();
			this.checkBox_mp_enable_team_switch = new System.Windows.Forms.CheckBox();
			this.checkBox_mp_allow_ai_score = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.min_players)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.max_players)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.respawn_delay)).BeginInit();
			this.SuspendLayout();
			// 
			// title_general
			// 
			this.title_general.AutoSize = true;
			this.title_general.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.title_general.Location = new System.Drawing.Point(32, 9);
			this.title_general.Name = "title_general";
			this.title_general.Size = new System.Drawing.Size(106, 29);
			this.title_general.TabIndex = 1;
			this.title_general.Text = "General";
			this.title_general.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// missionsqm_button
			// 
			this.missionsqm_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.missionsqm_button.Location = new System.Drawing.Point(360, 631);
			this.missionsqm_button.Name = "missionsqm_button";
			this.missionsqm_button.Size = new System.Drawing.Size(147, 38);
			this.missionsqm_button.TabIndex = 4;
			this.missionsqm_button.Text = "OK";
			this.missionsqm_button.UseVisualStyleBackColor = true;
			this.missionsqm_button.Click += new System.EventHandler(this.missionsqm_button_Click);
			// 
			// label_author
			// 
			this.label_author.AutoSize = true;
			this.label_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_author.Location = new System.Drawing.Point(68, 46);
			this.label_author.Name = "label_author";
			this.label_author.Size = new System.Drawing.Size(63, 20);
			this.label_author.TabIndex = 5;
			this.label_author.Text = "Author";
			// 
			// label_overview_text
			// 
			this.label_overview_text.AutoSize = true;
			this.label_overview_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_overview_text.Location = new System.Drawing.Point(12, 66);
			this.label_overview_text.MaximumSize = new System.Drawing.Size(120, 0);
			this.label_overview_text.Name = "label_overview_text";
			this.label_overview_text.Size = new System.Drawing.Size(119, 20);
			this.label_overview_text.TabIndex = 6;
			this.label_overview_text.Text = "Overview Text";
			// 
			// textbox_author
			// 
			this.textbox_author.Location = new System.Drawing.Point(138, 46);
			this.textbox_author.Name = "textbox_author";
			this.textbox_author.Size = new System.Drawing.Size(267, 20);
			this.textbox_author.TabIndex = 7;
			// 
			// textbox_overview_text
			// 
			this.textbox_overview_text.Location = new System.Drawing.Point(137, 72);
			this.textbox_overview_text.Multiline = true;
			this.textbox_overview_text.Name = "textbox_overview_text";
			this.textbox_overview_text.Size = new System.Drawing.Size(267, 100);
			this.textbox_overview_text.TabIndex = 8;
			// 
			// label_independent
			// 
			this.label_independent.AutoSize = true;
			this.label_independent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_independent.Location = new System.Drawing.Point(12, 184);
			this.label_independent.MaximumSize = new System.Drawing.Size(120, 0);
			this.label_independent.Name = "label_independent";
			this.label_independent.Size = new System.Drawing.Size(116, 40);
			this.label_independent.TabIndex = 9;
			this.label_independent.Text = "Independent Friendly";
			// 
			// west_checkbox
			// 
			this.west_checkbox.AutoSize = true;
			this.west_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.west_checkbox.Location = new System.Drawing.Point(137, 198);
			this.west_checkbox.Name = "west_checkbox";
			this.west_checkbox.Size = new System.Drawing.Size(65, 24);
			this.west_checkbox.TabIndex = 10;
			this.west_checkbox.Text = "West";
			this.west_checkbox.UseVisualStyleBackColor = true;
			// 
			// east_checkbox
			// 
			this.east_checkbox.AutoSize = true;
			this.east_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.east_checkbox.Location = new System.Drawing.Point(223, 198);
			this.east_checkbox.Name = "east_checkbox";
			this.east_checkbox.Size = new System.Drawing.Size(61, 24);
			this.east_checkbox.TabIndex = 11;
			this.east_checkbox.Text = "East";
			this.east_checkbox.UseVisualStyleBackColor = true;
			// 
			// title_multiplayer
			// 
			this.title_multiplayer.AutoSize = true;
			this.title_multiplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.title_multiplayer.Location = new System.Drawing.Point(11, 256);
			this.title_multiplayer.Name = "title_multiplayer";
			this.title_multiplayer.Size = new System.Drawing.Size(141, 29);
			this.title_multiplayer.TabIndex = 12;
			this.title_multiplayer.Text = "Multiplayer";
			this.title_multiplayer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label_min_players
			// 
			this.label_min_players.AutoSize = true;
			this.label_min_players.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_min_players.Location = new System.Drawing.Point(17, 291);
			this.label_min_players.Name = "label_min_players";
			this.label_min_players.Size = new System.Drawing.Size(89, 20);
			this.label_min_players.TabIndex = 13;
			this.label_min_players.Text = "Min Players";
			// 
			// label_max_players
			// 
			this.label_max_players.AutoSize = true;
			this.label_max_players.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_max_players.Location = new System.Drawing.Point(12, 315);
			this.label_max_players.Name = "label_max_players";
			this.label_max_players.Size = new System.Drawing.Size(93, 20);
			this.label_max_players.TabIndex = 14;
			this.label_max_players.Text = "Max Players";
			// 
			// min_players
			// 
			this.min_players.Location = new System.Drawing.Point(112, 291);
			this.min_players.Name = "min_players";
			this.min_players.Size = new System.Drawing.Size(44, 20);
			this.min_players.TabIndex = 15;
			// 
			// max_players
			// 
			this.max_players.Location = new System.Drawing.Point(111, 318);
			this.max_players.Name = "max_players";
			this.max_players.Size = new System.Drawing.Size(44, 20);
			this.max_players.TabIndex = 16;
			// 
			// label_respawn_delay
			// 
			this.label_respawn_delay.AutoSize = true;
			this.label_respawn_delay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_respawn_delay.Location = new System.Drawing.Point(234, 291);
			this.label_respawn_delay.Name = "label_respawn_delay";
			this.label_respawn_delay.Size = new System.Drawing.Size(120, 20);
			this.label_respawn_delay.TabIndex = 17;
			this.label_respawn_delay.Text = "Respawn Delay";
			// 
			// respawn_delay
			// 
			this.respawn_delay.Location = new System.Drawing.Point(360, 294);
			this.respawn_delay.Name = "respawn_delay";
			this.respawn_delay.Size = new System.Drawing.Size(44, 20);
			this.respawn_delay.TabIndex = 18;
			// 
			// label_summary
			// 
			this.label_summary.AutoSize = true;
			this.label_summary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_summary.Location = new System.Drawing.Point(17, 348);
			this.label_summary.Name = "label_summary";
			this.label_summary.Size = new System.Drawing.Size(83, 20);
			this.label_summary.TabIndex = 19;
			this.label_summary.Text = "Summary";
			// 
			// summary
			// 
			this.summary.Location = new System.Drawing.Point(106, 350);
			this.summary.Multiline = true;
			this.summary.Name = "summary";
			this.summary.Size = new System.Drawing.Size(298, 169);
			this.summary.TabIndex = 20;
			// 
			// checkBox_mp_mission_fail
			// 
			this.checkBox_mp_mission_fail.AutoSize = true;
			this.checkBox_mp_mission_fail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_mp_mission_fail.Location = new System.Drawing.Point(21, 536);
			this.checkBox_mp_mission_fail.Name = "checkBox_mp_mission_fail";
			this.checkBox_mp_mission_fail.Size = new System.Drawing.Size(223, 24);
			this.checkBox_mp_mission_fail.TabIndex = 21;
			this.checkBox_mp_mission_fail.Text = "Mission Fail Everyone Dead";
			this.checkBox_mp_mission_fail.UseVisualStyleBackColor = true;
			// 
			// checkBox_mp_sp_death_screen
			// 
			this.checkBox_mp_sp_death_screen.AutoSize = true;
			this.checkBox_mp_sp_death_screen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_mp_sp_death_screen.Location = new System.Drawing.Point(21, 566);
			this.checkBox_mp_sp_death_screen.Name = "checkBox_mp_sp_death_screen";
			this.checkBox_mp_sp_death_screen.Size = new System.Drawing.Size(217, 24);
			this.checkBox_mp_sp_death_screen.TabIndex = 22;
			this.checkBox_mp_sp_death_screen.Text = "Singleplayer Death Screen";
			this.checkBox_mp_sp_death_screen.UseVisualStyleBackColor = true;
			// 
			// checkBox_mp_switch_char
			// 
			this.checkBox_mp_switch_char.AutoSize = true;
			this.checkBox_mp_switch_char.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_mp_switch_char.Location = new System.Drawing.Point(21, 596);
			this.checkBox_mp_switch_char.Name = "checkBox_mp_switch_char";
			this.checkBox_mp_switch_char.Size = new System.Drawing.Size(223, 24);
			this.checkBox_mp_switch_char.TabIndex = 23;
			this.checkBox_mp_switch_char.Text = "Switch to another character";
			this.checkBox_mp_switch_char.UseVisualStyleBackColor = true;
			// 
			// checkBox_mp_manual_respawn
			// 
			this.checkBox_mp_manual_respawn.AutoSize = true;
			this.checkBox_mp_manual_respawn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_mp_manual_respawn.Location = new System.Drawing.Point(250, 536);
			this.checkBox_mp_manual_respawn.Name = "checkBox_mp_manual_respawn";
			this.checkBox_mp_manual_respawn.Size = new System.Drawing.Size(192, 24);
			this.checkBox_mp_manual_respawn.TabIndex = 24;
			this.checkBox_mp_manual_respawn.Text = "Allow Manual Respawn";
			this.checkBox_mp_manual_respawn.UseVisualStyleBackColor = true;
			// 
			// checkBox_mp_enable_team_switch
			// 
			this.checkBox_mp_enable_team_switch.AutoSize = true;
			this.checkBox_mp_enable_team_switch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_mp_enable_team_switch.Location = new System.Drawing.Point(250, 566);
			this.checkBox_mp_enable_team_switch.Name = "checkBox_mp_enable_team_switch";
			this.checkBox_mp_enable_team_switch.Size = new System.Drawing.Size(173, 24);
			this.checkBox_mp_enable_team_switch.TabIndex = 25;
			this.checkBox_mp_enable_team_switch.Text = "Enable Team Switch";
			this.checkBox_mp_enable_team_switch.UseVisualStyleBackColor = true;
			// 
			// checkBox_mp_allow_ai_score
			// 
			this.checkBox_mp_allow_ai_score.AutoSize = true;
			this.checkBox_mp_allow_ai_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_mp_allow_ai_score.Location = new System.Drawing.Point(250, 596);
			this.checkBox_mp_allow_ai_score.Name = "checkBox_mp_allow_ai_score";
			this.checkBox_mp_allow_ai_score.Size = new System.Drawing.Size(131, 24);
			this.checkBox_mp_allow_ai_score.TabIndex = 26;
			this.checkBox_mp_allow_ai_score.Text = "Allow AI Score";
			this.checkBox_mp_allow_ai_score.UseVisualStyleBackColor = true;
			// 
			// Form2_MissionSqmSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(824, 681);
			this.Controls.Add(this.checkBox_mp_allow_ai_score);
			this.Controls.Add(this.checkBox_mp_enable_team_switch);
			this.Controls.Add(this.checkBox_mp_manual_respawn);
			this.Controls.Add(this.checkBox_mp_switch_char);
			this.Controls.Add(this.checkBox_mp_sp_death_screen);
			this.Controls.Add(this.checkBox_mp_mission_fail);
			this.Controls.Add(this.summary);
			this.Controls.Add(this.label_summary);
			this.Controls.Add(this.respawn_delay);
			this.Controls.Add(this.label_respawn_delay);
			this.Controls.Add(this.max_players);
			this.Controls.Add(this.min_players);
			this.Controls.Add(this.label_max_players);
			this.Controls.Add(this.label_min_players);
			this.Controls.Add(this.title_multiplayer);
			this.Controls.Add(this.east_checkbox);
			this.Controls.Add(this.west_checkbox);
			this.Controls.Add(this.label_independent);
			this.Controls.Add(this.textbox_overview_text);
			this.Controls.Add(this.textbox_author);
			this.Controls.Add(this.label_overview_text);
			this.Controls.Add(this.label_author);
			this.Controls.Add(this.missionsqm_button);
			this.Controls.Add(this.title_general);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MinimizeBox = false;
			this.Name = "Form2_MissionSqmSettings";
			this.Text = "Arma 3 Phantom Mission Editor Edit Mission.sqm";
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.min_players)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.max_players)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.respawn_delay)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label title_general;
		private System.Windows.Forms.Button missionsqm_button;
		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.Label label_author;
		private System.Windows.Forms.Label label_overview_text;
		private System.Windows.Forms.TextBox textbox_author;
		private System.Windows.Forms.TextBox textbox_overview_text;
		private System.Windows.Forms.Label label_independent;
		private System.Windows.Forms.CheckBox west_checkbox;
		private System.Windows.Forms.CheckBox east_checkbox;
		private System.Windows.Forms.Label title_multiplayer;
		private System.Windows.Forms.Label label_min_players;
		private System.Windows.Forms.Label label_max_players;
		private System.Windows.Forms.NumericUpDown min_players;
		private System.Windows.Forms.NumericUpDown max_players;
		private System.Windows.Forms.Label label_respawn_delay;
		private System.Windows.Forms.NumericUpDown respawn_delay;
		private System.Windows.Forms.Label label_summary;
		private System.Windows.Forms.TextBox summary;
		private System.Windows.Forms.CheckBox checkBox_mp_mission_fail;
		private System.Windows.Forms.CheckBox checkBox_mp_sp_death_screen;
		private System.Windows.Forms.CheckBox checkBox_mp_switch_char;
		private System.Windows.Forms.CheckBox checkBox_mp_manual_respawn;
		private System.Windows.Forms.CheckBox checkBox_mp_enable_team_switch;
		private System.Windows.Forms.CheckBox checkBox_mp_allow_ai_score;
	}
}