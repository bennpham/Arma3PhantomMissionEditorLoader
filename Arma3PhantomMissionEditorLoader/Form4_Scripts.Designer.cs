namespace Arma3PhantomMissionEditorLoader
{
	partial class Form4_Scripts
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
			this.title_extra_scripts = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.FHQ_marker_patrol_checkbox = new System.Windows.Forms.CheckBox();
			this.FHQ_safe_add_loadout_checkbox = new System.Windows.Forms.CheckBox();
			this.scripts_button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// title_extra_scripts
			// 
			this.title_extra_scripts.AutoSize = true;
			this.title_extra_scripts.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.title_extra_scripts.Location = new System.Drawing.Point(12, 9);
			this.title_extra_scripts.Name = "title_extra_scripts";
			this.title_extra_scripts.Size = new System.Drawing.Size(212, 29);
			this.title_extra_scripts.TabIndex = 3;
			this.title_extra_scripts.Text = "Scripts to Enable";
			this.title_extra_scripts.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(14, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(286, 15);
			this.label1.TabIndex = 4;
			this.label1.Text = "FHQ Task Tracker will always be enabled by default";
			// 
			// FHQ_marker_patrol_checkbox
			// 
			this.FHQ_marker_patrol_checkbox.AutoSize = true;
			this.FHQ_marker_patrol_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FHQ_marker_patrol_checkbox.Location = new System.Drawing.Point(17, 70);
			this.FHQ_marker_patrol_checkbox.Name = "FHQ_marker_patrol_checkbox";
			this.FHQ_marker_patrol_checkbox.Size = new System.Drawing.Size(160, 24);
			this.FHQ_marker_patrol_checkbox.TabIndex = 12;
			this.FHQ_marker_patrol_checkbox.Text = "FHQ Marker Patrol";
			this.FHQ_marker_patrol_checkbox.UseVisualStyleBackColor = true;
			// 
			// FHQ_safe_add_loadout_checkbox
			// 
			this.FHQ_safe_add_loadout_checkbox.AutoSize = true;
			this.FHQ_safe_add_loadout_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FHQ_safe_add_loadout_checkbox.Location = new System.Drawing.Point(17, 100);
			this.FHQ_safe_add_loadout_checkbox.Name = "FHQ_safe_add_loadout_checkbox";
			this.FHQ_safe_add_loadout_checkbox.Size = new System.Drawing.Size(196, 24);
			this.FHQ_safe_add_loadout_checkbox.TabIndex = 13;
			this.FHQ_safe_add_loadout_checkbox.Text = "FHQ Safe Add Loadout";
			this.FHQ_safe_add_loadout_checkbox.UseVisualStyleBackColor = true;
			// 
			// scripts_button
			// 
			this.scripts_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.scripts_button.Location = new System.Drawing.Point(77, 331);
			this.scripts_button.Name = "scripts_button";
			this.scripts_button.Size = new System.Drawing.Size(147, 38);
			this.scripts_button.TabIndex = 14;
			this.scripts_button.Text = "OK";
			this.scripts_button.UseVisualStyleBackColor = true;
			this.scripts_button.Click += new System.EventHandler(this.scripts_button_Click);
			// 
			// Form4_Scripts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(304, 381);
			this.Controls.Add(this.scripts_button);
			this.Controls.Add(this.FHQ_safe_add_loadout_checkbox);
			this.Controls.Add(this.FHQ_marker_patrol_checkbox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.title_extra_scripts);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "Form4_Scripts";
			this.Text = "Form4_Scripts";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label title_extra_scripts;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox FHQ_marker_patrol_checkbox;
		private System.Windows.Forms.CheckBox FHQ_safe_add_loadout_checkbox;
		private System.Windows.Forms.Button scripts_button;
	}
}