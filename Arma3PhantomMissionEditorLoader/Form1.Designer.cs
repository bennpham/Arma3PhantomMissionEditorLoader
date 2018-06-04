namespace Arma3PhantomMissionEditorLoader
{
    partial class Arma3Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arma3Form));
			this.Title = new System.Windows.Forms.Label();
			this.mission_folder_label = new System.Windows.Forms.Label();
			this.directory = new System.Windows.Forms.TextBox();
			this.new_button = new System.Windows.Forms.Button();
			this.directory_button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Title.Location = new System.Drawing.Point(12, 9);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(703, 42);
			this.Title.TabIndex = 0;
			this.Title.Text = "Arma 3 Phantom Mission Editor Loader";
			this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// mission_folder_label
			// 
			this.mission_folder_label.AutoSize = true;
			this.mission_folder_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mission_folder_label.Location = new System.Drawing.Point(12, 75);
			this.mission_folder_label.Name = "mission_folder_label";
			this.mission_folder_label.Size = new System.Drawing.Size(153, 25);
			this.mission_folder_label.TabIndex = 1;
			this.mission_folder_label.Text = "Mission Folder";
			// 
			// directory
			// 
			this.directory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.directory.Location = new System.Drawing.Point(12, 103);
			this.directory.Name = "directory";
			this.directory.ReadOnly = true;
			this.directory.Size = new System.Drawing.Size(649, 29);
			this.directory.TabIndex = 2;
			// 
			// new_button
			// 
			this.new_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.new_button.Location = new System.Drawing.Point(296, 154);
			this.new_button.Name = "new_button";
			this.new_button.Size = new System.Drawing.Size(143, 45);
			this.new_button.TabIndex = 3;
			this.new_button.Text = "NEW";
			this.new_button.UseVisualStyleBackColor = true;
			this.new_button.Click += new System.EventHandler(this.new_button_Click);
			// 
			// directory_button
			// 
			this.directory_button.Image = ((System.Drawing.Image)(resources.GetObject("directory_button.Image")));
			this.directory_button.Location = new System.Drawing.Point(667, 100);
			this.directory_button.Name = "directory_button";
			this.directory_button.Size = new System.Drawing.Size(48, 32);
			this.directory_button.TabIndex = 4;
			this.directory_button.UseVisualStyleBackColor = true;
			this.directory_button.Click += new System.EventHandler(this.directory_button_Click);
			// 
			// Arma3Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(727, 213);
			this.Controls.Add(this.directory_button);
			this.Controls.Add(this.new_button);
			this.Controls.Add(this.directory);
			this.Controls.Add(this.mission_folder_label);
			this.Controls.Add(this.Title);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "Arma3Form";
			this.Text = "Arma 3 Phantom Mission Editor Loader";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label mission_folder_label;
        private System.Windows.Forms.TextBox directory;
        private System.Windows.Forms.Button new_button;
        private System.Windows.Forms.Button directory_button;
    }
}

