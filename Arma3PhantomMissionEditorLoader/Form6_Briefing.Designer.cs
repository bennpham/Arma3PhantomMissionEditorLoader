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
			this.label_text = new System.Windows.Forms.Label();
			this.custom_text = new System.Windows.Forms.TextBox();
			this.label_custom_color = new System.Windows.Forms.Label();
			this.custom_color = new System.Windows.Forms.TextBox();
			this.label_custom_marker = new System.Windows.Forms.Label();
			this.custom_marker = new System.Windows.Forms.TextBox();
			this.button_color_text = new System.Windows.Forms.Button();
			this.button_color_ctext = new System.Windows.Forms.Button();
			this.button_link = new System.Windows.Forms.Button();
			this.button_clink = new System.Windows.Forms.Button();
			this.colorButton = new System.Windows.Forms.Button();
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
			this.textbox_description.Size = new System.Drawing.Size(786, 280);
			this.textbox_description.TabIndex = 17;
			// 
			// button_add
			// 
			this.button_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_add.Location = new System.Drawing.Point(213, 549);
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
			this.button_complete.Location = new System.Drawing.Point(436, 549);
			this.button_complete.Name = "button_complete";
			this.button_complete.Size = new System.Drawing.Size(174, 40);
			this.button_complete.TabIndex = 21;
			this.button_complete.Text = "COMPLETE";
			this.button_complete.UseVisualStyleBackColor = true;
			this.button_complete.Click += new System.EventHandler(this.button_complete_Click);
			// 
			// label_text
			// 
			this.label_text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label_text.AutoSize = true;
			this.label_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_text.Location = new System.Drawing.Point(16, 425);
			this.label_text.Name = "label_text";
			this.label_text.Size = new System.Drawing.Size(43, 20);
			this.label_text.TabIndex = 23;
			this.label_text.Text = "Text";
			this.label_text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// custom_text
			// 
			this.custom_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.custom_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.custom_text.Location = new System.Drawing.Point(65, 423);
			this.custom_text.Name = "custom_text";
			this.custom_text.Size = new System.Drawing.Size(738, 24);
			this.custom_text.TabIndex = 24;
			// 
			// label_custom_color
			// 
			this.label_custom_color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label_custom_color.AutoSize = true;
			this.label_custom_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_custom_color.Location = new System.Drawing.Point(8, 461);
			this.label_custom_color.Name = "label_custom_color";
			this.label_custom_color.Size = new System.Drawing.Size(51, 20);
			this.label_custom_color.TabIndex = 25;
			this.label_custom_color.Text = "Color";
			this.label_custom_color.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// custom_color
			// 
			this.custom_color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.custom_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.custom_color.Location = new System.Drawing.Point(65, 459);
			this.custom_color.Name = "custom_color";
			this.custom_color.Size = new System.Drawing.Size(94, 24);
			this.custom_color.TabIndex = 26;
			// 
			// label_custom_marker
			// 
			this.label_custom_marker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label_custom_marker.AutoSize = true;
			this.label_custom_marker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_custom_marker.Location = new System.Drawing.Point(223, 459);
			this.label_custom_marker.Name = "label_custom_marker";
			this.label_custom_marker.Size = new System.Drawing.Size(64, 20);
			this.label_custom_marker.TabIndex = 27;
			this.label_custom_marker.Text = "Marker";
			this.label_custom_marker.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// custom_marker
			// 
			this.custom_marker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.custom_marker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.custom_marker.Location = new System.Drawing.Point(293, 459);
			this.custom_marker.Name = "custom_marker";
			this.custom_marker.Size = new System.Drawing.Size(510, 24);
			this.custom_marker.TabIndex = 28;
			// 
			// button_color_text
			// 
			this.button_color_text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_color_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_color_text.Location = new System.Drawing.Point(12, 499);
			this.button_color_text.Name = "button_color_text";
			this.button_color_text.Size = new System.Drawing.Size(212, 29);
			this.button_color_text.TabIndex = 29;
			this.button_color_text.Text = "Create Default Color Text";
			this.button_color_text.UseVisualStyleBackColor = true;
			this.button_color_text.Click += new System.EventHandler(this.button_color_text_Click);
			// 
			// button_color_ctext
			// 
			this.button_color_ctext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_color_ctext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_color_ctext.Location = new System.Drawing.Point(240, 499);
			this.button_color_ctext.Name = "button_color_ctext";
			this.button_color_ctext.Size = new System.Drawing.Size(174, 29);
			this.button_color_ctext.TabIndex = 30;
			this.button_color_ctext.Text = "Create Color Text";
			this.button_color_ctext.UseVisualStyleBackColor = true;
			this.button_color_ctext.Click += new System.EventHandler(this.button_color_ctext_Click);
			// 
			// button_link
			// 
			this.button_link.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_link.Location = new System.Drawing.Point(427, 499);
			this.button_link.Name = "button_link";
			this.button_link.Size = new System.Drawing.Size(191, 29);
			this.button_link.TabIndex = 31;
			this.button_link.Text = "Create Default Marker";
			this.button_link.UseVisualStyleBackColor = true;
			this.button_link.Click += new System.EventHandler(this.button_link_Click);
			// 
			// button_clink
			// 
			this.button_clink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_clink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_clink.Location = new System.Drawing.Point(633, 499);
			this.button_clink.Name = "button_clink";
			this.button_clink.Size = new System.Drawing.Size(170, 29);
			this.button_clink.TabIndex = 32;
			this.button_clink.Text = "Create Color Marker";
			this.button_clink.UseVisualStyleBackColor = true;
			this.button_clink.Click += new System.EventHandler(this.button_clink_Click);
			// 
			// colorButton
			// 
			this.colorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.colorButton.Location = new System.Drawing.Point(171, 460);
			this.colorButton.Name = "colorButton";
			this.colorButton.Size = new System.Drawing.Size(26, 23);
			this.colorButton.TabIndex = 53;
			this.colorButton.UseVisualStyleBackColor = true;
			this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
			// 
			// Form6_Briefing
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(824, 601);
			this.Controls.Add(this.colorButton);
			this.Controls.Add(this.button_clink);
			this.Controls.Add(this.button_link);
			this.Controls.Add(this.button_color_ctext);
			this.Controls.Add(this.button_color_text);
			this.Controls.Add(this.custom_marker);
			this.Controls.Add(this.label_custom_marker);
			this.Controls.Add(this.custom_color);
			this.Controls.Add(this.label_custom_color);
			this.Controls.Add(this.custom_text);
			this.Controls.Add(this.label_text);
			this.Controls.Add(this.button_add);
			this.Controls.Add(this.button_complete);
			this.Controls.Add(this.textbox_description);
			this.Controls.Add(this.descriptionLabel);
			this.Controls.Add(this.textbox_title);
			this.Controls.Add(this.titleLabel);
			this.Controls.Add(this.title_briefing);
			this.MinimumSize = new System.Drawing.Size(840, 640);
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
		private System.Windows.Forms.Label label_text;
		private System.Windows.Forms.TextBox custom_text;
		private System.Windows.Forms.Label label_custom_color;
		private System.Windows.Forms.TextBox custom_color;
		private System.Windows.Forms.Label label_custom_marker;
		private System.Windows.Forms.TextBox custom_marker;
		private System.Windows.Forms.Button button_color_text;
		private System.Windows.Forms.Button button_color_ctext;
		private System.Windows.Forms.Button button_link;
		private System.Windows.Forms.Button button_clink;
		private System.Windows.Forms.Button colorButton;
	}
}