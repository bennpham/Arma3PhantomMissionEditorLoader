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
	public partial class Form5_Debrief : Form
	{
		// Constants
		private const String DEBRIEFING = "debriefing.hpp";

		private String missionDirectory;
		private HashSet<String> classNames;

		public Form5_Debrief(String missionDirectory)
		{
			InitializeComponent();
			this.missionDirectory = missionDirectory;
			classNames = new HashSet<string>();
		}

		private void button_add_Click(object sender, EventArgs e)
		{
			System.Text.RegularExpressions.Regex alphanumeric = new System.Text.RegularExpressions.Regex("^[a-zA-Z0-9]*$");

			if (String.IsNullOrWhiteSpace(textbox_classname.Text))
			{
				MessageBox.Show("ERROR: Please fill in a classname!",
					"Empty ClassName",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (!alphanumeric.IsMatch(textbox_classname.Text))
			{
				MessageBox.Show("ERROR: Classnames can only be alphanumeric.",
					"Classname Contains Invalid Characters",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (this.classNames.Contains(textbox_classname.Text.Trim()))
			{
				MessageBox.Show("ERROR: " + textbox_classname.Text + " classname already exists! Please try a different name.", 
					"Classname Already Exist", 
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			// Note: No sanitizing picture Background for now. So either use existing loadscreen.jpg or get the path right.
			else
			{
				this.classNames.Add(textbox_classname.Text.Trim());

				using (System.IO.StreamWriter sw = new System.IO.StreamWriter(System.IO.Path.Combine(this.missionDirectory, DEBRIEFING), true))
				{
					sw.WriteLine("class " + textbox_classname.Text.Trim());
					sw.WriteLine("{");
					sw.WriteLine("	title = \"" + textbox_title.Text.Replace("\"", "\"\"") + "\";");
					sw.WriteLine("	subtitle = \"" + textbox_subtitle.Text.Replace("\"", "\"\"") + "\";");
					sw.WriteLine("	description = \"" + textbox_description.Text.Replace("\"", "\"\"").Replace(Environment.NewLine, " ") + "\";");
					sw.WriteLine("	pictureBackground = \"" + textbox_pictureBackground.Text + "\";");
					sw.WriteLine("}");
					sw.WriteLine("");
				}
			}
		}

		private void button_win_Click(object sender, EventArgs e)
		{
			textbox_classname.Text = "Win";
			textbox_title.Text = "Mission Accomplished";
		}

		private void button_lose_Click(object sender, EventArgs e)
		{
			textbox_classname.Text = "Lose";
			textbox_title.Text = "Mission Failed";
		}

		private void button_complete_Click(object sender, EventArgs e)
		{
			// Go to Form 6 Briefing Page
			this.Hide();
			Form6_Briefing new_form = new Form6_Briefing(this.missionDirectory);
			new_form.ShowDialog();
		}
	}
}
