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
	public partial class Form6_Briefing : Form
	{
		// Constants
		private const String BRIEFING = "briefing.sqf";
		private const String FOLDER_SCRIPTS = "scripts";

		private String missionDirectory;
		private bool firstItemAdded;

		public Form6_Briefing(String missionDirectory)
		{
			InitializeComponent();
			this.missionDirectory = missionDirectory;
			firstItemAdded = false;
			initializeBriefing();
		}

		private void button_add_Click(object sender, EventArgs e)
		{
			using (System.IO.StreamWriter sw = new System.IO.StreamWriter(System.IO.Path.Combine(this.missionDirectory, FOLDER_SCRIPTS, BRIEFING), true))
			{
				if (String.IsNullOrWhiteSpace(textbox_title.Text))
				{
					MessageBox.Show("ERROR: Briefing Title Cannot be Blank!",
						"Empty Title",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					// Append , after end of briefing description to separate new briefing description
					//	if new briefing description isn't the first item
					if (firstItemAdded)
					{
						sw.WriteLine(",");
						sw.WriteLine("");
					}
					sw.WriteLine("		[\"" + textbox_title.Text.Replace("\"", "\"\"") + "\",");
					sw.Write("			\"" + textbox_description.Text.Replace("\"", "\"\"").Replace(Environment.NewLine, "<br/>").Replace("'\"\" + _htmlcolor + \"\"'", "'\" + _htmlcolor + \"'") + "\"]"); 
					firstItemAdded = true;
				}
			}
		}

		private void button_complete_Click(object sender, EventArgs e)
		{
			using (System.IO.StreamWriter sw = new System.IO.StreamWriter(System.IO.Path.Combine(this.missionDirectory, FOLDER_SCRIPTS, BRIEFING), true))
			{
				sw.WriteLine("");
				sw.WriteLine("");
				sw.WriteLine("] call FHQ_fnc_ttAddBriefing;");
			}
			// Go to Form 7 Briefing Task Page
			this.Hide();
			Form7_Briefing_Task new_form = new Form7_Briefing_Task(this.missionDirectory);
			new_form.ShowDialog();
		}

		private void initializeBriefing()
		{
			using (System.IO.StreamWriter sw = new System.IO.StreamWriter(System.IO.Path.Combine(this.missionDirectory, FOLDER_SCRIPTS, BRIEFING)))
			{
				sw.WriteLine("_color = [\"GUI\", \"BCG_RGB\"] call BIS_fnc_displayColorGet;");
				sw.WriteLine("_htmlcolor = _color call BIS_fnc_colorRGBAtoHTML;");
				sw.WriteLine("");
				sw.WriteLine("#define __color_link(marker, text) \"<font color='\" + _htmlcolor + \"'><marker name='\" + marker + \"'>\" + text + \"</marker></font>\"");
				sw.WriteLine("#define __color_text(text) \"<font color='\" + _htmlcolor + \"'>\" + text + \"</font>\"");
				sw.WriteLine("#define __color_clink(colour, marker, text) \"<font color='\" + colour + \"'><marker name='\" + marker + \"'>\" + text + \"</marker></font>\"");
				sw.WriteLine("#define __color_ctext(colour, text) \"<font color='\" + colour + \"'>\" + text + \"</font>\"");
				sw.WriteLine("");
				sw.WriteLine("/* Briefing");
				sw.WriteLine(" * The briefing can be defined by calling FHQ_TT_addBriefing.");
				sw.WriteLine(" * The array is built like this.");
				sw.WriteLine(" * The first element should be a filter (side, group, faction, or a piece of script)");
				sw.WriteLine(" * This is followed by pairs of strings, a head line, and an actual text.");
				sw.WriteLine(" * Briefings are added in the order in which they appear for any unit that matches");
				sw.WriteLine(" * the last filter.");
				sw.WriteLine(" */");
				sw.WriteLine("[");
				sw.WriteLine("	{true}, ");
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
			if (containsAnyQuotes()) 
			{
				displayMarkerNameContainQuotes();
			}
			else 
			{
				textbox_description.Text += "<font color='\" + " + "_htmlcolor" + " + \"'><marker name='"+ custom_marker.Text + "'>" + custom_text.Text.Replace("\"", "\"\"") + "</marker></font>";
			}
		}

		// Create custom color marker link in description
		private void button_clink_Click(object sender, EventArgs e)
		{
			if (!Helper.isColorHexidecimal(custom_color.Text))
			{
				displayHexidecimalColorError();
			}
			else if (containsAnyQuotes()) 
			{
				displayMarkerNameContainQuotes();
			}
			else
			{
				textbox_description.Text += "<font color='" + custom_color.Text + "'><marker name='" + custom_marker.Text + "'>" + custom_text.Text.Replace("\"", "\"\"") + "</marker></font>";
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
		private void displayMarkerNameContainQuotes()
		{
			MessageBox.Show("ERROR: Marker name must not contain any quotes whether they're ' or \".",
					"Quotes not Allowed",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		// Return true if marker name contains quotes or double quotes
		private bool containsAnyQuotes()
		{
			return custom_marker.Text.Contains("'") || custom_marker.Text.Contains("\"");
		}
	}
}
