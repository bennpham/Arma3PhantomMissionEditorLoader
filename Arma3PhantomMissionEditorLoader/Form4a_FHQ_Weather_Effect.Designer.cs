namespace Arma3PhantomMissionEditorLoader
{
	partial class Form4a_FHQ_Weather_Effect
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
			this.title = new System.Windows.Forms.Label();
			this.fog_checkbox = new System.Windows.Forms.CheckBox();
			this.wind_checkbox = new System.Windows.Forms.CheckBox();
			this.sand_checkbox = new System.Windows.Forms.CheckBox();
			this.snow_checkbox = new System.Windows.Forms.CheckBox();
			this.scripts_button = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.fogInterval = new System.Windows.Forms.NumericUpDown();
			this.label_fogInterval = new System.Windows.Forms.Label();
			this.sandInterval = new System.Windows.Forms.NumericUpDown();
			this.label_sandInterval = new System.Windows.Forms.Label();
			this.snowInterval = new System.Windows.Forms.NumericUpDown();
			this.label_snowInterval = new System.Windows.Forms.Label();
			this.windInterval = new System.Windows.Forms.NumericUpDown();
			this.label_windInterval = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.fogInterval)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sandInterval)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.snowInterval)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.windInterval)).BeginInit();
			this.SuspendLayout();
			// 
			// title
			// 
			this.title.AutoSize = true;
			this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.title.Location = new System.Drawing.Point(12, 9);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(246, 29);
			this.title.TabIndex = 4;
			this.title.Text = "FHQ Weather Script";
			this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// fog_checkbox
			// 
			this.fog_checkbox.AutoSize = true;
			this.fog_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fog_checkbox.Location = new System.Drawing.Point(17, 58);
			this.fog_checkbox.Name = "fog_checkbox";
			this.fog_checkbox.Size = new System.Drawing.Size(56, 24);
			this.fog_checkbox.TabIndex = 16;
			this.fog_checkbox.Text = "Fog";
			this.fog_checkbox.UseVisualStyleBackColor = true;
			// 
			// wind_checkbox
			// 
			this.wind_checkbox.AutoSize = true;
			this.wind_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.wind_checkbox.Location = new System.Drawing.Point(17, 88);
			this.wind_checkbox.Name = "wind_checkbox";
			this.wind_checkbox.Size = new System.Drawing.Size(64, 24);
			this.wind_checkbox.TabIndex = 17;
			this.wind_checkbox.Text = "Wind";
			this.wind_checkbox.UseVisualStyleBackColor = true;
			// 
			// sand_checkbox
			// 
			this.sand_checkbox.AutoSize = true;
			this.sand_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sand_checkbox.Location = new System.Drawing.Point(202, 58);
			this.sand_checkbox.Name = "sand_checkbox";
			this.sand_checkbox.Size = new System.Drawing.Size(66, 24);
			this.sand_checkbox.TabIndex = 18;
			this.sand_checkbox.Text = "Sand";
			this.sand_checkbox.UseVisualStyleBackColor = true;
			// 
			// snow_checkbox
			// 
			this.snow_checkbox.AutoSize = true;
			this.snow_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.snow_checkbox.Location = new System.Drawing.Point(202, 88);
			this.snow_checkbox.Name = "snow_checkbox";
			this.snow_checkbox.Size = new System.Drawing.Size(68, 24);
			this.snow_checkbox.TabIndex = 19;
			this.snow_checkbox.Text = "Snow";
			this.snow_checkbox.UseVisualStyleBackColor = true;
			// 
			// scripts_button
			// 
			this.scripts_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.scripts_button.Location = new System.Drawing.Point(88, 361);
			this.scripts_button.Name = "scripts_button";
			this.scripts_button.Size = new System.Drawing.Size(147, 38);
			this.scripts_button.TabIndex = 20;
			this.scripts_button.Text = "OK";
			this.scripts_button.UseVisualStyleBackColor = true;
			this.scripts_button.Click += new System.EventHandler(this.scripts_button_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 125);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(283, 45);
			this.label1.TabIndex = 21;
			this.label1.Text = "Intervals are time in seconds between each effect.  \r\nThe lower the number, the m" +
    "ore frequency you\'ll \r\nsee in the effects.";
			// 
			// fogInterval
			// 
			this.fogInterval.DecimalPlaces = 10;
			this.fogInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fogInterval.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
			this.fogInterval.Location = new System.Drawing.Point(125, 194);
			this.fogInterval.Name = "fogInterval";
			this.fogInterval.Size = new System.Drawing.Size(170, 26);
			this.fogInterval.TabIndex = 49;
			// 
			// label_fogInterval
			// 
			this.label_fogInterval.AutoSize = true;
			this.label_fogInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_fogInterval.Location = new System.Drawing.Point(26, 196);
			this.label_fogInterval.Name = "label_fogInterval";
			this.label_fogInterval.Size = new System.Drawing.Size(93, 20);
			this.label_fogInterval.TabIndex = 48;
			this.label_fogInterval.Text = "Fog Interval";
			// 
			// sandInterval
			// 
			this.sandInterval.DecimalPlaces = 10;
			this.sandInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sandInterval.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
			this.sandInterval.Location = new System.Drawing.Point(123, 266);
			this.sandInterval.Name = "sandInterval";
			this.sandInterval.Size = new System.Drawing.Size(172, 26);
			this.sandInterval.TabIndex = 51;
			// 
			// label_sandInterval
			// 
			this.label_sandInterval.AutoSize = true;
			this.label_sandInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_sandInterval.Location = new System.Drawing.Point(14, 268);
			this.label_sandInterval.Name = "label_sandInterval";
			this.label_sandInterval.Size = new System.Drawing.Size(103, 20);
			this.label_sandInterval.TabIndex = 50;
			this.label_sandInterval.Text = "Sand Interval";
			// 
			// snowInterval
			// 
			this.snowInterval.DecimalPlaces = 10;
			this.snowInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.snowInterval.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
			this.snowInterval.Location = new System.Drawing.Point(123, 298);
			this.snowInterval.Name = "snowInterval";
			this.snowInterval.Size = new System.Drawing.Size(172, 26);
			this.snowInterval.TabIndex = 55;
			// 
			// label_snowInterval
			// 
			this.label_snowInterval.AutoSize = true;
			this.label_snowInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_snowInterval.Location = new System.Drawing.Point(14, 300);
			this.label_snowInterval.Name = "label_snowInterval";
			this.label_snowInterval.Size = new System.Drawing.Size(105, 20);
			this.label_snowInterval.TabIndex = 54;
			this.label_snowInterval.Text = "Snow Interval";
			// 
			// windInterval
			// 
			this.windInterval.DecimalPlaces = 10;
			this.windInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.windInterval.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
			this.windInterval.Location = new System.Drawing.Point(125, 226);
			this.windInterval.Name = "windInterval";
			this.windInterval.Size = new System.Drawing.Size(170, 26);
			this.windInterval.TabIndex = 53;
			// 
			// label_windInterval
			// 
			this.label_windInterval.AutoSize = true;
			this.label_windInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_windInterval.Location = new System.Drawing.Point(18, 226);
			this.label_windInterval.Name = "label_windInterval";
			this.label_windInterval.Size = new System.Drawing.Size(101, 20);
			this.label_windInterval.TabIndex = 52;
			this.label_windInterval.Text = "Wind Interval";
			// 
			// Form4a_FHQ_Weather_Effect
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(312, 411);
			this.Controls.Add(this.snowInterval);
			this.Controls.Add(this.label_snowInterval);
			this.Controls.Add(this.windInterval);
			this.Controls.Add(this.label_windInterval);
			this.Controls.Add(this.sandInterval);
			this.Controls.Add(this.label_sandInterval);
			this.Controls.Add(this.fogInterval);
			this.Controls.Add(this.label_fogInterval);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.scripts_button);
			this.Controls.Add(this.snow_checkbox);
			this.Controls.Add(this.sand_checkbox);
			this.Controls.Add(this.wind_checkbox);
			this.Controls.Add(this.fog_checkbox);
			this.Controls.Add(this.title);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MinimizeBox = false;
			this.Name = "Form4a_FHQ_Weather_Effect";
			this.Text = "Form4a_FHQ_Weather_Effect";
			((System.ComponentModel.ISupportInitialize)(this.fogInterval)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sandInterval)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.snowInterval)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.windInterval)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label title;
		private System.Windows.Forms.CheckBox fog_checkbox;
		private System.Windows.Forms.CheckBox wind_checkbox;
		private System.Windows.Forms.CheckBox sand_checkbox;
		private System.Windows.Forms.CheckBox snow_checkbox;
		private System.Windows.Forms.Button scripts_button;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown fogInterval;
		private System.Windows.Forms.Label label_fogInterval;
		private System.Windows.Forms.NumericUpDown sandInterval;
		private System.Windows.Forms.Label label_sandInterval;
		private System.Windows.Forms.NumericUpDown snowInterval;
		private System.Windows.Forms.Label label_snowInterval;
		private System.Windows.Forms.NumericUpDown windInterval;
		private System.Windows.Forms.Label label_windInterval;
	}
}