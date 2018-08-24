namespace Arma3PhantomMissionEditorLoader
{
	partial class Form6_Briefing
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
			this.title_briefing = new System.Windows.Forms.Label();
			this.titleLabel = new System.Windows.Forms.Label();
			this.textbox_title = new System.Windows.Forms.TextBox();
			this.descriptionLabel = new System.Windows.Forms.Label();
			this.textbox_description = new System.Windows.Forms.TextBox();
			this.button_add = new System.Windows.Forms.Button();
			this.button_complete = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// title_briefing
			// 
			this.title_briefing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.title_briefing.AutoSize = true;
			this.title_briefing.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.title_briefing.Location = new System.Drawing.Point(12, 9);
			this.title_briefing.Name = "title_briefing";
			this.title_briefing.Size = new System.Drawing.Size(104, 29);
			this.title_briefing.TabIndex = 5;
			this.title_briefing.Text = "Briefing";
			this.title_briefing.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// titleLabel
			// 
			this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.titleLabel.AutoSize = true;
			this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titleLabel.Location = new System.Drawing.Point(13, 48);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(43, 20);
			this.titleLabel.TabIndex = 6;
			this.titleLabel.Text = "Title";
			this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// textbox_title
			// 
			this.textbox_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textbox_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textbox_title.Location = new System.Drawing.Point(17, 71);
			this.textbox_title.Name = "textbox_title";
			this.textbox_title.Size = new System.Drawing.Size(786, 24);
			this.textbox_title.TabIndex = 9;
			// 
			// descriptionLabel
			// 
			this.descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.descriptionLabel.AutoSize = true;
			this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.descriptionLabel.Location = new System.Drawing.Point(13, 108);
			this.descriptionLabel.Name = "descriptionLabel";
			this.descriptionLabel.Size = new System.Drawing.Size(100, 20);
			this.descriptionLabel.TabIndex = 16;
			this.descriptionLabel.Text = "Description";
			this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// textbox_description
			// 
			this.textbox_description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textbox_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textbox_description.Location = new System.Drawing.Point(17, 131);
			this.textbox_description.Multiline = true;
			this.textbox_description.Name = "textbox_description";
			this.textbox_description.Size = new System.Drawing.Size(786, 254);
			this.textbox_description.TabIndex = 17;
			// 
			// button_add
			// 
			this.button_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_add.Location = new System.Drawing.Point(213, 449);
			this.button_add.Name = "button_add";
			this.button_add.Size = new System.Drawing.Size(174, 40);
			this.button_add.TabIndex = 22;
			this.button_add.Text = "ADD";
			this.button_add.UseVisualStyleBackColor = true;
			this.button_add.Click += new System.EventHandler(this.button_add_Click);
			// 
			// button_complete
			// 
			this.button_complete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.button_complete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_complete.Location = new System.Drawing.Point(436, 449);
			this.button_complete.Name = "button_complete";
			this.button_complete.Size = new System.Drawing.Size(174, 40);
			this.button_complete.TabIndex = 21;
			this.button_complete.Text = "COMPLETE";
			this.button_complete.UseVisualStyleBackColor = true;
			this.button_complete.Click += new System.EventHandler(this.button_complete_Click);
			// 
			// Form6_Briefing
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(824, 501);
			this.Controls.Add(this.button_add);
			this.Controls.Add(this.button_complete);
			this.Controls.Add(this.textbox_description);
			this.Controls.Add(this.descriptionLabel);
			this.Controls.Add(this.textbox_title);
			this.Controls.Add(this.titleLabel);
			this.Controls.Add(this.title_briefing);
			this.Name = "Form6_Briefing";
			this.Text = "Form6_Briefing";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label title_briefing;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.TextBox textbox_title;
		private System.Windows.Forms.Label descriptionLabel;
		private System.Windows.Forms.TextBox textbox_description;
		private System.Windows.Forms.Button button_add;
		private System.Windows.Forms.Button button_complete;
	}
}