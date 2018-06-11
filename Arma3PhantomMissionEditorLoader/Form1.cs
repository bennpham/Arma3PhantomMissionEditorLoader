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
    public partial class Arma3Form : Form
    {
		private const String ERROR_1_FILE = "ERROR! There should only be 1 unbinarize mission.sqm in your mission folder in order for this program to generate scripts for your mission!";

        public Arma3Form()
        {
            InitializeComponent();
        }

		private void directory_button_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			fbd.Description = "Select the folder of your new and empty Arma 3 mission that contains only the mission.sqm";
			if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				directory.Text = fbd.SelectedPath;
			}
		}

		private void new_button_Click(object sender, EventArgs e)
		{
			// #1 Check to make sure there's only a mission.sqm and its not binarize
			//		Might still work unbinarize, but your mission.sqm might break
			String[] directories = System.IO.Directory.GetFiles(directory.Text);
			if (directories.Length != 1)
			{
				MessageBox.Show(ERROR_1_FILE); 
				return;
			}
			else if (System.IO.Path.GetFileName(directories[0]) != "mission.sqm")
			{
				MessageBox.Show(ERROR_1_FILE);
				return;
			}

			// #2 Setup mission.sqm settings 
			this.Hide();
			Form2_MissionSqmSettings form2_missionsqm = new Form2_MissionSqmSettings();
			if (form2_missionsqm.ShowDialog() == DialogResult.OK)
			{
				form2_missionsqm.missionSQM = directories[0];
			}
		}
	}
}
