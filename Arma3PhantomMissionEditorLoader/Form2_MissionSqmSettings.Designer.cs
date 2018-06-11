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
			this.Title = new System.Windows.Forms.Label();
			this.missionsqm_button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Title.Location = new System.Drawing.Point(12, 9);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(137, 37);
			this.Title.TabIndex = 1;
			this.Title.Text = "General";
			this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// missionsqm_button
			// 
			this.missionsqm_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.missionsqm_button.Location = new System.Drawing.Point(341, 400);
			this.missionsqm_button.Name = "missionsqm_button";
			this.missionsqm_button.Size = new System.Drawing.Size(147, 38);
			this.missionsqm_button.TabIndex = 4;
			this.missionsqm_button.Text = "OK";
			this.missionsqm_button.UseVisualStyleBackColor = true;
			this.missionsqm_button.Click += new System.EventHandler(this.missionsqm_button_Click);
			// 
			// Form2_MissionSqmSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.missionsqm_button);
			this.Controls.Add(this.Title);
			this.Name = "Form2_MissionSqmSettings";
			this.Text = "Form2_MissionSqmSettings";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.Button missionsqm_button;
	}
}