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
	public partial class Form4a_TAW_View_Distance : Form
	{
		private String missionDirectory;
		private Dictionary<String, Object> parameters;

		public Form4a_TAW_View_Distance(String missionDirectory, Dictionary<String, Object> parameters)
		{
			InitializeComponent();
			this.missionDirectory = missionDirectory;
			this.parameters = parameters;
		}

		private void scripts_button_Click(object sender, EventArgs e)
		{
			String init_TAW_View_Distance = this.parameters["init_TAW_View_Distance"].ToString();
			// Setup parameters
			if (disableNone_checkbox.Checked)
			{
				init_TAW_View_Distance += "tawvd_disablenone = true;\n";
			}
			if (enableMaxRange_checkBox.Checked)
			{
				init_TAW_View_Distance += "tawvd_maxRange = " + maxRange.Value.ToString() + ";\n";
			}
			this.parameters["init_TAW_View_Distance"] = init_TAW_View_Distance;

			// Go to Form 5
			this.Hide();
			Form5_Debrief new_form = new Form5_Debrief(this.missionDirectory, this.parameters);
			new_form.ShowDialog();
		}
	}
}
