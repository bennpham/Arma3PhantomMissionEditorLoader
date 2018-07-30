namespace Arma3PhantomMissionEditorLoader
{
	partial class Form3_Description
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
			this.title_description = new System.Windows.Forms.Label();
			this.description_params_checkbox = new System.Windows.Forms.CheckBox();
			this.description_loadout_checkbox = new System.Windows.Forms.CheckBox();
			this.description_button = new System.Windows.Forms.Button();
			this.title_infotext = new System.Windows.Forms.Label();
			this.infotext_title = new System.Windows.Forms.TextBox();
			this.label_created_by = new System.Windows.Forms.Label();
			this.label_datetime = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// title_description
			// 
			this.title_description.AutoSize = true;
			this.title_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.title_description.Location = new System.Drawing.Point(12, 9);
			this.title_description.Name = "title_description";
			this.title_description.Size = new System.Drawing.Size(146, 29);
			this.title_description.TabIndex = 2;
			this.title_description.Text = "Description";
			this.title_description.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// description_params_checkbox
			// 
			this.description_params_checkbox.AutoSize = true;
			this.description_params_checkbox.Checked = true;
			this.description_params_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.description_params_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.description_params_checkbox.Location = new System.Drawing.Point(17, 41);
			this.description_params_checkbox.Name = "description_params_checkbox";
			this.description_params_checkbox.Size = new System.Drawing.Size(314, 24);
			this.description_params_checkbox.TabIndex = 11;
			this.description_params_checkbox.Text = "Description Params (Player Count Scale)";
			this.description_params_checkbox.UseVisualStyleBackColor = true;
			// 
			// description_loadout_checkbox
			// 
			this.description_loadout_checkbox.AutoSize = true;
			this.description_loadout_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.description_loadout_checkbox.Location = new System.Drawing.Point(17, 71);
			this.description_loadout_checkbox.Name = "description_loadout_checkbox";
			this.description_loadout_checkbox.Size = new System.Drawing.Size(306, 24);
			this.description_loadout_checkbox.TabIndex = 12;
			this.description_loadout_checkbox.Text = "Description Loadout (Singleplayer Only)";
			this.description_loadout_checkbox.UseVisualStyleBackColor = true;
			// 
			// description_button
			// 
			this.description_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.description_button.Location = new System.Drawing.Point(176, 331);
			this.description_button.Name = "description_button";
			this.description_button.Size = new System.Drawing.Size(147, 38);
			this.description_button.TabIndex = 13;
			this.description_button.Text = "OK";
			this.description_button.UseVisualStyleBackColor = true;
			this.description_button.Click += new System.EventHandler(this.description_button_Click);
			// 
			// title_infotext
			// 
			this.title_infotext.AutoSize = true;
			this.title_infotext.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.title_infotext.Location = new System.Drawing.Point(12, 127);
			this.title_infotext.Name = "title_infotext";
			this.title_infotext.Size = new System.Drawing.Size(174, 29);
			this.title_infotext.TabIndex = 14;
			this.title_infotext.Text = "Info Text Title";
			this.title_infotext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// infotext_title
			// 
			this.infotext_title.Location = new System.Drawing.Point(12, 203);
			this.infotext_title.Multiline = true;
			this.infotext_title.Name = "infotext_title";
			this.infotext_title.Size = new System.Drawing.Size(440, 75);
			this.infotext_title.TabIndex = 21;
			// 
			// label_created_by
			// 
			this.label_created_by.AutoSize = true;
			this.label_created_by.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_created_by.Location = new System.Drawing.Point(13, 290);
			this.label_created_by.Name = "label_created_by";
			this.label_created_by.Size = new System.Drawing.Size(174, 20);
			this.label_created_by.TabIndex = 22;
			this.label_created_by.Text = "Created By Phantom";
			// 
			// label_datetime
			// 
			this.label_datetime.AutoSize = true;
			this.label_datetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_datetime.Location = new System.Drawing.Point(12, 170);
			this.label_datetime.Name = "label_datetime";
			this.label_datetime.Size = new System.Drawing.Size(199, 20);
			this.label_datetime.TabIndex = 23;
			this.label_datetime.Text = "June 1, 2018 | 12:00:00";
			// 
			// Form3_Description
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(464, 381);
			this.Controls.Add(this.label_datetime);
			this.Controls.Add(this.label_created_by);
			this.Controls.Add(this.infotext_title);
			this.Controls.Add(this.title_infotext);
			this.Controls.Add(this.description_button);
			this.Controls.Add(this.description_loadout_checkbox);
			this.Controls.Add(this.description_params_checkbox);
			this.Controls.Add(this.title_description);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "Form3_Description";
			this.Text = "Arma 3 Phantom Mission Editor Edit Mission.sqm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label title_description;
		private System.Windows.Forms.CheckBox description_params_checkbox;
		private System.Windows.Forms.CheckBox description_loadout_checkbox;
		private System.Windows.Forms.Button description_button;
		private System.Windows.Forms.Label title_infotext;
		private System.Windows.Forms.TextBox infotext_title;
		private System.Windows.Forms.Label label_created_by;
		private System.Windows.Forms.Label label_datetime;
	}
}