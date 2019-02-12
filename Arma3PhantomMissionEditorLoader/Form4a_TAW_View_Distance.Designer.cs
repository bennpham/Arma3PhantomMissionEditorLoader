namespace Arma3PhantomMissionEditorLoader
{
	partial class Form4a_TAW_View_Distance
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
			this.maxRange = new System.Windows.Forms.NumericUpDown();
			this.label_maxRange = new System.Windows.Forms.Label();
			this.disableNone_checkbox = new System.Windows.Forms.CheckBox();
			this.title = new System.Windows.Forms.Label();
			this.enableMaxRange_checkBox = new System.Windows.Forms.CheckBox();
			this.scripts_button = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.maxRange)).BeginInit();
			this.SuspendLayout();
			// 
			// maxRange
			// 
			this.maxRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.maxRange.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.maxRange.Location = new System.Drawing.Point(115, 133);
			this.maxRange.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
			this.maxRange.Name = "maxRange";
			this.maxRange.Size = new System.Drawing.Size(170, 26);
			this.maxRange.TabIndex = 53;
			// 
			// label_maxRange
			// 
			this.label_maxRange.AutoSize = true;
			this.label_maxRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_maxRange.Location = new System.Drawing.Point(16, 135);
			this.label_maxRange.Name = "label_maxRange";
			this.label_maxRange.Size = new System.Drawing.Size(90, 20);
			this.label_maxRange.TabIndex = 52;
			this.label_maxRange.Text = "Max Range";
			// 
			// disableNone_checkbox
			// 
			this.disableNone_checkbox.AutoSize = true;
			this.disableNone_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.disableNone_checkbox.Location = new System.Drawing.Point(17, 58);
			this.disableNone_checkbox.Name = "disableNone_checkbox";
			this.disableNone_checkbox.Size = new System.Drawing.Size(231, 24);
			this.disableNone_checkbox.TabIndex = 51;
			this.disableNone_checkbox.Text = "Disable Grass Option  \'None\'";
			this.disableNone_checkbox.UseVisualStyleBackColor = true;
			// 
			// title
			// 
			this.title.AutoSize = true;
			this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.title.Location = new System.Drawing.Point(12, 9);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(241, 29);
			this.title.TabIndex = 50;
			this.title.Text = "TAW View Distance";
			this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// enableMaxRange_checkBox
			// 
			this.enableMaxRange_checkBox.AutoSize = true;
			this.enableMaxRange_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.enableMaxRange_checkBox.Location = new System.Drawing.Point(17, 88);
			this.enableMaxRange_checkBox.Name = "enableMaxRange_checkBox";
			this.enableMaxRange_checkBox.Size = new System.Drawing.Size(268, 24);
			this.enableMaxRange_checkBox.TabIndex = 54;
			this.enableMaxRange_checkBox.Text = "Enable View Distance Max Range";
			this.enableMaxRange_checkBox.UseVisualStyleBackColor = true;
			// 
			// scripts_button
			// 
			this.scripts_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.scripts_button.Location = new System.Drawing.Point(101, 181);
			this.scripts_button.Name = "scripts_button";
			this.scripts_button.Size = new System.Drawing.Size(147, 38);
			this.scripts_button.TabIndex = 55;
			this.scripts_button.Text = "OK";
			this.scripts_button.UseVisualStyleBackColor = true;
			this.scripts_button.Click += new System.EventHandler(this.scripts_button_Click);
			// 
			// Form4a_TAW_View_Distance
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(344, 231);
			this.Controls.Add(this.scripts_button);
			this.Controls.Add(this.enableMaxRange_checkBox);
			this.Controls.Add(this.maxRange);
			this.Controls.Add(this.label_maxRange);
			this.Controls.Add(this.disableNone_checkbox);
			this.Controls.Add(this.title);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "Form4a_TAW_View_Distance";
			this.Text = "Form4a_TAW_View_Distance";
			((System.ComponentModel.ISupportInitialize)(this.maxRange)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown maxRange;
		private System.Windows.Forms.Label label_maxRange;
		private System.Windows.Forms.CheckBox disableNone_checkbox;
		private System.Windows.Forms.Label title;
		private System.Windows.Forms.CheckBox enableMaxRange_checkBox;
		private System.Windows.Forms.Button scripts_button;
	}
}