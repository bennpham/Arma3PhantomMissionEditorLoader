using System;
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
	public partial class Form7_Briefing_Task : Form
	{
		private ColorDialog colorDiaglog;

		// Constants
		private const String BRIEFING = "briefing.sqf";
		private const String FOLDER_SCRIPTS = "scripts";

		private String missionDirectory;
		private bool firstItemAdded;
		private bool firstAssignedTaskStateFound;
		private HashSet<string> taskNames;

		public Form7_Briefing_Task(String missionDirectory)
		{
			InitializeComponent();
			this.missionDirectory = missionDirectory;
			firstItemAdded = false;
			firstAssignedTaskStateFound = false;
			taskNames = new HashSet<string>();

			// Setup color dialog
			this.colorDiaglog = new ColorDialog();

			// Set taskState combobox to default to "Created" as the first item
			comboBox_taskState.SelectedIndex = 0;

			// Initialize opening array for creating tasks
			initializeTask();
		}

		private void button_add_Click(object sender, EventArgs e)
		{
			using (System.IO.StreamWriter sw = new System.IO.StreamWriter(System.IO.Path.Combine(this.missionDirectory, FOLDER_SCRIPTS, BRIEFING), true))
			{
				if (String.IsNullOrWhiteSpace(textbox_taskname.Text))
				{
					MessageBox.Show("ERROR: Task Name Cannot be Blank!", "Empty Task Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else if (containsAnyQuotes(textbox_taskname.Text))
				{
					displayErrorContainQuotes("Task name");
				}
				else if (String.IsNullOrWhiteSpace(textbox_tasktitle.Text))
				{
					MessageBox.Show("ERROR: Task Title Cannot be Blank!", "Empty Task Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else if (containsAnyQuotes(textbox_taskmarkername.Text))
				{
					displayErrorContainQuotes("Task Marker Name");
				}
				else if (firstAssignedTaskStateFound && comboBox_taskState.Text.Equals("assigned"))
				{
					MessageBox.Show("ERROR: Only 1 task state can start off as Assigned!", "Only 1 Task Allow Assigned", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else if (this.taskNames.Contains(textbox_taskname.Text.Trim().ToLower()))
				{
					MessageBox.Show("ERROR: " + textbox_taskname.Text.Trim().ToLower() + " has already been defined!", "Task Name Already Defined", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					// Mark first assigned task state"assigned" found if task state is set to "assigned"
					if (comboBox_taskState.Text.Equals("assigned"))
					{
						firstAssignedTaskStateFound = true;
					}
					// Append , after end of task description to separate new task description
					//	if new task description isn't the first item
					if (firstItemAdded)
					{
						sw.WriteLine(",");
					}

					// Write Task to briefing.sqf
					sw.WriteLine("    	[\"" + textbox_taskname.Text + "\", // Task name");
					sw.WriteLine("		 \"" + textbox_description.Text.Replace("\"", "\"\"").Replace(Environment.NewLine, "<br/>").Replace("'\"\" + _htmlcolor + \"\"'", "'\" + _htmlcolor + \"'") + "\", // Task Description");
					sw.WriteLine("		 \"" + textbox_tasktitle.Text.Replace("\"", "\"\"") + "\", // Task title in briefing");
					sw.WriteLine("		 \"" + textbox_waypoint_text.Text.Replace("\"", "\"\"") + "\", // Waypoint text");
					sw.WriteLine("		 getmarkerpos \"" + textbox_taskmarkername.Text + "\", // Optional: Position or object");
					sw.WriteLine("		 \"" + comboBox_taskState.Text + "\", // Optional: Task State Status");
					sw.WriteLine("		 \"" + comboBox_taskType.Text + "\" // Optional: Task Type");
					sw.Write("        ]");

					taskNames.Add(textbox_taskname.Text.Trim().ToLower());
					firstItemAdded = true;
				}
			}
		}

		private void button_complete_Click(object sender, EventArgs e)
		{
			using (System.IO.StreamWriter sw = new System.IO.StreamWriter(System.IO.Path.Combine(this.missionDirectory, FOLDER_SCRIPTS, BRIEFING), true))
			{
				sw.WriteLine("");
				sw.WriteLine("] call FHQ_fnc_ttAddTasks;");
			}
			Environment.Exit(0);
		}

		private void initializeTask()
		{
			using (System.IO.StreamWriter sw = new System.IO.StreamWriter(System.IO.Path.Combine(this.missionDirectory, FOLDER_SCRIPTS, BRIEFING), true))
			{
				sw.WriteLine("");
				sw.WriteLine("[");
				sw.WriteLine("	{true},");
			}
		}

		// Create font color tag default in description
		private void button_color_text_Click(object sender, EventArgs e)
		{
			textbox_description.Text += "<font color='\" + " + "_htmlcolor" + " + \"'>" + custom_text.Text.Replace("\"", "\"\"") + "</font>";
		}

		// Create font color tag custom color in description
		private void button_color_ctext_Click(object sender, EventArgs e)
		{
			if (Helper.isColorHexidecimal(custom_color.Text))
			{
				textbox_description.Text += "<font color='" + custom_color.Text + "'>" + custom_text.Text.Replace("\"", "\"\"") + "</font>";
			}
			else
			{
				displayHexidecimalColorError();
			}
		}

		// Create default color marker link in description
		private void button_link_Click(object sender, EventArgs e)
		{
			if (containsAnyQuotes(custom_marker.Text))
			{
				displayErrorContainQuotes("Marker name");
			}
			else
			{
				textbox_description.Text += "<font color='\" + " + "_htmlcolor" + " + \"'><marker name='" + custom_marker.Text + "'>" + custom_text.Text.Replace("\"", "\"\"") + "</marker></font>";
			}
		}

		// Create custom color marker link in description
		private void button_clink_Click(object sender, EventArgs e)
		{
			if (!Helper.isColorHexidecimal(custom_color.Text))
			{
				displayHexidecimalColorError();
			}
			else if (containsAnyQuotes(custom_marker.Text))
			{
				displayErrorContainQuotes("Marker name");
			}
			else
			{
				textbox_description.Text += "<font color='" + custom_color.Text + "'><marker name='" + custom_marker.Text + "'>" + custom_text.Text.Replace("\"", "\"\"") + "</marker></font>";
			}
		}

		private void colorButton_Click(object sender, EventArgs e)
		{
			DialogResult result = this.colorDiaglog.ShowDialog();
			colorButton.BackColor = this.colorDiaglog.Color;
			custom_color.Text = Helper.hexConverter(this.colorDiaglog.Color);
		}

		private void custom_color_TextChanged(object sender, EventArgs e)
		{
			if (Helper.isColorHexidecimal(custom_color.Text))
			{
				colorButton.BackColor = ColorTranslator.FromHtml(custom_color.Text);
			}
		}

		/*======================
		 * Helper functions
		 =======================*/
		// Return error message pop-up if color input isn't proper hexidecimal
		private void displayHexidecimalColorError()
		{
			MessageBox.Show("ERROR: Color in hexidecimal format is required! Please input a string like #FF0000 to define the color.",
				   "Invalid Color",
				   MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		// Return error message pop-up for marker name containing quotes
		private void displayErrorContainQuotes(string text)
		{
			MessageBox.Show("ERROR: " + text + " must not contain any quotes whether they're ' or \".",
					"Quotes not Allowed",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		// Return true if the following item contains quotes or double quotes
		private bool containsAnyQuotes(string text)
		{
			return text.Contains("'") || text.Contains("\"");
		}
	}
}
