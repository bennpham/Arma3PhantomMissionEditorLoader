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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select the folder of your new and empty Arma 3 mission that contains only the mission.sqm";
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show(fbd.SelectedPath);
            }
        }
    }
}
